using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.Tray;
using Integradora.ERP.Winthor.Domain;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Tray
{
    class Receber : IProcessIntegration
    {
        public Integradora.ECommerce.Tray.Integracao LojaECommerce { get; set; }
        public PedidoWeb PedidoForcaVenda { get; set; }

        public Receber()
        {
            LojaECommerce = new ECommerce.Tray.Integracao();
            PedidoForcaVenda = new PedidoWeb();
        }
        public void Process(Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            ObterPedidosVenda();
        }

        private void ObterPedidosVenda()
        {
            //            TrayPedido pedido = LojaECommerce.ObterPedido("13770");
            //            Biblioteca.Tools.JSON.Export(pedido, "13770");
            //            string text = pedido.Order.id;
            //            
            //            TrayPedidoPagamento PagamentoPedido = LojaECommerce.ListarPedidosPagto("11914");
            //            text = PagamentoPedido.Payment.modified;
            try
            {
                TrayListaPedidos ListaPedidos = null;
                //Obtendo a lista de pedidos
                ListaPedidos = LojaECommerce.ListarPedidos("A ENVIAR");
                //Exportar o resultado da lista de pedidos para arquivos json
                if (ListaPedidos != null)
                {
                    ProcessarListaPedidos(ListaPedidos);
                }

                //Obtendo a lista de pedidos
                ListaPedidos = LojaECommerce.ListarPedidos("A ENVIAR TRAYCHECKOUT");
                //Exportar o resultado da lista de pedidos para arquivos json
                if (ListaPedidos != null)
                {
                    ProcessarListaPedidos(ListaPedidos);
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                                     , "ObterPedidosVenda"
                                     , "Erro ao listar pedidos: " + ex.ToString()
                                     );
            }
        }

        private void ProcessarListaPedidos(TrayListaPedidos ListaPedidos)
        {
            try
            {
                Biblioteca.Tools.JSON.Export(ListaPedidos, "ListaPedidos.");
                //Percorrendo a lista de pedidos encontrada
                foreach (var pedidoTray in ListaPedidos.Orders)
                {   //Obtendo o pedido da lista
                    TrayPedido pedido = LojaECommerce.ObterPedido(pedidoTray.Order.id);
                    //Verificando se carregou o pedido
                    if (pedido != null)
                    {   //Exportando pedido para arquivo Json
                        Biblioteca.Tools.JSON.Export(pedido, "pedido_" + pedidoTray.Order.id);
                        //Verificando se o pedido já existe na base do Winthor
                        bool sucesso = (PedidoWeb.PedidoExiste(pedido.Order.id));

                        if (!sucesso)
                        {
                            //Importando o pedido da lista
                            sucesso = ImportarPedido(pedido);
                        }

                        if (sucesso)
                        {
                            sucesso = ExecutarIntegradora(PedidoForcaVenda);
                        }
                        //Verificando se retornou sucesso
                        if (sucesso)
                        {  //Atualizando o status do pedido  
                            AtualizarStatus(pedido);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                             , "ProcessarListaPedidos"
                             , "Erro ao processar listar pedidos: " + ex.ToString()
                             );
            }
        }

        private void AtualizarStatus(TrayPedido pedido)
        {
            string status = "IMPORTADO WINTHOR"; //SOLICITADO PELO HUMBERTO - 07/08/2017
            if (pedido.Order.point_sale.ToUpper() == "MERCADO LIVRE")
            {
                status = "AGUARDANDO ENVIO MERCADO LIVRE";
            }
            //Marcar pedido como processado
            LojaECommerce.MudarStatus(pedido.Order.id, status);
        }

        private bool ImportarPedido(TrayPedido ecommerce)
        {
            //Iniciando transação
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    #region Cliente
                    //Validando o cliente
                    TrayCliente cliente = LojaECommerce.ObterCliente(ecommerce.Order.customer_id);
                    //Exportando dados do cliente para arquivo JSON
                    Biblioteca.Tools.JSON.Export(cliente, "cliente_" + ecommerce.Order.customer_id.ToString() + ".json");
                    //Obtendo o CNPJ e CPF
                    string cnpjcpf = string.IsNullOrEmpty(cliente.Customer.cpf) ? cliente.Customer.cnpj : cliente.Customer.cpf;
                    cnpjcpf = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(cnpjcpf);
                    //Obtendo o cliente através do CNPJ/CPF
                    if (!PedidoForcaVenda.ClienteExiste(string.Format("DTEXCLUSAO IS NULL AND CGCENT = '{0}'", cnpjcpf)))
                    {
                        GravarCliente(cliente, cnpjcpf);
                    }
                    //Cliente não encontrado
                    if (PedidoForcaVenda.Cliente == null)
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                                             , "ImportarPedido"
                                             , string.Format("Cliente não localizado: pedido {0} - CNPJ/CPF {1}", ecommerce.Order.id, cnpjcpf)
                                             );
                        return false;
                    }
                    #endregion

                    #region Cabeçalho do pedido
                    //Inicializando o pedido
                    PedidoForcaVenda.PedidoInicializar();
                    PedidoForcaVenda.Cabecalho.Numpedcli = ecommerce.Order.id;
                    PedidoForcaVenda.Cabecalho.Numpedrca = Convert.ToDecimal(ecommerce.Order.id);
                    PedidoForcaVenda.Cabecalho.Numpedweb = PedidoForcaVenda.Cabecalho.Numpedrca;

                    PedidoForcaVenda.Cabecalho.Data = Convert.ToDateTime(ecommerce.Order.date);
                    PedidoForcaVenda.Cabecalho.Codusur = Biblioteca.Dictionaries.Settings.CodRCA();
                    PedidoForcaVenda.Cabecalho.Codcli = PedidoForcaVenda.Cliente.Codcli;
                    PedidoForcaVenda.Cabecalho.Obsentrega1 = ecommerce.Order.shipment;
                    PedidoForcaVenda.Cabecalho.Vlfrete = Convert.ToDecimal(ecommerce.Order.shipment_value) / 100;
                    #endregion

                    #region Marketplace
                    //Obtendo dados do marketplace
                    if ((!string.IsNullOrEmpty(ecommerce.Order.point_sale))  && (ecommerce.Order.point_sale != "LOJA VIRTUAL")) //partner_id: Não vem preenchido
                    {                       
                        ESTMarketplace marketplaceWinthor = ESTMarketplace.Listar(string.Format("MARKETPLACE_ID = '{0}' OR UPPER(DESCRICAO) = '{0}'", ecommerce.Order.point_sale.ToUpper())).FirstOrDefault();

                        if (marketplaceWinthor == null)
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                                                 , "ImportarPedido"
                                                 , string.Format("Marketplace não localizado: pedido {0} - Marketplace {1}", ecommerce.Order.id, ecommerce.Order.point_sale)
                                                 );
                            return false;
                        }
                        else
                        {
                            PedidoForcaVenda.Cabecalho.Codcob = marketplaceWinthor.Codcob;
                            PedidoForcaVenda.Cabecalho.Codplpag = marketplaceWinthor.Codplpag;
                            PedidoForcaVenda.Cabecalho.Codusur = marketplaceWinthor.Codusur;
                            PedidoForcaVenda.Cabecalho.Codclirecebedor = marketplaceWinthor.Codcli;
                            PedidoForcaVenda.Cabecalho.Obs2 = marketplaceWinthor.Marketplace_Id;
                            PedidoForcaVenda.Cabecalho.Integradora = 12;
                        }
                    }
                    #endregion

                    #region Itens
                    //Listar produtos
                    foreach (var itemVenda in ecommerce.Order.ProductsSold)
                    {
                        TrayPedidoProduto itensPedido = LojaECommerce.ListarPedidosItens(itemVenda.id);

                        if (itensPedido != null)
                        {
                            PCProdut produtoWinthor = PCProdut.Listar(string.Format("CODPRODRELEV = {0}", itensPedido.ProductsSold.product_id)).FirstOrDefault();
                            if (produtoWinthor != null)
                            {
                                Integradora.ERP.Winthor.EntityWinthor.PCPeditemp itemPedido = null;
                                itemPedido = PedidoForcaVenda.Itens.Find(l => l.Complemento == itensPedido.ProductsSold.product_id);
                                if (itemPedido == null)
                                {   //Inserindo um novo produto
                                    itemPedido = PedidoForcaVenda.NovoItemPedido();

                                    itemPedido.Numseq = PedidoForcaVenda.Itens.Count + 1;
                                    itemPedido.Codprod = produtoWinthor.Codprod;
                                    itemPedido.Complemento = itensPedido.ProductsSold.product_id.ToString();
                                    //itemPedido.Codauxiliar = Convert.ToDecimal(item.SKU);
                                    itemPedido.Qt = Convert.ToDecimal(itensPedido.ProductsSold.quantity);
                                    itemPedido.Ptabela = Convert.ToDecimal(itensPedido.ProductsSold.original_price) / 100;
                                    itemPedido.Pvenda = Convert.ToDecimal(itensPedido.ProductsSold.price) / 100;
                                    if ((itemPedido.Ptabela != itemPedido.Pvenda) && (itemPedido.Ptabela > 0))
                                    {
                                        //Calculando desconto
                                        itemPedido.Perdesc = (1 - (itemPedido.Pvenda / itemPedido.Ptabela)) * 100;
                                    }
                                    PedidoForcaVenda.Itens.Add(itemPedido);
                                }
                                else
                                {    //Se já estiver no pedido, apenas adiciona a quantidade
                                    itemPedido.Qt += Convert.ToDecimal(itensPedido.ProductsSold.quantity);
                                }
                            }
                            else
                            {
                                Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                                             , "ImportarPedido"
                                             , string.Format("Produto não localizado no cadastro do Winthor: pedido {0} - sku {1}", ecommerce.Order.id, itensPedido.ProductsSold.id)
                                             );
                                return false;
                            }
                        }
                        else
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                                         , "ImportarPedido"
                                         , string.Format("Produto não localizado para o pedido {0} - id {1}", ecommerce.Order.id, itemVenda.id)
                                         );
                            return false;
                        }
                    }
                    #endregion

                    #region Pagamento
                    //Listar pagamento
                    if (PedidoForcaVenda.Cabecalho.Integradora != 12) //Verificando se é do marketplace
                    {
                        decimal total = 0;
                        decimal valorPago = 0;
                        foreach (var itemPagamento in ecommerce.Order.Payment)
                        {
                            TrayPedidoPagamento PagamentoPedido = LojaECommerce.ListarPedidosPagto(itemPagamento.id);

                            if (PagamentoPedido != null)
                            {
                                Int16 totalParcelamento = Convert.ToInt16(ecommerce.Order.installment);
                                if (totalParcelamento <= 0)
                                    totalParcelamento = 1;

                                valorPago = Convert.ToDecimal(PagamentoPedido.Payment.value) / 100;
                                for (int i = 0; i < totalParcelamento; i++)
                                {
                                    Integradora.ERP.Winthor.EntityWinthor.PCPresttemp parcelaPedido = PedidoForcaVenda.NovaParcela();

                                    parcelaPedido.Valor = valorPago;
                                    if (totalParcelamento > 0)
                                    {
                                        parcelaPedido.Valor = decimal.Round((parcelaPedido.Valor / totalParcelamento), 2);
                                    }
                                    else
                                    {
                                        parcelaPedido.Valor = decimal.Round(parcelaPedido.Valor, 2);
                                    }
                                    total = total + parcelaPedido.Valor; //Acumula para verificar a diferença
                                    parcelaPedido.Prest = (PedidoForcaVenda.Parcelas.Count() + 1).ToString();
                                    parcelaPedido.Presttef = parcelaPedido.Prest;
                                    parcelaPedido.Codcob = PedidoForcaVenda.Cabecalho.Codcob;
                                    parcelaPedido.Codplpag = PedidoForcaVenda.Cabecalho.Codplpag;
                                    if (!string.IsNullOrEmpty(parcelaPedido.NSUTef))
                                    {//Se for pagamento com cartão devera fazer o ajuste do financeiro
                                        PedidoForcaVenda.Cabecalho.ESC_AjustarFinanceiro = "S";
                                    }
                                    PedidoForcaVenda.Parcelas.Add(parcelaPedido);
                                }
                            }
                            else
                            {
                                Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                                             , "ImportarPedido"
                                             , string.Format("Pagamento não localizado para o pedido {0} - id {1}", ecommerce.Order.id, itemPagamento.id)
                                             );
                                return false;
                            }
                        }

                        //Verificando se teve diferença na parcela
                        decimal diferenca = decimal.Round(total - valorPago, 2);
                        if (diferenca != 0)
                        {   //Adiciona a diferença na ultima parcela
                            if (diferenca > 0)
                            {
                                PedidoForcaVenda.Parcelas.Last().Valor -= diferenca;
                            }
                            else
                            {
                                PedidoForcaVenda.Parcelas.Last().Valor += (diferenca * -1);
                            }
                        }

                    }
                    else //Parcelas, quando for de um pedido de origem de marketplace deve gerar apenas 1
                    {
                        Integradora.ERP.Winthor.EntityWinthor.PCPresttemp parcelaPedido = PedidoForcaVenda.NovaParcela();
                        parcelaPedido.Valor = Convert.ToDecimal(ecommerce.Order.total) / 100; // Já vem embutido no valor da parcela:  + parcelamento.ValorJuros - parcelamento.ValorDesconto;
                        parcelaPedido.Prest = "1";
                        parcelaPedido.Presttef = parcelaPedido.Prest;
                        parcelaPedido.Codcob = PedidoForcaVenda.Cabecalho.Codcob;
                        parcelaPedido.Codplpag = PedidoForcaVenda.Cabecalho.Codplpag;
                        PedidoForcaVenda.Parcelas.Add(parcelaPedido);
                    }
                    #endregion

                    bool commitTransacao = commitTransacao = PedidoForcaVenda.PedidoGravar();
                    if (commitTransacao)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        transaction.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                                 , "ImportarPedido"
                                 , string.Format("Erro ao importar pedido: {0} - Erro: {1} ", ecommerce.Order.id, ex.ToString())
                                 );
                }
            }
            return true;
        }

        private bool GravarCliente(TrayCliente cliente, string cnpjcpf)
        {
            PedidoForcaVenda.ClienteInicializar();

            PedidoForcaVenda.Cliente.Cgcent = cnpjcpf;
            PedidoForcaVenda.Cliente.Cliente = string.IsNullOrEmpty(cliente.Customer.company_name) ? cliente.Customer.name : cliente.Customer.company_name;
            PedidoForcaVenda.Cliente.Fantasia = cliente.Customer.name;
            PedidoForcaVenda.Cliente.Email = cliente.Customer.email; // Biblioteca.Tools.Formats.FormatoWinthor(cliente.Customer.email).ToLower();
            PedidoForcaVenda.Cliente.Emailnfe = cliente.Customer.email;  //PedidoForcaVenda.Cliente.Email;
            PedidoForcaVenda.Cliente.Sexo = cliente.Customer.gender == "0" ? "M" : "F";
            PedidoForcaVenda.Cliente.Codcliweb = Biblioteca.Tools.Numbers.ToInt32(cliente.Customer.id);
            PedidoForcaVenda.Cliente.Telent = Biblioteca.Tools.Formats.FormatoWinthor(cliente.Customer.phone);
            PedidoForcaVenda.Cliente.Telcelent = Biblioteca.Tools.Formats.FormatoWinthor(cliente.Customer.cellphone);
            PedidoForcaVenda.Cliente.Rg = Biblioteca.Tools.Formats.FormatoWinthor(cliente.Customer.rg);
            PedidoForcaVenda.Cliente.Aceitavendafracao = "S";
            PedidoForcaVenda.Cliente.Validarmultiplovenda = "S";
            PedidoForcaVenda.Cliente.Usacreclifat = "S";
            PedidoForcaVenda.Cliente.Codcontab = Biblioteca.Dictionaries.Settings.ContaContabilCliente();
            PedidoForcaVenda.Cliente.Codcob = Biblioteca.Dictionaries.Settings.CodCobranca();
            PedidoForcaVenda.Cliente.Codplpag = Biblioteca.Dictionaries.Settings.CodPlanoPagamento();
            if (cliente.Customer.birth_date != "0000-00-00")
            {
                PedidoForcaVenda.Cliente.Dtnasc = Biblioteca.Tools.Calendars.ToDateTime(cliente.Customer.birth_date);
            }

            foreach (var item in cliente.Customer.CustomerAddress)
            {
                TrayEndereco Enderecos = LojaECommerce.ObterEndereco(item.id);

                PedidoForcaVenda.Cliente.Municent = Biblioteca.Tools.Formats.FormatoWinthor(Enderecos.CustomerAddress.city);
                PedidoForcaVenda.Cliente.Complementoent = Biblioteca.Tools.Formats.FormatoWinthor(Enderecos.CustomerAddress.complement);
                PedidoForcaVenda.Cliente.Numeroent = Biblioteca.Tools.Formats.FormatoWinthor(Enderecos.CustomerAddress.number);
                PedidoForcaVenda.Cliente.Estent    = Biblioteca.Tools.Formats.FormatoWinthor(Enderecos.CustomerAddress.state);
                PedidoForcaVenda.Cliente.Cepent    = Biblioteca.Tools.Formats.FormatoWinthor(Enderecos.CustomerAddress.zip_code);
                PedidoForcaVenda.Cliente.Enderent  = Biblioteca.Tools.Formats.FormatoWinthor(Enderecos.CustomerAddress.address);
                PedidoForcaVenda.Cliente.Bairroent = Biblioteca.Tools.Formats.FormatoWinthor(Enderecos.CustomerAddress.neighborhood);
                if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Bairroent)) 
                {
                    PedidoForcaVenda.Cliente.Bairroent = "CENTRO";
                }

            }

            return PedidoForcaVenda.ClienteGravar();
        }

        private static bool ExecutarIntegradora(Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda)
        {
            if (Biblioteca.Dictionaries.Settings.Debugando())
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                                , "ExecutarIntegradora"
                                , "Executando integradora do Winthor no pedido: " + PedidoForcaVenda.Cabecalho.Numpedrca.ToString());
            }
            bool importado = false;
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    PedidoForcaVenda.IntegrarPedido_Modelo_01(PedidoForcaVenda.Cabecalho.Numpedrca, PedidoForcaVenda.Cabecalho.Codusur);
                    transaction.Commit();
                    importado = true;
                    if (Biblioteca.Dictionaries.Settings.Debugando())
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                                , "ExecutarIntegradora"
                                , "Concluido a integradora do Winthor no pedido: " + PedidoForcaVenda.Cabecalho.Numpedrca.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    importado = false;
                    Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                                , "ExecutarIntegradora"
                                , string.Format("Erro ao executar integradora - pedido: {0} - Erro: {1} ", PedidoForcaVenda.Cabecalho.Numpedrca, ex.ToString())
                                );
                }
            }
            return importado;
        }
    }
}

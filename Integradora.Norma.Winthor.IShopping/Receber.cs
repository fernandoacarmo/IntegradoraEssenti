using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.IShopping;
using Integradora.ECommerce.IShopping.Retornos;
using Integradora.ERP.Winthor.Domain;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.IShopping
{
    class Receber : IProcessIntegration
    {
        public Integradora.ECommerce.IShopping.Integracao LojaECommerce { get; set; }
        public PedidoWeb PedidoForcaVenda { get; set; }

        public Receber()
        {
            LojaECommerce = new ECommerce.IShopping.Integracao();
            PedidoForcaVenda = new PedidoWeb();
        }
        public void Process(Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            ObterPedidosVenda();
        }

        private void ObterPedidosVenda()
        {
            try
            {
                ListaPedidos ListaPedidos = null;
                //Obtendo a lista de pedidos
                ListaPedidos = LojaECommerce.PedidoListar();
                //Exportar o resultado da lista de pedidos para arquivos json
                if (ListaPedidos != null)
                {
                    ProcessarListaPedidos(ListaPedidos);
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.IShopping"
                                     , "ObterPedidosVenda"
                                     , "Erro ao listar pedidos: " + ex.ToString()
                                     );
            }
        }

        private void ProcessarListaPedidos(ListaPedidos ListaPedidos)
        {
            try
            {
                Biblioteca.Tools.JSON.Export(ListaPedidos, "ListaPedidos.");
                //Percorrendo a lista de pedidos encontrada
                foreach (var pedidoIShopping in ListaPedidos.orders)
                {   //Obtendo o pedido da lista
                    Order pedido = LojaECommerce.ObterPedido(pedidoIShopping.orderId);
                    //Verificando se carregou o pedido
                    if (pedido != null)
                    {   //Exportando pedido para arquivo Json
                        Biblioteca.Tools.JSON.Export(pedido, "pedido_" + pedidoIShopping.orderId);
                        //Verificando se o pedido já existe na base do Winthor
                        bool sucesso = (PedidoWeb.PedidoExiste(pedidoIShopping.orderId.ToString()));

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
                Logs.GerarLog("Integradora.Norma.Winthor.IShopping"
                             , "ProcessarListaPedidos"
                             , "Erro ao processar listar pedidos: " + ex.ToString()
                             );
            }
        }

        private void AtualizarStatus(Order pedido)
        {
            int status = 2;
            string msg = "Inicializando faturamento";

            //Marcar pedido como processado
            LojaECommerce.MudarStatus(pedido.orderId, status, msg);
        }

        private bool ExecutarIntegradora(PedidoWeb PedidoForcaVenda)
        {
            if (Biblioteca.Dictionaries.Settings.Debugando())
            {
                Logs.GerarLog("Integradora.Norma.Winthor.IShopping"
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
                        Logs.GerarLog("Integradora.Norma.Winthor.IShopping"
                                , "ExecutarIntegradora"
                                , "Concluido a integradora do Winthor no pedido: " + PedidoForcaVenda.Cabecalho.Numpedrca.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    importado = false;
                    Logs.GerarLog("Integradora.Norma.Winthor.IShopping"
                                , "ExecutarIntegradora"
                                , string.Format("Erro ao executar integradora - pedido: {0} - Erro: {1} ", PedidoForcaVenda.Cabecalho.Numpedrca, ex.ToString())
                                );
                }
            }
            return importado;
        }

        private bool ImportarPedido(Order pedido)
        {
            //Iniciando transação
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    #region Cliente
                    //Validando o cliente
                    Customer cliente = pedido.customer;
                    //Obtendo o CNPJ e CPF
                    string cnpjcpf = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(cliente.cpf_cnpj);
                    //Obtendo o cliente através do CNPJ/CPF
                    if (!PedidoForcaVenda.ClienteExiste(string.Format("DTEXCLUSAO IS NULL AND CGCENT = '{0}'", cnpjcpf)))
                    {
                        GravarCliente(cliente);
                    }
                    //Cliente não encontrado
                    if (PedidoForcaVenda.Cliente == null)
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.IShopping"
                                     , "ImportarPedido"
                                     , string.Format("Cliente não localizado: pedido {0} - CNPJ/CPF {1}", pedido.orderId, cnpjcpf)
                                     );
                        return false;
                    }
                    #endregion

                    #region Cabeçalho do pedido
                    //Inicializando o pedido
                    PedidoForcaVenda.PedidoInicializar();
                    PedidoForcaVenda.Cabecalho.Numpedcli = pedido.orderId.ToString();
                    PedidoForcaVenda.Cabecalho.Numpedrca = pedido.orderId;
                    PedidoForcaVenda.Cabecalho.Numpedweb = PedidoForcaVenda.Cabecalho.Numpedrca;

                    PedidoForcaVenda.Cabecalho.Data = Convert.ToDateTime(pedido.datePurchased);
                    PedidoForcaVenda.Cabecalho.Codusur = Biblioteca.Dictionaries.Settings.CodRCA();
                    PedidoForcaVenda.Cabecalho.Codcli = PedidoForcaVenda.Cliente.Codcli;
                    PedidoForcaVenda.Cabecalho.Obsentrega1 = pedido.shipping.method;
                    #endregion

                    #region Marketplace
                    //                    //Obtendo dados do marketplace
                    //                    if (!string.IsNullOrEmpty(ecommerce.Order.point_sale)) //partner_id: Não vem preenchido
                    //                    {
                    //                        ESTMarketplace marketplaceWinthor = ESTMarketplace.Listar(string.Format("MARKETPLACE_ID = '{0}' OR UPPER(DESCRICAO) = '{0}'", ecommerce.Order.point_sale.ToUpper())).FirstOrDefault();
                    //
                    //                        if (marketplaceWinthor == null)
                    //                        {
                    //                            Logs.GerarLog("Integradora.Norma.Winthor.Tray"
                    //                                                 , "ImportarPedido"
                    //                                                 , string.Format("Marketplace não localizado: pedido {0} - Marketplace {1}", ecommerce.Order.id, ecommerce.Order.point_sale)
                    //                                                 );
                    //                            return false;
                    //                        }
                    //                        else
                    //                        {
                    //                            PedidoForcaVenda.Cabecalho.Codcob = marketplaceWinthor.Codcob;
                    //                            PedidoForcaVenda.Cabecalho.Codplpag = marketplaceWinthor.Codplpag;
                    //                            PedidoForcaVenda.Cabecalho.Codusur = marketplaceWinthor.Codusur;
                    //                            PedidoForcaVenda.Cabecalho.Codclirecebedor = marketplaceWinthor.Codcli;
                    //                            PedidoForcaVenda.Cabecalho.Obs2 = marketplaceWinthor.Marketplace_Id;
                    //                            PedidoForcaVenda.Cabecalho.Integradora = 12;
                    //                        }
                    //                    }
                    #endregion

                    #region Itens
                    //Listar produtos
                    foreach (var itemVenda in pedido.products)
                    {
                        PCEmbalagem produtoWinthor = PCEmbalagem.Listar(string.Format("CODISHOPPING = {0}", itemVenda.id)).FirstOrDefault();
                        if (produtoWinthor != null)
                        {
                            Integradora.ERP.Winthor.EntityWinthor.PCPeditemp itemPedido = null;
                            itemPedido = PedidoForcaVenda.Itens.Find(l => l.Complemento == itemVenda.id.ToString());
                            if (itemPedido == null)
                            {   //Inserindo um novo produto
                                itemPedido = PedidoForcaVenda.NovoItemPedido();

                                itemPedido.Numseq = PedidoForcaVenda.Itens.Count + 1;
                                itemPedido.Codprod = produtoWinthor.Codprod;
                                itemPedido.Complemento = itemVenda.id.ToString();
                                itemPedido.Codauxiliar = itemPedido.Codauxiliar;
                                itemPedido.Qt = Convert.ToDecimal(itemVenda.quantity);
                                itemPedido.Ptabela = Convert.ToDecimal(itemVenda.price_unit) / 100;
                                itemPedido.Pvenda = Convert.ToDecimal(itemVenda.price_final) / 100;
                                if (itemPedido.Ptabela != itemPedido.Pvenda)
                                {
                                    //Calculando desconto
                                    itemPedido.Perdesc = (1 - (itemPedido.Pvenda / itemPedido.Ptabela)) * 100;
                                }
                                PedidoForcaVenda.Itens.Add(itemPedido);
                            }
                            else
                            {    //Se já estiver no pedido, apenas adiciona a quantidade
                                itemPedido.Qt += Convert.ToDecimal(itemVenda.quantity);
                            }
                        }
                        else
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.IShopping"
                                         , "ImportarPedido"
                                         , string.Format("Produto não no cadastro do Winthor: pedido {0} - sku {1}", pedido.orderId, itemVenda.id)
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
                        Int16 totalParcelamento = Convert.ToInt16(pedido.payment.installments);
                        if (totalParcelamento <= 0)
                            totalParcelamento = 1;

                        valorPago = Convert.ToDecimal(pedido.orderTotal) / 100;
                        for (int i = 0; i < totalParcelamento; i++)
                        {
                            Integradora.ERP.Winthor.EntityWinthor.PCPresttemp parcelaPedido = PedidoForcaVenda.NovaParcela();

                            parcelaPedido.Valor = valorPago;
                            parcelaPedido.Valor = decimal.Round((parcelaPedido.Valor / totalParcelamento), 2);
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
                        parcelaPedido.Valor = Convert.ToDecimal(pedido.orderTotal) / 100; // Já vem embutido no valor da parcela:  + parcelamento.ValorJuros - parcelamento.ValorDesconto;
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
                    Logs.GerarLog("Integradora.Norma.Winthor.IShopping"
                                 , "ImportarPedido"
                                 , string.Format("Erro ao importar pedido: {0} - Erro: {1} ", pedido.orderId, ex.ToString())
                                 );
                }
            }
            return true;
        }

        private bool GravarCliente(Customer cliente)
        {
            PedidoForcaVenda.ClienteInicializar();

            PedidoForcaVenda.Cliente.Cgcent = cliente.cpf_cnpj;
            PedidoForcaVenda.Cliente.Cliente = cliente.name;
            PedidoForcaVenda.Cliente.Fantasia = cliente.name;
            PedidoForcaVenda.Cliente.Empresa = cliente.company;
            PedidoForcaVenda.Cliente.Email = Biblioteca.Tools.Formats.FormatoWinthor(cliente.email).ToLower();
            PedidoForcaVenda.Cliente.Emailnfe = PedidoForcaVenda.Cliente.Email;
            PedidoForcaVenda.Cliente.Sexo = "M";
            PedidoForcaVenda.Cliente.Codcliweb = cliente.id;
            PedidoForcaVenda.Cliente.Telent = Biblioteca.Tools.Formats.FormatoWinthor(cliente.phones.primary.ddd.ToString() + cliente.phones.primary.number);
            PedidoForcaVenda.Cliente.Telcelent = Biblioteca.Tools.Formats.FormatoWinthor(cliente.phones.cellphone.ddd.ToString() + cliente.phones.cellphone.number);
            PedidoForcaVenda.Cliente.Rg = Biblioteca.Tools.Formats.FormatoWinthor(cliente.rg);
            PedidoForcaVenda.Cliente.Aceitavendafracao = "S";
            PedidoForcaVenda.Cliente.Validarmultiplovenda = "S";
            PedidoForcaVenda.Cliente.Usacreclifat = "S";
            PedidoForcaVenda.Cliente.Codcontab = Biblioteca.Dictionaries.Settings.ContaContabilCliente();
            PedidoForcaVenda.Cliente.Codcob = Biblioteca.Dictionaries.Settings.CodCobranca();
            PedidoForcaVenda.Cliente.Codplpag = Biblioteca.Dictionaries.Settings.CodPlanoPagamento();
            if (cliente.dob != "0000-00-00")
            {
                PedidoForcaVenda.Cliente.Dtnasc = Biblioteca.Tools.Calendars.ToDateTime(cliente.dob);
            }

            PedidoForcaVenda.Cliente.Municent = Biblioteca.Tools.Formats.FormatoWinthor(cliente.address.city);
            PedidoForcaVenda.Cliente.Complementoent = Biblioteca.Tools.Formats.FormatoWinthor(cliente.address.complement);
            PedidoForcaVenda.Cliente.Numeroent = Biblioteca.Tools.Formats.FormatoWinthor(cliente.address.number.ToString());
            PedidoForcaVenda.Cliente.Estent = Biblioteca.Tools.Formats.FormatoWinthor(cliente.address.state);
            PedidoForcaVenda.Cliente.Cepent = Biblioteca.Tools.Formats.FormatoWinthor(cliente.address.postcode);
            PedidoForcaVenda.Cliente.Enderent = Biblioteca.Tools.Formats.FormatoWinthor(cliente.address.street);
            PedidoForcaVenda.Cliente.Pontorefer = Biblioteca.Tools.Formats.FormatoWinthor(cliente.address.suburb);

            return PedidoForcaVenda.ClienteGravar();
        }
    }
}

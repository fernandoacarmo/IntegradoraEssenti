using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.VTiger;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Integradora.Norma.Winthor.VTiger
{
    class Receber : IProcessIntegration
    {
        public Integradora.ECommerce.VTiger.Integracao LojaECommerce { get; set; }
        public Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda { get; set; }

        public Receber()
        {
            LojaECommerce = new ECommerce.VTiger.Integracao();
            PedidoForcaVenda = new ERP.Winthor.Domain.PedidoWeb();
        }
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            //ReceiveCliente();
            //ReceiveClienteEndereco();
            ReceivePedidos();
        }

        public void ReceivePedidos()
        {
            ListaPedido listagem = LojaECommerce.ObterPedidosPendentes();
            if ((listagem != null) && (listagem.Pedido.Count > 0))
            {
                foreach (var item in listagem.Pedido)
                {
                    PCPedctemp Cabecalho = null;
                    try
                    { //Carregando o cabeçalho do pedido
                        Cabecalho = PCPedctemp.Listar("NUMPEDCLI = '" + item.Numpedido + "'").Single();
                        if (Cabecalho.Numpedrca > 0)
                        {
                            Logs.GerarLog("Pedido já existente: " + item.Numpedido);
                        }
                    }
                    catch (Exception)
                    {
                        Logs.GerarLog("Importando pedido: " + item.Numpedido);
                        Cabecalho = null;
                    }

                    if (Cabecalho == null)
                    {
                        string retorno = ImportarPedidoVenda(item);
                        if (retorno != "OK")
                        {
                            Logs.GerarLog("Erro na importação do pedido: " + item.Numpedido + " - erro: " + retorno);
                        }
                    }
                    else
                    {
                        LojaECommerce.MarcarPedidoComoImportado(item.Numpedido, Cabecalho.Numpedrca);
                        Logs.GerarLog("Pedido marcado como importado: " + item.Numpedido);
                    }
                }
            }
            else
            {
                Logs.GerarLog("Nenhum pedido para ser importado");
            }
        }

        public string ImportarPedidoVenda(Integradora.ECommerce.VTiger.Pedido pedido)
        {
            decimal numPedido = 0;
            decimal codRCA = 0;
            bool commitTransacao = false;
            string resultado = "";

            Biblioteca.Tools.XML.Export(pedido, "Pedido_" + pedido.Numpedido.ToString());
            
            if (string.IsNullOrEmpty(pedido.Cliente.CNPJCPF))
            {
                return "CNPJ/CPF do cliente não informado!";
            }
            if (Convert.ToDecimal(pedido.CodVendedor) <= 0)
            {
                pedido.CodVendedor = Biblioteca.Dictionaries.Settings.CodRCA().ToString();
            }
            if (Convert.ToDecimal(pedido.CodVendedor) <= 0)
            {
                return "Código do vendedor não informado!";
            }
            if (pedido.Itens.ItemPedido.Count <= 0)
            {
                return "Nenhum item inserido!";
            }
            if (pedido.Parcelas.ParcelaPedido.Count <= 0)
            {
                return "Nenhuma parcela inserida!";
            }

            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda = new ERP.Winthor.Domain.PedidoWeb();

                    if (!AtualizarCadastroCliente(pedido.Cliente, PedidoForcaVenda))
                    {
                        return "Erro na validação do cliente";
                    }
                    PedidoForcaVenda.PedidoInicializar();
                    PedidoForcaVenda.Cabecalho.Codcli = PedidoForcaVenda.Cliente.Codcli;
                    PedidoForcaVenda.Cabecalho.Codusur2 = Numbers.ToInt32(pedido.CodProfissional);
                    PedidoForcaVenda.Cabecalho.Vlfrete = Math.Round(Convert.ToDecimal(pedido.Valorfrete.Replace(".", ",")), 2);
                    PedidoForcaVenda.Cabecalho.Codusur = Numbers.ToInt32(pedido.CodVendedor);
                    PedidoForcaVenda.Cabecalho.Codfilial = Biblioteca.Dictionaries.Settings.CodFilialVenda();
                    PedidoForcaVenda.Cabecalho.Codfilialnf = Biblioteca.Dictionaries.Settings.CodFilialVenda();
                    PedidoForcaVenda.Cabecalho.Codplpag = Biblioteca.Dictionaries.Settings.CodPlanoPagamento();
                    PedidoForcaVenda.Cabecalho.Codcob = Biblioteca.Dictionaries.Settings.CodCobranca();
                    PedidoForcaVenda.Cabecalho.Data = Calendars.ToDateTime( Calendars.ToDateTime(pedido.Dtemissao) );
                    PedidoForcaVenda.Cabecalho.Dtentrega = Calendars.ToDateTime(pedido.Dtentrega);
                    //PedidoForcaVenda.Cabecalho.Numpedweb = Convert.ToDecimal( pedido.Numpedido );
                    PedidoForcaVenda.Cabecalho.Numpedcli = pedido.Numpedido;
                    PedidoForcaVenda.Cabecalho.Obs1 = pedido.Observacao;

                    foreach (var item in pedido.Itens.ItemPedido)
                    {
                        //Classe que representa o item na lista
                        Integradora.ERP.Winthor.EntityWinthor.PCPeditemp itemPedido = null;
                        decimal codproduto = Convert.ToDecimal( item.Codproduto); 
                        if ( codproduto > 0)
                        {
                            //Verificando se o produto já esta no pedido
                            itemPedido = PedidoForcaVenda.Itens.Find(l => l.Codprod == codproduto);
                            if (itemPedido == null)
                            {   //Inserindo um novo produto
                                itemPedido = PedidoForcaVenda.NovoItemPedido();

                                itemPedido.Numseq = PedidoForcaVenda.Itens.Count + 1;
                                itemPedido.Codprod = codproduto;
                                //itemPedido.Codauxiliar = Convert.ToDecimal(item.SKU);
                                itemPedido.Qt = Math.Round(Convert.ToDecimal(item.Quantidade.Replace(".", ",")), 0);
                                itemPedido.Ptabela = Math.Round(Convert.ToDecimal(item.Precotabela.Replace(".",",")),4);
                                itemPedido.Pvenda = Math.Round(Convert.ToDecimal(item.Precovenda.Replace(".",",")),4); 
                                if (itemPedido.Ptabela != itemPedido.Pvenda)
                                {
                                    //Calculando desconto
                                    itemPedido.Perdesc = (1 - (itemPedido.Pvenda / itemPedido.Ptabela)) * 100;
                                }
                                PedidoForcaVenda.Itens.Add(itemPedido);
                            }
                            else
                            {    //Se já estiver no pedido, apenas adiciona a quantidade
                                itemPedido.Qt += Convert.ToDecimal(item.Quantidade); 
                            }
                        }
                    }

                    foreach (var parcelamento in pedido.Parcelas.ParcelaPedido)
                    {
                        CarregarFormaPagamento(PedidoForcaVenda, parcelamento);
                        int numParcelas = Convert.ToInt32(parcelamento.Numparcelas);
                        for (int i = 0; i < numParcelas; i++)
                        {
                            Integradora.ERP.Winthor.EntityWinthor.PCPresttemp parcelaPedido = PedidoForcaVenda.NovaParcela();

                            parcelaPedido.Valor = Math.Round(Convert.ToDecimal(parcelamento.Valor.Replace(".", ",")), 2);
                            //parcelaPedido.Esc_Vldesconto = parcelamento.ValorDesconto;
                            //parcelaPedido.Esc_Vljuros = parcelamento.ValorJuros;
                            parcelaPedido.Prest = (i + 1).ToString();
                            parcelaPedido.Presttef = parcelaPedido.Prest;
                            parcelaPedido.Dttransacaocc = PedidoForcaVenda.Cabecalho.Data;
                            parcelaPedido.Codcob = PedidoForcaVenda.Cabecalho.Codcob;
                            parcelaPedido.Codplpag = PedidoForcaVenda.Cabecalho.Codplpag;
                            parcelaPedido.NSUTef = Numbers.OnlyNumbers( parcelamento.NSU );
                            parcelaPedido.CodAutTEF = Numbers.ToInt64( parcelamento.CodAutorizacao );
                            if (!string.IsNullOrEmpty(parcelaPedido.NSUTef))
                            {//Se for pagamento com cartão devera fazer o ajuste do financeiro
                                PedidoForcaVenda.Cabecalho.ESC_AjustarFinanceiro = "S";
                            }

                            PedidoForcaVenda.Parcelas.Add(parcelaPedido);                            
                        }
                    }
                    //Gravar o cliente (inserindo ou atualizando dados
                    commitTransacao = PedidoForcaVenda.PedidoGravar();
                    if (commitTransacao)
                    {
                        numPedido = PedidoForcaVenda.Cabecalho.Numpedweb;
                        codRCA = PedidoForcaVenda.Cabecalho.Codusur;
                    }

                    if (commitTransacao)
                    {
                        transaction.Commit();
                        resultado = "OK";
                    }
                    else
                    {
                        transaction.Rollback();
                        resultado = "Erro ao gravar pedido!";
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    resultado = ex.ToString();
                }
            }

            if (resultado == "OK")
            {
                Logs.GerarLog("Executando a integradora no pedido RCA: " + numPedido);
                bool importado = ExecutarIntegradora(numPedido, codRCA, PedidoForcaVenda);

                if (importado)
                {
                    LojaECommerce.MarcarPedidoComoImportado(pedido.Numpedido, PedidoForcaVenda.Cabecalho.Numpedrca);
                    Logs.GerarLog("Pedido marcado como importado: " + pedido.Numpedido);
                }
            }
            return resultado;
        }

        private static bool ExecutarIntegradora(decimal numPedido, decimal codRCA, Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda)
        {
            if (Biblioteca.Dictionaries.Settings.Debugando())
            {
                Logs.GerarLog("Executando integradora do Winthor no pedido: " + numPedido.ToString());
            }
            bool importado = false;
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    PedidoForcaVenda.IntegrarPedido_Modelo_01(numPedido, codRCA);
                    transaction.Commit();
                    importado = true;
                    if (Biblioteca.Dictionaries.Settings.Debugando())
                    {
                        Logs.GerarLog("Concluido a integradora do Winthor no pedido: " + numPedido.ToString());
                    }
                    ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTiger.Receber"
                                                      , "ExecutarIntegradora"
                                                      , "Pedido: " + numPedido.ToString() + " importado com sucesso "
                                                      , PedidoForcaVenda.Cabecalho.Numpedcli
                                                      , PedidoForcaVenda.Cabecalho.Numpedrca
                                                      , "S"
                                                      , "VTIGER");

                }
                catch (Exception erro)
                {
                    transaction.Rollback();
                    importado = false;
                    ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTiger.Receber"
                                                      , "ExecutarIntegradora"
                                                      , "Pedido: " + numPedido.ToString() + " erro: " + erro
                                                      , PedidoForcaVenda.Cabecalho.Numpedcli
                                                      , PedidoForcaVenda.Cabecalho.Numpedrca
                                                      , "N"
                                                      , "VTIGER");
                }
            }
            return importado;
        }

        private bool AtualizarCadastroCliente(Integradora.ECommerce.VTiger.VTigerCliente cliente, ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda)
        {
            string CNPJ_CPF = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(cliente.CNPJCPF);
            //Verifica se o cliente do pedido existe no Winthor
            if (!PedidoForcaVenda.ClienteExiste("REGEXP_REPLACE(CGCENT, '[^0-9]','') = '" + CNPJ_CPF + "'"))
            {
                //Criando um novo cliente
                PedidoForcaVenda.ClienteInicializar();
            }

            if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Cliente))
            {
                PedidoForcaVenda.Cliente.Cliente = Formats.FormatoWinthor(cliente.Razaosocial);
            }
            if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Fantasia))
            {
                PedidoForcaVenda.Cliente.Fantasia = Formats.FormatoWinthor(cliente.Nomefantasia);
            }
            if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Ieent))
            {
                PedidoForcaVenda.Cliente.Ieent = string.IsNullOrEmpty(cliente.Inscricaoestadual) ? "ISENTO" : Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(cliente.Inscricaoestadual);
            }
            if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Cgcent))
            {
                PedidoForcaVenda.Cliente.Cgcent = CNPJ_CPF;
            }
            PedidoForcaVenda.Cliente.Enderent = Formats.FormatoWinthor(cliente.Endereco);
            PedidoForcaVenda.Cliente.Bairroent = Formats.FormatoWinthor(cliente.Bairro);
            PedidoForcaVenda.Cliente.Complementoent = Formats.FormatoWinthor(cliente.Complemento);
            PedidoForcaVenda.Cliente.Numeroent = Formats.FormatoWinthor(cliente.Numero);
            PedidoForcaVenda.Cliente.Municent = Formats.FormatoWinthor(cliente.Cidade);
            PedidoForcaVenda.Cliente.Estent = Formats.FormatoWinthor(cliente.Estado);
            //PedidoForcaVenda.Cliente.Paisent = Formats.FormatoWinthor(client);
            //PedidoForcaVenda.Cliente.Pontorefer = Formats.FormatoWinthor(VTexPedido.shippingData.address.reference);
            PedidoForcaVenda.Cliente.Site = "VTIGER";
            PedidoForcaVenda.Cliente.Dtultcomp = PedidoForcaVenda.Cliente.DataServidor();
            PedidoForcaVenda.Cliente.Dtultvisita = PedidoForcaVenda.Cliente.Dtultcomp;
            PedidoForcaVenda.Cliente.Email = string.IsNullOrEmpty( cliente.Email) ? "" : cliente.Email.ToLower();
            PedidoForcaVenda.Cliente.Telent = cliente.Telefone;
            PedidoForcaVenda.Cliente.Telcelent = cliente.Celular;
            PedidoForcaVenda.Cliente.Cepent = cliente.CEP;

            PedidoForcaVenda.Cliente.Endercom = PedidoForcaVenda.Cliente.Enderent;
            PedidoForcaVenda.Cliente.Numerocom = PedidoForcaVenda.Cliente.Numeroent;
            PedidoForcaVenda.Cliente.Bairrocom = PedidoForcaVenda.Cliente.Bairroent;
            PedidoForcaVenda.Cliente.Municcom = PedidoForcaVenda.Cliente.Municent;
            PedidoForcaVenda.Cliente.Estcom = PedidoForcaVenda.Cliente.Estent;
            PedidoForcaVenda.Cliente.Cepcom = PedidoForcaVenda.Cliente.Cepent;

            PedidoForcaVenda.Cliente.Endercob = PedidoForcaVenda.Cliente.Enderent;
            PedidoForcaVenda.Cliente.Numerocob = PedidoForcaVenda.Cliente.Numeroent;
            PedidoForcaVenda.Cliente.Bairrocob = PedidoForcaVenda.Cliente.Bairroent;
            PedidoForcaVenda.Cliente.Municcob = PedidoForcaVenda.Cliente.Municent;
            PedidoForcaVenda.Cliente.Estcob = PedidoForcaVenda.Cliente.Estent;
            PedidoForcaVenda.Cliente.Cepcob = PedidoForcaVenda.Cliente.Cepent;

            return PedidoForcaVenda.ClienteGravar();
        }

        public string EnviarCliente(Integradora.ECommerce.VTiger.VTigerCliente cliente)
        {
            if (cliente == null)
            {
                return "Cliente inválido. Objeto não atribuído.";
            }

            if (string.IsNullOrEmpty(cliente.CNPJCPF))
            {
                return "CNPJ/CPF não informado.";
            }

            if (string.IsNullOrEmpty(cliente.Razaosocial))
            {
                return "Razão social/nome não informado.";
            }

            string resultado = "";
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda = new ERP.Winthor.Domain.PedidoWeb();
                    if (AtualizarCadastroCliente(cliente, PedidoForcaVenda))
                    {
                        resultado = "OK";
                    }
                    else
                    {
                        resultado = "Erro ao gravar cliente";
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    resultado = ex.ToString();
                }
            }
            return resultado;
        }

        private static bool CarregarFormaPagamento(Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda, Integradora.ECommerce.VTiger.ParcelaPedido parcelas)
        {
            Ecommerceformapagto FormaPagamento = null;
            bool resultado = false;
            try
            {
                //Esta usando o mesmo mapeamento da VTex para obter a cobrança e plano de pagamento
                string filtro = string.Format("CODCOB IS NOT NULL AND CODPLPAG IS NOT NULL AND  ECommerce = 'VTex' AND CODIGONOECOMMERCE = '{0}' and ROWNUM = 1",
                                              parcelas.CodCobranca.PadLeft(2, '0'));
                FormaPagamento = Ecommerceformapagto.Listar(filtro).Single();
                PedidoForcaVenda.Cabecalho.Codcob = FormaPagamento.Codcob;
                PedidoForcaVenda.Cabecalho.Codplpag = FormaPagamento.Codplpag;

                filtro = string.Format("CODPLPAG IS NOT NULL AND ECommerce = 'VTex' AND CODIGONOECOMMERCE = '{0}' AND NUMPARCELA = {1} and ROWNUM = 1"
                                      , parcelas.CodCobranca.PadLeft(2, '0')
                                      , parcelas.Numparcelas);

                try
                {
                    Ecommerceformapagto_Parcela TipoParcela = Ecommerceformapagto_Parcela.Listar(filtro).Single();
                    if (TipoParcela.Codplpag > 0)
                    {
                        PedidoForcaVenda.Cabecalho.Codplpag = TipoParcela.Codplpag;
                    }
                }
                catch
                {
                    PedidoForcaVenda.Cabecalho.Codplpag = FormaPagamento.Codplpag;
                }

                resultado = true;
            }
            catch
            {
                resultado = false;
            }

            return resultado;
        }
    }
}

using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.Magento001.MagentoService;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Magento001
{
    public class RetornoImportacao
    {
        public RetornoImportacao()
        {
            sucesso = false;
            mensagem = "";
            numeroPedido = 0;
            codRCA = 0;
        }

        public bool sucesso;
        public string mensagem;
        public decimal numeroPedido;
        public decimal codRCA;
    }
    public class Receber : IProcessIntegration
    {
        public Integradora.ECommerce.Magento001.Integracao LojaECommerce { get; set; }
        public Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda { get; set; }

        public Receber()
        {
            LojaECommerce = new ECommerce.Magento001.Integracao();
            PedidoForcaVenda = new ERP.Winthor.Domain.PedidoWeb();

        }
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            try
            {
                ReceberPedidosPagos();
                ReceberPedidosNovos();
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                             , "Process"
                             , "Erro ao receber do Magento: " + ex.ToString());
            }
        }

        private salesOrderInfoCustomEntity ObterPedido(string numeroPedidoEcommerce)
        {
            var pedido = LojaECommerce.PedidosCarregar(numeroPedidoEcommerce);

            if (pedido != null)
            {
                Biblioteca.Tools.XML.Export(pedido, "Magento_" + numeroPedidoEcommerce);
            }
            return pedido;
        }
        private void ReceberPedidosNovos()
        {
            //Listar pedidos pendentes de importacao para gerar o pedido do Winthor 
            var Pedidos = LojaECommerce.PedidosListar(Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPedido_pesquisa());
            //Verifica se existe epdidos
            if ((Pedidos != null) && (Pedidos.Count() > 0))
            {//Listando os pedidos
                foreach (var item in Pedidos)
                {
                        GerarPedidoNoERP(item.increment_id, item.customer_email);
                }
            }
            else
            {
                if (Biblioteca.Dictionaries.Settings.Debugando())
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                 , "ReceberPedidosNovos"
                                 , "Nenhum pedido para ser importado");
                }
            }
        }

        private void GerarPedidoNoERP(string NumPedidoECommerce, string EmailCliente)
        {
            RetornoImportacao retorno = new RetornoImportacao();
            if (!PedidoJaImportado(NumPedidoECommerce))
            {//Carregando pedido
                var pedido = ObterPedido(NumPedidoECommerce);

                if (pedido != null)
                {
                    if (string.IsNullOrEmpty(pedido.erp_id_pedido))
                    {
                        retorno = PedidoImportar(pedido, true);
                    }
                }
            }
            else
            {
                retorno.mensagem = "Pedido já importado";

                MarcarPosicaoPedido(NumPedidoECommerce
                                   , "Pedido já importado"
                                   , Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPedido_importado()
                                   , EmailCliente
                                   , retorno.numeroPedido.ToString()
                                   , Biblioteca.Dictionaries.Tips.SimNao.Nao
                                   );
            }

            if (retorno.sucesso)
            {//Mudando a posição do pedido
                var msgRetorno = string.Format("Pedido {0} gerado no ERP!", NumPedidoECommerce);
                MarcarPosicaoPedido(NumPedidoECommerce
                                   , msgRetorno
                                   , Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPedido_importado()
                                   , EmailCliente
                                   , retorno.numeroPedido.ToString()
                                   , Biblioteca.Dictionaries.Tips.SimNao.Nao
                                   );

                Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                             , "GerarPedidoNoERP"
                             , "Pedido marcado como importado: " + NumPedidoECommerce);
            }
            else
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                             , "GerarPedidoNoERP"
                             , string.Format("Erro na importação do pedido: {0} - erro: {1}"
                                            , NumPedidoECommerce
                                            , retorno.mensagem));
            }
        }

        private void ReceberPedidosPagos()
        {
            //Listar pedidos pendentes de pagamento
            var Pedidos = LojaECommerce.PedidosListar(Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPagamentoAprovado());

            if ((Pedidos != null) && (Pedidos.Count() > 0))
            {
                foreach (var item in Pedidos)
                {
                    var pedido = ObterPedido(item.increment_id);

                    if (pedido != null)
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                     , "ReceberPedidosNovos"
                                     , "Validar pedido e-commerce: " + item.increment_id);
                        if (!string.IsNullOrEmpty(pedido.erp_id_pedido))
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                         , "ReceberPedidosNovos"
                                         , "Pedido e-commerce: " + item.increment_id + " importar pagamento para pedido ERP: " + pedido.erp_id_pedido);
                            PagamentoImportar(pedido, false);
                        }
                        else
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                         , "ReceberPedidosNovos"
                                         , "Pedido e-commerce: " + item.increment_id + " gerar pedido no ERP");

                            GerarPedidoNoERP(item.increment_id, item.customer_email);
                        }
                    }
                }
            }
        }

        private static bool CarregarFormaPagamento(PCPedc pedidoWinthor
                                                  , ECommerce.Magento001.MagentoService.salesOrderInfoCustomEntity pedido)
        {
            bool resultado = false;
            try
            {
                Ecommerceformapagto FormaPagamento = ConfiguracaoPagamento(pedido.payment.cc_type);
                if (FormaPagamento != null)
                {
                    pedidoWinthor.Codcob = FormaPagamento.Codcob;
                    pedidoWinthor.Codplpag = FormaPagamento.Codplpag;
                    resultado = true;
                }
            }
            catch
            {
                resultado = false;
            }

            return resultado;
        }

        private static Ecommerceformapagto ConfiguracaoPagamento(string codigoEcommerce)
        {
            Ecommerceformapagto FormaPagamento = null;
            if (string.IsNullOrEmpty(codigoEcommerce))
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                             , "ConfiguracaoPagamento"
                             , "Código do tipo do pagamento não informado!");
            }
            else
            {
                try
                {
                    string filtro = string.Format(@"    CODCOB                   IS NOT NULL 
                                                AND CODPLPAG                 IS NOT NULL 
                                                AND ECOMMERCE                = 'Magento' 
                                                AND UPPER(CODIGONOECOMMERCE) = UPPER('{0}')
                                                and ROWNUM = 1"
                                                 , codigoEcommerce.ToUpper()
                                                 );
                    FormaPagamento = Ecommerceformapagto.Listar(filtro).FirstOrDefault();
                }
                catch
                {
                    FormaPagamento = null;

                }

                if (FormaPagamento == null)
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                 , "ConfiguracaoPagamento"
                                 , "Configuração de plano de pagamento e cobrança não encontrado para o tipo do e-commerce: " + codigoEcommerce);
                }
            }
            return FormaPagamento;
        }

        private bool ParcelasImportar(salesOrderInfoCustomEntity pedidoECommerce, bool DeveExecutarIntegradora, ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda)
        {
            bool resultado = false;
 
            foreach (var parcelaEcommerce in pedidoECommerce.payment.detalhes)
            {
                decimal valorTotal = 0;
                decimal valorTotalParcelas = 0;
 
                for (int i = 1; i <= parcelaEcommerce.parcelas; i++)
                {
                    Integradora.ERP.Winthor.EntityWinthor.PCPresttemp parcelaPedido = PedidoForcaVenda.NovaParcela();

                    //
                    parcelaPedido.Codcob   = PedidoForcaVenda.Cabecalho.Codcob;
                    parcelaPedido.Codplpag = PedidoForcaVenda.Cabecalho.Codplpag;
                    
                    parcelaPedido.Codcli = PedidoForcaVenda.Cabecalho.Codcli;
                    parcelaPedido.Prest = i.ToString();
                    parcelaPedido.Presttef = parcelaPedido.Prest;
                    parcelaPedido.ESC_Cartaocliente = pedidoECommerce.payment.cc_owner;
                    parcelaPedido.ESC_Cartaonumero = pedidoECommerce.payment.cc_number_enc;
                    parcelaPedido.ESC_Cartaovalidadeano = Convert.ToDecimal(pedidoECommerce.payment.cc_exp_year);
                    parcelaPedido.ESC_Cartaovalidademes = Convert.ToDecimal(pedidoECommerce.payment.cc_exp_month);
                    parcelaPedido.Codusur = PedidoForcaVenda.Cabecalho.Codusur;
                    parcelaPedido.Dttransacaocc = PedidoForcaVenda.Cabecalho.Data;
                    parcelaPedido.NSUTef = Convert.ToString(parcelaEcommerce.nsu);
                    parcelaPedido.CodAutTEF = parcelaEcommerce.auth_code;
                    parcelaPedido.Valor = Math.Round(Convert.ToDecimal(pedidoECommerce.payment.amount_ordered.Replace(".", ",")) / Convert.ToDecimal(parcelaEcommerce.parcelas), 2);
  
                    //Se for pagamento com cartão devera fazer o ajuste do financeiro
                    if (DeveExecutarIntegradora)
                    {
                        PedidoForcaVenda.Cabecalho.ESC_AjustarFinanceiro = string.IsNullOrEmpty(parcelaPedido.NSUTef) ? "N" : "S";
                    }
                    else
                    {
                        PedidoForcaVenda.Cabecalho.ESC_AjustarFinanceiro = "S";
                    }

                    valorTotalParcelas = ( parcelaPedido.Valor * Convert.ToDecimal(parcelaEcommerce.parcelas));

                    if ((valorTotalParcelas != Convert.ToDecimal(pedidoECommerce.payment.amount_ordered.Replace(".", ","))) && (i == 1))
                    {
                        parcelaPedido.Valor = (parcelaPedido.Valor + ( Convert.ToDecimal(pedidoECommerce.payment.amount_ordered.Replace(".", ",")) - valorTotalParcelas));
                    }

                    PedidoForcaVenda.Parcelas.Add(parcelaPedido);
                }

            }

            resultado = true;
            
            return resultado;

        }


        public string PagamentoImportar(ECommerce.Magento001.MagentoService.salesOrderInfoCustomEntity pedidoECommerce, bool p)
        {
            string resultado = "OK";
            string msgRetorno = "";
            try
            {
                PCPedc pedidoWinthor = PCPedc.Listar("NUMPEDWEB = " + pedidoECommerce.increment_id).FirstOrDefault();
                if (pedidoWinthor != null)
                {
                    foreach (var parcelaEcommerce in pedidoECommerce.payment.detalhes)
                    {
                        decimal valorTotal = 0;
                        decimal valorTotalParcelas = 0;

                        for (int i = 1; i <= parcelaEcommerce.parcelas; i++)
                        {
                            //Carregar plano de pagamento
                            CarregarFormaPagamento(pedidoWinthor, pedidoECommerce);

                            Integradora.ERP.Winthor.EntityWinthor.PCPresttemp parcelaPedido = PedidoForcaVenda.NovaParcela();
                            parcelaPedido.Codcob = pedidoWinthor.Codcob;
                            parcelaPedido.Codplpag = PedidoForcaVenda.Cabecalho.Codplpag;

                            parcelaPedido.Numpedweb = pedidoWinthor.Numped;
                            parcelaPedido.Idtitulo = parcelaPedido.Proximo("DFSEQ_PCPRESTTEMP_IDTITULO");
                            parcelaPedido.Integradora = 15;
                            parcelaPedido.Tipointegracao = "A";
                            parcelaPedido.Codcli = pedidoWinthor.Codcli;
                            parcelaPedido.Prest = i.ToString();
                            parcelaPedido.Presttef = parcelaPedido.Prest;
                            parcelaPedido.ESC_Cartaocliente = pedidoECommerce.payment.cc_owner;
                            parcelaPedido.ESC_Cartaonumero = pedidoECommerce.payment.cc_number_enc;
                            parcelaPedido.ESC_Cartaovalidadeano = Convert.ToDecimal(pedidoECommerce.payment.cc_exp_year);
                            parcelaPedido.ESC_Cartaovalidademes = Convert.ToDecimal(pedidoECommerce.payment.cc_exp_month);
                            parcelaPedido.Codusur = pedidoWinthor.Codusur;
                            parcelaPedido.Dtemissao = parcelaPedido.DataServidor();
                            parcelaPedido.Dtinclusao = parcelaPedido.DataHoraServidor();
                            parcelaPedido.Dttransacaocc = parcelaPedido.Dtemissao;
                            parcelaPedido.Dtvenc = parcelaPedido.Dtemissao;
                            parcelaPedido.NSUTef = Convert.ToString(parcelaEcommerce.nsu);
                            parcelaPedido.CodAutTEF = parcelaEcommerce.auth_code;
                            parcelaPedido.Valor = Math.Round(Convert.ToDecimal(parcelaEcommerce.valor_pago) / Convert.ToDecimal(parcelaEcommerce.parcelas), 2);
                            parcelaPedido.Esc_Vldesconto = 0;
                            parcelaPedido.Esc_Vljuros = 0;
                            parcelaPedido.Gravar();

                            ESTPedidofinanceiro pedidoFinanceiro = new ESTPedidofinanceiro();
                            pedidoFinanceiro.Boletoquitado = "N";
                            pedidoFinanceiro.Codusuarioinc = Biblioteca.Dictionaries.Settings.Matricula();
                            pedidoFinanceiro.Dtinclusao = parcelaPedido.Dtinclusao;
                            pedidoFinanceiro.Formapagto = "C";
                            pedidoFinanceiro.Numped = pedidoWinthor.Numped;
                            pedidoFinanceiro.Numtransacao = parcelaPedido.Idtitulo;
                            pedidoFinanceiro.Prest = parcelaPedido.Prest;
                            pedidoFinanceiro.Vlutilizado = parcelaPedido.Valor;
                            pedidoFinanceiro.Gravar();

                            valorTotalParcelas = valorTotalParcelas + pedidoFinanceiro.Vlutilizado;
                        }

                        if (valorTotalParcelas != Convert.ToDecimal(parcelaEcommerce.valor_pago))
                        {
                            valorTotalParcelas = valorTotalParcelas - Convert.ToDecimal(parcelaEcommerce.valor_pago);

                            if (valorTotalParcelas != 0)
                            {
                                pedidoWinthor.ExecutarComando(string.Format(@"UPDATE PCPRESTTEMP  
                                                                     SET VALOR = VALOR + {0}
                                                                   WHERE NUMPED = {1} 
                                                                     AND PREST = '1' "
                                                                            , valorTotalParcelas
                                                                            , pedidoWinthor.Numped.ToString()
                                                                            ));
                            }
                        }
                    }


                    //Marca pedido com pagamento realizado
                    pedidoWinthor.ExecutarComando(string.Format(@"UPDATE PCPEDC  
                                                                     SET CODMOTIVO           = {1}
                                                                       , CODMOTBLOQUEIO      = {2}
                                                                       , CODCOB              = '{3}'
                                                                       , CODPLPAG            = {4}
                                                                    WHERE NUMPED             = {0}"
                                                                , pedidoWinthor.Numped.ToString()
                                                                , Biblioteca.Dictionaries.Settings.CodMotivoBloqueioPagtoAprovado().ToString()
                                                                , Biblioteca.Dictionaries.Settings.CodMotivoBloqueioPagtoAprovado().ToString()
                                                                , pedidoWinthor.Codcob
                                                                , pedidoWinthor.Codplpag.ToString()
                                                                )
                                           );

                    msgRetorno = string.Format("Pedido {0} recebido com sucesso o pagamento!", pedidoECommerce.increment_id);
                    MarcarPosicaoPedido(pedidoECommerce.increment_id
                                       , msgRetorno
                                       , Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPedido_importado()
                                       , pedidoECommerce.customer_email
                                       , pedidoWinthor.Numped.ToString()
                                       , Biblioteca.Dictionaries.Tips.SimNao.Nao
                                       );

                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                 , "PagamentoImportar"
                                 , msgRetorno);
                }
                else
                {
                    if (string.IsNullOrEmpty(pedidoECommerce.erp_id_pedido))
                    {
                        resultado = "Pedido de venda no Winthor não encontrado! Pedido web: " + pedidoECommerce.increment_id;
                        msgRetorno = string.Format("Erro na importação do pedido: {0} - erro: {1}"
                                                  , pedidoECommerce.increment_id
                                                  , resultado);

                        MarcarPosicaoPedido(pedidoECommerce.increment_id
                                           , msgRetorno
                                           , Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPedido_importado()
                                           , pedidoECommerce.customer_email
                                           , ""
                                           , Biblioteca.Dictionaries.Tips.SimNao.Nao
                                           );

                        Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                     , "PagamentoImportar"
                                     , msgRetorno);
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception Ex)
            {
                resultado = Ex.ToString();
            }
            return resultado;

        }

        internal void MarcarPosicaoPedido(string numeroPedidoEcommerce
                                         , string retorno
                                         , string statusPedido
                                         , string email
                                         , string numperoPedidoERP
                                         , Integradora.Biblioteca.Dictionaries.Tips.SimNao notificar)
        {
            try
            {
                LojaECommerce.PedidosAtualizarStatus(numeroPedidoEcommerce                                  //string numeroPedidoECommerce     
                                                    , statusPedido                                          //string novoStatus
                                                    , retorno                                               //string comentario
                                                    , notificar                                             //Integradora.Biblioteca.Dictionaries.Tips.SimNao enviarMsg
                                                    , numperoPedidoERP                                      //string numeroPedidoERP
                                                    , ""                                                    //string numeroPedidoMarketPlace
                                                    , email                                                 //string eMailCliente
                                                    , ""                                                    //string chaveNFe
                                                    , ""                                                    //string serieNF
                                                    , ""                                                    //string numeroNF)
                                                    );
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                                  , "MarcarPosicaoPedido"
                                                  , "Pedido: " + numeroPedidoEcommerce + " erro: " + erro);
            }
        }

        private static bool PedidoJaImportado(string NumPedidoECommerce)
        {
            bool retorno = false;
            try
            { //Carregando o cabeçalho do pedido
                PCPedctemp Cabecalho = PCPedctemp.Listar("NUMPEDCLI = '" + NumPedidoECommerce + "'").FirstOrDefault();
                if (Cabecalho.Numpedrca > 0)
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                 , "PedidoJaImportado"
                                 , "Pedido já existente: " + NumPedidoECommerce);
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            catch (Exception)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                             , "PedidoJaImportado"
                             , "Importando pedido: " + NumPedidoECommerce);
                retorno = false;
            }

            return retorno;
        }

        public RetornoImportacao PedidoImportar(salesOrderInfoCustomEntity pedido, bool DeveExecutarIntegradora)
        {
            RetornoImportacao resultado = new RetornoImportacao();
            bool commitTransacao = false;

            //Grava o xml do pedido
            if (Biblioteca.Dictionaries.Settings.Debugando())
            {
                Biblioteca.Tools.XML.Export(pedido, "Pedido_" + pedido.increment_id);
            }

            ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda = new ERP.Winthor.Domain.PedidoWeb();

            if (!AtualizarCadastroCliente(pedido, PedidoForcaVenda))
            {
                resultado.mensagem = "Erro na validação do cliente";
                return resultado;
            }

            try
            {
                PedidoForcaVenda.PedidoInicializar();
                PedidoForcaVenda.Cabecalho.Codcli = PedidoForcaVenda.Cliente.Codcli;
                PedidoForcaVenda.Cabecalho.Numpedweb = Convert.ToDecimal(pedido.increment_id);
                PedidoForcaVenda.Cabecalho.Numpedcli = pedido.increment_id;

                //PedidoForcaVenda.Cabecalho.Vlfrete = Math.Round(Convert.ToDecimal(pedido.Valorfrete.Replace(".", ",")), 2);
                PedidoForcaVenda.Cabecalho.Codusur = Biblioteca.Dictionaries.Settings.CodRCA();
                PedidoForcaVenda.Cabecalho.Codsupervisor = Biblioteca.Dictionaries.Settings.CodRCA();
                PedidoForcaVenda.Cabecalho.Codfilial = Biblioteca.Dictionaries.Settings.CodFilialVenda();
                PedidoForcaVenda.Cabecalho.Codfilialnf = Biblioteca.Dictionaries.Settings.CodFilialVenda();
                PedidoForcaVenda.Cabecalho.Codplpag = Biblioteca.Dictionaries.Settings.CodPlanoPagamento();
                PedidoForcaVenda.Cabecalho.Codcob = Biblioteca.Dictionaries.Settings.CodCobranca();
                PedidoForcaVenda.Cabecalho.Data = Calendars.ToDateTime(Calendars.ToDateTime(pedido.created_at));
                PedidoForcaVenda.Cabecalho.Dtentrega = PedidoForcaVenda.Cabecalho.Data.AddDays(3);
                //PedidoForcaVenda.Cabecalho.Obsentrega1 = pedido.shipping_method;
                PedidoForcaVenda.Cabecalho.ESC_AjustarFinanceiro = DeveExecutarIntegradora ? "N" : "S";

                foreach (var item in pedido.items)
                {
                    //Classe que representa o item na lista
                    Integradora.ERP.Winthor.EntityWinthor.PCPeditemp itemPedido = null;
                    Int32 codproduto = Numbers.ToInt32(item.sku);
                    if (codproduto > 0)
                    {
                        //Verificando se o produto já esta no pedido
                        itemPedido = PedidoForcaVenda.Itens.Find(l => l.Codprod == Convert.ToDecimal(codproduto));
                        if (itemPedido == null)
                        {   //Inserindo um novo produto
                            itemPedido = PedidoForcaVenda.NovoItemPedido();

                            itemPedido.Numseq = PedidoForcaVenda.Itens.Count + 1;
                            itemPedido.Codprod = codproduto;
                            if (!string.IsNullOrEmpty(item.sku))
                            {
                                string codigoauxiliar = item.sku;
                                if (!string.IsNullOrEmpty(codigoauxiliar))
                                {
                                    itemPedido.Codauxiliar = Convert.ToDecimal(codigoauxiliar);
                                }
                            }
                            itemPedido.Qt = Math.Round(Convert.ToDecimal(item.qty_ordered.Replace(".", ",")), 0);
                            itemPedido.Ptabela = Math.Round(Convert.ToDecimal(item.price.Replace(".", ",")), 4);
                            itemPedido.Pvenda = Math.Round(Convert.ToDecimal(item.price.Replace(".", ",")), 4);

                            if (itemPedido.Ptabela != itemPedido.Pvenda)
                            {
                                //Calculando desconto
                                itemPedido.Perdesc = (1 - (itemPedido.Pvenda / itemPedido.Ptabela)) * 100;
                            }
                            PedidoForcaVenda.Itens.Add(itemPedido);
                        }
                        else
                        {    //Se já estiver no pedido, apenas adiciona a quantidade
                            itemPedido.Qt += Math.Round(Convert.ToDecimal(item.qty_ordered.Replace(".", ",")), 0);
                        }
                    }
                }

                if (pedido.payment.method.ToUpper() != "CASHONDELIVERY")
                {

                    try
                    {
                        //Carregar plano de pagamento
                        string TipoCobranca = "";
                        if (pedido.payment.method.ToUpper() == "BOLETOBANCARIO") 
                        {
                           TipoCobranca = pedido.payment.method;
                        }
                        else
                        {
                           TipoCobranca = pedido.payment.cc_type;
                        }
                        
                        Ecommerceformapagto FormaPagamento = ConfiguracaoPagamento(TipoCobranca);
 
                        if (FormaPagamento == null)
                        {
                            resultado.mensagem = "Plano de pagamento e cobrança não encontrado";
                            return resultado;
                        }
                        else
                        {
                            PedidoForcaVenda.Cabecalho.Codcob = FormaPagamento.Codcob;
                            PedidoForcaVenda.Cabecalho.Codplpag = FormaPagamento.Codplpag;

                            if (TipoCobranca.ToUpper() == "BOLETOBANCARIO")
                            {
                                Integradora.ERP.Winthor.EntityWinthor.PCPresttemp parcelaPedido = PedidoForcaVenda.NovaParcela();
                                parcelaPedido.Codcob = PedidoForcaVenda.Cabecalho.Codcob;
                                parcelaPedido.Codplpag = PedidoForcaVenda.Cabecalho.Codplpag;
                                parcelaPedido.Valor = Math.Round(Convert.ToDecimal(pedido.payment.amount_ordered.Replace(".", ",")), 2);
                                parcelaPedido.Prest = "1";
                                parcelaPedido.Presttef = parcelaPedido.Prest;
                                parcelaPedido.Dttransacaocc = PedidoForcaVenda.Cabecalho.Data;
                                parcelaPedido.ESC_Cartaocliente = pedido.payment.cc_owner;
                                parcelaPedido.ESC_Cartaonumero = pedido.payment.cc_number_enc;
                                parcelaPedido.ESC_Cartaovalidadeano = Convert.ToDecimal(pedido.payment.cc_exp_year);
                                parcelaPedido.ESC_Cartaovalidademes = Convert.ToDecimal(pedido.payment.cc_exp_month);
                                //Se for pagamento com cartão devera fazer o ajuste do financeiro
                                if (DeveExecutarIntegradora)
                                {
                                    PedidoForcaVenda.Cabecalho.ESC_AjustarFinanceiro = string.IsNullOrEmpty(parcelaPedido.NSUTef) ? "N" : "S";
                                }
                                else
                                {
                                    PedidoForcaVenda.Cabecalho.ESC_AjustarFinanceiro = "S";
                                }
                                PedidoForcaVenda.Parcelas.Add(parcelaPedido);

                            }
                            else
                            {
                                if (!ParcelasImportar(pedido, DeveExecutarIntegradora, PedidoForcaVenda))
                                { 
                                    resultado.mensagem = "Erro ao gerar parcelas de cartão.";
                                    return resultado;
                                }
                                
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        resultado.mensagem = "Erro ao obter parcelas: " + ex.ToString();
                        return resultado;
                    }
                }
                //Gravar o cliente (inserindo ou atualizando dados
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        commitTransacao = PedidoForcaVenda.PedidoGravar();
                        if (commitTransacao)
                        {
                            transaction.Commit();

                            resultado.codRCA = PedidoForcaVenda.Cabecalho.Codusur;
                            resultado.numeroPedido = PedidoForcaVenda.Cabecalho.Numpedweb;
                            resultado.sucesso = true;
                            resultado.mensagem = string.Format("Pedido e-commerce {0} gerou o pedido temporário {1} no ERP", pedido.increment_id, PedidoForcaVenda.Cabecalho.Numpedrca.ToString());
                        }
                        else
                        {
                            transaction.Rollback();
                            resultado.sucesso = false;
                            resultado.mensagem = string.Format("Erro ao gravar pedido: {0}!", pedido.increment_id);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        resultado.sucesso = false;
                        resultado.mensagem = string.Format("Erro ao gravar pedido: {0} - Erro: {1}", pedido.increment_id, ex.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.sucesso = false;
                resultado.mensagem = string.Format("Erro ao obteder dados do pedido: {0} - Erro: {1}", pedido.increment_id, ex.ToString());
            }

            if (DeveExecutarIntegradora)
            {
                if (resultado.sucesso)
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                 , "ExecutarIntegradora"
                                 , "Executando a integradora no pedido RCA: " + resultado.numeroPedido.ToString());
                    bool importado = Comum.ExecutarIntegradora(resultado.numeroPedido, resultado.codRCA, PedidoForcaVenda);

                    if (!importado)
                    {
                        resultado.sucesso = false;
                        resultado.mensagem = string.Format("Erro ao importar pedido: {0} na interadora do Winthor", pedido.increment_id);
                    }
                }
            }

            if (resultado.sucesso)
            {
                try
                {
                    resultado.numeroPedido = PCPedctemp.Listar("NUMPEDRCA = " + resultado.numeroPedido.ToString()).FirstOrDefault().Numped;
                    resultado.sucesso = resultado.numeroPedido > 0;
                }
                catch
                {
                    resultado.sucesso = false;
                    resultado.mensagem = "Erro ao obter o número do pedido tempóriario do ERP";
                }
            }
            return resultado;
        }

        private bool AtualizarCadastroCliente(salesOrderInfoCustomEntity pedidoMagento, ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda)
        {
            bool resultado = false;
            try
            {
                customerCustomerEntity cliente = LojaECommerce.ClienteCarregar(Convert.ToInt32(pedidoMagento.customer_id));
                if (cliente == null)
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                 , "AtualizarCadastroCliente"
                                 , "Cliente não informado no pedido");
                    return false;
                }
                string CNPJ_CPF = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(cliente.taxvat);

                if (string.IsNullOrEmpty(CNPJ_CPF))
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                 , "AtualizarCadastroCliente"
                                 , "CNPJ/CPF não informado!");
                    return false;
                }

                //Verifica se o cliente do pedido existe no Winthor
                if (!PedidoForcaVenda.ClienteExiste("REGEXP_REPLACE(CGCENT, '[^0-9]','') = '" + CNPJ_CPF + "'"))
                {
                    //Criando um novo cliente0,
                    PedidoForcaVenda.ClienteInicializar(); 

                    PedidoForcaVenda.Cliente.Codpraca = Biblioteca.Dictionaries.Settings.CodPraca();
                }

                if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Cliente))
                {
                    if (!string.IsNullOrEmpty(cliente.firstname))
                    {
                        PedidoForcaVenda.Cliente.Cliente = Formats.FormatoWinthor(string.Format("{0} {1} {2}", cliente.firstname, cliente.middlename, cliente.lastname));
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(pedidoMagento.billing_firstname))
                        {
                            PedidoForcaVenda.Cliente.Cliente = Formats.FormatoWinthor(string.Format("{0} {1}", pedidoMagento.billing_firstname, pedidoMagento.billing_lastname));
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(pedidoMagento.billing_firstname))
                            {
                                PedidoForcaVenda.Cliente.Cliente = Formats.FormatoWinthor(string.Format("{0} {1}", pedidoMagento.shipping_firstname, pedidoMagento.shipping_lastname));
                            }
                        }
                    }
                }
                if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Fantasia))
                {
                    PedidoForcaVenda.Cliente.Fantasia = PedidoForcaVenda.Cliente.Cliente;
                }
                if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Ieent))
                {
                    PedidoForcaVenda.Cliente.Ieent = "ISENTO";
                }
                if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Cgcent))
                {
                    PedidoForcaVenda.Cliente.Cgcent = cliente.taxvat;
                }
                PedidoForcaVenda.Cliente.Email = string.IsNullOrEmpty(cliente.email) ? "" : cliente.email.ToLower();
                PedidoForcaVenda.Cliente.Site = "MAGENTO";
                PedidoForcaVenda.Cliente.Codcliweb = cliente.customer_id;
                PedidoForcaVenda.Cliente.Dtultcomp = PedidoForcaVenda.Cliente.DataServidor();
                PedidoForcaVenda.Cliente.Dtultvisita = PedidoForcaVenda.Cliente.Dtultcomp;
                if (!string.IsNullOrEmpty(cliente.dob))
                {
                    PedidoForcaVenda.Cliente.Dtnasc = Calendars.ToDateTime(cliente.dob);
                }

                string[] endereco = new string[4];
                char[] delimiters = new char[] { '\r', '\n' };

                endereco = pedidoMagento.shipping_address.street.Split(delimiters);
                if (endereco.Count() > 0)
                {
                    PedidoForcaVenda.Cliente.Enderent = Formats.FormatoWinthor(endereco[0]);
                }
                if (endereco.Count() > 1)
                {
                    PedidoForcaVenda.Cliente.Numeroent = Formats.FormatoWinthor(endereco[1]);
                }
                if (endereco.Count() > 2)
                {
                    PedidoForcaVenda.Cliente.Complementoent = Formats.FormatoWinthor(endereco[2]);
                }
                if (endereco.Count() > 3)
                {
                    PedidoForcaVenda.Cliente.Bairroent = Formats.FormatoWinthor(endereco[3]);
                }
                PedidoForcaVenda.Cliente.Cepent = pedidoMagento.shipping_address.postcode;
                PedidoForcaVenda.Cliente.Estent = LojaECommerce.EstadoCarregar(pedidoMagento.shipping_address.region_id);
                PedidoForcaVenda.Cliente.Municent = Formats.FormatoWinthor(pedidoMagento.shipping_address.city);
                PedidoForcaVenda.Cliente.Faxcli = pedidoMagento.shipping_address.fax;
                PedidoForcaVenda.Cliente.Telent = pedidoMagento.shipping_address.telephone;
                PedidoForcaVenda.Cliente.Telcelent = string.IsNullOrEmpty(pedidoMagento.shipping_address.fax) ? pedidoMagento.shipping_address.telephone : pedidoMagento.shipping_address.fax;
                PedidoForcaVenda.Cliente.Tipodocumento = "C";
                endereco = pedidoMagento.billing_address.street.Split(delimiters);
                if (endereco.Count() > 0)
                {
                    PedidoForcaVenda.Cliente.Endercom = Formats.FormatoWinthor(endereco[0]);
                }
                if (endereco.Count() > 1)
                {
                    PedidoForcaVenda.Cliente.Numerocom = Formats.FormatoWinthor(endereco[1]);
                }
                if (endereco.Count() > 2)
                {
                }
                if (endereco.Count() > 3)
                {
                    PedidoForcaVenda.Cliente.Bairrocom = Formats.FormatoWinthor(endereco[3]);
                }
                if (pedidoMagento.billing_address.region_id != pedidoMagento.shipping_address.region_id)
                {
                    PedidoForcaVenda.Cliente.Estcom = LojaECommerce.EstadoCarregar(pedidoMagento.billing_address.region_id);
                }
                PedidoForcaVenda.Cliente.Municcom = Formats.FormatoWinthor(pedidoMagento.billing_address.city);
                PedidoForcaVenda.Cliente.Cepcom = pedidoMagento.billing_address.postcode;
                PedidoForcaVenda.Cliente.Estcom = PedidoForcaVenda.Cliente.Estent;
                PedidoForcaVenda.Cliente.Endercob = PedidoForcaVenda.Cliente.Enderent;
                PedidoForcaVenda.Cliente.Numerocob = PedidoForcaVenda.Cliente.Numeroent;
                PedidoForcaVenda.Cliente.Bairrocob = PedidoForcaVenda.Cliente.Bairroent;
                PedidoForcaVenda.Cliente.Municcob = PedidoForcaVenda.Cliente.Municent;
                PedidoForcaVenda.Cliente.Estcob = PedidoForcaVenda.Cliente.Estent;
                PedidoForcaVenda.Cliente.Cepcob = PedidoForcaVenda.Cliente.Cepent;

                resultado = true;
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                                  , "AtualizarCadastroCliente"
                                                  , "Pedido: " + pedidoMagento.increment_id.ToString() + " - erro ao montar cadastro do cliente: " + ex.ToString());
                resultado = false;
            }

            //Aplicar no banco de dados
            if (resultado)
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        resultado = PedidoForcaVenda.ClienteGravar();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Receber"
                                                          , "AtualizarCadastroCliente"
                                                          , "Pedido: " + pedidoMagento.increment_id.ToString() + " - erro ao gravar cliente: " + ex.ToString());
                        resultado = false;
                    }
                }
            }
            return resultado;
        }
    }
}

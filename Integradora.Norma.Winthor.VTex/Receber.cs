using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.VTex.Orders;
using Integradora.ERP.Corpem.Entity;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.VTex
{
    public struct RetornoProcessamento
    {
        public void Inicializar()
        {
            numeroPedidoERP = 0;
            codigoRCA = 0;
            sucesso = false;
        }
        public decimal numeroPedidoERP;
        public decimal codigoRCA;
        public bool sucesso;
    }


    public class Receber : IProcessIntegration
    {
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            try
            {
                VTex_enviar_pedidos();
            }
            catch (Exception erro)
            {
                Processo.Notificar("Integradora.Norma.Winthor.VTex.Receber", "Process", erro);
            }
        }

        public void VTex_enviar_pedidos()
        {
            try
            {
                //Classe que irá listar os pedidos
                Integradora.ECommerce.VTex.OrderList.ListaPedido VTexListaPedido = new Integradora.ECommerce.VTex.OrderList.ListaPedido();

                if (VTexListaPedido != null)
                {
                    //Obtendo a lista de pedidos
                    List<string> VTexPedido = VTexListaPedido.Pendentes();
                    if (VTexPedido != null)
                    {
                        if (VTexPedido.Count > 0)
                        {
                            Biblioteca.Tools.XML.Export(VTexPedido, "ListaPedidos.xml");
                            //Verificando a lista de pedidos que retornou
                            foreach (string value in VTexPedido)
                            {
                                //Verificando se o pedido já foi importado 
                                bool ExistePedido = Integradora.ERP.Winthor.Domain.PedidoWeb.PedidoExiste(value);
                                if (!ExistePedido)
                                {    //Verifica o número de vezes que já processo o pedido
                                    if (ESTLogpedidoecommerce.Validar(value, "VTEX"))
                                    {
                                        if (Biblioteca.Dictionaries.Settings.Debugando())
                                        {
                                            Logs.GerarLog("Importando pedido: " + value);
                                        }
                                        //Gravar o novo pedido
                                        VTex_Pedido_Winthor(value);
                                    }
                                }
                                else
                                {
                                    if (!Biblioteca.Dictionaries.Settings.Debugando())
                                    {
                                        Logs.GerarLog("Pedido já existe: " + value + " - enviando notificação a VTEX");
                                        Integradora.ECommerce.VTex.Orders.Pedido VTexPedidoConsulta = new Integradora.ECommerce.VTex.Orders.Pedido();
                                        VTexPedidoConsulta.Consultar(value);
                                        VTexPedidoConsulta.NotificarInicioManuseio(value);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                Processo.Notificar("Integradora.Norma.Winthor.VTex.Receber", "VTex_enviar_pedidos", erro);
            }
        }

        public void VTex_Pedido_Winthor(string numeroPedido)
        {
            try
            {
                RetornoProcessamento retornoProcessamento = new RetornoProcessamento();

                //Classe que irá montar o pedido para ser integrado no Winthor
                Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda = new Integradora.ERP.Winthor.Domain.PedidoWeb();
                Integradora.ECommerce.VTex.Orders.Pedido VTexPedidoConsulta = new Integradora.ECommerce.VTex.Orders.Pedido();
                if ((PedidoForcaVenda != null) && (VTexPedidoConsulta != null))
                {
                    //Obtendo o pedido selecionado
                    Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido = VTexPedidoConsulta.Consultar(numeroPedido);
                    //Verificando se o pedido foi encontrado
                    if (VTexPedido != null)
                    {
                        string status = VTexPedido.status;
                        status = VTexPedido.statusDescription;

                        try
                        {
                            Biblioteca.Tools.JSON.Export(VTexPedido, VTexPedido.sequence.ToString());
                        }
                        catch
                        {
                        }

                        if (!ImportarCliente(PedidoForcaVenda, VTexPedido))
                        { //Senão importou o cliente aborta
                            return;
                        }

                        List<VWFiliais> listaFilais = VWFiliais.Listar(" B.VTEXCODFILIAL IS NOT NULL AND B.VTEXWAREHOUSE IS NOT NULL ORDER BY  B.VTEXCODFILIAL");

                        if (listaFilais.Count() > 0)
                        {
                            bool ExisteMaisDeUmaFilial = listaFilais.Select(l => l.Vtexcodfilial).Distinct().Count() > 1;

                            if (ExisteMaisDeUmaFilial)
                            {
                                string idWarehouse = ObterFilialVenda(VTexPedido);

                                foreach (var item in listaFilais)
                                {
                                    if (item.Vtexwarehouse == idWarehouse)
                                    {
                                        List<VWFiliais> listaunica = new List<VWFiliais>();
                                        listaunica.Add(item);
                                        retornoProcessamento = ImportarPedido(PedidoForcaVenda, VTexPedido, VTexPedidoConsulta, listaunica, 0);
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                retornoProcessamento = ImportarPedido(PedidoForcaVenda, VTexPedido, VTexPedidoConsulta, listaFilais, 0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.VTex.Receber"
                                  , "VTex_Pedido_Winthor"
                                  , string.Format("Erro ao receber o pedido: {0} - erro: {1}", numeroPedido, ex.ToString()));

            }
        }

        public bool ImportarFinanceiro(PCPedctemp Cabecalho
                                       , List<PCPresttemp> Parcelas
                                       , Integradora.ECommerce.VTex.Orders.Pedido VTexPedidoConsulta
                                       , Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido
                                       , ESTMarketplace marketplace)
        {
            bool processado = true;
            foreach (Integradora.ECommerce.VTex.Orders.Transaction transacao in VTexPedido.paymentData.transactions)
            {
                foreach (Integradora.ECommerce.VTex.Orders.Payment parcelas in transacao.payments)
                {
                    decimal total = 0;

                    bool parcelamentoMarketplace = (Cabecalho.Codclirecebedor > 0)
                                                 && (PedidoMarketPlace(VTexPedido)); 


                    if ((parcelas.installments > 0) && (!parcelamentoMarketplace))
                    {
                        if (!CarregarFormaPagamento(Cabecalho, parcelas))
                        {
                            return false;
                        }

                        for (int i = 0; i < parcelas.installments; i++)
                        {
                            PCPresttemp parcelaPedido = new PCPresttemp();

                            if (parcelas.installments != 0)
                            {
                                parcelaPedido.Valor = decimal.Round(((parcelas.value / 100) / parcelas.installments), 2);
                            }
                            else
                            {
                                parcelaPedido.Valor = decimal.Round(((parcelas.value / 100)), 2);
                            }

                            total += parcelaPedido.Valor;
                            parcelaPedido.Idpontovenda = 1; //Indicar para a package ESK_DUPLICATA que e para o cliente a parcela
                            parcelaPedido.Prest = (i + 1).ToString();
                            parcelaPedido.Presttef = parcelaPedido.Prest;
                            //parcelaPedido.NSUTef = Biblioteca.Tools.Numbers.OnlyNumbers( parcelas.connectorResponses.Nsu );
                            parcelaPedido.ESC_Cartaonumero = Biblioteca.Tools.Numbers.OnlyNumbers(parcelas.connectorResponses.Nsu); //Backup do antigo;
                            parcelaPedido.NSUTef = VTexPedidoConsulta.ObterPagamentoNSU(transacao.transactionId, parcelas);
                            parcelaPedido.Dttransacaocc = Cabecalho.Data;
                            //Verificar se deve ser gravado o formato string
                            parcelaPedido.CodAutTEF = Biblioteca.Tools.Numbers.ToInt32(parcelas.connectorResponses.authId);
                            parcelaPedido.ESC_codautorizacaotef = parcelas.connectorResponses.authId;
                            parcelaPedido.Codcob = Cabecalho.Codcob;
                            parcelaPedido.Codplpag = Cabecalho.Codplpag;
                            if (parcelas.connectorResponses.ReturnCode == "0")
                            {//Apenas se for rede
                                Cabecalho.Esc_obternsu = "S";
                            }
                            if (!string.IsNullOrEmpty(parcelaPedido.NSUTef))
                            {//Se for pagamento com cartão devera fazer o ajuste do financeiro
                                Cabecalho.ESC_AjustarFinanceiro = "S";
                            }

                            Parcelas.Add(parcelaPedido);
                        }
                        //Verificando se teve diferença na parcela
                        decimal diferenca = decimal.Round(total - (parcelas.value / 100), 2);
                        if (diferenca != 0)
                        {   //Adiciona a diferença na ultima parcela
                            if (diferenca > 0)
                            {
                                Parcelas.Last().Valor -= diferenca;
                            }
                            else
                            {
                                Parcelas.Last().Valor += (diferenca * -1);
                            }
                        }
                    }
                    else
                    {  //Parcela para o MarketPlace
                        if (PedidoMarketPlace(VTexPedido))
                        {
                            PCPresttemp parcelaPedido = new PCPresttemp();

                            parcelaPedido.Prest = "1";
                            parcelaPedido.Presttef = parcelaPedido.Prest;
                            parcelaPedido.Valor = (Convert.ToDecimal(VTexPedido.value / 100));
                            parcelaPedido.Codcob = Cabecalho.Codcob;
                            parcelaPedido.Codplpag = Cabecalho.Codplpag;
                            parcelaPedido.NSUTef = "1"; //Para o acerto do caixa, conforme e-mail da Rejane nodia 22/01
                            parcelaPedido.Idpontovenda = 2; //Indicar para a package ESK_DUPLICATA que e para o Markteplace a parcela

                            DateTime dataatual = parcelaPedido.DataServidor();

                            switch (marketplace.Tipopagto)
                            {
                                case "F": //Dia fixo
                                    dataatual = GerarDataVencimento(Convert.ToInt16(marketplace.Diavencto));
                                    break;
                                case "D": //Soma dia
                                    dataatual = dataatual.AddDays(Convert.ToInt32(marketplace.Diavencto));
                                    break;
                                case "P": //Calcula período
                                    try
                                    {
                                        ESTMarketplace_periodo PeriodoCondicaoPagamento = ESTMarketplace_periodo.Listar(string.Format("UPPER(MARKETPLACE_ID) = '{0}' AND TO_NUMBER(TO_CHAR(SYSDATE, 'DD')) BETWEEN DIAINICIO AND DIAFINAL", VTexPedido.affiliateId.ToUpper())).Single();
                                        dataatual = GerarDataVencimento(Convert.ToInt16(PeriodoCondicaoPagamento.Diavencto));
                                    }
                                    catch
                                    { //Senão achar joga 30 dias direto
                                        dataatual = dataatual.AddDays(30);
                                    }
                                    break;
                                case "S": //Dia da semana no mês
                                    dataatual = GerarDataVencimentoOracle(marketplace);
                                    break;
                                default:
                                    break;
                            }
                            parcelaPedido.Dtvenc = dataatual;
                            Parcelas.Add(parcelaPedido);
                        }
                    }
                }
                if ((transacao.payments.Count > 1) || //Se tiver mais de uma forma de pagamento devera fazer o ajuste do financeiro
                    (PedidoMarketPlace(VTexPedido)))  //Ou se for marketplace também deve ajustar o financeiro
                {
                    Cabecalho.ESC_AjustarFinanceiro = "S";
                }
            }
            return processado;
        }

        private string ObterFilialVenda(Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido)
        {
            string warehouse = "";
            foreach (var entrega in VTexPedido.shippingData.logisticsInfo)
            {
                foreach (var retira in entrega.deliveryIds)
                {
                    if (!string.IsNullOrEmpty(retira.warehouseId))
                    {
                        warehouse = retira.warehouseId;
                        break;
                    }
                }
            }

            return warehouse;
        }

        private string ObterFilialRetira(Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido
                                      , int posicaolistadeItens
                                      , List<VWFiliais> Filial)
        {
            string codigo = "";
            if (Filial.Count() == 1)
            {
                codigo = Filial.FirstOrDefault().Codigo;
            }
            else
            {

                foreach (var entrega in VTexPedido.shippingData.logisticsInfo)
                {
                    if (entrega.itemIndex == posicaolistadeItens)
                    {
                        foreach (var retira in entrega.deliveryIds)
                        {
                            codigo = Filial.Where(c => c.Vtexwarehouse == retira.warehouseId).FirstOrDefault().Codigo;

                            if (!string.IsNullOrEmpty(codigo))
                            {
                                break;
                            }
                        }
                    }
                }
            }
            return codigo;
        }

        private DateTime GerarDataVencimentoOracle(ESTMarketplace marketplace)
        {
            string script = @"SELECT BASE.DATA datahora
                                FROM ESTMARKETPLACE
                                  , (SELECT (LAST_DAY(TRUNC(SYSDATE)) + 1) --Sempre contar no mês posterior
                                            + ROWNUM-1 DATA                                 
                                        FROM ALL_TABLES                                                    
                                       WHERE ROWNUM<=60) BASE
                               WHERE TO_CHAR(BASE.DATA, 'D') = ESTMARKETPLACE.DIASEMANA
                                 AND TO_CHAR(DATA, 'W') = ESTMARKETPLACE.SEMANANOMES
                                 AND ESTMARKETPLACE.MARKETPLACE_ID = '{0}'
                                 AND ROWNUM = 1";

            script = string.Format(script, marketplace.Marketplace_Id);

            DateTime? retorno = marketplace.GetDataCampo(script);

            return Biblioteca.Tools.Calendars.ToDateTime(retorno);
        }
        private bool ImportarCliente(Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda, Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido)
        {
            bool retorno = true;
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {

                    string CNPJ_CPF = "";
                    if ((!string.IsNullOrEmpty(VTexPedido.clientProfileData.corporateDocument)) && (VTexPedido.clientProfileData.isCorporate))
                    {
                        CNPJ_CPF = VTexPedido.clientProfileData.corporateDocument;
                    }
                    else
                    {
                        CNPJ_CPF = VTexPedido.clientProfileData.document;
                    }

                    CNPJ_CPF = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(CNPJ_CPF);

                    if (CNPJ_CPF == "33863059700")
                    {
                        return false;
                    }
                    bool NovoClientePessoaJuridica = false;

                    if (string.IsNullOrEmpty(CNPJ_CPF))
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.Vtex.Receber"
                                     , "ImportarCliente"
                                     , "CNPJ/CPF não informado!");
                        return false;
                    }

                    //Verifica se o cliente do pedido existe no Winthor
                    if (!PedidoForcaVenda.ClienteExiste("REGEXP_REPLACE(CGCENT, '[^0-9]','') = '" + CNPJ_CPF + "'"))
                    {
                        //Não existindo e feito o cadastro do cliente
                        VTex_Cliente_Winthor(PedidoForcaVenda, VTexPedido);
                        NovoClientePessoaJuridica = CNPJ_CPF.Length > 11; //Verifica se e pessoa fisica
                    }
                    if (PedidoForcaVenda.Cliente == null)
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.VTex", "ImportarCliente", string.Format("Existe mais de um cliente cadastrado para o CNPJ/CPF: {0}, pedido: {1} não será importado!", CNPJ_CPF, VTexPedido.sequence));

                        ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                          , "ImportarCliente"
                                                          , string.Format("Existe mais de um cliente cadastrado para o CNPJ/CPF: {0}, pedido: {1} não será importado!", CNPJ_CPF, VTexPedido.sequence)
                                                          , VTexPedido.orderId
                                                          , Convert.ToDecimal(VTexPedido.sequence)
                                                          , "N"
                                                          , "VTEX");
                        
                        return false;
                    }
                    AtualizarDadosClientes(PedidoForcaVenda, VTexPedido, CNPJ_CPF);
                    //Gravar o cliente (inserindo ou atualizando dados
                    PedidoForcaVenda.ClienteGravar();
                    //Gravar os dados do cliente que esta ligado ao pedido e-commerce
                    PedidoForcaVenda.GravarClienteECommerce(Convert.ToDecimal(VTexPedido.sequence), (Convert.ToDecimal(VTexPedido.value) / 100), 0);

                    if (Biblioteca.Dictionaries.Settings.ValidarClienteJuridico() == "S")
                    {
                        if (NovoClientePessoaJuridica)
                        {
                            ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                              , "ImportarCliente"
                                                              , string.Format("Primeira venda para cliente pessoa jurídica, pedido: {0} - cliente: {1}"
                                                                             , VTexPedido.sequence + ": " + VTexPedido.orderId
                                                                             , PedidoForcaVenda.Cliente.Codcli)
                                                              , VTexPedido.orderId
                                                              , Convert.ToDecimal(VTexPedido.sequence)
                                                              , "N"
                                                              , "VTEX"
                                                              , Biblioteca.Dictionaries.Settings.NumeroTentativaImportarPedido());
                            retorno = false;
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                      , "ImportarCliente"
                                                      , string.Format("Erro ao incluir/alterar cadastro de cliente - pedido: {0} - cliente: {1} - Erro: {2}"
                                                                     , VTexPedido.sequence + ": " + VTexPedido.orderId
                                                                     , PedidoForcaVenda.Cliente.Codcli
                                                                     , ex.Message)
                                                      , VTexPedido.orderId
                                                      , Convert.ToDecimal(VTexPedido.sequence)
                                                      , "N"
                                                      , "VTEX");
                    retorno = false;


                }
            }
            return retorno;
        }

        private static decimal ObterDesconto(decimal PrecoTabela, decimal PrecoVenda)
        {
            decimal resultado = 0;
            if (PrecoTabela != PrecoVenda)
            {
                //Calculando desconto
                if (PrecoTabela != 0)
                {
                    resultado = (1 - (PrecoVenda / PrecoTabela)) * 100;
                }
            }
            return resultado;
        }

        private static decimal ObterPrecoTabela(decimal CodigoProduto, decimal PrecoTabelaNoPedido)
        {
            decimal valor = 0;
            try
            {
                if (CodigoProduto > 0)
                {
                    VWVtexProdutos TabelaPreco = VWVtexProdutos.Listar("CODPROD = " + CodigoProduto.ToString()).FirstOrDefault();
                    if (TabelaPreco != null)
                    {
                        valor = TabelaPreco.Pvenda;
                    }
                    else
                    {
                        valor = PrecoTabelaNoPedido;
                    }
                }
                else
                    valor = 0;
            }
            catch (Exception Ex)
            {
                Logs.GerarLog("ObterPrecoTabela, do produto: " + CodigoProduto.ToString() + " Erro: " + Ex.ToString());
                valor = PrecoTabelaNoPedido;
            }
            return valor;
        }

        private static bool CarregarFormaPagamento(PCPedctemp PedidoERP, Integradora.ECommerce.VTex.Orders.Payment parcelas)
        {
            Ecommerceformapagto FormaPagamento = null;
            string codigoAdquirente = "0";
            bool resultado = false;
            try
            {
                if (parcelas.connectorResponses != null)
                {
                    codigoAdquirente = parcelas.connectorResponses.ReturnCode;
                    if ((string.IsNullOrEmpty(codigoAdquirente)) || (codigoAdquirente == "undefined"))
                    {
                        codigoAdquirente = "0";
                    }
                }
                string filtro = string.Format("CODCOB IS NOT NULL AND CODPLPAG IS NOT NULL AND  ECommerce = 'VTex' AND CODIGONOECOMMERCE = '{0}' AND TIPOADQUIRENTE = '{1}' and ROWNUM = 1"
                                             , parcelas.paymentSystem.PadLeft(2, '0')
                                             , codigoAdquirente);
                FormaPagamento = Ecommerceformapagto.Listar(filtro).Single();
                PedidoERP.Codcob = FormaPagamento.Codcob;
                PedidoERP.Codplpag = FormaPagamento.Codplpag;


                filtro = string.Format("CODPLPAG IS NOT NULL AND ECommerce = 'VTex' AND CODIGONOECOMMERCE = '{0}' AND NUMPARCELA = {1} AND TIPOADQUIRENTE = '{2}' and ROWNUM = 1"
                                      , parcelas.paymentSystem.PadLeft(2, '0')
                                      , parcelas.installments.ToString()
                                      , codigoAdquirente);

                try
                {
                    Ecommerceformapagto_Parcela TipoParcela = Ecommerceformapagto_Parcela.Listar(filtro).Single();
                    if (TipoParcela.Codplpag > 0)
                    {
                        PedidoERP.Codplpag = TipoParcela.Codplpag;
                    }
                }
                catch
                {
                    PedidoERP.Codplpag = FormaPagamento.Codplpag;
                }

                resultado = true;
            }
            catch
            {
                ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                  , "VTex_Pedido_Winthor"
                                                  , string.Format("Não foi possível encontrar a regra de cobrança/Parcela - Código: {0} - Adiquirinte: {1} "
                                                                 , parcelas.paymentSystem.PadLeft(2, '0'), codigoAdquirente)
                                                  , PedidoERP.Numpedcli
                                                  , PedidoERP.Numpedrca
                                                  , "N"
                                                  , "VTEX");
                resultado = false;
            }

            return resultado;
        }

        private static bool FinalizarIntegracaoPedido(decimal numPedido, Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda)
        {
            bool retorno = false;
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    //Obtendo pedido importado para ver se foi realmente gerado
                    if (PedidoForcaVenda.PedidoConsultar(numPedido))
                    {  //Verifica se foi realmente importado com sucesso
                        if (PedidoForcaVenda.Cabecalho.Importado == "S")
                        {
                            PedidoForcaVenda.MovimentacaoFinanceiraBoleto(PedidoForcaVenda.Cabecalho.Numped);
                            ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                              , "FinalizarIntegracaoPedido"
                                                              , "Pedido: " + numPedido.ToString() + " importado."
                                                              , PedidoForcaVenda.Cabecalho.Numpedcli
                                                              , PedidoForcaVenda.Cabecalho.Numpedrca
                                                              , "S"
                                                              , "VTEX");
                            retorno = true;
                        }
                        else
                        {  //Senão notifica o motivo da não importação
                            string msgErro = PedidoForcaVenda.Cabecalho.Observacao_Pc;
                            try
                            {//Pegar lista de erro do cadastro de itens do pedido
                                List<PCPeditemp> itensPedido = PCPeditemp.Listar("NUMPEDRCA = " + numPedido.ToString());
                                foreach (var item in itensPedido)
                                {
                                    if (!string.IsNullOrEmpty(item.Observacao_Pc))
                                    {
                                        msgErro = msgErro + " # " + item.Codprod.ToString() + ": " + item.Observacao_Pc;
                                    }

                                }
                            }
                            catch
                            { }

                            ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                              , "FinalizarIntegracaoPedido"
                                                              , "Pedido: " + numPedido.ToString() + " não importado: " + msgErro
                                                              , PedidoForcaVenda.Cabecalho.Numpedcli
                                                              , PedidoForcaVenda.Cabecalho.Numpedrca
                                                              , "N"
                                                              , "VTEX");
                            //Apagar pedido
                            if (!Biblioteca.Dictionaries.Settings.Debugando())
                            {
                                PedidoForcaVenda.PedidoApagar();
                            }
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception erro)
                {
                    retorno = false;
                    transaction.Rollback();
                    ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                      , "FinalizarIntegracaoPedido"
                                                      , "Pedido: " + numPedido.ToString() + " erro: " + erro
                                                      , PedidoForcaVenda.Cabecalho.Numpedcli
                                                      , PedidoForcaVenda.Cabecalho.Numpedrca
                                                      , "N"
                                                      , "VTEX");
                }
            }
            return retorno;
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
//                    PedidoForcaVenda.IntegrarPedido_Modelo_02(numPedido, PedidoForcaVenda.Cabecalho.Integradora, codRCA);
                    PedidoForcaVenda.IntegrarPedido_Modelo_01(numPedido, codRCA);
                    transaction.Commit();
                    importado = true;
                    if (Biblioteca.Dictionaries.Settings.Debugando())
                    {
                        Logs.GerarLog("Concluido a integradora do Winthor no pedido: " + numPedido.ToString());
                    }
                }
                catch (Exception erro)
                {
                    transaction.Rollback();
                    importado = false;
                    ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                      , "ExecutarIntegradora"
                                                      , "Pedido: " + numPedido.ToString() + " erro: " + erro
                                                      , PedidoForcaVenda.Cabecalho.Numpedcli
                                                      , PedidoForcaVenda.Cabecalho.Numpedrca
                                                      , "N"
                                                      , "VTEX");
                }
            }
            return importado;
        }

        private void VTex_Cliente_Winthor(ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda, Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido)
        {
            try
            {
                //Criando um novo cliente
                PedidoForcaVenda.Cliente = new ERP.Winthor.EntityWinthor.PCClient();
                PedidoForcaVenda.ClienteInicializar();
            }
            catch (Exception erro)
            {
                ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                  , "VTex_Cliente_Winthor"
                                                  , erro.ToString()
                                                  , PedidoForcaVenda.Cabecalho.Numpedcli
                                                  , PedidoForcaVenda.Cabecalho.Numpedrca
                                                  , "N"
                                                  , "VTEX");
            }
        }

        private static void AtualizarDadosClientes(ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda
                                                  , Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido
                                                  , string CNPJ_CPF)
        {
            if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Cliente))
            {
                if (!string.IsNullOrEmpty(VTexPedido.clientProfileData.corporateName))
                {
                    PedidoForcaVenda.Cliente.Empresa = Formats.FormatoWinthor(VTexPedido.clientProfileData.corporateName);
                    PedidoForcaVenda.Cliente.Cliente = PedidoForcaVenda.Cliente.Empresa;
                }
                else
                {
                    PedidoForcaVenda.Cliente.Cliente = Formats.FormatoWinthor(VTexPedido.clientProfileData.firstName + " " + VTexPedido.clientProfileData.lastName);
                }
            }
            if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Fantasia))
            {
                PedidoForcaVenda.Cliente.Fantasia = Formats.FormatoWinthor(VTexPedido.shippingData.address.receiverName);
            }
            if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Ieent))
            {
                PedidoForcaVenda.Cliente.Ieent = string.IsNullOrEmpty(VTexPedido.clientProfileData.stateInscription) ? "ISENTO" : Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(VTexPedido.clientProfileData.stateInscription);
            }
            if (string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Cgcent))
            {
                PedidoForcaVenda.Cliente.Cgcent = CNPJ_CPF;
            }
            PedidoForcaVenda.Cliente.Enderent = Formats.FormatoWinthor(VTexPedido.shippingData.address.street);
            PedidoForcaVenda.Cliente.Bairroent = Formats.FormatoWinthor(VTexPedido.shippingData.address.neighborhood);
            PedidoForcaVenda.Cliente.Complementoent = Formats.FormatoWinthor(VTexPedido.shippingData.address.complement);
            PedidoForcaVenda.Cliente.Numeroent = Formats.FormatoWinthor(VTexPedido.shippingData.address.number);
            PedidoForcaVenda.Cliente.Municent = Formats.FormatoWinthor(VTexPedido.shippingData.address.city);
            PedidoForcaVenda.Cliente.Estent = Formats.FormatoWinthor(VTexPedido.shippingData.address.state);
            PedidoForcaVenda.Cliente.Paisent = Formats.FormatoWinthor(VTexPedido.shippingData.address.country);
            PedidoForcaVenda.Cliente.Pontorefer = Formats.FormatoWinthor(VTexPedido.shippingData.address.reference);
            PedidoForcaVenda.Cliente.Site = "VTEX";
            PedidoForcaVenda.Cliente.Dtultcomp = PedidoForcaVenda.Cliente.DataServidor();
            PedidoForcaVenda.Cliente.Dtultvisita = PedidoForcaVenda.Cliente.Dtultcomp;
            PedidoForcaVenda.Cliente.Email = string.IsNullOrEmpty(VTexPedido.clientProfileData.email) ? "" : VTexPedido.clientProfileData.email.ToLower();

            if (!string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Email))
            {
                //Retirar o sufixo da criptografia SOFT
                PedidoForcaVenda.Cliente.Email = PedidoForcaVenda.Cliente.Email.Replace("-1b.ct.vtex.com.br", "");
                PedidoForcaVenda.Cliente.Email = PedidoForcaVenda.Cliente.Email.Replace("-2b.ct.vtex.com.br", "");
                PedidoForcaVenda.Cliente.Email = PedidoForcaVenda.Cliente.Email.Replace("-3b.ct.vtex.com.br", "");
                PedidoForcaVenda.Cliente.Email = PedidoForcaVenda.Cliente.Email.Replace("-4b.ct.vtex.com.br", "");
                PedidoForcaVenda.Cliente.Email = PedidoForcaVenda.Cliente.Email.Replace("-5b.ct.vtex.com.br", "");
                PedidoForcaVenda.Cliente.Email = PedidoForcaVenda.Cliente.Email.Replace("-6b.ct.vtex.com.br", "");
                PedidoForcaVenda.Cliente.Email = PedidoForcaVenda.Cliente.Email.Replace("-7b.ct.vtex.com.br", "");
                PedidoForcaVenda.Cliente.Email = PedidoForcaVenda.Cliente.Email.Replace("-8b.ct.vtex.com.br", "");
                PedidoForcaVenda.Cliente.Email = PedidoForcaVenda.Cliente.Email.Replace("-9b.ct.vtex.com.br", "");
                //Retirar a criptografia
                if (PedidoForcaVenda.Cliente.Email.Contains("ct.vtex.com.br") && (string.IsNullOrEmpty(VTexPedido.affiliateId)))
                {
                    Integradora.ECommerce.VTex.Orders.Pedido VTexPedidoConsulta = new Integradora.ECommerce.VTex.Orders.Pedido();
                    var emailtratado = VTexPedidoConsulta.EmailDescriptografado(PedidoForcaVenda.Cliente.Email);
                    if (!string.IsNullOrEmpty(emailtratado))
                    {
                        PedidoForcaVenda.Cliente.Email = emailtratado;
                        PedidoForcaVenda.Cliente.Emailnfe = emailtratado;
                    }
                }
            }

            if (!string.IsNullOrEmpty(VTexPedido.shippingData.address.postalCode))
            {
                PedidoForcaVenda.Cliente.Cepent = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(VTexPedido.shippingData.address.postalCode);
            }
            if (!string.IsNullOrEmpty(VTexPedido.clientProfileData.document))
            {
                PedidoForcaVenda.Cliente.Cgcentrega = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(VTexPedido.clientProfileData.document);
            }
            if (!string.IsNullOrEmpty(VTexPedido.clientProfileData.phone))
            {
                PedidoForcaVenda.Cliente.Telent = VTexPedido.clientProfileData.phone;
                if (PedidoForcaVenda.Cliente.Telent.Length > 5)
                {
                    if (!string.IsNullOrEmpty(PedidoForcaVenda.Cliente.Telent))
                    {
                        if (PedidoForcaVenda.Cliente.Telent.Substring(0, 3) == "+55")
                        {
                            PedidoForcaVenda.Cliente.Telent = Integradora.Biblioteca.Tools.Formats.Telefone(PedidoForcaVenda.Cliente.Telent.Substring(3));
                        }
                    }
                }

                PedidoForcaVenda.Cliente.Telcob = PedidoForcaVenda.Cliente.Telent;
            }
            if (!string.IsNullOrEmpty(VTexPedido.clientProfileData.corporatePhone))
            {
                PedidoForcaVenda.Cliente.Telempr = Integradora.Biblioteca.Tools.Formats.Telefone(VTexPedido.clientProfileData.corporatePhone);
            }

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
        }

        private static DateTime GerarDataVencimento(int DiaVencimento)
        {
            //Obtem o último dia do mês corrente
            DateTime ultimoDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            //Compara o último dia do mês com o dia do vencimento, se dia do vencimento for maior, assume o último dia do mês
            if (DiaVencimento > ultimoDia.Day)
            {
                DiaVencimento = ultimoDia.Day;
            }

            //Variavel para obter a data atual a ser comparado
            DateTime dataatual = DateTime.Now;
            if (dataatual.Day > DiaVencimento - 3)
            {
                dataatual = dataatual.AddMonths(1);
            }
            DateTime datanovaFixo = new DateTime(dataatual.Year, dataatual.Month, DiaVencimento, 0, 0, 0);
            return datanovaFixo;
        }

        private bool PedidoMarketPlace(Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido)
        {
            //Lista de marketplace que deverão seguir o fluxo normal.
            List<string> MarketplaceExclusos = new List<string> { "RFR" };

            bool resultado = false;

            //A sigla do Marketplace deve ser enviado
            resultado = !string.IsNullOrEmpty(VTexPedido.affiliateId);
            if (resultado)
            {   //Mesmo com a sigla, alguns não serão tratados como Marketplace
                resultado = !MarketplaceExclusos.Contains(VTexPedido.affiliateId.ToUpper());
            }

            return resultado;
        }


        private RetornoProcessamento ImportarPedido(Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda
                                                   , Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido
                                                   , Integradora.ECommerce.VTex.Orders.Pedido VTexPedidoConsulta
                                                   , List<VWFiliais> Filial
                                                   , int prefixoPedido)
        {
            RetornoProcessamento retorno = new RetornoProcessamento();
            retorno.Inicializar();

            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    ESTMarketplace marketplace = null;

                    //Importar o pedido de venda
                    PedidoForcaVenda.PedidoInicializar();
                    PedidoForcaVenda.Cabecalho.Codfilial = Filial.FirstOrDefault().Vtexcodfilial; // ObterFilialVenda(VTexPedido, PedidoForcaVenda);
                    PedidoForcaVenda.Cabecalho.Codfilialnf = PedidoForcaVenda.Cabecalho.Codfilial;
                    PedidoForcaVenda.Cabecalho.Numpedcli = VTexPedido.orderId;
                    PedidoForcaVenda.Cabecalho.Data = Convert.ToDateTime(VTexPedido.creationDate);
                    PedidoForcaVenda.Cabecalho.Obsentrega4 = Formats.FormatoWinthor(VTexPedido.shippingData.address.reference);
                    PedidoForcaVenda.Cabecalho.Esc_obternsu = "N";
                    if (prefixoPedido > 0)
                    {
                        PedidoForcaVenda.Cabecalho.Numpedrca = Convert.ToDecimal(VTexPedido.sequence + prefixoPedido.ToString().PadLeft(3, '0'));
                    }
                    else
                    {
                        PedidoForcaVenda.Cabecalho.Numpedrca = Convert.ToDecimal(VTexPedido.sequence);
                    }

                    #region Utiliza processo do Marketplace
                    if (PedidoMarketPlace(VTexPedido))
                    {
                        PedidoForcaVenda.Cabecalho.Obs2 = VTexPedido.affiliateId.ToUpper();
                        PedidoForcaVenda.Cabecalho.Integradora = 12; //Para identificar que e um pedido do tipo Marketplace
                        try
                        {
                            marketplace = ESTMarketplace.Listar(string.Format("UPPER(MARKETPLACE_ID) = '{0}'", PedidoForcaVenda.Cabecalho.Obs2)).Single();
                            PedidoForcaVenda.Cabecalho.Codusur = marketplace.Codusur;
                            PedidoForcaVenda.Cabecalho.Codcob = marketplace.Codcob;
                            PedidoForcaVenda.Cabecalho.Codplpag = marketplace.Codplpag;
                            PedidoForcaVenda.Cabecalho.Codclirecebedor = marketplace.Codcli;

                            //Validar percentual de diferença
                            if (marketplace.Prcdiferencavltotal > 0)
                            {
                                decimal valorPedidoVTex = (Convert.ToDecimal(VTexPedido.value) / 100);
                                decimal valorParcelaVTex = 0;
                                foreach (Integradora.ECommerce.VTex.Orders.Transaction transacao in VTexPedido.paymentData.transactions)
                                {
                                    foreach (Integradora.ECommerce.VTex.Orders.Payment parcelas in transacao.payments)
                                    {
                                        valorParcelaVTex = valorParcelaVTex + (Convert.ToDecimal(parcelas.value) / 100);
                                    }
                                }

                                if (valorPedidoVTex != valorParcelaVTex)
                                {
                                    decimal percentualDiferencaEncontrado = (((valorParcelaVTex - valorPedidoVTex) * 100) / valorPedidoVTex);
                                    if (percentualDiferencaEncontrado > marketplace.Prcdiferencavltotal)
                                    {
                                        bool JaFoiAutorizado = false;
                                        try
                                        {
                                            ESTCliente_ECommerce clientecommerce = ESTCliente_ECommerce.Listar("NUMPEDRCA = " + VTexPedido.sequence).Single();

                                            JaFoiAutorizado = clientecommerce.Dtliberacaomp != null;
                                        }
                                        catch
                                        {
                                            JaFoiAutorizado = false;
                                        }

                                        if (!JaFoiAutorizado)
                                        {
                                            ESTCliente_ECommerce logPedidoCliente = null;
                                            try
                                            {
                                                logPedidoCliente = ESTCliente_ECommerce.Listar(string.Format("CODCLI = {0} AND NUMPEDRCA = {1}", PedidoForcaVenda.Cliente.Codcli, VTexPedido.sequence)).FirstOrDefault();
                                                if (logPedidoCliente.Codcli == 0)
                                                    logPedidoCliente = null;
                                            }
                                            catch
                                            {
                                                logPedidoCliente = null;
                                            }

                                            if (logPedidoCliente == null)
                                            {
                                                PedidoForcaVenda.GravarClienteECommerce(Convert.ToDecimal(VTexPedido.sequence), valorPedidoVTex, valorParcelaVTex);
                                            }
                                            else
                                            {
                                                logPedidoCliente.Vlparcelas = valorParcelaVTex;
                                                logPedidoCliente.Vlpedido = valorPedidoVTex;
                                                logPedidoCliente.Gravar();
                                            }

                                            ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                                              , "VTex_Pedido_Winthor"
                                                                              , string.Format("Percentual diferença do valor em pedido marketplace, pedido: {0} - marketplace: {1} - valor pedido: {2} - valor parcela: {3} - perc dif.: {4}"
                                                                                             , VTexPedido.sequence + ": " + VTexPedido.orderId
                                                                                             , marketplace.Marketplace_Id
                                                                                             , valorPedidoVTex.ToString()
                                                                                             , valorParcelaVTex.ToString()
                                                                                             , percentualDiferencaEncontrado.ToString()
                                                                                             )
                                                                              , VTexPedido.orderId
                                                                              , Convert.ToDecimal(VTexPedido.sequence)
                                                                              , "N"
                                                                              , "VTEX"
                                                                              , Biblioteca.Dictionaries.Settings.NumeroTentativaImportarPedido());
                                            transaction.Commit();
                                            return retorno;
                                        }
                                    }
                                }
                            }
                        }
                        catch
                        {
                            ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                              , "VTex_Pedido_Winthor"
                                                              , string.Format("Cadastro do marketplace não encontrado, pedido: {0} - sigla: {1}", PedidoForcaVenda.Cabecalho.Numpedcli, PedidoForcaVenda.Cabecalho.Obs2)
                                                              , PedidoForcaVenda.Cabecalho.Numpedcli
                                                              , PedidoForcaVenda.Cabecalho.Numpedrca
                                                              , "N"
                                                              , "VTEX");
                            return retorno;
                        }
                    }
                    #endregion

                    if (VTexPedido.marketingData != null)
                    {
                        if (!String.IsNullOrEmpty(VTexPedido.marketingData.utmSource))
                        {
                            string novoVendedor = Biblioteca.Tools.Numbers.OnlyNumbers(VTexPedido.marketingData.utmSource);
                            if (!String.IsNullOrEmpty(novoVendedor))
                            {
                                PCUsuari RCA = PCUsuari.Listar("CODUSUR = " + novoVendedor).FirstOrDefault();
                                if (RCA != null)
                                {
                                    PedidoForcaVenda.Cabecalho.Codusur = RCA.Codusur;
                                    PedidoForcaVenda.Cabecalho.Codsupervisor = RCA.Codsupervisor;
                                }
                            }
                        }
                    }
                    foreach (Integradora.ECommerce.VTex.Orders.Total item in VTexPedido.totals)
                    {
                        //Obtendo frete 
                        if (item.id == "Shipping")
                        {
                            PedidoForcaVenda.Cabecalho.Vlfrete = item.value / 100;
                        }
                    }

                    foreach (var item in VTexPedido.shippingData.logisticsInfo)
                    {
                        if (!string.IsNullOrEmpty(item.selectedSla))
                        {
                            PedidoForcaVenda.Cabecalho.Obsentrega1 = string.Format("Transp.: {0} - {1} ", item.deliveryCompany, item.selectedSla);
                        }
                        else
                        {
                            PedidoForcaVenda.Cabecalho.Obsentrega1 = "Transportadora: " + item.deliveryCompany;
                        }
                        PedidoForcaVenda.Cabecalho.Obsentrega2 = "Data estimada: " + item.shippingEstimateDate;
                        PedidoForcaVenda.Cabecalho.Obsentrega3 = "Estimativa entrega: " + item.shippingEstimate;

                        DateTime dataEntrega = Convert.ToDateTime(item.shippingEstimateDate);
                        if (dataEntrega.Date < DateTime.Now.Date)
                            dataEntrega = DateTime.Now.Date.AddDays(3);
                        PedidoForcaVenda.Cabecalho.Dtentrega = Convert.ToDateTime( dataEntrega.Date.ToShortDateString());

                        break; //Para o laço uma vez encontrado o registro
                    }
                    int posicaolistadeItens = -1;
                    foreach (Integradora.ECommerce.VTex.Orders.Item item in VTexPedido.items)
                    {
                        //Classe que representa o item na lista
                        Integradora.ERP.Winthor.EntityWinthor.PCPeditemp itemPedido = null;
                        //Incrementando o itemIndex do produto
                        posicaolistadeItens++;
                        //Lista de produto entrega
                        LogisticsInfo ProdutoEntrega = VTexPedido.shippingData.logisticsInfo.Where(c => c.itemIndex == posicaolistadeItens).FirstOrDefault();

                        bool ExisteAProdutoNaFilial = ProdutoEntrega != null;
                        if (ExisteAProdutoNaFilial)
                        {
                            foreach (var Filialitem in Filial)
                            {
                                ExisteAProdutoNaFilial = (ProdutoEntrega.deliveryIds.Where(c => c.warehouseId == Filialitem.Vtexwarehouse).Count()) > 0;

                                if (ExisteAProdutoNaFilial)
                                    break;
                            }
                        }

                        if (ExisteAProdutoNaFilial)
                        {
                            if (item.components.Count == 0)
                            {
                                if (PedidoForcaVenda.ProdutoExiste(item.productId))
                                {
                                    //Verificando se o produto já esta no pedido
                                    itemPedido = PedidoForcaVenda.Itens.Find(l => l.Codprod == Convert.ToDecimal(item.productId));
                                    if (itemPedido == null)
                                    {   //Inserindo um novo produto
                                        itemPedido = PedidoForcaVenda.NovoItemPedido();

                                        itemPedido.Numseq = PedidoForcaVenda.Itens.Count + 1;
                                        itemPedido.Codprod = Convert.ToDecimal(item.productId);
                                        itemPedido.Codauxiliar = Numbers.ToInt64(item.ean);
                                        itemPedido.Qt = item.quantity;

                                        //Obter preço tabela
                                        itemPedido.Ptabela = item.listPrice / 100; //Este esta gravado no pedido
                                        itemPedido.Ptabela = ObterPrecoTabela(itemPedido.Codprod, itemPedido.Ptabela); //Vai buscar no Winthor o preço tabela atual
                                        itemPedido.Pvenda = item.sellingPrice / 100;
                                        itemPedido.Perdesc = ObterDesconto(itemPedido.Ptabela, itemPedido.Pvenda);
                                        itemPedido.Codfilialretira = ObterFilialRetira(VTexPedido, posicaolistadeItens, Filial);

                                        PedidoForcaVenda.Itens.Add(itemPedido);
                                    }
                                    else
                                    {    //Se já estiver no pedido, apenas adiciona a quantidade
                                        itemPedido.Qt += item.quantity;
                                    }
                                }

                            }
                            else
                            {
                                foreach (Integradora.ECommerce.VTex.Orders.Component componente in item.components)
                                {
                                    //Verificando se o produto já esta no pedido
                                    itemPedido = PedidoForcaVenda.Itens.Find(l => l.Codprod == Convert.ToDecimal(componente.id));
                                    if (itemPedido == null)
                                    {   //Inserindo um novo produto
                                        itemPedido = PedidoForcaVenda.NovoItemPedido();
                                        itemPedido.Codprodcesta = Convert.ToDecimal(item.productId);

                                        itemPedido.Codprod = Convert.ToDecimal(componente.id);
                                        itemPedido.Numseq = PedidoForcaVenda.Itens.Count + 1;
                                        itemPedido.Codauxiliar = Convert.ToDecimal(componente.ean);
                                        itemPedido.Qt = componente.quantity * item.quantity;
                                        //Obter preço tabela
                                        itemPedido.Ptabela = componente.price / 100; //Este esta gravado no pedido
                                        itemPedido.Ptabela = ObterPrecoTabela(itemPedido.Codprod, itemPedido.Ptabela); //Vai buscar no Winthor o preço tabela atual
                                        itemPedido.Pvenda = componente.sellingPrice / 100;
                                        itemPedido.Perdesc = ObterDesconto(itemPedido.Ptabela, itemPedido.Pvenda);
                                        itemPedido.Codfilialretira = ObterFilialRetira(VTexPedido, posicaolistadeItens, Filial);

                                        PedidoForcaVenda.Itens.Add(itemPedido);
                                    }
                                    else
                                    {    //Se já estiver no pedido, apenas adiciona a quantidade
                                        itemPedido.Qt += (componente.quantity * item.quantity);
                                    }
                                }
                            }
                        }
                    }

                    if (PedidoForcaVenda.Itens.Count > 0)
                    {
                        //Validar estoque
                        bool FaltaEstoque = false;
                        foreach (var item in PedidoForcaVenda.Itens)
                        {
                            try
                            {
                                PCEst estoque = PCEst.Listar(string.Format("CODFILIAL = '{0}' AND CODPROD = {1}", item.Codfilialretira, item.Codprod)).Single();
                                if ((estoque.Qtestger - estoque.Qtbloqueada - estoque.Qtreserv - estoque.Qtpendente) < item.Qt)
                                {
                                    FaltaEstoque = true;
                                    ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                                      , "VTex_Pedido_Winthor"
                                                                      , string.Format("Produto sem estoque! Pedido: {0} - Filial: {1} - Produto: {2} - Qt. Estoque: {3} - Qt. venda: {4}"
                                                                                     , PedidoForcaVenda.Cabecalho.Numpedcli
                                                                                     , item.Codfilialretira
                                                                                     , item.Codprod.ToString()
                                                                                     , (estoque.Qtestger - estoque.Qtbloqueada - estoque.Qtreserv - estoque.Qtpendente).ToString()
                                                                                     , item.Qt.ToString()
                                                                                     )
                                                                      , PedidoForcaVenda.Cabecalho.Numpedcli
                                                                      , PedidoForcaVenda.Cabecalho.Numpedrca
                                                                      , "N"
                                                                      , "VTEX");
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {
                                FaltaEstoque = true;
                                ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                                  , "VTex_Pedido_Winthor"
                                                                  , "Validar estoque do pedido:  " + retorno.numeroPedidoERP.ToString() + " - Erro: " + ex.ToString()
                                                                  , PedidoForcaVenda.Cabecalho.Numpedcli
                                                                  , PedidoForcaVenda.Cabecalho.Numpedrca
                                                                  , "N"
                                                                  , "VTEX");
                                break;
                            }
                        }

                        if (!FaltaEstoque)
                        {
                            retorno.sucesso = ImportarFinanceiro(PedidoForcaVenda.Cabecalho
                                                                , PedidoForcaVenda.Parcelas
                                                                , VTexPedidoConsulta
                                                                , VTexPedido
                                                                , marketplace);
                            if (retorno.sucesso)
                            {
                                //Gravar o cliente (inserindo ou atualizando dados
                                retorno.sucesso = PedidoForcaVenda.PedidoGravar();
                                if (retorno.sucesso)
                                {
                                    retorno.numeroPedidoERP = PedidoForcaVenda.Cabecalho.Numpedweb;
                                    retorno.codigoRCA = PedidoForcaVenda.Cabecalho.Codusur;
                                }
                            }
                            else
                            {
                                retorno.Inicializar();
                            }
                        }
                    }
                    else
                    {
                        ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                          , "VTex_Pedido_Winthor"
                                                          , "Nenhum produto encontrado para o pedido: " + PedidoForcaVenda.Cabecalho.Numpedcli
                                                          , PedidoForcaVenda.Cabecalho.Numpedcli
                                                          , PedidoForcaVenda.Cabecalho.Numpedrca
                                                          , "N"
                                                          , "VTEX");
                        retorno.Inicializar();
                    }

                    if (retorno.sucesso)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        transaction.Rollback();
                    }
                }
                catch (Exception erro)
                {
                    ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.VTex.Receber"
                                                      , "VTex_Pedido_Winthor"
                                                      , "Gravando o pedido:  " + retorno.numeroPedidoERP + " - Erro: " + erro
                                                      , PedidoForcaVenda.Cabecalho.Numpedcli
                                                      , PedidoForcaVenda.Cabecalho.Numpedrca
                                                      , "N"
                                                      , "VTEX");
                    retorno.Inicializar();
                }
            } //Fim do using

            //Executar a integradora do Winthor *
            if (retorno.sucesso)
            {
                retorno.sucesso = ExecutarIntegradora(retorno.numeroPedidoERP, retorno.codigoRCA, PedidoForcaVenda);
                if (retorno.sucesso)
                {//Notificar que o pedido foi recebido com sucesso
                    if (FinalizarIntegracaoPedido(retorno.numeroPedidoERP, PedidoForcaVenda))
                    {
                        VTexPedidoConsulta.NotificarInicioManuseio(PedidoForcaVenda.Cabecalho.Numpedcli);
                    }
                }
                retorno.Inicializar();
            }
            return retorno;
        }
    }
}

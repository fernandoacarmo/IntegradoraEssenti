using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ECommerce.Magento002.MagentoService;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Magento002
{
    public class Receber : IProcessIntegration
    {
        public Integradora.ECommerce.Magento002.Integracao LojaECommerce { get; set; }
        public Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda { get; set; }

        public Receber()
        {
            LojaECommerce = new ECommerce.Magento002.Integracao();
            PedidoForcaVenda = new ERP.Winthor.Domain.PedidoWeb();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
                VerificarPedidosAReceberCartao();
                VerificarPedidosAImportar();
        }

        private void VerificarPedidosAReceberCartao()
        {
            //Listar pedidos pendentes de pagamento
            var Pedidos = LojaECommerce.PedidosListar(Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPedido_pendentepagamento());

            if ((Pedidos != null) && (Pedidos.Count() > 0))
            {
                foreach (var item in Pedidos)
                {
                    string retorno = "";
                    if (!PedidoJaImportado(item))
                    {
                        var pedido = LojaECommerce.PedidosCarregar(item.increment_id);

                        if (pedido != null)
                        {
                            switch (pedido.payment.method.ToUpper())
                            {
                                case "MCARD" : retorno = PedidoImportar(pedido, false);
                                    break;
                                case "CCSAVE": retorno = PedidoImportar(pedido, false);
                                    break;
                                default:
                                    retorno = "IGNORAR";
                                    break; //Não faz nada                                    
                            }
                        }
                    }
                    else
                    {
                        retorno = "Pedido já importado";
                    }

                    if (retorno == "OK")
                    {
                        Comum.MarcarPosicaoPedido(LojaECommerce
                                                 , item.increment_id
                                                 , "Pedido recebido com sucesso, aguardando o pagamento!"
                                                 , Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPagamentoAguardando()
                                                 , item.customer_email
                                                 );

                        Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
                                     , "VerificarPedidosAReceberCartao"
                                     , "Pedido marcado como aguardando pagamento: " + item.increment_id);
                    }
                    else
                    {
                        if (retorno != "IGNORAR")
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
                                         , "VerificarPedidosAReceberCartao"
                                         , string.Format("Erro na importação do pedido: {0} - erro: {1}"
                                                        , item.increment_id
                                                        , retorno));
                        }
                    }
                }
            }
        }

        private void VerificarPedidosAImportar()
        {
            //Listar pedidos pendentes de importacao para gerar o pedido do Winthor
            var Pedidos = LojaECommerce.PedidosListar(Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPedido_pesquisa());
            //Verifica se existe epdidos
            if ((Pedidos != null) && (Pedidos.Count() > 0))
            {//Listando os pedidos
                foreach (var item in Pedidos)
                {
                    string retorno = "";
                    if (!PedidoJaImportado(item))
                    {//Carregando pedido
                        var pedido = LojaECommerce.PedidosCarregar(item.increment_id);

                        if (pedido != null)
                        {
                            retorno = PedidoImportar(pedido, true);
                        }
                    }
                    else
                    {
                        retorno = "Pedido já importado";
                    }

                    if (retorno != "OK")
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
                                     , "VerificarPedidosAImportar"
                                     , string.Format("Erro na importação do pedido: {0} - erro: {1}"
                                                    , item.increment_id
                                                    , retorno));
                    }
                    else
                    {//Mudando a posição do pedido
                        Comum.MarcarPosicaoPedido(LojaECommerce
                                                 , item.increment_id
                                                 , "Pagamento realizado com sucesso! Seu pedido está sendo preparado para entrega."
                                                 , Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPedido_importado()
                                                 , item.customer_email);

                        Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
                                     , "VerificarPedidosAImportar"
                                     , "Pedido marcado como importado: " + item.increment_id);
                    }
                }
            }
            else
            {
                if (Biblioteca.Dictionaries.Settings.Debugando())
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
                                 , "VerificarPedidosAImportar"
                                 , "Nenhum pedido para ser importado");
                }
            }
        }

        private static bool PedidoJaImportado(salesOrderListEntity item)
        {
            bool retorno = false;
            try
            { //Carregando o cabeçalho do pedido
                PCPedctemp Cabecalho = PCPedctemp.Listar("NUMPEDCLI = '" + item.increment_id + "'").FirstOrDefault();
                if (Cabecalho.Numpedrca > 0)
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
                                 , "PedidoJaImportado"
                                 , "Pedido já existente: " + item.increment_id);
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            catch (Exception)
            {
                //Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
                //             , "PedidoJaImportado"
                //             , "Importando pedido: " + item.increment_id);
                retorno = false;
            }

            return retorno;
        }

        public string PedidoReceber(salesOrderEntity pedido)
        {
            string retorno = "OK";
            if (pedido != null)
            {
                TcpClient cliente = new TcpClient();
                cliente.Connect("1", 1);
                try
                {
                    byte[] buffer = new byte[12];  // length of the text "Hello world!"
                    try
                    { // receive data with timeout 10s
                        Sockets.Receive(cliente.Client, buffer, 0, buffer.Length, 10000);
                        string str = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                    }
                    catch (Exception ex)
                    { /* ... */
                        Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
                                     , "ExecutarIntegradora"
                                     , string.Format("Erro ao efetuar o pagamento do pedido: {0} - Erro: {1}"
                                                    , pedido.increment_id, ex.ToString()));
                    }
                }
                finally
                {
                    cliente.Close();
                }
            }
            return retorno;
        }

        public string PedidoImportar(salesOrderEntity pedido, bool DeveExecutarIntegradora)
        {
            decimal numPedido = 0;
            decimal codRCA = 0;
            bool commitTransacao = false;
            string resultado = "";

            //Grava o xml do pedido
            if (Biblioteca.Dictionaries.Settings.Debugando())
            {
                Biblioteca.Tools.XML.Export(pedido, "Pedido_" + pedido.increment_id);
            }

            ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda = new ERP.Winthor.Domain.PedidoWeb();

            if (!AtualizarCadastroCliente(pedido, PedidoForcaVenda))
            {
                return "Erro na validação do cliente";
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
                                codigoauxiliar = LojaECommerce.ProdutoEan(codigoauxiliar);
                                codigoauxiliar = Biblioteca.Tools.Numbers.OnlyNumbers(codigoauxiliar);
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
                    Integradora.ERP.Winthor.EntityWinthor.PCPresttemp parcelaPedido = PedidoForcaVenda.NovaParcela();

                    parcelaPedido.Codcob = PedidoForcaVenda.Cabecalho.Codcob;
                    if (!string.IsNullOrEmpty(pedido.payment.cc_type))
                    {
                        try
                        {
                            Persistencia ba = new Persistencia(PCConsum.GetStringConnection());
                            string cobranca = ba.GetValorCampoString(@" SELECT PCCOB.CODCOB VALOR
                                                                         FROM PCCOB
                                                                        WHERE UPPER(PCCOB.CODOUTRO) = '" + pedido.payment.cc_type.ToUpper() + "'");
                            if (!string.IsNullOrEmpty(cobranca))
                            {
                                PedidoForcaVenda.Cabecalho.Codcob = cobranca;
                                parcelaPedido.Codcob = cobranca;
                            }
                        }
                        catch
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber", "ExecutarIntegradora", "Cobrança não encontrada para o código: " + pedido.payment.cc_type);
                        }
                    }

                    parcelaPedido.Valor = Math.Round(Convert.ToDecimal(pedido.payment.amount_ordered.Replace(".", ",")), 2);
                    parcelaPedido.Prest = "1";
                    parcelaPedido.Presttef = parcelaPedido.Prest;
                    parcelaPedido.Dttransacaocc = PedidoForcaVenda.Cabecalho.Data;
                    parcelaPedido.Codplpag = PedidoForcaVenda.Cabecalho.Codplpag;
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
                //Gravar o cliente (inserindo ou atualizando dados
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        commitTransacao = PedidoForcaVenda.PedidoGravar();
                        if (commitTransacao)
                        {
                            numPedido = PedidoForcaVenda.Cabecalho.Numpedweb;
                            codRCA = PedidoForcaVenda.Cabecalho.Codusur;
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
            }
            catch (Exception ex)
            {
                resultado = ex.ToString();
            }

            if (DeveExecutarIntegradora)
            {
                if (resultado == "OK")
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber", "ExecutarIntegradora", "Executando a integradora no pedido RCA: " + numPedido);
                    bool importado = Comum.ExecutarIntegradora(numPedido, codRCA, PedidoForcaVenda);

                    if (!importado)
                    {
                        resultado = "Erro ao importador via integradora Winthor";
                    }
                    else
                    {

                    }

                }
            }
            return resultado;
        }

        private bool AtualizarCadastroCliente(salesOrderEntity pedidoMagento, ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda)
        {
            bool resultado = false;
            try
            {
                customerCustomerEntity cliente = LojaECommerce.ClienteCarregar(Convert.ToInt32(pedidoMagento.customer_id));
                if (cliente == null)
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
                                 , "AtualizarCadastroCliente"
                                 , "Cliente não informado no pedido");
                    return false;
                }
                string CNPJ_CPF = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(cliente.taxvat);
                if (string.IsNullOrEmpty(CNPJ_CPF))
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
                                 , "AtualizarCadastroCliente"
                                 , "CNPJ/CPF não informado!");
                    return false;
                }
                //Verifica se o cliente do pedido existe no Winthor
                if (!PedidoForcaVenda.ClienteExiste("REGEXP_REPLACE(CGCENT, '[^0-9]','') = '" + CNPJ_CPF + "'"))
                {
                    //Criando um novo cliente
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
                Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
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
                        Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Receber"
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

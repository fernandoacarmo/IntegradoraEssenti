using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.VTex.OrderList;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using Integradora.ERP.Winthor.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.VTex
{
    class Enviar : IProcessIntegration
    {
        public Enviar()
        {
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadECommerce("TABELA IN ('ESVVTEXESTOQUE','PCPEDC', 'PCNFSAID','PCPEDCTEMP', 'VWVTEXPRODUTOS')  order by DTINCLUSAO");
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    using (var transaction = new System.Transactions.CommittableTransaction())
                    {
                        try
                        {
                            //Criando a classe e carregando
                            var filtro = "rowid = '" + item.Id + "'";
                            if (item.Tabela.Substring(0, 2) == "VW")
                                filtro = "rid = '" + item.Id + "'";

                            if (item.Tabela.Substring(0, 3) == "ESV")
                                filtro = "rid = '" + item.Id + "'";

                            var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, filtro);
                            //Caso tenha encontrado processa
                            bool PodeApagarRegistro = true;
                            if (integracao != null)
                            {
                                switch (item.Tabela)
                                {
                                    case "PCPEDC":
                                        PodeApagarRegistro = SendPedido((PCPedc)integracao, item.Acao);
                                        break;
                                     case "PCPEDCTEMP":
                                        PodeApagarRegistro = SendPedidoTemporario((PCPedctemp)integracao, item.Acao);
                                        break;
                                    case "ESVVTEXESTOQUE":
                                        PodeApagarRegistro = SendEstoque((Esvvtexestoque)integracao, item.Acao);
                                        break;
                                    case "VWVTEXPRODUTOS":
                                        if (codigoclientepc != Biblioteca.Dictionaries.Tips.ClientePC.ClimaRio) //Não envia preço
                                        {
                                            PodeApagarRegistro = SendProduto((VWVtexProdutos)integracao, item.Acao);
                                        }
                                        else
                                            PodeApagarRegistro = true;
                                        break;
                                    case "PCNFSAID":
                                        PodeApagarRegistro = SendNotaFical((PCNfsaid)integracao, item.Acao);
                                        break;
                                }
                            }

                            if (PodeApagarRegistro)
                            {
                                Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);
                            }
                            else
                            {
                                Logs.GerarLog("Integradora.Norma.Winthor.VTex", "Process", "Registro não encontrado para tabela: " + item.Tabela);
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Processo.Notificar("Integradora.Norma.Winthor.VTex", "Process", ex);
                        }
                    }
                }
            }
        }

        private bool SendNotaFical(PCNfsaid registro, decimal p)
        {
            bool retorno = false;
            try
            {
                PCPedctemp pedidoTemporario = PCPedctemp.Listar("NUMPED = " + registro.Numped).FirstOrDefault();
                if (pedidoTemporario == null)
                {
                    retorno = true;
                }
                Integradora.ECommerce.VTex.Orders.Pedido VTexPedidoConsulta = new Integradora.ECommerce.VTex.Orders.Pedido();
                Integradora.ECommerce.VTex.Orders.RootPedido VTexPedido = VTexPedidoConsulta.Consultar(pedidoTemporario.Numpedcli);

                foreach (Integradora.ECommerce.VTex.Orders.Transaction transacao in VTexPedido.paymentData.transactions)
                {
                    foreach (Integradora.ECommerce.VTex.Orders.Payment parcelas in transacao.payments)
                    {
                        string NSU = "";
                        if (parcelas.installments > 0)
                        {
                            for (int i = 0; i < parcelas.installments; i++)
                            {
                                var NSU_Vtex = Biblioteca.Tools.Numbers.OnlyNumbers(parcelas.connectorResponses.Nsu);
                                if (NSU != NSU_Vtex)
                                {
                                    NSU = NSU_Vtex;  //Backup do antigo;
                                    var vsNovoNSU = VTexPedidoConsulta.ObterPagamentoNSU(transacao.transactionId, parcelas);

                                    string Script = @"BEGIN
                                                        UPDATE PCPREST
                                                           SET PCPREST.NSUTEF = '{0}'
                                                         WHERE PCPREST.NSUTEF = '{1}'
                                                           AND PCPREST.NUMTRANSVENDA = {2};

                                                        UPDATE PCPRESTTEMP
                                                           SET PCPRESTTEMP.NSUTEF = '{0}'
                                                         WHERE PCPRESTTEMP.NSUTEF = '{1}'
                                                           AND EXISTS (SELECT 1
                                                                         FROM PCPEDCTEMP
                                                                        WHERE PCPRESTTEMP.NUMPEDWEB = PCPEDCTEMP.NUMPEDRCA
                                                                          AND PCPEDCTEMP.NUMPED = {3});

                                                        UPDATE PCPEDCTEMP
                                                           SET PCPEDCTEMP.ESC_OBTERNSU = 'N'
                                                         WHERE PCPEDCTEMP.NUMPED = {3};
                                                      END;
                                                    ";

                                    Script = string.Format(Script
                                                          , vsNovoNSU
                                                          , NSU
                                                          , registro.Numtransvenda.ToString()
                                                          , registro.Numped.ToString()
                                                          );

                                    registro.ExecutarComando(Script);

                                    Processo.Notificar("Integradora.Norma.Winthor.VTex"
                                                      , "SendNotaFical"
                                                      , string.Format("Trocar NSU de {0} para {1} do pedido: {2}", NSU, vsNovoNSU, registro.Numped.ToString()));
                                }
                            }
                        }
                    }
                }
                retorno = true;
            }
            catch (Exception ex)
            {
                retorno = false;
                Processo.Notificar("Integradora.Norma.Winthor.VTex", "SendNotaFical", ex);
            }

            return retorno;
        }

        private bool SendProduto(VWVtexProdutos registro, decimal p)
        {
            //if ()
            bool retorno = false;
            try
            {
                Integradora.ECommerce.VTex.Produtos.VTexPreco precificacao = new Integradora.ECommerce.VTex.Produtos.VTexPreco();

                precificacao.Id = "";
                precificacao.itemId = Convert.ToInt32(registro.Codprod);
                precificacao.price = registro.Pvenda;
                precificacao.listPrice = registro.Pvenda;

                if (Biblioteca.Dictionaries.Settings.Debugando())
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.VTex", "SendPreco", "Enviado para preço: " + registro.Codprod.ToString() + " valor: " + registro.Pvenda.ToString());
                }
                Integradora.ECommerce.VTex.Produtos.Produtos VTexECommerce = new Integradora.ECommerce.VTex.Produtos.Produtos();

                List<Integradora.ECommerce.VTex.Produtos.VTexPreco> ListaPrecificacao = new List<ECommerce.VTex.Produtos.VTexPreco>();
                ListaPrecificacao.Add(precificacao);

//                try
//                {
//                    VTexECommerce.ExcluirPreco(registro.Sku);
                //                }HM6NR-QXX7C-DFW2Y-8B82K-WTYJV
//                catch (Exception ex)
//                {
//                    Logs.GerarLog("Integradora.Norma.Winthor.VTex", "SendPreco", "Excluir preço do produto: " + registro.Codprod.ToString() + " valor: " + registro.Pvenda.ToString() + " - " + ex.Message);
//                }

                string respostas = VTexECommerce.EnviarPreco(registro.Codprod.ToString(), ListaPrecificacao);

                //Gravar log de precificação
                ESTLogpreco_ecommerce logpreco = new ESTLogpreco_ecommerce();
                logpreco.Codprod = registro.Codprod;
                logpreco.Dtreplicacao = registro.DataHoraServidor();
                logpreco.Pvenda = registro.Pvenda;
                logpreco.Registro = "SKU";
                logpreco.Gravar();

                retorno = true;
            }
            catch (Exception ex)
            {
                retorno = false;
                Processo.Notificar("Integradora.Norma.Winthor.VTex", "SendPreco", ex);
            }

            return retorno;
        }

        private bool SendEstoque(Esvvtexestoque registro, decimal Acao)
        {
            bool retorno = false;
            try
            {
                Integradora.ECommerce.VTex.Produtos.VTexEstoque estoque = new Integradora.ECommerce.VTex.Produtos.VTexEstoque();

                estoque.wareHouseId = registro.Vtexwarehouse;
                estoque.itemId = registro.Codprod.ToString();
                estoque.unlimitedQuantity = false; //Estoque ilimitado
                estoque.dateUtcOnBalanceSystem = registro.Dtultimobalanco.ToString(Calendars.GetMascaraDataHoraXML());
                estoque.quantity = Convert.ToInt32(registro.Qtestoque);
                if (estoque.quantity < 0)
                {
                    estoque.quantity = 0;
                }
//                {
//                    Logs.GerarLog("Integradora.Norma.Winthor.VTex", "SendEstoque", "Enviado estoque produto: " + registro.Codprod.ToString() + " quantidade: " + estoque.quantity.ToString());
//                }
                Integradora.ECommerce.VTex.Produtos.Produtos VTexECommerce = new Integradora.ECommerce.VTex.Produtos.Produtos();
                List<Integradora.ECommerce.VTex.Produtos.VTexEstoque> ListaEstoque = new List<ECommerce.VTex.Produtos.VTexEstoque>();
                ListaEstoque.Add(estoque);

                string respostas = VTexECommerce.EnviarEstoque(registro.Codprod.ToString(), registro.Vtexwarehouse, ListaEstoque);

                //if (Biblioteca.Dictionaries.Settings.Debugando())
//                {
//                    Logs.GerarLog("Integradora.Norma.Winthor.VTex", "SendEstoque", "Enviado estoque produto: " + registro.Codprod.ToString() + " quantidade: " + estoque.quantity.ToString() + " - " + respostas);
//                }
                retorno = true;
            }
            catch (Exception ex)
            {
                retorno = false;
                Processo.Notificar("Integradora.Norma.Winthor.VTex", "SendEstoque", ex);
            }

            return retorno;
        }

        private bool SendPedidoTemporario(PCPedctemp pedidoecommerce, decimal Acao)
        {
            try
            {
                Integradora.ECommerce.VTex.Orders.Pedido VTexECommerce = new Integradora.ECommerce.VTex.Orders.Pedido();

                string retorno = "";
                switch (Convert.ToInt16(Acao))
                {
                    case 0: //Cancelando o pedido
                        retorno = VTexECommerce.Cancelar(pedidoecommerce.Numpedcli);
                        if (Biblioteca.Dictionaries.Settings.Debugando())
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.VTex", "SendPedido", "Cancelar pedido: " + pedidoecommerce.Numpedcli + " " + retorno);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.VTex", "SendPedidoTemporario", ex);
            }

            return true;
        }

        private bool SendPedido(PCPedc pedido, decimal Acao)
        {
            bool resultado = true;
            if ((pedido.Numpedrca > 0) && (Acao != 1))
            {
                PCPedctemp pedidoecommerce = null;
                try
                {
                    pedidoecommerce = PCPedctemp.Listar("NUMPEDRCA = " + pedido.Numpedrca.ToString()).Single();
                }
                catch
                {
                    pedidoecommerce = null;
                }

                try
                {
                    if (pedidoecommerce != null)
                    {
                        string retorno = "";
                        switch (Convert.ToInt16(Acao))
                        {
                            case 0: //Cancela o pedido
                                SendPedidoTemporario(pedidoecommerce, Acao);
                                Logs.GerarLog("Integradora.Norma.Winthor.VTex", "SendPedido", "Pedido cancelado: " + pedidoecommerce.Numpedcli + " " + retorno);
                                resultado = true;
                                break;
                            case 2: //Notificando que o pedido foi faturado
                                Integradora.ECommerce.VTex.Orders.Pedido VTexECommerce = new Integradora.ECommerce.VTex.Orders.Pedido();
                                object NotaFiscal = DadosNotaFiscal(pedido);
                                if (NotaFiscal != null)
                                {
                                    resultado = true;
                                    retorno = VTexECommerce.Faturado(pedidoecommerce.Numpedcli, NotaFiscal);
                                    Logs.GerarLog("Integradora.Norma.Winthor.VTex", "SendPedido", "Pedido faturado: " + pedidoecommerce.Numpedcli + " " + retorno);
                                }
                                else
                                {
                                    Logs.GerarLog("Integradora.Norma.Winthor.VTex", "SendPedido", "Não foi localizado dados da nota fiscal do pedido " + pedidoecommerce.Numpedcli);
                                    resultado = false;
                                }
                                break;
                            default:
                                resultado = true;
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Processo.Notificar("Integradora.Norma.Winthor.VTex", "SendPedido", ex);
                    resultado = true;
                }
            }
            else
            {
                resultado = true;
            }

            return resultado;
        }

        private object DadosNotaFiscal(PCPedc pedido)
        {
            RootObjectFaturamento cabecalho = new RootObjectFaturamento();

            string Rastreamento = "";
            if (!string.IsNullOrEmpty(pedido.Obsentrega1))
            {
                if (pedido.Obsentrega1.Contains("CORREIOS"))
                {
                    Rastreamento = "";
                }
            }

            if (!string.IsNullOrEmpty(pedido.URLrastreamento))
            {
                Rastreamento = pedido.URLrastreamento;
                cabecalho.trackingUrl = pedido.URLrastreamento;
            }

            decimal? CodTransportadora = pedido.Codfornecfrete;
            cabecalho.type = "Output";
            try
            {
                PCNfsaid notafiscal = PCNfsaid.Listar("NUMNOTA <> NUMTRANSVENDA AND NUMPED = " + pedido.Numped.ToString()).Single();
                cabecalho.invoiceNumber = notafiscal.Numnota.ToString();
                cabecalho.invoiceKey = notafiscal.Chavenfe.ToString();

                if (string.IsNullOrEmpty(Rastreamento))
                {
                    cabecalho.trackingNumber = notafiscal.Numnota.ToString();
                }
                else
                {
                    cabecalho.trackingNumber = Biblioteca.Tools.Numbers.OnlyNumbers(Rastreamento);
                }
                if (notafiscal.Codfornecfrete > 0)
                {
                    CodTransportadora = notafiscal.Codfornecfrete;
                }
            }
            catch (Exception Erro)
            {
                //Aborta a operação e não exclui o registro para ser enviado uma próxima vez }

                Logs.GerarLog("Integradora.Norma.Winthor.VTex", "DadosNotaFiscal", Erro);

                return null;
                //                cabecalho.invoiceNumber = pedido.Numnota.ToString();
                //                cabecalho.trackingNumber = "";
            }

            //Verifica se o nome da transportadora foi informado
            if (CodTransportadora > 0)
            {
                try
                {//Obtendo os dados da transportadora
                    PCFornec transportadora = PCFornec.Listar("CODFORNEC = " + CodTransportadora.ToString()).Single();
                    cabecalho.courier = string.IsNullOrEmpty(transportadora.Fantasia) ? transportadora.Fornecedor : transportadora.Fantasia;
                    if (string.IsNullOrEmpty(cabecalho.trackingUrl))
                    {
                        cabecalho.trackingUrl = transportadora.Complementoend;
                    }
                }
                catch
                {//Sem informação
                    if (string.IsNullOrEmpty(cabecalho.trackingUrl))
                    {
                        cabecalho.trackingUrl = "";
                    }
                    cabecalho.courier = "";
                }
            }
            cabecalho.issuanceDate = Calendars.ToDateTime(pedido.Dtfat).ToString(Calendars.GetMascaraDataHoraXML());
            cabecalho.invoiceValue = Convert.ToInt32(pedido.Vltotal * 100);
            //Criar lisa de itens
            cabecalho.items = new List<ItemFaturamento>();
            //Listar itens faturados
            try
            {
                List<PCPedi> ItensPedidos = PCPedi.Listar("NUMPED = " + pedido.Numped.ToString());
                foreach (var item in ItensPedidos)
                {
                    ItemFaturamento produto = new ItemFaturamento();

                    produto.id = item.Codprod.ToString();
                    produto.quantity = Convert.ToInt32(item.Qt);
                    produto.price = Convert.ToInt32(item.Pvenda * 100);

                    cabecalho.items.Add(produto);
                }
            }
            catch (Exception Erro)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.VTex", "ItensPedidos", Erro);

            }

            //if (Biblioteca.Dictionaries.Settings.Debugando())
            //Retirar esta função depois de concluir o processo de enviar o nome do fornecedor para a VTEX, para não ficar gerando registro no disco desnecessário
//            {
//                Biblioteca.Tools.XML.Export(cabecalho, "pedido_" + pedido.Numpedrca.ToString());
//            }

            return cabecalho;
        }
    }
}

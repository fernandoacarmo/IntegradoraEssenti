using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.Ajuri.Metodos;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Ajuri
{
    internal class EnviarAjuri
    {
        internal bool SendWebserviceEntrada(Integradora.ECommerce.Ajuri.Integracao LojaECommerce, ESVConcluidoWMS dados, List<PCWmsoutput> ListaWMSOutput)
        {
            bool retorno = false;
            //Objeto de envio
            RetornaIO xml = new RetornaIO();
            //Inicializando
            xml.ObterDados();
            //Listar o primeiro registro para pegar os dados do cabeçalho
            PCWmsoutput primeiroItem = ListaWMSOutput.FirstOrDefault();
            //Montar cabeçalho
            ConferenciaRetornaIO conferencia = new ConferenciaRetornaIO();
            conferencia.ObterDados("ENTRADA");
            conferencia.Cabecalhochave.Numero = primeiroItem.Numnota.ToString();
            conferencia.Cabecalhochave.Data = primeiroItem.Dtemissao.ToString(Calendars.GetMascaraDataXML());

            conferencia.Cabecalhochave.Serie = dados.Serie;
            conferencia.Cabecalhochave.Cfop.Codigo = dados.Cfop;
            conferencia.Cabecalhochave.Cfop.Descricao = "";
            conferencia.Entidade.Documentofederal = dados.Cnpj_emitente;
            conferencia.Entidade.Razaosocial = dados.Razaosocial;
            conferencia.Livres.AdicionarItem("6", "TRANSACAO_ID_AJURI", dados.Numajuri);
            conferencia.Livres.AdicionarItem("7", "TRANSACAO_ID_CLIENTE", "26");
            //conferencia.Livres.AdicionarItem("3","DOCUMENTO_WINTHOR","2206512");

            List<ESTNotaentradaitens> ListaItemOriginal = ESTNotaentradaitens.Listar(string.Format("NUMTRANSACAO = {0}", dados.Numtransacao));

            foreach (var item in ListaWMSOutput)
            {//Listando itens do documento
                try
                {
                    ESTNotaentradaitens obteritemoriginal = ListaItemOriginal.Where(c => c.Codproduto == item.Codprod).FirstOrDefault();

                    ItemRetornaIO produto = new ItemRetornaIO();

                    //Estou usando o campo QTavaria, apenas para contar as quantidades processada, o certo seria o campo qtarmazenada, 
                    //mas estou usando ele o processo de quantidade a maior
                    var vnSaldo = item.Qtrec - (obteritemoriginal.Quantidade - obteritemoriginal.Qtavaria);
                    obteritemoriginal.Qtavaria += item.Qtrec;

                    produto.Quantidadeprocessada = item.Qtrec.ToString();
                    produto.Lote = item.Numlote;

                    ObterDadosLote(item.Codprod, item.Numlote, item.Dtfabricacao, item.Dtvalidade, item.Fabricante, produto);

                    produto.Produto.Partnumber = obteritemoriginal.Numajuri;
                    produto.Produto.Descricao = obteritemoriginal.Descricao;

                    produto.Quantidade = item.Qtrec.ToString();
                    produto.Valorunitario = obteritemoriginal.Vlunitario.ToString().Replace(",", ".");
                    produto.Serial = obteritemoriginal.Serial;
                    produto.Resultado = "LIBERADO";

                    //Inserindo item na lista do documento
                    conferencia.Itens.Item.Add(produto);

                    if (vnSaldo > obteritemoriginal.Quantidade)
                    {
                        ItemRetornaIO diferenca = (ItemRetornaIO)produto.Clone();
                        diferenca.Resultado = "FISICO_MAIOR";
                        diferenca.Quantidade = Math.Abs(vnSaldo).ToString();
                        diferenca.Quantidadeprocessada = diferenca.Quantidade;
                        //Inserindo item na lista do documento
                        conferencia.Itens.Item.Add(diferenca);
                    }
                }
                catch
                {
                }

            }

            foreach (var item in ListaItemOriginal)
            {
                if (item.Qtavaria < item.Quantidade)
                {
                    ItemRetornaIO produto = new ItemRetornaIO();

                    produto.Quantidadeprocessada = Math.Abs(item.Qtavaria - item.Quantidade).ToString();
                    produto.Lote = ".";

                    ObterDadosLote(item.Codproduto, item.Numlote, item.Dtfabricacao, item.Dtvalidade, item.Modelo, produto);

                    produto.Modelo = produto.Modelo == "-1" ? "1" : produto.Modelo;
                    produto.Produto.Partnumber = item.Numajuri;
                    produto.Produto.Descricao = item.Descricao;
                    produto.Quantidade = produto.Quantidadeprocessada;
                    produto.Valorunitario = item.Vlunitario.ToString().Replace(",", ".");
                    produto.Serial = item.Serial;
                    produto.Resultado = "FISICO_MENOR";

                    //Inserindo item na lista do documento
                    conferencia.Itens.Item.Add(produto);
                }

                if (item.Qtarmazenada > item.Quantidade)
                {
                    ItemRetornaIO produto = new ItemRetornaIO();

                    produto.Quantidadeprocessada = Math.Abs(item.Qtarmazenada - item.Quantidade).ToString();
                    produto.Lote = item.Numlote;

                    ObterDadosLote(item.Codproduto, item.Numlote, item.Dtfabricacao, item.Dtvalidade, item.Modelo, produto);

                    produto.Produto.Partnumber = item.Numajuri;
                    produto.Produto.Descricao = item.Descricao;
                    produto.Quantidade = produto.Quantidadeprocessada;
                    produto.Valorunitario = item.Vlunitario.ToString().Replace(",", ".");
                    produto.Serial = item.Serial;
                    produto.Resultado = "FISICO_MAIOR";

                    //Inserindo item na lista do documento
                    conferencia.Itens.Item.Add(produto);
                }
            }
            //Inserindo cabeçalho no objeto de envio
            xml.Conferencias.Conferencia.Add(conferencia);
            //Validar Fabricante
            foreach (var item in conferencia.Itens.Item)
            {
                if (string.IsNullOrEmpty(item.Modelo) || (item.Datafabricacao == null || (item.Datavencimento == null)))
                {
                    if (Convert.ToDecimal(item.Quantidadeprocessada) > 0)
                    {
                        var validacao = string.Format("Nota entrada: {0} - Produto Ajuri {1} com código do fabricante ou dt. fabricação ou dt. validade não informado!"
                                                      , conferencia.Cabecalhochave.Numero
                                                      , item.Produto.Partnumber
                                                      );
                        ESTLogintegracao.GerarLog("Integradora.Norma.Winthor.Ajuri" //classe
                                                 , "SendWebserviceEntrada" //metodo
                                                 , validacao //mensagem
                                                 , "ESTNOTAENTRADA" //tabela
                                                 , dados.Numtransacao//codigoEssenti
                                                 , dados.Numajuri //codigoEcommerce
                                                 , true //Winthor enviou?
                                                 , false //sucesso
                                                 );

                        Logs.GerarLog("Integradora.Norma.Winthor.Ajuri", "SendWebserviceEntrada", validacao);
                        return false;
                    }
                }
            }
            retorno = LojaECommerce.EnviarEntradas(xml);
            //Resultado
            return retorno;
        }
        private static void ObterDadosLote(decimal Codproduto, string Numlote, DateTime Dtfabricacao, DateTime Dtvalidade, string codigoFabricante, ItemRetornaIO produto)
        {
            //Variaveis para tratarmento
            DateTime? dataFabricacao = Dtfabricacao;
            DateTime? dataValidacao  = Dtvalidade;
            string Fabricante = string.Empty;

            if (codigoFabricante != string.Empty)
            {
                try
                {
                    Fabricante = ESTFabricante.Listar("CODIGO = " + codigoFabricante.ToString()).FirstOrDefault().Numajuri;
                }
                catch
                {
                    Fabricante = "";
                }
            }


            ///Pesquisa pelo PCMOVENDPEND
            #region PCMOVENDPEND
            if ((string.IsNullOrEmpty(Fabricante)) || (dataFabricacao == null) || (dataValidacao == null))
            {
                //Listar dados do lote primeiramente na PCESTENDERECOI
                try
                {
                    List<PCMovendpend> WMSmovimentacao = PCMovendpend.Listar(string.Format("CODPROD = {0} AND NUMLOTE = '{1}'", Codproduto, Numlote));
                    foreach (var itemWMSmovimentacao in WMSmovimentacao)
                    {
                        if (itemWMSmovimentacao.Dtfabricacao != null)
                        {
                            dataFabricacao = itemWMSmovimentacao.Dtfabricacao;
                        }

                        if (itemWMSmovimentacao.Dtvalidade != null)
                        {
                            dataValidacao = itemWMSmovimentacao.Dtvalidade;
                        }
                        //Buscar o nome do fabricante através do código
                        if (itemWMSmovimentacao.CodFabricante > 0)
                        {
                            try
                            {
                                Fabricante = ESTFabricante.Listar("CODIGO = " + itemWMSmovimentacao.CodFabricante.ToString()).FirstOrDefault().Numajuri;
                            }
                            catch
                            {
                                Fabricante = "";
                            }
                        }
                        //Se tiver preenchido todos os parametros encerra o laço
                        if ((!string.IsNullOrEmpty(Fabricante)) && (dataFabricacao != null) && (dataValidacao != null))
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Ajuri"
                                 , "ObterDadosLote"
                                 , string.Format("Movimentação não encontrado para o produto {0} and lote {1} - erro: {2}"
                                                , Codproduto.ToString()
                                                , Numlote
                                                , ex.ToString()));
                }
            }
            #endregion

            #region PCESTENDERECOI
            if ((string.IsNullOrEmpty(Fabricante)) || (dataFabricacao == null) || (dataValidacao == null))
            {
                //Listar dados do lote primeiramente na PCESTENDERECOI
                try
                {
                    List<PCEstenderecoi> enderecamento = PCEstenderecoi.Listar(string.Format("CODPROD = {0} AND NUMLOTE = '{1}'", Codproduto, Numlote));
                    foreach (var itemEnderecamento in enderecamento)
                    {
                        if (itemEnderecamento.Dtfabricacao != null)
                        {
                            dataFabricacao = itemEnderecamento.Dtfabricacao;
                        }

                        if (itemEnderecamento.Dtval != null)
                        {
                            dataValidacao = itemEnderecamento.Dtval;
                        }
                        //Buscar o nome do fabricante através do código
                        if (itemEnderecamento.Codfabricante > 0)
                        {
                            try
                            {
                                Fabricante = ESTFabricante.Listar("CODIGO = " + itemEnderecamento.Codfabricante.ToString()).FirstOrDefault().Numajuri;
                            }
                            catch
                            {
                                Fabricante = "";
                            }
                        }
                        //Se tiver preenchido todos os parametros encerra o laço
                        if ((!string.IsNullOrEmpty(Fabricante)) && (dataFabricacao != null) && (dataValidacao != null))
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Ajuri"
                                 , "ObterDadosLote"
                                 , string.Format("Endereço não encontrado para o produto {0} and lote {1} - erro: {2}", Codproduto.ToString(), Numlote, ex.ToString()));
                }
            }
#endregion  
         
            #region PCLOTE
//          if ((string.IsNullOrEmpty(Fabricante)) || (dataFabricacao == null) || (dataValidacao == null))
//            {
//                //Listar dados do lote primeiramente na PCLote
//                try
//                {
//                    List<PCLote> loteamento = PCLote.Listar(string.Format("CODPROD = {0} AND NUMLOTE = '{1}'", Codproduto, Numlote));
//                    foreach (var itemLoteamento in loteamento)
//                    {
//                        if (itemLoteamento.Datafabricacao != null)
//                        {
//                            dataFabricacao = itemLoteamento.Datafabricacao;
//                        }
//
//                        if (itemLoteamento.Dtvalidade != null)
//                        {
//                            dataValidacao = itemLoteamento.Dtvalidade;
//                        }
//                        //Buscar o nome do fabricante através do código
//                        if (!string.IsNullOrEmpty(itemLoteamento.Fabricante))
//                        {
//                            try
//                            {
//                                Fabricante = ESTFabricante.Listar("CODIGO = " + itemLoteamento.Fabricante).FirstOrDefault().Numajuri;
//                            }
//                            catch
//                            {
//                                Fabricante = "";
//                            }
//                        }
//                        //Se tiver preenchido todos os parametros encerra o laço
//                        if ((!string.IsNullOrEmpty(Fabricante)) && (dataFabricacao != null) && (dataValidacao != null))
//                            break;
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Logs.GerarLog("Integradora.Norma.Winthor.Ajuri"
//                                 , "ObterDadosLote"
//                                 , string.Format("Lote não encontrado para o produto {0} and lote {1} - erro: {2}"
//                                                , Codproduto.ToString()
//                                                , Numlote
//                                                , ex.ToString()));
//                }
            //            }
            #endregion

            //Caso não tenha encontrado, busca da tabela PCWMSOutput
            if (dataFabricacao == null)
            {
                dataFabricacao = Dtfabricacao;
            }

            if (dataValidacao == null)
            {
                dataValidacao = Dtvalidade;
            }
            if (string.IsNullOrEmpty(Fabricante))
            {
                Fabricante = codigoFabricante;
            }

            //Retorno dos registros encontrados
            produto.Datafabricacao = dataFabricacao == null ? "" : Calendars.ToDateTime(dataFabricacao).ToString(Calendars.GetMascaraDataXML());
            produto.Datavencimento = dataValidacao  == null ? "" : Calendars.ToDateTime(dataValidacao).ToString(Calendars.GetMascaraDataXML());
            produto.Modelo         = string.IsNullOrEmpty(Fabricante) ? "-1" : Fabricante; //Tem que mandar qualquer valor senão da erro no xml
        }
        internal bool SendWebServiceSaida(Integradora.ECommerce.Ajuri.Integracao LojaECommerce, ESVConcluidoWMS dados, List<PCWmsoutput> ListaWMSOutput)
        {
            List<string> ProdutosJaIncluido = new List<string>();

            bool retorno = false;
            //Objeto de envio
            RetornaIO xml = new RetornaIO();
            //Inicializando
            xml.ObterDados();
            //Listar o primeiro registro para pegar os dados do cabeçalho
            PCWmsoutput primeiroItem = ListaWMSOutput.FirstOrDefault();
            //Montar cabeçalho
            ConferenciaRetornaIO conferencia = new ConferenciaRetornaIO();
            conferencia.ObterDados("SAIDA");
            conferencia.Cabecalhochave.Numero = primeiroItem.Numero.ToString();
            conferencia.Cabecalhochave.Data = primeiroItem.Dtemissao.ToString(Calendars.GetMascaraDataXML());

            conferencia.Cabecalhochave.Serie = dados.Serie;
            conferencia.Cabecalhochave.Cfop.Codigo = "5102";
            conferencia.Cabecalhochave.Cfop.Descricao = "";
            conferencia.Entidade.Documentofederal = dados.Cnpj_emitente;
            conferencia.Entidade.Razaosocial = dados.Razaosocial;
            conferencia.Livres.AdicionarItem("6", "TRANSACAO_ID_AJURI", dados.Numajuri);
            conferencia.Livres.AdicionarItem("7", "TRANSACAO_ID_CLIENTE", "26");

            List<ESTPedidosaidaitens> ListaItemOriginal = ESTPedidosaidaitens.Listar(string.Format("NUMPEDIDO = {0}", dados.Numdocumento));

            foreach (var item in ListaWMSOutput)
            {//Listando itens do documento
                try
                {
                    ESTPedidosaidaitens obteritemoriginal = ListaItemOriginal.Where(c => c.Codproduto == item.Codprod).FirstOrDefault();
                    List<PCWmsnumlote> lotes = null;
                    try
                    {
                        lotes = PCWmsnumlote.Listar(string.Format("NUMPED = {0} AND CODPROD = {1}", item.Numero, item.Codprod));
                    }
                    catch
                    {
                        lotes = null;
                    }

                    if ((lotes == null) || (lotes.Count == 0))
                    {
                        ItemRetornaIO produto = new ItemRetornaIO();
                        //var vnSaldo = item.Qtsep - (obteritemoriginal.Quantidade - obteritemoriginal.Qtatendido);
                        obteritemoriginal.Qtatendido += item.Qtsep;
                        produto.Quantidadeprocessada = item.Qtsep.ToString();
                        produto.Lote = item.Numlote;
                        ObterDadosLote(item.Codprod, item.Numlote, item.Dtfabricacao, item.Dtvalidade, item.Fabricante, produto);
                        produto.Produto.Partnumber = obteritemoriginal.Numajuri;
                        produto.Produto.Descricao = obteritemoriginal.Descricao;
                        produto.Quantidade = produto.Quantidadeprocessada;
                        produto.Resultado = string.IsNullOrEmpty(obteritemoriginal.Tipoestoque) ? "LIBERADO" : obteritemoriginal.Tipoestoque;
                        produto.Valorunitario = obteritemoriginal.Vlunitario.ToString().Replace(",", ".");
                        produto.Serial = obteritemoriginal.Serial;
                        //Inserindo item na lista do documento
                        conferencia.Itens.Item.Add(produto);
                    }
                    else
                    {
                        foreach (var itemlote in lotes)
                        {
                            ItemRetornaIO produtolote = new ItemRetornaIO();
                            //                            var vnSaldo = itemlote.Qt - (obteritemoriginal.Quantidade - obteritemoriginal.Qtatendido);
                            obteritemoriginal.Qtatendido += itemlote.Qt;

                            produtolote.Quantidadeprocessada = itemlote.Qt.ToString();
                            produtolote.Lote = itemlote.Numlote;

                            ObterDadosLote(itemlote.Codprod, itemlote.Numlote, itemlote.Datafabricacao, itemlote.Dtvalidade, itemlote.Fabricante, produtolote);

                            produtolote.Produto.Partnumber = obteritemoriginal.Numajuri;
                            produtolote.Produto.Descricao = obteritemoriginal.Descricao;
                            produtolote.Quantidade = produtolote.Quantidadeprocessada;
                            produtolote.Resultado = string.IsNullOrEmpty(obteritemoriginal.Tipoestoque) ? "LIBERADO" : obteritemoriginal.Tipoestoque;
                            produtolote.Valorunitario = obteritemoriginal.Vlunitario.ToString().Replace(",", ".");
                            produtolote.Serial = obteritemoriginal.Serial;

                            //Inserindo item na lista do documento
                            conferencia.Itens.Item.Add(produtolote);
                        }
                    }
                }
                catch
                {
                }
            }

            //Inserindo cabeçalho no objeto de envio
            xml.Conferencias.Conferencia.Add(conferencia);

            foreach (var item in conferencia.Itens.Item)
            {
                if (string.IsNullOrEmpty(item.Modelo) || (item.Datafabricacao == null || (item.Datavencimento == null)))
                {
                    if (Convert.ToDecimal(item.Quantidadeprocessada) > 0)
                    {
                        var validacao = string.Format("Pedido venda: {0} - Produto Ajuri {1} com código do fabricante ou dt. fabricação ou dt. validade não informado!"
                                                      , conferencia.Cabecalhochave.Numero
                                                      , item.Produto.Partnumber
                                                      );
                        ESTLogintegracao.GerarLog("Integradora.Norma.Winthor.Ajuri" //classe
                                                 , "SendWebServiceSaida" //metodo
                                                 , validacao //mensagem
                                                 , "ESTPEDIDOSAIDA" //tabela
                                                 , dados.Numtransacao//codigoEssenti
                                                 , dados.Numajuri //codigoEcommerce
                                                 , true //Winthor enviou?
                                                 , false //sucesso
                                                 );
                        return false;
                    }
                }
            }

            //Enviando para o webservice
            retorno = LojaECommerce.EnviarSaidas(xml);
            //Resultado
            return retorno;
        }
        internal bool SendWebServiceInventario(Integradora.ECommerce.Ajuri.Integracao LojaECommerce, ESVConcluidoWMS dados, List<PCWmsoutput> ListaWMSOutput)
        {
            bool retorno = false;

            return retorno;
        }
    }
}

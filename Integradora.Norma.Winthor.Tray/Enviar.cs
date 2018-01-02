using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.Tray;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Integradora.Norma.Winthor.Tray
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.Tray.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.Tray.Integracao();
        }

        public void Process(Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadECommerce("1=1 order by dtinclusao");
            foreach (var item in lista)
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        if (Biblioteca.Dictionaries.Settings.Debugando())
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.Tray", "Process", "Enviar: " + item.Tabela);
                        }

                        string filtro = "rowid = '" + item.Id + "'";

                        //Criando a classe e carregando
                        if (item.Tabela.Substring(0, 2) == "VW")
                            filtro = "B.rid = '" + item.Id + "'";

                        var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, filtro);
                        bool PodeApagarRegistro = true;
                        //Caso tenha encontrado processa
                        if (integracao != null)
                        {
                            switch (item.Tabela.ToString())
                            {
                                case "VWTRAYPRODUTOS":
                                    SendProdutos((VWTrayProdutos)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "VWTRAYPEDIDOS":
                                    PodeApagarRegistro = SendPosicaoPedido((VWTrayPedidos)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                            }
                        }
                        else
                        {
                            if (Biblioteca.Dictionaries.Settings.Debugando())
                            {
                                Logs.GerarLog("Integradora.Norma.Winthor.Tray", "Process", string.Format("Nenhum registro encontrado para a tabela: {0} - Filtro: {1}", item.Tabela, filtro));
                            }
                        }

                        if (PodeApagarRegistro)
                        {
                            Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);
                        }
                        

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.Tray", "Process", ex);
                    }
                }
            }
        }

        private bool SendPosicaoPedido(VWTrayPedidos registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            bool resultado = true;
            try
            {
                RetornoNotaFiscal retorno = EnviarNotaFiscal(registros);

                resultado = retorno != null;

            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integeradora.Norma.Winthor.Tray", "SendPosicaoPedido", ex);
                resultado = false;
            }

            return resultado;
            
        }

        private void SendProdutos(VWTrayProdutos registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
           RetornoProduto retorno = EnviarProdutos(registros);
            if (retorno != null)
            {

                if ((registros.SKU == 0) && (!string.IsNullOrEmpty(retorno.id)))
                {
                    string comando = @"UPDATE PCPRODUT
                                          SET CODPRODRELEV = {0}
                                        WHERE CODPROD      = {1}";
                    comando = string.Format(comando, retorno.id, registros.Codprod.ToString());

                    PCProdut atualizaproduto = new PCProdut();
                    atualizaproduto.ExecutarComando(comando);
                }
            }
        }

        private RetornoNotaFiscal EnviarNotaFiscal(VWTrayPedidos registros)
        {

            Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Tray", "EnviarNotaFiscal", "Iniciando envio de nota fiscal");

            RetornoNotaFiscal jsonObject = null;
            string postString = string.Empty;
            string metodo = "POST";
            string URLAuth = LojaECommerce.MontarUrl("/orders/" + registros.Numpedweb.ToString() + "/invoices/");

            try
            {
                NameValueCollection queryParameters = new NameValueCollection();

                queryParameters.Add("access_token", LojaECommerce.ObterChaveAcesso().access_token);

                List<string> items = new List<string>();

                foreach (String name in queryParameters)
                    items.Add(String.Concat(name, "=", HttpUtility.UrlEncode(queryParameters[name])));

                string argsString = String.Join("&", items.ToArray());

                postString  = "{";
                postString += "  \"issue_date\": \"" + registros.Issue_Date + "\",";
                postString += "  \"number\": \"" + registros.NumNota.ToString() + "\",";
                postString += "  \"serie\": \"" +  registros.Serie + "\",";
                postString += "  \"value\": \"" + registros.ValorNotaFiscal.ToString().Replace(",", ".") + "\",";
                postString += "  \"key\": \"" + registros.ChaveNFE + "\",";
                postString += "  \"link\": \"" + registros.LinkNFE + "\",";
                postString += "  \"xml_danfe\": \"" + registros.XMLNfe.ToString().Replace("\"", "\\\"") + "\",";
                postString += "  \"OrderStatus\": {";

               //Listar itens faturados
               try
               {
                  Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Tray", "EnviarNotaFiscal", "Pesquisando itens da nota fiscal.");
                  List<VWTrayItensPedidos> ItensPedidos = VWTrayItensPedidos.Listar("B.NUMTRANSVENDA = " + registros.Numtransvenda.ToString());
                  foreach (var item in ItensPedidos)
                  {
                     postString += "      \"product_id\": \"" + item.Product_ID.ToString() + "\",";
                     postString += "      \"variation_id\": \"0\",";
                     postString += "      \"cfop\": \"" + item.CFOP.ToString() + "\"";
                  } 
               }
               catch (Exception Erro)
               {
                   Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Tray", "ItensPedidos", Erro);
               }
                
               postString += "  }";
               postString += "}";

               Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Tray", "EnviarNotaFiscal", string.Format("Json nota fiscal: {0}", postString));
               string responseData = LojaECommerce.ExecutarJson(metodo, URLAuth, argsString, postString);

               jsonObject = JsonConvert.DeserializeObject<RetornoNotaFiscal>(responseData);

            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Nomra.Winthor.Tray"
                             , "EnviarNotaFiscal"
                             , "Erro ao enviar Nota Fiscal: " + metodo + Environment.NewLine +
                                "    Url " + URLAuth + Environment.NewLine +
                                "    Dados " + postString + Environment.NewLine + 
                                "    Erro: " + ex.ToString()
                             );
                jsonObject = null;
            }
            return jsonObject;
        }


        private RetornoProduto EnviarProdutos(VWTrayProdutos registros)
        {
            RetornoProduto jsonObject = null;
            string postString = string.Empty;
            string metodo = registros.SKU > 0 ? "PUT" : "POST";
            string URLAuth = LojaECommerce.MontarUrl("/products/");

            try
            {
                if (registros.SKU > 0)
                {
                    URLAuth = URLAuth + registros.SKU.ToString() + "/";
                }
                NameValueCollection queryParameters = new NameValueCollection();

                queryParameters.Add("access_token", LojaECommerce.ObterChaveAcesso().access_token);

                List<string> items = new List<string>();

                foreach (String name in queryParameters)
                    items.Add(String.Concat(name, "=", HttpUtility.UrlEncode(queryParameters[name])));

                string argsString = String.Join("&", items.ToArray());

                postString = "{";
                postString += "  \"Product\": {";

                if (registros.SKU == 0)
                {
                    postString += "      \"ean\": \"" + registros.Codauxiliar.ToString() + "\",";
                    postString += "      \"name\": \"" + registros.Nome + "\",";
                    postString += "      \"description\": \"" + registros.Description + "\",";
                    postString += "      \"description_small\": \"" + registros.Description_small + "\",";
                    postString += "      \"brand\": \"" + registros.Marca + "\",";
                    postString += "      \"reference\": \"" + registros.Codprod.ToString() + "\",";
                }
                if (registros.Start_promotion != null)
                {
                    postString += "      \"start_promotion\": \"" + Calendars.ToDateTime(registros.Start_promotion).Date.ToShortDateString() + "\",";
                    postString += "      \"end_promotion\": \"" + Calendars.ToDateTime(registros.End_promotion).Date.ToShortDateString() + "\",";
                    postString += "      \"promotional_price\": " + registros.Promotional_price.ToString().Replace(",", ".") + ",";
                }

                postString += "      \"stock\": " + registros.Qtestoque.ToString().Replace(",", ".") + ",";
                postString += "      \"price\": " + registros.Price.ToString().Replace(",", ".") + ",";
                postString += "      \"cost_price\": " + registros.Cost_price.ToString().Replace(",", ".") + "";
                postString += "  }";
                postString += "}";

                string responseData = LojaECommerce.ExecutarJson(metodo, URLAuth, argsString, postString);

                jsonObject = JsonConvert.DeserializeObject<RetornoProduto>(responseData);

            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Nomra.Winthor.Tray"
                             , "EnviarProdutos"
                             , "Erro ao enviar produto: " + metodo + Environment.NewLine +
                                "    Url " + URLAuth + Environment.NewLine +
                                "    Dados " + postString + Environment.NewLine + 
                                "    Erro: " + ex.ToString()
                             );
                jsonObject = null;
            }
            return jsonObject;
        }
    }
}

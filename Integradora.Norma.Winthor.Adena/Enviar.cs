using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using Integradora.ECommerce.Adena;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Integradora.Norma.Winthor.Adena
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.Adena.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.Adena.Integracao();
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
                            Logs.GerarLog("Integradora.Norma.Winthor.Adena", "Process", "Enviar: " + item.Tabela);
                        }

                        string filtro = "rowid = '" + item.Id + "'";

                        //Criando a classe e carregando
                        if (item.Tabela.Substring(0, 2) == "VW")
                            filtro = "B.rid = '" + item.Id + "'";
                        if (item.Tabela.Substring(0, 3) == "ESV")
                            filtro = "rid = '" + item.Id + "'";

                        var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, filtro);

                        //Caso tenha encontrado processa
                        if (integracao != null)
                        {
                            switch (item.Tabela.ToString())
                            {
                                case "VWADENAPRODUTOS":
                                    SendProdutos((VWAdenaProdutos)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                        //        case "PCMARCA":
                        //            SendMarcas((PCMarca)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                        //            break;

                                // case "PCPEDC":
                                //     SendPosicaoPedido((PCPedc)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                //     break;
                            }
                        }
                        else
                        {
                          //  if (Biblioteca.Dictionaries.Settings.Debugando())
                          //  {
                                Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Adena", "Process", string.Format("Nenhum registro encontrado para a tabela: {0} - Filtro: {1}", item.Tabela, filtro));
                            //}
                        }

                        Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.Adena", "Process", ex);
                    }
                }
            }
        }

        /*private void SendMarcas(PCMarca registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            Logs.GerarLog("Integradora.Norma.Winthor.Shoppub", "SendMarcas", string.Format("Registro tabela PCMARCA: {0} - Nome: {1}", registros.Codmarca.ToString(), registros.Marca));
            string postString = "{";
            //          if (registros.IdFabricante_Shoppub > 0)
            //              postString += "      \"id\": \"" + registros.IdFabricante_Shoppub.ToString() + "\",";
            postString += "      \"nome\": \"" + registros.Marca + "\",";
            postString += "      \"slug\": \"" + registros.Codmarca.ToString() + "-" + registros.Marca.Replace(" ", "-") + "\",";
            postString += "      \"seo_descricao\": \"" + registros.Codmarca.ToString() + "\",";
            postString += "      \"ativo\": \"" + "1" + "\"";
            postString += "}";

            RetornoFabricante RetornoMarca = null;
            try
            {

                Logs.GerarLog("Integradora.Norma.Winthor.Shoppub", "SendMarcas", string.Format("json fabricante: {0}", postString));
                RetornoMarca = LojaECommerce.EnviarMarca(postString);

                if (RetornoMarca.Sucesso)
                {
                    string descricao = RetornoMarca.nome;
                    string comando = @"UPDATE PCMARCA
                                   SET IDFABRICANTE_SHOPPUB = {0}
                                   WHERE CODMARCA      = {1}";

                    comando = string.Format(comando, RetornoMarca.id, registros.Codmarca);
                    Logs.GerarLog("Integradora.Norma.Winthor.Shoppub", "SendMarcas", comando);

                    PCMarca atualizamarca = new PCMarca();
                    atualizamarca.ExecutarComando(comando);

                }

            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Shoppub", "SendMarcas", ex);
            }

            //            //            string pathLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogAtualiza.txt");
            //            //            File.WriteAllText(pathLog, String.Format("QUANTIDADE DE PRODUTOS: {0}", listaProdutos.Count));


        }
        */

        private void SendProdutos(VWAdenaProdutos registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {

            decimal PrecoVenda = Math.Round(registros.Preco, 2);
            string NomeProduto = Formats.RemoverCaracteres(registros.Nome);
            string postString = "{";
        //    postString += "      \"sku\": \"" + "CL-" + registros.Codprod.ToString() + "\",";
                //postString += "      \"fabricante\": " + registros.IdFabricante.ToString() + ",";

            postString += "      \"produtos\": { ";
            postString += "      \"produto\": {";
            postString += "      \"codigo\": \"" + registros.CodProd.ToString() + "\",";
            postString += "      \"nome\": \"" + registros.Nome + "\",";
            postString += "      \"resumo\": \"" + registros.Nome + "\",";
            postString += "      \"descricao\": \"" + registros.Nome + "\",";
            postString += "      \"id_categoria\": " + registros.IdCategoria.ToString() + ",";
            postString += "      \"categoria\": \"" + registros.Categoria + "\",";
            postString += "      \"destaque_home\": \"" + "0" + "\",";
            postString += "      \"destaque_categoria\": \"" + "0" + "\",";
            postString += "      \"tipo\": \"" + "Padrao" + "\",";
            //postString += "      \"destaque_home\": \"" + "0" + "\",";
            postString += "      \"sku_produto\": {";
            postString += "      \"sku\": \"" + registros.Sku.ToString() + "\",";
            postString += "      \"estoque\": \"" + registros.QtEstoque.ToString().Replace(",", ".") + "\",";
            postString += "      \"custo\": \"" + registros.Custo.ToString().Replace(",", ".") + "\",";
            postString += "      \"preco\": \"" + registros.Preco.ToString().Replace(",", ".") + "\",";
            postString += "      \"preco_de\": \"" + registros.Preco.ToString().Replace(",", ".") + "\",";
            postString += "      \"sku_padrao\": \"" + "0" + "\",";
            postString += "      \"status\": \"" + "D" + "\",";
            postString += "      \"peso\": \"" + registros.Peso.ToString().Replace(",", ".") + "\",";
            postString += "      \"altura\": \"" + registros.Altura.ToString().Replace(",", ".") + "\",";
            postString += "      \"largura\": \"" + registros.Largura.ToString().Replace(",", ".") + "\",";
            postString += "      \"profundidade\": \"" + registros.Profundidade.ToString().Replace(",", ".") + "\",";
            postString += "      \"estoque_minimo\": \"" + registros.EstoqueMinimo.ToString().Replace(",", ".") + "\",";

            postString += "      \"codigo_barras\": [";
            postString += registros.Codauxiliar.ToString() ;
            if (!string.IsNullOrEmpty(registros.Codauxiliar.ToString()))
            {
                postString += ", " + registros.Codauxiliar.ToString(); 
            }
            postString += "       ]";
            postString += "}"; //tag sku_produto
            postString += "}"; //tag produto
            postString += "}"; //tag produtos
            postString += "}"; //tag produtos

            try
            {
                if (LojaECommerce == null)
                {
                    Biblioteca.Tools.Logs.GerarLog("Loja nulo");
                }
                Biblioteca.Tools.Logs.GerarLog(string.Format("json produto: {0}", postString));
             
                var listaProdutos = LojaECommerce.EnviarProduto(postString);
                string pathLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogAtualiza.txt");
                //            File.WriteAllText(pathLog, String.Format("QUANTIDADE DE PRODUTOS: {0}", listaProdutos.Count));
                /*if (listaProdutos != null)
                {

                    if (listaProdutos.Count > 0)
                    {
                        foreach (Resultado retorno in listaProdutos)
                        {
                            //                    File.WriteAllText(pathLog, String.Format("Inciando a lista: SKU: {0}, ID: {1}, Status:{2}", retorno.SKU, retorno.Id, retorno.Sucesso.ToString())); 
                            if (retorno.Sucesso)
                            {
                                string comando = @"UPDATE PCPRODUT
                                          SET CODPRODRELEV = {0}
                                        WHERE CODPROD      = {1}";
                                string codigoproduto = Biblioteca.Tools.Numbers.OnlyNumbers(retorno.SKU);
                                comando = string.Format(comando, retorno.Id, codigoproduto);

                                File.WriteAllText(pathLog, comando);

                                PCProdut atualizaproduto = new PCProdut();
                                atualizaproduto.ExecutarComando(comando);
                            }

                        }

                    }
                }
                else
                {
                    Biblioteca.Tools.Logs.GerarLog("Resultado nulo");
                } */
            } 

            catch (Exception erro)
            {
                Biblioteca.Tools.Logs.GerarLog("Percorrendo Lista", "Envia Produtos adena", erro);
            }
            //List<Integradora. Resultado> listaProdutos = LojaECommerce.EnviarProduto(postString);


        }

        private void SendPosicaoPedido(PCPedc pCPedc, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            throw new NotImplementedException();
        }
    }
}

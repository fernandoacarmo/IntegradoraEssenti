using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using Integradora.ECommerce.Shoppub;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Shoppub
{

    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.Shoppub.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.Shoppub.Integracao();
        }

        public void Process(Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadShoppub("1=1 order by dtinclusao");
            foreach (var item in lista)
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        if (Biblioteca.Dictionaries.Settings.Debugando())
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.Shoppub", "Process", "Enviar: " + item.Tabela);
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
                                case "VWSHOPPUBPRODUTOS":
                                    SendProdutos((VWShoppubProdutos)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCMARCA":
                                    SendMarcas((PCMarca)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;

                                // case "PCPEDC":
                                //     SendPosicaoPedido((PCPedc)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                //     break;
                            }
                        }
                        else
                        {
                            if (Biblioteca.Dictionaries.Settings.Debugando())
                            {
                                Logs.GerarLog("Integradora.Norma.Winthor.Shoppub", "Process", string.Format("Nenhum registro encontrado para a tabela: {0} - Filtro: {1}", item.Tabela, filtro));
                            }
                        }

                        Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.Shoppub", "Process", ex);
                    }
                }
            }
        }

        private void SendMarcas(PCMarca registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
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


        private void SendProdutos(VWShoppubProdutos registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {

            decimal PrecoVenda = Math.Round(registros.Pvenda, 2);
            string NomeProduto = Formats.RemoverCaracteres(registros.Produto);
            string postString = "{";
   //         if (registros.Codprodrelev > 0)
   //             postString += "      \"id\"" + registros.Codprodrelev.ToString() + "\",";
            if (registros.Codprodrelev > 0)
            {
                postString += "      \"sku\": \"" + "CL-" + registros.Codprod.ToString() + "\",";
                postString += "      \"nome\": \"" + registros.Produto + "\",";
                postString += "      \"slug\": \"" + registros.Codprod.ToString() + "-" + NomeProduto.Replace(" ", "-") + "\",";
                postString += "      \"fabricante\": " + registros.IdFabricante.ToString() + ",";
                postString += "      \"preco_de\": " + PrecoVenda.ToString().Replace(",", ".") + ",";
                postString += "      \"preco_por\": " + PrecoVenda.ToString().Replace(",", ".") + ",";
                postString += "      \"preco_atacado\": " + PrecoVenda.ToString().Replace(",", ".") + ",";
                postString += "      \"preco_custo\": " + PrecoVenda.ToString().Replace(",", ".") + ",";
                postString += "      \"ncm\": \"" + registros.Nbm + "\",";
                postString += "      \"estoque\": " + registros.Qtestoque.ToString().Replace(",", ".") + ",";
                postString += "      \"estoque_reserva\": " + registros.Qtreserv.ToString().Replace(",", ".") + ",";
                postString += "      \"estoque_minimo\": 0";
            }
            else
            {
                postString += "      \"sku\": \"" + "CL-" + registros.Codprod.ToString() + "\",";
                postString += "      \"nome\": \"" + registros.Produto + "\",";
                postString += "      \"slug\": \"" + registros.Codprod.ToString() + "-" + NomeProduto.Replace(" ", "-") + "\",";

                postString += "      \"fabricante\": " + registros.IdFabricante.ToString() + ",";

                postString += "      \"ativo\": false,";
                postString += "      \"destaque\": false,";
                postString += "      \"lancamento\": false,";
                postString += "      \"promocao\": false,";
                postString += "      \"is_wrapper\": false,";
                postString += "      \"home\": false,";
                postString += "      \"genero\": null,";
                postString += "      \"envio_especial\": false,";
                postString += "      \"principal\": false,";
                postString += "      \"seo_tag_title\": null,";
                postString += "      \"seo_meta_tag_description\": null,";
                postString += "      \"seo_meta_tag_keyword\": null,";
                postString += "      \"preco_de\": " + PrecoVenda.ToString().Replace(",", ".") + ",";
                postString += "      \"preco_por\": " + PrecoVenda.ToString().Replace(",", ".") + ",";
                postString += "      \"preco_atacado\": " + PrecoVenda.ToString().Replace(",", ".") + ",";
                postString += "      \"preco_custo\": " + PrecoVenda.ToString().Replace(",", ".") + ",";
                postString += "      \"peso\": " + registros.Pesoliq.ToString().Replace(",", ".") + ",";
                postString += "      \"altura\": " + registros.Alturam3.ToString().Replace(",", ".") + ",";
                postString += "      \"largura\": " + registros.Larguram3.ToString().Replace(",", ".") + ",";
                postString += "      \"comprimento\": " + registros.Comprimentom3.ToString().Replace(",", ".") + ",";
                postString += "      \"ncm\": \"" + registros.Nbm + "\",";
   //             postString += "      \"categorias\": [";
   //             postString += "       4";
  //              postString += "       ],";
                postString += "      \"estoque\": " + registros.Qtestoque.ToString().Replace(",", ".") + ",";
                postString += "      \"estoque_reserva\": " + registros.Qtreserv.ToString().Replace(",", ".") + ",";
                postString += "      \"estoque_minimo\": 0";

            }


            //            postString += "atributo_grupo": 10,
            //            postString += "fabricante": 18,
            //            postString += "codigo": "",
            //            postString += "gtin": "",
            //            postString += "mpn": "",
            //            postString += "parent": "null",
            //            postString += "categorias": [
            //            postString +=   141,
            //            postString +=   225
            //            postString += ],
            //            postString += "cores": [ ],
            //            postString += "produtos_recomendados_relacionados": [ ],
            //            postString += "atributos_valores": [
            //            postString +=   59
            //            postString += ],
            //            postString += "loja_vendedora": 1,
            //            postString +=  "grupos": [
            //            postString +=     4
            //            postString += ]

            postString += "}";

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
                if (listaProdutos != null)
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
                }
            }
            catch (Exception erro)
            {
                Biblioteca.Tools.Logs.GerarLog("Percorrendo Lista", "Envia Produtos shoppu", erro);
            }
            //List<Integradora. Resultado> listaProdutos = LojaECommerce.EnviarProduto(postString);




        }

        private void SendPosicaoPedido(PCPedc pCPedc, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            throw new NotImplementedException();
        }
    }
}


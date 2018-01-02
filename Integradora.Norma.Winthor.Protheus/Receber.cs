using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.Domain;
using Integradora.ERP.Winthor.EntityPedidoDireto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Protheus
{
    class Receber : IProcessIntegration
    {
        Localizacao localizacao = null;
        List<Pedido> ListaPedidos = null;
        PedidoDireto pedidoDireto = null;
        string CaminhoFTP = Biblioteca.Dictionaries.Settings.FTPEndereco() + "Remessa/";

        public Receber()
        {
            localizacao = new Localizacao();
            ListaPedidos = new List<Pedido>();
            pedidoDireto = new PedidoDireto();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            PedidoViaFTP();
            //PedidoViaArquivoTexto();
        }

        private void PedidoViaFTP()
        {
            FtpWebRequest request = localizacao.ConectarFTP(CaminhoFTP, WebRequestMethods.Ftp.ListDirectory);
            if (request != null)
            {
                try
                {
                    try
                    {
                        List<string> liArquivos = new List<string>();
                        //Cria comunicação com o servidor
                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                        try
                        {
                            //Criando a Stream para pegar o retorno
                            Stream responseStream = response.GetResponseStream();
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                //Adicionar os arquivos na lista
                                liArquivos = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                            }
                        }
                        finally
                        {
                            response.Close();
                        }

                        //Responder a lista dos arquivos
                        foreach (string item in liArquivos)
                        {
                            if (item.ToUpper().Contains(".TXT"))
                            {
                                Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Protheus"
                                                              , "PedidoViaFTP"
                                                              , "Importar arquivo: " + item.ToString());
                                FTPDownloadArquivo(item);

                                PedidoViaArquivoTexto();
                                //bool resultado = 
                                //if (resultado)
                                //{
                                FTPMoverArquivo(item, true);
                                //}
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Protheus"
                                                      , "PedidoViaFTP"
                                                      , string.Format("Erro ao listar pedidos a ser importado no caminho: {0}, erro: {1}", CaminhoFTP, ex.ToString()));
                    }
                }
                finally
                {
                    request = null;
                }
            }
        }

        private void FTPMoverArquivo(string arquivo, bool sucessonaintegracao)
        {
            string arquivoOrigem = CaminhoFTP + arquivo;
            string arquivoDestino = "Processado/" + arquivo;
            FtpWebRequest request = localizacao.ConectarFTP(arquivoOrigem, WebRequestMethods.Ftp.Rename);
            if (request != null)
            {
                try
                {
                    try
                    {
                        try
                        {
                            request.RenameTo = arquivoDestino;
                        }
                        finally
                        {
                            request.GetResponse().Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Protheus"
                                                      , "FTPMoverArquivo"
                                                      , string.Format("Erro ao mover arquivo de pasta {0} para {1}, erro: {2}", arquivoOrigem, arquivoDestino, ex.ToString()));
                    }
                }
                finally
                {
                    request = null;
                }
            }
        }
        private void FTPDownloadArquivo(string arquivo)
        {
            string CaminhoCompleto = CaminhoFTP + "/" + arquivo;
            FtpWebRequest request = localizacao.ConectarFTP(CaminhoCompleto, WebRequestMethods.Ftp.DownloadFile);
            if (request != null)
            {
                try
                {
                    try
                    {
                        //definindo o arquivo para download
                        //criando o objeto FtpWebResponse
                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                        try
                        {
                            //Criando a Stream para ler o arquivo
                            Stream responseStream = response.GetResponseStream();
                            string pathArquivo = Path.Combine(localizacao.DiretorioRemessa, arquivo);
                            FileStream newFile = new FileStream(pathArquivo, FileMode.Create);
                            try
                            {
                                byte[] buffer = new byte[2048];
                                //Definir o local onde o arquivo será criado.
                                //Ler o arquivo de origem
                                int readCount = responseStream.Read(buffer, 0, buffer.Length);
                                while (readCount > 0)
                                {
                                    //Escrever o arquivo
                                    newFile.Write(buffer, 0, readCount);
                                    readCount = responseStream.Read(buffer, 0, buffer.Length);
                                }
                            }
                            finally
                            {
                                newFile.Close();
                                responseStream.Close();
                            }
                        }
                        finally
                        {
                            response.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Protheus"
                                                      , "FTPDownloadArquivo"
                                                      , string.Format("Erro ao mover arquivo de pasta {0} para {1}, erro: ", CaminhoCompleto, ex.ToString()));
                    }
                }
                finally
                {
                    request = null;
                }
            }
        }
        private bool PedidoViaArquivoTexto()
        {
            bool enviarParaNaoProcessado = false;
            //Monta o diretório de monitoramento
            DirectoryInfo diretorio = new DirectoryInfo(localizacao.DiretorioRemessa);

            //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
            FileInfo[] Arquivos = diretorio.GetFiles(localizacao.Extensao);

            //Começamos a listar os arquivos
            foreach (FileInfo fileinfo in Arquivos)
            {
                //Limpa a lista de pedidos já importada, e uma lista por arquivo
                ListaPedidos.Clear();

                System.IO.StreamReader file = new System.IO.StreamReader(fileinfo.FullName);
                try
                {
                    string linha = "";
                    while ((linha = file.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(linha))
                        {
                            //Verificando o tipo do registro
                            switch (linha.Substring(0, 2))
                            {
                                case "01": InserirCabecalho(linha); //Inserir cabeçalho 
                                    break;
                                case "02": InserirItem(linha); //Inserir item
                                    break;
                                default:
                                    break;
                            }
                        }

                    }
                }
                finally
                {
                    file.Close();
                }

                string processado = "OK";

                if (ListaPedidos.Count > 0)
                {
                    foreach (var item in ListaPedidos)
                    {
                        processado = pedidoDireto.Gravar(item);
                        if (processado != "OK")
                        {
                            Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Protheus", "PedidoViaArquivoTexto", "Erro: " + processado);
                            enviarParaNaoProcessado = true;
                        }
                    }
                }
                else
                {
                    enviarParaNaoProcessado = true;
                }

                string arquivodestino = "";
                if (enviarParaNaoProcessado)
                {
                    arquivodestino = Path.Combine(localizacao.DiretorioNaoProcessado, fileinfo.Name);
                }
                else
                {
                    arquivodestino = Path.Combine(localizacao.DiretorioProcessado, fileinfo.Name);
                }
                try
                {
                    fileinfo.CopyTo(arquivodestino);
                }
                catch { }
                try
                {
                    fileinfo.Delete();                  
                }
                catch { }
            }

            return !enviarParaNaoProcessado;
        }

        private string InserirCabecalho(string linha)
        {
            string retorno = "OK";
            try
            {
                Pedido cabecalho = new Pedido();
                string[] campos = linha.Split('|');

                if (!string.IsNullOrEmpty(campos[1]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Codfilial = campos[1];                                                                     //01 - Filial	            C5_FILIAL	                    Char	    2	
                if (!string.IsNullOrEmpty(campos[2]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Numpedido = Biblioteca.Tools.Numbers.ToInt64(campos[2]);                                   //02 - Número              C5_NUM	                        Char	    6	
                if (!string.IsNullOrEmpty(campos[3]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Dtemissao = DateTime.ParseExact(campos[3], "yyyyMMdd", CultureInfo.InvariantCulture);      //03 - Data	            C5_EMISSAO	                    Date	    8	
                if (!string.IsNullOrEmpty(campos[4]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Valortotal = Convert.ToDecimal(campos[4].Replace(".", ","));                                                 //04 - Valor Pedido	    Somatória(C6_VALOR)	            Num	        12.2	
                if (!string.IsNullOrEmpty(campos[5]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Cliente.CNPJCPF = campos[5];                                                               //05 - CNPJ Cliente	    Posicione(A1_CGC)	            Char	    14	
                if (!string.IsNullOrEmpty(campos[6]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Dtentrega = DateTime.ParseExact(campos[6], "yyyyMMdd", CultureInfo.InvariantCulture);      //06 - Data Entrega	    C5_ZPREFAT	                    Date	    8	
                if (!string.IsNullOrEmpty(campos[7]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Totalpeso = Convert.ToDecimal(campos[7].Replace(".", ","));                                                  //07 - Total Peso	        Somatória(B1_PESBRU)	        Num	        11.4	
                if (!string.IsNullOrEmpty(campos[8]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Totalvolume = Convert.ToDecimal(campos[8].Replace(".", ","));                                                //08 - Total Volume	    Não há	                        Num	        1	enviar zeros
                //09 - Qtde Itens	        Converter numerico	            Num	        2	Quantidade de itens
                if (!string.IsNullOrEmpty(campos[10]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Cliente.Razaosocial = campos[10];                                                          //10 - RazaoSocial Cliente	Posicione(A1_NOME)	            Char	    40	
                if (!string.IsNullOrEmpty(campos[11]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Cliente.Inscricaoestadual = campos[11];                                                    //11 - Inscrição Estadual	Posicione(A1_INSCR)	            Char	    18	
                if (!string.IsNullOrEmpty(campos[12]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Cliente.Endereco = campos[12];                                                             //12 - Logradouro (Rua)	Posicione(A1_ENDENT)	        Char	    40	Endereço de entrega do cliente
                if (!string.IsNullOrEmpty(campos[13]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Cliente.Numero = campos[13];                                                                //13 - Numero	            Não há	                        Num	        1	enviar zeros
                if (!string.IsNullOrEmpty(campos[14]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Cliente.Bairro = campos[14];                                                                //14 - Bairro	            Posicione(A1_BAIRROE)	        Char	    20	Bairro de entrega do cliente
                if (!string.IsNullOrEmpty(campos[15]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Cliente.Cidade = campos[15];                                                                //15 - Cidade	            Posicione(A1_MUNE)	            Char	    25	Municipio de entrega do cliente
                if (!string.IsNullOrEmpty(campos[16]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Cliente.Estado = campos[16];                                                                //16 - Estado	            Posicione(A1_ESTE)	            Char	    2	UF de entrega do cliente
                if (!string.IsNullOrEmpty(campos[17]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Cliente.CEP = campos[17];                                                                  //17 - CEP	                Posicione(A1_CEPE)	            Char	    8	CEP de entrega do cliente
                if (!string.IsNullOrEmpty(campos[18]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    cabecalho.Cliente.CodIBGE = Biblioteca.Tools.Numbers.ToInt32(campos[18]);                           //18 - Codigo Cidade IBGE	Posicione(CC2_CODMUN,A1_MUNE)	Char	    5	Sem código da UF

                if (cabecalho.Numpedido > 0)
                {
                    ListaPedidos.Add(cabecalho);
                }
            }
            catch (Exception ex)
            {
                retorno = "Erro ao importar item: " + ex.ToString();
            }
            return retorno;
        }

        private string InserirItem(string linha)
        {
            string retorno = "OK";
            try
            {
                ItemPedido item = new ItemPedido();
                string[] campos = linha.Split('|');

                item.Numitem = ListaPedidos.Last().Itens.Count + 1;
                //    Nome	                        Campo	                Tipo	    Tam	    Obs
                //00 - Detalhe	                    Campo fixo	            Char	    2	    Enviar '02'
                //01 - Filial	                    C6_FILIAL	            Char	    2	
                //02 - Número do Pedido	            C6_NUM	                Char	    6	
                //03 - Data	                        C5_EMISSAO	            Date	    8	
                //04 - CNPJ Cliente	                Posicione(A1_CGC)	    Char	    14	

                if (!string.IsNullOrEmpty(campos[05]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    item.Codproduto = Biblioteca.Tools.Numbers.ToInt32(campos[05]); //05 - Código Produto Protheus	    C6_Produto	            Char	    30	    Usar código do produto do Protheus
                if (!string.IsNullOrEmpty(campos[06]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    item.Codauxiliar = Convert.ToDecimal(campos[06]);               //06 - Codigo Produto (EAN)	        Posicione(B1_CODBAR)	Char	    30	    Conforme produto será enviado em branco
                if (!string.IsNullOrEmpty(campos[07]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    item.Quantidade = Convert.ToDecimal(campos[07].Replace(".", ","));                //07 - Quantidade	                C6_QTDVEN	            Num	        9.2	    Quantidade vendidade 1a unidade (em caixas)
                if (!string.IsNullOrEmpty(campos[08]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    item.Precovenda = Convert.ToDecimal(campos[08].Replace(".", ","));                //08 - Preço Venda	                C6_PRCVEN	            Num	        18.6	Preço de venda 
                if (!string.IsNullOrEmpty(campos[09]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    item.Descricao = campos[09];                                    //09 - Descrição Produto	        C6_DESCRI	            Char	    45	
                if (!string.IsNullOrEmpty(campos[10]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    item.Embalagem = campos[10];                                    //10 - Embalagem	                Posicione(B1_CODEMB)	Char	    20	    Informação não preenchida no Protheus
                if (!string.IsNullOrEmpty(campos[11]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    item.Unidade = campos[11];                                      //11 - Unidade	                    C6_UM	                Char	    2	    Unidade de medida 1a unidade (em caixas)
                if (!string.IsNullOrEmpty(campos[12]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    item.Qtdeunitaria = Convert.ToDecimal(campos[12].Replace(".", ","));              //12 - Quantidade Emb. Venda	    Posicione(B1_QE)	    Num	        9	    Quantidade por embalagem
                if (!string.IsNullOrEmpty(campos[13]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    item.Qtdecaixa = Convert.ToDecimal(campos[13].Replace(".", ","));                 //13 - Quantidade Emb. Master	    Posicione(B1_CONV)	    Num	        7.2	    Fator de conversão embalagem de embarque do produto
                if (!string.IsNullOrEmpty(campos[14]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    item.Pesobruto = Convert.ToDecimal(campos[14].Replace(".", ","));                 //14 - Peso Bruto	                Posicione(B1_PESBRU)	Num	        11.4	Peso bruto unitário
                if (!string.IsNullOrEmpty(campos[15]))                                                                                                     //00 - Cabeçalho	        Campo fixo	                    Char	    2	Enviar '01'
                    item.Pesoliquido = Convert.ToDecimal(campos[15].Replace(".", ","));               //15 - Peso Liq.	                Posicione(B1_PESO)	    Num	        11.4	Peso liquido unitário


                ListaPedidos.Last().Itens.Add(item);
            }
            catch (Exception ex)
            {
                retorno = "Erro ao importar item: " + ex.ToString();
            }
            return retorno;
        }

    }
}

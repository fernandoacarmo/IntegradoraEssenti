using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Protheus
{
    class Enviar : IProcessIntegration
    {
        Localizacao localizacao = null;
        string CaminhoFTP = Biblioteca.Dictionaries.Settings.FTPEndereco() + "/Retorno/";

        public Enviar()
        {
            localizacao = new Localizacao();
        }
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            EnviarRetornoPedidos();
        }

        private void EnviarRetornoPedidos()
        {
            List<VWPedidoProtheus> ListaPedidos = VWPedidoProtheus.Listar();
            if (ListaPedidos.Count > 0)
            {
                DirectoryInfo diretorio = new DirectoryInfo(localizacao.DiretorioRemessa);
                string nomeArquivo = "ret" + String.Format("{0:yyyyMMddhhmmss}", DateTime.Now) + ".TXT";
                string pathArquivo = Path.Combine(localizacao.DiretorioRemessa, nomeArquivo);

                Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Protheus"
                                              , "EnviarRetornoPedidos"
                                              , "Exportar arquivo: " + nomeArquivo.ToString());

                StreamWriter valor = new StreamWriter(pathArquivo, true, Encoding.ASCII);
                Oracle bd = new Oracle(PCPedc.GetStringConnection());
                foreach (var item in ListaPedidos)
                {
                    string linha = Biblioteca.Dictionaries.Settings.Protheus_Filial() + "|" +
                                   item.Numped.ToString().PadLeft(6, '0') + "|" +
                                   string.Format("CARGA: {0}, BOX: {1}, VOLUME: {2}"
                                                , item.Numcar.ToString()
                                                , item.Esc_box
                                                , item.Totvolume
                                                ) +
                                  Environment.NewLine; //Salta a linha

                    valor.Write(linha);
                    bd.ExecuteNonQuery(@"UPDATE PCPEDC  
                                            SET ESC_DTENVIOPROTHEUS = SYSDATE 
                                          WHERE NUMPED = " + item.Numped.ToString());
                }
                valor.Close();

                string arquivodestino = "";
                FileInfo fileinfo = new FileInfo(pathArquivo);
                if (FTPUploadArquivo(nomeArquivo, pathArquivo))
                {
                    arquivodestino = Path.Combine(localizacao.DiretorioProcessado, fileinfo.Name);
                }
                else
                {
                    arquivodestino = Path.Combine(localizacao.DiretorioNaoProcessado, fileinfo.Name);
                }
                fileinfo.CopyTo(arquivodestino);
                fileinfo.Delete();
            }
        }

        private bool FTPUploadArquivo(string arquivo, string caminhocompleto)
        {
            bool processado = false;
            //definindo o arquivo para download
            FtpWebRequest request = localizacao.ConectarFTP(CaminhoFTP + "/" + arquivo, WebRequestMethods.Ftp.UploadFile);
            if (request != null)
            {
                try
                {
                    try
                    {
                        //Caminho do arquivo para upload
                        FileInfo fileInf = new FileInfo(caminhocompleto);

                        request.ContentLength = fileInf.Length;
                        //cria a stream que será usada para mandar o arquivo via FTP
                        Stream responseStream = request.GetRequestStream();
                        byte[] buffer = new byte[2048];

                        //Lê o arquivo de origem
                        FileStream fs = fileInf.OpenRead();
                        try
                        {
                            //Enquanto vai lendo o arquivo de origem, vai escrevendo no FTP
                            int readCount = fs.Read(buffer, 0, buffer.Length);
                            while (readCount > 0)
                            {
                                //Esceve o arquivo
                                responseStream.Write(buffer, 0, readCount);
                                readCount = fs.Read(buffer, 0, buffer.Length);
                            }
                        }
                        finally
                        {
                            fs.Close();
                            responseStream.Close();
                        }

                        processado = true;
                    }
                    catch (Exception ex)
                    {
                        processado = false;
                        Logs.GerarLog("Integradora.Norma.Winthor.Protheus.Enviar"
                                     , "FTPUploadArquivo"
                                     , string.Format("Erro ao fazer upload para ftp do arquivo: {0}, erro: {1}"
                                                    , caminhocompleto, ex.ToString()));
                    }
                }
                finally
                {
                    request = null;
                }
            }

            return processado;
        }
    }
}

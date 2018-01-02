using Integradora.Biblioteca.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Protheus
{
    public class Localizacao
    {
        private string diretorioretorno;
        private string diretorioremessa;
        private string diretorionaoprocessado;
        private string diretorioprocessado;

        public string Extensao
        {
            get { return "*.txt"; }
            set { }
        }

        public FtpWebRequest ConectarFTP(string endereco, string Metodo)
        {
            try
            {
                //Definir o diretório a ser listado
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(endereco);
                //Define que a ação vai ser de listar diretório
                request.Method = Metodo;
                //Credenciais para o login (usuario, senha)
                request.Credentials = new NetworkCredential(Biblioteca.Dictionaries.Settings.FTPUsuario(), Biblioteca.Dictionaries.Settings.FTPSenha());
                //modo passivo
                request.UsePassive = false;
                //dados binarios
                request.UseBinary = true;
                //setar o KeepAlive para true
                request.KeepAlive = true;
                //setar timeout
                request.Timeout = 10000000;

                return request;
            }
            catch (Exception ex)
            {
                Biblioteca.Tools.Logs.GerarLog("Integradora.Norma.Winthor.Protheus"
                                              , "ConectarFTP"
                                              , string.Format("Não foi possível conectar no FTP: {0} - Erro: {1}", endereco, ex.ToString()));
                return null;
            }
        }

        public string DiretorioRetorno
        {
            get
            {
                if (string.IsNullOrEmpty(diretorioretorno))
                {
                    diretorioretorno = MontarDiretorio("Retorno");
                }
                return diretorioretorno;
            }
            set
            {
                diretorioretorno = value;
            }
        }

        public string DiretorioRemessa
        {
            get
            {
                if (string.IsNullOrEmpty(diretorioremessa))
                {
                    diretorioremessa = MontarDiretorio("Remessa");
                }
                return diretorioremessa;
            }
            set
            {
                diretorioremessa = value;
            }
        }

        public string DiretorioNaoProcessado
        {
            get
            {
                if (string.IsNullOrEmpty(diretorionaoprocessado))
                {
                    diretorionaoprocessado = MontarDiretorio("NaoProcessado");
                }
                return diretorionaoprocessado;
            }
            set
            {
                diretorionaoprocessado = value;
            }
        }

        public string DiretorioProcessado
        {
            get
            {
                if (string.IsNullOrEmpty(diretorioprocessado))
                {
                    diretorioprocessado = MontarDiretorio("Processado");
                }
                return diretorioprocessado;
            }
            set
            {
                diretorioprocessado = value;
            }
        }
        private string MontarDiretorio(string diretorio)
        {
            string retorno = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, diretorio);
            try
            {
                if (!Directory.Exists(retorno))
                {
                    Directory.CreateDirectory(retorno);
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Protheus.Localizacao", "MontarDiretorio", "Erro ao criar diretório: " + diretorio + " - Erro: " + ex.ToString());
            }
            return retorno;
        }
    }
}

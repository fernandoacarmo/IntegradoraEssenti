using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ERP.Winthor.Inherited
{
    public class OracleObjeto : Integradora.Biblioteca.Interfaces.IEntity
    {
        private static string ConnectionString_Winthor = "";

        public static string GetStringConnection()
        {
            if (string.IsNullOrEmpty(ConnectionString_Winthor))
            {
                string ArquivoWinthorINI = Integradora.Biblioteca.Dictionaries.Settings.Winthor_ArquivoINI();
                try
                {
                    if (!string.IsNullOrEmpty(ArquivoWinthorINI))
                    {
                        string NomeServidor = Integradora.Biblioteca.Dictionaries.Settings.Winthor_Servidor().ToUpper();
                        string NomeUsuario = Integradora.Biblioteca.Dictionaries.Settings.Winthor_Usuario().ToUpper();
                        string SenhaUsuario = "";

                        WinThorIni ini = new WinThorIni(ArquivoWinthorINI);
                        foreach (LojasWinThorIni loja in ini.ObterLojasEmpresas())
                        {
                            if (loja.Nome.ToUpper() == NomeServidor)
                            {
                                foreach (string empresa in loja.Empresas)
                                {
                                    if (empresa.ToUpper() == NomeUsuario)
                                    {
                                        LicencaUso licenca = ini.ObterLicencaUso(loja.Nome, empresa);
                                        SenhaUsuario = licenca.SenhaBD;

                                        ConnectionString_Winthor = string.Format("Data Source={0}; User ID={1}; Password={2}"
                                                                                , NomeServidor
                                                                                , NomeUsuario
                                                                                , SenhaUsuario);

                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logs.GerarLog("Integradora.ERP.Winthor", "GetStringConnection", ex);                    
                }

                if (string.IsNullOrEmpty(ConnectionString_Winthor))
                {
                    ConnectionString_Winthor = Integradora.Biblioteca.Dictionaries.Settings.Winthor_Conexao();
                }
            }

            return ConnectionString_Winthor;

        }

        public DateTime DataHoraServidor()
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.GetDataHoraServidor();
        }

        public DateTime DataServidor()
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.GetDataServidor();
        }

        public decimal Proximo(string nomeSequence)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.GetProximoID(nomeSequence);
        }

        public decimal Proximo(string nomedatabela, string nomecampo)
        {
            return Proximo(nomedatabela, nomecampo, "1=1");
        }

        public decimal Proximo(string nomedatabela, string nomecampo, string filtro)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.GetProximoID(nomedatabela, nomecampo, filtro);
        }

        public decimal Maior(string nomedatabela, string nomecampo, string filtro)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Maior(nomedatabela, nomecampo, filtro);
        }

        public DateTime? GetDataCampo(string script)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.GetValorCampoDate(script);
        }
        public string GetTextoCampo(string script)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.GetValorCampoString(script);
        }
        public decimal GetValorCampo(string script)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.GetValorCampoDecimal(script);
        }
        
    }
}

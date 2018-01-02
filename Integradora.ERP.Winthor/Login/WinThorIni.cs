using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;

namespace Integradora.ERP.Winthor.Login
{
    internal class LicencaUso
    {
        public string NomeLoja { get; set; }
        public string NomeEmpresa { get; set; }
        public string NomeCliente { get; set; }
        public int CodigoCliente { get; set; }
        public int QuantidadeLicencas { get; set; }
        public DateTime DataExpiracao { get; set; }
        public string SenhaBD { get; set; }

        [DllImport("PCINF000Crypt.dll",
            EntryPoint = "PCDecryptDES",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        private static extern void PCDecryptDES(IntPtr codificado, IntPtr keyCript, StringBuilder retornoDecodificado);

        [DllImport("PCINF000Crypt.dll",
            EntryPoint = "DecodificarSenha",
            CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        private static extern void DecodificarSenha(IntPtr nomeBancoDados, IntPtr nomeUsuarioBD,
            IntPtr senhaBDCripto, StringBuilder senhaBDDecripto);

        private static string GerarKeyDESAntigo()
        {
            return "P#?xc@?Sy-##???Sx?@&";
        }

        private static string GerarKeyDESNovo()
        {
            return @"Z?mjg@?GJ&75lg#@#x!3w1\@@##";
        }

        private static string DecodificarChave(string chaveCripto, bool novo)
        {
            StringBuilder retornoDecodificado = new StringBuilder(200);
            IntPtr codificadoPtr = Marshal.StringToHGlobalAnsi(chaveCripto);
            IntPtr keyCript = Marshal.StringToHGlobalAnsi(novo ? GerarKeyDESNovo() : GerarKeyDESAntigo());

            PCDecryptDES(codificadoPtr, keyCript, retornoDecodificado);

            // Libera memória alocada
            Marshal.FreeHGlobal(codificadoPtr);
            Marshal.FreeHGlobal(keyCript);

            return retornoDecodificado.ToString();
        }

        public static string DecriptoSenha(string bancoDados, string usuarioBD,
            string senhaCripto)
        {
            StringBuilder senhaDecripto = new StringBuilder(2000);
            IntPtr bancoDadosPtr = Marshal.StringToHGlobalAnsi(bancoDados);
            IntPtr usuarioBDPtr = Marshal.StringToHGlobalAnsi(usuarioBD);
            IntPtr senhaCriptoPtr = Marshal.StringToHGlobalAnsi(senhaCripto);


            DecodificarSenha(bancoDadosPtr, usuarioBDPtr, senhaCriptoPtr, senhaDecripto);

            // Libera memória alocada
            Marshal.FreeHGlobal(bancoDadosPtr);
            Marshal.FreeHGlobal(usuarioBDPtr);
            Marshal.FreeHGlobal(senhaCriptoPtr);

            return senhaDecripto.ToString();
        }

        private static string DecodificarSenha(
            string nomeBancoDados, string nomeUsuarioBD, string senhaBDCripto)
        {
            return DecriptoSenha(nomeBancoDados, nomeUsuarioBD, senhaBDCripto);
        }

        public LicencaUso(string loja, string empresa, string chaveCriptografada, string senhaBDCripto)
        {
            this.NomeLoja = loja;
            this.NomeEmpresa = empresa;
            this.SenhaBD = DecodificarSenha(this.NomeLoja, this.NomeEmpresa, senhaBDCripto);

            string chaveDecripto = DecodificarChave(chaveCriptografada, false);

            string[] trechos = chaveDecripto.Split(new char[] { ';' });

            if (trechos.Length < 4)
            {
                chaveDecripto = DecodificarChave(chaveCriptografada, true);

                trechos = chaveDecripto.Split(new char[] { ';' });

                if (trechos.Length < 4)
                {
                    throw new Exception("Licença inválida. A licença codificada contém menos de 4 trechos.");
                }
                else
                {
                    PreencherDados(trechos);
                }
            }
            else
            {
                PreencherDados(trechos);
            }
        }

        private void PreencherDados(string[] trechos)
        {
            this.NomeCliente = trechos[0];
            this.CodigoCliente = int.Parse(trechos[1]);
            this.QuantidadeLicencas = int.Parse(trechos[2]);

            string[] trechosData = trechos[3].Split(new char[] { '/' });
            this.DataExpiracao = new DateTime(
                int.Parse(trechosData[2]),
                int.Parse(trechosData[1]),
                int.Parse(trechosData[0]));
        }
    }


    internal class WinThorIni
    {
        private string NomeArquivo { get; set; }

        public WinThorIni(string nomeArquivoIni)
        {
            this.NomeArquivo = nomeArquivoIni;
        }

        public LicencaUso ObterLicencaUso(string nomeLoja, string nomeEmpresa)
        {
            string chaveCriptografada;
            string senhaBDCripto;
            if (ObterLinhaEmpresa(nomeLoja, nomeEmpresa, out chaveCriptografada, out senhaBDCripto))
                return new LicencaUso(nomeLoja, nomeEmpresa, chaveCriptografada, senhaBDCripto);
            else
                return null;
        }

        public ListaLojasDTO ObterLojasEmpresas()
        {
            ListaLojasDTO retorno = new ListaLojasDTO();

            using (StreamReader leitorWinThorIni = new StreamReader(NomeArquivo))
            {
                string linhaIni = "";
                string nomeLoja;
                LojasWinThorIni lojaAtual = null;
                int posSustenido;

                // podem existir vários blocos de loja e empresa para mesma loja
                while (linhaIni != null)
                {
                    while ((linhaIni = leitorWinThorIni.ReadLine()) != null)
                    {
                        if (linhaIni.Trim().StartsWith("="))
                        {
                            nomeLoja = linhaIni.Substring(1).ToUpper();

                            if (lojaAtual != null) lojaAtual.Empresas.Sort();

                            // as lojas não estão ordenadas e se repetem
                            lojaAtual = retorno.ObterLoja(nomeLoja);
                            if (lojaAtual == null)
                            {
                                lojaAtual = new LojasWinThorIni(nomeLoja);
                                retorno.Add(lojaAtual);
                            }
                        }
                        else
                            if (linhaIni.Trim().StartsWith("+"))
                            {
                                if (lojaAtual != null)
                                {
                                    posSustenido = linhaIni.IndexOf('#');
                                    string nomeEmpresa = linhaIni.Substring(1, posSustenido - 1);

                                    if (!lojaAtual.Empresas.Contains(nomeEmpresa))
                                        lojaAtual.Empresas.Add(nomeEmpresa);
                                }
                            }

                    }
                }

                if (lojaAtual != null) lojaAtual.Empresas.Sort();

                retorno.Ordenar();
                return retorno;
            }
        }


        #region Código antigo
        /*
        public List<string> ObterNomeLojas()
        {
            List<string> lojas = new List<string>();

            using (StreamReader leitorWinThorIni = new StreamReader(this.NomeArquivo))
            {
                string linhaIni;
                string novaLoja;
                while ((linhaIni = leitorWinThorIni.ReadLine()) != null)
                {
                    if (linhaIni.Trim().StartsWith("="))
                    {
                        novaLoja = linhaIni.Substring(1);
                        if (!lojas.Contains(novaLoja))
                        {
                            lojas.Add(novaLoja);
                        }
                    }
                }
            }

            lojas.Sort();
            return lojas;
        }

        public List<string> ObterNomeEmpresas(string nomeLoja)
        {
            List<string> empresas = new List<string>();

            using (StreamReader leitorWinThorIni = new StreamReader(this.NomeArquivo))
            {
                bool achouLoja = false;
                string linhaIni = "";

                // podem existir vários blocos de loja e empresa para mesma loja
                while (linhaIni != null)
                {
                    while ((linhaIni = leitorWinThorIni.ReadLine()) != null)
                    {
                        if (linhaIni.Trim().StartsWith("=") && linhaIni.Substring(1).ToUpper().Equals(nomeLoja))
                        {
                            achouLoja = true;
                            break;
                        }
                    }

                    if (achouLoja)
                    {
                        int posSustenido;
                        while ((linhaIni = leitorWinThorIni.ReadLine()) != null)
                        {
                            linhaIni = linhaIni.Trim();
                            if (linhaIni.StartsWith("="))
                                break;


                            if (linhaIni.StartsWith("+"))
                            {
                                posSustenido = linhaIni.IndexOf('#');
                                empresas.Add(linhaIni.Substring(1, posSustenido - 1));
                            }
                        }
                    }
                }

                empresas.Sort();
                return empresas;
            }
        }
        */
        #endregion

        private void QuebrarLinhaWinThorIni(string linhaWinThorIni,
            out string nomeUsuarioBD, out string chaveCriptografada, out string senhaBDCripto)
        {
            int posSustenido = linhaWinThorIni.IndexOf('#');
            int posArroba = linhaWinThorIni.LastIndexOf('@');

            if (posSustenido > 0 && posArroba > 0)
            {
                // 1234567890123456789
                // aa#bbbbbbbb@ccc
                // posSustenido = 3
                // posArroba = 12
                // tam b = 8
                nomeUsuarioBD = linhaWinThorIni.Substring(1, posSustenido - 1);
                chaveCriptografada = linhaWinThorIni.Substring(posSustenido + 1, posArroba - posSustenido - 1);
                senhaBDCripto = linhaWinThorIni.Substring(posArroba + 1);
            }
            else
            {
                nomeUsuarioBD = "";
                chaveCriptografada = "";
                senhaBDCripto = "";
            }
        }

        private bool ObterLinhaEmpresa(string nomeLoja, string nomeEmpresa,
            out string chaveCriptografada, out string senhaBDCripto)
        {
            using (StreamReader leitorWinThorIni = new StreamReader(this.NomeArquivo))
            {
                string linhaIni = "";
                string nomeLojaAtual = "";

                // podem existir vários blocos de loja e empresa para mesma loja
                while ((linhaIni = leitorWinThorIni.ReadLine()) != null)
                {
                    linhaIni = linhaIni.Trim();

                    if (linhaIni.StartsWith("=") &&
                        linhaIni.Substring(1).ToUpper().Equals(nomeLoja))
                    {
                        nomeLojaAtual = linhaIni.Substring(1).ToUpper();
                    }
                    else
                        if (linhaIni.StartsWith("+"))
                        {
                            string nomeUsuarioBD;
                            QuebrarLinhaWinThorIni(linhaIni, out nomeUsuarioBD, out chaveCriptografada, out senhaBDCripto);

                            if (nomeUsuarioBD.Equals(nomeEmpresa) && nomeLojaAtual.Equals(nomeLoja))
                            {
                                return true;
                            }
                        }
                }

                // não encontrou a empresa no WinThor.ini:
                chaveCriptografada = "";
                senhaBDCripto = "";

                return false;
            }
        }

    }    
}

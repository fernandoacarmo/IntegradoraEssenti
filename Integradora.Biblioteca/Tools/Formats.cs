﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Tools
{
    public class Formats
    {
        public static string Cortar(string texto, int tamanho)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return "";
            }
            else
            {
                tamanho = texto.Length > tamanho ? tamanho : texto.Length;
                texto = texto.Substring(0, tamanho);
                return texto;
            }
        }

        public static string Telefone(string numero)
        {
            string Tratado = "";
            //string fomato = "00-000-0000"
            if (!String.IsNullOrEmpty(numero))
            {
                Tratado = Numbers.OnlyNumbers(numero);
                //Tratado.
            }

            return Tratado;
        }

        public static string FormatoWinthor(string texto)
        {
            string retorno = texto;

            retorno = RemoveCaracteresEspeciais(retorno, true, true);

            if (!string.IsNullOrEmpty(retorno))
            {
                retorno = retorno.ToUpper();
            }

            return retorno;

        }
        public static string RemoveCaracteresEspeciais(string texto, bool aceitaEspaco, bool substituiAcentos)
        {
            string ret = texto;

            if (string.IsNullOrEmpty(ret))
                return ret;

            if (substituiAcentos)
                ret = RemoveAcentos(ret);

            if (aceitaEspaco)
                ret = System.Text.RegularExpressions.Regex.Replace(ret, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ\s]+?", string.Empty);
            else
                ret = System.Text.RegularExpressions.Regex.Replace(ret, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ]+?", string.Empty);

            return ret;
        }

        public static string RemoverCaracteres(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                char[] CARACTERES_PROIBIDOS = new char[] { '.', '!', '@', '#', '$', '%', '/', '+', '*', '?' };
                return string.Concat(texto.Split(CARACTERES_PROIBIDOS, StringSplitOptions.RemoveEmptyEntries));
            }
            return string.Empty;
        }

        public static string DecricaoToURL(string text)
        {
            string url = "";
            if (!string.IsNullOrEmpty(text))
            { 
                url = text.Replace(" ", "-");
                url = url.ToLower();
            }
            return url;
        }
        public static string RemoveAcentos(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] <= 256)
                {
                    sb.Append(s_Accents[text[i]]);
                }
            }

            return sb.ToString();
        }

        private static readonly char[] s_Accents = GetAccents();
        private static char[] GetAccents()
        {
            char[] accents = new char[256];

            for (int i = 0; i < 256; i++)
                accents[i] = (char)i;

            accents[(byte)'á'] = accents[(byte)'à'] = accents[(byte)'ã'] = accents[(byte)'â'] = accents[(byte)'ä'] = 'a';
            accents[(byte)'Á'] = accents[(byte)'À'] = accents[(byte)'Ã'] = accents[(byte)'Â'] = accents[(byte)'Ä'] = 'A';

            accents[(byte)'é'] = accents[(byte)'è'] = accents[(byte)'ê'] = accents[(byte)'ë'] = 'e';
            accents[(byte)'É'] = accents[(byte)'È'] = accents[(byte)'Ê'] = accents[(byte)'Ë'] = 'E';

            accents[(byte)'í'] = accents[(byte)'ì'] = accents[(byte)'î'] = accents[(byte)'ï'] = 'i';
            accents[(byte)'Í'] = accents[(byte)'Ì'] = accents[(byte)'Î'] = accents[(byte)'Ï'] = 'I';

            accents[(byte)'ó'] = accents[(byte)'ò'] = accents[(byte)'ô'] = accents[(byte)'õ'] = accents[(byte)'ö'] = 'o';
            accents[(byte)'Ó'] = accents[(byte)'Ò'] = accents[(byte)'Ô'] = accents[(byte)'Õ'] = accents[(byte)'Ö'] = 'O';

            accents[(byte)'ú'] = accents[(byte)'ù'] = accents[(byte)'û'] = accents[(byte)'ü'] = 'u';
            accents[(byte)'Ú'] = accents[(byte)'Ù'] = accents[(byte)'Û'] = accents[(byte)'Ü'] = 'U';

            //            accents[(byte)'ĺ'] = 'l';

            accents[(byte)'ç'] = 'c';
            accents[(byte)'Ç'] = 'C';

            accents[(byte)'ñ'] = 'n';
            accents[(byte)'Ñ'] = 'N';

            accents[(byte)'ÿ'] = accents[(byte)'ý'] = 'y';
            accents[(byte)'Ý'] = 'Y';

            return accents;
        }

    }
}

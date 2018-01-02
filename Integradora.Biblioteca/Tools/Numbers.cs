using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Tools
{
    public class Numbers
    {
        public static string OnlyNumbers(string value)
        {
            string resultString = string.Empty;
            if (!string.IsNullOrEmpty(value))
            {
                Regex regexObj = new Regex(@"[^\d]");
                resultString = regexObj.Replace(value, "");
            }
            return resultString;
        }

        public static string OnlyNumbers(string value, string valuedefault)
        {
            string resultString =  OnlyNumbers(value);
            if (string.IsNullOrEmpty(resultString))
            {
                resultString = valuedefault;
            }

            return resultString;
        }
        public static long ToInt64(string value)
        {
            return Convert.ToInt64("0" + OnlyNumbers(value));
        }

        public static Int32 ToInt32(string value)
        {
            return Convert.ToInt32("0" + OnlyNumbers(value));
        }

        public static Int16 ToInt16(string value)
        {
            return Convert.ToInt16("0" + OnlyNumbers(value));
        }
    }
}

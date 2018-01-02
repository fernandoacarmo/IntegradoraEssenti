using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Tools
{
    public class Calendars
    {
        public static DateTime? ToDateTime(string value)
        {
            DateTime? resultString = default(DateTime?);
            if (value != string.Empty)
            {
                resultString = Convert.ToDateTime(value);
            }
            return resultString;
        }

        public static DateTime ToDateTime(DateTime? value)
        {
            string Data;
            if (value == null)
            {
                Data = default(DateTime?).ToString();
            }
            else
            {
                Data = value.ToString();
            }

            return Convert.ToDateTime(Data);
        }

        public static string GetMascaraDataHoraXML()
        { 
            return "yyyy-MM-ddTHH:mm:ss";
        }
        public static string GetMascaraDataXML()
        {
            return "yyyy-MM-dd";
        }
        public static int GetDiffDays(DateTime? initialDate, DateTime? finalDate, bool diasUteis)
        {
            return GetDiffDays(ToDateTime(initialDate), ToDateTime(initialDate), diasUteis);
        }

        public static int GetDiffDays(DateTime initialDate, DateTime finalDate, bool diasUteis)
        {
            int days = 0;
            int daysCount = 0;
            days = initialDate.Subtract(finalDate).Days;

            if (diasUteis)
            {
                //Módulo 
                if (days < 0)
                    days = days * -1;

                for (int i = 1; i <= days; i++)
                {
                    initialDate = initialDate.AddDays(1);
                    //Conta apenas dias da semana.
                    if (initialDate.DayOfWeek != DayOfWeek.Sunday &&
                        initialDate.DayOfWeek != DayOfWeek.Saturday)
                        daysCount++;
                }
            }
            else
            {
                daysCount = days;
            }
            return daysCount;
        }
    }
}

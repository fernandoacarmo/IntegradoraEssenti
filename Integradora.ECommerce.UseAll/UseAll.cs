using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.UseAll
{
    public class UseAll
    {
        public static string GetStringConnection()
        {
            return Integradora.Biblioteca.Dictionaries.Settings.UseAll_Conexao();
        }

        public bool ClienteExiste(long consumidor)
        {
            bool resultado = false;
            try
            {
                if (consumidor > 0)
                {
                    Persistencia ba = new Persistencia(GetStringConnection());
                    resultado = ba.Contar("CONSUMIDOR", "IDCONSUMIDOR = '" + consumidor.ToString() + "'") > 0;
                }
            }
            catch (Exception erro)
            {
                resultado = false;
                Logs.GerarLog("Integradora.ECommerce.UseAll", "ClienteExiste", erro);
            }
            return resultado;
        }
    }
}

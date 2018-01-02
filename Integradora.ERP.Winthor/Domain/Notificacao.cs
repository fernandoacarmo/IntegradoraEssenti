using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ERP.Winthor.Domain
{
    public class Notificacao
    {
        public Notificacao()
        {

        }
        public static List<Correspondencias> Load()
        {
            List<Correspondencias> Lista;
            try
            {
                string Quantidade;
                Quantidade = Integradora.Biblioteca.Dictionaries.Settings.QuantidadeRegistroEnviar().ToString();
                Lista = Correspondencias.Listar("DTENVIO IS NULL AND ROWNUM <= " + Quantidade);
            }
            catch
            {
                Lista = null;
            }
            return Lista;
        }

        public static void Remove(Correspondencias value)
        {
            Persistencia ba = new Persistencia(Correspondencias.GetStringConnection());

            value.Dtenvio = value.DataHoraServidor();
 
            ba.Alterar(value);
        }


    }
}

using Integradora.Database.Oracle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Corpem.Inherited
{
    public class OracleObjeto : Integradora.Biblioteca.Interfaces.IEntity
    {
        public static string GetStringConnection()
        {
            return Integradora.Biblioteca.Dictionaries.Settings.Corpem_Conexao();
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

    }
}

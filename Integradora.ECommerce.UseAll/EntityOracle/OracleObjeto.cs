using Integradora.Database.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.UseAll.EntityOracle
{
    public abstract class OracleObjeto : Integradora.Biblioteca.Interfaces.IEntity
    {
        public static string GetStringConnection()
        {
            return Integradora.Biblioteca.Dictionaries.Settings.UseAll_Conexao();
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
        public abstract string GetTableName();

        /// <summary>
        /// Propriedade referente ao campo: OID
        /// Comentário: ROWID do Oracle, mas por motivos do mesmo não vir no select, deve ser utilizado um apelido
        /// </summary>
//        private string oid;
//        [XmlElement(ElementName = "OID", DataType = "VARCHAR2", IsNullable = false)]
//        [DataObjectField(false, false, true, 40)]
//        public string OID
//        {
//            get { return oid; }
//            set { oid = value; }
//        }
    }
}

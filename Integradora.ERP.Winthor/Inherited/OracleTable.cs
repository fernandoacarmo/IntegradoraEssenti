using Integradora.Database.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.Inherited
{
    public abstract class OracleTable : OracleObjeto
    {
        public OracleTable()
        {
        }

        public object Clone()
        {
            var clone = this.MemberwiseClone();
            return clone;
        }
        public abstract string GetTableName();

        /// <summary>
        /// Propriedade referente ao campo: OID
        /// Comentário: ROWID do Oracle, mas por motivos do mesmo não vir no select, deve ser utilizado um apelido
        /// </summary>
        private string oid;
        [XmlElement(ElementName = "OID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, true, 40)]
        public string OID
        {
            get { return oid; }
            set { oid = value; }
        }

        public bool Gravar()
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            bool resultado = true;
            try
            {
                if (string.IsNullOrEmpty(OID))
                {
                    ba.Inserir(this);
                }
                else
                {
                    ba.Alterar(this);
                }
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }

        public bool Excluir()
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            bool resultado = true;
            try
            {
                if (string.IsNullOrEmpty(OID))
                {
                    resultado = false;
                }
                else
                {
                    ba.Excluir(this);
                }
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }
        public bool ExecutarComando(string sqlCommando)
        {
            bool resultado = false;
            try
            {
                Persistencia ba = new Persistencia(GetStringConnection());
                resultado = ba.Executar(sqlCommando);
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }
    }
}

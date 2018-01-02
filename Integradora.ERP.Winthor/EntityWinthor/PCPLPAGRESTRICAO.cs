using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityWinthor
{
    /// <summary>
    /// Classe referente a tabela PCPlpagrestricao
    /// </summary>
    [XmlType("PCPLPAGRESTRICAO")]
    public class PCPlpagrestricao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: C�digo do plano de pagamento
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRESTRICAO
        /// Coment�rio: C�digo da restri��o
        /// </summary>
        private decimal codrestricao;
        [XmlElement(ElementName = "CODRESTRICAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codrestricao
        {
            get { return  codrestricao; }
            set {  codrestricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORESTRICAO
        /// Coment�rio: Tipo da restri��o do plano de pagamento
        /// </summary>
        private string tiporestricao;
        [XmlElement(ElementName = "TIPORESTRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Tiporestricao
        {
            get { return  tiporestricao; }
            set {  tiporestricao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPlpagrestricao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPLPAGRESTRICAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPlpagrestricao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPlpagrestricao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPlpagrestricao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPlpagrestricao>(where);
        }

        #endregion
    }
}

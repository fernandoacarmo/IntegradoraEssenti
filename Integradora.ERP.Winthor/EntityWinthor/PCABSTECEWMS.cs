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
    /// Classe referente a tabela PCAbstecewms
    /// </summary>
    [XmlType("PCABSTECEWMS")]
    public class PCAbstecewms : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECOAP
        /// Coment�rio: 
        /// </summary>
        private decimal codenderecoap;
        [XmlElement(ElementName = "CODENDERECOAP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codenderecoap
        {
            get { return  codenderecoap; }
            set {  codenderecoap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECOCX
        /// Coment�rio: 
        /// </summary>
        private decimal codenderecocx;
        [XmlElement(ElementName = "CODENDERECOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codenderecocx
        {
            get { return  codenderecocx; }
            set {  codenderecocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSWMS
        /// Coment�rio: 
        /// </summary>
        private decimal numtranswms;
        [XmlElement(ElementName = "NUMTRANSWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numtranswms
        {
            get { return  numtranswms; }
            set {  numtranswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEM
        /// Coment�rio: 
        /// </summary>
        private string origem;
        [XmlElement(ElementName = "ORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Origem
        {
            get { return  origem; }
            set {  origem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEM
        /// Coment�rio: 
        /// </summary>
        private string tipoembalagem;
        [XmlElement(ElementName = "TIPOEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoembalagem
        {
            get { return  tipoembalagem; }
            set {  tipoembalagem = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAbstecewms()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCABSTECEWMS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAbstecewms> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAbstecewms>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAbstecewms> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAbstecewms>(where);
        }

        #endregion
    }
}

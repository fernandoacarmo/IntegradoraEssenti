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
    /// Classe referente a tabela PCComplemento
    /// </summary>
    [XmlType("PCCOMPLEMENTO")]
    public class PCComplemento : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO1
        /// Comentário: 
        /// </summary>
        private string complemento1;
        [XmlElement(ElementName = "COMPLEMENTO1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Complemento1
        {
            get { return  complemento1; }
            set {  complemento1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO2
        /// Comentário: 
        /// </summary>
        private string complemento2;
        [XmlElement(ElementName = "COMPLEMENTO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Complemento2
        {
            get { return  complemento2; }
            set {  complemento2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO3
        /// Comentário: 
        /// </summary>
        private string complemento3;
        [XmlElement(ElementName = "COMPLEMENTO3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Complemento3
        {
            get { return  complemento3; }
            set {  complemento3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMETABELA
        /// Comentário: 
        /// </summary>
        private string nometabela;
        [XmlElement(ElementName = "NOMETABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Nometabela
        {
            get { return  nometabela; }
            set {  nometabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Indica o número do pedido de venda.
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Comentário: 
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCComplemento()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMPLEMENTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCComplemento> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComplemento>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCComplemento> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComplemento>(where);
        }

        #endregion
    }
}

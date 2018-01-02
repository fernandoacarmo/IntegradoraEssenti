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
    /// Classe referente a tabela PCMovsaid
    /// </summary>
    [XmlType("PCMOVSAID")]
    public class PCMovsaid : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�d.Filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�d.Produto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data.
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
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Coment�rio: Num.Trans.Entrada.
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: Num.Trans.Saida.
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCONT
        /// Coment�rio: Qt.sa�da.
        /// </summary>
        private decimal qtcont;
        [XmlElement(ElementName = "QTCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtcont
        {
            get { return  qtcont; }
            set {  qtcont = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMovsaid()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVSAID";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMovsaid> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovsaid>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMovsaid> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovsaid>(where);
        }

        #endregion
    }
}

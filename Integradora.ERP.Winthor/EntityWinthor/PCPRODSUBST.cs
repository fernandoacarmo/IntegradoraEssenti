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
    /// Classe referente a tabela PCProdsubst
    /// </summary>
    [XmlType("PCPRODSUBST")]
    public class PCProdsubst : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCSUBST
        /// Comentário: Indica o código do funcionário da substituição.
        /// </summary>
        private decimal codfuncsubst;
        [XmlElement(ElementName = "CODFUNCSUBST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncsubst
        {
            get { return  codfuncsubst; }
            set {  codfuncsubst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODSIMIL
        /// Comentário: Indica o código do produto similar.
        /// </summary>
        private decimal codprodsimil;
        [XmlElement(ElementName = "CODPRODSIMIL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprodsimil
        {
            get { return  codprodsimil; }
            set {  codprodsimil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODSUBST
        /// Comentário: Indica o código do produto substituído.
        /// </summary>
        private decimal codprodsubst;
        [XmlElement(ElementName = "CODPRODSUBST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprodsubst
        {
            get { return  codprodsubst; }
            set {  codprodsubst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATASUBST
        /// Comentário: Indica a data da substituição.
        /// </summary>
        private DateTime? datasubst;
        [XmlElement(ElementName = "DATASUBST", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datasubst
        {
            get { return  datasubst; }
            set {  datasubst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDSUBST
        /// Comentário: Indica o número do pedido com produto substituído.
        /// </summary>
        private decimal numpedsubst;
        [XmlElement(ElementName = "NUMPEDSUBST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedsubst
        {
            get { return  numpedsubst; }
            set {  numpedsubst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: Indica o sequencial do produto substituído.
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELASIMILAR
        /// Comentário: Indica o preço de tabela do produto similar.
        /// </summary>
        private decimal ptabelasimilar;
        [XmlElement(ElementName = "PTABELASIMILAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelasimilar
        {
            get { return  ptabelasimilar; }
            set {  ptabelasimilar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELASUBST
        /// Comentário: Indica o preço de tabela produto substituído.
        /// </summary>
        private decimal ptabelasubst;
        [XmlElement(ElementName = "PTABELASUBST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelasubst
        {
            get { return  ptabelasubst; }
            set {  ptabelasubst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSIMILAR
        /// Comentário: Quantidade do similar.
        /// </summary>
        private decimal qtsimilar;
        [XmlElement(ElementName = "QTSIMILAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtsimilar
        {
            get { return  qtsimilar; }
            set {  qtsimilar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSUBST
        /// Comentário: Quantidade da substituição.
        /// </summary>
        private decimal qtsubst;
        [XmlElement(ElementName = "QTSUBST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtsubst
        {
            get { return  qtsubst; }
            set {  qtsubst = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCProdsubst()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODSUBST";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCProdsubst> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdsubst>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCProdsubst> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdsubst>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCContratoi
    /// </summary>
    [XmlType("PCCONTRATOI")]
    public class PCContratoi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTRATO
        /// Coment�rio: 
        /// </summary>
        private decimal codcontrato;
        [XmlElement(ElementName = "CODCONTRATO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcontrato
        {
            get { return  codcontrato; }
            set {  codcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODPRODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codprodcli;
        [XmlElement(ElementName = "CODPRODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codprodcli
        {
            get { return  codprodcli; }
            set {  codprodcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOENTREGA
        /// Coment�rio: 
        /// </summary>
        private decimal prazoentrega;
        [XmlElement(ElementName = "PRAZOENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Prazoentrega
        {
            get { return  prazoentrega; }
            set {  prazoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODDESCRICAO
        /// Coment�rio: Indica a descri��o do produto no contrato.
        /// </summary>
        private string proddescricao;
        [XmlElement(ElementName = "PRODDESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Proddescricao
        {
            get { return  proddescricao; }
            set {  proddescricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODDESCRICAODANFE
        /// Coment�rio: Descri��o produto Danfe
        /// </summary>
        private string proddescricaodanfe;
        [XmlElement(ElementName = "PRODDESCRICAODANFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Proddescricaodanfe
        {
            get { return  proddescricaodanfe; }
            set {  proddescricaodanfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Coment�rio: 
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEMINIMA
        /// Coment�rio: Qtde m�nima para venda do produto
        /// </summary>
        private decimal qtdeminima;
        [XmlElement(ElementName = "QTDEMINIMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtdeminima
        {
            get { return  qtdeminima; }
            set {  qtdeminima = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIN
        /// Coment�rio: 
        /// </summary>
        private decimal qtmin;
        [XmlElement(ElementName = "QTMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtmin
        {
            get { return  qtmin; }
            set {  qtmin = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCContratoi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTRATOI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCContratoi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContratoi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCContratoi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContratoi>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCBeneficorigem
    /// </summary>
    [XmlType("PCBENEFICORIGEM")]
    public class PCBeneficorigem : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BASEICST
        /// Coment�rio: Cont�m o valor da base do ST informado para o produto de origem. 
        /// </summary>
        private decimal baseicst;
        [XmlElement(ElementName = "BASEICST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Baseicst
        {
            get { return  baseicst; }
            set {  baseicst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Coment�rio: Indica o c�digo fiscal. 
        /// </summary>
        private decimal codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
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
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICM
        /// Coment�rio: Cont�m o valor do percentual de ICMS informado para o produto de origem. 
        /// </summary>
        private decimal percicm;
        [XmlElement(ElementName = "PERCICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percicm
        {
            get { return  percicm; }
            set {  percicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPI
        /// Coment�rio: Cont�m o valor do percentual de IPI informado para o produto de origem. 
        /// </summary>
        private decimal percipi;
        [XmlElement(ElementName = "PERCIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percipi
        {
            get { return  percipi; }
            set {  percipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNIT
        /// Coment�rio: 
        /// </summary>
        private decimal punit;
        [XmlElement(ElementName = "PUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Punit
        {
            get { return  punit; }
            set {  punit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTREGUE
        /// Coment�rio: 
        /// </summary>
        private decimal qtentregue;
        [XmlElement(ElementName = "QTENTREGUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtentregue
        {
            get { return  qtentregue; }
            set {  qtentregue = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDA
        /// Coment�rio: Quantidade perda de insumos. 
        /// </summary>
        private decimal qtperda;
        [XmlElement(ElementName = "QTPERDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtperda
        {
            get { return  qtperda; }
            set {  qtperda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Coment�rio: Cont�m a situa��o tribut�ria informada para o produto de origem. 
        /// </summary>
        private string sittribut;
        [XmlElement(ElementName = "SITTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittribut
        {
            get { return  sittribut; }
            set {  sittribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ST
        /// Coment�rio: Cont�m o valor do ST informado para o produto de origem. 
        /// </summary>
        private decimal st;
        [XmlElement(ElementName = "ST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal St
        {
            get { return  st; }
            set {  st = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBeneficorigem()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBENEFICORIGEM";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBeneficorigem> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBeneficorigem>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBeneficorigem> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBeneficorigem>(where);
        }

        #endregion
    }
}

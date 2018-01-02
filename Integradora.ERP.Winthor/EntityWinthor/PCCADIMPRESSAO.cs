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
    /// Classe referente a tabela PCCadimpressao
    /// </summary>
    [XmlType("PCCADIMPRESSAO")]
    public class PCCadimpressao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: C�D. EMBALAGEM
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Coment�rio: C�D. CATEGORIA
        /// </summary>
        private decimal codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcategoria
        {
            get { return  codcategoria; }
            set {  codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEPTO
        /// Coment�rio: C�D. DO DEPARTAMENTO
        /// </summary>
        private decimal coddepto;
        [XmlElement(ElementName = "CODDEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Coddepto
        {
            get { return  coddepto; }
            set {  coddepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�D. DA FILIAL
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINATIVACAO
        /// Coment�rio: C�D. FUNC. INATIVA��O
        /// </summary>
        private decimal codfuncinativacao;
        [XmlElement(ElementName = "CODFUNCINATIVACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncinativacao
        {
            get { return  codfuncinativacao; }
            set {  codfuncinativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIMP
        /// Coment�rio: C�D. CADASTRO DE IMPRESSAO
        /// </summary>
        private decimal codimp;
        [XmlElement(ElementName = "CODIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codimp
        {
            get { return  codimp; }
            set {  codimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�D. PRODUTO
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Coment�rio: C�D. SE��O
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBCATEGORIA
        /// Coment�rio: C�D. SUBCATEGORIA
        /// </summary>
        private decimal codsubcategoria;
        [XmlElement(ElementName = "CODSUBCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsubcategoria
        {
            get { return  codsubcategoria; }
            set {  codsubcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINATIVACAO
        /// Coment�rio: DATA INATIVA��O
        /// </summary>
        private DateTime? dtinativacao;
        [XmlElement(ElementName = "DTINATIVACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinativacao
        {
            get { return  dtinativacao; }
            set {  dtinativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRESSORA
        /// Coment�rio: DESCRI��O IMPRESSORA
        /// </summary>
        private string impressora;
        [XmlElement(ElementName = "IMPRESSORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Impressora
        {
            get { return  impressora; }
            set {  impressora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOINATIVACAO
        /// Coment�rio: MOTIVO INATIVA��O
        /// </summary>
        private string motivoinativacao;
        [XmlElement(ElementName = "MOTIVOINATIVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,90)]
        public string Motivoinativacao
        {
            get { return  motivoinativacao; }
            set {  motivoinativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: STATUS IMPRESS�O
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCadimpressao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCADIMPRESSAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCadimpressao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCadimpressao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCadimpressao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCadimpressao>(where);
        }

        #endregion
    }
}

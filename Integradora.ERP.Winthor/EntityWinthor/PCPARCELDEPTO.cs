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
    /// Classe referente a tabela PCParceldepto
    /// </summary>
    [XmlType("PCPARCELDEPTO")]
    public class PCParceldepto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Coment�rio: C�digo da Categoria
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
        /// Coment�rio: C�digo do Departamento
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
        /// Coment�rio: C�digo da Filial
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
        /// Coment�rio: C�digo do Funcion�rio Respons�vel pela Inativa��o
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
        /// Propriedade referente ao campo: CODPARCEL
        /// Coment�rio: Sequ�ncial do registro
        /// </summary>
        private decimal codparcel;
        [XmlElement(ElementName = "CODPARCEL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codparcel
        {
            get { return  codparcel; }
            set {  codparcel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto
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
        /// Coment�rio: C�digo da Se��o
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
        /// Coment�rio: C�digo da Subcategoria
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
        /// Propriedade referente ao campo: DIAFIXO
        /// Coment�rio: Dia Fixo
        /// </summary>
        private decimal diafixo;
        [XmlElement(ElementName = "DIAFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diafixo
        {
            get { return  diafixo; }
            set {  diafixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINATIVACAO
        /// Coment�rio: Data de Inativa��o
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
        /// Propriedade referente ao campo: MOTIVOINATIVACAO
        /// Coment�rio: Motivo da Inativa��o
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
        /// Propriedade referente ao campo: PERTXFIN
        /// Coment�rio: Valor de acr�scimo/ desconto
        /// </summary>
        private decimal pertxfin;
        [XmlElement(ElementName = "PERTXFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pertxfin
        {
            get { return  pertxfin; }
            set {  pertxfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXPARCELA
        /// Coment�rio: Quantidade M�xima de Parcelas
        /// </summary>
        private decimal qtmaxparcela;
        [XmlElement(ElementName = "QTMAXPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtmaxparcela
        {
            get { return  qtmaxparcela; }
            set {  qtmaxparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: Status(A / I)
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
        /// Propriedade referente ao campo: TXJUROS
        /// Coment�rio: Valor da taxa de juros
        /// </summary>
        private decimal txjuros;
        [XmlElement(ElementName = "TXJUROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Txjuros
        {
            get { return  txjuros; }
            set {  txjuros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADIAFIXO
        /// Coment�rio: Usar Dia Fixo (S / N)
        /// </summary>
        private string usadiafixo;
        [XmlElement(ElementName = "USADIAFIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadiafixo
        {
            get { return  usadiafixo; }
            set {  usadiafixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENCIMENTO
        /// Coment�rio: Quantidade de Dias para vencimento
        /// </summary>
        private decimal vencimento;
        [XmlElement(ElementName = "VENCIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Vencimento
        {
            get { return  vencimento; }
            set {  vencimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINPARCELA
        /// Coment�rio: Valor m�nimo da parcela 
        /// </summary>
        private decimal vlminparcela;
        [XmlElement(ElementName = "VLMINPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Vlminparcela
        {
            get { return  vlminparcela; }
            set {  vlminparcela = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCParceldepto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARCELDEPTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCParceldepto> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParceldepto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCParceldepto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParceldepto>(where);
        }

        #endregion
    }
}

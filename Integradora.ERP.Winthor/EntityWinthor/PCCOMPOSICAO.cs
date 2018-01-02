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
    /// Classe referente a tabela PCComposicao
    /// </summary>
    [XmlType("PCCOMPOSICAO")]
    public class PCComposicao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITAREQACIMAPREV
        /// Coment�rio: 
        /// </summary>
        private string aceitareqacimaprev;
        [XmlElement(ElementName = "ACEITAREQACIMAPREV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitareqacimaprev
        {
            get { return  aceitareqacimaprev; }
            set {  aceitareqacimaprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNCALTER
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncalter;
        [XmlElement(ElementName = "CODFUNCALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncalter
        {
            get { return  codfuncalter; }
            set {  codfuncalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCADASTRO
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccadastro;
        [XmlElement(ElementName = "CODFUNCCADASTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccadastro
        {
            get { return  codfunccadastro; }
            set {  codfunccadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncultalter;
        [XmlElement(ElementName = "CODFUNCULTALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalter
        {
            get { return  codfuncultalter; }
            set {  codfuncultalter = value; }
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
        /// Propriedade referente ao campo: CODPRODMASTER
        /// Coment�rio: 
        /// </summary>
        private decimal codprodmaster;
        [XmlElement(ElementName = "CODPRODMASTER", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprodmaster
        {
            get { return  codprodmaster; }
            set {  codprodmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTER
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultalter;
        [XmlElement(ElementName = "DTULTALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalter
        {
            get { return  dtultalter; }
            set {  dtultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRACAOSEPARACAO
        /// Coment�rio: 
        /// </summary>
        private decimal fracaoseparacao;
        [XmlElement(ElementName = "FRACAOSEPARACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Fracaoseparacao
        {
            get { return  fracaoseparacao; }
            set {  fracaoseparacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRACAOUMIDA
        /// Coment�rio: 
        /// </summary>
        private string fracaoumida;
        [XmlElement(ElementName = "FRACAOUMIDA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public string Fracaoumida
        {
            get { return  fracaoumida; }
            set {  fracaoumida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOTEPRODUCAOMASTER
        /// Coment�rio: 
        /// </summary>
        private decimal loteproducaomaster;
        [XmlElement(ElementName = "LOTEPRODUCAOMASTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Loteproducaomaster
        {
            get { return  loteproducaomaster; }
            set {  loteproducaomaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METODO
        /// Coment�rio: 
        /// </summary>
        private string metodo;
        [XmlElement(ElementName = "METODO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public string Metodo
        {
            get { return  metodo; }
            set {  metodo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDECIMAIS
        /// Coment�rio: Indica n�mero de casas decimais usado na Ordem de Produ��o (rotinas 1615, 1616). 
        /// </summary>
        private decimal numdecimais;
        [XmlElement(ElementName = "NUMDECIMAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Numdecimais
        {
            get { return  numdecimais; }
            set {  numdecimais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDECIMAL
        /// Coment�rio: Indica n�mero de casas decimais usado na Ordem de Produ��o (rotinas 1615, 1616). 
        /// </summary>
        private decimal numdecimal;
        [XmlElement(ElementName = "NUMDECIMAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Numdecimal
        {
            get { return  numdecimal; }
            set {  numdecimal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMETAPA
        /// Coment�rio: 
        /// </summary>
        private decimal numetapa;
        [XmlElement(ElementName = "NUMETAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numetapa
        {
            get { return  numetapa; }
            set {  numetapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFORMULACAOTOTAL
        /// Coment�rio: Indica o percentual da formula��o.
        /// </summary>
        private decimal percformulacaototal;
        [XmlElement(ElementName = "PERCFORMULACAOTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percformulacaototal
        {
            get { return  percformulacaototal; }
            set {  percformulacaototal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPERDA
        /// Coment�rio: 
        /// </summary>
        private decimal percperda;
        [XmlElement(ElementName = "PERCPERDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percperda
        {
            get { return  percperda; }
            set {  percperda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNESTRUTURA
        /// Coment�rio: 
        /// </summary>
        private string unestrutura;
        [XmlElement(ElementName = "UNESTRUTURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Unestrutura
        {
            get { return  unestrutura; }
            set {  unestrutura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDADE
        /// Coment�rio: 
        /// </summary>
        private decimal validade;
        [XmlElement(ElementName = "VALIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Validade
        {
            get { return  validade; }
            set {  validade = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCComposicao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMPOSICAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCComposicao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComposicao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCComposicao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComposicao>(where);
        }

        #endregion
    }
}

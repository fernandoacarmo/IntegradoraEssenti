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
    /// Classe referente a tabela PCMovlojaitem
    /// </summary>
    [XmlType("PCMOVLOJAITEM")]
    public class PCMovlojaitem : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CANCELADO
        /// Coment�rio: Verificar se est� cancelado
        /// </summary>
        private string cancelado;
        [XmlElement(ElementName = "CANCELADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cancelado
        {
            get { return  cancelado; }
            set {  cancelado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: C�d. Auxiliar
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
        /// Propriedade referente ao campo: CODFUNCAD
        /// Coment�rio: C�digo do funcion�rio de cadastro
        /// </summary>
        private decimal codfuncad;
        [XmlElement(ElementName = "CODFUNCAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncad
        {
            get { return  codfuncad; }
            set {  codfuncad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONT1
        /// Coment�rio: C�digo do funcionario da primeira contagem
        /// </summary>
        private decimal codfunccont1;
        [XmlElement(ElementName = "CODFUNCCONT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccont1
        {
            get { return  codfunccont1; }
            set {  codfunccont1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONT2
        /// Coment�rio: C�digo do funcionario da segunda contagem
        /// </summary>
        private decimal codfunccont2;
        [XmlElement(ElementName = "CODFUNCCONT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccont2
        {
            get { return  codfunccont2; }
            set {  codfunccont2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONT3
        /// Coment�rio: C�digo do funcionario da terceira contagem
        /// </summary>
        private decimal codfunccont3;
        [XmlElement(ElementName = "CODFUNCCONT3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccont3
        {
            get { return  codfunccont3; }
            set {  codfunccont3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOVLOJA
        /// Coment�rio: C�digo sequencial
        /// </summary>
        private decimal codmovloja;
        [XmlElement(ElementName = "CODMOVLOJA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codmovloja
        {
            get { return  codmovloja; }
            set {  codmovloja = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto
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
        /// Propriedade referente ao campo: DATACONT1
        /// Coment�rio: Data da primeira contagem
        /// </summary>
        private DateTime? datacont1;
        [XmlElement(ElementName = "DATACONT1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacont1
        {
            get { return  datacont1; }
            set {  datacont1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONT2
        /// Coment�rio: Data da segunda contagem
        /// </summary>
        private DateTime? datacont2;
        [XmlElement(ElementName = "DATACONT2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacont2
        {
            get { return  datacont2; }
            set {  datacont2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONT3
        /// Coment�rio: Data da terceira contagem
        /// </summary>
        private DateTime? datacont3;
        [XmlElement(ElementName = "DATACONT3", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacont3
        {
            get { return  datacont3; }
            set {  datacont3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Data de cadastro
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
        /// Propriedade referente ao campo: MOTIVO
        /// Coment�rio: Motivo de altera��o da quantidade aplicada
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: N�mero sequ�ncia de inclus�o.
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: N�mero da venda.
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCANCEL
        /// Coment�rio: Quantidade Cancelada
        /// </summary>
        private decimal qtcancel;
        [XmlElement(ElementName = "QTCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtcancel
        {
            get { return  qtcancel; }
            set {  qtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFRENTELOJAANT
        /// Coment�rio: Quantidade anterior da loja antes da altera��o
        /// </summary>
        private decimal qtfrentelojaant;
        [XmlElement(ElementName = "QTFRENTELOJAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtfrentelojaant
        {
            get { return  qtfrentelojaant; }
            set {  qtfrentelojaant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFRENTELOJAATUAL
        /// Coment�rio: Quantidade atualizada da loja 
        /// </summary>
        private decimal qtfrentelojaatual;
        [XmlElement(ElementName = "QTFRENTELOJAATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtfrentelojaatual
        {
            get { return  qtfrentelojaatual; }
            set {  qtfrentelojaatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLANCAMENTO
        /// Coment�rio: Quantidade do lan�amento
        /// </summary>
        private decimal qtlancamento;
        [XmlElement(ElementName = "QTLANCAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtlancamento
        {
            get { return  qtlancamento; }
            set {  qtlancamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTREGISTRADA
        /// Coment�rio: Quantidade efetivada
        /// </summary>
        private decimal qtregistrada;
        [XmlElement(ElementName = "QTREGISTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtregistrada
        {
            get { return  qtregistrada; }
            set {  qtregistrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTREGISTRADA2
        /// Coment�rio: Quantidade registrada da segunda contagem
        /// </summary>
        private decimal qtregistrada2;
        [XmlElement(ElementName = "QTREGISTRADA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtregistrada2
        {
            get { return  qtregistrada2; }
            set {  qtregistrada2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTREGISTRADA3
        /// Coment�rio: Quantidade registrada da terceira contagem
        /// </summary>
        private decimal qtregistrada3;
        [XmlElement(ElementName = "QTREGISTRADA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtregistrada3
        {
            get { return  qtregistrada3; }
            set {  qtregistrada3 = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMovlojaitem()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVLOJAITEM";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMovlojaitem> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovlojaitem>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMovlojaitem> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovlojaitem>(where);
        }

        #endregion
    }
}

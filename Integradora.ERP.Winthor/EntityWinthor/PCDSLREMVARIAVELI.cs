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
    /// Classe referente a tabela PCDslremvariaveli
    /// </summary>
    [XmlType("PCDSLREMVARIAVELI")]
    public class PCDslremvariaveli : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CLIPOS
        /// Coment�rio: Realizado clientes positivados.
        /// </summary>
        private decimal clipos;
        [XmlElement(ElementName = "CLIPOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Clipos
        {
            get { return  clipos; }
            set {  clipos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIPOSPREV
        /// Coment�rio: Meta clientes positivados.
        /// </summary>
        private decimal cliposprev;
        [XmlElement(ElementName = "CLIPOSPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Cliposprev
        {
            get { return  cliposprev; }
            set {  cliposprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo do fornecedor.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHA
        /// Coment�rio: C�digo linha de produto.
        /// </summary>
        private decimal codlinha;
        [XmlElement(ElementName = "CODLINHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codlinha
        {
            get { return  codlinha; }
            set {  codlinha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto.
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
        /// Propriedade referente ao campo: CODRAMO
        /// Coment�rio: C�digo ramo de atividade.
        /// </summary>
        private decimal codramo;
        [XmlElement(ElementName = "CODRAMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codramo
        {
            get { return  codramo; }
            set {  codramo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: C�digo do RCA.
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTMIX
        /// Coment�rio: Contagem mix.
        /// </summary>
        private decimal contmix;
        [XmlElement(ElementName = "CONTMIX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Contmix
        {
            get { return  contmix; }
            set {  contmix = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDAPURACAO
        /// Coment�rio: Identifica��o apura��o remunera��o vari�vel.
        /// </summary>
        private decimal idapuracao;
        [XmlElement(ElementName = "IDAPURACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Idapuracao
        {
            get { return  idapuracao; }
            set {  idapuracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MIXPREV
        /// Coment�rio: Meta mix.
        /// </summary>
        private decimal mixprev;
        [XmlElement(ElementName = "MIXPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Mixprev
        {
            get { return  mixprev; }
            set {  mixprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREMIO
        /// Coment�rio: Valor do pr�mio.
        /// </summary>
        private decimal premio;
        [XmlElement(ElementName = "PREMIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Premio
        {
            get { return  premio; }
            set {  premio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPONTOS
        /// Coment�rio: Quantidade de pontos.
        /// </summary>
        private decimal qtpontos;
        [XmlElement(ElementName = "QTPONTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtpontos
        {
            get { return  qtpontos; }
            set {  qtpontos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAPURACAO
        /// Coment�rio: Tipo apura��o.
        /// </summary>
        private decimal tipoapuracao;
        [XmlElement(ElementName = "TIPOAPURACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tipoapuracao
        {
            get { return  tipoapuracao; }
            set {  tipoapuracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFATURADO
        /// Coment�rio: Realizado valor faturado.
        /// </summary>
        private decimal vlfaturado;
        [XmlElement(ElementName = "VLFATURADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfaturado
        {
            get { return  vlfaturado; }
            set {  vlfaturado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINVENDAPOS
        /// Coment�rio: Meta valor m�nimo da venda para positivar.
        /// </summary>
        private decimal vlminvendapos;
        [XmlElement(ElementName = "VLMINVENDAPOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vlminvendapos
        {
            get { return  vlminvendapos; }
            set {  vlminvendapos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAPREV
        /// Coment�rio: Meta valor venda.
        /// </summary>
        private decimal vlvendaprev;
        [XmlElement(ElementName = "VLVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlvendaprev
        {
            get { return  vlvendaprev; }
            set {  vlvendaprev = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDslremvariaveli()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDSLREMVARIAVELI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDslremvariaveli> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDslremvariaveli>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDslremvariaveli> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDslremvariaveli>(where);
        }

        #endregion
    }
}

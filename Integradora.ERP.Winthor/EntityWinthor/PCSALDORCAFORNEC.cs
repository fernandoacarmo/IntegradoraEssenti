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
    /// Classe referente a tabela PCSaldorcafornec
    /// </summary>
    [XmlType("PCSALDORCAFORNEC")]
    public class PCSaldorcafornec : OracleTable
    {
        #region Atributos

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
        /// Propriedade referente ao campo: CODFUNCCAD
        /// Coment�rio: C�digo do funcion�rio de cadastro.
        /// </summary>
        private decimal codfunccad;
        [XmlElement(ElementName = "CODFUNCCAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccad
        {
            get { return  codfunccad; }
            set {  codfunccad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: C�digo saldo rca/fornecedor.
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: C�digo do usu�rio.
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
        /// Propriedade referente ao campo: DTALT
        /// Coment�rio: Data de altera��o.
        /// </summary>
        private DateTime? dtalt;
        [XmlElement(ElementName = "DTALT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalt
        {
            get { return  dtalt; }
            set {  dtalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCRIACAO
        /// Coment�rio: Data da cria��o.
        /// </summary>
        private DateTime? dtcriacao;
        [XmlElement(ElementName = "DTCRIACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcriacao
        {
            get { return  dtcriacao; }
            set {  dtcriacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMVIGENCIA
        /// Coment�rio: Data de fim da vig�ncia.
        /// </summary>
        private DateTime? dtfimvigencia;
        [XmlElement(ElementName = "DTFIMVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimvigencia
        {
            get { return  dtfimvigencia; }
            set {  dtfimvigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOVIGENCIA
        /// Coment�rio: Data de in�cio da ving�ncia.
        /// </summary>
        private DateTime? dtiniciovigencia;
        [XmlElement(ElementName = "DTINICIOVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciovigencia
        {
            get { return  dtiniciovigencia; }
            set {  dtiniciovigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Coment�rio: Motivo de cadastro.
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOALTERACAO
        /// Coment�rio: Motivo da altera��o.
        /// </summary>
        private string motivoalteracao;
        [XmlElement(ElementName = "MOTIVOALTERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Motivoalteracao
        {
            get { return  motivoalteracao; }
            set {  motivoalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLLIMCRED
        /// Coment�rio: Valor do limite de cr�dito.
        /// </summary>
        private decimal vllimcred;
        [XmlElement(ElementName = "VLLIMCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vllimcred
        {
            get { return  vllimcred; }
            set {  vllimcred = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCSaldorcafornec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSALDORCAFORNEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCSaldorcafornec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSaldorcafornec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCSaldorcafornec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSaldorcafornec>(where);
        }

        #endregion
    }
}

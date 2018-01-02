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
    /// Classe referente a tabela PCApuracampanha
    /// </summary>
    [XmlType("PCAPURACAMPANHA")]
    public class PCApuracampanha : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAPURACAO
        /// Coment�rio: C�digo do funcion�rio que realizou a apura��o.
        /// </summary>
        private decimal codfuncapuracao;
        [XmlElement(ElementName = "CODFUNCAPURACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncapuracao
        {
            get { return  codfuncapuracao; }
            set {  codfuncapuracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: C�digo do item analisado.
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO2
        /// Coment�rio: C�digo do item 2 analisado.
        /// </summary>
        private decimal codigo2;
        [XmlElement(ElementName = "CODIGO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codigo2
        {
            get { return  codigo2; }
            set {  codigo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Coment�rio: C�digo do supervisor.
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: C�digo de RCA.
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
        /// Propriedade referente ao campo: COLUNA
        /// Coment�rio: Nome da coluna de crit�rio.
        /// </summary>
        private string coluna;
        [XmlElement(ElementName = "COLUNA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,32)]
        public string Coluna
        {
            get { return  coluna; }
            set {  coluna = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAAPURACAO
        /// Coment�rio: Data de apura��o da campanha.
        /// </summary>
        private DateTime? dataapuracao;
        [XmlElement(ElementName = "DATAAPURACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataapuracao
        {
            get { return  dataapuracao; }
            set {  dataapuracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Coment�rio: Data final de vig�ncia.
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: Data de in�cio de vig�ncia.
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDOC
        /// Coment�rio: N�mero do documento de vale.
        /// </summary>
        private decimal numdoc;
        [XmlElement(ElementName = "NUMDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Numdoc
        {
            get { return  numdoc; }
            set {  numdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREMIO
        /// Coment�rio: Valor do Pr�mio.
        /// </summary>
        private decimal premio;
        [XmlElement(ElementName = "PREMIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Premio
        {
            get { return  premio; }
            set {  premio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREVISTO
        /// Coment�rio: Valor previsto para meta.
        /// </summary>
        private decimal previsto;
        [XmlElement(ElementName = "PREVISTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Previsto
        {
            get { return  previsto; }
            set {  previsto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REALIZADO
        /// Coment�rio: Valor realizado pelo RCA.
        /// </summary>
        private decimal realizado;
        [XmlElement(ElementName = "REALIZADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Realizado
        {
            get { return  realizado; }
            set {  realizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMETA
        /// Coment�rio: Tipo de meta.
        /// </summary>
        private string tipometa;
        [XmlElement(ElementName = "TIPOMETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipometa
        {
            get { return  tipometa; }
            set {  tipometa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPREMIO
        /// Coment�rio: Tipo de premia��o.
        /// </summary>
        private string tipopremio;
        [XmlElement(ElementName = "TIPOPREMIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipopremio
        {
            get { return  tipopremio; }
            set {  tipopremio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALEGERADO
        /// Coment�rio: Indica se foi gerado vale.
        /// </summary>
        private string valegerado;
        [XmlElement(ElementName = "VALEGERADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Valegerado
        {
            get { return  valegerado; }
            set {  valegerado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCApuracampanha()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAPURACAMPANHA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCApuracampanha> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCApuracampanha>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCApuracampanha> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCApuracampanha>(where);
        }

        #endregion
    }
}

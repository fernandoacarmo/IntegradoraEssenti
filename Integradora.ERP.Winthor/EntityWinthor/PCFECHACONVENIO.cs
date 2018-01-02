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
    /// Classe referente a tabela PCFechaconvenio
    /// </summary>
    [XmlType("PCFECHACONVENIO")]
    public class PCFechaconvenio : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�DIGO CLIENTE.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�DIGO FILIAL.
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
        /// Propriedade referente ao campo: CODFUNCFECNF
        /// Coment�rio: C�D. FUNCION�RIO DO FECHAMENTO.
        /// </summary>
        private decimal codfuncfecnf;
        [XmlElement(ElementName = "CODFUNCFECNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfecnf
        {
            get { return  codfuncfecnf; }
            set {  codfuncfecnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFECPREST
        /// Coment�rio: C�D. FUNCION�RIO DO FECHAMENTO.
        /// </summary>
        private decimal codfuncfecprest;
        [XmlElement(ElementName = "CODFUNCFECPREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfecprest
        {
            get { return  codfuncfecprest; }
            set {  codfuncfecprest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFECREL
        /// Coment�rio: C�D. FUNCION�RIO QUE GEROU O  RELAT�RIO.
        /// </summary>
        private decimal codfuncfecrel;
        [XmlElement(ElementName = "CODFUNCFECREL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfecrel
        {
            get { return  codfuncfecrel; }
            set {  codfuncfecrel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECNF
        /// Coment�rio: DATA FECHAMENTO CONV�NIO.
        /// </summary>
        private DateTime? dtfecnf;
        [XmlElement(ElementName = "DTFECNF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfecnf
        {
            get { return  dtfecnf; }
            set {  dtfecnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECPREST
        /// Coment�rio: DATA PRESTA��O.
        /// </summary>
        private DateTime? dtfecprest;
        [XmlElement(ElementName = "DTFECPREST", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfecprest
        {
            get { return  dtfecprest; }
            set {  dtfecprest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECREL
        /// Coment�rio: DATA FECHAMENTO RELAT�RIO.
        /// </summary>
        private DateTime? dtfecrel;
        [XmlElement(ElementName = "DTFECREL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfecrel
        {
            get { return  dtfecrel; }
            set {  dtfecrel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFECHAMENTO
        /// Coment�rio: N�MERO DO FECHAMENTO.
        /// </summary>
        private decimal numfechamento;
        [XmlElement(ElementName = "NUMFECHAMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numfechamento
        {
            get { return  numfechamento; }
            set {  numfechamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDADEST
        /// Coment�rio: N�MERO DO T�TULO.
        /// </summary>
        private decimal numtransvendadest;
        [XmlElement(ElementName = "NUMTRANSVENDADEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendadest
        {
            get { return  numtransvendadest; }
            set {  numtransvendadest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDANF
        /// Coment�rio: N�MERO DA VENDA.
        /// </summary>
        private decimal numtransvendanf;
        [XmlElement(ElementName = "NUMTRANSVENDANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendanf
        {
            get { return  numtransvendanf; }
            set {  numtransvendanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASREL
        /// Coment�rio: N�MERO DE VIA RELAT�RIO.
        /// </summary>
        private decimal numviasrel;
        [XmlElement(ElementName = "NUMVIASREL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numviasrel
        {
            get { return  numviasrel; }
            set {  numviasrel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRESTDEST
        /// Coment�rio: N�MERO PRESTA��O.
        /// </summary>
        private string prestdest;
        [XmlElement(ElementName = "PRESTDEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Prestdest
        {
            get { return  prestdest; }
            set {  prestdest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: SITUA��O.
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFechaconvenio()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFECHACONVENIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFechaconvenio> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFechaconvenio>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFechaconvenio> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFechaconvenio>(where);
        }

        #endregion
    }
}

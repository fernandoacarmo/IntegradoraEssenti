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
    /// Classe referente a tabela PCDescontoc
    /// </summary>
    [XmlType("PCDESCONTOC")]
    public class PCDescontoc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: Indica o c�digo da campanha de desconto.
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Indica a descri��o da campanha de desconto.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Coment�rio: Indica a data final Data final de vig�ncia da campanha de desconto.
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: Indica a data de in�cio de vig�ncia da campanha de desconto.
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METODOLOGIA
        /// Coment�rio: Indica o metodologia da campamha.
        /// </summary>
        private string metodologia;
        [XmlElement(ElementName = "METODOLOGIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,400)]
        public string Metodologia
        {
            get { return  metodologia; }
            set {  metodologia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCAMPANHA
        /// Coment�rio: Indica o tipo de campanha.
        /// </summary>
        private string tipocampanha;
        [XmlElement(ElementName = "TIPOCAMPANHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Tipocampanha
        {
            get { return  tipocampanha; }
            set {  tipocampanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCONTO
        /// Coment�rio: Indica o tipo de desconto.
        /// </summary>
        private string tipodesconto;
        [XmlElement(ElementName = "TIPODESCONTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodesconto
        {
            get { return  tipodesconto; }
            set {  tipodesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPATROCINIO
        /// Coment�rio: Indica o tipo de patroc�nio da campanha.
        /// </summary>
        private string tipopatrocinio;
        [XmlElement(ElementName = "TIPOPATROCINIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopatrocinio
        {
            get { return  tipopatrocinio; }
            set {  tipopatrocinio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACODCLIPRINC
        /// Coment�rio: Indica se considera redes de clientes.
        /// </summary>
        private string utilizacodcliprinc;
        [XmlElement(ElementName = "UTILIZACODCLIPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacodcliprinc
        {
            get { return  utilizacodcliprinc; }
            set {  utilizacodcliprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACODPRODPRINC
        /// Coment�rio: Indica se considera fam�lias de produtos.
        /// </summary>
        private string utilizacodprodprinc;
        [XmlElement(ElementName = "UTILIZACODPRODPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacodprodprinc
        {
            get { return  utilizacodprodprinc; }
            set {  utilizacodprodprinc = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDescontoc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESCONTOC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDescontoc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDescontoc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDescontoc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDescontoc>(where);
        }

        #endregion
    }
}

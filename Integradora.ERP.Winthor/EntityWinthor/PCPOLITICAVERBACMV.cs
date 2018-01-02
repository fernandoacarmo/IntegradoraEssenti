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
    /// Classe referente a tabela PCPoliticaverbacmv
    /// </summary>
    [XmlType("PCPOLITICAVERBACMV")]
    public class PCPoliticaverbacmv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTERACONTACORRENTE
        /// Coment�rio: Alterar o conta corrente do RCA
        /// </summary>
        private string alteracontacorrente;
        [XmlElement(ElementName = "ALTERACONTACORRENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Alteracontacorrente
        {
            get { return  alteracontacorrente; }
            set {  alteracontacorrente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente para aplica��o de verba CMV.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Coment�rio: C�digo do departamento para aplica��o de verba CMV.
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: C�digo da pol�tica para aplica��o e verba CMV, este campo ser� gerado automaticamente sequence).
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto para aplica��o de verba CMV. 
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
        /// Propriedade referente ao campo: CODREDE
        /// Coment�rio: C�digo da rede de clientes
        /// </summary>
        private decimal codrede;
        [XmlElement(ElementName = "CODREDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrede
        {
            get { return  codrede; }
            set {  codrede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Coment�rio: C�digo da se��o para aplica��o de verba CMV. 
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
        /// Propriedade referente ao campo: DTFIM
        /// Coment�rio: Data de validade final da pol�tica para aplica��o de verba CMV. 
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
        /// Coment�rio: Data de validade inicial da pol�tica para aplica��o de verba CMV. 
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
        /// Propriedade referente ao campo: PERCVERBACMV
        /// Coment�rio: Percentual da verba CMV a ser aplicado no pedido de venda. 
        /// </summary>
        private decimal percverbacmv;
        [XmlElement(ElementName = "PERCVERBACMV", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Percverbacmv
        {
            get { return  percverbacmv; }
            set {  percverbacmv = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPoliticaverbacmv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPOLITICAVERBACMV";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPoliticaverbacmv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPoliticaverbacmv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPoliticaverbacmv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPoliticaverbacmv>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCAutorc
    /// </summary>
    [XmlType("PCAUTORC")]
    public class PCAutorc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: 
        /// </summary>
        private decimal? codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal? Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCUTILIZACAO
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncutilizacao;
        [XmlElement(ElementName = "CODFUNCUTILIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncutilizacao
        {
            get { return  codfuncutilizacao; }
            set {  codfuncutilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGLIBERADO
        /// Coment�rio: Indica o c�digo do plano de pagamento autorizado.
        /// </summary>
        private decimal? codplpagliberado;
        [XmlElement(ElementName = "CODPLPAGLIBERADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codplpagliberado
        {
            get { return  codplpagliberado; }
            set {  codplpagliberado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal condvenda;
        [XmlElement(ElementName = "CONDVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Condvenda
        {
            get { return  condvenda; }
            set {  condvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTUTILIZACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtutilizacao;
        [XmlElement(ElementName = "DTUTILIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtutilizacao
        {
            get { return  dtutilizacao; }
            set {  dtutilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIBERALIMCRED
        /// Coment�rio: 
        /// </summary>
        private string liberalimcred;
        [XmlElement(ElementName = "LIBERALIMCRED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Liberalimcred
        {
            get { return  liberalimcred; }
            set {  liberalimcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIBERARPORPEDIDO
        /// Coment�rio: 
        /// </summary>
        private string liberarporpedido;
        [XmlElement(ElementName = "LIBERARPORPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Liberarporpedido
        {
            get { return  liberarporpedido; }
            set {  liberarporpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMCRED
        /// Coment�rio: 
        /// </summary>
        private decimal limcred;
        [XmlElement(ElementName = "LIMCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Limcred
        {
            get { return  limcred; }
            set {  limcred = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDO
        /// Coment�rio: 
        /// </summary>
        private decimal numpedido;
        [XmlElement(ElementName = "NUMPEDIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedido
        {
            get { return  numpedido; }
            set {  numpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDLIBERAR
        /// Coment�rio: 
        /// </summary>
        private decimal? numpedliberar;
        [XmlElement(ElementName = "NUMPEDLIBERAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numpedliberar
        {
            get { return  numpedliberar; }
            set {  numpedliberar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDUTILIZACAO
        /// Coment�rio: 
        /// </summary>
        private decimal? numpedutilizacao;
        [XmlElement(ElementName = "NUMPEDUTILIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numpedutilizacao
        {
            get { return  numpedutilizacao; }
            set {  numpedutilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Indica observa��o/motivo da autoriza��o de limite de cr�dito.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMPED
        /// Coment�rio: Indica a origem do pedido.
        /// </summary>
        private string origemped;
        [XmlElement(ElementName = "ORIGEMPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemped
        {
            get { return  origemped; }
            set {  origemped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXAFIN
        /// Coment�rio: 
        /// </summary>
        private decimal? taxafin;
        [XmlElement(ElementName = "TAXAFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Taxafin
        {
            get { return  taxafin; }
            set {  taxafin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLLIBERADO
        /// Coment�rio: 
        /// </summary>
        private decimal vlliberado;
        [XmlElement(ElementName = "VLLIBERADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlliberado
        {
            get { return  vlliberado; }
            set {  vlliberado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPENDENTE
        /// Coment�rio: 
        /// </summary>
        private decimal vlpendente;
        [XmlElement(ElementName = "VLPENDENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlpendente
        {
            get { return  vlpendente; }
            set {  vlpendente = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAutorc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAUTORC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAutorc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAutorc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAutorc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAutorc>(where);
        }

        #endregion
    }
}

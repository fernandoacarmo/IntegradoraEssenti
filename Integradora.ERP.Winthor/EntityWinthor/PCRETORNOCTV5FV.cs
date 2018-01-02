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
    /// Classe referente a tabela PCRetornoctv5fv
    /// </summary>
    [XmlType("PCRETORNOCTV5FV")]
    public class PCRetornoctv5fv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CGCCLI
        /// Comentário: Cnpj ou cpf do cliente
        /// </summary>
        private string cgccli;
        [XmlElement(ElementName = "CGCCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgccli
        {
            get { return  cgccli; }
            set {  cgccli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Codigo do cliente
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
        /// Comentário: Codigo da Filial do Pedido
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
        /// Propriedade referente ao campo: CODFILIALNF
        /// Comentário: Codigo da Filial NF do Pedido
        /// </summary>
        private string codfilialnf;
        [XmlElement(ElementName = "CODFILIALNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialnf
        {
            get { return  codfilialnf; }
            set {  codfilialnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALRETIRA
        /// Comentário: Codigo da Filial Retira do Pedido
        /// </summary>
        private string codfilialretira;
        [XmlElement(ElementName = "CODFILIALRETIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialretira
        {
            get { return  codfilialretira; }
            set {  codfilialretira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Codigo do rca
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
        /// Propriedade referente ao campo: DTABERTURAPEDPALM
        /// Comentário: Data completa do pedido no palm
        /// </summary>
        private DateTime? dtaberturapedpalm;
        [XmlElement(ElementName = "DTABERTURAPEDPALM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtaberturapedpalm
        {
            get { return  dtaberturapedpalm; }
            set {  dtaberturapedpalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: Data de alteração do registro na tabela
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTREGA
        /// Comentário: Data de entrega do pedido
        /// </summary>
        private DateTime? dtentrega;
        [XmlElement(ElementName = "DTENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtentrega
        {
            get { return  dtentrega; }
            set {  dtentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: Data de inclusao do registro na tabela
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARBRINDEPEDBONIFIC
        /// Comentário: GERARBRINDEPEDBONIFIC
        /// </summary>
        private string gerarbrindepedbonific;
        [XmlElement(ElementName = "GERARBRINDEPEDBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarbrindepedbonific
        {
            get { return  gerarbrindepedbonific; }
            set {  gerarbrindepedbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDORIGEM
        /// Comentário: Numero do pedido TV1 que gerou o brinde
        /// </summary>
        private decimal numpedorigem;
        [XmlElement(ElementName = "NUMPEDORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedorigem
        {
            get { return  numpedorigem; }
            set {  numpedorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Comentário: Número do pedido do palm
        /// </summary>
        private decimal numpedrca;
        [XmlElement(ElementName = "NUMPEDRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedrca
        {
            get { return  numpedrca; }
            set {  numpedrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDTV5
        /// Comentário: Numero do pedido TV5 gerado
        /// </summary>
        private decimal numpedtv5;
        [XmlElement(ElementName = "NUMPEDTV5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedtv5
        {
            get { return  numpedtv5; }
            set {  numpedtv5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO_ATUAL
        /// Comentário: Posição atual do pedido de brinde
        /// </summary>
        private string posicao_atual;
        [XmlElement(ElementName = "POSICAO_ATUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Posicao_Atual
        {
            get { return  posicao_atual; }
            set {  posicao_atual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RETORNO
        /// Comentário: Retorno
        /// </summary>
        private decimal retorno;
        [XmlElement(ElementName = "RETORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Retorno
        {
            get { return  retorno; }
            set {  retorno = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRetornoctv5fv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRETORNOCTV5FV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRetornoctv5fv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRetornoctv5fv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRetornoctv5fv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRetornoctv5fv>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCCondicaovenda
    /// </summary>
    [XmlType("PCCONDICAOVENDA")]
    public class PCCondicaovenda : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONDICAOVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal codcondicaovenda;
        [XmlElement(ElementName = "CODCONDICAOVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcondicaovenda
        {
            get { return  codcondicaovenda; }
            set {  codcondicaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRAZOINTEGRAD
        /// Coment�rio: C�digo Prazo
        /// </summary>
        private string codprazointegrad;
        [XmlElement(ElementName = "CODPRAZOINTEGRAD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codprazointegrad
        {
            get { return  codprazointegrad; }
            set {  codprazointegrad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDICAOINTEGRAD
        /// Coment�rio: Condi��o da integradora
        /// </summary>
        private string condicaointegrad;
        [XmlElement(ElementName = "CONDICAOINTEGRAD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condicaointegrad
        {
            get { return  condicaointegrad; }
            set {  condicaointegrad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDFINAL
        /// Coment�rio: Data final do peri�do de vig�ncia da condi��o de venda
        /// </summary>
        private DateTime? dtvalidfinal;
        [XmlElement(ElementName = "DTVALIDFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidfinal
        {
            get { return  dtvalidfinal; }
            set {  dtvalidfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDINICIAL
        /// Coment�rio: Data inicial do peri�do de vig�ncia da condi��o de venda
        /// </summary>
        private DateTime? dtvalidinicial;
        [XmlElement(ElementName = "DTVALIDINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidinicial
        {
            get { return  dtvalidinicial; }
            set {  dtvalidinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOINTEGRAD
        /// Coment�rio: Prazo da integradora
        /// </summary>
        private decimal prazointegrad;
        [XmlElement(ElementName = "PRAZOINTEGRAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Prazointegrad
        {
            get { return  prazointegrad; }
            set {  prazointegrad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCBONIF
        /// Coment�rio: Tipo de desconto para Bonifica��o
        /// </summary>
        private string tipodescbonif;
        [XmlElement(ElementName = "TIPODESCBONIF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodescbonif
        {
            get { return  tipodescbonif; }
            set {  tipodescbonif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPLPAG
        /// Coment�rio: Tipo de Plano de Pagamento
        /// </summary>
        private decimal tipoplpag;
        [XmlElement(ElementName = "TIPOPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tipoplpag
        {
            get { return  tipoplpag; }
            set {  tipoplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRAZOINTEGRAD
        /// Coment�rio: Tipo de prazo da integradora
        /// </summary>
        private string tipoprazointegrad;
        [XmlElement(ElementName = "TIPOPRAZOINTEGRAD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoprazointegrad
        {
            get { return  tipoprazointegrad; }
            set {  tipoprazointegrad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALORMINIMO
        /// Coment�rio: Tipo de valor m�nino para o per�odo
        /// </summary>
        private string tipovalorminimo;
        [XmlElement(ElementName = "TIPOVALORMINIMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalorminimo
        {
            get { return  tipovalorminimo; }
            set {  tipovalorminimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMINIMOPED
        /// Coment�rio: Valor m�nimo do pedido
        /// </summary>
        private decimal valorminimoped;
        [XmlElement(ElementName = "VALORMINIMOPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Valorminimoped
        {
            get { return  valorminimoped; }
            set {  valorminimoped = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCondicaovenda()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONDICAOVENDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCondicaovenda> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCondicaovenda>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCondicaovenda> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCondicaovenda>(where);
        }

        #endregion
    }
}

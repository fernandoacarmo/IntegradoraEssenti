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
    /// Classe referente a tabela PCCotacao
    /// </summary>
    [XmlType("PCCOTACAO")]
    public class PCCotacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Coment�rio: Indica o c�digo usu�rio lan�amento.
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: Indica o c�digo da rotina.
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Indica a data cadastro.
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
        /// Propriedade referente ao campo: DTFIMVIGENCIA
        /// Coment�rio: Indica a data final para vig�ncia da cota��o.
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
        /// Propriedade referente ao campo: DTINIVIGENCIA
        /// Coment�rio: Indica a data de in�cio para vig�ncia da cota��o.
        /// </summary>
        private DateTime? dtinivigencia;
        [XmlElement(ElementName = "DTINIVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinivigencia
        {
            get { return  dtinivigencia; }
            set {  dtinivigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCOTACAO
        /// Coment�rio: Indica o n�mero cota��o.
        /// </summary>
        private decimal numcotacao;
        [XmlElement(ElementName = "NUMCOTACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcotacao
        {
            get { return  numcotacao; }
            set {  numcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: Indica o pedido de compra gerado.
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOBONIFIC
        /// Coment�rio: 
        /// </summary>
        private string tipobonific;
        [XmlElement(ElementName = "TIPOBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipobonific
        {
            get { return  tipobonific; }
            set {  tipobonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCARGA
        /// Coment�rio: Tipo de pedido de compra.
        /// </summary>
        private string tipodescarga;
        [XmlElement(ElementName = "TIPODESCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodescarga
        {
            get { return  tipodescarga; }
            set {  tipodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEMPEDIDO
        /// Coment�rio: Tipo de embalagem dos produtos(Master ou Vendas).
        /// </summary>
        private string tipoembalagempedido;
        [XmlElement(ElementName = "TIPOEMBALAGEMPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoembalagempedido
        {
            get { return  tipoembalagempedido; }
            set {  tipoembalagempedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTLPRAZOMEDFORNEC
        /// Coment�rio: Utiliza prazo de pagamento como critico de desempate
        /// </summary>
        private string utlprazomedfornec;
        [XmlElement(ElementName = "UTLPRAZOMEDFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utlprazomedfornec
        {
            get { return  utlprazomedfornec; }
            set {  utlprazomedfornec = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCotacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOTACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCotacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCotacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCotacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCotacao>(where);
        }

        #endregion
    }
}

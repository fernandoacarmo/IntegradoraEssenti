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
    /// Classe referente a tabela PCCadgiftcard
    /// </summary>
    [XmlType("PCCADGIFTCARD")]
    public class PCCadgiftcard : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente do cart�o de presente (giftcard).
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
        /// Propriedade referente ao campo: CODFUNCATIVO
        /// Coment�rio: Registra o c�digo do operador que realizou a ativa��o.
        /// </summary>
        private decimal codfuncativo;
        [XmlElement(ElementName = "CODFUNCATIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncativo
        {
            get { return  codfuncativo; }
            set {  codfuncativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSUMIDORFINAL
        /// Coment�rio: Identificador de tipo de consumidor, se � do tipo consumidor final.
        /// </summary>
        private string consumidorfinal;
        [XmlElement(ElementName = "CONSUMIDORFINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consumidorfinal
        {
            get { return  consumidorfinal; }
            set {  consumidorfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTATIVO
        /// Coment�rio: Data da Ativa��o do Cart�o GIFTCARD
        /// </summary>
        private DateTime? dtativo;
        [XmlElement(ElementName = "DTATIVO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtativo
        {
            get { return  dtativo; }
            set {  dtativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Data em que o cart�o foi cadastrado.
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
        /// Propriedade referente ao campo: DTINATIVO
        /// Coment�rio: Data de inativa��o do cart�o.
        /// </summary>
        private DateTime? dtinativo;
        [XmlElement(ElementName = "DTINATIVO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinativo
        {
            get { return  dtinativo; }
            set {  dtinativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Coment�rio: Data limite de validade do cart�o. Data de vencimento.
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIXO
        /// Coment�rio: Identificador de fixo/vari�vel referente ao valor de venda do cart�o.
        /// </summary>
        private string fixo;
        [XmlElement(ElementName = "FIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fixo
        {
            get { return  fixo; }
            set {  fixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOINATIVO
        /// Coment�rio: Motivo da inativa��o do cart�o.
        /// </summary>
        private string motivoinativo;
        [XmlElement(ElementName = "MOTIVOINATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Motivoinativo
        {
            get { return  motivoinativo; }
            set {  motivoinativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGIFTCARD
        /// Coment�rio: N�mero do cart�o de presente (giftcard).
        /// </summary>
        private decimal numgiftcard;
        [XmlElement(ElementName = "NUMGIFTCARD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,25)]
        public decimal Numgiftcard
        {
            get { return  numgiftcard; }
            set {  numgiftcard = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: Status do cart�o: (A)TIVO,(I)NATIVO ou (D)ISPON�VEL.
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor de venda do cart�o.
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCadgiftcard()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCADGIFTCARD";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCadgiftcard> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCadgiftcard>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCadgiftcard> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCadgiftcard>(where);
        }

        #endregion
    }
}

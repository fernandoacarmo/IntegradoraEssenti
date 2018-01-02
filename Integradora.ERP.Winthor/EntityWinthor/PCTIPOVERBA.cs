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
    /// Classe referente a tabela PCTipoverba
    /// </summary>
    [XmlType("PCTIPOVERBA")]
    public class PCTipoverba : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATIVO
        /// Coment�rio: Indica se esta ativo.
        /// </summary>
        private string ativo;
        [XmlElement(ElementName = "ATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ativo
        {
            get { return  ativo; }
            set {  ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Coment�rio: Indica o c�digo da conta gerencial.
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: Indica o cC�digo do tipo da conta.
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
        /// Coment�rio: Indica a descri��o do tipo da verba.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: Indica a data de exclus�o.
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EAPURACAO
        /// Coment�rio: Indica se a verba utiliza apura��o.
        /// </summary>
        private string eapuracao;
        [XmlElement(ElementName = "EAPURACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Eapuracao
        {
            get { return  eapuracao; }
            set {  eapuracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ECONTRATO
        /// Coment�rio: Indica o tipo contrato.
        /// </summary>
        private string econtrato;
        [XmlElement(ElementName = "ECONTRATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Econtrato
        {
            get { return  econtrato; }
            set {  econtrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EDESCONTO
        /// Coment�rio: Indica o tipo desconto.
        /// </summary>
        private string edesconto;
        [XmlElement(ElementName = "EDESCONTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Edesconto
        {
            get { return  edesconto; }
            set {  edesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EDINHEIRO
        /// Coment�rio: Indica o tipo dinheiro.
        /// </summary>
        private string edinheiro;
        [XmlElement(ElementName = "EDINHEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Edinheiro
        {
            get { return  edinheiro; }
            set {  edinheiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMERCADORIA
        /// Coment�rio: Indica o tipo mercadoria.
        /// </summary>
        private string emercadoria;
        [XmlElement(ElementName = "EMERCADORIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emercadoria
        {
            get { return  emercadoria; }
            set {  emercadoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EREBAIXACUSTO
        /// Coment�rio: Indica se e rebaixa de custo.
        /// </summary>
        private string erebaixacusto;
        [XmlElement(ElementName = "EREBAIXACUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Erebaixacusto
        {
            get { return  erebaixacusto; }
            set {  erebaixacusto = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCTipoverba()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTIPOVERBA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCTipoverba> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTipoverba>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCTipoverba> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTipoverba>(where);
        }

        #endregion
    }
}

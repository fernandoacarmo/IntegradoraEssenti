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
    /// Classe referente a tabela PCItemsolicitacaomaterial
    /// </summary>
    [XmlType("PCITEMSOLICITACAOMATERIAL")]
    public class PCItemsolicitacaomaterial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial de atendimento do item.
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
        /// Propriedade referente ao campo: CODFUNCACEITEITENS
        /// Comentário: Código do funcionário do aceite dos itens.
        /// </summary>
        private decimal codfuncaceiteitens;
        [XmlElement(ElementName = "CODFUNCACEITEITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncaceiteitens
        {
            get { return  codfuncaceiteitens; }
            set {  codfuncaceiteitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCATENDIMENTOITEM
        /// Comentário: Código do Funcionário do Atendimento do item
        /// </summary>
        private decimal codfuncatendimentoitem;
        [XmlElement(ElementName = "CODFUNCATENDIMENTOITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncatendimentoitem
        {
            get { return  codfuncatendimentoitem; }
            set {  codfuncatendimentoitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Comentário: Código do Produto
        /// </summary>
        private decimal codproduto;
        [XmlElement(ElementName = "CODPRODUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codproduto
        {
            get { return  codproduto; }
            set {  codproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAACEITE
        /// Comentário: Data aceite dos itens da solicitação
        /// </summary>
        private DateTime? dataaceite;
        [XmlElement(ElementName = "DATAACEITE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataaceite
        {
            get { return  dataaceite; }
            set {  dataaceite = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAATENDIMENTOITEM
        /// Comentário: Data do Atendimento do Item
        /// </summary>
        private DateTime? dataatendimentoitem;
        [XmlElement(ElementName = "DATAATENDIMENTOITEM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataatendimentoitem
        {
            get { return  dataatendimentoitem; }
            set {  dataatendimentoitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOREJEICAOITEM
        /// Comentário: Motivo da rejeição do item
        /// </summary>
        private string motivorejeicaoitem;
        [XmlElement(ElementName = "MOTIVOREJEICAOITEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Motivorejeicaoitem
        {
            get { return  motivorejeicaoitem; }
            set {  motivorejeicaoitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROSOLICITACAO
        /// Comentário: Número da Solicitação a que pertence
        /// </summary>
        private decimal numerosolicitacao;
        [XmlElement(ElementName = "NUMEROSOLICITACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numerosolicitacao
        {
            get { return  numerosolicitacao; }
            set {  numerosolicitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEATENDIDA
        /// Comentário: Quantidade de itens atendidos
        /// </summary>
        private decimal qtdeatendida;
        [XmlElement(ElementName = "QTDEATENDIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtdeatendida
        {
            get { return  qtdeatendida; }
            set {  qtdeatendida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDECOTACAO
        /// Comentário: Quantidade de itens para cotação
        /// </summary>
        private decimal qtdecotacao;
        [XmlElement(ElementName = "QTDECOTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtdecotacao
        {
            get { return  qtdecotacao; }
            set {  qtdecotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEREJEITADA
        /// Comentário: Quantidade de itens rejeitados
        /// </summary>
        private decimal qtderejeitada;
        [XmlElement(ElementName = "QTDEREJEITADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtderejeitada
        {
            get { return  qtderejeitada; }
            set {  qtderejeitada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADE
        /// Comentário: Quantidade
        /// </summary>
        private decimal quantidade;
        [XmlElement(ElementName = "QUANTIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Quantidade
        {
            get { return  quantidade; }
            set {  quantidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSITEM
        /// Comentário: Status do item
        /// </summary>
        private string statusitem;
        [XmlElement(ElementName = "STATUSITEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Statusitem
        {
            get { return  statusitem; }
            set {  statusitem = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCItemsolicitacaomaterial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCITEMSOLICITACAOMATERIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCItemsolicitacaomaterial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCItemsolicitacaomaterial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCItemsolicitacaomaterial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCItemsolicitacaomaterial>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCConvlistapresente
    /// </summary>
    [XmlType("PCCONVLISTAPRESENTE")]
    public class PCConvlistapresente : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BAIXAMANUAL
        /// Comentário: Indicador de baixa manual do item
        /// </summary>
        private string baixamanual;
        [XmlElement(ElementName = "BAIXAMANUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixamanual
        {
            get { return  baixamanual; }
            set {  baixamanual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Código de barras do produto
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do Cliente
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
        /// Propriedade referente ao campo: CODFUNCBAIXAMANUAL
        /// Comentário: Codigo do funcionário que baixou item
        /// </summary>
        private decimal codfuncbaixamanual;
        [XmlElement(ElementName = "CODFUNCBAIXAMANUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncbaixamanual
        {
            get { return  codfuncbaixamanual; }
            set {  codfuncbaixamanual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Codigo sequencial dos convidados
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
        /// Propriedade referente ao campo: DATACOMPRA
        /// Comentário: Data da Compra
        /// </summary>
        private DateTime? datacompra;
        [XmlElement(ElementName = "DATACOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacompra
        {
            get { return  datacompra; }
            set {  datacompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEM
        /// Comentário: Mensagem Convidado
        /// </summary>
        private string mensagem;
        [XmlElement(ElementName = "MENSAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Mensagem
        {
            get { return  mensagem; }
            set {  mensagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECONVIDADO
        /// Comentário: Nome Convidado
        /// </summary>
        private string nomeconvidado;
        [XmlElement(ElementName = "NOMECONVIDADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomeconvidado
        {
            get { return  nomeconvidado; }
            set {  nomeconvidado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLISTA
        /// Comentário: Número de Identificação da Lista
        /// </summary>
        private decimal numlista;
        [XmlElement(ElementName = "NUMLISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numlista
        {
            get { return  numlista; }
            set {  numlista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Comentário: Número do orçamento para identificar de onde esse cliente baixou a venda
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: Número da transação da venda, realizada pelo PDV.
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDE
        /// Comentário: Quantidade
        /// </summary>
        private decimal qtde;
        [XmlElement(ElementName = "QTDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtde
        {
            get { return  qtde; }
            set {  qtde = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConvlistapresente()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONVLISTAPRESENTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConvlistapresente> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConvlistapresente>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConvlistapresente> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConvlistapresente>(where);
        }

        #endregion
    }
}

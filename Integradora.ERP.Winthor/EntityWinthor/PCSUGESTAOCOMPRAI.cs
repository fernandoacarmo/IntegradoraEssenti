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
    /// Classe referente a tabela PCSugestaocomprai
    /// </summary>
    [XmlType("PCSUGESTAOCOMPRAI")]
    public class PCSugestaocomprai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do produto para qual foi gerada a sugestão.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOCANCELAMENTO
        /// Comentário: Código do usuário responsável pelo cancelamento do pedido.
        /// </summary>
        private decimal codusuariocancelamento;
        [XmlElement(ElementName = "CODUSUARIOCANCELAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuariocancelamento
        {
            get { return  codusuariocancelamento; }
            set {  codusuariocancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOPROCESSAMENTO
        /// Comentário: Código o usuário responsável pelo processamento do pedido de compra.
        /// </summary>
        private decimal codusuarioprocessamento;
        [XmlElement(ElementName = "CODUSUARIOPROCESSAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioprocessamento
        {
            get { return  codusuarioprocessamento; }
            set {  codusuarioprocessamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAPROCESSAMENTO
        /// Comentário: Data do processamento e geração do pedido de compra.
        /// </summary>
        private DateTime? dataprocessamento;
        [XmlElement(ElementName = "DATAPROCESSAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataprocessamento
        {
            get { return  dataprocessamento; }
            set {  dataprocessamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOTELICIT
        /// Comentário: Lote da licitação
        /// </summary>
        private string lotelicit;
        [XmlElement(ElementName = "LOTELICIT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Lotelicit
        {
            get { return  lotelicit; }
            set {  lotelicit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROITEMLICIT
        /// Comentário: Número item licitação
        /// </summary>
        private decimal numeroitemlicit;
        [XmlElement(ElementName = "NUMEROITEMLICIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Numeroitemlicit
        {
            get { return  numeroitemlicit; }
            set {  numeroitemlicit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Número do pedido de compra gerado no processamento.
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSUGESTAO
        /// Comentário: O número da sugestão gerada.
        /// </summary>
        private decimal numsugestao;
        [XmlElement(ElementName = "NUMSUGESTAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numsugestao
        {
            get { return  numsugestao; }
            set {  numsugestao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: Observação será o campo onde será gravado o motivo de não geração do pedido de compra para o item sugerido.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMPRALIQSUGERIDO
        /// Comentário: Preço Compra Liq. Sug.
        /// </summary>
        private decimal pcompraliqsugerido;
        [XmlElement(ElementName = "PCOMPRALIQSUGERIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pcompraliqsugerido
        {
            get { return  pcompraliqsugerido; }
            set {  pcompraliqsugerido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDIDO
        /// Comentário: Quantidade gerada no pedido.
        /// </summary>
        private decimal qtpedido;
        [XmlElement(ElementName = "QTPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtpedido
        {
            get { return  qtpedido; }
            set {  qtpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSUGERIDA
        /// Comentário: Quantidade gerada pela sugestão.
        /// </summary>
        private decimal qtsugerida;
        [XmlElement(ElementName = "QTSUGERIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtsugerida
        {
            get { return  qtsugerida; }
            set {  qtsugerida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: "Status da sugestão G - Gerado S - Sugerido  C - Cancelado P - Pendente ".
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSugestaocomprai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSUGESTAOCOMPRAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSugestaocomprai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSugestaocomprai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSugestaocomprai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSugestaocomprai>(where);
        }

        #endregion
    }
}

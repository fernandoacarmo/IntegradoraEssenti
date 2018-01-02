using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Esvpedidoestoque
    /// </summary>
    [XmlType("ESVPEDIDOESTOQUE")]
    public class Esvpedidoestoque : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLIENTE
        /// Comentário: 
        /// </summary>
        private decimal codcliente;
        [XmlElement(ElementName = "CODCLIENTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcliente
        {
            get { return  codcliente; }
            set {  codcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Comentário: 
        /// </summary>
        private decimal codproduto;
        [XmlElement(ElementName = "CODPRODUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codproduto
        {
            get { return  codproduto; }
            set {  codproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOCLIENTE
        /// Comentário: 
        /// </summary>
        private string descricaocliente;
        [XmlElement(ElementName = "DESCRICAOCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Descricaocliente
        {
            get { return  descricaocliente; }
            set {  descricaocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPALETE
        /// Comentário: 
        /// </summary>
        private decimal numpalete;
        [XmlElement(ElementName = "NUMPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpalete
        {
            get { return  numpalete; }
            set {  numpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDO
        /// Comentário: 
        /// </summary>
        private decimal numpedido;
        [XmlElement(ElementName = "NUMPEDIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numpedido
        {
            get { return  numpedido; }
            set {  numpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSARMAZENAGEM
        /// Comentário: 
        /// </summary>
        private string obsarmazenagem;
        [XmlElement(ElementName = "OBSARMAZENAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obsarmazenagem
        {
            get { return  obsarmazenagem; }
            set {  obsarmazenagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Comentário: 
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Posicao
        {
            get { return  posicao; }
            set {  posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT_A_SER_RESERVADA
        /// Comentário: 
        /// </summary>
        private decimal qt_a_ser_reservada;
        [XmlElement(ElementName = "QT_A_SER_RESERVADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qt_A_Ser_Reservada
        {
            get { return  qt_a_ser_reservada; }
            set {  qt_a_ser_reservada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTREGUE
        /// Comentário: 
        /// </summary>
        private decimal qtentregue;
        [XmlElement(ElementName = "QTENTREGUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtentregue
        {
            get { return  qtentregue; }
            set {  qtentregue = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODUZIDA
        /// Comentário: 
        /// </summary>
        private decimal qtproduzida;
        [XmlElement(ElementName = "QTPRODUZIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtproduzida
        {
            get { return  qtproduzida; }
            set {  qtproduzida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERVADA
        /// Comentário: 
        /// </summary>
        private decimal qtreservada;
        [XmlElement(ElementName = "QTRESERVADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtreservada
        {
            get { return  qtreservada; }
            set {  qtreservada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSALDO_A_RESERVA
        /// Comentário: 
        /// </summary>
        private decimal qtsaldo_a_reserva;
        [XmlElement(ElementName = "QTSALDO_A_RESERVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtsaldo_A_Reserva
        {
            get { return  qtsaldo_a_reserva; }
            set {  qtsaldo_a_reserva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADE
        /// Comentário: 
        /// </summary>
        private decimal quantidade;
        [XmlElement(ElementName = "QUANTIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Quantidade
        {
            get { return  quantidade; }
            set {  quantidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REQSEMPRODUZIR
        /// Comentário: 
        /// </summary>
        private string reqsemproduzir;
        [XmlElement(ElementName = "REQSEMPRODUZIR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reqsemproduzir
        {
            get { return  reqsemproduzir; }
            set {  reqsemproduzir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REQUISITANTE_QTCANCELADO
        /// Comentário: 
        /// </summary>
        private decimal requisitante_qtcancelado;
        [XmlElement(ElementName = "REQUISITANTE_QTCANCELADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Requisitante_Qtcancelado
        {
            get { return  requisitante_qtcancelado; }
            set {  requisitante_qtcancelado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REQUISITANTE_QTENTREGUE
        /// Comentário: 
        /// </summary>
        private decimal requisitante_qtentregue;
        [XmlElement(ElementName = "REQUISITANTE_QTENTREGUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Requisitante_Qtentregue
        {
            get { return  requisitante_qtentregue; }
            set {  requisitante_qtentregue = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REQUISITANTE_QTSOLICITADA
        /// Comentário: 
        /// </summary>
        private decimal requisitante_qtsolicitada;
        [XmlElement(ElementName = "REQUISITANTE_QTSOLICITADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Requisitante_Qtsolicitada
        {
            get { return  requisitante_qtsolicitada; }
            set {  requisitante_qtsolicitada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA
        /// Comentário: 
        /// </summary>
        private string rua;
        [XmlElement(ElementName = "RUA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Rua
        {
            get { return  rua; }
            set {  rua = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esvpedidoestoque()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVPEDIDOESTOQUE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvpedidoestoque> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvpedidoestoque.GetStringConnection());
            return ba.Listar<Esvpedidoestoque>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvpedidoestoque> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvpedidoestoque.GetStringConnection());
            return ba.Existe<Esvpedidoestoque>(where);
        }

        #endregion
    }
}

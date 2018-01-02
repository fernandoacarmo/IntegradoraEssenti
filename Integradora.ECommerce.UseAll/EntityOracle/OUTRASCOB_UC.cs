using Integradora.Database.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.UseAll.EntityOracle
{
    /// <summary>
    /// Classe referente a tabela Outrascob_Uc
    /// </summary>
    [XmlType("OUTRASCOB_UC")]
    public class Outrascob_Uc : OracleObjeto
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CANCELADO
        /// Comentário: 
        /// </summary>
        private decimal cancelado;
        [XmlElement(ElementName = "CANCELADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Cancelado
        {
            get { return  cancelado; }
            set {  cancelado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPETENCIA
        /// Comentário: 
        /// </summary>
        private DateTime? competencia;
        [XmlElement(ElementName = "COMPETENCIA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Competencia
        {
            get { return  competencia; }
            set {  competencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTABILIZAR
        /// Comentário: 
        /// </summary>
        private string contabilizar;
        [XmlElement(ElementName = "CONTABILIZAR", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Contabilizar
        {
            get { return  contabilizar; }
            set {  contabilizar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_CANCELAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? data_cancelamento;
        [XmlElement(ElementName = "DATA_CANCELAMENTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data_Cancelamento
        {
            get { return  data_cancelamento; }
            set {  data_cancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_INSERCAO
        /// Comentário: 
        /// </summary>
        private DateTime? data_insercao;
        [XmlElement(ElementName = "DATA_INSERCAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data_Insercao
        {
            get { return  data_insercao; }
            set {  data_insercao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_LANCTO
        /// Comentário: 
        /// </summary>
        private DateTime? data_lancto;
        [XmlElement(ElementName = "DATA_LANCTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data_Lancto
        {
            get { return  data_lancto; }
            set {  data_lancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DERENEGOCIACAO
        /// Comentário: 
        /// </summary>
        private string derenegociacao;
        [XmlElement(ElementName = "DERENEGOCIACAO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Derenegociacao
        {
            get { return  derenegociacao; }
            set {  derenegociacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,100)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCODFATURA
        /// Comentário: 
        /// </summary>
        private decimal idcodfatura;
        [XmlElement(ElementName = "IDCODFATURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Idcodfatura
        {
            get { return  idcodfatura; }
            set {  idcodfatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDITEM
        /// Comentário: 
        /// </summary>
        private decimal iditem;
        [XmlElement(ElementName = "IDITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Iditem
        {
            get { return  iditem; }
            set {  iditem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDOUTRASCOBMOVTO
        /// Comentário: 
        /// </summary>
        private decimal idoutrascobmovto;
        [XmlElement(ElementName = "IDOUTRASCOBMOVTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Idoutrascobmovto
        {
            get { return  idoutrascobmovto; }
            set {  idoutrascobmovto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDOUTRASCOBUC
        /// Comentário: 
        /// </summary>
        private decimal idoutrascobuc;
        [XmlElement(ElementName = "IDOUTRASCOBUC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idoutrascobuc
        {
            get { return  idoutrascobuc; }
            set {  idoutrascobuc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDREMESSA_EFI
        /// Comentário: 
        /// </summary>
        private decimal idremessa_efi;
        [XmlElement(ElementName = "IDREMESSA_EFI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idremessa_Efi
        {
            get { return  idremessa_efi; }
            set {  idremessa_efi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDSEQUENCIAL
        /// Comentário: 
        /// </summary>
        private decimal idsequencial;
        [XmlElement(ElementName = "IDSEQUENCIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Idsequencial
        {
            get { return  idsequencial; }
            set {  idsequencial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDUC
        /// Comentário: 
        /// </summary>
        private decimal iduc;
        [XmlElement(ElementName = "IDUC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Iduc
        {
            get { return  iduc; }
            set {  iduc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: JAFATURADA
        /// Comentário: 
        /// </summary>
        private string jafaturada;
        [XmlElement(ElementName = "JAFATURADA", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Jafaturada
        {
            get { return  jafaturada; }
            set {  jafaturada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MESFATURAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? mesfaturamento;
        [XmlElement(ElementName = "MESFATURAMENTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Mesfaturamento
        {
            get { return  mesfaturamento; }
            set {  mesfaturamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO_CANCELAMENTO
        /// Comentário: 
        /// </summary>
        private string motivo_cancelamento;
        [XmlElement(ElementName = "MOTIVO_CANCELAMENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,256)]
        public string Motivo_Cancelamento
        {
            get { return  motivo_cancelamento; }
            set {  motivo_cancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDE
        /// Comentário: 
        /// </summary>
        private decimal qtde;
        [XmlElement(ElementName = "QTDE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Qtde
        {
            get { return  qtde; }
            set {  qtde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFERENCIA
        /// Comentário: 
        /// </summary>
        private string referencia;
        [XmlElement(ElementName = "REFERENCIA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public string Referencia
        {
            get { return  referencia; }
            set {  referencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS_EFI
        /// Comentário: 
        /// </summary>
        private string status_efi;
        [XmlElement(ElementName = "STATUS_EFI", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Status_Efi
        {
            get { return  status_efi; }
            set {  status_efi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private decimal tipo;
        [XmlElement(ElementName = "TIPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIO_CANCELAMENTO
        /// Comentário: 
        /// </summary>
        private string usuario_cancelamento;
        [XmlElement(ElementName = "USUARIO_CANCELAMENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Usuario_Cancelamento
        {
            get { return  usuario_cancelamento; }
            set {  usuario_cancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIO_INSERCAO
        /// Comentário: 
        /// </summary>
        private string usuario_insercao;
        [XmlElement(ElementName = "USUARIO_INSERCAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Usuario_Insercao
        {
            get { return  usuario_insercao; }
            set {  usuario_insercao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Outrascob_Uc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "OUTRASCOB_UC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Outrascob_Uc> Listar(string where)
        {
            Persistencia ba = new Persistencia(Outrascob_Uc.GetStringConnection());
            return ba.Listar<Outrascob_Uc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Outrascob_Uc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Outrascob_Uc.GetStringConnection());
            return ba.Existe<Outrascob_Uc>(where);
        }

        #endregion
    }
}

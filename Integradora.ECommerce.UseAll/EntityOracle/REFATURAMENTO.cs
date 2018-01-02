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
    /// Classe referente a tabela Refaturamento
    /// </summary>
    [XmlType("REFATURAMENTO")]
    public class Refaturamento : OracleObjeto
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO_MES_REFAT
        /// Comentário: 
        /// </summary>
        private DateTime? ano_mes_refat;
        [XmlElement(ElementName = "ANO_MES_REFAT", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Ano_Mes_Refat
        {
            get { return  ano_mes_refat; }
            set {  ano_mes_refat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Comentário: 
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,4000)]
        public string Complemento
        {
            get { return  complemento; }
            set {  complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORA
        /// Comentário: 
        /// </summary>
        private DateTime? datahora;
        [XmlElement(ElementName = "DATAHORA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Datahora
        {
            get { return  datahora; }
            set {  datahora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_DEVOLUCAO
        /// Comentário: 
        /// </summary>
        private DateTime? data_devolucao;
        [XmlElement(ElementName = "DATA_DEVOLUCAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data_Devolucao
        {
            get { return  data_devolucao; }
            set {  data_devolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEFATURA_PAGA
        /// Comentário: 
        /// </summary>
        private string defatura_paga;
        [XmlElement(ElementName = "DEFATURA_PAGA", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Defatura_Paga
        {
            get { return  defatura_paga; }
            set {  defatura_paga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEVOLVER_JUROS_RETIF_PAGA
        /// Comentário: 
        /// </summary>
        private string devolver_juros_retif_paga;
        [XmlElement(ElementName = "DEVOLVER_JUROS_RETIF_PAGA", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Devolver_Juros_Retif_Paga
        {
            get { return  devolver_juros_retif_paga; }
            set {  devolver_juros_retif_paga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAS_PRORROGA_APRESENTACAO
        /// Comentário: 
        /// </summary>
        private decimal dias_prorroga_apresentacao;
        [XmlElement(ElementName = "DIAS_PRORROGA_APRESENTACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Dias_Prorroga_Apresentacao
        {
            get { return  dias_prorroga_apresentacao; }
            set {  dias_prorroga_apresentacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATURAS_ZERADAS
        /// Comentário: 
        /// </summary>
        private string faturas_zeradas;
        [XmlElement(ElementName = "FATURAS_ZERADAS", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Faturas_Zeradas
        {
            get { return  faturas_zeradas; }
            set {  faturas_zeradas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCALCULO_CANC
        /// Comentário: 
        /// </summary>
        private decimal idcalculo_canc;
        [XmlElement(ElementName = "IDCALCULO_CANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Idcalculo_Canc
        {
            get { return  idcalculo_canc; }
            set {  idcalculo_canc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCALCULO_NOVO
        /// Comentário: 
        /// </summary>
        private decimal idcalculo_novo;
        [XmlElement(ElementName = "IDCALCULO_NOVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Idcalculo_Novo
        {
            get { return  idcalculo_novo; }
            set {  idcalculo_novo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCALCULO_REFAT
        /// Comentário: 
        /// </summary>
        private decimal idcalculo_refat;
        [XmlElement(ElementName = "IDCALCULO_REFAT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,16)]
        public decimal Idcalculo_Refat
        {
            get { return  idcalculo_refat; }
            set {  idcalculo_refat = value; }
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
        /// Propriedade referente ao campo: IDMOTIVORETIF
        /// Comentário: 
        /// </summary>
        private decimal idmotivoretif;
        [XmlElement(ElementName = "IDMOTIVORETIF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idmotivoretif
        {
            get { return  idmotivoretif; }
            set {  idmotivoretif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDOUTRASCOBUC_REFAT
        /// Comentário: 
        /// </summary>
        private decimal idoutrascobuc_refat;
        [XmlElement(ElementName = "IDOUTRASCOBUC_REFAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Idoutrascobuc_Refat
        {
            get { return  idoutrascobuc_refat; }
            set {  idoutrascobuc_refat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDSEQGERDOC
        /// Comentário: 
        /// </summary>
        private decimal idseqgerdoc;
        [XmlElement(ElementName = "IDSEQGERDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Idseqgerdoc
        {
            get { return  idseqgerdoc; }
            set {  idseqgerdoc = value; }
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
        /// Propriedade referente ao campo: REFAT_INDEVIDO
        /// Comentário: 
        /// </summary>
        private string refat_indevido;
        [XmlElement(ElementName = "REFAT_INDEVIDO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Refat_Indevido
        {
            get { return  refat_indevido; }
            set {  refat_indevido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIO
        /// Comentário: 
        /// </summary>
        private string usuario;
        [XmlElement(ElementName = "USUARIO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Usuario
        {
            get { return  usuario; }
            set {  usuario = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Refaturamento()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "REFATURAMENTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Refaturamento> Listar(string where)
        {
            Persistencia ba = new Persistencia(Refaturamento.GetStringConnection());
            return ba.Listar<Refaturamento>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Refaturamento> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Refaturamento.GetStringConnection());
            return ba.Existe<Refaturamento>(where);
        }

        #endregion
    }
}

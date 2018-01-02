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
    /// Classe referente a tabela Fatura
    /// </summary>
    [XmlType("FATURA")]
    public class Fatura : OracleObjeto
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO_MES
        /// Coment�rio: 
        /// </summary>
        private DateTime? ano_mes;
        [XmlElement(ElementName = "ANO_MES", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Ano_Mes
        {
            get { return  ano_mes; }
            set {  ano_mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANO_MES_ORIGINAL
        /// Coment�rio: 
        /// </summary>
        private DateTime? ano_mes_original;
        [XmlElement(ElementName = "ANO_MES_ORIGINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Ano_Mes_Original
        {
            get { return  ano_mes_original; }
            set {  ano_mes_original = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APRESENTADA
        /// Coment�rio: 
        /// </summary>
        private string apresentada;
        [XmlElement(ElementName = "APRESENTADA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Apresentada
        {
            get { return  apresentada; }
            set {  apresentada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COBRAR_MULTA
        /// Coment�rio: 
        /// </summary>
        private string cobrar_multa;
        [XmlElement(ElementName = "COBRAR_MULTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Cobrar_Multa
        {
            get { return  cobrar_multa; }
            set {  cobrar_multa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_APRESENTACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? data_apresentacao;
        [XmlElement(ElementName = "DATA_APRESENTACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data_Apresentacao
        {
            get { return  data_apresentacao; }
            set {  data_apresentacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_EMISSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? data_emissao;
        [XmlElement(ElementName = "DATA_EMISSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data_Emissao
        {
            get { return  data_emissao; }
            set {  data_emissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPO
        /// Coment�rio: 
        /// </summary>
        private string grupo;
        [XmlElement(ElementName = "GRUPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Grupo
        {
            get { return  grupo; }
            set {  grupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDAGENTE
        /// Coment�rio: 
        /// </summary>
        private decimal idagente;
        [XmlElement(ElementName = "IDAGENTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idagente
        {
            get { return  idagente; }
            set {  idagente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDASSOCIADO
        /// Coment�rio: 
        /// </summary>
        private decimal idassociado;
        [XmlElement(ElementName = "IDASSOCIADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idassociado
        {
            get { return  idassociado; }
            set {  idassociado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCALCULO
        /// Coment�rio: 
        /// </summary>
        private decimal idcalculo;
        [XmlElement(ElementName = "IDCALCULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,16)]
        public decimal Idcalculo
        {
            get { return  idcalculo; }
            set {  idcalculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCFOP
        /// Coment�rio: 
        /// </summary>
        private decimal idcfop;
        [XmlElement(ElementName = "IDCFOP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idcfop
        {
            get { return  idcfop; }
            set {  idcfop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCLASSE
        /// Coment�rio: 
        /// </summary>
        private decimal idclasse;
        [XmlElement(ElementName = "IDCLASSE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idclasse
        {
            get { return  idclasse; }
            set {  idclasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCODFATURA
        /// Coment�rio: 
        /// </summary>
        private decimal idcodfatura;
        [XmlElement(ElementName = "IDCODFATURA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idcodfatura
        {
            get { return  idcodfatura; }
            set {  idcodfatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCONSUMIDOR
        /// Coment�rio: 
        /// </summary>
        private decimal idconsumidor;
        [XmlElement(ElementName = "IDCONSUMIDOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idconsumidor
        {
            get { return  idconsumidor; }
            set {  idconsumidor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDLOCALENTREGA
        /// Coment�rio: 
        /// </summary>
        private decimal idlocalentrega;
        [XmlElement(ElementName = "IDLOCALENTREGA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idlocalentrega
        {
            get { return  idlocalentrega; }
            set {  idlocalentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDREMESSA_EFI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: IDSUBCLASSE
        /// Coment�rio: 
        /// </summary>
        private decimal idsubclasse;
        [XmlElement(ElementName = "IDSUBCLASSE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idsubclasse
        {
            get { return  idsubclasse; }
            set {  idsubclasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDTARIFA
        /// Coment�rio: 
        /// </summary>
        private string idtarifa;
        [XmlElement(ElementName = "IDTARIFA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public string Idtarifa
        {
            get { return  idtarifa; }
            set {  idtarifa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDUC
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: MOTIVO_BAIXA
        /// Coment�rio: 
        /// </summary>
        private decimal motivo_baixa;
        [XmlElement(ElementName = "MOTIVO_BAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Motivo_Baixa
        {
            get { return  motivo_baixa; }
            set {  motivo_baixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO_FISCAL
        /// Coment�rio: 
        /// </summary>
        private decimal numero_fiscal;
        [XmlElement(ElementName = "NUMERO_FISCAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Numero_Fiscal
        {
            get { return  numero_fiscal; }
            set {  numero_fiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? pagto;
        [XmlElement(ElementName = "PAGTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Pagto
        {
            get { return  pagto; }
            set {  pagto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROCESSADA
        /// Coment�rio: 
        /// </summary>
        private string processada;
        [XmlElement(ElementName = "PROCESSADA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Processada
        {
            get { return  processada; }
            set {  processada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFATURAMENTO
        /// Coment�rio: 
        /// </summary>
        private decimal refaturamento;
        [XmlElement(ElementName = "REFATURAMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Refaturamento
        {
            get { return  refaturamento; }
            set {  refaturamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RETIFICADO
        /// Coment�rio: 
        /// </summary>
        private string retificado;
        [XmlElement(ElementName = "RETIFICADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Retificado
        {
            get { return  retificado; }
            set {  retificado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO_CALCULO
        /// Coment�rio: 
        /// </summary>
        private decimal tipo_calculo;
        [XmlElement(ElementName = "TIPO_CALCULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Tipo_Calculo
        {
            get { return  tipo_calculo; }
            set {  tipo_calculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR_TOTAL
        /// Coment�rio: 
        /// </summary>
        private decimal valor_total;
        [XmlElement(ElementName = "VALOR_TOTAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
        public decimal Valor_Total
        {
            get { return  valor_total; }
            set {  valor_total = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VCTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? vcto;
        [XmlElement(ElementName = "VCTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Vcto
        {
            get { return  vcto; }
            set {  vcto = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public Fatura()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "FATURA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<Fatura> Listar(string where)
        {
            Persistencia ba = new Persistencia(Fatura.GetStringConnection());
            return ba.Listar<Fatura>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<Fatura> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Fatura.GetStringConnection());
            return ba.Existe<Fatura>(where);
        }

        #endregion
    }
}

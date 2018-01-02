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
    /// Classe referente a tabela PCRazaocli
    /// </summary>
    [XmlType("PCRAZAOCLI")]
    public class PCRazaocli : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,12)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: 
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDANF
        /// Comentário: Número de Transação de Venda da Nota Fiscal
        /// </summary>
        private decimal numtransvendanf;
        [XmlElement(ElementName = "NUMTRANSVENDANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendanf
        {
            get { return  numtransvendanf; }
            set {  numtransvendanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Comentário: 
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOLANC
        /// Comentário: Tipo de lançamento: Nota Fiscal, Título de Crédito ou Devolução
        /// </summary>
        private string tipolanc;
        [XmlElement(ElementName = "TIPOLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipolanc
        {
            get { return  tipolanc; }
            set {  tipolanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINSDIF
        /// Comentário: Valor total da COFINS referente nota de saída para órgão público. (PROCESSO DIFERIMENTO DE PIS/COFINS)
        /// </summary>
        private decimal vlcofinsdif;
        [XmlElement(ElementName = "VLCOFINSDIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcofinsdif
        {
            get { return  vlcofinsdif; }
            set {  vlcofinsdif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDCOFINSDIF
        /// Comentário:  Valor total da COFINS referente nota de entrada vinculada a nota de saída para órgão público pelo PEPS (Rotina 1074). (PROCESSO DIFERIMENTO DE PIS/COFINS) 
        /// </summary>
        private decimal vlcredcofinsdif;
        [XmlElement(ElementName = "VLCREDCOFINSDIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredcofinsdif
        {
            get { return  vlcredcofinsdif; }
            set {  vlcredcofinsdif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDITO
        /// Comentário: 
        /// </summary>
        private decimal vlcredito;
        [XmlElement(ElementName = "VLCREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredito
        {
            get { return  vlcredito; }
            set {  vlcredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPISDIF
        /// Comentário: Valor total do PIS referente nota de entrada vinculada a nota de saída para órgão público pelo PEPS (Rotina 1074). (PROCESSO DIFERIMENTO DE PIS/COFINS) 
        /// </summary>
        private decimal vlcredpisdif;
        [XmlElement(ElementName = "VLCREDPISDIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredpisdif
        {
            get { return  vlcredpisdif; }
            set {  vlcredpisdif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEBITO
        /// Comentário: 
        /// </summary>
        private decimal vldebito;
        [XmlElement(ElementName = "VLDEBITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldebito
        {
            get { return  vldebito; }
            set {  vldebito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPISDIF
        /// Comentário: Valor total do PIS referente nota de saída para órgão público. (PROCESSO DIFERIMENTO DE PIS/COFINS)
        /// </summary>
        private decimal vlpisdif;
        [XmlElement(ElementName = "VLPISDIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpisdif
        {
            get { return  vlpisdif; }
            set {  vlpisdif = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRazaocli()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRAZAOCLI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRazaocli> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRazaocli>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRazaocli> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRazaocli>(where);
        }

        #endregion
    }
}

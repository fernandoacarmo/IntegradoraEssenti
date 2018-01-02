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
    /// Classe referente a tabela PCCiapitem
    /// </summary>
    [XmlType("PCCIAPITEM")]
    public class PCCiapitem : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: Ano apuração.
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APURADO
        /// Comentário: Indica se o item ja foi apurado.
        /// </summary>
        private string apurado;
        [XmlElement(ElementName = "APURADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Apurado
        {
            get { return  apurado; }
            set {  apurado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Cód. filial do item apurado.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODITEM
        /// Comentário: Código do item de apuração.
        /// </summary>
        private decimal coditem;
        [XmlElement(ElementName = "CODITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Coditem
        {
            get { return  coditem; }
            set {  coditem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do produto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSALDO
        /// Comentário: Código do saldo inivial vinculado.
        /// </summary>
        private decimal codsaldo;
        [XmlElement(ElementName = "CODSALDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsaldo
        {
            get { return  codsaldo; }
            set {  codsaldo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATABAIXA
        /// Comentário: Data Baixa CIAP
        /// </summary>
        private DateTime? databaixa;
        [XmlElement(ElementName = "DATABAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Databaixa
        {
            get { return  databaixa; }
            set {  databaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFINALCIAP
        /// Comentário: Data Final do Cálculo do CIAP
        /// </summary>
        private DateTime? datafinalciap;
        [XmlElement(ElementName = "DATAFINALCIAP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafinalciap
        {
            get { return  datafinalciap; }
            set {  datafinalciap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINICIOCIAP
        /// Comentário: Data de Início do cálculo do CIAP
        /// </summary>
        private DateTime? datainiciociap;
        [XmlElement(ElementName = "DATAINICIOCIAP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datainiciociap
        {
            get { return  datainiciociap; }
            set {  datainiciociap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATOR
        /// Comentário: Fator de aplicação.
        /// </summary>
        private string fator;
        [XmlElement(ElementName = "FATOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Fator
        {
            get { return  fator; }
            set {  fator = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Comentário: Mês apuração.
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: Numero da Transação de Entrada ou Saída
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: Numero de transação de entrada.
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: Numero de transação de saida.
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
        /// Propriedade referente ao campo: TIPOTRANSACAO
        /// Comentário: Tipo da Transação do Ativo Imobilizado
        /// </summary>
        private string tipotransacao;
        [XmlElement(ElementName = "TIPOTRANSACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipotransacao
        {
            get { return  tipotransacao; }
            set {  tipotransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASECREDITO
        /// Comentário: Valor Credito do CIAP.
        /// </summary>
        private decimal vlbasecredito;
        [XmlElement(ElementName = "VLBASECREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbasecredito
        {
            get { return  vlbasecredito; }
            set {  vlbasecredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDITO
        /// Comentário: Valor base do credito do CIAP.
        /// </summary>
        private decimal vlcredito;
        [XmlElement(ElementName = "VLCREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredito
        {
            get { return  vlcredito; }
            set {  vlcredito = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCiapitem()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCIAPITEM";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCiapitem> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCiapitem>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCiapitem> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCiapitem>(where);
        }

        #endregion
    }
}

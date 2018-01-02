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
    /// Classe referente a tabela PCBaixacartaoc
    /// </summary>
    [XmlType("PCBAIXACARTAOC")]
    public class PCBaixacartaoc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BANCOARQUIVO
        /// Comentário: Flag para identificar o banco do arquivo
        /// </summary>
        private string bancoarquivo;
        [XmlElement(ElementName = "BANCOARQUIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bancoarquivo
        {
            get { return  bancoarquivo; }
            set {  bancoarquivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBAIXACARTAO
        /// Comentário: Código da baixa
        /// </summary>
        private decimal codbaixacartao;
        [XmlElement(ElementName = "CODBAIXACARTAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codbaixacartao
        {
            get { return  codbaixacartao; }
            set {  codbaixacartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: Código do banco
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial
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
        /// Propriedade referente ao campo: CODMOEDA
        /// Comentário: Código da moeda
        /// </summary>
        private string codmoeda;
        [XmlElement(ElementName = "CODMOEDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codmoeda
        {
            get { return  codmoeda; }
            set {  codmoeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSURBAIXA
        /// Comentário: Código do usuário que realizou a baixa
        /// </summary>
        private decimal codusurbaixa;
        [XmlElement(ElementName = "CODUSURBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusurbaixa
        {
            get { return  codusurbaixa; }
            set {  codusurbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSURIMPORTACAO
        /// Comentário: Código do usuário que realizou a importação
        /// </summary>
        private decimal codusurimportacao;
        [XmlElement(ElementName = "CODUSURIMPORTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusurimportacao
        {
            get { return  codusurimportacao; }
            set {  codusurimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATABAIXA
        /// Comentário: Data da baixa do arquivo
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
        /// Propriedade referente ao campo: DATAIMPORTACAO
        /// Comentário: Data da importação do arquivo
        /// </summary>
        private DateTime? dataimportacao;
        [XmlElement(ElementName = "DATAIMPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataimportacao
        {
            get { return  dataimportacao; }
            set {  dataimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORABAIXA
        /// Comentário: Hora da baixa do arquivo
        /// </summary>
        private string horabaixa;
        [XmlElement(ElementName = "HORABAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Horabaixa
        {
            get { return  horabaixa; }
            set {  horabaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAIMPORTACAO
        /// Comentário: Hora da importação do arquivo
        /// </summary>
        private string horaimportacao;
        [XmlElement(ElementName = "HORAIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Horaimportacao
        {
            get { return  horaimportacao; }
            set {  horaimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEDOARQUIVO
        /// Comentário: Nome do arquivo
        /// </summary>
        private string nomedoarquivo;
        [XmlElement(ElementName = "NOMEDOARQUIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomedoarquivo
        {
            get { return  nomedoarquivo; }
            set {  nomedoarquivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMELAYOUT
        /// Comentário: Nome Layout baixa
        /// </summary>
        private string nomelayout;
        [XmlElement(ElementName = "NOMELAYOUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomelayout
        {
            get { return  nomelayout; }
            set {  nomelayout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Comentário: Número da transação na pcprest
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCBaixacartaoc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBAIXACARTAOC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBaixacartaoc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBaixacartaoc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCBaixacartaoc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBaixacartaoc>(where);
        }

        #endregion
    }
}

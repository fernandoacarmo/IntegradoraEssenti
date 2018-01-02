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
    /// Classe referente a tabela PCEstcrcompensacao
    /// </summary>
    [XmlType("PCESTCRCOMPENSACAO")]
    public class PCEstcrcompensacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: Ano do saldo por compensação
        /// </summary>
        private string ano;
        [XmlElement(ElementName = "ANO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: Código do banco do saldo por compensação
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
        /// Propriedade referente ao campo: CODMOEDA
        /// Comentário: Código da moeda do saldo por compensação
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
        /// Propriedade referente ao campo: DATASALDOINICIAL
        /// Comentário: Data do saldo inicial
        /// </summary>
        private DateTime? datasaldoinicial;
        [XmlElement(ElementName = "DATASALDOINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datasaldoinicial
        {
            get { return  datasaldoinicial; }
            set {  datasaldoinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Comentário: Mês do saldo por compensação
        /// </summary>
        private string mes;
        [XmlElement(ElementName = "MES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDO
        /// Comentário: Saldo final por compensação
        /// </summary>
        private decimal saldo;
        [XmlElement(ElementName = "SALDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Saldo
        {
            get { return  saldo; }
            set {  saldo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOINICIAL
        /// Comentário: Saldo inicial por compensação
        /// </summary>
        private decimal saldoinicial;
        [XmlElement(ElementName = "SALDOINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Saldoinicial
        {
            get { return  saldoinicial; }
            set {  saldoinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCREDITO
        /// Comentário: Valor de credito do saldo por compensação
        /// </summary>
        private decimal valorcredito;
        [XmlElement(ElementName = "VALORCREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcredito
        {
            get { return  valorcredito; }
            set {  valorcredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDEBITO
        /// Comentário: Valor de debito do saldo por compensação
        /// </summary>
        private decimal valordebito;
        [XmlElement(ElementName = "VALORDEBITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valordebito
        {
            get { return  valordebito; }
            set {  valordebito = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEstcrcompensacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCESTCRCOMPENSACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEstcrcompensacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEstcrcompensacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEstcrcompensacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEstcrcompensacao>(where);
        }

        #endregion
    }
}

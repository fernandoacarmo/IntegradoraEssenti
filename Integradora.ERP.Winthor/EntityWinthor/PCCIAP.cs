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
    /// Classe referente a tabela PCCiap
    /// </summary>
    [XmlType("PCCIAP")]
    public class PCCiap : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: Ano de Apuração.
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APURADO
        /// Comentário: Indica se foi apurado.
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
        /// Comentário: Cód.Filial da apuração.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRACAO
        /// Comentário: Valor da Fração.
        /// </summary>
        private string fracao;
        [XmlElement(ElementName = "FRACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public string Fracao
        {
            get { return  fracao; }
            set {  fracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Comentário: Mes de apuração.
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASECREDITO
        /// Comentário: Valor base para calculo.
        /// </summary>
        private decimal vlbasecredito;
        [XmlElement(ElementName = "VLBASECREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlbasecredito
        {
            get { return  vlbasecredito; }
            set {  vlbasecredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDITO
        /// Comentário: Valor do crédito.
        /// </summary>
        private decimal vlcredito;
        [XmlElement(ElementName = "VLCREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlcredito
        {
            get { return  vlcredito; }
            set {  vlcredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSAIDASTRIBUTADAS
        /// Comentário: Total das saídas tributadas.
        /// </summary>
        private decimal vlsaidastributadas;
        [XmlElement(ElementName = "VLSAIDASTRIBUTADAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlsaidastributadas
        {
            get { return  vlsaidastributadas; }
            set {  vlsaidastributadas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALSAIDAS
        /// Comentário: Total das saidas.
        /// </summary>
        private decimal vltotalsaidas;
        [XmlElement(ElementName = "VLTOTALSAIDAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vltotalsaidas
        {
            get { return  vltotalsaidas; }
            set {  vltotalsaidas = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCiap()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCIAP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCiap> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCiap>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCiap> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCiap>(where);
        }

        #endregion
    }
}

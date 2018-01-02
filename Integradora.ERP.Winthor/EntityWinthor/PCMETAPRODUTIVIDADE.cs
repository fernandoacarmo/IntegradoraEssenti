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
    /// Classe referente a tabela PCMetaprodutividade
    /// </summary>
    [XmlType("PCMETAPRODUTIVIDADE")]
    public class PCMetaprodutividade : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: Ano de referencia da meta
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
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Cód. Filial da meta cadastrada
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
        /// Propriedade referente ao campo: CODFUNCCANCELAMENTO
        /// Comentário: Cód. Do funcionario que cancelou a meta
        /// </summary>
        private decimal codfunccancelamento;
        [XmlElement(ElementName = "CODFUNCCANCELAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccancelamento
        {
            get { return  codfunccancelamento; }
            set {  codfunccancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMETAPRODUTIVIDADE
        /// Comentário: Cod. Meta de produtividade
        /// </summary>
        private decimal codmetaprodutividade;
        [XmlElement(ElementName = "CODMETAPRODUTIVIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codmetaprodutividade
        {
            get { return  codmetaprodutividade; }
            set {  codmetaprodutividade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCELAMENTO
        /// Comentário: Dt. De cancelamento da meta
        /// </summary>
        private DateTime? dtcancelamento;
        [XmlElement(ElementName = "DTCANCELAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancelamento
        {
            get { return  dtcancelamento; }
            set {  dtcancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Comentário: Mês de referencia da meta
        /// </summary>
        private string mes;
        [XmlElement(ElementName = "MES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMetaprodutividade()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMETAPRODUTIVIDADE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMetaprodutividade> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMetaprodutividade>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMetaprodutividade> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMetaprodutividade>(where);
        }

        #endregion
    }
}

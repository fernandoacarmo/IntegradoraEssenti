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
    /// Classe referente a tabela PCFeriadofiscal
    /// </summary>
    [XmlType("PCFERIADOFISCAL")]
    public class PCFeriadofiscal : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: ano
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Comentário: cidade feriado
        /// </summary>
        private decimal codcidade;
        [XmlElement(ElementName = "CODCIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcidade
        {
            get { return  codcidade; }
            set {  codcidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFERIADO
        /// Comentário: Codigo do feriado
        /// </summary>
        private decimal codferiado;
        [XmlElement(ElementName = "CODFERIADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codferiado
        {
            get { return  codferiado; }
            set {  codferiado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDTODOSANOS
        /// Comentário: considera todos os anos
        /// </summary>
        private string considtodosanos;
        [XmlElement(ElementName = "CONSIDTODOSANOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considtodosanos
        {
            get { return  considtodosanos; }
            set {  considtodosanos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCFERIADO
        /// Comentário: Descricao do feriado
        /// </summary>
        private string descferiado;
        [XmlElement(ElementName = "DESCFERIADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descferiado
        {
            get { return  descferiado; }
            set {  descferiado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIA
        /// Comentário: dia
        /// </summary>
        private decimal dia;
        [XmlElement(ElementName = "DIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Dia
        {
            get { return  dia; }
            set {  dia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Comentário: mês
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFERIADO
        /// Comentário: tipo feriado
        /// </summary>
        private string tipoferiado;
        [XmlElement(ElementName = "TIPOFERIADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoferiado
        {
            get { return  tipoferiado; }
            set {  tipoferiado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFFERIADO
        /// Comentário: uf feriado
        /// </summary>
        private string ufferiado;
        [XmlElement(ElementName = "UFFERIADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufferiado
        {
            get { return  ufferiado; }
            set {  ufferiado = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFeriadofiscal()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFERIADOFISCAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFeriadofiscal> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFeriadofiscal>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFeriadofiscal> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFeriadofiscal>(where);
        }

        #endregion
    }
}

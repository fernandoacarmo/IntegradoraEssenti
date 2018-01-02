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
        /// Coment�rio: ano
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
        /// Coment�rio: cidade feriado
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
        /// Coment�rio: Codigo do feriado
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
        /// Coment�rio: considera todos os anos
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
        /// Coment�rio: Descricao do feriado
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
        /// Coment�rio: dia
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
        /// Coment�rio: m�s
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
        /// Coment�rio: tipo feriado
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
        /// Coment�rio: uf feriado
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFeriadofiscal> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFeriadofiscal>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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

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
    /// Classe referente a tabela PCRelfiltroesp
    /// </summary>
    [XmlType("PCRELFILTROESP")]
    public class PCRelfiltroesp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILTRO
        /// Comentário: CÓDIGO DO FILTRO
        /// </summary>
        private decimal codfiltro;
        [XmlElement(ElementName = "CODFILTRO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfiltro
        {
            get { return  codfiltro; }
            set {  codfiltro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRELATORIO
        /// Comentário: CÓDIGO DO RELATORIO
        /// </summary>
        private decimal codrelatorio;
        [XmlElement(ElementName = "CODRELATORIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrelatorio
        {
            get { return  codrelatorio; }
            set {  codrelatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECAMPO
        /// Comentário: NOME DO CAMPO DA TABELA
        /// </summary>
        private string nomecampo;
        [XmlElement(ElementName = "NOMECAMPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomecampo
        {
            get { return  nomecampo; }
            set {  nomecampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERADOR
        /// Comentário: OPERADOR DA CLAUSULA WHERE
        /// </summary>
        private string operador;
        [XmlElement(ElementName = "OPERADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Operador
        {
            get { return  operador; }
            set {  operador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERADORLOGICO
        /// Comentário: OPERADOR LOGICO (AND, OR)
        /// </summary>
        private string operadorlogico;
        [XmlElement(ElementName = "OPERADORLOGICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Operadorlogico
        {
            get { return  operadorlogico; }
            set {  operadorlogico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Comentário: ORDEM DO FILTRO 
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: VALOR DO FILTRO REFERENTE AO CAMPO SELECIONADO
        /// </summary>
        private string valor;
        [XmlElement(ElementName = "VALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRelfiltroesp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRELFILTROESP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRelfiltroesp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRelfiltroesp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRelfiltroesp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRelfiltroesp>(where);
        }

        #endregion
    }
}

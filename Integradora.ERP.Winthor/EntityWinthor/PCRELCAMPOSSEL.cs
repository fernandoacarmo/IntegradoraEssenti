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
    /// Classe referente a tabela PCRelcampossel
    /// </summary>
    [XmlType("PCRELCAMPOSSEL")]
    public class PCRelcampossel : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCAMPO
        /// Comentário: Código do campo
        /// </summary>
        private decimal codcampo;
        [XmlElement(ElementName = "CODCAMPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcampo
        {
            get { return  codcampo; }
            set {  codcampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRELATORIO
        /// Comentário: Código do relatório
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
        /// Propriedade referente ao campo: FUNCAO
        /// Comentário: Função de agrupamento dos campos
        /// </summary>
        private string funcao;
        [XmlElement(ElementName = "FUNCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Funcao
        {
            get { return  funcao; }
            set {  funcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECAMPO
        /// Comentário: Nome do campo da tabela
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
        /// Propriedade referente ao campo: ORDEM
        /// Comentário: Ordem dos campos que irão sair no relatorio
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRelcampossel()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRELCAMPOSSEL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRelcampossel> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRelcampossel>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRelcampossel> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRelcampossel>(where);
        }

        #endregion
    }
}

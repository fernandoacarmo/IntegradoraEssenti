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
    /// Classe referente a tabela PCLayoutbaixacred
    /// </summary>
    [XmlType("PCLAYOUTBAIXACRED")]
    public class PCLayoutbaixacred : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Código do layout
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DELIMITADOR
        /// Comentário: Caracter delimitador
        /// </summary>
        private string delimitador;
        [XmlElement(ElementName = "DELIMITADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Delimitador
        {
            get { return  delimitador; }
            set {  delimitador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição do layout
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEM
        /// Comentário: Campo indica o valor aceito na diferença durante a baixa automatica
        /// </summary>
        private decimal margem;
        [XmlElement(ElementName = "MARGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Margem
        {
            get { return  margem; }
            set {  margem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODADO
        /// Comentário: Define o tipo de dados CSV ou TXT
        /// </summary>
        private string tipodado;
        [XmlElement(ElementName = "TIPODADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodado
        {
            get { return  tipodado; }
            set {  tipodado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAO
        /// Comentário: Versão do arquivo
        /// </summary>
        private string versao;
        [XmlElement(ElementName = "VERSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Versao
        {
            get { return  versao; }
            set {  versao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLayoutbaixacred()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLAYOUTBAIXACRED";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLayoutbaixacred> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLayoutbaixacred>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLayoutbaixacred> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLayoutbaixacred>(where);
        }

        #endregion
    }
}

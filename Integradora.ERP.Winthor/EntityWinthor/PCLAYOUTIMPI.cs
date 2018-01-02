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
    /// Classe referente a tabela PCLayoutimpi
    /// </summary>
    [XmlType("PCLAYOUTIMPI")]
    public class PCLayoutimpi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAMPO
        /// Comentário: Campo para armazenar o nome do campo a ser utilizado.
        /// </summary>
        private string campo;
        [XmlElement(ElementName = "CAMPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Campo
        {
            get { return  campo; }
            set {  campo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLAYOUTIMP
        /// Comentário: Campo para identificar os layouts.
        /// </summary>
        private decimal codlayoutimp;
        [XmlElement(ElementName = "CODLAYOUTIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codlayoutimp
        {
            get { return  codlayoutimp; }
            set {  codlayoutimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRITERIO
        /// Comentário: Campo para armazenar a expressão para ser utilizada como critério de importação do registro.
        /// </summary>
        private string criterio;
        [XmlElement(ElementName = "CRITERIO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Criterio
        {
            get { return  criterio; }
            set {  criterio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDENTIFICADORSECAO
        /// Comentário: Campo para armazenar o separador a ser utilizado na importação.
        /// </summary>
        private string identificadorsecao;
        [XmlElement(ElementName = "IDENTIFICADORSECAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Identificadorsecao
        {
            get { return  identificadorsecao; }
            set {  identificadorsecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MASCARALEITURA
        /// Comentário: Campo para máscara a ser utilizada na leitura do campo.
        /// </summary>
        private string mascaraleitura;
        [XmlElement(ElementName = "MASCARALEITURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Mascaraleitura
        {
            get { return  mascaraleitura; }
            set {  mascaraleitura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Comentário: Campo para armazenar a ordem da string a ser importada.
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TABELA
        /// Comentário: Campo para armazenar o nome da tabela a ser utilizada.
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Tabela
        {
            get { return  tabela; }
            set {  tabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAMANHO
        /// Comentário: Campo para armazenar o tamanho da string a ser importada.
        /// </summary>
        private decimal tamanho;
        [XmlElement(ElementName = "TAMANHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Tamanho
        {
            get { return  tamanho; }
            set {  tamanho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALOR
        /// Comentário: Campo para indicar o tipo do valor. D-Data, T-Texto e N-Número.
        /// </summary>
        private string tipovalor;
        [XmlElement(ElementName = "TIPOVALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalor
        {
            get { return  tipovalor; }
            set {  tipovalor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLayoutimpi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLAYOUTIMPI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLayoutimpi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLayoutimpi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLayoutimpi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLayoutimpi>(where);
        }

        #endregion
    }
}

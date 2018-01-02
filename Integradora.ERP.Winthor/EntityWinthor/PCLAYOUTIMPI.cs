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
        /// Coment�rio: Campo para armazenar o nome do campo a ser utilizado.
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
        /// Coment�rio: Campo para identificar os layouts.
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
        /// Coment�rio: Campo para armazenar a express�o para ser utilizada como crit�rio de importa��o do registro.
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
        /// Coment�rio: Campo para armazenar o separador a ser utilizado na importa��o.
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
        /// Coment�rio: Campo para m�scara a ser utilizada na leitura do campo.
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
        /// Coment�rio: Campo para armazenar a ordem da string a ser importada.
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
        /// Coment�rio: Campo para armazenar o nome da tabela a ser utilizada.
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
        /// Coment�rio: Campo para armazenar o tamanho da string a ser importada.
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
        /// Coment�rio: Campo para indicar o tipo do valor. D-Data, T-Texto e N-N�mero.
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCLayoutimpi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLayoutimpi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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

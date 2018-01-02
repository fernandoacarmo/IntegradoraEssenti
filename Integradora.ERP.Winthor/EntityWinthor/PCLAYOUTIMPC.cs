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
    /// Classe referente a tabela PCLayoutimpc
    /// </summary>
    [XmlType("PCLAYOUTIMPC")]
    public class PCLayoutimpc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Campo seqüencial para identificar os layouts
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Campo para armazenar a descrição do layout.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDENTIFICACAOCAMPO
        /// Comentário: Campo para indicar o tipo da identificação dos campos: 0-Por Separador e 1-Por Tamanho.
        /// </summary>
        private decimal identificacaocampo;
        [XmlElement(ElementName = "IDENTIFICACAOCAMPO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Identificacaocampo
        {
            get { return  identificacaocampo; }
            set {  identificacaocampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEARQUIVO
        /// Comentário: Campo para armazenar o nome do arquivo a ser importado.
        /// </summary>
        private string nomearquivo;
        [XmlElement(ElementName = "NOMEARQUIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomearquivo
        {
            get { return  nomearquivo; }
            set {  nomearquivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARADOR
        /// Comentário: Campo para armazenar o separador a ser utilizado na importação.
        /// </summary>
        private string separador;
        [XmlElement(ElementName = "SEPARADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separador
        {
            get { return  separador; }
            set {  separador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAMANHOIDENTIFICADORSECAO
        /// Comentário: Campo para armazenar o tamanho do campo de identificação das seções.
        /// </summary>
        private decimal tamanhoidentificadorsecao;
        [XmlElement(ElementName = "TAMANHOIDENTIFICADORSECAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Tamanhoidentificadorsecao
        {
            get { return  tamanhoidentificadorsecao; }
            set {  tamanhoidentificadorsecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOIMPORTACAO
        /// Comentário: Campo para indicar o tipo da importação. F-Força de Vendas, R-Rede de cliente e C-Conciliação de cartão
        /// </summary>
        private string tipoimportacao;
        [XmlElement(ElementName = "TIPOIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoimportacao
        {
            get { return  tipoimportacao; }
            set {  tipoimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOLEITURA
        /// Comentário: Campo para indicar o tipo de leitura do arquivo: 0-Tipo de Registro e 1-Conteúdo fixo.
        /// </summary>
        private decimal tipoleitura;
        [XmlElement(ElementName = "TIPOLEITURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipoleitura
        {
            get { return  tipoleitura; }
            set {  tipoleitura = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLayoutimpc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLAYOUTIMPC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLayoutimpc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLayoutimpc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLayoutimpc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLayoutimpc>(where);
        }

        #endregion
    }
}

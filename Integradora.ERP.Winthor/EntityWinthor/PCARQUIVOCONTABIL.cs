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
    /// Classe referente a tabela PCArquivocontabil
    /// </summary>
    [XmlType("PCARQUIVOCONTABIL")]
    public class PCArquivocontabil : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODARQCONT
        /// Comentário: Indica código de controle do arquivo.
        /// </summary>
        private decimal codarqcont;
        [XmlElement(ElementName = "CODARQCONT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codarqcont
        {
            get { return  codarqcont; }
            set {  codarqcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Cód. Da filial.
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Nome do arquivo gerado.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGERACAO
        /// Comentário: Data da geracao do arquivo.
        /// </summary>
        private DateTime? dtgeracao;
        [XmlElement(ElementName = "DTGERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgeracao
        {
            get { return  dtgeracao; }
            set {  dtgeracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAGERACAO
        /// Comentário: Horário em que foi gerado o arquivo.
        /// </summary>
        private string horageracao;
        [XmlElement(ElementName = "HORAGERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Horageracao
        {
            get { return  horageracao; }
            set {  horageracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFIM
        /// Comentário: Periodo final que foi escolhido para geração do arquivo.
        /// </summary>
        private DateTime? perfim;
        [XmlElement(ElementName = "PERFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Perfim
        {
            get { return  perfim; }
            set {  perfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERINI
        /// Comentário: Periodo inicial que foi escolhido para geração do arquivo.
        /// </summary>
        private DateTime? perini;
        [XmlElement(ElementName = "PERINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Perini
        {
            get { return  perini; }
            set {  perini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGISTRO
        /// Comentário: Arquivo gerado.
        /// </summary>
        private string registro;
        [XmlElement(ElementName = "REGISTRO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Registro
        {
            get { return  registro; }
            set {  registro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA
        /// Comentário: Rotina do Winthor que foi gerado o arquivo.
        /// </summary>
        private string rotina;
        [XmlElement(ElementName = "ROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Rotina
        {
            get { return  rotina; }
            set {  rotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOARQ
        /// Comentário: Tipo do Arquivo.
        /// </summary>
        private string tipoarq;
        [XmlElement(ElementName = "TIPOARQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoarq
        {
            get { return  tipoarq; }
            set {  tipoarq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOESCRITURACAO
        /// Comentário: Indica qual a forma de escrituração foi gerada.
        /// </summary>
        private string tipoescrituracao;
        [XmlElement(ElementName = "TIPOESCRITURACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoescrituracao
        {
            get { return  tipoescrituracao; }
            set {  tipoescrituracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAO
        /// Comentário: Qual a versão da rotina que gerou o arquivo.
        /// </summary>
        private string versao;
        [XmlElement(ElementName = "VERSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
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
        public PCArquivocontabil()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCARQUIVOCONTABIL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCArquivocontabil> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCArquivocontabil>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCArquivocontabil> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCArquivocontabil>(where);
        }

        #endregion
    }
}

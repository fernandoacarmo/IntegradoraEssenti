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
    /// Classe referente a tabela PCDoci
    /// </summary>
    [XmlType("PCDOCI")]
    public class PCDoci : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODDOC
        /// Comentário: 
        /// </summary>
        private decimal coddoc;
        [XmlElement(ElementName = "CODDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddoc
        {
            get { return  coddoc; }
            set {  coddoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: 
        /// </summary>
        private string codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public string Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNA
        /// Comentário: 
        /// </summary>
        private decimal coluna;
        [XmlElement(ElementName = "COLUNA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Coluna
        {
            get { return  coluna; }
            set {  coluna = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DECIMAIS
        /// Comentário: 
        /// </summary>
        private decimal decimais;
        [XmlElement(ElementName = "DECIMAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Decimais
        {
            get { return  decimais; }
            set {  decimais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LINHA
        /// Comentário: 
        /// </summary>
        private decimal linha;
        [XmlElement(ElementName = "LINHA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Linha
        {
            get { return  linha; }
            set {  linha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SECAO
        /// Comentário: 
        /// </summary>
        private string secao;
        [XmlElement(ElementName = "SECAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Secao
        {
            get { return  secao; }
            set {  secao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAMANHO
        /// Comentário: 
        /// </summary>
        private decimal tamanho;
        [XmlElement(ElementName = "TAMANHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Tamanho
        {
            get { return  tamanho; }
            set {  tamanho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEXTO
        /// Comentário: 
        /// </summary>
        private string texto;
        [XmlElement(ElementName = "TEXTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Texto
        {
            get { return  texto; }
            set {  texto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCAMPO
        /// Comentário: 
        /// </summary>
        private string tipocampo;
        [XmlElement(ElementName = "TIPOCAMPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocampo
        {
            get { return  tipocampo; }
            set {  tipocampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOC
        /// Comentário: 
        /// </summary>
        private string tipodoc;
        [XmlElement(ElementName = "TIPODOC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public string Tipodoc
        {
            get { return  tipodoc; }
            set {  tipodoc = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDoci()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDOCI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDoci> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDoci>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDoci> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDoci>(where);
        }

        #endregion
    }
}

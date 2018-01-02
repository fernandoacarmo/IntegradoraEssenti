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
    /// Classe referente a tabela PCSerasa_registro
    /// </summary>
    [XmlType("PCSERASA_REGISTRO")]
    public class PCSerasa_registro : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Coment�rio: C�digo interno da consulta
        /// </summary>
        private decimal id;
        [XmlElement(ElementName = "ID", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Id
        {
            get { return  id; }
            set {  id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LINHA
        /// Coment�rio: Linha do arquivo importada
        /// </summary>
        private string linha;
        [XmlElement(ElementName = "LINHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Linha
        {
            get { return  linha; }
            set {  linha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_CAMPO
        /// Coment�rio: Descri��o do campo
        /// </summary>
        private string nome_campo;
        [XmlElement(ElementName = "NOME_CAMPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,400)]
        public string Nome_Campo
        {
            get { return  nome_campo; }
            set {  nome_campo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_TIPO
        /// Coment�rio: Tipo de informa��o do layout
        /// </summary>
        private string nome_tipo;
        [XmlElement(ElementName = "NOME_TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nome_Tipo
        {
            get { return  nome_tipo; }
            set {  nome_tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQ_NOME
        /// Coment�rio: Sequencial do campo no layout
        /// </summary>
        private string seq_nome;
        [XmlElement(ElementName = "SEQ_NOME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Seq_Nome
        {
            get { return  seq_nome; }
            set {  seq_nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQ_TIPO
        /// Coment�rio: Sequencial interno
        /// </summary>
        private decimal seq_tipo;
        [XmlElement(ElementName = "SEQ_TIPO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Seq_Tipo
        {
            get { return  seq_tipo; }
            set {  seq_tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: Tipo do layout
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR_CAMPO
        /// Coment�rio: Valor importado
        /// </summary>
        private string valor_campo;
        [XmlElement(ElementName = "VALOR_CAMPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,400)]
        public string Valor_Campo
        {
            get { return  valor_campo; }
            set {  valor_campo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCSerasa_registro()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSERASA_REGISTRO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCSerasa_registro> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSerasa_registro>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCSerasa_registro> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSerasa_registro>(where);
        }

        #endregion
    }
}

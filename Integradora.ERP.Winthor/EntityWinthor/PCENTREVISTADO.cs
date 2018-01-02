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
    /// Classe referente a tabela PCEntrevistado
    /// </summary>
    [XmlType("PCENTREVISTADO")]
    public class PCEntrevistado : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPESQUISA
        /// Coment�rio: 
        /// </summary>
        private decimal codpesquisa;
        [XmlElement(ElementName = "CODPESQUISA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codpesquisa
        {
            get { return  codpesquisa; }
            set {  codpesquisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATO
        /// Coment�rio: 
        /// </summary>
        private string contato;
        [XmlElement(ElementName = "CONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Contato
        {
            get { return  contato; }
            set {  contato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAENTREVISTA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataentrevista;
        [XmlElement(ElementName = "DATAENTREVISTA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dataentrevista
        {
            get { return  dataentrevista; }
            set {  dataentrevista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATASELECIONADA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataselecionada;
        [XmlElement(ElementName = "DATASELECIONADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataselecionada
        {
            get { return  dataselecionada; }
            set {  dataselecionada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULAENTREVISTOU
        /// Coment�rio: 
        /// </summary>
        private decimal matriculaentrevistou;
        [XmlElement(ElementName = "MATRICULAENTREVISTOU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matriculaentrevistou
        {
            get { return  matriculaentrevistou; }
            set {  matriculaentrevistou = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULASELECIONOU
        /// Coment�rio: 
        /// </summary>
        private decimal matriculaselecionou;
        [XmlElement(ElementName = "MATRICULASELECIONOU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matriculaselecionou
        {
            get { return  matriculaselecionou; }
            set {  matriculaselecionou = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OCUPACAO
        /// Coment�rio: 
        /// </summary>
        private string ocupacao;
        [XmlElement(ElementName = "OCUPACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Ocupacao
        {
            get { return  ocupacao; }
            set {  ocupacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Coment�rio: 
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEntrevistado()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCENTREVISTADO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEntrevistado> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEntrevistado>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEntrevistado> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEntrevistado>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCDicionarioitemcep
    /// </summary>
    [XmlType("PCDICIONARIOITEMCEP")]
    public class PCDicionarioitemcep : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAMPOBAIRRO
        /// Comentário: 
        /// </summary>
        private string campobairro;
        [XmlElement(ElementName = "CAMPOBAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Campobairro
        {
            get { return  campobairro; }
            set {  campobairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMPOCEP
        /// Comentário: 
        /// </summary>
        private string campocep;
        [XmlElement(ElementName = "CAMPOCEP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Campocep
        {
            get { return  campocep; }
            set {  campocep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMPOCIDADE
        /// Comentário: 
        /// </summary>
        private string campocidade;
        [XmlElement(ElementName = "CAMPOCIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Campocidade
        {
            get { return  campocidade; }
            set {  campocidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMPOCODCIDADE
        /// Comentário: 
        /// </summary>
        private string campocodcidade;
        [XmlElement(ElementName = "CAMPOCODCIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Campocodcidade
        {
            get { return  campocodcidade; }
            set {  campocodcidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMPOCODIBGE
        /// Comentário: 
        /// </summary>
        private string campocodibge;
        [XmlElement(ElementName = "CAMPOCODIBGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Campocodibge
        {
            get { return  campocodibge; }
            set {  campocodibge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMPOLOGRADOURO
        /// Comentário: 
        /// </summary>
        private string campologradouro;
        [XmlElement(ElementName = "CAMPOLOGRADOURO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Campologradouro
        {
            get { return  campologradouro; }
            set {  campologradouro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMPOUF
        /// Comentário: 
        /// </summary>
        private string campouf;
        [XmlElement(ElementName = "CAMPOUF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Campouf
        {
            get { return  campouf; }
            set {  campouf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FOREIGN
        /// Comentário: 
        /// </summary>
        private string foreign;
        [XmlElement(ElementName = "FOREIGN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Foreign
        {
            get { return  foreign; }
            set {  foreign = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEOBJETO
        /// Comentário: 
        /// </summary>
        private string nomeobjeto;
        [XmlElement(ElementName = "NOMEOBJETO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Nomeobjeto
        {
            get { return  nomeobjeto; }
            set {  nomeobjeto = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDicionarioitemcep()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDICIONARIOITEMCEP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDicionarioitemcep> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDicionarioitemcep>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDicionarioitemcep> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDicionarioitemcep>(where);
        }

        #endregion
    }
}

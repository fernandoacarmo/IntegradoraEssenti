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
    /// Classe referente a tabela PCSintegra
    /// </summary>
    [XmlType("PCSINTEGRA")]
    public class PCSintegra : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA1
        /// Comentário: 
        /// </summary>
        private DateTime? data1;
        [XmlElement(ElementName = "DATA1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data1
        {
            get { return  data1; }
            set {  data1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA2
        /// Comentário: 
        /// </summary>
        private DateTime? data2;
        [XmlElement(ElementName = "DATA2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data2
        {
            get { return  data2; }
            set {  data2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGERA
        /// Comentário: 
        /// </summary>
        private DateTime? dtgera;
        [XmlElement(ElementName = "DTGERA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgera
        {
            get { return  dtgera; }
            set {  dtgera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LINHA
        /// Comentário: 
        /// </summary>
        private string linha;
        [XmlElement(ElementName = "LINHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Linha
        {
            get { return  linha; }
            set {  linha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA
        /// Comentário: 
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
        /// Propriedade referente ao campo: VERSAO
        /// Comentário: 
        /// </summary>
        private string versao;
        [XmlElement(ElementName = "VERSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
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
        public PCSintegra()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSINTEGRA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSintegra> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSintegra>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSintegra> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSintegra>(where);
        }

        #endregion
    }
}

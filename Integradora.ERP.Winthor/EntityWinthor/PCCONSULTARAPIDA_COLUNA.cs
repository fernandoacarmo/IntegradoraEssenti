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
    /// Classe referente a tabela PCConsultarapida_coluna
    /// </summary>
    [XmlType("PCCONSULTARAPIDA_COLUNA")]
    public class PCConsultarapida_coluna : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAMPO
        /// Comentário: 
        /// </summary>
        private string campo;
        [XmlElement(ElementName = "CAMPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Campo
        {
            get { return  campo; }
            set {  campo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONSULTARAPIDA
        /// Comentário: 
        /// </summary>
        private decimal codconsultarapida;
        [XmlElement(ElementName = "CODCONSULTARAPIDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codconsultarapida
        {
            get { return  codconsultarapida; }
            set {  codconsultarapida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EORDENAVEL
        /// Comentário: 
        /// </summary>
        private string eordenavel;
        [XmlElement(ElementName = "EORDENAVEL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Eordenavel
        {
            get { return  eordenavel; }
            set {  eordenavel = value; }
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
        /// Propriedade referente ao campo: TITULO
        /// Comentário: 
        /// </summary>
        private string titulo;
        [XmlElement(ElementName = "TITULO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Titulo
        {
            get { return  titulo; }
            set {  titulo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConsultarapida_coluna()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONSULTARAPIDA_COLUNA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConsultarapida_coluna> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConsultarapida_coluna>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConsultarapida_coluna> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConsultarapida_coluna>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCMenscfop
    /// </summary>
    [XmlType("PCMENSCFOP")]
    public class PCMenscfop : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: 
        /// </summary>
        private decimal codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEM
        /// Comentário: 
        /// </summary>
        private string mensagem;
        [XmlElement(ElementName = "MENSAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Mensagem
        {
            get { return  mensagem; }
            set {  mensagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFFILIAL
        /// Comentário: 
        /// </summary>
        private string uffilial;
        [XmlElement(ElementName = "UFFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Uffilial
        {
            get { return  uffilial; }
            set {  uffilial = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMenscfop()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMENSCFOP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMenscfop> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMenscfop>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMenscfop> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMenscfop>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCLib
    /// </summary>
    [XmlType("PCLIB")]
    public class PCLib : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Comentário: 
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC_LIB
        /// Comentário: 
        /// </summary>
        private decimal codfunc_lib;
        [XmlElement(ElementName = "CODFUNC_LIB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc_Lib
        {
            get { return  codfunc_lib; }
            set {  codfunc_lib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOA
        /// Comentário: Código do cadastro.
        /// </summary>
        private string codigoa;
        [XmlElement(ElementName = "CODIGOA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codigoa
        {
            get { return  codigoa; }
            set {  codigoa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGON
        /// Comentário: 
        /// </summary>
        private decimal codigon;
        [XmlElement(ElementName = "CODIGON", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codigon
        {
            get { return  codigon; }
            set {  codigon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTABELA
        /// Comentário: 
        /// </summary>
        private decimal codtabela;
        [XmlElement(ElementName = "CODTABELA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codtabela
        {
            get { return  codtabela; }
            set {  codtabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_LIB
        /// Comentário: 
        /// </summary>
        private DateTime? data_lib;
        [XmlElement(ElementName = "DATA_LIB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data_Lib
        {
            get { return  data_lib; }
            set {  data_lib = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLib()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLIB";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLib> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLib>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLib> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLib>(where);
        }

        #endregion
    }
}

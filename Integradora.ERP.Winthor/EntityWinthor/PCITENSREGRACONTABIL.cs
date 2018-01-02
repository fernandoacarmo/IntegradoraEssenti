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
    /// Classe referente a tabela PCItensregracontabil
    /// </summary>
    [XmlType("PCITENSREGRACONTABIL")]
    public class PCItensregracontabil : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALLANCTO
        /// Coment�rio: Define qual ser� a filial � qual ser� atribuida o lan�amento cont�bil na contabiliza��o.
        /// </summary>
        private string codfiliallancto;
        [XmlElement(ElementName = "CODFILIALLANCTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Codfiliallancto
        {
            get { return  codfiliallancto; }
            set {  codfiliallancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHISTORICO
        /// Coment�rio: Indica o c�digo do hist�rico.
        /// </summary>
        private decimal codhistorico;
        [XmlElement(ElementName = "CODHISTORICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codhistorico
        {
            get { return  codhistorico; }
            set {  codhistorico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDUZIDO_PC
        /// Coment�rio: Indica o c�digo reduzido da conta cont�bil.
        /// </summary>
        private string codreduzido_pc;
        [XmlElement(ElementName = "CODREDUZIDO_PC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codreduzido_Pc
        {
            get { return  codreduzido_pc; }
            set {  codreduzido_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREGRA
        /// Coment�rio: Indica o c�digo controle.
        /// </summary>
        private decimal codregra;
        [XmlElement(ElementName = "CODREGRA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codregra
        {
            get { return  codregra; }
            set {  codregra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMULAS
        /// Coment�rio: Indica o f�rmula para contabiliza��o.
        /// </summary>
        private string formulas;
        [XmlElement(ElementName = "FORMULAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Formulas
        {
            get { return  formulas; }
            set {  formulas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTCOMPLREGRA
        /// Coment�rio: Indica o hist�rico complementar.
        /// </summary>
        private string histcomplregra;
        [XmlElement(ElementName = "HISTCOMPLREGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Histcomplregra
        {
            get { return  histcomplregra; }
            set {  histcomplregra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZA
        /// Coment�rio: Indica o natureza da contabilizacao.
        /// </summary>
        private string natureza;
        [XmlElement(ElementName = "NATUREZA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Natureza
        {
            get { return  natureza; }
            set {  natureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALIZAVALOR
        /// Coment�rio: Indica se o valor ser� totalizado.
        /// </summary>
        private string totalizavalor;
        [XmlElement(ElementName = "TOTALIZAVALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Totalizavalor
        {
            get { return  totalizavalor; }
            set {  totalizavalor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCItensregracontabil()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCITENSREGRACONTABIL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCItensregracontabil> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCItensregracontabil>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCItensregracontabil> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCItensregracontabil>(where);
        }

        #endregion
    }
}

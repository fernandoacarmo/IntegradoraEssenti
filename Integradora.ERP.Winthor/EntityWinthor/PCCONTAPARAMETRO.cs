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
    /// Classe referente a tabela PCContaparametro
    /// </summary>
    [XmlType("PCCONTAPARAMETRO")]
    public class PCContaparametro : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGOPARAMETRO
        /// Coment�rio: Indica c�digo de controle do arquivo.
        /// </summary>
        private decimal codigoparametro;
        [XmlElement(ElementName = "CODIGOPARAMETRO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Codigoparametro
        {
            get { return  codigoparametro; }
            set {  codigoparametro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Coment�rio: Indica o plano de contas.
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDUZIDO_PC
        /// Coment�rio: Indica o c�digo reduzido de uma conta contabil.
        /// </summary>
        private string codreduzido_pc;
        [XmlElement(ElementName = "CODREDUZIDO_PC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codreduzido_Pc
        {
            get { return  codreduzido_pc; }
            set {  codreduzido_pc = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCContaparametro()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTAPARAMETRO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCContaparametro> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContaparametro>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCContaparametro> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContaparametro>(where);
        }

        #endregion
    }
}

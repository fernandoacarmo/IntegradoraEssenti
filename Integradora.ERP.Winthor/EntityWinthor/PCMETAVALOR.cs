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
    /// Classe referente a tabela PCMetavalor
    /// </summary>
    [XmlType("PCMETAVALOR")]
    public class PCMetavalor : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMETAPRODUTIVIDADE
        /// Coment�rio: C�d. da produtividade que meta est� relacionada
        /// </summary>
        private decimal codmetaprodutividade;
        [XmlElement(ElementName = "CODMETAPRODUTIVIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmetaprodutividade
        {
            get { return  codmetaprodutividade; }
            set {  codmetaprodutividade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMETAVALOR
        /// Coment�rio: C�d. oo valor da meta cadastrada.
        /// </summary>
        private decimal codmetavalor;
        [XmlElement(ElementName = "CODMETAVALOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codmetavalor
        {
            get { return  codmetavalor; }
            set {  codmetavalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: Tipo de meta
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLAPAGAR
        /// Coment�rio: Valor a pagar
        /// </summary>
        private decimal vlapagar;
        [XmlElement(ElementName = "VLAPAGAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Vlapagar
        {
            get { return  vlapagar; }
            set {  vlapagar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFINAL
        /// Coment�rio: Valor final
        /// </summary>
        private decimal vlfinal;
        [XmlElement(ElementName = "VLFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Vlfinal
        {
            get { return  vlfinal; }
            set {  vlfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLINICIAL
        /// Coment�rio: Valor inicial
        /// </summary>
        private decimal vlinicial;
        [XmlElement(ElementName = "VLINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Vlinicial
        {
            get { return  vlinicial; }
            set {  vlinicial = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMetavalor()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMETAVALOR";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMetavalor> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMetavalor>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMetavalor> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMetavalor>(where);
        }

        #endregion
    }
}

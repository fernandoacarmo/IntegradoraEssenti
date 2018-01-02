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
    /// Classe referente a tabela PCCidadefornec
    /// </summary>
    [XmlType("PCCIDADEFORNEC")]
    public class PCCidadefornec : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: Indica o c�digo do fornecedor.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMUNICIPIO
        /// Coment�rio: Indica o c�digo da cidade.
        /// </summary>
        private decimal codmunicipio;
        [XmlElement(ElementName = "CODMUNICIPIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codmunicipio
        {
            get { return  codmunicipio; }
            set {  codmunicipio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMUNICIPIOFORNEC
        /// Coment�rio: Indica valor que representa rela��o entra cidade e fornecedor.
        /// </summary>
        private string codmunicipiofornec;
        [XmlElement(ElementName = "CODMUNICIPIOFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codmunicipiofornec
        {
            get { return  codmunicipiofornec; }
            set {  codmunicipiofornec = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCidadefornec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCIDADEFORNEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCidadefornec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCidadefornec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCidadefornec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCidadefornec>(where);
        }

        #endregion
    }
}

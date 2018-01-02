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
    /// Classe referente a tabela PCProdutocertific
    /// </summary>
    [XmlType("PCPRODUTOCERTIFIC")]
    public class PCProdutocertific : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ARQUIVO
        /// Coment�rio: Caminho do certificado
        /// </summary>
        private string arquivo;
        [XmlElement(ElementName = "ARQUIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,400)]
        public string Arquivo
        {
            get { return  arquivo; }
            set {  arquivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODCERTIFIC
        /// Coment�rio: Indentificador do registro
        /// </summary>
        private decimal codprodcertific;
        [XmlElement(ElementName = "CODPRODCERTIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Codprodcertific
        {
            get { return  codprodcertific; }
            set {  codprodcertific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: Data de altera��o
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: N�mero do lote
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCProdutocertific()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODUTOCERTIFIC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCProdutocertific> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdutocertific>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCProdutocertific> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdutocertific>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCDanoneondamov
    /// </summary>
    [XmlType("PCDANONEONDAMOV")]
    public class PCDanoneondamov : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEQUIPAMENTO
        /// Coment�rio: C�digo do equipamento
        /// </summary>
        private string codequipamento;
        [XmlElement(ElementName = "CODEQUIPAMENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,30)]
        public string Codequipamento
        {
            get { return  codequipamento; }
            set {  codequipamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFAB
        /// Coment�rio: C�digo de f�brica do produto
        /// </summary>
        private string codfab;
        [XmlElement(ElementName = "CODFAB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Codfab
        {
            get { return  codfab; }
            set {  codfab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODONDA
        /// Coment�rio: C�digo da Onda
        /// </summary>
        private string codonda;
        [XmlElement(ElementName = "CODONDA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Codonda
        {
            get { return  codonda; }
            set {  codonda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIVRO
        /// Coment�rio: Livro definido pela Danone
        /// </summary>
        private string livro;
        [XmlElement(ElementName = "LIVRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Livro
        {
            get { return  livro; }
            set {  livro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: Quantidade
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDanoneondamov()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDANONEONDAMOV";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDanoneondamov> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDanoneondamov>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDanoneondamov> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDanoneondamov>(where);
        }

        #endregion
    }
}

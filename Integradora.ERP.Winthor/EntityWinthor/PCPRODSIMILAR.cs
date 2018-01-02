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
    /// Classe referente a tabela PCProdsimilar
    /// </summary>
    [XmlType("PCPRODSIMILAR")]
    public class PCProdsimilar : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial .
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
        /// Propriedade referente ao campo: CODPRODMASTER
        /// Coment�rio: C�digo do Produto Master.
        /// </summary>
        private decimal codprodmaster;
        [XmlElement(ElementName = "CODPRODMASTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodmaster
        {
            get { return  codprodmaster; }
            set {  codprodmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODPRINCIPAL
        /// Coment�rio: C�digo do Produto Principal.
        /// </summary>
        private decimal codprodprincipal;
        [XmlElement(ElementName = "CODPRODPRINCIPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodprincipal
        {
            get { return  codprodprincipal; }
            set {  codprodprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODSIMILAR
        /// Coment�rio: C�digo do Produto Similar.
        /// </summary>
        private decimal codprodsimilar;
        [XmlElement(ElementName = "CODPRODSIMILAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodsimilar
        {
            get { return  codprodsimilar; }
            set {  codprodsimilar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORDEM
        /// Coment�rio: Define a prioridade da produ��o no caso de troca de Mat�ria Prima.
        /// </summary>
        private decimal numordem;
        [XmlElement(ElementName = "NUMORDEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numordem
        {
            get { return  numordem; }
            set {  numordem = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCProdsimilar()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODSIMILAR";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCProdsimilar> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdsimilar>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCProdsimilar> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdsimilar>(where);
        }

        #endregion
    }
}

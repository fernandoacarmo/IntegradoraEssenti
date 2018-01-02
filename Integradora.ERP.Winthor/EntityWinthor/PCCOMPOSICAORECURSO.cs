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
    /// Classe referente a tabela PCComposicaorecurso
    /// </summary>
    [XmlType("PCCOMPOSICAORECURSO")]
    public class PCComposicaorecurso : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Refere-se ao c�digo da filial da composi��o.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODMASTER
        /// Coment�rio: C�digo do produto a ser produzido.
        /// </summary>
        private decimal codprodmaster;
        [XmlElement(ElementName = "CODPRODMASTER", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprodmaster
        {
            get { return  codprodmaster; }
            set {  codprodmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDRECURSO
        /// Coment�rio: Refere-se ao c�digo do recurso de produ��o.
        /// </summary>
        private decimal idrecurso;
        [XmlElement(ElementName = "IDRECURSO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Idrecurso
        {
            get { return  idrecurso; }
            set {  idrecurso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METODO
        /// Coment�rio: M�todo de formula��o do produto formulado.
        /// </summary>
        private string metodo;
        [XmlElement(ElementName = "METODO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public string Metodo
        {
            get { return  metodo; }
            set {  metodo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRECURSO
        /// Coment�rio: Quantidade de recurso utilizado na produ��o.
        /// </summary>
        private decimal qtrecurso;
        [XmlElement(ElementName = "QTRECURSO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Qtrecurso
        {
            get { return  qtrecurso; }
            set {  qtrecurso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAETAPA
        /// Coment�rio: Define se o recurso ser� contabilizado na produ��o.
        /// </summary>
        private string utilizaetapa;
        [XmlElement(ElementName = "UTILIZAETAPA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Utilizaetapa
        {
            get { return  utilizaetapa; }
            set {  utilizaetapa = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCComposicaorecurso()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMPOSICAORECURSO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCComposicaorecurso> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComposicaorecurso>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCComposicaorecurso> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComposicaorecurso>(where);
        }

        #endregion
    }
}

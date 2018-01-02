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
    /// Classe referente a tabela PCEtaparecurso
    /// </summary>
    [XmlType("PCETAPARECURSO")]
    public class PCEtaparecurso : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODETAPA
        /// Comentário: Código da etapa da produção.
        /// </summary>
        private decimal codetapa;
        [XmlElement(ElementName = "CODETAPA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codetapa
        {
            get { return  codetapa; }
            set {  codetapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial.
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
        /// Comentário: Código do produto master da produção.
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
        /// Comentário: Código do recurso da produção.
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
        /// Comentário: Método de produção do produto master.
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
        /// Propriedade referente ao campo: SEQUENCIAETAPA
        /// Comentário: Sequencia da etapa na produção.
        /// </summary>
        private decimal sequenciaetapa;
        [XmlElement(ElementName = "SEQUENCIAETAPA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Sequenciaetapa
        {
            get { return  sequenciaetapa; }
            set {  sequenciaetapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPOPREVISTO
        /// Comentário: Tempo previsto de duração da etapa.
        /// </summary>
        private decimal tempoprevisto;
        [XmlElement(ElementName = "TEMPOPREVISTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Tempoprevisto
        {
            get { return  tempoprevisto; }
            set {  tempoprevisto = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEtaparecurso()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCETAPARECURSO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEtaparecurso> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEtaparecurso>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEtaparecurso> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEtaparecurso>(where);
        }

        #endregion
    }
}

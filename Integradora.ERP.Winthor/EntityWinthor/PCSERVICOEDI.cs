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
    /// Classe referente a tabela PCServicoedi
    /// </summary>
    [XmlType("PCSERVICOEDI")]
    public class PCServicoedi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGRUPAFILIAL
        /// Coment�rio: Agrupar Filial (S/N).
        /// </summary>
        private string agrupafilial;
        [XmlElement(ElementName = "AGRUPAFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agrupafilial
        {
            get { return  agrupafilial; }
            set {  agrupafilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALPRINCIP
        /// Coment�rio: C�digo da Filial Principal.
        /// </summary>
        private string codfilialprincip;
        [XmlElement(ElementName = "CODFILIALPRINCIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialprincip
        {
            get { return  codfilialprincip; }
            set {  codfilialprincip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSERVICOEDI
        /// Coment�rio: C�digo do Servi�o de EDI
        /// </summary>
        private decimal codservicoedi;
        [XmlElement(ElementName = "CODSERVICOEDI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codservicoedi
        {
            get { return  codservicoedi; }
            set {  codservicoedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPO
        /// Coment�rio: Grupo
        /// </summary>
        private string grupo;
        [XmlElement(ElementName = "GRUPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Grupo
        {
            get { return  grupo; }
            set {  grupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMESERVICOEDI
        /// Coment�rio: Nome do Servi�o
        /// </summary>
        private string nomeservicoedi;
        [XmlElement(ElementName = "NOMESERVICOEDI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Nomeservicoedi
        {
            get { return  nomeservicoedi; }
            set {  nomeservicoedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSERVICO
        /// Coment�rio: Tipo de Servi�o
        /// </summary>
        private decimal tiposervico;
        [XmlElement(ElementName = "TIPOSERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Tiposervico
        {
            get { return  tiposervico; }
            set {  tiposervico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ULTSEQARQ
        /// Coment�rio: �ltima Sequ�ncia do Arquivo
        /// </summary>
        private decimal ultseqarq;
        [XmlElement(ElementName = "ULTSEQARQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Ultseqarq
        {
            get { return  ultseqarq; }
            set {  ultseqarq = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCServicoedi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSERVICOEDI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCServicoedi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCServicoedi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCServicoedi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCServicoedi>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCDemonstrativoctb
    /// </summary>
    [XmlType("PCDEMONSTRATIVOCTB")]
    public class PCDemonstrativoctb : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODDEMONST
        /// Coment�rio: Campo chave que identifica o demonstrativo. 
        /// </summary>
        private decimal coddemonst;
        [XmlElement(ElementName = "CODDEMONST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Coddemonst
        {
            get { return  coddemonst; }
            set {  coddemonst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Campo que descreve o demonstrativo. 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DFC
        /// Coment�rio: Compor DFC.
        /// </summary>
        private string dfc;
        [XmlElement(ElementName = "DFC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dfc
        {
            get { return  dfc; }
            set {  dfc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORNEGATIVOEXIBIR
        /// Coment�rio: Campo que identifica se valores negativos dever�o exibir sinal negativo ou entre par�nteses. 
        /// </summary>
        private string valornegativoexibir;
        [XmlElement(ElementName = "VALORNEGATIVOEXIBIR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Valornegativoexibir
        {
            get { return  valornegativoexibir; }
            set {  valornegativoexibir = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDemonstrativoctb()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDEMONSTRATIVOCTB";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDemonstrativoctb> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDemonstrativoctb>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDemonstrativoctb> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDemonstrativoctb>(where);
        }

        #endregion
    }
}

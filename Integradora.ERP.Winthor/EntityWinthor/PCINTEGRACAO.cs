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
    /// Classe referente a tabela PCIntegracao
    /// </summary>
    [XmlType("PCINTEGRACAO")]
    public class PCIntegracao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCATE
        /// Coment�rio: Indica a m�scara que ser� concatenada ao nome do arquivo.
        /// </summary>
        private string concate;
        [XmlElement(ElementName = "CONCATE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Concate
        {
            get { return  concate; }
            set {  concate = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEARQUIVO
        /// Coment�rio: 
        /// </summary>
        private string nomearquivo;
        [XmlElement(ElementName = "NOMEARQUIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Nomearquivo
        {
            get { return  nomearquivo; }
            set {  nomearquivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADESCNOMEARQ
        /// Coment�rio: Indica descri��o do nome do arquivo.
        /// </summary>
        private string usadescnomearq;
        [XmlElement(ElementName = "USADESCNOMEARQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadescnomearq
        {
            get { return  usadescnomearq; }
            set {  usadescnomearq = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCIntegracao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINTEGRACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCIntegracao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCIntegracao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCIntegracao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCIntegracao>(where);
        }

        #endregion
    }
}

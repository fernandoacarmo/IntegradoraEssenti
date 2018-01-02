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
    /// Classe referente a tabela PCCobecf
    /// </summary>
    [XmlType("PCCOBECF")]
    public class PCCobecf : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERADORACARTAO
        /// Comentário: Campo para armazenar o código da operadora de cartão associada à cobrança.
        /// </summary>
        private string codoperadoracartao;
        [XmlElement(ElementName = "CODOPERADORACARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codoperadoracartao
        {
            get { return  codoperadoracartao; }
            set {  codoperadoracartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARCELA
        /// Comentário: 
        /// </summary>
        private decimal parcela;
        [XmlElement(ElementName = "PARCELA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Parcela
        {
            get { return  parcela; }
            set {  parcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERJUROS
        /// Comentário: 
        /// </summary>
        private decimal perjuros;
        [XmlElement(ElementName = "PERJUROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perjuros
        {
            get { return  perjuros; }
            set {  perjuros = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCobecf()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOBECF";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCobecf> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCobecf>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCobecf> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCobecf>(where);
        }

        #endregion
    }
}

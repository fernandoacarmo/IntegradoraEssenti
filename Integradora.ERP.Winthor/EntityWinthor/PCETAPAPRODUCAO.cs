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
    /// Classe referente a tabela PCEtapaproducao
    /// </summary>
    [XmlType("PCETAPAPRODUCAO")]
    public class PCEtapaproducao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODETAPA
        /// Comentário: código da etapa da produção.
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição da etapa de produção.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBRIGATORIA
        /// Comentário: Obrigatoriedade da etapa de produção.
        /// </summary>
        private string obrigatoria;
        [XmlElement(ElementName = "OBRIGATORIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Obrigatoria
        {
            get { return  obrigatoria; }
            set {  obrigatoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: Status da etapa de produção.
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEtapaproducao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCETAPAPRODUCAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEtapaproducao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEtapaproducao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEtapaproducao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEtapaproducao>(where);
        }

        #endregion
    }
}

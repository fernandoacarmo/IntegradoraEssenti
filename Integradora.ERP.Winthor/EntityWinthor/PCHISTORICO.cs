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
    /// Classe referente a tabela PCHistorico
    /// </summary>
    [XmlType("PCHISTORICO")]
    public class PCHistorico : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODHISTORICO
        /// Comentário: Indica o código do histórico.
        /// </summary>
        private decimal codhistorico;
        [XmlElement(ElementName = "CODHISTORICO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codhistorico
        {
            get { return  codhistorico; }
            set {  codhistorico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_HISTORICO
        /// Comentário: 
        /// </summary>
        private string nome_historico;
        [XmlElement(ElementName = "NOME_HISTORICO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,80)]
        public string Nome_Historico
        {
            get { return  nome_historico; }
            set {  nome_historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITIR_INFOCOMPL
        /// Comentário: 
        /// </summary>
        private string permitir_infocompl;
        [XmlElement(ElementName = "PERMITIR_INFOCOMPL", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Permitir_Infocompl
        {
            get { return  permitir_infocompl; }
            set {  permitir_infocompl = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCHistorico()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCHISTORICO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCHistorico> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCHistorico>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCHistorico> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCHistorico>(where);
        }

        #endregion
    }
}

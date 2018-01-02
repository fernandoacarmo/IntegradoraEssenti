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
    /// Classe referente a tabela PCFluxo_simulacao
    /// </summary>
    [XmlType("PCFLUXO_SIMULACAO")]
    public class PCFluxo_simulacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DATAEMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dataemissao;
        [XmlElement(ElementName = "DATAEMISSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dataemissao
        {
            get { return  dataemissao; }
            set {  dataemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLAPAGAR
        /// Comentário: 
        /// </summary>
        private decimal vlapagar;
        [XmlElement(ElementName = "VLAPAGAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal Vlapagar
        {
            get { return  vlapagar; }
            set {  vlapagar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLARECEBER
        /// Comentário: 
        /// </summary>
        private decimal vlareceber;
        [XmlElement(ElementName = "VLARECEBER", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal Vlareceber
        {
            get { return  vlareceber; }
            set {  vlareceber = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFluxo_simulacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFLUXO_SIMULACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFluxo_simulacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFluxo_simulacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFluxo_simulacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFluxo_simulacao>(where);
        }

        #endregion
    }
}

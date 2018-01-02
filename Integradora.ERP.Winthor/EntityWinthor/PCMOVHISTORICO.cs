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
    /// Classe referente a tabela PCMovhistorico
    /// </summary>
    [XmlType("PCMOVHISTORICO")]
    public class PCMovhistorico : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CESTABASICALEGIS
        /// Comentário: Cesta Básica - Legislação
        /// </summary>
        private string cestabasicalegis;
        [XmlElement(ElementName = "CESTABASICALEGIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cestabasicalegis
        {
            get { return  cestabasicalegis; }
            set {  cestabasicalegis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSHISTORICO
        /// Comentário: Número Transação Histórico Movimentação
        /// </summary>
        private decimal numtranshistorico;
        [XmlElement(ElementName = "NUMTRANSHISTORICO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,18)]
        public decimal Numtranshistorico
        {
            get { return  numtranshistorico; }
            set {  numtranshistorico = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMovhistorico()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVHISTORICO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMovhistorico> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovhistorico>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMovhistorico> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovhistorico>(where);
        }

        #endregion
    }
}

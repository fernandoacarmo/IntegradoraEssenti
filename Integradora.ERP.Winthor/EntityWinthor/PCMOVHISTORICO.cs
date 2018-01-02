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
        /// Coment�rio: Cesta B�sica - Legisla��o
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
        /// Coment�rio: N�mero Transa��o Hist�rico Movimenta��o
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMovhistorico> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovhistorico>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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

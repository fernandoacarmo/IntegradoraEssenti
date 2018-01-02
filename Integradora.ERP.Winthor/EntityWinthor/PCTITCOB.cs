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
    /// Classe referente a tabela PCTitcob
    /// </summary>
    [XmlType("PCTITCOB")]
    public class PCTitcob : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: IDCOB
        /// Coment�rio: Recebe o identificador da cobran�a.
        /// </summary>
        private decimal idcob;
        [XmlElement(ElementName = "IDCOB", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Idcob
        {
            get { return  idcob; }
            set {  idcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDTITULO
        /// Coment�rio: Recebe o identificador da cobran�a.
        /// </summary>
        private decimal idtitulo;
        [XmlElement(ElementName = "IDTITULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Idtitulo
        {
            get { return  idtitulo; }
            set {  idtitulo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCTitcob()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTITCOB";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCTitcob> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTitcob>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCTitcob> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTitcob>(where);
        }

        #endregion
    }
}

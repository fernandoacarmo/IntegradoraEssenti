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
    /// Classe referente a tabela PCAgendapedcomprai
    /// </summary>
    [XmlType("PCAGENDAPEDCOMPRAI")]
    public class PCAgendapedcomprai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODUSURULTALT
        /// Coment�rio: C�digo do usu�rio altera��o
        /// </summary>
        private decimal codusurultalt;
        [XmlElement(ElementName = "CODUSURULTALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusurultalt
        {
            get { return  codusurultalt; }
            set {  codusurultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAULTALT
        /// Coment�rio: Data da altera��o
        /// </summary>
        private DateTime? dataultalt;
        [XmlElement(ElementName = "DATAULTALT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataultalt
        {
            get { return  dataultalt; }
            set {  dataultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Coment�rio: N�mero Identifica��o do Agendamento
        /// </summary>
        private decimal id;
        [XmlElement(ElementName = "ID", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Id
        {
            get { return  id; }
            set {  id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: N�mero do pedido de compra
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAgendapedcomprai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAGENDAPEDCOMPRAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAgendapedcomprai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAgendapedcomprai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAgendapedcomprai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAgendapedcomprai>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCServicoedimarca
    /// </summary>
    [XmlType("PCSERVICOEDIMARCA")]
    public class PCServicoedimarca : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMARCA
        /// Coment�rio: C�digo da Marca
        /// </summary>
        private decimal codmarca;
        [XmlElement(ElementName = "CODMARCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codmarca
        {
            get { return  codmarca; }
            set {  codmarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSERVICOEDI
        /// Coment�rio: C�digo do Servi�o de EDI
        /// </summary>
        private decimal codservicoedi;
        [XmlElement(ElementName = "CODSERVICOEDI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codservicoedi
        {
            get { return  codservicoedi; }
            set {  codservicoedi = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCServicoedimarca()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSERVICOEDIMARCA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCServicoedimarca> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCServicoedimarca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCServicoedimarca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCServicoedimarca>(where);
        }

        #endregion
    }
}

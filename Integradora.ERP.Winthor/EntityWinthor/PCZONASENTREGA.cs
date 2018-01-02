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
    /// Classe referente a tabela PCZonasentrega
    /// </summary>
    [XmlType("PCZONASENTREGA")]
    public class PCZonasentrega : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODZONAENTREGA
        /// Coment�rio: C�digo da Zona de Entrega
        /// </summary>
        private decimal codzonaentrega;
        [XmlElement(ElementName = "CODZONAENTREGA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Codzonaentrega
        {
            get { return  codzonaentrega; }
            set {  codzonaentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DSCZONAENTREGA
        /// Coment�rio: Descri��o da Zona de Entrega
        /// </summary>
        private string dsczonaentrega;
        [XmlElement(ElementName = "DSCZONAENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Dsczonaentrega
        {
            get { return  dsczonaentrega; }
            set {  dsczonaentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAUMENTOVLCALCULADO
        /// Coment�rio: Percentual do Aumento do Valor Calculado
        /// </summary>
        private decimal percaumentovlcalculado;
        [XmlElement(ElementName = "PERCAUMENTOVLCALCULADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Percaumentovlcalculado
        {
            get { return  percaumentovlcalculado; }
            set {  percaumentovlcalculado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCZonasentrega()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCZONASENTREGA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCZonasentrega> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCZonasentrega>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCZonasentrega> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCZonasentrega>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCFilialcteestado
    /// </summary>
    [XmlType("PCFILIALCTEESTADO")]
    public class PCFilialcteestado : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCTE
        /// Comentário: Código do CTE
        /// </summary>
        private decimal codcte;
        [XmlElement(ElementName = "CODCTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codcte
        {
            get { return  codcte; }
            set {  codcte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCTE
        /// Comentário: Próximo número CTE
        /// </summary>
        private decimal numcte;
        [XmlElement(ElementName = "NUMCTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcte
        {
            get { return  numcte; }
            set {  numcte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIECTE
        /// Comentário: Série CTE
        /// </summary>
        private string seriecte;
        [XmlElement(ElementName = "SERIECTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Seriecte
        {
            get { return  seriecte; }
            set {  seriecte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Comentário: Estado da CTE
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFilialcteestado()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFILIALCTEESTADO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFilialcteestado> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFilialcteestado>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFilialcteestado> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFilialcteestado>(where);
        }

        #endregion
    }
}

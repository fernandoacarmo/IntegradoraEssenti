using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a view Esvvtexestoque
    /// </summary>
    [XmlType("ESVVTEXESTOQUE")]
    public class Esvvtexestoque : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public string Codfilial
        {
            get { return codfilial; }
            set { codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codprod
        {
            get { return codprod; }
            set { codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTOQUE
        /// Comentário: 
        /// </summary>
        private decimal qtestoque;
        [XmlElement(ElementName = "QTESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtestoque
        {
            get { return qtestoque; }
            set { qtestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VTEXWAREHOUSE
        /// Comentário: 
        /// </summary>
        private string vtexwarehouse;
        [XmlElement(ElementName = "VTEXWAREHOUSE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 10)]
        public string Vtexwarehouse
        {
            get { return vtexwarehouse; }
            set { vtexwarehouse = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: DTULTIMOBALANCO
        /// Comentário: 
        /// </summary>
        private DateTime dtultimobalanco;
        [XmlElement(ElementName = "DTULTIMOBALANCO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 10)]
        public DateTime Dtultimobalanco
        {
            get { return dtultimobalanco; }
            set { dtultimobalanco = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esvvtexestoque()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVVTEXESTOQUE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvvtexestoque> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvvtexestoque.GetStringConnection());
            return ba.Listar<Esvvtexestoque>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvvtexestoque> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvvtexestoque.GetStringConnection());
            return ba.Existe<Esvvtexestoque>(where);
        }

        #endregion
    }
}

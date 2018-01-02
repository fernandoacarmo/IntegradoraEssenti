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
    /// Classe referente a tabela Esvcomboativos
    /// </summary>
    [XmlType("ESVCOMBOATIVOS")]
    public class Esvcomboativos : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIARCOMBO
        /// Comentário: 
        /// </summary>
        private decimal codauxiliarcombo;
        [XmlElement(ElementName = "CODAUXILIARCOMBO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public decimal Codauxiliarcombo
        {
            get { return  codauxiliarcombo; }
            set {  codauxiliarcombo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIARITEM
        /// Comentário: 
        /// </summary>
        private decimal codauxiliaritem;
        [XmlElement(ElementName = "CODAUXILIARITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public decimal Codauxiliaritem
        {
            get { return  codauxiliaritem; }
            set {  codauxiliaritem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOMBO
        /// Comentário: 
        /// </summary>
        private decimal codcombo;
        [XmlElement(ElementName = "CODCOMBO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcombo
        {
            get { return  codcombo; }
            set {  codcombo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODITEM
        /// Comentário: 
        /// </summary>
        private decimal codproditem;
        [XmlElement(ElementName = "CODPRODITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codproditem
        {
            get { return  codproditem; }
            set {  codproditem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCONTO
        /// Comentário: 
        /// </summary>
        private decimal percdesconto;
        [XmlElement(ElementName = "PERCDESCONTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Percdesconto
        {
            get { return  percdesconto; }
            set {  percdesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDACOMBO
        /// Comentário: 
        /// </summary>
        private decimal pvendacombo;
        [XmlElement(ElementName = "PVENDACOMBO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Pvendacombo
        {
            get { return  pvendacombo; }
            set {  pvendacombo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAITEM
        /// Comentário: 
        /// </summary>
        private decimal pvendaitem;
        [XmlElement(ElementName = "PVENDAITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Pvendaitem
        {
            get { return  pvendaitem; }
            set {  pvendaitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADE
        /// Comentário: 
        /// </summary>
        private decimal quantidade;
        [XmlElement(ElementName = "QUANTIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Quantidade
        {
            get { return  quantidade; }
            set {  quantidade = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esvcomboativos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVCOMBOATIVOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvcomboativos> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvcomboativos.GetStringConnection());
            return ba.Listar<Esvcomboativos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvcomboativos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvcomboativos.GetStringConnection());
            return ba.Existe<Esvcomboativos>(where);
        }

        #endregion
    }
}

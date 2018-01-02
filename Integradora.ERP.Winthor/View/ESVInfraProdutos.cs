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
    /// Classe referente a tabela Esvinfraprodutos
    /// </summary>
    [XmlType("ESVINFRAPRODUTOS")]
    public class ESVInfraProdutos : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
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
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Comentário: 
        /// </summary>
        private string id;
        [XmlElement(ElementName = "ID", DataType = "ROWID", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Id
        {
            get { return  id; }
            set {  id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODUTO
        /// Comentário: 
        /// </summary>
        private string produto;
        [XmlElement(ElementName = "PRODUTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Produto
        {
            get { return  produto; }
            set {  produto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA1
        /// Comentário: 
        /// </summary>
        private decimal pvenda1;
        [XmlElement(ElementName = "PVENDA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda1
        {
            get { return  pvenda1; }
            set {  pvenda1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA2
        /// Comentário: 
        /// </summary>
        private decimal pvenda2;
        [XmlElement(ElementName = "PVENDA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda2
        {
            get { return  pvenda2; }
            set {  pvenda2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA3
        /// Comentário: 
        /// </summary>
        private decimal pvenda3;
        [XmlElement(ElementName = "PVENDA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda3
        {
            get { return  pvenda3; }
            set {  pvenda3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA4
        /// Comentário: 
        /// </summary>
        private decimal pvenda4;
        [XmlElement(ElementName = "PVENDA4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda4
        {
            get { return  pvenda4; }
            set {  pvenda4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA5
        /// Comentário: 
        /// </summary>
        private decimal pvenda5;
        [XmlElement(ElementName = "PVENDA5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda5
        {
            get { return  pvenda5; }
            set {  pvenda5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA6
        /// Comentário: 
        /// </summary>
        private decimal pvenda6;
        [XmlElement(ElementName = "PVENDA6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda6
        {
            get { return  pvenda6; }
            set {  pvenda6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA7
        /// Comentário: 
        /// </summary>
        private decimal pvenda7;
        [XmlElement(ElementName = "PVENDA7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda7
        {
            get { return  pvenda7; }
            set {  pvenda7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDISPONIVEL
        /// Comentário: 
        /// </summary>
        private decimal qtdisponivel;
        [XmlElement(ElementName = "QTDISPONIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtdisponivel
        {
            get { return  qtdisponivel; }
            set {  qtdisponivel = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESVInfraProdutos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVINFRAPRODUTOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESVInfraProdutos> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESVInfraProdutos.GetStringConnection());
            return ba.Listar<ESVInfraProdutos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESVInfraProdutos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESVInfraProdutos.GetStringConnection());
            return ba.Existe<ESVInfraProdutos>(where);
        }

        #endregion
    }
}

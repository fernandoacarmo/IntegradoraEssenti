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
    /// Classe referente a tabela PCOfertaprogramadai
    /// </summary>
    [XmlType("PCOFERTAPROGRAMADAI")]
    public class PCOfertaprogramadai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Código da Embalagem.
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da Filial.
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
        /// Propriedade referente ao campo: CODITEM
        /// Comentário: Código do Item.
        /// </summary>
        private decimal coditem;
        [XmlElement(ElementName = "CODITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Coditem
        {
            get { return  coditem; }
            set {  coditem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOFERTA
        /// Comentário: Código da Oferta.
        /// </summary>
        private decimal codoferta;
        [XmlElement(ElementName = "CODOFERTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codoferta
        {
            get { return  codoferta; }
            set {  codoferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOFERTAORIG
        /// Comentário: Códito da oferta a qual o item obteve o preço
        /// </summary>
        private decimal codofertaorig;
        [XmlElement(ElementName = "CODOFERTAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codofertaorig
        {
            get { return  codofertaorig; }
            set {  codofertaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOETIQ
        /// Comentário: Data da emissão de etiqueta da oferta.
        /// </summary>
        private DateTime? dtemissaoetiq;
        [XmlElement(ElementName = "DTEMISSAOETIQ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaoetiq
        {
            get { return  dtemissaoetiq; }
            set {  dtemissaoetiq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOOFERTA
        /// Comentário: Motivo da oferta
        /// </summary>
        private string motivooferta;
        [XmlElement(ElementName = "MOTIVOOFERTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Motivooferta
        {
            get { return  motivooferta; }
            set {  motivooferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXVENDA
        /// Comentário: Quantidade máxima do item em oferta para cada cupom fiscal
        /// </summary>
        private decimal qtmaxvenda;
        [XmlElement(ElementName = "QTMAXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtmaxvenda
        {
            get { return  qtmaxvenda; }
            set {  qtmaxvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOFERTA
        /// Comentário: Valor da oferta.
        /// </summary>
        private decimal vloferta;
        [XmlElement(ElementName = "VLOFERTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloferta
        {
            get { return  vloferta; }
            set {  vloferta = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCOfertaprogramadai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCOFERTAPROGRAMADAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCOfertaprogramadai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOfertaprogramadai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCOfertaprogramadai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOfertaprogramadai>(where);
        }

        #endregion
    }
}

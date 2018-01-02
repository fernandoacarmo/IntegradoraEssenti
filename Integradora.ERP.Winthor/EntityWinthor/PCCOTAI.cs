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
    /// Classe referente a tabela PCCotai
    /// </summary>
    [XmlType("PCCOTAI")]
    public class PCCotai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Código auxiliar da embalagem que foi cotada.
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
        /// Propriedade referente ao campo: CODCONCOR
        /// Comentário: 
        /// </summary>
        private string codconcor;
        [XmlElement(ElementName = "CODCONCOR", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public string Codconcor
        {
            get { return  codconcor; }
            set {  codconcor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial que foi realizado a cotação.
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
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Comentário: 
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal custofin;
        [XmlElement(ElementName = "CUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofin
        {
            get { return  custofin; }
            set {  custofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREAL
        /// Comentário: 
        /// </summary>
        private decimal custoreal;
        [XmlElement(ElementName = "CUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoreal
        {
            get { return  custoreal; }
            set {  custoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENT
        /// Comentário: 
        /// </summary>
        private decimal custoultent;
        [XmlElement(ElementName = "CUSTOULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultent
        {
            get { return  custoultent; }
            set {  custoultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALANC
        /// Comentário: 
        /// </summary>
        private DateTime? datalanc;
        [XmlElement(ElementName = "DATALANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datalanc
        {
            get { return  datalanc; }
            set {  datalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPESQUISA
        /// Comentário: 
        /// </summary>
        private decimal numpesquisa;
        [XmlElement(ElementName = "NUMPESQUISA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpesquisa
        {
            get { return  numpesquisa; }
            set {  numpesquisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: 
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNIT
        /// Comentário: 
        /// </summary>
        private decimal punit;
        [XmlElement(ElementName = "PUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Punit
        {
            get { return  punit; }
            set {  punit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNITATAC
        /// Comentário: Preço de atacado na cotação
        /// </summary>
        private decimal punitatac;
        [XmlElement(ElementName = "PUNITATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Punitatac
        {
            get { return  punitatac; }
            set {  punitatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAEMBALAGEM
        /// Comentário: Preço de venda atual da embalagem do produto.
        /// </summary>
        private decimal pvendaembalagem;
        [XmlElement(ElementName = "PVENDAEMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaembalagem
        {
            get { return  pvendaembalagem; }
            set {  pvendaembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAPRODUTO
        /// Comentário: Preço de venda atual do produto.
        /// </summary>
        private decimal pvendaproduto;
        [XmlElement(ElementName = "PVENDAPRODUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaproduto
        {
            get { return  pvendaproduto; }
            set {  pvendaproduto = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCotai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOTAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCotai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCotai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCotai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCotai>(where);
        }

        #endregion
    }
}

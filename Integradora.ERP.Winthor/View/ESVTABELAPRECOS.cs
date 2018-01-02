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
    /// Classe referente a tabela Esvtabelaprecos
    /// </summary>
    [XmlType("ESVTABELAPRECOS")]
    public class Esvtabelaprecos : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Coment�rio: 
        /// </summary>
        private decimal codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMPRESA
        /// Coment�rio: 
        /// </summary>
        private string codempresa;
        [XmlElement(ElementName = "CODEMPRESA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codempresa
        {
            get { return  codempresa; }
            set {  codempresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAGAMENTO
        /// Coment�rio: 
        /// </summary>
        private decimal codpagamento;
        [XmlElement(ElementName = "CODPAGAMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codpagamento
        {
            get { return  codpagamento; }
            set {  codpagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Coment�rio: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Coment�rio: 
        /// </summary>
        private decimal codproduto;
        [XmlElement(ElementName = "CODPRODUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codproduto
        {
            get { return  codproduto; }
            set {  codproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODST
        /// Coment�rio: 
        /// </summary>
        private decimal codst;
        [XmlElement(ElementName = "CODST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codst
        {
            get { return  codst; }
            set {  codst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOATRIBUIDO
        /// Coment�rio: 
        /// </summary>
        private decimal custoatribuido;
        [XmlElement(ElementName = "CUSTOATRIBUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Custoatribuido
        {
            get { return  custoatribuido; }
            set {  custoatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: FOTOPRODUTO
        /// Coment�rio: 
        /// </summary>
        private string fotoproduto;
        [XmlElement(ElementName = "FOTOPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Fotoproduto
        {
            get { return  fotoproduto; }
            set {  fotoproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMS
        /// Coment�rio: 
        /// </summary>
        private decimal percicms;
        [XmlElement(ElementName = "PERCICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Percicms
        {
            get { return  percicms; }
            set {  percicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Coment�rio: 
        /// </summary>
        private decimal percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Coment�rio: 
        /// </summary>
        private decimal perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRCPESORATEIO
        /// Coment�rio: 
        /// </summary>
        private decimal prcpesorateio;
        [XmlElement(ElementName = "PRCPESORATEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Prcpesorateio
        {
            get { return  prcpesorateio; }
            set {  prcpesorateio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal precovenda;
        [XmlElement(ElementName = "PRECOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Precovenda
        {
            get { return  precovenda; }
            set {  precovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Coment�rio: 
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public Esvtabelaprecos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVTABELAPRECOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<Esvtabelaprecos> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvtabelaprecos.GetStringConnection());
            return ba.Listar<Esvtabelaprecos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<Esvtabelaprecos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvtabelaprecos.GetStringConnection());
            return ba.Existe<Esvtabelaprecos>(where);
        }

        #endregion
    }
}

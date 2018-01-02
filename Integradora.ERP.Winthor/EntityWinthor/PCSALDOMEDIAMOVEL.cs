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
    /// Classe referente a tabela PCSaldomediamovel
    /// </summary>
    [XmlType("PCSALDOMEDIAMOVEL")]
    public class PCSaldomediamovel : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Coment�rio: Ano do saldo em quest�o.
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo Filial do saldo em quest�o.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo Produto do saldo em quest�o.
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
        /// Propriedade referente ao campo: MES
        /// Coment�rio: M�s do saldo em quest�o.
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBASEST
        /// Coment�rio: Qtde em estoque do produto.
        /// </summary>
        private decimal qtbasest;
        [XmlElement(ElementName = "QTBASEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtbasest
        {
            get { return  qtbasest; }
            set {  qtbasest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLUNITBASEST
        /// Coment�rio: Valor unit�rio da base ST do produto.
        /// </summary>
        private decimal vlunitbasest;
        [XmlElement(ElementName = "VLUNITBASEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlunitbasest
        {
            get { return  vlunitbasest; }
            set {  vlunitbasest = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCSaldomediamovel()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSALDOMEDIAMOVEL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCSaldomediamovel> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSaldomediamovel>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCSaldomediamovel> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSaldomediamovel>(where);
        }

        #endregion
    }
}

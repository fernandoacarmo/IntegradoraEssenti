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
    /// Classe referente a tabela PCCstfretefob
    /// </summary>
    [XmlType("PCCSTFRETEFOB")]
    public class PCCstfretefob : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CFOP
        /// Coment�rio: CFOP do Conhecimento de Frete
        /// </summary>
        private decimal cfop;
        [XmlElement(ElementName = "CFOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Cfop
        {
            get { return  cfop; }
            set {  cfop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCSTICMSPRODUTO
        /// Coment�rio: Codigo CST ICMS Tributa��o de entrada
        /// </summary>
        private string codcsticmsproduto;
        [XmlElement(ElementName = "CODCSTICMSPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codcsticmsproduto
        {
            get { return  codcsticmsproduto; }
            set {  codcsticmsproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCSTICMSTRANSP
        /// Coment�rio: Codigo CST ICMS Transportadora
        /// </summary>
        private string codcsticmstransp;
        [XmlElement(ElementName = "CODCSTICMSTRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codcsticmstransp
        {
            get { return  codcsticmstransp; }
            set {  codcsticmstransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCSTPISCOFINSPRODUTO
        /// Coment�rio: Codigo CST PIS/COFINS Tributa��o de entrada
        /// </summary>
        private decimal codcstpiscofinsproduto;
        [XmlElement(ElementName = "CODCSTPISCOFINSPRODUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codcstpiscofinsproduto
        {
            get { return  codcstpiscofinsproduto; }
            set {  codcstpiscofinsproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCSTPISCOFINSTRANSP
        /// Coment�rio: Codigo CST PIS/COFINS Transportadora
        /// </summary>
        private decimal codcstpiscofinstransp;
        [XmlElement(ElementName = "CODCSTPISCOFINSTRANSP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codcstpiscofinstransp
        {
            get { return  codcstpiscofinstransp; }
            set {  codcstpiscofinstransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo do Fornecedor
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSPEDAGIOICMSFRETEFOB
        /// Coment�rio: Cons. Ped�gio na Base ICMS frete FOB
        /// </summary>
        private string conspedagioicmsfretefob;
        [XmlElement(ElementName = "CONSPEDAGIOICMSFRETEFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conspedagioicmsfretefob
        {
            get { return  conspedagioicmsfretefob; }
            set {  conspedagioicmsfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSPEDAGIOPISCOFINSFRETEFOB
        /// Coment�rio: Cons. Ped�gio na Base PIS/COFINS frete FOB
        /// </summary>
        private string conspedagiopiscofinsfretefob;
        [XmlElement(ElementName = "CONSPEDAGIOPISCOFINSFRETEFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conspedagiopiscofinsfretefob
        {
            get { return  conspedagiopiscofinsfretefob; }
            set {  conspedagiopiscofinsfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERABASESEMALIQ
        /// Coment�rio: Gera Base de PIS/COFINS s/Al�quota
        /// </summary>
        private string gerabasesemaliq;
        [XmlElement(ElementName = "GERABASESEMALIQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerabasesemaliq
        {
            get { return  gerabasesemaliq; }
            set {  gerabasesemaliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMS
        /// Coment�rio: Percentual de ICMS
        /// </summary>
        private decimal percicms;
        [XmlElement(ElementName = "PERCICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicms
        {
            get { return  percicms; }
            set {  percicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Coment�rio: Percentual de COFINS
        /// </summary>
        private decimal percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDICMSCUSTO
        /// Coment�rio: Percentual de ICMS p/ Calc.Custo
        /// </summary>
        private decimal percredicmscusto;
        [XmlElement(ElementName = "PERCREDICMSCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percredicmscusto
        {
            get { return  percredicmscusto; }
            set {  percredicmscusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Coment�rio: Percentual de PIS
        /// </summary>
        private decimal perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: 1 - ICMS , 2 - PISCOFINS
        /// </summary>
        private decimal tipo;
        [XmlElement(ElementName = "TIPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCstfretefob()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCSTFRETEFOB";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCstfretefob> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCstfretefob>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCstfretefob> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCstfretefob>(where);
        }

        #endregion
    }
}

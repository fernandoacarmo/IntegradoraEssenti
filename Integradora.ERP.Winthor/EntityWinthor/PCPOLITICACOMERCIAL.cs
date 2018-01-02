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
    /// Classe referente a tabela PCPoliticacomercial
    /// </summary>
    [XmlType("PCPOLITICACOMERCIAL")]
    public class PCPoliticacomercial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial
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
        /// Coment�rio: C�digo do produto
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
        /// Propriedade referente ao campo: CUSTOFORNEC
        /// Coment�rio: Custo fornecedor
        /// </summary>
        private decimal custofornec;
        [XmlElement(ElementName = "CUSTOFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Custofornec
        {
            get { return  custofornec; }
            set {  custofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPROXIMACOMPRA
        /// Coment�rio: Custo proxima compra
        /// </summary>
        private decimal custoproximacompra;
        [XmlElement(ElementName = "CUSTOPROXIMACOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoproximacompra
        {
            get { return  custoproximacompra; }
            set {  custoproximacompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREP
        /// Coment�rio: Custo reposi��o
        /// </summary>
        private decimal custorep;
        [XmlElement(ElementName = "CUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorep
        {
            get { return  custorep; }
            set {  custorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAALTER
        /// Coment�rio: Data da altera��o
        /// </summary>
        private DateTime? dataalter;
        [XmlElement(ElementName = "DATAALTER", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dataalter
        {
            get { return  dataalter; }
            set {  dataalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Coment�rio: Matricula do usuario logado
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matricula
        {
            get { return  matricula; }
            set {  matricula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRES
        /// Coment�rio: Percentual de acrescimo
        /// </summary>
        private decimal percacres;
        [XmlElement(ElementName = "PERCACRES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percacres
        {
            get { return  percacres; }
            set {  percacres = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Coment�rio: Desconto pregressivo
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC1
        /// Coment�rio: 1� Desconto progressivo
        /// </summary>
        private decimal percdesc1;
        [XmlElement(ElementName = "PERCDESC1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc1
        {
            get { return  percdesc1; }
            set {  percdesc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC10
        /// Coment�rio: 10� Desconto progressivo
        /// </summary>
        private decimal percdesc10;
        [XmlElement(ElementName = "PERCDESC10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc10
        {
            get { return  percdesc10; }
            set {  percdesc10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC2
        /// Coment�rio: 2� Desconto progressivo
        /// </summary>
        private decimal percdesc2;
        [XmlElement(ElementName = "PERCDESC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc2
        {
            get { return  percdesc2; }
            set {  percdesc2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC3
        /// Coment�rio: 3� Desconto progressivo
        /// </summary>
        private decimal percdesc3;
        [XmlElement(ElementName = "PERCDESC3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc3
        {
            get { return  percdesc3; }
            set {  percdesc3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC4
        /// Coment�rio: 4� Desconto progressivo
        /// </summary>
        private decimal percdesc4;
        [XmlElement(ElementName = "PERCDESC4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc4
        {
            get { return  percdesc4; }
            set {  percdesc4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC5
        /// Coment�rio: 5� Desconto progressivo
        /// </summary>
        private decimal percdesc5;
        [XmlElement(ElementName = "PERCDESC5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc5
        {
            get { return  percdesc5; }
            set {  percdesc5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC6
        /// Coment�rio: 6� Desconto progressivo
        /// </summary>
        private decimal percdesc6;
        [XmlElement(ElementName = "PERCDESC6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc6
        {
            get { return  percdesc6; }
            set {  percdesc6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC7
        /// Coment�rio: 7� Desconto progressivo
        /// </summary>
        private decimal percdesc7;
        [XmlElement(ElementName = "PERCDESC7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc7
        {
            get { return  percdesc7; }
            set {  percdesc7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC8
        /// Coment�rio: 8� Desconto progressivo
        /// </summary>
        private decimal percdesc8;
        [XmlElement(ElementName = "PERCDESC8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc8
        {
            get { return  percdesc8; }
            set {  percdesc8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC9
        /// Coment�rio: 9� Desconto progressivo
        /// </summary>
        private decimal percdesc9;
        [XmlElement(ElementName = "PERCDESC9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc9
        {
            get { return  percdesc9; }
            set {  percdesc9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDPMC
        /// Coment�rio: Percentual pre�o m�dio consumidor
        /// </summary>
        private decimal percredpmc;
        [XmlElement(ElementName = "PERCREDPMC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percredpmc
        {
            get { return  percredpmc; }
            set {  percredpmc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAFORNEC
        /// Coment�rio: Pre�o fornecedor
        /// </summary>
        private decimal ptabelafornec;
        [XmlElement(ElementName = "PTABELAFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabelafornec
        {
            get { return  ptabelafornec; }
            set {  ptabelafornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA
        /// Coment�rio: Rotina que fez a altera��o
        /// </summary>
        private string rotina;
        [XmlElement(ElementName = "ROTINA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Rotina
        {
            get { return  rotina; }
            set {  rotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TABELA
        /// Coment�rio: Tabela que disparou a trigger
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Tabela
        {
            get { return  tabela; }
            set {  tabela = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPoliticacomercial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPOLITICACOMERCIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPoliticacomercial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPoliticacomercial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPoliticacomercial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPoliticacomercial>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCConffilial
    /// </summary>
    [XmlType("PCCONFFILIAL")]
    public class PCConffilial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Coment�rio: 
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQABRIL
        /// Coment�rio: Bloqueia m�s de Abril.
        /// </summary>
        private string bloqabril;
        [XmlElement(ElementName = "BLOQABRIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqabril
        {
            get { return  bloqabril; }
            set {  bloqabril = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQAGOSTO
        /// Coment�rio: Bloqueia m�s de Agosto.
        /// </summary>
        private string bloqagosto;
        [XmlElement(ElementName = "BLOQAGOSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqagosto
        {
            get { return  bloqagosto; }
            set {  bloqagosto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQDEZEMBRO
        /// Coment�rio: Bloqueia m�s de Dezembro.
        /// </summary>
        private string bloqdezembro;
        [XmlElement(ElementName = "BLOQDEZEMBRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqdezembro
        {
            get { return  bloqdezembro; }
            set {  bloqdezembro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQFEVEREIRO
        /// Coment�rio: Bloqueia m�s de Fevereiro.
        /// </summary>
        private string bloqfevereiro;
        [XmlElement(ElementName = "BLOQFEVEREIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqfevereiro
        {
            get { return  bloqfevereiro; }
            set {  bloqfevereiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQJANEIRO
        /// Coment�rio: Bloqueia m�s de Janeiro.
        /// </summary>
        private string bloqjaneiro;
        [XmlElement(ElementName = "BLOQJANEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqjaneiro
        {
            get { return  bloqjaneiro; }
            set {  bloqjaneiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQJULHO
        /// Coment�rio: Bloqueia m�s de Julho.
        /// </summary>
        private string bloqjulho;
        [XmlElement(ElementName = "BLOQJULHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqjulho
        {
            get { return  bloqjulho; }
            set {  bloqjulho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQJUNHO
        /// Coment�rio: Bloqueia m�s de Junho.
        /// </summary>
        private string bloqjunho;
        [XmlElement(ElementName = "BLOQJUNHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqjunho
        {
            get { return  bloqjunho; }
            set {  bloqjunho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQMAIO
        /// Coment�rio: Bloqueia m�s de Maio.
        /// </summary>
        private string bloqmaio;
        [XmlElement(ElementName = "BLOQMAIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqmaio
        {
            get { return  bloqmaio; }
            set {  bloqmaio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQMARCO
        /// Coment�rio: Bloqueia m�s de Mar�o.
        /// </summary>
        private string bloqmarco;
        [XmlElement(ElementName = "BLOQMARCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqmarco
        {
            get { return  bloqmarco; }
            set {  bloqmarco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQNOVEMBRO
        /// Coment�rio: Bloqueia m�s de Novembro.
        /// </summary>
        private string bloqnovembro;
        [XmlElement(ElementName = "BLOQNOVEMBRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqnovembro
        {
            get { return  bloqnovembro; }
            set {  bloqnovembro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQOUTUBRO
        /// Coment�rio: Bloqueia m�s de Outubro.
        /// </summary>
        private string bloqoutubro;
        [XmlElement(ElementName = "BLOQOUTUBRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqoutubro
        {
            get { return  bloqoutubro; }
            set {  bloqoutubro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQSETEMBRO
        /// Coment�rio: Bloqueia m�s de Setembro.
        /// </summary>
        private string bloqsetembro;
        [XmlElement(ElementName = "BLOQSETEMBRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqsetembro
        {
            get { return  bloqsetembro; }
            set {  bloqsetembro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONFIG
        /// Coment�rio: 
        /// </summary>
        private decimal codconfig;
        [XmlElement(ElementName = "CODCONFIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codconfig
        {
            get { return  codconfig; }
            set {  codconfig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODGRUPOFILIAL
        /// Coment�rio: 
        /// </summary>
        private decimal codgrupofilial;
        [XmlElement(ElementName = "CODGRUPOFILIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codgrupofilial
        {
            get { return  codgrupofilial; }
            set {  codgrupofilial = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCConffilial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONFFILIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCConffilial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConffilial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCConffilial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConffilial>(where);
        }

        #endregion
    }
}

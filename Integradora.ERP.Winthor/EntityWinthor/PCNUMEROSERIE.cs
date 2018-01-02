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
    /// Classe referente a tabela PCNumeroserie
    /// </summary>
    [XmlType("PCNUMEROSERIE")]
    public class PCNumeroserie : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AVARIA
        /// Coment�rio: Avaria
        /// </summary>
        private string avaria;
        [XmlElement(ElementName = "AVARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Avaria
        {
            get { return  avaria; }
            set {  avaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIO
        /// Coment�rio: Bloqueio
        /// </summary>
        private string bloqueio;
        [XmlElement(ElementName = "BLOQUEIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueio
        {
            get { return  bloqueio; }
            set {  bloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial
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
        /// Coment�rio: C�digo do produto
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
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: N�mero do lote
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIE
        /// Coment�rio: N�mero de s�rie
        /// </summary>
        private string numserie;
        [XmlElement(ElementName = "NUMSERIE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,60)]
        public string Numserie
        {
            get { return  numserie; }
            set {  numserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESERVADA
        /// Coment�rio: Reservada
        /// </summary>
        private string reservada;
        [XmlElement(ElementName = "RESERVADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reservada
        {
            get { return  reservada; }
            set {  reservada = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCNumeroserie()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNUMEROSERIE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCNumeroserie> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNumeroserie>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCNumeroserie> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNumeroserie>(where);
        }

        #endregion
    }
}

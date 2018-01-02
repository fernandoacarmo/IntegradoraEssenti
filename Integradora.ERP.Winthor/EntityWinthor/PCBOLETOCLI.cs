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
    /// Classe referente a tabela PCBoletocli
    /// </summary>
    [XmlType("PCBOLETOCLI")]
    public class PCBoletocli : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BANCO
        /// Coment�rio: 
        /// </summary>
        private decimal banco;
        [XmlElement(ElementName = "BANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Banco
        {
            get { return  banco; }
            set {  banco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Coment�rio: Campo para armazenar o valor do c�digo de barras do boleto.
        /// </summary>
        private string codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Gravar o c�digo da filial, amarrado ao boleto gerado.
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
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LINHADIG
        /// Coment�rio: Campo para armazenar o valor da linha digit�vel do boleto.
        /// </summary>
        private string linhadig;
        [XmlElement(ElementName = "LINHADIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,65)]
        public string Linhadig
        {
            get { return  linhadig; }
            set {  linhadig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOSSONUMBCO
        /// Coment�rio: 
        /// </summary>
        private string nossonumbco;
        [XmlElement(ElementName = "NOSSONUMBCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nossonumbco
        {
            get { return  nossonumbco; }
            set {  nossonumbco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Coment�rio: 
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Posicao
        {
            get { return  posicao; }
            set {  posicao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBoletocli()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBOLETOCLI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBoletocli> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBoletocli>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBoletocli> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBoletocli>(where);
        }

        #endregion
    }
}

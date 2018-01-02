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
    /// Classe referente a tabela PCAnaliseclirfv
    /// </summary>
    [XmlType("PCANALISECLIRFV")]
    public class PCAnaliseclirfv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Coment�rio: 
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSIFICACAO
        /// Coment�rio: 
        /// </summary>
        private string classificacao;
        [XmlElement(ElementName = "CLASSIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,32)]
        public string Classificacao
        {
            get { return  classificacao; }
            set {  classificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NOTAFREQUENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal notafrequencia;
        [XmlElement(ElementName = "NOTAFREQUENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Notafrequencia
        {
            get { return  notafrequencia; }
            set {  notafrequencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOTARESCENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal notarescencia;
        [XmlElement(ElementName = "NOTARESCENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Notarescencia
        {
            get { return  notarescencia; }
            set {  notarescencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOTATOTAL
        /// Coment�rio: 
        /// </summary>
        private decimal notatotal;
        [XmlElement(ElementName = "NOTATOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Notatotal
        {
            get { return  notatotal; }
            set {  notatotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOTAVALOR
        /// Coment�rio: 
        /// </summary>
        private decimal notavalor;
        [XmlElement(ElementName = "NOTAVALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Notavalor
        {
            get { return  notavalor; }
            set {  notavalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOFREQUENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal pesofrequencia;
        [XmlElement(ElementName = "PESOFREQUENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Pesofrequencia
        {
            get { return  pesofrequencia; }
            set {  pesofrequencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESORESCENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal pesorescencia;
        [XmlElement(ElementName = "PESORESCENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Pesorescencia
        {
            get { return  pesorescencia; }
            set {  pesorescencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOVALOR
        /// Coment�rio: 
        /// </summary>
        private decimal pesovalor;
        [XmlElement(ElementName = "PESOVALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Pesovalor
        {
            get { return  pesovalor; }
            set {  pesovalor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAnaliseclirfv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCANALISECLIRFV";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAnaliseclirfv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAnaliseclirfv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAnaliseclirfv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAnaliseclirfv>(where);
        }

        #endregion
    }
}

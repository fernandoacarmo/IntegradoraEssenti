using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ECommerce.Corpem.Inherited;

namespace Integradora.ECommerce.Corpem.Entity
{
    /// <summary>
    /// Classe referente a tabela ESTNotasaida
    /// </summary>
    [XmlType("ESTNOTASAIDA")]
    public class ESTNotasaida : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODDESTINARIO
        /// Coment�rio: 
        /// </summary>
        private decimal coddestinario;
        [XmlElement(ElementName = "CODDESTINARIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Coddestinario
        {
            get { return  coddestinario; }
            set {  coddestinario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCELAMENTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcancelamento;
        [XmlElement(ElementName = "DTCANCELAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancelamento
        {
            get { return  dtcancelamento; }
            set {  dtcancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFATURAMENTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfaturamento;
        [XmlElement(ElementName = "DTFATURAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfaturamento
        {
            get { return  dtfaturamento; }
            set {  dtfaturamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Coment�rio: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Coment�rio: 
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMAFARO
        /// Coment�rio: 
        /// </summary>
        private string semafaro;
        [XmlElement(ElementName = "SEMAFARO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Semafaro
        {
            get { return  semafaro; }
            set {  semafaro = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESTNotasaida()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTNOTASAIDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTNotasaida> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<ESTNotasaida>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTNotasaida> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<ESTNotasaida>(where);
        }

        #endregion
    }
}

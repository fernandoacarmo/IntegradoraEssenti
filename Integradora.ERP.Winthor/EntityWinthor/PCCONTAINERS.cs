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
    /// Classe referente a tabela PCContainers
    /// </summary>
    [XmlType("PCCONTAINERS")]
    public class PCContainers : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DIASCARENCIA
        /// Coment�rio: Dias de car�ncia
        /// </summary>
        private decimal diascarencia;
        [XmlElement(ElementName = "DIASCARENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Diascarencia
        {
            get { return  diascarencia; }
            set {  diascarencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Data de cadastro do containers
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
        /// Propriedade referente ao campo: DTCHEGADA
        /// Coment�rio: Data de chegada do container.
        /// </summary>
        private DateTime? dtchegada;
        [XmlElement(ElementName = "DTCHEGADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtchegada
        {
            get { return  dtchegada; }
            set {  dtchegada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDEVOLUCAO
        /// Coment�rio: Data devolu��o
        /// </summary>
        private DateTime? dtdevolucao;
        [XmlElement(ElementName = "DTDEVOLUCAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdevolucao
        {
            get { return  dtdevolucao; }
            set {  dtdevolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREVDEVOLUCAO
        /// Coment�rio: Data de previs�o para devolu��o
        /// </summary>
        private DateTime? dtprevdevolucao;
        [XmlElement(ElementName = "DTPREVDEVOLUCAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprevdevolucao
        {
            get { return  dtprevdevolucao; }
            set {  dtprevdevolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCONTAINER
        /// Coment�rio: Identifica��o do container
        /// </summary>
        private string idcontainer;
        [XmlElement(ElementName = "IDCONTAINER", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Idcontainer
        {
            get { return  idcontainer; }
            set {  idcontainer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCONTROLEEMBARQUE
        /// Coment�rio: Identifica��o do controle de embarque.
        /// </summary>
        private string idcontroleembarque;
        [XmlElement(ElementName = "IDCONTROLEEMBARQUE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Idcontroleembarque
        {
            get { return  idcontroleembarque; }
            set {  idcontroleembarque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LACRES
        /// Coment�rio: Descri��o dos n�meros que identificam os lacres dos containers
        /// </summary>
        private string lacres;
        [XmlElement(ElementName = "LACRES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Lacres
        {
            get { return  lacres; }
            set {  lacres = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTAINER
        /// Coment�rio: Descri��o para definir o tipo do container.
        /// </summary>
        private string tipocontainer;
        [XmlElement(ElementName = "TIPOCONTAINER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Tipocontainer
        {
            get { return  tipocontainer; }
            set {  tipocontainer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOTACAO
        /// Coment�rio: Valor unit�rio da moeda 
        /// </summary>
        private decimal vlcotacao;
        [XmlElement(ElementName = "VLCOTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcotacao
        {
            get { return  vlcotacao; }
            set {  vlcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIARIA
        /// Coment�rio: Valor da di�ria
        /// </summary>
        private decimal vldiaria;
        [XmlElement(ElementName = "VLDIARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldiaria
        {
            get { return  vldiaria; }
            set {  vldiaria = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCContainers()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTAINERS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCContainers> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContainers>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCContainers> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContainers>(where);
        }

        #endregion
    }
}

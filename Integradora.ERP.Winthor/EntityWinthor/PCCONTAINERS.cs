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
        /// Comentário: Dias de carência
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
        /// Comentário: Data de cadastro do containers
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
        /// Comentário: Data de chegada do container.
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
        /// Comentário: Data devolução
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
        /// Comentário: Data de previsão para devolução
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
        /// Comentário: Identificação do container
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
        /// Comentário: Identificação do controle de embarque.
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
        /// Comentário: Descrição dos números que identificam os lacres dos containers
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
        /// Comentário: Descrição para definir o tipo do container.
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
        /// Comentário: Valor unitário da moeda 
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
        /// Comentário: Valor da diária
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCContainers> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContainers>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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

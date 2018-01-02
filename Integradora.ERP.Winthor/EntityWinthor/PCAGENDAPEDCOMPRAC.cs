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
    /// Classe referente a tabela PCAgendapedcomprac
    /// </summary>
    [XmlType("PCAGENDAPEDCOMPRAC")]
    public class PCAgendapedcomprac : OracleTable
    {
        #region Atributos

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
        /// Propriedade referente ao campo: CODUSURCAD
        /// Coment�rio: C�digo do usu�rio cadastro
        /// </summary>
        private decimal codusurcad;
        [XmlElement(ElementName = "CODUSURCAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusurcad
        {
            get { return  codusurcad; }
            set {  codusurcad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSURULTALT
        /// Coment�rio: C�digo do usu�rio altera��o
        /// </summary>
        private decimal codusurultalt;
        [XmlElement(ElementName = "CODUSURULTALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusurultalt
        {
            get { return  codusurultalt; }
            set {  codusurultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data do agendamento
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACAD
        /// Coment�rio: Data do cadastro
        /// </summary>
        private DateTime? datacad;
        [XmlElement(ElementName = "DATACAD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacad
        {
            get { return  datacad; }
            set {  datacad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAULTALT
        /// Coment�rio: Data da altera��o
        /// </summary>
        private DateTime? dataultalt;
        [XmlElement(ElementName = "DATAULTALT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataultalt
        {
            get { return  dataultalt; }
            set {  dataultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFIM
        /// Coment�rio: Hora fim do agendamento
        /// </summary>
        private string horafim;
        [XmlElement(ElementName = "HORAFIM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public string Horafim
        {
            get { return  horafim; }
            set {  horafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINI
        /// Coment�rio: Hora inicio do agendamento
        /// </summary>
        private string horaini;
        [XmlElement(ElementName = "HORAINI", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public string Horaini
        {
            get { return  horaini; }
            set {  horaini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Coment�rio: N�mero Identifica��o do Agendamento
        /// </summary>
        private decimal id;
        [XmlElement(ElementName = "ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Id
        {
            get { return  id; }
            set {  id = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAgendapedcomprac()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAGENDAPEDCOMPRAC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAgendapedcomprac> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAgendapedcomprac>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAgendapedcomprac> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAgendapedcomprac>(where);
        }

        #endregion
    }
}

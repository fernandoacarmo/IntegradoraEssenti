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
    /// Classe referente a tabela PCCliesp
    /// </summary>
    [XmlType("PCCLIESP")]
    public class PCCliesp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CHAVEATIVACAO
        /// Comentário: 
        /// </summary>
        private string chaveativacao;
        [XmlElement(ElementName = "CHAVEATIVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Chaveativacao
        {
            get { return  chaveativacao; }
            set {  chaveativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: DIAVENC
        /// Comentário: 
        /// </summary>
        private decimal diavenc;
        [XmlElement(ElementName = "DIAVENC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diavenc
        {
            get { return  diavenc; }
            set {  diavenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALIZACAO
        /// Comentário: 
        /// </summary>
        private string localizacao;
        [XmlElement(ElementName = "LOCALIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Localizacao
        {
            get { return  localizacao; }
            set {  localizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MESVENC
        /// Comentário: 
        /// </summary>
        private string mesvenc;
        [XmlElement(ElementName = "MESVENC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Mesvenc
        {
            get { return  mesvenc; }
            set {  mesvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEBD
        /// Comentário: 
        /// </summary>
        private string nomebd;
        [XmlElement(ElementName = "NOMEBD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomebd
        {
            get { return  nomebd; }
            set {  nomebd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFILIAIS
        /// Comentário: 
        /// </summary>
        private decimal numfiliais;
        [XmlElement(ElementName = "NUMFILIAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numfiliais
        {
            get { return  numfiliais; }
            set {  numfiliais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMUSUARIOS
        /// Comentário: 
        /// </summary>
        private decimal numusuarios;
        [XmlElement(ElementName = "NUMUSUARIOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numusuarios
        {
            get { return  numusuarios; }
            set {  numusuarios = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHABD
        /// Comentário: 
        /// </summary>
        private string senhabd;
        [XmlElement(ElementName = "SENHABD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Senhabd
        {
            get { return  senhabd; }
            set {  senhabd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTRAT
        /// Comentário: 
        /// </summary>
        private string tipocontrat;
        [XmlElement(ElementName = "TIPOCONTRAT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocontrat
        {
            get { return  tipocontrat; }
            set {  tipocontrat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTRATO
        /// Comentário: 
        /// </summary>
        private string tipocontrato;
        [XmlElement(ElementName = "TIPOCONTRATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipocontrato
        {
            get { return  tipocontrato; }
            set {  tipocontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXVENDORCLI
        /// Comentário: 
        /// </summary>
        private decimal txvendorcli;
        [XmlElement(ElementName = "TXVENDORCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Txvendorcli
        {
            get { return  txvendorcli; }
            set {  txvendorcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOBD
        /// Comentário: 
        /// </summary>
        private string usuariobd;
        [XmlElement(ElementName = "USUARIOBD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Usuariobd
        {
            get { return  usuariobd; }
            set {  usuariobd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASE
        /// Comentário: 
        /// </summary>
        private decimal vlbase;
        [XmlElement(ElementName = "VLBASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlbase
        {
            get { return  vlbase; }
            set {  vlbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCONTRATO
        /// Comentário: 
        /// </summary>
        private decimal vlcontrato;
        [XmlElement(ElementName = "VLCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcontrato
        {
            get { return  vlcontrato; }
            set {  vlcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINIMO
        /// Comentário: 
        /// </summary>
        private decimal vlminimo;
        [XmlElement(ElementName = "VLMINIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlminimo
        {
            get { return  vlminimo; }
            set {  vlminimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPROPOSTO
        /// Comentário: 
        /// </summary>
        private decimal vlproposto;
        [XmlElement(ElementName = "VLPROPOSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlproposto
        {
            get { return  vlproposto; }
            set {  vlproposto = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCliesp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCLIESP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCliesp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCliesp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCliesp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCliesp>(where);
        }

        #endregion
    }
}

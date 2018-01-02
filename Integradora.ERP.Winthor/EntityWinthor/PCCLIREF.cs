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
    /// Classe referente a tabela PCCliref
    /// </summary>
    [XmlType("PCCLIREF")]
    public class PCCliref : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODCOBREFER
        /// Comentário: 
        /// </summary>
        private string codcobrefer;
        [XmlElement(ElementName = "CODCOBREFER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobrefer
        {
            get { return  codcobrefer; }
            set {  codcobrefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATOREFER
        /// Comentário: 
        /// </summary>
        private string contatorefer;
        [XmlElement(ElementName = "CONTATOREFER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Contatorefer
        {
            get { return  contatorefer; }
            set {  contatorefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTROREFER
        /// Comentário: 
        /// </summary>
        private DateTime? dtcadastrorefer;
        [XmlElement(ElementName = "DTCADASTROREFER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastrorefer
        {
            get { return  dtcadastrorefer; }
            set {  dtcadastrorefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTMAIORCOMPREFER
        /// Comentário: 
        /// </summary>
        private DateTime? dtmaiorcomprefer;
        [XmlElement(ElementName = "DTMAIORCOMPREFER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtmaiorcomprefer
        {
            get { return  dtmaiorcomprefer; }
            set {  dtmaiorcomprefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCOMPREFER
        /// Comentário: 
        /// </summary>
        private DateTime? dtultcomprefer;
        [XmlElement(ElementName = "DTULTCOMPREFER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultcomprefer
        {
            get { return  dtultcomprefer; }
            set {  dtultcomprefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMPREFER
        /// Comentário: 
        /// </summary>
        private string emprefer;
        [XmlElement(ElementName = "EMPREFER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Emprefer
        {
            get { return  emprefer; }
            set {  emprefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMCREDREFER
        /// Comentário: 
        /// </summary>
        private decimal limcredrefer;
        [XmlElement(ElementName = "LIMCREDREFER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Limcredrefer
        {
            get { return  limcredrefer; }
            set {  limcredrefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQREFER
        /// Comentário: 
        /// </summary>
        private decimal numseqrefer;
        [XmlElement(ElementName = "NUMSEQREFER", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numseqrefer
        {
            get { return  numseqrefer; }
            set {  numseqrefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELREFER
        /// Comentário: 
        /// </summary>
        private string telrefer;
        [XmlElement(ElementName = "TELREFER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telrefer
        {
            get { return  telrefer; }
            set {  telrefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAIORCOMPREFER
        /// Comentário: 
        /// </summary>
        private decimal vlmaiorcomprefer;
        [XmlElement(ElementName = "VLMAIORCOMPREFER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmaiorcomprefer
        {
            get { return  vlmaiorcomprefer; }
            set {  vlmaiorcomprefer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLULTCOMPREFER
        /// Comentário: 
        /// </summary>
        private decimal vlultcomprefer;
        [XmlElement(ElementName = "VLULTCOMPREFER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlultcomprefer
        {
            get { return  vlultcomprefer; }
            set {  vlultcomprefer = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCliref()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCLIREF";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCliref> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCliref>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCliref> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCliref>(where);
        }

        #endregion
    }
}

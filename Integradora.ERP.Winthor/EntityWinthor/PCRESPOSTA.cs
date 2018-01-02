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
    /// Classe referente a tabela PCResposta
    /// </summary>
    [XmlType("PCRESPOSTA")]
    public class PCResposta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAGENDA
        /// Coment�rio: C�digo da agenda.
        /// </summary>
        private decimal codagenda;
        [XmlElement(ElementName = "CODAGENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codagenda
        {
            get { return  codagenda; }
            set {  codagenda = value; }
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
        /// Propriedade referente ao campo: CODPERGUNTA
        /// Coment�rio: 
        /// </summary>
        private decimal codpergunta;
        [XmlElement(ElementName = "CODPERGUNTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codpergunta
        {
            get { return  codpergunta; }
            set {  codpergunta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPESQUISA
        /// Coment�rio: 
        /// </summary>
        private decimal codpesquisa;
        [XmlElement(ElementName = "CODPESQUISA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codpesquisa
        {
            get { return  codpesquisa; }
            set {  codpesquisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRESPPERGUNTA
        /// Coment�rio: 
        /// </summary>
        private decimal codresppergunta;
        [XmlElement(ElementName = "CODRESPPERGUNTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codresppergunta
        {
            get { return  codresppergunta; }
            set {  codresppergunta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMENTARIO
        /// Coment�rio: Indica o comentario da resposta.
        /// </summary>
        private string comentario;
        [XmlElement(ElementName = "COMENTARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Comentario
        {
            get { return  comentario; }
            set {  comentario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NOTA
        /// Coment�rio: 
        /// </summary>
        private decimal nota;
        [XmlElement(ElementName = "NOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Nota
        {
            get { return  nota; }
            set {  nota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Coment�rio: Indica o n�mero da ordem de servi�o.
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUALIDADE
        /// Coment�rio: 
        /// </summary>
        private string qualidade;
        [XmlElement(ElementName = "QUALIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Qualidade
        {
            get { return  qualidade; }
            set {  qualidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESPSN
        /// Coment�rio: 
        /// </summary>
        private string respsn;
        [XmlElement(ElementName = "RESPSN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Respsn
        {
            get { return  respsn; }
            set {  respsn = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMP
        /// Coment�rio: 
        /// </summary>
        private string temp;
        [XmlElement(ElementName = "TEMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Temp
        {
            get { return  temp; }
            set {  temp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEXTO
        /// Coment�rio: 
        /// </summary>
        private string texto;
        [XmlElement(ElementName = "TEXTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Texto
        {
            get { return  texto; }
            set {  texto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCResposta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRESPOSTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCResposta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCResposta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCResposta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCResposta>(where);
        }

        #endregion
    }
}

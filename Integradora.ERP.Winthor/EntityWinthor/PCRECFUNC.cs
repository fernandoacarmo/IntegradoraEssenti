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
    /// Classe referente a tabela PCRecfunc
    /// </summary>
    [XmlType("PCRECFUNC")]
    public class PCRecfunc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ASSUNTO
        /// Comentário: 
        /// </summary>
        private string assunto;
        [XmlElement(ElementName = "ASSUNTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Assunto
        {
            get { return  assunto; }
            set {  assunto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAB
        /// Comentário: 
        /// </summary>
        private decimal codfuncab;
        [XmlElement(ElementName = "CODFUNCAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncab
        {
            get { return  codfuncab; }
            set {  codfuncab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCDEST
        /// Comentário: 
        /// </summary>
        private decimal codfuncdest;
        [XmlElement(ElementName = "CODFUNCDEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncdest
        {
            get { return  codfuncdest; }
            set {  codfuncdest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCRE
        /// Comentário: 
        /// </summary>
        private decimal codfuncre;
        [XmlElement(ElementName = "CODFUNCRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncre
        {
            get { return  codfuncre; }
            set {  codfuncre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORDEST
        /// Comentário: 
        /// </summary>
        private decimal codsetordest;
        [XmlElement(ElementName = "CODSETORDEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetordest
        {
            get { return  codsetordest; }
            set {  codsetordest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORORIG
        /// Comentário: 
        /// </summary>
        private decimal codsetororig;
        [XmlElement(ElementName = "CODSETORORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetororig
        {
            get { return  codsetororig; }
            set {  codsetororig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMUNICADO
        /// Comentário: 
        /// </summary>
        private string comunicado;
        [XmlElement(ElementName = "COMUNICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Comunicado
        {
            get { return  comunicado; }
            set {  comunicado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAB
        /// Comentário: 
        /// </summary>
        private DateTime? dtab;
        [XmlElement(ElementName = "DTAB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtab
        {
            get { return  dtab; }
            set {  dtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRE
        /// Comentário: 
        /// </summary>
        private DateTime? dtre;
        [XmlElement(ElementName = "DTRE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtre
        {
            get { return  dtre; }
            set {  dtre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXCLUIDO
        /// Comentário: 
        /// </summary>
        private string excluido;
        [XmlElement(ElementName = "EXCLUIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Excluido
        {
            get { return  excluido; }
            set {  excluido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMRECADO
        /// Comentário: 
        /// </summary>
        private decimal numrecado;
        [XmlElement(ElementName = "NUMRECADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numrecado
        {
            get { return  numrecado; }
            set {  numrecado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMRECADOFV
        /// Comentário: 
        /// </summary>
        private decimal numrecadofv;
        [XmlElement(ElementName = "NUMRECADOFV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Numrecadofv
        {
            get { return  numrecadofv; }
            set {  numrecadofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEXTORECADO
        /// Comentário: 
        /// </summary>
        private string textorecado;
        [XmlElement(ElementName = "TEXTORECADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Textorecado
        {
            get { return  textorecado; }
            set {  textorecado = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRecfunc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRECFUNC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRecfunc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRecfunc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRecfunc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRecfunc>(where);
        }

        #endregion
    }
}

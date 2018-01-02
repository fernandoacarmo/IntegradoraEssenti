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
    /// Classe referente a tabela PCRecfuncfv
    /// </summary>
    [XmlType("PCRECFUNCFV")]
    public class PCRecfuncfv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ASSUNTO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNCDEST
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncdest;
        [XmlElement(ElementName = "CODFUNCDEST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codfuncdest
        {
            get { return  codfuncdest; }
            set {  codfuncdest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: Data de Altera��o no registro
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Coment�rio: Grava Data e Hora da �ltima Importa��o.
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Coment�rio: 
        /// </summary>
        private decimal importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMRECADOFV
        /// Coment�rio: 
        /// </summary>
        private decimal numrecadofv;
        [XmlElement(ElementName = "NUMRECADOFV", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,12)]
        public decimal Numrecadofv
        {
            get { return  numrecadofv; }
            set {  numrecadofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_PC
        /// Coment�rio: 
        /// </summary>
        private string observacao_pc;
        [XmlElement(ElementName = "OBSERVACAO_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Observacao_Pc
        {
            get { return  observacao_pc; }
            set {  observacao_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEXTORECADO
        /// Coment�rio: 
        /// </summary>
        private string textorecado;
        [XmlElement(ElementName = "TEXTORECADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,4000)]
        public string Textorecado
        {
            get { return  textorecado; }
            set {  textorecado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRecfuncfv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRECFUNCFV";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRecfuncfv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRecfuncfv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRecfuncfv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRecfuncfv>(where);
        }

        #endregion
    }
}

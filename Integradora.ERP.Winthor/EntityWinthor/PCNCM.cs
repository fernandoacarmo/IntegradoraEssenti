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
    /// Classe referente a tabela PCNcm
    /// </summary>
    [XmlType("PCNCM")]
    public class PCNcm : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAPITULO
        /// Comentário: Capítulo NCM.
        /// </summary>
        private decimal capitulo;
        [XmlElement(ElementName = "CAPITULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Capitulo
        {
            get { return  capitulo; }
            set {  capitulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEX
        /// Comentário: Código de exceção.
        /// </summary>
        private decimal codex;
        [XmlElement(ElementName = "CODEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Codex
        {
            get { return  codex; }
            set {  codex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNCM
        /// Comentário: Código NCM.
        /// </summary>
        private string codncm;
        [XmlElement(ElementName = "CODNCM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
        public string Codncm
        {
            get { return  codncm; }
            set {  codncm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNCMEX
        /// Comentário: 
        /// </summary>
        private string codncmex;
        [XmlElement(ElementName = "CODNCMEX", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Codncmex
        {
            get { return  codncmex; }
            set {  codncmex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUREXCLUSAO
        /// Comentário: Código do Usuário que Inativou o NCM.
        /// </summary>
        private decimal codusurexclusao;
        [XmlElement(ElementName = "CODUSUREXCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusurexclusao
        {
            get { return  codusurexclusao; }
            set {  codusurexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSURINCLUSAO
        /// Comentário: Código do Usuário que Cadastrou o NCM.
        /// </summary>
        private decimal codusurinclusao;
        [XmlElement(ElementName = "CODUSURINCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusurinclusao
        {
            get { return  codusurinclusao; }
            set {  codusurinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição NCM.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,500)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: Data da Exclusão.
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
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: Data da Inclusão.
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCNcm()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNCM";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNcm> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNcm>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCNcm> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNcm>(where);
        }

        #endregion
    }
}

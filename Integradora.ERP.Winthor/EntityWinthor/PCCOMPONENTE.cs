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
    /// Classe referente a tabela PCComponente
    /// </summary>
    [XmlType("PCCOMPONENTE")]
    public class PCComponente : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CADASTRO
        /// Comentário: Cadastro
        /// </summary>
        private string cadastro;
        [XmlElement(ElementName = "CADASTRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cadastro
        {
            get { return  cadastro; }
            set {  cadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOMP
        /// Comentário: Código do componente
        /// </summary>
        private decimal codcomp;
        [XmlElement(ElementName = "CODCOMP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcomp
        {
            get { return  codcomp; }
            set {  codcomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODBASE
        /// Comentário: Código do produto base
        /// </summary>
        private decimal codprodbase;
        [XmlElement(ElementName = "CODPRODBASE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprodbase
        {
            get { return  codprodbase; }
            set {  codprodbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODCOMP
        /// Comentário: Código do produto componente
        /// </summary>
        private string codprodcomp;
        [XmlElement(ElementName = "CODPRODCOMP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Codprodcomp
        {
            get { return  codprodcomp; }
            set {  codprodcomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Observação
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCComponente()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMPONENTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCComponente> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComponente>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCComponente> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComponente>(where);
        }

        #endregion
    }
}

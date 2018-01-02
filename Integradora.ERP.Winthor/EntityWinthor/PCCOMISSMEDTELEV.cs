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
    /// Classe referente a tabela PCComissmedtelev
    /// </summary>
    [XmlType("PCCOMISSMEDTELEV")]
    public class PCComissmedtelev : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOMISS
        /// Comentário: Código da Comissão para o Tipo de Comissão informado
        /// </summary>
        private decimal codcomiss;
        [XmlElement(ElementName = "CODCOMISS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Codcomiss
        {
            get { return  codcomiss; }
            set {  codcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da Filial
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
        /// Propriedade referente ao campo: CODFUNCCADASTRO
        /// Comentário: Funcionário cadastro
        /// </summary>
        private decimal codfunccadastro;
        [XmlElement(ElementName = "CODFUNCCADASTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccadastro
        {
            get { return  codfunccadastro; }
            set {  codfunccadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALT
        /// Comentário: Funcionário última alteração
        /// </summary>
        private decimal codfuncultalt;
        [XmlElement(ElementName = "CODFUNCULTALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalt
        {
            get { return  codfuncultalt; }
            set {  codfuncultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Data Cadastro
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
        /// Propriedade referente ao campo: DTULTALT
        /// Comentário: Data últ. Alteração
        /// </summary>
        private DateTime? dtultalt;
        [XmlElement(ElementName = "DTULTALT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalt
        {
            get { return  dtultalt; }
            set {  dtultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMISS
        /// Comentário: Percentual de Comissão
        /// </summary>
        private decimal percomiss;
        [XmlElement(ElementName = "PERCOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomiss
        {
            get { return  percomiss; }
            set {  percomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCOMISS
        /// Comentário: Tpo de Comissão [F-Fornecedor; M-Marca]
        /// </summary>
        private string tipocomiss;
        [XmlElement(ElementName = "TIPOCOMISS", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Tipocomiss
        {
            get { return  tipocomiss; }
            set {  tipocomiss = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCComissmedtelev()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMISSMEDTELEV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCComissmedtelev> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComissmedtelev>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCComissmedtelev> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComissmedtelev>(where);
        }

        #endregion
    }
}

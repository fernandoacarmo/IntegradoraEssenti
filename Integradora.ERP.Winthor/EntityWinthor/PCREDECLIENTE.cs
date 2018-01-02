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
    /// Classe referente a tabela PCRedecliente
    /// </summary>
    [XmlType("PCREDECLIENTE")]
    public class PCRedecliente : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCAD
        /// Coment�rio: Indica o funcionario que cadastrou o cliente.
        /// </summary>
        private decimal codfunccad;
        [XmlElement(ElementName = "CODFUNCCAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccad
        {
            get { return  codfunccad; }
            set {  codfunccad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALT
        /// Coment�rio: Indica o funcionario que fez a ultima altera��o.
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
        /// Propriedade referente ao campo: CODREDE
        /// Coment�rio: Indica o c�digo da rede.
        /// </summary>
        private decimal codrede;
        [XmlElement(ElementName = "CODREDE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codrede
        {
            get { return  codrede; }
            set {  codrede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Indica a descri��o da rede.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Indica a data de cadastro da rede.
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
        /// Coment�rio: Indica a data da �ltima altera��o.
        /// </summary>
        private DateTime? dtultalt;
        [XmlElement(ElementName = "DTULTALT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalt
        {
            get { return  dtultalt; }
            set {  dtultalt = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRedecliente()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCREDECLIENTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRedecliente> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRedecliente>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRedecliente> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRedecliente>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCFormulac
    /// </summary>
    [XmlType("PCFORMULAC")]
    public class PCFormulac : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFORMULA
        /// Coment�rio: Campo gerado de forma autom�tica (sequence) para identificar a f�rmula criada. Criado atrav�s da rotina de gerenciamento de f�rmulas 5xx. |Campo do tipo num�rico, de tamanho 10, sem casas decimais.
        /// </summary>
        private decimal codformula;
        [XmlElement(ElementName = "CODFORMULA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codformula
        {
            get { return  codformula; }
            set {  codformula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Campo para armazenar a descri��o da f�rmula. |Campo do tipo caracter, de tamanho 60.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FILTRO
        /// Coment�rio: Condi��es que dever�o ser verificadas para aplica��o da f�rmula. Estas condi��es ser�o cl�usulas WHERE de um SELECT. |Campo do tipo clob.
        /// </summary>
        private string filtro;
        [XmlElement(ElementName = "FILTRO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Filtro
        {
            get { return  filtro; }
            set {  filtro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMULA
        /// Coment�rio: F�rmula a ser utilizada. |Campo do tipo caracter, de tamanho 1000.
        /// </summary>
        private string formula;
        [XmlElement(ElementName = "FORMULA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Formula
        {
            get { return  formula; }
            set {  formula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HASH
        /// Coment�rio: Assinatura digital do registro, para evitar a utiliza��o de f�rmulas que n�o tenham sido criadas atrav�s da rotina de gerenciamento. |Campo do tipo caracter, de tamanho 32.
        /// </summary>
        private string hash;
        [XmlElement(ElementName = "HASH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,32)]
        public string Hash
        {
            get { return  hash; }
            set {  hash = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PADRAO
        /// Coment�rio: Indica se esta f�rmula � padr�o do WinThor, e caso seja, n�o ser� permitida nenhuma altera��o na mesma. |Campo do tipo caracter, de tamanho 1.
        /// </summary>
        private string padrao;
        [XmlElement(ElementName = "PADRAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Padrao
        {
            get { return  padrao; }
            set {  padrao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFormulac()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFORMULAC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFormulac> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFormulac>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFormulac> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFormulac>(where);
        }

        #endregion
    }
}

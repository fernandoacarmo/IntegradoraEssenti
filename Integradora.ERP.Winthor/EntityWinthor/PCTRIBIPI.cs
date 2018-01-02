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
    /// Classe referente a tabela PCTribipi
    /// </summary>
    [XmlType("PCTRIBIPI")]
    public class PCTribipi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFIGURAIPI
        /// Coment�rio: C�digo da Figura Tribut�ria
        /// </summary>
        private decimal codfiguraipi;
        [XmlElement(ElementName = "CODFIGURAIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiguraipi
        {
            get { return  codfiguraipi; }
            set {  codfiguraipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial.
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do Produto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBIPIENT
        /// Coment�rio: C�digo da Situa��o Tribut�ria de IPI nas Entradas.
        /// </summary>
        private decimal codsittribipient;
        [XmlElement(ElementName = "CODSITTRIBIPIENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribipient
        {
            get { return  codsittribipient; }
            set {  codsittribipient = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBIPISAID
        /// Coment�rio: C�digo da Situa��o Tribut�ria de IPI nas Sa�das.
        /// </summary>
        private decimal codsittribipisaid;
        [XmlElement(ElementName = "CODSITTRIBIPISAID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribipisaid
        {
            get { return  codsittribipisaid; }
            set {  codsittribipisaid = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCTribipi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRIBIPI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCTribipi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTribipi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCTribipi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTribipi>(where);
        }

        #endregion
    }
}

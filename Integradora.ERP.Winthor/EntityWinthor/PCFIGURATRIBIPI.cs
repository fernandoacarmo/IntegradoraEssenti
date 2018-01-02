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
    /// Classe referente a tabela PCFiguratribipi
    /// </summary>
    [XmlType("PCFIGURATRIBIPI")]
    public class PCFiguratribipi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFIGURAIPI
        /// Coment�rio: C�digo da figura tribut�ria.
        /// </summary>
        private decimal codfiguraipi;
        [XmlElement(ElementName = "CODFIGURAIPI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfiguraipi
        {
            get { return  codfiguraipi; }
            set {  codfiguraipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBIPIENT
        /// Coment�rio: C�d.Sit.Trib.IPI Entrada.
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
        /// Coment�rio: C�d.Sit.Trib.IPI Sa�da.
        /// </summary>
        private decimal codsittribipisaid;
        [XmlElement(ElementName = "CODSITTRIBIPISAID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribipisaid
        {
            get { return  codsittribipisaid; }
            set {  codsittribipisaid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o da figura tributaria.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERABASEALIQZERO
        /// Coment�rio: Gerar Base de C�lculo do IPI com Aliquota Zero
        /// </summary>
        private string gerabasealiqzero;
        [XmlElement(ElementName = "GERABASEALIQZERO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerabasealiqzero
        {
            get { return  gerabasealiqzero; }
            set {  gerabasealiqzero = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFiguratribipi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFIGURATRIBIPI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFiguratribipi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFiguratribipi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFiguratribipi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFiguratribipi>(where);
        }

        #endregion
    }
}

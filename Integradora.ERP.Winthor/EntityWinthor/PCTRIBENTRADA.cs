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
    /// Classe referente a tabela PCTribentrada
    /// </summary>
    [XmlType("PCTRIBENTRADA")]
    public class PCTribentrada : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEXCECAOPISCOFINS
        /// Coment�rio: C�digo da exce��o PIS/COFINS
        /// </summary>
        private decimal codexcecaopiscofins;
        [XmlElement(ElementName = "CODEXCECAOPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codexcecaopiscofins
        {
            get { return  codexcecaopiscofins; }
            set {  codexcecaopiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFIGURA
        /// Coment�rio: C�digo figura tribut�ria.
        /// </summary>
        private decimal codfigura;
        [XmlElement(ElementName = "CODFIGURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfigura
        {
            get { return  codfigura; }
            set {  codfigura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial.
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
        /// Propriedade referente ao campo: CODFUNCCAD
        /// Coment�rio: C�digo do Empregado que Cadastrou
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
        /// Propriedade referente ao campo: CODTRIBPISCOFINS
        /// Coment�rio: C�digo da figura tribut�ria para c�lculo do PIS/COFINS
        /// </summary>
        private decimal codtribpiscofins;
        [XmlElement(ElementName = "CODTRIBPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codtribpiscofins
        {
            get { return  codtribpiscofins; }
            set {  codtribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Data do Cadastro
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
        /// Propriedade referente ao campo: NCM
        /// Coment�rio: Nomeclatura Comum do Mercosul.
        /// </summary>
        private string ncm;
        [XmlElement(ElementName = "NCM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Ncm
        {
            get { return  ncm; }
            set {  ncm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��o Tributa��o
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFORNEC
        /// Coment�rio: Tipo do fornecedor.
        /// </summary>
        private string tipofornec;
        [XmlElement(ElementName = "TIPOFORNEC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Tipofornec
        {
            get { return  tipofornec; }
            set {  tipofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFORIGEM
        /// Coment�rio: UF de origem.
        /// </summary>
        private string uforigem;
        [XmlElement(ElementName = "UFORIGEM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Uforigem
        {
            get { return  uforigem; }
            set {  uforigem = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCTribentrada()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRIBENTRADA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCTribentrada> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTribentrada>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCTribentrada> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTribentrada>(where);
        }

        #endregion
    }
}

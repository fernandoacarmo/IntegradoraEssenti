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
    /// Classe referente a tabela PCEstado
    /// </summary>
    [XmlType("PCESTADO")]
    public class PCEstado : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CALCVLCONTABILNFCF
        /// Coment�rio: Indica se gera notas de cupom fiscal com valores zerados no livro fiscal. 
        /// </summary>
        private string calcvlcontabilnfcf;
        [XmlElement(ElementName = "CALCVLCONTABILNFCF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcvlcontabilnfcf
        {
            get { return  calcvlcontabilnfcf; }
            set {  calcvlcontabilnfcf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODESTADUAL
        /// Coment�rio: C�digo estadual.
        /// </summary>
        private decimal codestadual;
        [XmlElement(ElementName = "CODESTADUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codestadual
        {
            get { return  codestadual; }
            set {  codestadual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECGERACAOFECP
        /// Coment�rio: Indica o c�digo do fornecedor do FECP � Fundo Estadual de Combate a Pobreza
        /// </summary>
        private decimal codfornecgeracaofecp;
        [XmlElement(ElementName = "CODFORNECGERACAOFECP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecgeracaofecp
        {
            get { return  codfornecgeracaofecp; }
            set {  codfornecgeracaofecp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECGERACAOFUNCEP
        /// Coment�rio: C�digo Fornecedor gera��o do FUNCEP.
        /// </summary>
        private decimal codfornecgeracaofuncep;
        [XmlElement(ElementName = "CODFORNECGERACAOFUNCEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecgeracaofuncep
        {
            get { return  codfornecgeracaofuncep; }
            set {  codfornecgeracaofuncep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECGERACAOGNRE
        /// Coment�rio: Indica o c�digo do fornecedor da GNRE.
        /// </summary>
        private decimal codfornecgeracaognre;
        [XmlElement(ElementName = "CODFORNECGERACAOGNRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecgeracaognre
        {
            get { return  codfornecgeracaognre; }
            set {  codfornecgeracaognre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIBGE
        /// Coment�rio: 
        /// </summary>
        private decimal codibge;
        [XmlElement(ElementName = "CODIBGE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codibge
        {
            get { return  codibge; }
            set {  codibge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: C�digo da UF. 
        /// </summary>
        private string codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAIS
        /// Coment�rio: 
        /// </summary>
        private decimal codpais;
        [XmlElement(ElementName = "CODPAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpais
        {
            get { return  codpais; }
            set {  codpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Coment�rio: 
        /// </summary>
        private string estado;
        [XmlElement(ElementName = "ESTADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Estado
        {
            get { return  estado; }
            set {  estado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IESUBSTTRIBUT
        /// Coment�rio: 
        /// </summary>
        private string iesubsttribut;
        [XmlElement(ElementName = "IESUBSTTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Iesubsttribut
        {
            get { return  iesubsttribut; }
            set {  iesubsttribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Coment�rio: 
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEstado()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCESTADO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEstado> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEstado>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEstado> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEstado>(where);
        }

        #endregion
    }
}

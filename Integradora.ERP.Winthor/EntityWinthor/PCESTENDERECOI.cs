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
    /// Classe referente a tabela PCEstenderecoi
    /// </summary>
    [XmlType("PCESTENDERECOI")]
    public class PCEstenderecoi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Coment�rio: C�digo do endere�o
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,16)]
        public decimal Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALT
        /// Coment�rio: C�digo do funcion�rio que alterou
        /// </summary>
        private decimal codfuncalt;
        [XmlElement(ElementName = "CODFUNCALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncalt
        {
            get { return  codfuncalt; }
            set {  codfuncalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,16)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFABRICANTE
        /// Coment�rio: C�digo do produto
        /// </summary>
        private decimal codfabricante;
        [XmlElement(ElementName = "CODFABRICANTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 16)]
        public decimal Codfabricante
        {
            get { return codfabricante; }
            set { codfabricante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: C�digo da rotina
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINAALT
        /// Coment�rio: C�digo da rotina de altera��o
        /// </summary>
        private decimal codrotinaalt;
        [XmlElement(ElementName = "CODROTINAALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotinaalt
        {
            get { return  codrotinaalt; }
            set {  codrotinaalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUMA
        /// Coment�rio: C�digo U.M.A.
        /// </summary>
        private decimal coduma;
        [XmlElement(ElementName = "CODUMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Coduma
        {
            get { return  coduma; }
            set {  coduma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALT
        /// Coment�rio: Data de altera��o
        /// </summary>
        private DateTime? dtalt;
        [XmlElement(ElementName = "DTALT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalt
        {
            get { return  dtalt; }
            set {  dtalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTRADA
        /// Coment�rio: Data de entrada
        /// </summary>
        private DateTime? dtentrada;
        [XmlElement(ElementName = "DTENTRADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtentrada
        {
            get { return  dtentrada; }
            set {  dtentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL
        /// Coment�rio: Data de validade
        /// </summary>
        private DateTime? dtfabricacao;
        [XmlElement(ElementName = "DTFABRICACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfabricacao
        {
            get { return dtfabricacao; }
            set { dtfabricacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL
        /// Coment�rio: Data de validade
        /// </summary>
        private DateTime? dtval;
        [XmlElement(ElementName = "DTVAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtval
        {
            get { return dtval; }
            set { dtval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: N�mero do lote
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: Quantidade
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEstenderecoi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCESTENDERECOI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEstenderecoi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEstenderecoi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEstenderecoi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEstenderecoi>(where);
        }

        #endregion
    }
}

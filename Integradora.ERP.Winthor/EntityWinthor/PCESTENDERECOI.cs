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
        /// Comentário: Código do endereço
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
        /// Comentário: Código do funcionário que alterou
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
        /// Comentário: Código do produto
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
        /// Comentário: Código do produto
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
        /// Comentário: Código da rotina
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
        /// Comentário: Código da rotina de alteração
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
        /// Comentário: Código U.M.A.
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
        /// Comentário: Data de alteração
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
        /// Comentário: Data de entrada
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
        /// Comentário: Data de validade
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
        /// Comentário: Data de validade
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
        /// Comentário: Número do lote
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
        /// Comentário: Quantidade
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEstenderecoi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEstenderecoi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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

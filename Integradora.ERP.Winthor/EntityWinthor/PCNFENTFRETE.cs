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
    /// Classe referente a tabela PCNfentfrete
    /// </summary>
    [XmlType("PCNFENTFRETE")]
    public class PCNfentfrete : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: Código do fornecedor
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Rotina.
        /// </summary>
        private string codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: Número da nota.
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: Número de transação de entrada.
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTNF
        /// Comentário: Número de transação de entrada da nota fiscal.
        /// </summary>
        private decimal numtransentnf;
        [XmlElement(ElementName = "NUMTRANSENTNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentnf
        {
            get { return  numtransentnf; }
            set {  numtransentnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOFRETE
        /// Comentário: Indica o peso do frete.
        /// </summary>
        private decimal pesofrete;
        [XmlElement(ElementName = "PESOFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pesofrete
        {
            get { return  pesofrete; }
            set {  pesofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: Série.
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALFRETE
        /// Comentário: Valor total do frete.
        /// </summary>
        private decimal vltotalfrete;
        [XmlElement(ElementName = "VLTOTALFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalfrete
        {
            get { return  vltotalfrete; }
            set {  vltotalfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALIPI
        /// Comentário: Valor total do IPI de todas as notas fiscais que compõe o conhecimento de frete
        /// </summary>
        private decimal vltotalipi;
        [XmlElement(ElementName = "VLTOTALIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotalipi
        {
            get { return  vltotalipi; }
            set {  vltotalipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALNF
        /// Comentário: Valor da nota.
        /// </summary>
        private decimal vltotalnf;
        [XmlElement(ElementName = "VLTOTALNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalnf
        {
            get { return  vltotalnf; }
            set {  vltotalnf = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCNfentfrete()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNFENTFRETE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNfentfrete> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfentfrete>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCNfentfrete> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNfentfrete>(where);
        }

        #endregion
    }
}

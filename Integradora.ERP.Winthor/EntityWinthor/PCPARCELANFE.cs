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
    /// Classe referente a tabela PCParcelanfe
    /// </summary>
    [XmlType("PCPARCELANFE")]
    public class PCParcelanfe : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: Data de vencimento
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DUPLIC
        /// Coment�rio: N�mero da duplicata
        /// </summary>
        private decimal duplic;
        [XmlElement(ElementName = "DUPLIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Duplic
        {
            get { return  duplic; }
            set {  duplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Coment�rio: N�mero da transa��o
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Coment�rio: Presta��o
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor da presta��o
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCParcelanfe()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARCELANFE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCParcelanfe> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParcelanfe>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCParcelanfe> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParcelanfe>(where);
        }

        #endregion
    }
}

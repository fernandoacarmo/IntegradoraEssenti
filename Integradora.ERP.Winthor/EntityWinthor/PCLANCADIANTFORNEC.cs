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
    /// Classe referente a tabela PCLancadiantfornec
    /// </summary>
    [XmlType("PCLANCADIANTFORNEC")]
    public class PCLancadiantfornec : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DTESTORNO
        /// Comentário: Data do estorno do lançamento
        /// </summary>
        private DateTime? dtestorno;
        [XmlElement(ElementName = "DTESTORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtestorno
        {
            get { return  dtestorno; }
            set {  dtestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Comentário: Data do lançamento do abatimento
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSADIANTFOR
        /// Comentário: Número sequencial do NUMTRANS
        /// </summary>
        private decimal numtransadiantfor;
        [XmlElement(ElementName = "NUMTRANSADIANTFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numtransadiantfor
        {
            get { return  numtransadiantfor; }
            set {  numtransadiantfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUMADIANTAMENTO
        /// Comentário: ID da tabela PCLANC do lançamento de adiantamento
        /// </summary>
        private decimal recnumadiantamento;
        [XmlElement(ElementName = "RECNUMADIANTAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnumadiantamento
        {
            get { return  recnumadiantamento; }
            set {  recnumadiantamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUMPAGTO
        /// Comentário: ID da tabela PCLANC do lançamento do título
        /// </summary>
        private decimal recnumpagto;
        [XmlElement(ElementName = "RECNUMPAGTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnumpagto
        {
            get { return  recnumpagto; }
            set {  recnumpagto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: Valor utilizado no abatimento
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLancadiantfornec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLANCADIANTFORNEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLancadiantfornec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLancadiantfornec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLancadiantfornec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLancadiantfornec>(where);
        }

        #endregion
    }
}

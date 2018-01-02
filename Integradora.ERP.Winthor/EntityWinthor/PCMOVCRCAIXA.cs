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
    /// Classe referente a tabela PCMovcrcaixa
    /// </summary>
    [XmlType("PCMOVCRCAIXA")]
    public class PCMovcrcaixa : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: Indica o c�digo cobran�a.
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Coment�rio: Indica o c�digo conta receita ou despesa.
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica o c�digo da filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: Indica o c�digo funcion�rio respons�vel pelo caixa.
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARCEIRO
        /// Coment�rio: Indica o c�digo do parceiro.
        /// </summary>
        private decimal codparceiro;
        [XmlElement(ElementName = "CODPARCEIRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codparceiro
        {
            get { return  codparceiro; }
            set {  codparceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: Indica o data de vencimento.
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
        /// Propriedade referente ao campo: NUMDOC
        /// Coment�rio: Indica o n�mero do documento.
        /// </summary>
        private decimal numdoc;
        [XmlElement(ElementName = "NUMDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numdoc
        {
            get { return  numdoc; }
            set {  numdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Coment�rio: Armazena c�digo do banco o qual caixa foi acertado.
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAO
        /// Coment�rio: Indica o tipo de opera��o.
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQDOC
        /// Coment�rio: Indica o sequ�ncia do documento.
        /// </summary>
        private string seqdoc;
        [XmlElement(ElementName = "SEQDOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Seqdoc
        {
            get { return  seqdoc; }
            set {  seqdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPARCEIRO
        /// Coment�rio: Indica o tipo do parceiro.
        /// </summary>
        private string tipoparceiro;
        [XmlElement(ElementName = "TIPOPARCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoparceiro
        {
            get { return  tipoparceiro; }
            set {  tipoparceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXPERM
        /// Coment�rio: Indica o valor dos juros.
        /// </summary>
        private decimal txperm;
        [XmlElement(ElementName = "TXPERM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Txperm
        {
            get { return  txperm; }
            set {  txperm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Indica o valor documento.
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDESC
        /// Coment�rio: Indica o valor do desconto.
        /// </summary>
        private decimal valordesc;
        [XmlElement(ElementName = "VALORDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valordesc
        {
            get { return  valordesc; }
            set {  valordesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VPAGO
        /// Coment�rio: Indica o valor pago.
        /// </summary>
        private decimal vpago;
        [XmlElement(ElementName = "VPAGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vpago
        {
            get { return  vpago; }
            set {  vpago = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMovcrcaixa()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVCRCAIXA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMovcrcaixa> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovcrcaixa>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMovcrcaixa> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovcrcaixa>(where);
        }

        #endregion
    }
}

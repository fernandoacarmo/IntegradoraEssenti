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
    /// Classe referente a tabela PCVerbacontratoc
    /// </summary>
    [XmlType("PCVERBACONTRATOC")]
    public class PCVerbacontratoc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CALCVLSEMIMPOSTO
        /// Coment�rio: Para calcular o produto utilizando ou n�o o valor dos impostos.
        /// </summary>
        private string calcvlsemimposto;
        [XmlElement(ElementName = "CALCVLSEMIMPOSTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Calcvlsemimposto
        {
            get { return  calcvlsemimposto; }
            set {  calcvlsemimposto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Coment�rio: C�digo da conta gerencial.
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo do fornecedor.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: C�digo da rotina que gerou o contrato.
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
        /// Propriedade referente ao campo: CODTIPOVERBA
        /// Coment�rio: C�digo do tipo da verba.
        /// </summary>
        private decimal codtipoverba;
        [XmlElement(ElementName = "CODTIPOVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codtipoverba
        {
            get { return  codtipoverba; }
            set {  codtipoverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALT
        /// Coment�rio: C�digo do usu�rio que alterou o contrato.
        /// </summary>
        private decimal codusuarioalt;
        [XmlElement(ElementName = "CODUSUARIOALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioalt
        {
            get { return  codusuarioalt; }
            set {  codusuarioalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOEXC
        /// Coment�rio: C�digo do usu�rio que excluiu o contrato.
        /// </summary>
        private decimal codusuarioexc;
        [XmlElement(ElementName = "CODUSUARIOEXC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioexc
        {
            get { return  codusuarioexc; }
            set {  codusuarioexc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOINC
        /// Coment�rio: C�digo do usu�rio que incluiu o contrato.
        /// </summary>
        private decimal codusuarioinc;
        [XmlElement(ElementName = "CODUSUARIOINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioinc
        {
            get { return  codusuarioinc; }
            set {  codusuarioinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: Data altera��o do contrato.
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONTRATO
        /// Coment�rio: Data do acordo do contrato com o fornecedor.
        /// </summary>
        private DateTime? dtcontrato;
        [XmlElement(ElementName = "DTCONTRATO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcontrato
        {
            get { return  dtcontrato; }
            set {  dtcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: Data exclus�o do contrato.
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINAL
        /// Coment�rio: Data final da virg�ncia do contrato.
        /// </summary>
        private DateTime? dtfinal;
        [XmlElement(ElementName = "DTFINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtfinal
        {
            get { return  dtfinal; }
            set {  dtfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Coment�rio: Data de inclus�o do contrato no sistema.
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIAL
        /// Coment�rio: Data inicial da virg�ncia do contrato.
        /// </summary>
        private DateTime? dtinicial;
        [XmlElement(ElementName = "DTINICIAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinicial
        {
            get { return  dtinicial; }
            set {  dtinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERADESCONTOFIN
        /// Coment�rio: Se o valor da verba gerado ser� utilizado ou n�o para desconto de duplicada do contas a pagar.
        /// </summary>
        private string geradescontofin;
        [XmlElement(ElementName = "GERADESCONTOFIN", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Geradescontofin
        {
            get { return  geradescontofin; }
            set {  geradescontofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO1
        /// Coment�rio: Historico para gera��o da verba.
        /// </summary>
        private string historico1;
        [XmlElement(ElementName = "HISTORICO1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Historico1
        {
            get { return  historico1; }
            set {  historico1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO2
        /// Coment�rio: Historico para gera��o de verbas, continua��o.
        /// </summary>
        private string historico2;
        [XmlElement(ElementName = "HISTORICO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Historico2
        {
            get { return  historico2; }
            set {  historico2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATO
        /// Coment�rio: N�mero do contrato.
        /// </summary>
        private decimal numcontrato;
        [XmlElement(ElementName = "NUMCONTRATO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,12)]
        public decimal Numcontrato
        {
            get { return  numcontrato; }
            set {  numcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOPAGTO
        /// Coment�rio: Prazo de pagamento da verba gerada.
        /// </summary>
        private decimal prazopagto;
        [XmlElement(ElementName = "PRAZOPAGTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public decimal Prazopagto
        {
            get { return  prazopagto; }
            set {  prazopagto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUPERVISOR
        /// Coment�rio: Supervisor respons�vel pela fornecedor.
        /// </summary>
        private string supervisor;
        [XmlElement(ElementName = "SUPERVISOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Supervisor
        {
            get { return  supervisor; }
            set {  supervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTRATO
        /// Coment�rio: Tipo de contrato: Por Fornecedor ou Por Produto.
        /// </summary>
        private string tipocontrato;
        [XmlElement(ElementName = "TIPOCONTRATO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipocontrato
        {
            get { return  tipocontrato; }
            set {  tipocontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOINDICE
        /// Coment�rio: Tipo do �ndice: Calculo por Percentual ou por Valor.
        /// </summary>
        private string tipoindice;
        [XmlElement(ElementName = "TIPOINDICE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipoindice
        {
            get { return  tipoindice; }
            set {  tipoindice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVERBA
        /// Coment�rio: Tipo da verba: Mercadoria, Dinheiro ou Outros.
        /// </summary>
        private string tipoverba;
        [XmlElement(ElementName = "TIPOVERBA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipoverba
        {
            get { return  tipoverba; }
            set {  tipoverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLINDICE
        /// Coment�rio: Valor do �ndice (podendo ser percentual ou valor, de acordo com a op��o marcada acima).
        /// </summary>
        private decimal vlindice;
        [XmlElement(ElementName = "VLINDICE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Vlindice
        {
            get { return  vlindice; }
            set {  vlindice = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCVerbacontratoc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVERBACONTRATOC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCVerbacontratoc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCVerbacontratoc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCVerbacontratoc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCVerbacontratoc>(where);
        }

        #endregion
    }
}

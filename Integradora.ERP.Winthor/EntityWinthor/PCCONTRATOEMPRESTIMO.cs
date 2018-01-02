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
    /// Classe referente a tabela PCContratoemprestimo
    /// </summary>
    [XmlType("PCCONTRATOEMPRESTIMO")]
    public class PCContratoemprestimo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: Código do caixa/banco (não utilizado no empréstimo FINIMP)
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: Código parceiro(banco)
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
        /// Propriedade referente ao campo: DTCONTRATO
        /// Comentário: Data do contrato de empréstimo FINIMP
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
        /// Propriedade referente ao campo: DTCOTACAO
        /// Comentário: Data da cotação da moeda estrangeira de negociação
        /// </summary>
        private DateTime? dtcotacao;
        [XmlElement(ElementName = "DTCOTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcotacao
        {
            get { return  dtcotacao; }
            set {  dtcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOEDAESTRANGEIRA
        /// Comentário: Código da moeda estrangeira de negociação
        /// </summary>
        private decimal moedaestrangeira;
        [XmlElement(ElementName = "MOEDAESTRANGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Moedaestrangeira
        {
            get { return  moedaestrangeira; }
            set {  moedaestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOEDANACIONAL
        /// Comentário: Gravar sempre 'S' se o empréstimo foi adquirido em moeda nacional e 'N' se foi adquirido em moeda estrangeira
        /// </summary>
        private string moedanacional;
        [XmlElement(ElementName = "MOEDANACIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Moedanacional
        {
            get { return  moedanacional; }
            set {  moedanacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATO
        /// Comentário: Número do contrato de empréstimo FINIMP
        /// </summary>
        private string numcontrato;
        [XmlElement(ElementName = "NUMCONTRATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcontrato
        {
            get { return  numcontrato; }
            set {  numcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQCONTRATOEMPRESTIMO
        /// Comentário: Número sequencial do contrato
        /// </summary>
        private decimal numseqcontratoemprestimo;
        [XmlElement(ElementName = "NUMSEQCONTRATOEMPRESTIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numseqcontratoemprestimo
        {
            get { return  numseqcontratoemprestimo; }
            set {  numseqcontratoemprestimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Observações definidas pelo usuário
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOPER
        /// Comentário: Prazo da operação do empréstimo FINIMP
        /// </summary>
        private decimal prazoper;
        [XmlElement(ElementName = "PRAZOPER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoper
        {
            get { return  prazoper; }
            set {  prazoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTRATO
        /// Comentário: Tipo do contrato
        /// </summary>
        private string tipocontrato;
        [XmlElement(ElementName = "TIPOCONTRATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocontrato
        {
            get { return  tipocontrato; }
            set {  tipocontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMPRESTIMO
        /// Comentário: Tipo do emprestimo
        /// </summary>
        private string tipoemprestimo;
        [XmlElement(ElementName = "TIPOEMPRESTIMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoemprestimo
        {
            get { return  tipoemprestimo; }
            set {  tipoemprestimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXJURO
        /// Comentário: Taxa de juros
        /// </summary>
        private decimal txjuro;
        [XmlElement(ElementName = "TXJURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Txjuro
        {
            get { return  txjuro; }
            set {  txjuro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORPRINCIPAL
        /// Comentário: Valor principal do contrato.
        /// </summary>
        private decimal valorprincipal;
        [XmlElement(ElementName = "VALORPRINCIPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorprincipal
        {
            get { return  valorprincipal; }
            set {  valorprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRTOTAL
        /// Comentário: Valor total do empréstimo em reais
        /// </summary>
        private decimal vlrtotal;
        [XmlElement(ElementName = "VLRTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlrtotal
        {
            get { return  vlrtotal; }
            set {  vlrtotal = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCContratoemprestimo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTRATOEMPRESTIMO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCContratoemprestimo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContratoemprestimo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCContratoemprestimo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContratoemprestimo>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCDocarrecadacao
    /// </summary>
    [XmlType("PCDOCARRECADACAO")]
    public class PCDocarrecadacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AUTENTBANCARIA
        /// Comentário: Autentificação bancária.
        /// </summary>
        private string autentbancaria;
        [XmlElement(ElementName = "AUTENTBANCARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Autentbancaria
        {
            get { return  autentbancaria; }
            set {  autentbancaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONT
        /// Comentário: Código da conta.
        /// </summary>
        private decimal codcont;
        [XmlElement(ElementName = "CODCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcont
        {
            get { return  codcont; }
            set {  codcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOC
        /// Comentário: Código do documento.
        /// </summary>
        private decimal coddoc;
        [XmlElement(ElementName = "CODDOC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Coddoc
        {
            get { return  coddoc; }
            set {  coddoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMODELO
        /// Comentário: Código do modelo.
        /// </summary>
        private decimal codmodelo;
        [XmlElement(ElementName = "CODMODELO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Codmodelo
        {
            get { return  codmodelo; }
            set {  codmodelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGAMENTO
        /// Comentário: Data do pagamento.
        /// </summary>
        private DateTime? dtpagamento;
        [XmlElement(ElementName = "DTPAGAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpagamento
        {
            get { return  dtpagamento; }
            set {  dtpagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCIMENTO
        /// Comentário: Data do vencimento.
        /// </summary>
        private DateTime? dtvencimento;
        [XmlElement(ElementName = "DTVENCIMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencimento
        {
            get { return  dtvencimento; }
            set {  dtvencimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDOC
        /// Comentário: Número do documento.
        /// </summary>
        private string numdoc;
        [XmlElement(ElementName = "NUMDOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numdoc
        {
            get { return  numdoc; }
            set {  numdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: Número da transação de entrada.
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
        /// Propriedade referente ao campo: UF
        /// Comentário: Uf beneficiada.
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTARRECADACAO
        /// Comentário: Valor total da arrecadação.
        /// </summary>
        private decimal vltotarrecadacao;
        [XmlElement(ElementName = "VLTOTARRECADACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vltotarrecadacao
        {
            get { return  vltotarrecadacao; }
            set {  vltotarrecadacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDocarrecadacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDOCARRECADACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDocarrecadacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDocarrecadacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDocarrecadacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDocarrecadacao>(where);
        }

        #endregion
    }
}

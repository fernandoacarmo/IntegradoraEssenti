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
    /// Classe referente a tabela PCPrestdni
    /// </summary>
    [XmlType("PCPRESTDNI")]
    public class PCPrestdni : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: Código do banco.
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
        /// Propriedade referente ao campo: DTBAIXA
        /// Comentário: Data da baixa.
        /// </summary>
        private DateTime? dtbaixa;
        [XmlElement(ElementName = "DTBAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbaixa
        {
            get { return  dtbaixa; }
            set {  dtbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTESTORNOBAIXA
        /// Comentário: Data do estorno da baixa.
        /// </summary>
        private DateTime? dtestornobaixa;
        [XmlElement(ElementName = "DTESTORNOBAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtestornobaixa
        {
            get { return  dtestornobaixa; }
            set {  dtestornobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDOC
        /// Comentário: Núm. Identificação.
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
        /// Propriedade referente ao campo: NUMTRANSBAIXA
        /// Comentário: Núm. Transação da baixa.
        /// </summary>
        private decimal numtransbaixa;
        [XmlElement(ElementName = "NUMTRANSBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransbaixa
        {
            get { return  numtransbaixa; }
            set {  numtransbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSESTORNO
        /// Comentário: Núm. Transação do estorno baixa.
        /// </summary>
        private decimal numtransestorno;
        [XmlElement(ElementName = "NUMTRANSESTORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransestorno
        {
            get { return  numtransestorno; }
            set {  numtransestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSORIGEM
        /// Comentário: Núm. Transação do lançamento DNI.
        /// </summary>
        private decimal numtransorigem;
        [XmlElement(ElementName = "NUMTRANSORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransorigem
        {
            get { return  numtransorigem; }
            set {  numtransorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: Núm. Transação venda titulo.
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Comentário: Núm.  Prestação do título.
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: Valor associação.
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
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
        public PCPrestdni()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRESTDNI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPrestdni> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrestdni>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPrestdni> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrestdni>(where);
        }

        #endregion
    }
}

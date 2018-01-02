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
    /// Classe referente a tabela PCBancofornec
    /// </summary>
    [XmlType("PCBANCOFORNEC")]
    public class PCBancofornec : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGENCIA
        /// Comentário: Identificação da Agência.
        /// </summary>
        private string agencia;
        [XmlElement(ElementName = "AGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Agencia
        {
            get { return  agencia; }
            set {  agencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BANCO
        /// Comentário: Identificação do Banco.
        /// </summary>
        private string banco;
        [XmlElement(ElementName = "BANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Banco
        {
            get { return  banco; }
            set {  banco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: Código do Fornecedor.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTACORRENTE
        /// Comentário: Identificação conta corrente.
        /// </summary>
        private string contacorrente;
        [XmlElement(ElementName = "CONTACORRENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Contacorrente
        {
            get { return  contacorrente; }
            set {  contacorrente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: Endereço completo da agência bancária.
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IBAN
        /// Comentário: Identificação do código iBan.
        /// </summary>
        private string iban;
        [XmlElement(ElementName = "IBAN", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Iban
        {
            get { return  iban; }
            set {  iban = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SWIFT
        /// Comentário: Código Swift emitido pelo banqueiro.
        /// </summary>
        private string swift;
        [XmlElement(ElementName = "SWIFT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Swift
        {
            get { return  swift; }
            set {  swift = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCBancofornec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBANCOFORNEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBancofornec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBancofornec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCBancofornec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBancofornec>(where);
        }

        #endregion
    }
}

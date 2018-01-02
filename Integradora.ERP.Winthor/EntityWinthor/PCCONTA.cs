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
    /// Classe referente a tabela PCConta
    /// </summary>
    [XmlType("PCCONTA")]
    public class PCConta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BONIFIC
        /// Comentário: 
        /// </summary>
        private string bonific;
        [XmlElement(ElementName = "BONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bonific
        {
            get { return  bonific; }
            set {  bonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCENTROCUSTOPADRAO
        /// Comentário: Código do Centro de Custo Padrão
        /// </summary>
        private decimal codcentrocustopadrao;
        [XmlElement(ElementName = "CODCENTROCUSTOPADRAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcentrocustopadrao
        {
            get { return  codcentrocustopadrao; }
            set {  codcentrocustopadrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Comentário: 
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACONTRAPARTIDA
        /// Comentário: 
        /// </summary>
        private decimal codcontacontrapartida;
        [XmlElement(ElementName = "CODCONTACONTRAPARTIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacontrapartida
        {
            get { return  codcontacontrapartida; }
            set {  codcontacontrapartida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAMASTER
        /// Comentário: 
        /// </summary>
        private decimal codcontamaster;
        [XmlElement(ElementName = "CODCONTAMASTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontamaster
        {
            get { return  codcontamaster; }
            set {  codcontamaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEVENTOINTFOLHA
        /// Comentário: Cód. Evento folha - RM
        /// </summary>
        private string codeventointfolha;
        [XmlElement(ElementName = "CODEVENTOINTFOLHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Codeventointfolha
        {
            get { return  codeventointfolha; }
            set {  codeventointfolha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSECAOINTFOLHA
        /// Comentário: Código da seção integração folha
        /// </summary>
        private string codsecaointfolha;
        [XmlElement(ElementName = "CODSECAOINTFOLHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Codsecaointfolha
        {
            get { return  codsecaointfolha; }
            set {  codsecaointfolha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTA
        /// Comentário: 
        /// </summary>
        private string conta;
        [XmlElement(ElementName = "CONTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Conta
        {
            get { return  conta; }
            set {  conta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTACONTABIL
        /// Comentário: 
        /// </summary>
        private string contacontabil;
        [XmlElement(ElementName = "CONTACONTABIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Contacontabil
        {
            get { return  contacontabil; }
            set {  contacontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIXAVARIAVEL
        /// Comentário: 
        /// </summary>
        private string fixavariavel;
        [XmlElement(ElementName = "FIXAVARIAVEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fixavariavel
        {
            get { return  fixavariavel; }
            set {  fixavariavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAPROVLANCCONTAB
        /// Comentário: 
        /// </summary>
        private string geraprovlanccontab;
        [XmlElement(ElementName = "GERAPROVLANCCONTAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraprovlanccontab
        {
            get { return  geraprovlanccontab; }
            set {  geraprovlanccontab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOCONTA
        /// Comentário: 
        /// </summary>
        private decimal grupoconta;
        [XmlElement(ElementName = "GRUPOCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Grupoconta
        {
            get { return  grupoconta; }
            set {  grupoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INVESTIMENTO
        /// Comentário: 
        /// </summary>
        private string investimento;
        [XmlElement(ElementName = "INVESTIMENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Investimento
        {
            get { return  investimento; }
            set {  investimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARATEIOCENTROCUSTO
        /// Comentário: Usa rateio por Centro de Custo?
        /// </summary>
        private string usarateiocentrocusto;
        [XmlElement(ElementName = "USARATEIOCENTROCUSTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Usarateiocentrocusto
        {
            get { return  usarateiocentrocusto; }
            set {  usarateiocentrocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERBA
        /// Comentário: Conta contábil de verba.
        /// </summary>
        private string verba;
        [XmlElement(ElementName = "VERBA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verba
        {
            get { return  verba; }
            set {  verba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCAMES
        /// Comentário: 
        /// </summary>
        private decimal vlorcames;
        [XmlElement(ElementName = "VLORCAMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcames
        {
            get { return  vlorcames; }
            set {  vlorcames = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConta>(where);
        }

        #endregion
    }
}

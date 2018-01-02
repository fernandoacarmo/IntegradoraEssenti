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
    /// Classe referente a tabela PCTabdev
    /// </summary>
    [XmlType("PCTABDEV")]
    public class PCTabdev : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIACLIENTE
        /// Comentário: Motivo da devolução determina uma possível condição de bloqueio do cliente.
        /// </summary>
        private string bloqueiacliente;
        [XmlElement(ElementName = "BLOQUEIACLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueiacliente
        {
            get { return  bloqueiacliente; }
            set {  bloqueiacliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODDEVOL
        /// Comentário: 
        /// </summary>
        private decimal coddevol;
        [XmlElement(ElementName = "CODDEVOL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Coddevol
        {
            get { return  coddevol; }
            set {  coddevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTFORNECNESTLE
        /// Comentário: 
        /// </summary>
        private decimal codmotfornecnestle;
        [XmlElement(ElementName = "CODMOTFORNECNESTLE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmotfornecnestle
        {
            get { return  codmotfornecnestle; }
            set {  codmotfornecnestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTNESTLE
        /// Comentário: 
        /// </summary>
        private decimal codmotnestle;
        [XmlElement(ElementName = "CODMOTNESTLE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmotnestle
        {
            get { return  codmotnestle; }
            set {  codmotnestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTORNACOMISSAO
        /// Comentário: 
        /// </summary>
        private string estornacomissao;
        [XmlElement(ElementName = "ESTORNACOMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Estornacomissao
        {
            get { return  estornacomissao; }
            set {  estornacomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MANTERCREDITO
        /// Comentário: Manter o débito relativo ao desconto financeiro.
        /// </summary>
        private string mantercredito;
        [XmlElement(ElementName = "MANTERCREDITO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Mantercredito
        {
            get { return  mantercredito; }
            set {  mantercredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MANTERDEBITODESCFIN
        /// Comentário: Manter o débito relativo ao desconto financeiro.
        /// </summary>
        private string manterdebitodescfin;
        [XmlElement(ElementName = "MANTERDEBITODESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Manterdebitodescfin
        {
            get { return  manterdebitodescfin; }
            set {  manterdebitodescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Comentário: 
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,30)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCESTCOM
        /// Comentário: 
        /// </summary>
        private decimal percestcom;
        [XmlElement(ElementName = "PERCESTCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percestcom
        {
            get { return  percestcom; }
            set {  percestcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCESTCOMMOT
        /// Comentário: Percentual de estorno para comissão de motorista. Será aplicado só na geração do relatório de apuração de comissão para motorista. 
        /// </summary>
        private decimal percestcommot;
        [XmlElement(ElementName = "PERCESTCOMMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percestcommot
        {
            get { return  percestcommot; }
            set {  percestcommot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RETORNOVENDANAOENTREGUEAODEST
        /// Comentário: Define é uma operação de Retorno de Venda não entregue ao destinatário
        /// </summary>
        private string retornovendanaoentregueaodest;
        [XmlElement(ElementName = "RETORNOVENDANAOENTREGUEAODEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Retornovendanaoentregueaodest
        {
            get { return  retornovendanaoentregueaodest; }
            set {  retornovendanaoentregueaodest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTabdev()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTABDEV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTabdev> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTabdev>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTabdev> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTabdev>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCLfpisreg0111
    /// </summary>
    [XmlType("PCLFPISREG0111")]
    public class PCLfpisreg0111 : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da Filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFIM
        /// Comentário: Data Final do Período Selecionado.
        /// </summary>
        private DateTime? datafim;
        [XmlElement(ElementName = "DATAFIM", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Datafim
        {
            get { return  datafim; }
            set {  datafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINI
        /// Comentário: Data Inicial do Período Selecionado.
        /// </summary>
        private DateTime? dataini;
        [XmlElement(ElementName = "DATAINI", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dataini
        {
            get { return  dataini; }
            set {  dataini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECBRUCUM
        /// Comentário: Receita Bruta Cumulativa.
        /// </summary>
        private decimal recbrucum;
        [XmlElement(ElementName = "RECBRUCUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Recbrucum
        {
            get { return  recbrucum; }
            set {  recbrucum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECBRUNCUMEXP
        /// Comentário: Receita Bruta Não-Cumulativa - Exportação.
        /// </summary>
        private decimal recbruncumexp;
        [XmlElement(ElementName = "RECBRUNCUMEXP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Recbruncumexp
        {
            get { return  recbruncumexp; }
            set {  recbruncumexp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECBRUNCUMNTMI
        /// Comentário: Receita Bruta Não-Cumulativa ¿ Não Tributada no Mercado Interno.
        /// </summary>
        private decimal recbruncumntmi;
        [XmlElement(ElementName = "RECBRUNCUMNTMI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Recbruncumntmi
        {
            get { return  recbruncumntmi; }
            set {  recbruncumntmi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECBRUNCUMTRIBMI
        /// Comentário: Receita Bruta não Cumulativa Tributada no Mercado Interno.
        /// </summary>
        private decimal recbruncumtribmi;
        [XmlElement(ElementName = "RECBRUNCUMTRIBMI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Recbruncumtribmi
        {
            get { return  recbruncumtribmi; }
            set {  recbruncumtribmi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECBRUTOTAL
        /// Comentário: Receita Bruta Total.
        /// </summary>
        private decimal recbrutotal;
        [XmlElement(ElementName = "RECBRUTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Recbrutotal
        {
            get { return  recbrutotal; }
            set {  recbrutotal = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLfpisreg0111()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLFPISREG0111";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLfpisreg0111> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLfpisreg0111>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLfpisreg0111> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLfpisreg0111>(where);
        }

        #endregion
    }
}

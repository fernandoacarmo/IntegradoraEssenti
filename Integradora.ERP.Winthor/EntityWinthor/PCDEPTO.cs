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
    /// Classe referente a tabela PCDepto
    /// </summary>
    [XmlType("PCDEPTO")]
    public class PCDepto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAINVGERAL
        /// Comentário: 
        /// </summary>
        private string atualizainvgeral;
        [XmlElement(ElementName = "ATUALIZAINVGERAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizainvgeral
        {
            get { return  atualizainvgeral; }
            set {  atualizainvgeral = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Comentário: 
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,25)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: EMITEQTUNIT
        /// Comentário: 
        /// </summary>
        private string emiteqtunit;
        [XmlElement(ElementName = "EMITEQTUNIT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emiteqtunit
        {
            get { return  emiteqtunit; }
            set {  emiteqtunit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAGENTO_ID
        /// Comentário: 
        /// </summary>
        private string magento_id;
        [XmlElement(ElementName = "MAGENTO_ID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Magento_Id
        {
            get { return  magento_id; }
            set {  magento_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMPREVISTA
        /// Comentário: %de margem prevista padrão  de lucratividade
        /// </summary>
        private decimal margemprevista;
        [XmlElement(ElementName = "MARGEMPREVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Margemprevista
        {
            get { return  margemprevista; }
            set {  margemprevista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMGARANTIDA
        /// Comentário: % Com.mín.garantida
        /// </summary>
        private decimal perccomgarantida;
        [XmlElement(ElementName = "PERCCOMGARANTIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perccomgarantida
        {
            get { return  perccomgarantida; }
            set {  perccomgarantida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMARGEMPREV
        /// Comentário: 
        /// </summary>
        private decimal percmargemprev;
        [XmlElement(ElementName = "PERCMARGEMPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percmargemprev
        {
            get { return  percmargemprev; }
            set {  percmargemprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTVENDAPREV
        /// Comentário: 
        /// </summary>
        private decimal percpartvendaprev;
        [XmlElement(ElementName = "PERCPARTVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percpartvendaprev
        {
            get { return  percpartvendaprev; }
            set {  percpartvendaprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXAVISTA
        /// Comentário: % Desc.máximo venda a vista
        /// </summary>
        private decimal perdescmaxavista;
        [XmlElement(ElementName = "PERDESCMAXAVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxavista
        {
            get { return  perdescmaxavista; }
            set {  perdescmaxavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXIDEAL
        /// Comentário: % Desc.máximo ideal para venda.
        /// </summary>
        private decimal perdescmaxideal;
        [XmlElement(ElementName = "PERDESCMAXIDEAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxideal
        {
            get { return  perdescmaxideal; }
            set {  perdescmaxideal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXPOSSIVEL
        /// Comentário: % Desc.máximo possível para venda
        /// </summary>
        private decimal perdescmaxpossivel;
        [XmlElement(ElementName = "PERDESCMAXPOSSIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxpossivel
        {
            get { return  perdescmaxpossivel; }
            set {  perdescmaxpossivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFERENCIA
        /// Comentário: Referencia interna
        /// </summary>
        private string referencia;
        [XmlElement(ElementName = "REFERENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Referencia
        {
            get { return  referencia; }
            set {  referencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMERC
        /// Comentário: 
        /// </summary>
        private string tipomerc;
        [XmlElement(ElementName = "TIPOMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomerc
        {
            get { return  tipomerc; }
            set {  tipomerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USANOECOMMERCE
        /// Comentário: 
        /// </summary>
        private string usanoecommerce;
        [XmlElement(ElementName = "USANOECOMMERCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usanoecommerce
        {
            get { return  usanoecommerce; }
            set {  usanoecommerce = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDepto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDEPTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDepto> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDepto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDepto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDepto>(where);
        }

        #endregion
    }
}

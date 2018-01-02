using Integradora.Database.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.UseAll.EntityOracle
{
    /// <summary>
    /// Classe referente a tabela Outrascob_Cergrand
    /// </summary>
    [XmlType("OUTRASCOB_CERGRAND")]
    public class Outrascob_Cergrand : OracleObjeto
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO_FATURA
        /// Comentário: 
        /// </summary>
        private decimal ano_fatura;
        [XmlElement(ElementName = "ANO_FATURA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Ano_Fatura
        {
            get { return  ano_fatura; }
            set {  ano_fatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_LANCTO
        /// Comentário: 
        /// </summary>
        private DateTime? data_lancto;
        [XmlElement(ElementName = "DATA_LANCTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data_Lancto
        {
            get { return  data_lancto; }
            set {  data_lancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDEVEREST
        /// Comentário: 
        /// </summary>
        private string ideverest;
        [XmlElement(ElementName = "IDEVEREST", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,200)]
        public string Ideverest
        {
            get { return  ideverest; }
            set {  ideverest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDOUTRASCOBUC
        /// Comentário: 
        /// </summary>
        private decimal idoutrascobuc;
        [XmlElement(ElementName = "IDOUTRASCOBUC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idoutrascobuc
        {
            get { return  idoutrascobuc; }
            set {  idoutrascobuc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID_CONTA
        /// Comentário: 
        /// </summary>
        private decimal id_conta;
        [XmlElement(ElementName = "ID_CONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Id_Conta
        {
            get { return  id_conta; }
            set {  id_conta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID_ITEM
        /// Comentário: 
        /// </summary>
        private decimal id_item;
        [XmlElement(ElementName = "ID_ITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Id_Item
        {
            get { return  id_item; }
            set {  id_item = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID_ZONA
        /// Comentário: 
        /// </summary>
        private decimal id_zona;
        [XmlElement(ElementName = "ID_ZONA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Id_Zona
        {
            get { return  id_zona; }
            set {  id_zona = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES_FATURA
        /// Comentário: 
        /// </summary>
        private decimal mes_fatura;
        [XmlElement(ElementName = "MES_FATURA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Mes_Fatura
        {
            get { return  mes_fatura; }
            set {  mes_fatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
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
        public Outrascob_Cergrand()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "OUTRASCOB_CERGRAND";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Outrascob_Cergrand> Listar(string where)
        {
            Persistencia ba = new Persistencia(Outrascob_Cergrand.GetStringConnection());
            return ba.Listar<Outrascob_Cergrand>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Outrascob_Cergrand> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Outrascob_Cergrand.GetStringConnection());
            return ba.Existe<Outrascob_Cergrand>(where);
        }

        #endregion
    }
}

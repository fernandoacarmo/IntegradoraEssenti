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
    /// Classe referente a tabela PCClientfilial
    /// </summary>
    [XmlType("PCCLIENTFILIAL")]
    public class PCClientfilial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Indica o código do cliente.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Indica o código da filial.
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
        /// Propriedade referente ao campo: PERCOMCLI
        /// Comentário: Indica o percentual de comissão RCA.
        /// </summary>
        private decimal percomcli;
        [XmlElement(ElementName = "PERCOMCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percomcli
        {
            get { return  percomcli; }
            set {  percomcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMFILIALBROKER
        /// Comentário: Indica a comissão da Filial paga pela indústria por cliente e filial.
        /// </summary>
        private decimal percomfilialbroker;
        [XmlElement(ElementName = "PERCOMFILIALBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percomfilialbroker
        {
            get { return  percomfilialbroker; }
            set {  percomfilialbroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMOT
        /// Comentário: Indica o percentual de comissão motorista.
        /// </summary>
        private decimal percommot;
        [XmlElement(ElementName = "PERCOMMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percommot
        {
            get { return  percommot; }
            set {  percommot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMTERCBROKER
        /// Comentário: Indica a comissão de terceiros pago pela indústria por cliente e filial.
        /// </summary>
        private decimal percomtercbroker;
        [XmlElement(ElementName = "PERCOMTERCBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percomtercbroker
        {
            get { return  percomtercbroker; }
            set {  percomtercbroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETEBROKER
        /// Comentário: Indica a comissão de terceiros pago pela indústria por cliente e filial.
        /// </summary>
        private decimal perfretebroker;
        [XmlElement(ElementName = "PERFRETEBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perfretebroker
        {
            get { return  perfretebroker; }
            set {  perfretebroker = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCClientfilial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCLIENTFILIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCClientfilial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCClientfilial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCClientfilial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCClientfilial>(where);
        }

        #endregion
    }
}

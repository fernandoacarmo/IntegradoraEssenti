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
    /// Classe referente a tabela PCBrindeexpremio
    /// </summary>
    [XmlType("PCBRINDEEXPREMIO")]
    public class PCBrindeexpremio : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITAMULTIPLO
        /// Coment�rio: S/"N", determina se a campanha ir� multiplicar os brindes conforme a quantidade de vezes em que o pedido atender as regras.
        /// </summary>
        private string aceitamultiplo;
        [XmlElement(ElementName = "ACEITAMULTIPLO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitamultiplo
        {
            get { return  aceitamultiplo; }
            set {  aceitamultiplo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBREX
        /// Coment�rio: C�digo da campanha.
        /// </summary>
        private decimal codbrex;
        [XmlElement(ElementName = "CODBREX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codbrex
        {
            get { return  codbrex; }
            set {  codbrex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto em campanha.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOREGRA
        /// Coment�rio: C�digo do grupo da regra.
        /// </summary>
        private decimal gruporegra;
        [XmlElement(ElementName = "GRUPOREGRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Gruporegra
        {
            get { return  gruporegra; }
            set {  gruporegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: Quantidade do produto em campanha.
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBRINDESDISP
        /// Coment�rio: Quantidade disponivel para o brinde.
        /// </summary>
        private decimal qtbrindesdisp;
        [XmlElement(ElementName = "QTBRINDESDISP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtbrindesdisp
        {
            get { return  qtbrindesdisp; }
            set {  qtbrindesdisp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXBRINDES
        /// Coment�rio: Quantidade m�xima de brindes.
        /// </summary>
        private decimal qtmaxbrindes;
        [XmlElement(ElementName = "QTMAXBRINDES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtmaxbrindes
        {
            get { return  qtmaxbrindes; }
            set {  qtmaxbrindes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXBRINDESCLI
        /// Coment�rio: Qtde m�x. de brindes para cliente por item.
        /// </summary>
        private decimal qtmaxbrindescli;
        [XmlElement(ElementName = "QTMAXBRINDESCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtmaxbrindescli
        {
            get { return  qtmaxbrindescli; }
            set {  qtmaxbrindescli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXMULTIPLO
        /// Coment�rio: Quantida m�xima multiplo.
        /// </summary>
        private decimal qtmaxmultiplo;
        [XmlElement(ElementName = "QTMAXMULTIPLO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmaxmultiplo
        {
            get { return  qtmaxmultiplo; }
            set {  qtmaxmultiplo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBSTBRINDEPORSIMILAR
        /// Coment�rio: "S"/"N", determina se a campanha poder� substituir o brinde por produto similar caso n�o possua estoque para este.
        /// </summary>
        private string substbrindeporsimilar;
        [XmlElement(ElementName = "SUBSTBRINDEPORSIMILAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Substbrindeporsimilar
        {
            get { return  substbrindeporsimilar; }
            set {  substbrindeporsimilar = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBrindeexpremio()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBRINDEEXPREMIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBrindeexpremio> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBrindeexpremio>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBrindeexpremio> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBrindeexpremio>(where);
        }

        #endregion
    }
}

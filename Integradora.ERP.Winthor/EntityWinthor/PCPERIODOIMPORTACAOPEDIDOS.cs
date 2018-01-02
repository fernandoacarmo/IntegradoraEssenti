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
    /// Classe referente a tabela PCPeriodoimportacaopedidos
    /// </summary>
    [XmlType("PCPERIODOIMPORTACAOPEDIDOS")]
    public class PCPeriodoimportacaopedidos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial
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
        /// Propriedade referente ao campo: DOMINGO
        /// Coment�rio: Flag que verifica se domingo pode receber importa��o de pedidos
        /// </summary>
        private string domingo;
        [XmlElement(ElementName = "DOMINGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Domingo
        {
            get { return  domingo; }
            set {  domingo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOMINGOHORAFINAL
        /// Coment�rio: Hora final que domingo pode receber importa��o
        /// </summary>
        private DateTime? domingohorafinal;
        [XmlElement(ElementName = "DOMINGOHORAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Domingohorafinal
        {
            get { return  domingohorafinal; }
            set {  domingohorafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOMINGOHORAINICIAL
        /// Coment�rio: Hora inicial que domingo pode receber importa��o
        /// </summary>
        private DateTime? domingohorainicial;
        [XmlElement(ElementName = "DOMINGOHORAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Domingohorainicial
        {
            get { return  domingohorainicial; }
            set {  domingohorainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUARTA
        /// Coment�rio: Flag que verifica se quarta pode receber importa��o de pedidos
        /// </summary>
        private string quarta;
        [XmlElement(ElementName = "QUARTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Quarta
        {
            get { return  quarta; }
            set {  quarta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUARTAHORAFINAL
        /// Coment�rio: Hora final que quarta pode receber importa��o
        /// </summary>
        private DateTime? quartahorafinal;
        [XmlElement(ElementName = "QUARTAHORAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Quartahorafinal
        {
            get { return  quartahorafinal; }
            set {  quartahorafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUARTAHORAINICIAL
        /// Coment�rio: Hora inicial que quarta pode receber importa��o
        /// </summary>
        private DateTime? quartahorainicial;
        [XmlElement(ElementName = "QUARTAHORAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Quartahorainicial
        {
            get { return  quartahorainicial; }
            set {  quartahorainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUINTA
        /// Coment�rio: Flag que verifica se quinta pode receber importa��o de pedidos
        /// </summary>
        private string quinta;
        [XmlElement(ElementName = "QUINTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Quinta
        {
            get { return  quinta; }
            set {  quinta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUINTAHORAFINAL
        /// Coment�rio: Hora final que quinta pode receber importa��o
        /// </summary>
        private DateTime? quintahorafinal;
        [XmlElement(ElementName = "QUINTAHORAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Quintahorafinal
        {
            get { return  quintahorafinal; }
            set {  quintahorafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUINTAHORAINICIAL
        /// Coment�rio: Hora inicial que quinta pode receber importa��o
        /// </summary>
        private DateTime? quintahorainicial;
        [XmlElement(ElementName = "QUINTAHORAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Quintahorainicial
        {
            get { return  quintahorainicial; }
            set {  quintahorainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SABADO
        /// Coment�rio: Flag que verifica se sabado pode receber importa��o de pedidos
        /// </summary>
        private string sabado;
        [XmlElement(ElementName = "SABADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sabado
        {
            get { return  sabado; }
            set {  sabado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SABADOHORAFINAL
        /// Coment�rio: Hora final que s�bado pode receber importa��o
        /// </summary>
        private DateTime? sabadohorafinal;
        [XmlElement(ElementName = "SABADOHORAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Sabadohorafinal
        {
            get { return  sabadohorafinal; }
            set {  sabadohorafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SABADOHORAINICIAL
        /// Coment�rio: Hora inicial que sabado pode receber importa��o
        /// </summary>
        private DateTime? sabadohorainicial;
        [XmlElement(ElementName = "SABADOHORAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Sabadohorainicial
        {
            get { return  sabadohorainicial; }
            set {  sabadohorainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEGUNDA
        /// Coment�rio: Flag que verifica se segunda pode receber importa��o de pedidos
        /// </summary>
        private string segunda;
        [XmlElement(ElementName = "SEGUNDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Segunda
        {
            get { return  segunda; }
            set {  segunda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEGUNDAHORAFINAL
        /// Coment�rio: Hora final que segunda pode receber importa��o
        /// </summary>
        private DateTime? segundahorafinal;
        [XmlElement(ElementName = "SEGUNDAHORAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Segundahorafinal
        {
            get { return  segundahorafinal; }
            set {  segundahorafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEGUNDAHORAINICIAL
        /// Coment�rio: Hora inicial que segunda pode receber importa��o
        /// </summary>
        private DateTime? segundahorainicial;
        [XmlElement(ElementName = "SEGUNDAHORAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Segundahorainicial
        {
            get { return  segundahorainicial; }
            set {  segundahorainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEXTA
        /// Coment�rio: Flag que verifica se sexta pode receber importa��o de pedidos
        /// </summary>
        private string sexta;
        [XmlElement(ElementName = "SEXTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sexta
        {
            get { return  sexta; }
            set {  sexta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEXTAHORAFINAL
        /// Coment�rio: Hora final que sexta pode receber importa��o
        /// </summary>
        private DateTime? sextahorafinal;
        [XmlElement(ElementName = "SEXTAHORAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Sextahorafinal
        {
            get { return  sextahorafinal; }
            set {  sextahorafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEXTAHORAINICIAL
        /// Coment�rio: Hora inicial que sexta pode receber importa��o
        /// </summary>
        private DateTime? sextahorainicial;
        [XmlElement(ElementName = "SEXTAHORAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Sextahorainicial
        {
            get { return  sextahorainicial; }
            set {  sextahorainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TERCA
        /// Coment�rio: Flag que verifica se ter�a pode receber importa��o de pedidos
        /// </summary>
        private string terca;
        [XmlElement(ElementName = "TERCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Terca
        {
            get { return  terca; }
            set {  terca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TERCAHORAFINAL
        /// Coment�rio: Hora final que ter�a pode receber importa��o
        /// </summary>
        private DateTime? tercahorafinal;
        [XmlElement(ElementName = "TERCAHORAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Tercahorafinal
        {
            get { return  tercahorafinal; }
            set {  tercahorafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TERCAHORAINICIAL
        /// Coment�rio: Hora inicial que ter�a pode receber importa��o
        /// </summary>
        private DateTime? tercahorainicial;
        [XmlElement(ElementName = "TERCAHORAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Tercahorainicial
        {
            get { return  tercahorainicial; }
            set {  tercahorainicial = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPeriodoimportacaopedidos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPERIODOIMPORTACAOPEDIDOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPeriodoimportacaopedidos> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPeriodoimportacaopedidos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPeriodoimportacaopedidos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPeriodoimportacaopedidos>(where);
        }

        #endregion
    }
}

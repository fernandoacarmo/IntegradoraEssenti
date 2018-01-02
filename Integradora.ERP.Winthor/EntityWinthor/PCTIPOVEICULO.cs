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
    /// Classe referente a tabela PCTipoveiculo
    /// </summary>
    [XmlType("PCTIPOVEICULO")]
    public class PCTipoveiculo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPERFILVEICULO
        /// Comentário: Código do perfil do veículo
        /// </summary>
        private decimal codperfilveiculo;
        [XmlElement(ElementName = "CODPERFILVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codperfilveiculo
        {
            get { return  codperfilveiculo; }
            set {  codperfilveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOVEICULO
        /// Comentário: Código do tipo do veículo
        /// </summary>
        private decimal codtipoveiculo;
        [XmlElement(ElementName = "CODTIPOVEICULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Codtipoveiculo
        {
            get { return  codtipoveiculo; }
            set {  codtipoveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOINCIDESOBRE
        /// Comentário: Comissão incide sobre
        /// </summary>
        private string comissaoincidesobre;
        [XmlElement(ElementName = "COMISSAOINCIDESOBRE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Comissaoincidesobre
        {
            get { return  comissaoincidesobre; }
            set {  comissaoincidesobre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DSCTIPOVEICULO
        /// Comentário: Descrição do tipo do veículo
        /// </summary>
        private string dsctipoveiculo;
        [XmlElement(ElementName = "DSCTIPOVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Dsctipoveiculo
        {
            get { return  dsctipoveiculo; }
            set {  dsctipoveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIODOFIMVIGENCIA
        /// Comentário: Periódo Final  de Vigência
        /// </summary>
        private DateTime? periodofimvigencia;
        [XmlElement(ElementName = "PERIODOFIMVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Periodofimvigencia
        {
            get { return  periodofimvigencia; }
            set {  periodofimvigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIODOINIVIGENCIA
        /// Comentário: Periódo inicial de Vigência
        /// </summary>
        private DateTime? periodoinivigencia;
        [XmlElement(ElementName = "PERIODOINIVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Periodoinivigencia
        {
            get { return  periodoinivigencia; }
            set {  periodoinivigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PONDERACAOTARIFAENTREGA
        /// Comentário: Ponderação de tarifa sobre a entrega
        /// </summary>
        private decimal ponderacaotarifaentrega;
        [XmlElement(ElementName = "PONDERACAOTARIFAENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Ponderacaotarifaentrega
        {
            get { return  ponderacaotarifaentrega; }
            set {  ponderacaotarifaentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PONDERACAOTARIFAPESO
        /// Comentário: Ponderação de tarifa sobre o peso
        /// </summary>
        private decimal ponderacaotarifapeso;
        [XmlElement(ElementName = "PONDERACAOTARIFAPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Ponderacaotarifapeso
        {
            get { return  ponderacaotarifapeso; }
            set {  ponderacaotarifapeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PONDERACAOTARIFAVOLUME
        /// Comentário: Ponderação de tarifa sobre o volume
        /// </summary>
        private decimal ponderacaotarifavolume;
        [XmlElement(ElementName = "PONDERACAOTARIFAVOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Ponderacaotarifavolume
        {
            get { return  ponderacaotarifavolume; }
            set {  ponderacaotarifavolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODIARIA
        /// Comentário: Tipo de diária
        /// </summary>
        private string tipodiaria;
        [XmlElement(ElementName = "TIPODIARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodiaria
        {
            get { return  tipodiaria; }
            set {  tipodiaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTARIFAKGTRANSPORTADO
        /// Comentário: Tipo deTarifa por Kg transportado
        /// </summary>
        private string tipotarifakgtransportado;
        [XmlElement(ElementName = "TIPOTARIFAKGTRANSPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotarifakgtransportado
        {
            get { return  tipotarifakgtransportado; }
            set {  tipotarifakgtransportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTARIFAQTDENTREGA
        /// Comentário: Tipo de Tarifa por Qtd de Entrega
        /// </summary>
        private string tipotarifaqtdentrega;
        [XmlElement(ElementName = "TIPOTARIFAQTDENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotarifaqtdentrega
        {
            get { return  tipotarifaqtdentrega; }
            set {  tipotarifaqtdentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTARIFAVOLTRANSPORTADO
        /// Comentário: Tipo de Tarifa por Volume transportado
        /// </summary>
        private string tipotarifavoltransportado;
        [XmlElement(ElementName = "TIPOTARIFAVOLTRANSPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotarifavoltransportado
        {
            get { return  tipotarifavoltransportado; }
            set {  tipotarifavoltransportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIARIA
        /// Comentário: Valor da diária
        /// </summary>
        private decimal vldiaria;
        [XmlElement(ElementName = "VLDIARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldiaria
        {
            get { return  vldiaria; }
            set {  vldiaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTARIFAKGTRANSPORTADO
        /// Comentário: Valor da Tarifa por Kg transportado
        /// </summary>
        private decimal vltarifakgtransportado;
        [XmlElement(ElementName = "VLTARIFAKGTRANSPORTADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltarifakgtransportado
        {
            get { return  vltarifakgtransportado; }
            set {  vltarifakgtransportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTARIFAQTDENTREGA
        /// Comentário: Valor de Tarifa por Qtd de Entrega
        /// </summary>
        private decimal vltarifaqtdentrega;
        [XmlElement(ElementName = "VLTARIFAQTDENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltarifaqtdentrega
        {
            get { return  vltarifaqtdentrega; }
            set {  vltarifaqtdentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTARIFAVOLTRANSPORTADO
        /// Comentário: Valor da Tarifa por Volume transportado
        /// </summary>
        private decimal vltarifavoltransportado;
        [XmlElement(ElementName = "VLTARIFAVOLTRANSPORTADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltarifavoltransportado
        {
            get { return  vltarifavoltransportado; }
            set {  vltarifavoltransportado = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTipoveiculo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTIPOVEICULO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTipoveiculo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTipoveiculo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTipoveiculo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTipoveiculo>(where);
        }

        #endregion
    }
}

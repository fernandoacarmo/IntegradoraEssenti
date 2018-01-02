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
    /// Classe referente a tabela PCControledeentrega
    /// </summary>
    [XmlType("PCCONTROLEDEENTREGA")]
    public class PCControledeentrega : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: Indica o c�digo do cliente.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica o c�digo da filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Coment�rio: Indica o c�digo do motorista.
        /// </summary>
        private decimal codmotorista;
        [XmlElement(ElementName = "CODMOTORISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotorista
        {
            get { return  codmotorista; }
            set {  codmotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACADESTINO
        /// Coment�rio: Indica o c�digo destino da entrega.
        /// </summary>
        private decimal codpracadestino;
        [XmlElement(ElementName = "CODPRACADESTINO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpracadestino
        {
            get { return  codpracadestino; }
            set {  codpracadestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORA
        /// Coment�rio: Indica o data e hora de gera��o.
        /// </summary>
        private DateTime? datahora;
        [XmlElement(ElementName = "DATAHORA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datahora
        {
            get { return  datahora; }
            set {  datahora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATARETORNO
        /// Coment�rio: Indica o data e hora de retorno.
        /// </summary>
        private DateTime? dataretorno;
        [XmlElement(ElementName = "DATARETORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataretorno
        {
            get { return  dataretorno; }
            set {  dataretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATASAIDA
        /// Coment�rio: Indica o data e hora de sa�da.
        /// </summary>
        private DateTime? datasaida;
        [XmlElement(ElementName = "DATASAIDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datasaida
        {
            get { return  datasaida; }
            set {  datasaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGCOMISSAO
        /// Coment�rio: Indica quando a comiss�o foi paga para o profissional.
        /// </summary>
        private DateTime? dtpagcomissao;
        [XmlElement(ElementName = "DTPAGCOMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpagcomissao
        {
            get { return  dtpagcomissao; }
            set {  dtpagcomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDOC
        /// Coment�rio: Indica o n�mero do documento.
        /// </summary>
        private decimal numdoc;
        [XmlElement(ElementName = "NUMDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numdoc
        {
            get { return  numdoc; }
            set {  numdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: Indica o numero de transa��o de venda.
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Indica a observa��es.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCOMISSAOFRETE
        /// Coment�rio: Indica o valor da comiss�o paga esta entrega.
        /// </summary>
        private decimal valorcomissaofrete;
        [XmlElement(ElementName = "VALORCOMISSAOFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorcomissaofrete
        {
            get { return  valorcomissaofrete; }
            set {  valorcomissaofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDOC
        /// Coment�rio: Indica o valor do documento.
        /// </summary>
        private decimal valordoc;
        [XmlElement(ElementName = "VALORDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valordoc
        {
            get { return  valordoc; }
            set {  valordoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORFRETE
        /// Coment�rio: Indica o valor do frete.
        /// </summary>
        private decimal valorfrete;
        [XmlElement(ElementName = "VALORFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorfrete
        {
            get { return  valorfrete; }
            set {  valorfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORFRETEADICIONAL
        /// Coment�rio: Indica o valor de frete adicional.
        /// </summary>
        private decimal valorfreteadicional;
        [XmlElement(ElementName = "VALORFRETEADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorfreteadicional
        {
            get { return  valorfreteadicional; }
            set {  valorfreteadicional = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCControledeentrega()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTROLEDEENTREGA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCControledeentrega> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCControledeentrega>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCControledeentrega> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCControledeentrega>(where);
        }

        #endregion
    }
}

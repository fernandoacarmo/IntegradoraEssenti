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
    /// Classe referente a tabela PCFreteveiculo
    /// </summary>
    [XmlType("PCFRETEVEICULO")]
    public class PCFreteveiculo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: N�mero da filial do pedido.
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
        /// Propriedade referente ao campo: CODVEICULO
        /// Coment�rio: C�digo do ve�culo.
        /// </summary>
        private decimal codveiculo;
        [XmlElement(ElementName = "CODVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculo
        {
            get { return  codveiculo; }
            set {  codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCARGA
        /// Coment�rio: Valor de descarga.
        /// </summary>
        private decimal descarga;
        [XmlElement(ElementName = "DESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Descarga
        {
            get { return  descarga; }
            set {  descarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTFRETE
        /// Coment�rio: Data de altera��o do frete.
        /// </summary>
        private DateTime? dtaltfrete;
        [XmlElement(ElementName = "DTALTFRETE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtaltfrete
        {
            get { return  dtaltfrete; }
            set {  dtaltfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFRETE
        /// Coment�rio: Data de gera��o do frete.
        /// </summary>
        private DateTime? dtfrete;
        [XmlElement(ElementName = "DTFRETE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfrete
        {
            get { return  dtfrete; }
            set {  dtfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXTRA
        /// Coment�rio: Vl. extras para o c�lculo de frete.
        /// </summary>
        private decimal extra;
        [XmlElement(ElementName = "EXTRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Extra
        {
            get { return  extra; }
            set {  extra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Coment�rio: C�digo do carregamento.
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDAGIO
        /// Coment�rio: Valor de ped�gio.
        /// </summary>
        private decimal pedagio;
        [XmlElement(ElementName = "PEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pedagio
        {
            get { return  pedagio; }
            set {  pedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOVSVALORKG
        /// Coment�rio: Peso em rela��o ao valor kg transportado.
        /// </summary>
        private decimal pesovsvalorkg;
        [XmlElement(ElementName = "PESOVSVALORKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pesovsvalorkg
        {
            get { return  pesovsvalorkg; }
            set {  pesovsvalorkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPED
        /// Coment�rio: Qtde. Pedidos entregues.
        /// </summary>
        private decimal qtped;
        [XmlElement(ElementName = "QTPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtped
        {
            get { return  qtped; }
            set {  qtped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUM
        /// Coment�rio: N�mero de lan�amento.
        /// </summary>
        private decimal recnum;
        [XmlElement(ElementName = "RECNUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnum
        {
            get { return  recnum; }
            set {  recnum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA
        /// Coment�rio: Rotina geradora do frete.
        /// </summary>
        private string rotina;
        [XmlElement(ElementName = "ROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Rotina
        {
            get { return  rotina; }
            set {  rotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIO
        /// Coment�rio: Usu�rio gerador do frete.
        /// </summary>
        private string usuario;
        [XmlElement(ElementName = "USUARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Usuario
        {
            get { return  usuario; }
            set {  usuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFIXO
        /// Coment�rio: Valor fixo de entrega da carga.
        /// </summary>
        private decimal vlfixo;
        [XmlElement(ElementName = "VLFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlfixo
        {
            get { return  vlfixo; }
            set {  vlfixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLGRIS
        /// Coment�rio: Valor Gris do Ve�culo.
        /// </summary>
        private decimal vlgris;
        [XmlElement(ElementName = "VLGRIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlgris
        {
            get { return  vlgris; }
            set {  vlgris = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPED
        /// Coment�rio: Valor de entrega por pedido.
        /// </summary>
        private decimal vlped;
        [XmlElement(ElementName = "VLPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlped
        {
            get { return  vlped; }
            set {  vlped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSEGURO
        /// Coment�rio: Valor do seguro do veiculo.
        /// </summary>
        private decimal vlseguro;
        [XmlElement(ElementName = "VLSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlseguro
        {
            get { return  vlseguro; }
            set {  vlseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Coment�rio: Vl. total dos pedidos entregues. .
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALFRETE
        /// Coment�rio: Valor final do frete.
        /// </summary>
        private decimal vltotalfrete;
        [XmlElement(ElementName = "VLTOTALFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vltotalfrete
        {
            get { return  vltotalfrete; }
            set {  vltotalfrete = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFreteveiculo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFRETEVEICULO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFreteveiculo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFreteveiculo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFreteveiculo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFreteveiculo>(where);
        }

        #endregion
    }
}

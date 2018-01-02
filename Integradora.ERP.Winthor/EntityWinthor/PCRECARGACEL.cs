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
    /// Classe referente a tabela PCRecargacel
    /// </summary>
    [XmlType("PCRECARGACEL")]
    public class PCRecargacel : OracleTable
    {
        #region Atributos

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
        /// Propriedade referente ao campo: CODFUNCCX
        /// Coment�rio: C�digo Funcion�rio do Caixa.
        /// </summary>
        private decimal codfunccx;
        [XmlElement(ElementName = "CODFUNCCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfunccx
        {
            get { return  codfunccx; }
            set {  codfunccx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERRECARGACEL
        /// Coment�rio: Filial/Regional da operadora de celular.
        /// </summary>
        private decimal codoperrecargacel;
        [XmlElement(ElementName = "CODOPERRECARGACEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Codoperrecargacel
        {
            get { return  codoperrecargacel; }
            set {  codoperrecargacel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data da recarga.
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Coment�rio: Data de Exporta��o para o Servidor.
        /// </summary>
        private DateTime? dtexportacao;
        [XmlElement(ElementName = "DTEXPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacao
        {
            get { return  dtexportacao; }
            set {  dtexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Coment�rio: Exporta��o para Servidor.
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INFPRODUTO
        /// Coment�rio: Informa��o do produto
        /// </summary>
        private string infproduto;
        [XmlElement(ElementName = "INFPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Infproduto
        {
            get { return  infproduto; }
            set {  infproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Coment�rio: N�mero Sequencial �nico da Transa��o de Recarga.
        /// </summary>
        private decimal nsu;
        [XmlElement(ElementName = "NSU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Nsu
        {
            get { return  nsu; }
            set {  nsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Coment�rio: N�mero do Caixa.
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOM
        /// Coment�rio: N�mero do comprovante gerencial de recarga.
        /// </summary>
        private decimal numcupom;
        [XmlElement(ElementName = "NUMCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcupom
        {
            get { return  numcupom; }
            set {  numcupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDECF
        /// Coment�rio: N�mero do Pedido do Caixa.
        /// </summary>
        private decimal numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Coment�rio: N�mero de S�rie do ECF.
        /// </summary>
        private string numserieequip;
        [XmlElement(ElementName = "NUMSERIEEQUIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numserieequip
        {
            get { return  numserieequip; }
            set {  numserieequip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: N�mero da Transa��o de Venda.
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERADORA
        /// Coment�rio: Operadora de Recarga de Celular.
        /// </summary>
        private string operadora;
        [XmlElement(ElementName = "OPERADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Operadora
        {
            get { return  operadora; }
            set {  operadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUM
        /// Coment�rio: C�digo de re�acionamento com a tabela PCLANC.
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
        /// Propriedade referente ao campo: TIPOOPERACAO
        /// Coment�rio: Tipo de opera��o
        /// </summary>
        private string tipooperacao;
        [XmlElement(ElementName = "TIPOOPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipooperacao
        {
            get { return  tipooperacao; }
            set {  tipooperacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor da Recarga.
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRecargacel()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRECARGACEL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRecargacel> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRecargacel>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRecargacel> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRecargacel>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCCortefilho
    /// </summary>
    [XmlType("PCCORTEFILHO")]
    public class PCCortefilho : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�d cliente
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
        /// Propriedade referente ao campo: CODEMITENTEPED
        /// Coment�rio: Emitente do pedido
        /// </summary>
        private decimal codemitenteped;
        [XmlElement(ElementName = "CODEMITENTEPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codemitenteped
        {
            get { return  codemitenteped; }
            set {  codemitenteped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�d. Filial
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
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: Cod. Funcinario de lan�amento
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONF
        /// Coment�rio: C�d. Do conferente
        /// </summary>
        private decimal codfuncconf;
        [XmlElement(ElementName = "CODFUNCCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconf
        {
            get { return  codfuncconf; }
            set {  codfuncconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCSEP
        /// Coment�rio: Cod. Do separador
        /// </summary>
        private decimal codfuncsep;
        [XmlElement(ElementName = "CODFUNCSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncsep
        {
            get { return  codfuncsep; }
            set {  codfuncsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�d. Produto
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: Rotina geradora do registros
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: C�d. Rca
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA
        /// Coment�rio: Tipo de venda
        /// </summary>
        private decimal condvenda;
        [XmlElement(ElementName = "CONDVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Condvenda
        {
            get { return  condvenda; }
            set {  condvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_CORTE
        /// Coment�rio: Data do corte
        /// </summary>
        private DateTime? data_corte;
        [XmlElement(ElementName = "DATA_CORTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data_Corte
        {
            get { return  data_corte; }
            set {  data_corte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALCHECKOUT
        /// Coment�rio: Data. De finalizacao da conf.
        /// </summary>
        private DateTime? dtfinalcheckout;
        [XmlElement(ElementName = "DTFINALCHECKOUT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalcheckout
        {
            get { return  dtfinalcheckout; }
            set {  dtfinalcheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Coment�rio: Hora do corte
        /// </summary>
        private decimal hora;
        [XmlElement(ElementName = "HORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTO
        /// Coment�rio: Minuto do corte
        /// </summary>
        private decimal minuto;
        [XmlElement(ElementName = "MINUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minuto
        {
            get { return  minuto; }
            set {  minuto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Coment�rio: Motivo do corte
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Coment�rio: Num. Carregamento
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: Numero do pedido
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: Num. Sequencia
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCORTADA
        /// Coment�rio: Qtde. cortada
        /// </summary>
        private decimal qtcortada;
        [XmlElement(ElementName = "QTCORTADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtcortada
        {
            get { return  qtcortada; }
            set {  qtcortada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFALTA
        /// Coment�rio: Qtd. Faltante
        /// </summary>
        private decimal qtfalta;
        [XmlElement(ElementName = "QTFALTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtfalta
        {
            get { return  qtfalta; }
            set {  qtfalta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTORIG
        /// Coment�rio: Qtde. original
        /// </summary>
        private decimal qtorig;
        [XmlElement(ElementName = "QTORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtorig
        {
            get { return  qtorig; }
            set {  qtorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSEPARADA
        /// Coment�rio: Qtde. separada
        /// </summary>
        private decimal qtseparada;
        [XmlElement(ElementName = "QTSEPARADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtseparada
        {
            get { return  qtseparada; }
            set {  qtseparada = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCortefilho()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCORTEFILHO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCortefilho> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCortefilho>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCortefilho> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCortefilho>(where);
        }

        #endregion
    }
}

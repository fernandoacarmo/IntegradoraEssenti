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
    /// Classe referente a tabela PCBrindeex
    /// </summary>
    [XmlType("PCBRINDEEX")]
    public class PCBrindeex : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ABATERDEV
        /// Coment�rio: Valida se deve abater as devolu��es.
        /// </summary>
        private string abaterdev;
        [XmlElement(ElementName = "ABATERDEV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abaterdev
        {
            get { return  abaterdev; }
            set {  abaterdev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACUMULATIVA
        /// Coment�rio: Acumulativa
        /// </summary>
        private string acumulativa;
        [XmlElement(ElementName = "ACUMULATIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Acumulativa
        {
            get { return  acumulativa; }
            set {  acumulativa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBREX
        /// Coment�rio: 	C�digo da campanha.	
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 	T�tulo da campanha.	
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Coment�rio: 	Data do cancelamento do brinde.	
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Coment�rio: 	Fim de vig�ncia da campanha. Data e Hora.	
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Coment�rio: 	Data da inclus�o do brinde no banco de dados.	
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: 	In�cio de vig�ncia da campanha. Data e Hora.	
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOVCCRCA
        /// Coment�rio: 	S/"N", determina se o valor de brinde gerado pela campanha ser� debitado do C/C Flex do RCA.	
        /// </summary>
        private string movccrca;
        [XmlElement(ElementName = "MOVCCRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Movccrca
        {
            get { return  movccrca; }
            set {  movccrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTACUMULADAVENDA
        /// Coment�rio: Quantidade de multiplos a ser acumulada
        /// </summary>
        private decimal qtacumuladavenda;
        [XmlElement(ElementName = "QTACUMULADAVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtacumuladavenda
        {
            get { return  qtacumuladavenda; }
            set {  qtacumuladavenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBRINDESDISP
        /// Coment�rio: Quantidade de brinde disponivel
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
        /// Coment�rio: 	Determina uma qtde m�xima de brindes a serem contemplados pela campanha("Estoque" de brindes).	
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
        /// Propriedade referente ao campo: USAALIENACAO
        /// Coment�rio: Usa processo de aliena��o
        /// </summary>
        private string usaalienacao;
        [XmlElement(ElementName = "USAALIENACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaalienacao
        {
            get { return  usaalienacao; }
            set {  usaalienacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAAS
        /// Coment�rio: 	S/"N", determina se a campanha estar� dispon�vel para o Auto-Servi�o.	
        /// </summary>
        private string usaas;
        [XmlElement(ElementName = "USAAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaas
        {
            get { return  usaas; }
            set {  usaas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDABALCAO
        /// Coment�rio: 	Define se a campanha dever� ser validada na venda Balc�o.	
        /// </summary>
        private string vendabalcao;
        [XmlElement(ElementName = "VENDABALCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendabalcao
        {
            get { return  vendabalcao; }
            set {  vendabalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDABALCAORESERVA
        /// Coment�rio: 	Define se a campanha dever� ser validada na venda Balc�o Reserva.	
        /// </summary>
        private string vendabalcaoreserva;
        [XmlElement(ElementName = "VENDABALCAORESERVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendabalcaoreserva
        {
            get { return  vendabalcaoreserva; }
            set {  vendabalcaoreserva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDACALLCENTER
        /// Coment�rio: 	Define se a campanha dever� ser validada no Call Center.	
        /// </summary>
        private string vendacallcenter;
        [XmlElement(ElementName = "VENDACALLCENTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendacallcenter
        {
            get { return  vendacallcenter; }
            set {  vendacallcenter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDAFV
        /// Coment�rio: 	Define se a campanha dever� ser validada no For�a de Vendas.	
        /// </summary>
        private string vendafv;
        [XmlElement(ElementName = "VENDAFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendafv
        {
            get { return  vendafv; }
            set {  vendafv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDATELEMARK
        /// Coment�rio: 	Define se a campanha dever� ser validada no Telemarketing.	
        /// </summary>
        private string vendatelemark;
        [XmlElement(ElementName = "VENDATELEMARK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendatelemark
        {
            get { return  vendatelemark; }
            set {  vendatelemark = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBrindeex()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBRINDEEX";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBrindeex> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBrindeex>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBrindeex> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBrindeex>(where);
        }

        #endregion
    }
}

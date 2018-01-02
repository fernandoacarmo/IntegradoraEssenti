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
    /// Classe referente a tabela PCPresttemp
    /// </summary>
    [XmlType("PCPRESTTEMP")]
    public class PCPresttemp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Recebe o código do cliente.
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
        /// Propriedade referente ao campo: ESC_CARTAOVALIDADEMES
        /// Comentário: Recebe o código do cliente.
        /// </summary>
        private decimal esc_cartaovalidademes;
        [XmlElement(ElementName = "ESC_CARTAOVALIDADEMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public decimal ESC_Cartaovalidademes
        {
            get { return esc_cartaovalidademes; }
            set { esc_cartaovalidademes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_CARTAOVALIDADEANO
        /// Comentário: Recebe o código do cliente.
        /// </summary>
        private decimal esc_cartaovalidadeano;
        [XmlElement(ElementName = "ESC_CARTAOVALIDADEANO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 4)]
        public decimal ESC_Cartaovalidadeano
        {
            get { return esc_cartaovalidadeano; }
            set { esc_cartaovalidadeano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_CARTAONUMERO
        /// Comentário: Recebe o código de cobrança.
        /// </summary>
        private string esc_cartaonumero;
        [XmlElement(ElementName = "ESC_CARTAONUMERO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string ESC_Cartaonumero
        {
            get { return esc_cartaonumero; }
            set { esc_cartaonumero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_CARTAOCLIENTE
        /// Comentário: Recebe o código de cobrança.
        /// </summary>
        private string esc_cartaocliente;
        [XmlElement(ElementName = "ESC_CARTAOCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string ESC_Cartaocliente
        {
            get { return esc_cartaocliente; }
            set { esc_cartaocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: Recebe o código de cobrança.
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Recebe o código do RCA.
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
        /// Propriedade referente ao campo: DTVENC
        /// Comentário: Recebe a data do título.
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtvenc
        {
            get { return dtvenc; }
            set { dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Comentário: Recebe a data do título.
        /// </summary>
        private DateTime? dttransacaocc;
        [XmlElement(ElementName = "DTTRANSACAOCC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dttransacaocc
        {
            get { return dttransacaocc; }
            set { dttransacaocc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: Recebe a data do título.
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: IDPONTOVENDA
        /// Comentário: ID de Ponto de Venda para Integração APLIC.
        /// </summary>
        private decimal? idpontovenda;
        [XmlElement(ElementName = "IDPONTOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Idpontovenda
        {
            get { return  idpontovenda; }
            set {  idpontovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDTITULO
        /// Comentário: Recebe o identificador do título.
        /// </summary>
        private decimal? idtitulo;
        [XmlElement(ElementName = "IDTITULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal? Idtitulo
        {
            get { return  idtitulo; }
            set {  idtitulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTEGRADORA
        /// Comentário: Recebe o código da integradora de dados.
        /// </summary>
        private decimal? integradora;
        [XmlElement(ElementName = "INTEGRADORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Integradora
        {
            get { return  integradora; }
            set {  integradora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOSSONUMBCO
        /// Comentário: Recebe o valor do nosso número.
        /// </summary>
        private string nossonumbco;
        [XmlElement(ElementName = "NOSSONUMBCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nossonumbco
        {
            get { return  nossonumbco; }
            set {  nossonumbco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Comentário: Prestação
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Prest
        {
            get { return prest; }
            set { prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRESTTEF
        /// Comentário: Prestação que esta no TEF
        /// </summary>
        private string presttef;
        [XmlElement(ElementName = "PRESTTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Presttef
        {
            get { return presttef; }
            set { presttef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUTef
        /// Comentário: 
        /// </summary>
        private string nsutef;
        [XmlElement(ElementName = "NSUTef", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 15)]
        public string NSUTef
        {
            get { return nsutef; }
            set { nsutef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_CODAUTORIZACAOTEF
        /// Comentário: 
        /// </summary>
        private string esc_codautorizacaotef;
        [XmlElement(ElementName = "ESC_CODAUTORIZACAOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string ESC_codautorizacaotef
        {
            get { return esc_codautorizacaotef; }
            set { esc_codautorizacaotef = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: CodAutTEF
        /// Comentário: Código de autorização do TEF
        /// </summary>
        private decimal? codauttef;
        [XmlElement(ElementName = "CODAUTTEF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal? CodAutTEF
        {
            get { return codauttef; }
            set { codauttef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDWEB
        /// Comentário: 
        /// </summary>
        private decimal? numpedweb;
        [XmlElement(ElementName = "NUMPEDWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal? Numpedweb
        {
            get { return numpedweb; }
            set { numpedweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 4)]
        public decimal Codplpag
        {
            get { return codplpag; }
            set { codplpag = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: TIPOINTEGRACAO
        /// Comentário: Recebe o código do tipo de integração.
        /// </summary>
        private string tipointegracao;
        [XmlElement(ElementName = "TIPOINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipointegracao
        {
            get { return  tipointegracao; }
            set {  tipointegracao = value; }
        }

        
        // <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: Recebe o valor do título.
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        // <summary>
        /// Propriedade referente ao campo: ESC_VLDESCONTO
        /// Comentário: Recebe o valor do título.
        /// </summary>
        private decimal esc_vldesconto;
        [XmlElement(ElementName = "ESC_VLDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Esc_Vldesconto
        {
            get { return esc_vldesconto; }
            set { esc_vldesconto = value; }
        }

        // <summary>
        /// Propriedade referente ao campo: ESC_VLJUROS
        /// Comentário: Recebe o valor do título.
        /// </summary>
        private decimal esc_vljuros;
        [XmlElement(ElementName = "ESC_VLJUROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 12)]
        public decimal Esc_Vljuros
        {
            get { return esc_vljuros; }
            set { esc_vljuros = value; }
        }
        

        /// <summary>
        /// Propriedade referente ao campo: VLTXBOLETO
        /// Comentário: Valor de Taxa de Boleto.
        /// </summary>
        private decimal? vltxboleto;
        [XmlElement(ElementName = "VLTXBOLETO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vltxboleto
        {
            get { return  vltxboleto; }
            set {  vltxboleto = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPresttemp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRESTTEMP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPresttemp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPresttemp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPresttemp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPresttemp>(where);
        }

        #endregion
    }
}

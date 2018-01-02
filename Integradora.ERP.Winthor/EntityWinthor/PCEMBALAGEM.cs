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
    /// Classe referente a tabela PCEmbalagem
    /// </summary>
    [XmlType("PCEMBALAGEM")]
    public class PCEmbalagem : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITAPRECOREPLICADO
        /// Coment�rio: Indica se a embalagem deve ou n�o replica��o de pre�o. 
        /// </summary>
        private string aceitaprecoreplicado;
        [XmlElement(ElementName = "ACEITAPRECOREPLICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitaprecoreplicado
        {
            get { return  aceitaprecoreplicado; }
            set {  aceitaprecoreplicado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURA
        /// Coment�rio: Altura da embalagem
        /// </summary>
        private decimal? altura;
        [XmlElement(ElementName = "ALTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Altura
        {
            get { return  altura; }
            set {  altura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODISHOPPING
        /// Coment�rio: Altura da embalagem
        /// </summary>
        private decimal? codishopping;
        [XmlElement(ElementName = "CODISHOPPING", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Codishopping
        {
            get { return codishopping; }
            set { codishopping = value; }
        }
        

        /// <summary>
        /// Propriedade referente ao campo: ASSINATURA
        /// Coment�rio: C�digo MD-5 
        /// </summary>
        private string assinatura;
        [XmlElement(ElementName = "ASSINATURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Assinatura
        {
            get { return  assinatura; }
            set {  assinatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BEBALCOOLICA
        /// Coment�rio: Defini��o de Item como bebida alcoolica ou n�o.
        /// </summary>
        private string bebalcoolica;
        [XmlElement(ElementName = "BEBALCOOLICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bebalcoolica
        {
            get { return  bebalcoolica; }
            set {  bebalcoolica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente
        /// </summary>
        private decimal? codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: C�digo da cobran�a
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
        /// Propriedade referente ao campo: CODDIGITAQTDE
        /// Coment�rio: Permite digita��o da quantidade.
        /// </summary>
        private string coddigitaqtde;
        [XmlElement(ElementName = "CODDIGITAQTDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Coddigitaqtde
        {
            get { return  coddigitaqtde; }
            set {  coddigitaqtde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNCALTPOFERTA
        /// Coment�rio: C�digo Funcion�rio que alterou o pre�o de oferta.
        /// </summary>
        private decimal? codfuncaltpoferta;
        [XmlElement(ElementName = "CODFUNCALTPOFERTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncaltpoferta
        {
            get { return  codfuncaltpoferta; }
            set {  codfuncaltpoferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALTPOFERTAATAC
        /// Coment�rio: C�digo Funcion�rio que alterou o pre�o de oferta atacado.
        /// </summary>
        private decimal? codfuncaltpofertaatac;
        [XmlElement(ElementName = "CODFUNCALTPOFERTAATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncaltpofertaatac
        {
            get { return  codfuncaltpofertaatac; }
            set {  codfuncaltpofertaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALTPTABELA
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncaltptabela;
        [XmlElement(ElementName = "CODFUNCALTPTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncaltptabela
        {
            get { return  codfuncaltptabela; }
            set {  codfuncaltptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALTPTABELAATAC
        /// Coment�rio: C�digo Funcion�rio que alterou o pre�o de tabela atacado.
        /// </summary>
        private decimal? codfuncaltptabelaatac;
        [XmlElement(ElementName = "CODFUNCALTPTABELAATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncaltptabelaatac
        {
            get { return  codfuncaltptabelaatac; }
            set {  codfuncaltptabelaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALTPVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncaltpvenda;
        [XmlElement(ElementName = "CODFUNCALTPVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncaltpvenda
        {
            get { return  codfuncaltpvenda; }
            set {  codfuncaltpvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALTPVENDAATAC
        /// Coment�rio: C�digo Funcion�rio que alterou o pre�o de venda atacado.
        /// </summary>
        private decimal? codfuncaltpvendaatac;
        [XmlElement(ElementName = "CODFUNCALTPVENDAATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncaltpvendaatac
        {
            get { return  codfuncaltpvendaatac; }
            set {  codfuncaltpvendaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINATIVO
        /// Coment�rio: Funcion�rio desativa��o embalagem
        /// </summary>
        private decimal? codfuncinativo;
        [XmlElement(ElementName = "CODFUNCINATIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncinativo
        {
            get { return  codfuncinativo; }
            set {  codfuncinativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODINFEXTRABAL
        /// Coment�rio: Informa��o extra usada para vincular uma receita ao exportar a embalagem para a balan�a.
        /// </summary>
        private decimal? codinfextrabal;
        [XmlElement(ElementName = "CODINFEXTRABAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codinfextrabal
        {
            get { return  codinfextrabal; }
            set {  codinfextrabal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRIMENTO
        /// Coment�rio: Comprimento da embalagem
        /// </summary>
        private decimal? comprimento;
        [XmlElement(ElementName = "COMPRIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Comprimento
        {
            get { return  comprimento; }
            set {  comprimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLEVASILHAME
        /// Coment�rio: Controle Vasilhame
        /// </summary>
        private string controlevasilhame;
        [XmlElement(ElementName = "CONTROLEVASILHAME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlevasilhame
        {
            get { return  controlevasilhame; }
            set {  controlevasilhame = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOECF
        /// Coment�rio: Indica a descri��o do ECF. 
        /// </summary>
        private string descricaoecf;
        [XmlElement(ElementName = "DESCRICAOECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricaoecf
        {
            get { return  descricaoecf; }
            set {  descricaoecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOWEB
        /// Coment�rio: Descri��o do Produto na WEB
        /// </summary>
        private string descricaoweb;
        [XmlElement(ElementName = "DESCRICAOWEB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricaoweb
        {
            get { return  descricaoweb; }
            set {  descricaoweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTINOOFERTAATAC
        /// Coment�rio: Define para onde ser� aplicado o pre�o de oferta de atacado
        /// </summary>
        private string destinoofertaatac;
        [XmlElement(ElementName = "DESTINOOFERTAATAC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Destinoofertaatac
        {
            get { return  destinoofertaatac; }
            set {  destinoofertaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTINOOFERTAVAREJO
        /// Coment�rio: Define para onde ser� aplicado o pre�o de oferta de varejo
        /// </summary>
        private string destinoofertavarejo;
        [XmlElement(ElementName = "DESTINOOFERTAVAREJO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Destinoofertavarejo
        {
            get { return  destinoofertavarejo; }
            set {  destinoofertavarejo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAPLICPRECOATAC
        /// Coment�rio: Data de agendamento de pre�o futuro atacado.
        /// </summary>
        private DateTime? dtaplicprecoatac;
        [XmlElement(ElementName = "DTAPLICPRECOATAC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtaplicprecoatac
        {
            get { return  dtaplicprecoatac; }
            set {  dtaplicprecoatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAPLICPRECOVAREJO
        /// Coment�rio: Data de agendamento de pre�o futuro varejo.
        /// </summary>
        private DateTime? dtaplicprecovarejo;
        [XmlElement(ElementName = "DTAPLICPRECOVAREJO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtaplicprecovarejo
        {
            get { return  dtaplicprecovarejo; }
            set {  dtaplicprecovarejo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOETIQ
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtemissaoetiq;
        [XmlElement(ElementName = "DTEMISSAOETIQ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaoetiq
        {
            get { return  dtemissaoetiq; }
            set {  dtemissaoetiq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOETIQPOFERTAS
        /// Coment�rio: Indica a data de emiss�o da etiqueta de oferta.
        /// </summary>
        private DateTime? dtemissaoetiqpofertas;
        [XmlElement(ElementName = "DTEMISSAOETIQPOFERTAS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaoetiqpofertas
        {
            get { return  dtemissaoetiqpofertas; }
            set {  dtemissaoetiqpofertas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINATIVO
        /// Coment�rio: Data desativa��o embalagem
        /// </summary>
        private DateTime? dtinativo;
        [XmlElement(ElementName = "DTINATIVO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinativo
        {
            get { return  dtinativo; }
            set {  dtinativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTOFERTAATACFIM
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtofertaatacfim;
        [XmlElement(ElementName = "DTOFERTAATACFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertaatacfim
        {
            get { return  dtofertaatacfim; }
            set {  dtofertaatacfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTOFERTAATACINI
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtofertaatacini;
        [XmlElement(ElementName = "DTOFERTAATACINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertaatacini
        {
            get { return  dtofertaatacini; }
            set {  dtofertaatacini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTOFERTAFIM
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtofertafim;
        [XmlElement(ElementName = "DTOFERTAFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertafim
        {
            get { return  dtofertafim; }
            set {  dtofertafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTOFERTAINI
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtofertaini;
        [XmlElement(ElementName = "DTOFERTAINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertaini
        {
            get { return  dtofertaini; }
            set {  dtofertaini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTOFERTAWEBFIM
        /// Coment�rio: Data do fim do per�odo de vig�ncia da oferta do produto disponibilizado na web
        /// </summary>
        private DateTime? dtofertawebfim;
        [XmlElement(ElementName = "DTOFERTAWEBFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertawebfim
        {
            get { return  dtofertawebfim; }
            set {  dtofertawebfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTOFERTAWEBINI
        /// Coment�rio: Data do inicio do per�odo de vig�ncia do pre�o de oferta do produto disponibilizado na web
        /// </summary>
        private DateTime? dtofertawebini;
        [XmlElement(ElementName = "DTOFERTAWEBINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertawebini
        {
            get { return  dtofertawebini; }
            set {  dtofertawebini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALT
        /// Coment�rio: Data  e hora de �ltima altera��o no registro
        /// </summary>
        private DateTime? dtultalt;
        [XmlElement(ElementName = "DTULTALT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalt
        {
            get { return  dtultalt; }
            set {  dtultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTCOM
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultaltcom;
        [XmlElement(ElementName = "DTULTALTCOM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltcom
        {
            get { return  dtultaltcom; }
            set {  dtultaltcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTERSRVPRC
        /// Coment�rio: Indica a data da ultima altera��o nesta tabela.
        /// </summary>
        private DateTime? dtultaltersrvprc;
        [XmlElement(ElementName = "DTULTALTERSRVPRC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltersrvprc
        {
            get { return  dtultaltersrvprc; }
            set {  dtultaltersrvprc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTGIRO
        /// Coment�rio: Data da �ltima altera��o de giro
        /// </summary>
        private DateTime? dtultaltgiro;
        [XmlElement(ElementName = "DTULTALTGIRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltgiro
        {
            get { return  dtultaltgiro; }
            set {  dtultaltgiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTPTABELA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultaltptabela;
        [XmlElement(ElementName = "DTULTALTPTABELA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltptabela
        {
            get { return  dtultaltptabela; }
            set {  dtultaltptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTPTABELAATAC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultaltptabelaatac;
        [XmlElement(ElementName = "DTULTALTPTABELAATAC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltptabelaatac
        {
            get { return  dtultaltptabelaatac; }
            set {  dtultaltptabelaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTPTABELAWEB
        /// Coment�rio: Data da �ltima altera��o do pre�o de tabela para web
        /// </summary>
        private DateTime? dtultaltptabelaweb;
        [XmlElement(ElementName = "DTULTALTPTABELAWEB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltptabelaweb
        {
            get { return  dtultaltptabelaweb; }
            set {  dtultaltptabelaweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTPVENDA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultaltpvenda;
        [XmlElement(ElementName = "DTULTALTPVENDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltpvenda
        {
            get { return  dtultaltpvenda; }
            set {  dtultaltpvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTPVENDAATAC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultaltpvendaatac;
        [XmlElement(ElementName = "DTULTALTPVENDAATAC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltpvendaatac
        {
            get { return  dtultaltpvendaatac; }
            set {  dtultaltpvendaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEM
        /// Coment�rio: 
        /// </summary>
        private string embalagem;
        [XmlElement(ElementName = "EMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Embalagem
        {
            get { return  embalagem; }
            set {  embalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIABALANCA
        /// Coment�rio: 
        /// </summary>
        private string enviabalanca;
        [XmlElement(ElementName = "ENVIABALANCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviabalanca
        {
            get { return  enviabalanca; }
            set {  enviabalanca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIAFRENTECAIXA
        /// Coment�rio: Envia frente de caixa
        /// </summary>
        private string enviafrentecaixa;
        [XmlElement(ElementName = "ENVIAFRENTECAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviafrentecaixa
        {
            get { return  enviafrentecaixa; }
            set {  enviafrentecaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIAFV
        /// Coment�rio: 
        /// </summary>
        private string enviafv;
        [XmlElement(ElementName = "ENVIAFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviafv
        {
            get { return  enviafv; }
            set {  enviafv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIAINFNUTRI
        /// Coment�rio: Exportar as informa��es nutricionais da embalagem para balan�a
        /// </summary>
        private string enviainfnutri;
        [XmlElement(ElementName = "ENVIAINFNUTRI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviainfnutri
        {
            get { return  enviainfnutri; }
            set {  enviainfnutri = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIATELEMARKETING
        /// Coment�rio: Envia telemarketing
        /// </summary>
        private string enviatelemarketing;
        [XmlElement(ElementName = "ENVIATELEMARKETING", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviatelemarketing
        {
            get { return  enviatelemarketing; }
            set {  enviatelemarketing = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXCLUIDO
        /// Coment�rio: 
        /// </summary>
        private string excluido;
        [XmlElement(ElementName = "EXCLUIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Excluido
        {
            get { return  excluido; }
            set {  excluido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTACAMPO
        /// Coment�rio: 
        /// </summary>
        private string exportacampo;
        [XmlElement(ElementName = "EXPORTACAMPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportacampo
        {
            get { return  exportacampo; }
            set {  exportacampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORCONVERSAO
        /// Coment�rio: Indica o fator de convers�o para o da unidade da embalagem.
        /// </summary>
        private decimal? fatorconversao;
        [XmlElement(ElementName = "FATORCONVERSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Fatorconversao
        {
            get { return  fatorconversao; }
            set {  fatorconversao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORPRECO
        /// Coment�rio: 
        /// </summary>
        private decimal? fatorpreco;
        [XmlElement(ElementName = "FATORPRECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Fatorpreco
        {
            get { return  fatorpreco; }
            set {  fatorpreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GIROMEDIODIA
        /// Coment�rio: Giro m�dio dia da embalagem
        /// </summary>
        private decimal? giromediodia;
        [XmlElement(ElementName = "GIROMEDIODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal? Giromediodia
        {
            get { return  giromediodia; }
            set {  giromediodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GIROMES
        /// Coment�rio: Giro m�s da embalagem
        /// </summary>
        private decimal? giromes;
        [XmlElement(ElementName = "GIROMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal? Giromes
        {
            get { return  giromes; }
            set {  giromes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPDATAEMBALAGEMBALANCA
        /// Coment�rio: Exporta data da embalagem para balan�as
        /// </summary>
        private string impdataembalagembalanca;
        [XmlElement(ElementName = "IMPDATAEMBALAGEMBALANCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impdataembalagembalanca
        {
            get { return  impdataembalagembalanca; }
            set {  impdataembalagembalanca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRESSAORESTAURANTE
        /// Coment�rio: Permite impress�o restaurante.
        /// </summary>
        private string impressaorestaurante;
        [XmlElement(ElementName = "IMPRESSAORESTAURANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impressaorestaurante
        {
            get { return  impressaorestaurante; }
            set {  impressaorestaurante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRIMERESTAURANTE
        /// Coment�rio: Imprime restaurante
        /// </summary>
        private string imprimerestaurante;
        [XmlElement(ElementName = "IMPRIMERESTAURANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Imprimerestaurante
        {
            get { return  imprimerestaurante; }
            set {  imprimerestaurante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDCVENDECODINTERNO
        /// Coment�rio: Permite vender com c�digo interno.
        /// </summary>
        private string indcvendecodinterno;
        [XmlElement(ElementName = "INDCVENDECODINTERNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indcvendecodinterno
        {
            get { return  indcvendecodinterno; }
            set {  indcvendecodinterno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICALERTAQUANTIDADE
        /// Coment�rio: Indica se o sistema deve apresentar o alerta de quantidade para operador.
        /// </summary>
        private string indicalertaquantidade;
        [XmlElement(ElementName = "INDICALERTAQUANTIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indicalertaquantidade
        {
            get { return  indicalertaquantidade; }
            set {  indicalertaquantidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICGERARCODPESOVAR
        /// Coment�rio: Permite gerar c�digo peso vari�vel.
        /// </summary>
        private string indicgerarcodpesovar;
        [XmlElement(ElementName = "INDICGERARCODPESOVAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indicgerarcodpesovar
        {
            get { return  indicgerarcodpesovar; }
            set {  indicgerarcodpesovar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICPERMITEDIGITACAODESCONTO
        /// Coment�rio: Permite digita��o de desconto.
        /// </summary>
        private string indicpermitedigitacaodesconto;
        [XmlElement(ElementName = "INDICPERMITEDIGITACAODESCONTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indicpermitedigitacaodesconto
        {
            get { return  indicpermitedigitacaodesconto; }
            set {  indicpermitedigitacaodesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICPERMITEDIGITACAOPRECO
        /// Coment�rio: Permite digita��o de pre�o.
        /// </summary>
        private string indicpermitedigitacaopreco;
        [XmlElement(ElementName = "INDICPERMITEDIGITACAOPRECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indicpermitedigitacaopreco
        {
            get { return  indicpermitedigitacaopreco; }
            set {  indicpermitedigitacaopreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICPERMITEPORPREVENDA
        /// Coment�rio: Indica se o produto s� pode ser vendido dentro de uma pr� venda.
        /// </summary>
        private string indicpermiteporprevenda;
        [XmlElement(ElementName = "INDICPERMITEPORPREVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indicpermiteporprevenda
        {
            get { return  indicpermiteporprevenda; }
            set {  indicpermiteporprevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICPESAGEMOBRIGATORIA
        /// Coment�rio: Indica se a pesagem e obrigat�ria - PDV
        /// </summary>
        private string indicpesagemobrigatoria;
        [XmlElement(ElementName = "INDICPESAGEMOBRIGATORIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indicpesagemobrigatoria
        {
            get { return  indicpesagemobrigatoria; }
            set {  indicpesagemobrigatoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICPRODUCAOPROPRIA
        /// Coment�rio: Indica a produ��o pr�pria.
        /// </summary>
        private string indicproducaopropria;
        [XmlElement(ElementName = "INDICPRODUCAOPROPRIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indicproducaopropria
        {
            get { return  indicproducaopropria; }
            set {  indicproducaopropria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INFOPRODWEB
        /// Coment�rio: Informa��es do Produto WEB
        /// </summary>
//        private string infoprodweb;
//        [XmlElement(ElementName = "INFOPRODWEB", DataType = "CLOB", IsNullable = true)]
//        [DataObjectField(false,false,true,0)]
//        public string Infoprodweb
//        {
//            get { return  infoprodweb; }
//            set {  infoprodweb = value; }
//        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURA
        /// Coment�rio: Largura da embalagem
        /// </summary>
        private decimal? largura;
        [XmlElement(ElementName = "LARGURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Largura
        {
            get { return  largura; }
            set {  largura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LAYOUTETIQUETA
        /// Coment�rio: Defini��o de layout para embalagem. 
        /// </summary>
        private string layoutetiqueta;
        [XmlElement(ElementName = "LAYOUTETIQUETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Layoutetiqueta
        {
            get { return  layoutetiqueta; }
            set {  layoutetiqueta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEM
        /// Coment�rio: 
        /// </summary>
        private decimal? margem;
        [XmlElement(ElementName = "MARGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Margem
        {
            get { return  margem; }
            set {  margem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMATAC
        /// Coment�rio: 
        /// </summary>
        private decimal? margematac;
        [XmlElement(ElementName = "MARGEMATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Margematac
        {
            get { return  margematac; }
            set {  margematac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMATAC_ESP
        /// Coment�rio: 
        /// </summary>
        private decimal? margematac_esp;
        [XmlElement(ElementName = "MARGEMATAC_ESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Margematac_Esp
        {
            get { return  margematac_esp; }
            set {  margematac_esp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEM_ESP
        /// Coment�rio: 
        /// </summary>
        private decimal? margem_esp;
        [XmlElement(ElementName = "MARGEM_ESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Margem_Esp
        {
            get { return  margem_esp; }
            set {  margem_esp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMIDEALATAC
        /// Coment�rio: 
        /// </summary>
        private decimal? margemidealatac;
        [XmlElement(ElementName = "MARGEMIDEALATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Margemidealatac
        {
            get { return  margemidealatac; }
            set {  margemidealatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOOFERTA
        /// Coment�rio: Motivo da oferta
        /// </summary>
        private string motivooferta;
        [XmlElement(ElementName = "MOTIVOOFERTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Motivooferta
        {
            get { return  motivooferta; }
            set {  motivooferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQATU
        /// Coment�rio: 
        /// </summary>
        private decimal? numseqatu;
        [XmlElement(ElementName = "NUMSEQATU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal? Numseqatu
        {
            get { return  numseqatu; }
            set {  numseqatu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBRIGALEITURACODBARRA
        /// Coment�rio: Obriga leitura de c�digo de barras da embalagem
        /// </summary>
        private string obrigaleituracodbarra;
        [XmlElement(ElementName = "OBRIGALEITURACODBARRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Obrigaleituracodbarra
        {
            get { return  obrigaleituracodbarra; }
            set {  obrigaleituracodbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMEXT1
        /// Coment�rio: Taxa de comiss�o para vendedor externo.
        /// </summary>
        private decimal? pcomext1;
        [XmlElement(ElementName = "PCOMEXT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Pcomext1
        {
            get { return  pcomext1; }
            set {  pcomext1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMINT1
        /// Coment�rio: Taxa de comiss�o para vendedor interno.
        /// </summary>
        private decimal? pcomint1;
        [XmlElement(ElementName = "PCOMINT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Pcomint1
        {
            get { return  pcomint1; }
            set {  pcomint1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMREP1
        /// Coment�rio: Taxa de comiss�o para representante.
        /// </summary>
        private decimal? pcomrep1;
        [XmlElement(ElementName = "PCOMREP1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Pcomrep1
        {
            get { return  pcomrep1; }
            set {  pcomrep1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCCARTAOFIDELIDADE
        /// Coment�rio: 
        /// </summary>
        private decimal? perdesccartaofidelidade;
        [XmlElement(ElementName = "PERDESCCARTAOFIDELIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Perdesccartaofidelidade
        {
            get { return  perdesccartaofidelidade; }
            set {  perdesccartaofidelidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEMULTIPLICACAO
        /// Coment�rio: 
        /// </summary>
        private string permitemultiplicacao;
        [XmlElement(ElementName = "PERMITEMULTIPLICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitemultiplicacao
        {
            get { return  permitemultiplicacao; }
            set {  permitemultiplicacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEVENDAATACADO
        /// Coment�rio: Indica restri��o de venda por embalagem para o Atacado. 
        /// </summary>
        private string permitevendaatacado;
        [XmlElement(ElementName = "PERMITEVENDAATACADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitevendaatacado
        {
            get { return  permitevendaatacado; }
            set {  permitevendaatacado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEVENDACOMINTERNO
        /// Coment�rio: Permite venda com c�digo interno - PDV.
        /// </summary>
        private string permitevendacominterno;
        [XmlElement(ElementName = "PERMITEVENDACOMINTERNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitevendacominterno
        {
            get { return  permitevendacominterno; }
            set {  permitevendacominterno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERVARIACAOPTABELA
        /// Coment�rio: Indica o percentual de varia��o de pre�o.
        /// </summary>
        private decimal? pervariacaoptabela;
        [XmlElement(ElementName = "PERVARIACAOPTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Pervariacaoptabela
        {
            get { return  pervariacaoptabela; }
            set {  pervariacaoptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBRUTO
        /// Coment�rio: Indica o Peso Bruto da embalagem. 
        /// </summary>
        private decimal? pesobruto;
        [XmlElement(ElementName = "PESOBRUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Pesobruto
        {
            get { return  pesobruto; }
            set {  pesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOLIQ
        /// Coment�rio: Indica o Peso L�quido da embalagem. 
        /// </summary>
        private decimal? pesoliq;
        [XmlElement(ElementName = "PESOLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Pesoliq
        {
            get { return  pesoliq; }
            set {  pesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTA
        /// Coment�rio: 
        /// </summary>
        private decimal? poferta;
        [XmlElement(ElementName = "POFERTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Poferta
        {
            get { return  poferta; }
            set {  poferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTAATAC
        /// Coment�rio: 
        /// </summary>
        private decimal? pofertaatac;
        [XmlElement(ElementName = "POFERTAATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Pofertaatac
        {
            get { return  pofertaatac; }
            set {  pofertaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTAWEB
        /// Coment�rio: Pre�o de oferta que ser� aplicado ao produto disponibilizado na web
        /// </summary>
        private decimal? pofertaweb;
        [XmlElement(ElementName = "POFERTAWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Pofertaweb
        {
            get { return  pofertaweb; }
            set {  pofertaweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOVAL
        /// Coment�rio: 
        /// </summary>
        private decimal? prazoval;
        [XmlElement(ElementName = "PRAZOVAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazoval
        {
            get { return  prazoval; }
            set {  prazoval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOANTERIOR
        /// Coment�rio: 
        /// </summary>
        private decimal? precoanterior;
        [XmlElement(ElementName = "PRECOANTERIOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Precoanterior
        {
            get { return  precoanterior; }
            set {  precoanterior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOANTERIORATAC
        /// Coment�rio: 
        /// </summary>
        private decimal? precoanterioratac;
        [XmlElement(ElementName = "PRECOANTERIORATAC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal? Precoanterioratac
        {
            get { return  precoanterioratac; }
            set {  precoanterioratac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Coment�rio: 
        /// </summary>
        private decimal? ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAANT
        /// Coment�rio: Pre�o futuro anterior
        /// </summary>
        private decimal? ptabelaant;
        [XmlElement(ElementName = "PTABELAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Ptabelaant
        {
            get { return  ptabelaant; }
            set {  ptabelaant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATAC
        /// Coment�rio: 
        /// </summary>
        private decimal? ptabelaatac;
        [XmlElement(ElementName = "PTABELAATAC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal? Ptabelaatac
        {
            get { return  ptabelaatac; }
            set {  ptabelaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATACANT
        /// Coment�rio: Pre�o futuro atacado anterior
        /// </summary>
        private decimal? ptabelaatacant;
        [XmlElement(ElementName = "PTABELAATACANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Ptabelaatacant
        {
            get { return  ptabelaatacant; }
            set {  ptabelaatacant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAWEB
        /// Coment�rio: Pre�o futuro que ser� aplicado ao produto disponibilizado na web
        /// </summary>
        private decimal? ptabelaweb;
        [XmlElement(ElementName = "PTABELAWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Ptabelaweb
        {
            get { return  ptabelaweb; }
            set {  ptabelaweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAWEBANT
        /// Coment�rio: Pre�o futuro web anterior.
        /// </summary>
        private decimal? ptabelawebant;
        [XmlElement(ElementName = "PTABELAWEBANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Ptabelawebant
        {
            get { return  ptabelawebant; }
            set {  ptabelawebant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal? pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Pvenda
        {
            get { return  pvenda; }
            set {  pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATAC
        /// Coment�rio: 
        /// </summary>
        private decimal? pvendaatac;
        [XmlElement(ElementName = "PVENDAATAC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal? Pvendaatac
        {
            get { return  pvendaatac; }
            set {  pvendaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAWEB
        /// Coment�rio: Pre�o de venda que ser� aplicado ao produto disponibilizado na web
        /// </summary>
        private decimal? pvendaweb;
        [XmlElement(ElementName = "PVENDAWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Pvendaweb
        {
            get { return  pvendaweb; }
            set {  pvendaweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAWEBANT
        /// Coment�rio: Pre�o venda web anterior da embalagem.
        /// </summary>
        private decimal? pvendawebant;
        [XmlElement(ElementName = "PVENDAWEBANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Pvendawebant
        {
            get { return  pvendawebant; }
            set {  pvendawebant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIAS
        /// Coment�rio: Qt. Dias para estoque seguran�a
        /// </summary>
        private decimal? qtdias;
        [XmlElement(ElementName = "QTDIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Qtdias
        {
            get { return  qtdias; }
            set {  qtdias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEMISSAOETIQ
        /// Coment�rio: Quantidade de etiquetas a emitir desta embalagem
        /// </summary>
        private decimal? qtemissaoetiq;
        [XmlElement(ElementName = "QTEMISSAOETIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Qtemissaoetiq
        {
            get { return  qtemissaoetiq; }
            set {  qtemissaoetiq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFIXAMULTIPLICCHECKOUT
        /// Coment�rio: Quantidade fixa para multiplica��o no checkout
        /// </summary>
        private decimal? qtfixamultipliccheckout;
        [XmlElement(ElementName = "QTFIXAMULTIPLICCHECKOUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal? Qtfixamultipliccheckout
        {
            get { return  qtfixamultipliccheckout; }
            set {  qtfixamultipliccheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXGONDOLA
        /// Coment�rio: 
        /// </summary>
        private decimal? qtmaxgondola;
        [XmlElement(ElementName = "QTMAXGONDOLA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Qtmaxgondola
        {
            get { return  qtmaxgondola; }
            set {  qtmaxgondola = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal? qtmaxvenda;
        [XmlElement(ElementName = "QTMAXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Qtmaxvenda
        {
            get { return  qtmaxvenda; }
            set {  qtmaxvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINATACADOF
        /// Coment�rio: 
        /// </summary>
        private decimal? qtminatacadof;
        [XmlElement(ElementName = "QTMINATACADOF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Qtminatacadof
        {
            get { return  qtminatacadof; }
            set {  qtminatacadof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINGONDOLA
        /// Coment�rio: 
        /// </summary>
        private decimal? qtmingondola;
        [XmlElement(ElementName = "QTMINGONDOLA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Qtmingondola
        {
            get { return  qtmingondola; }
            set {  qtmingondola = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINIMAATACADO
        /// Coment�rio: 
        /// </summary>
        private decimal? qtminimaatacado;
        [XmlElement(ElementName = "QTMINIMAATACADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Qtminimaatacado
        {
            get { return  qtminimaatacado; }
            set {  qtminimaatacado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINIMAATACADOF
        /// Coment�rio: 
        /// </summary>
        private decimal? qtminimaatacadof;
        [XmlElement(ElementName = "QTMINIMAATACADOF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Qtminimaatacadof
        {
            get { return  qtminimaatacadof; }
            set {  qtminimaatacadof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMULTIPLA
        /// Coment�rio: Indica a quantidade m�ltipla embalagem. 
        /// </summary>
        private decimal? qtmultipla;
        [XmlElement(ElementName = "QTMULTIPLA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Qtmultipla
        {
            get { return  qtmultipla; }
            set {  qtmultipla = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNIT
        /// Coment�rio: 
        /// </summary>
        private decimal? qtunit;
        [XmlElement(ElementName = "QTUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Qtunit
        {
            get { return  qtunit; }
            set {  qtunit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAOWEB
        /// Coment�rio: Situa��o do Produto
        /// </summary>
        private string situacaoweb;
        [XmlElement(ElementName = "SITUACAOWEB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacaoweb
        {
            get { return  situacaoweb; }
            set {  situacaoweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOCIOTORCEDOR
        /// Coment�rio: Embalagem s�cio torcedor
        /// </summary>
        private string sociotorcedor;
        [XmlElement(ElementName = "SOCIOTORCEDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sociotorcedor
        {
            get { return  sociotorcedor; }
            set {  sociotorcedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TARAF
        /// Coment�rio: Tara da balan�a
        /// </summary>
        private decimal? taraf;
        [XmlElement(ElementName = "TARAF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal? Taraf
        {
            get { return  taraf; }
            set {  taraf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEM
        /// Coment�rio: 
        /// </summary>
        private string tipoembalagem;
        [XmlElement(ElementName = "TIPOEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoembalagem
        {
            get { return  tipoembalagem; }
            set {  tipoembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE
        /// Coment�rio: 
        /// </summary>
        private string unidade;
        [XmlElement(ElementName = "UNIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidade
        {
            get { return  unidade; }
            set {  unidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNMEDIDA
        /// Coment�rio: Indica a unidade de medida utilizada para a embalagem.
        /// </summary>
        private string unmedida;
        [XmlElement(ElementName = "UNMEDIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Unmedida
        {
            get { return  unmedida; }
            set {  unmedida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USABALANCATOLEDO
        /// Coment�rio: 
        /// </summary>
        private string usabalancatoledo;
        [XmlElement(ElementName = "USABALANCATOLEDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usabalancatoledo
        {
            get { return  usabalancatoledo; }
            set {  usabalancatoledo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARESTAURANTE
        /// Coment�rio: Usa embalagem em restaurante
        /// </summary>
        private string usarestaurante;
        [XmlElement(ElementName = "USARESTAURANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usarestaurante
        {
            get { return  usarestaurante; }
            set {  usarestaurante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUME
        /// Coment�rio: Volume da embalagem
        /// </summary>
        private decimal? volume;
        [XmlElement(ElementName = "VOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Volume
        {
            get { return  volume; }
            set {  volume = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEmbalagem()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEMBALAGEM";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEmbalagem> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEmbalagem>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEmbalagem> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEmbalagem>(where);
        }

        #endregion
    }
}

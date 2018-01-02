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
    /// Classe referente a tabela PCCarreg
    /// </summary>
    [XmlType("PCCARREG")]
    public class PCCarreg : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ABASTECIDO
        /// Coment�rio: 
        /// </summary>
        private string abastecido;
        [XmlElement(ElementName = "ABASTECIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abastecido
        {
            get { return  abastecido; }
            set {  abastecido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVADO
        /// Coment�rio: 
        /// </summary>
        private string aprovado;
        [XmlElement(ElementName = "APROVADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Aprovado
        {
            get { return  aprovado; }
            set {  aprovado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARMCODFUNCPRECACERTO
        /// Coment�rio: 
        /// </summary>
        private decimal armcodfuncprecacerto;
        [XmlElement(ElementName = "ARMCODFUNCPRECACERTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Armcodfuncprecacerto
        {
            get { return  armcodfuncprecacerto; }
            set {  armcodfuncprecacerto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARMKMPREVISTO
        /// Coment�rio: 
        /// </summary>
        private decimal armkmprevisto;
        [XmlElement(ElementName = "ARMKMPREVISTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Armkmprevisto
        {
            get { return  armkmprevisto; }
            set {  armkmprevisto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARMQTENTGEO
        /// Coment�rio: 
        /// </summary>
        private decimal armqtentgeo;
        [XmlElement(ElementName = "ARMQTENTGEO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Armqtentgeo
        {
            get { return  armqtentgeo; }
            set {  armqtentgeo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BALCAOBAIXADO
        /// Coment�rio: 
        /// </summary>
        private string balcaobaixado;
        [XmlElement(ElementName = "BALCAOBAIXADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Balcaobaixado
        {
            get { return  balcaobaixado; }
            set {  balcaobaixado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARGASECUNDARIA
        /// Coment�rio: 
        /// </summary>
        private string cargasecundaria;
        [XmlElement(ElementName = "CARGASECUNDARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cargasecundaria
        {
            get { return  cargasecundaria; }
            set {  cargasecundaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAJUDTRANSBORDO
        /// Coment�rio: Indica o c�digo do motorista ajudante.
        /// </summary>
        private decimal codajudtransbordo;
        [XmlElement(ElementName = "CODAJUDTRANSBORDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codajudtransbordo
        {
            get { return  codajudtransbordo; }
            set {  codajudtransbordo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCAIXA
        /// Coment�rio: 
        /// </summary>
        private decimal codcaixa;
        [XmlElement(ElementName = "CODCAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcaixa
        {
            get { return  codcaixa; }
            set {  codcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONF
        /// Coment�rio: 
        /// </summary>
        private decimal codconf;
        [XmlElement(ElementName = "CODCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codconf
        {
            get { return  codconf; }
            set {  codconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALSAIDA
        /// Coment�rio: Indica o c�digo da filial de sa�da do ve�culo .
        /// </summary>
        private string codfilialsaida;
        [XmlElement(ElementName = "CODFILIALSAIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialsaida
        {
            get { return  codfilialsaida; }
            set {  codfilialsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAJUD
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncajud;
        [XmlElement(ElementName = "CODFUNCAJUD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncajud
        {
            get { return  codfuncajud; }
            set {  codfuncajud = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAJUD2
        /// Coment�rio: Segundo ajudante
        /// </summary>
        private decimal codfuncajud2;
        [XmlElement(ElementName = "CODFUNCAJUD2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncajud2
        {
            get { return  codfuncajud2; }
            set {  codfuncajud2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAJUD3
        /// Coment�rio: Terceiro ajudante
        /// </summary>
        private decimal codfuncajud3;
        [XmlElement(ElementName = "CODFUNCAJUD3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncajud3
        {
            get { return  codfuncajud3; }
            set {  codfuncajud3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCANCEL
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccancel;
        [XmlElement(ElementName = "CODFUNCCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccancel
        {
            get { return  codfunccancel; }
            set {  codfunccancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONF
        /// Coment�rio: C�d. Do conferente.
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
        /// Propriedade referente ao campo: CODFUNCFAT
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncfat;
        [XmlElement(ElementName = "CODFUNCFAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfat
        {
            get { return  codfuncfat; }
            set {  codfuncfat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFECHA
        /// Coment�rio: C�digo do funcion�rio do fechamento
        /// </summary>
        private decimal codfuncfecha;
        [XmlElement(ElementName = "CODFUNCFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfecha
        {
            get { return  codfuncfecha; }
            set {  codfuncfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLIBEROURET
        /// Coment�rio: Funcionario que liberou a retaguarda
        /// </summary>
        private decimal codfuncliberouret;
        [XmlElement(ElementName = "CODFUNCLIBEROURET", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncliberouret
        {
            get { return  codfuncliberouret; }
            set {  codfuncliberouret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCMAPA
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncmapa;
        [XmlElement(ElementName = "CODFUNCMAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncmapa
        {
            get { return  codfuncmapa; }
            set {  codfuncmapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCMAPACARAGRUPADO
        /// Coment�rio: Indica o c�digo funcionario do mapa de separa��o dos carregamentos agrupados.
        /// </summary>
        private decimal codfuncmapacaragrupado;
        [XmlElement(ElementName = "CODFUNCMAPACARAGRUPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncmapacaragrupado
        {
            get { return  codfuncmapacaragrupado; }
            set {  codfuncmapacaragrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCMON
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncmon;
        [XmlElement(ElementName = "CODFUNCMON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncmon
        {
            get { return  codfuncmon; }
            set {  codfuncmon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCRETORNOCAR
        /// Coment�rio: C�d. Func. Que deu retorno da carga
        /// </summary>
        private decimal codfuncretornocar;
        [XmlElement(ElementName = "CODFUNCRETORNOCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncretornocar
        {
            get { return  codfuncretornocar; }
            set {  codfuncretornocar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCSAIDACAR
        /// Coment�rio: C�d. Func. Que deu saida na carga.
        /// </summary>
        private decimal codfuncsaidacar;
        [XmlElement(ElementName = "CODFUNCSAIDACAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncsaidacar
        {
            get { return  codfuncsaidacar; }
            set {  codfuncsaidacar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNTIPOCALCCOMISSAOFRETISTA
        /// Coment�rio: Cod. Fun. Tipo. Calc. Comiss�o Fret.
        /// </summary>
        private decimal codfuntipocalccomissaofretista;
        [XmlElement(ElementName = "CODFUNTIPOCALCCOMISSAOFRETISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuntipocalccomissaofretista
        {
            get { return  codfuntipocalccomissaofretista; }
            set {  codfuntipocalccomissaofretista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODMOTORISTACARAGRUPADO
        /// Coment�rio: Indica o c�digo motorista do carregamento agrupado.
        /// </summary>
        private decimal codmotoristacaragrupado;
        [XmlElement(ElementName = "CODMOTORISTACARAGRUPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotoristacaragrupado
        {
            get { return  codmotoristacaragrupado; }
            set {  codmotoristacaragrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTTRANSBORDO
        /// Coment�rio: Indica o c�digo do motorista transbordo.
        /// </summary>
        private decimal codmottransbordo;
        [XmlElement(ElementName = "CODMOTTRANSBORDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmottransbordo
        {
            get { return  codmottransbordo; }
            set {  codmottransbordo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPERFILVEICULO
        /// Coment�rio: C�digo do perfil do ve�culo
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
        /// Propriedade referente ao campo: CODROTAPRINC
        /// Coment�rio: 
        /// </summary>
        private decimal codrotaprinc;
        [XmlElement(ElementName = "CODROTAPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrotaprinc
        {
            get { return  codrotaprinc; }
            set {  codrotaprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOVEICULO
        /// Coment�rio: C�digo do tipo do ve�culo
        /// </summary>
        private decimal codtipoveiculo;
        [XmlElement(ElementName = "CODTIPOVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codtipoveiculo
        {
            get { return  codtipoveiculo; }
            set {  codtipoveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULCARAGRUPADO
        /// Coment�rio: Indica o c�digo ve�culo do carregamento agrupado.
        /// </summary>
        private decimal codveiculcaragrupado;
        [XmlElement(ElementName = "CODVEICULCARAGRUPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculcaragrupado
        {
            get { return  codveiculcaragrupado; }
            set {  codveiculcaragrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODVEICULO1
        /// Coment�rio: Ve�culo 1
        /// </summary>
        private decimal codveiculo1;
        [XmlElement(ElementName = "CODVEICULO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculo1
        {
            get { return  codveiculo1; }
            set {  codveiculo1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO2
        /// Coment�rio: Ve�culo 2
        /// </summary>
        private decimal codveiculo2;
        [XmlElement(ElementName = "CODVEICULO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculo2
        {
            get { return  codveiculo2; }
            set {  codveiculo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONHECFRETE
        /// Coment�rio: 
        /// </summary>
        private string conhecfrete;
        [XmlElement(ElementName = "CONHECFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conhecfrete
        {
            get { return  conhecfrete; }
            set {  conhecfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONHECGERADO
        /// Coment�rio: 
        /// </summary>
        private string conhecgerado;
        [XmlElement(ElementName = "CONHECGERADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conhecgerado
        {
            get { return  conhecgerado; }
            set {  conhecgerado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACARAGRUPADO
        /// Coment�rio: Indica a data do carregamento agrupado.
        /// </summary>
        private DateTime? datacaragrupado;
        [XmlElement(ElementName = "DATACARAGRUPADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacaragrupado
        {
            get { return  datacaragrupado; }
            set {  datacaragrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONF
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataconf;
        [XmlElement(ElementName = "DATACONF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataconf
        {
            get { return  dataconf; }
            set {  dataconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONFFIM
        /// Coment�rio: Indica a data de fim de confer�ncia do carregamento.
        /// </summary>
        private DateTime? dataconffim;
        [XmlElement(ElementName = "DATACONFFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataconffim
        {
            get { return  dataconffim; }
            set {  dataconffim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORAMAPA
        /// Coment�rio: 
        /// </summary>
        private DateTime? datahoramapa;
        [XmlElement(ElementName = "DATAHORAMAPA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datahoramapa
        {
            get { return  datahoramapa; }
            set {  datahoramapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORAMAPACARAGRUPADO
        /// Coment�rio: Indica o emiss�o do mapa de separa��o dos carregamentos agrupados.
        /// </summary>
        private DateTime? datahoramapacaragrupado;
        [XmlElement(ElementName = "DATAHORAMAPACARAGRUPADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datahoramapacaragrupado
        {
            get { return  datahoramapacaragrupado; }
            set {  datahoramapacaragrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALIBEROURET
        /// Coment�rio: Data que liberou retaguarda
        /// </summary>
        private DateTime? dataliberouret;
        [XmlElement(ElementName = "DATALIBEROURET", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataliberouret
        {
            get { return  dataliberouret; }
            set {  dataliberouret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAMAPA
        /// Coment�rio: 
        /// </summary>
        private DateTime? datamapa;
        [XmlElement(ElementName = "DATAMAPA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datamapa
        {
            get { return  datamapa; }
            set {  datamapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAMON
        /// Coment�rio: 
        /// </summary>
        private DateTime? datamon;
        [XmlElement(ElementName = "DATAMON", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datamon
        {
            get { return  datamon; }
            set {  datamon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTINO
        /// Coment�rio: 
        /// </summary>
        private string destino;
        [XmlElement(ElementName = "DESTINO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Destino
        {
            get { return  destino; }
            set {  destino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTINOAGRUP
        /// Coment�rio: Destino das cargas agrupadas.
        /// </summary>
        private string destinoagrup;
        [XmlElement(ElementName = "DESTINOAGRUP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Destinoagrup
        {
            get { return  destinoagrup; }
            set {  destinoagrup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIVISAOCARGA
        /// Coment�rio: Classe ou Subclasse/divis�o
        /// </summary>
        private string divisaocarga;
        [XmlElement(ElementName = "DIVISAOCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Divisaocarga
        {
            get { return  divisaocarga; }
            set {  divisaocarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCA_CAMINHAO
        /// Coment�rio: 
        /// </summary>
        private string doca_caminhao;
        [XmlElement(ElementName = "DOCA_CAMINHAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Doca_Caminhao
        {
            get { return  doca_caminhao; }
            set {  doca_caminhao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCAIXA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcaixa;
        [XmlElement(ElementName = "DTCAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcaixa
        {
            get { return  dtcaixa; }
            set {  dtcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DT_CANCEL
        /// Coment�rio: 
        /// </summary>
        private DateTime? dt_cancel;
        [XmlElement(ElementName = "DT_CANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dt_Cancel
        {
            get { return  dt_cancel; }
            set {  dt_cancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Coment�rio: Data de exporta��o dos dados enviados � integradora WMW.
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
        /// Propriedade referente ao campo: DTFAT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfat;
        [XmlElement(ElementName = "DTFAT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfat
        {
            get { return  dtfat; }
            set {  dtfat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfecha;
        [XmlElement(ElementName = "DTFECHA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfecha
        {
            get { return  dtfecha; }
            set {  dtfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHACOMAJUD
        /// Coment�rio: Indica a data de fechamento comiss�o ajudante.
        /// </summary>
        private DateTime? dtfechacomajud;
        [XmlElement(ElementName = "DTFECHACOMAJUD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechacomajud
        {
            get { return  dtfechacomajud; }
            set {  dtfechacomajud = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHACOMAJUDTRANSB
        /// Coment�rio: Indica a data de fechamento comiss�o ajudante.
        /// </summary>
        private DateTime? dtfechacomajudtransb;
        [XmlElement(ElementName = "DTFECHACOMAJUDTRANSB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechacomajudtransb
        {
            get { return  dtfechacomajudtransb; }
            set {  dtfechacomajudtransb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHACOMISSMOT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfechacomissmot;
        [XmlElement(ElementName = "DTFECHACOMISSMOT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechacomissmot
        {
            get { return  dtfechacomissmot; }
            set {  dtfechacomissmot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHACOMMOTTRANSB
        /// Coment�rio: Indica a data de fechamento comiss�o motorista.
        /// </summary>
        private DateTime? dtfechacommottransb;
        [XmlElement(ElementName = "DTFECHACOMMOTTRANSB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechacommottransb
        {
            get { return  dtfechacommottransb; }
            set {  dtfechacommottransb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMCHECKOUT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfimcheckout;
        [XmlElement(ElementName = "DTFIMCHECKOUT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimcheckout
        {
            get { return  dtfimcheckout; }
            set {  dtfimcheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALPEND
        /// Coment�rio: Indica a data de fim da pend�ncia do carregamento.
        /// </summary>
        private DateTime? dtfinalpend;
        [XmlElement(ElementName = "DTFINALPEND", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalpend
        {
            get { return  dtfinalpend; }
            set {  dtfinalpend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIALPEND
        /// Coment�rio: Indica a data de inicio da pend�ncia do carregamento.
        /// </summary>
        private DateTime? dtinicialpend;
        [XmlElement(ElementName = "DTINICIALPEND", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicialpend
        {
            get { return  dtinicialpend; }
            set {  dtinicialpend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOCHECKOUT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtiniciocheckout;
        [XmlElement(ElementName = "DTINICIOCHECKOUT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciocheckout
        {
            get { return  dtiniciocheckout; }
            set {  dtiniciocheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRETORNO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtretorno;
        [XmlElement(ElementName = "DTRETORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtretorno
        {
            get { return  dtretorno; }
            set {  dtretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSAIDA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtsaida;
        [XmlElement(ElementName = "DTSAIDA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtsaida
        {
            get { return  dtsaida; }
            set {  dtsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSAIDAVEICULO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtsaidaveiculo;
        [XmlElement(ElementName = "DTSAIDAVEICULO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtsaidaveiculo
        {
            get { return  dtsaidaveiculo; }
            set {  dtsaidaveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_PESO
        /// Coment�rio: Dados de Frota: quantidade de peso do frete.
        /// </summary>
        private decimal frota_peso;
        [XmlElement(ElementName = "FROTA_PESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Frota_Peso
        {
            get { return  frota_peso; }
            set {  frota_peso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GEROUDESPESAS
        /// Coment�rio: 
        /// </summary>
        private string geroudespesas;
        [XmlElement(ElementName = "GEROUDESPESAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geroudespesas
        {
            get { return  geroudespesas; }
            set {  geroudespesas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOEMBCARGA
        /// Coment�rio: Grupo de Embalagem
        /// </summary>
        private string grupoembcarga;
        [XmlElement(ElementName = "GRUPOEMBCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Grupoembcarga
        {
            get { return  grupoembcarga; }
            set {  grupoembcarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFECHA
        /// Coment�rio: 
        /// </summary>
        private decimal horafecha;
        [XmlElement(ElementName = "HORAFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horafecha
        {
            get { return  horafecha; }
            set {  horafecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAMON
        /// Coment�rio: 
        /// </summary>
        private decimal horamon;
        [XmlElement(ElementName = "HORAMON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horamon
        {
            get { return  horamon; }
            set {  horamon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: KMFINAL
        /// Coment�rio: 
        /// </summary>
        private decimal kmfinal;
        [XmlElement(ElementName = "KMFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Kmfinal
        {
            get { return  kmfinal; }
            set {  kmfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: KMINICIAL
        /// Coment�rio: 
        /// </summary>
        private decimal kminicial;
        [XmlElement(ElementName = "KMINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Kminicial
        {
            get { return  kminicial; }
            set {  kminicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LACRE
        /// Coment�rio: Descri��o do Lacre. Usado no WMS, na integra��o WinThor X ALCIS. 
        /// </summary>
        private string lacre;
        [XmlElement(ElementName = "LACRE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Lacre
        {
            get { return  lacre; }
            set {  lacre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LANCARDESPDESCFINAUTOMATIC
        /// Coment�rio: Lan�a desconto autom�tico.
        /// </summary>
        private string lancardespdescfinautomatic;
        [XmlElement(ElementName = "LANCARDESPDESCFINAUTOMATIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Lancardespdescfinautomatic
        {
            get { return  lancardespdescfinautomatic; }
            set {  lancardespdescfinautomatic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LANCTOCPAGARFECHCOMISS414
        /// Coment�rio: Indica lan�amento de Contas a Pagar no Fech. Comiss�o na 414.
        /// </summary>
        private string lanctocpagarfechcomiss414;
        [XmlElement(ElementName = "LANCTOCPAGARFECHCOMISS414", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Lanctocpagarfechcomiss414
        {
            get { return  lanctocpagarfechcomiss414; }
            set {  lanctocpagarfechcomiss414 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIBERA_RETAGUARDA
        /// Coment�rio: Parametro para liberar ou n�o retaguarda
        /// </summary>
        private string libera_retaguarda;
        [XmlElement(ElementName = "LIBERA_RETAGUARDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Libera_Retaguarda
        {
            get { return  libera_retaguarda; }
            set {  libera_retaguarda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAPAGERADOWMS
        /// Coment�rio: 
        /// </summary>
        private string mapageradowms;
        [XmlElement(ElementName = "MAPAGERADOWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Mapageradowms
        {
            get { return  mapageradowms; }
            set {  mapageradowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAPAGERADOWMSPAL
        /// Coment�rio: 
        /// </summary>
        private string mapageradowmspal;
        [XmlElement(ElementName = "MAPAGERADOWMSPAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Mapageradowmspal
        {
            get { return  mapageradowmspal; }
            set {  mapageradowmspal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOFECHA
        /// Coment�rio: 
        /// </summary>
        private decimal minutofecha;
        [XmlElement(ElementName = "MINUTOFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutofecha
        {
            get { return  minutofecha; }
            set {  minutofecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOMON
        /// Coment�rio: 
        /// </summary>
        private decimal minutomon;
        [XmlElement(ElementName = "MINUTOMON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutomon
        {
            get { return  minutomon; }
            set {  minutomon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEAPROPRIADOCARGA
        /// Coment�rio: Nome apropriado para transporte
        /// </summary>
        private string nomeapropriadocarga;
        [XmlElement(ElementName = "NOMEAPROPRIADOCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Nomeapropriadocarga
        {
            get { return  nomeapropriadocarga; }
            set {  nomeapropriadocarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMCARAGRUPADO
        /// Coment�rio: Indica o n�mero do carregamento agrupado.
        /// </summary>
        private decimal numcaragrupado;
        [XmlElement(ElementName = "NUMCARAGRUPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcaragrupado
        {
            get { return  numcaragrupado; }
            set {  numcaragrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARBROKER
        /// Coment�rio: N�mero de um carregamento Broker que ser� impresso junto com o mapa de separa��o de um carregamento normal. 
        /// </summary>
        private decimal numcarbroker;
        [XmlElement(ElementName = "NUMCARBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcarbroker
        {
            get { return  numcarbroker; }
            set {  numcarbroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARMANIFCONCLUIDOFV
        /// Coment�rio: N�mero do carregamento manifesto concluido para o for�a de vendas
        /// </summary>
        private string numcarmanifconcluidofv;
        [XmlElement(ElementName = "NUMCARMANIFCONCLUIDOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Numcarmanifconcluidofv
        {
            get { return  numcarmanifconcluidofv; }
            set {  numcarmanifconcluidofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAROL
        /// Coment�rio: 
        /// </summary>
        private decimal numcarol;
        [XmlElement(ElementName = "NUMCAROL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcarol
        {
            get { return  numcarol; }
            set {  numcarol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAROPERLOG
        /// Coment�rio: 
        /// </summary>
        private decimal numcaroperlog;
        [XmlElement(ElementName = "NUMCAROPERLOG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcaroperlog
        {
            get { return  numcaroperlog; }
            set {  numcaroperlog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARWMS
        /// Coment�rio: 
        /// </summary>
        private decimal numcarwms;
        [XmlElement(ElementName = "NUMCARWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcarwms
        {
            get { return  numcarwms; }
            set {  numcarwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCID
        /// Coment�rio: 
        /// </summary>
        private decimal numcid;
        [XmlElement(ElementName = "NUMCID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcid
        {
            get { return  numcid; }
            set {  numcid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIARIAS
        /// Coment�rio: 
        /// </summary>
        private decimal numdiarias;
        [XmlElement(ElementName = "NUMDIARIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiarias
        {
            get { return  numdiarias; }
            set {  numdiarias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMENT
        /// Coment�rio: 
        /// </summary>
        private decimal nument;
        [XmlElement(ElementName = "NUMENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Nument
        {
            get { return  nument; }
            set {  nument = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANCDIARIA
        /// Coment�rio: N�mero do Lan�amento gerado pela 1449 na gera��o de Di�rias de Viagens e Despesas Ajudante para n�o permitir o lan�amento novamente.
        /// </summary>
        private decimal numlancdiaria;
        [XmlElement(ElementName = "NUMLANCDIARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numlancdiaria
        {
            get { return  numlancdiaria; }
            set {  numlancdiaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAS
        /// Coment�rio: 
        /// </summary>
        private decimal numnotas;
        [XmlElement(ElementName = "NUMNOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotas
        {
            get { return  numnotas; }
            set {  numnotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMONUCARGA
        /// Coment�rio: N�mero ONU / U N
        /// </summary>
        private string numonucarga;
        [XmlElement(ElementName = "NUMONUCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Numonucarga
        {
            get { return  numonucarga; }
            set {  numonucarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDOTV4
        /// Coment�rio: 
        /// </summary>
        private decimal numpedidotv4;
        [XmlElement(ElementName = "NUMPEDIDOTV4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedidotv4
        {
            get { return  numpedidotv4; }
            set {  numpedidotv4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASCARAGRUPADO
        /// Coment�rio: Indica o n�mero de vias do carregamento agrupado.
        /// </summary>
        private decimal numviascaragrupado;
        [XmlElement(ElementName = "NUMVIASCARAGRUPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numviascaragrupado
        {
            get { return  numviascaragrupado; }
            set {  numviascaragrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASMAPA
        /// Coment�rio: 
        /// </summary>
        private decimal numviasmapa;
        [XmlElement(ElementName = "NUMVIASMAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numviasmapa
        {
            get { return  numviasmapa; }
            set {  numviasmapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSACERTO
        /// Coment�rio: Observa��es sobre o acerto do carregamento, na rotina 402.
        /// </summary>
        private string obsacerto;
        [XmlElement(ElementName = "OBSACERTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obsacerto
        {
            get { return  obsacerto; }
            set {  obsacerto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSDESTINO
        /// Coment�rio: 
        /// </summary>
        private string obsdestino;
        [XmlElement(ElementName = "OBSDESTINO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsdestino
        {
            get { return  obsdestino; }
            set {  obsdestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSDESTINOAGRUP
        /// Coment�rio: Observa��es destino das cargas agrupadas.
        /// </summary>
        private string obsdestinoagrup;
        [XmlElement(ElementName = "OBSDESTINOAGRUP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obsdestinoagrup
        {
            get { return  obsdestinoagrup; }
            set {  obsdestinoagrup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSEXPORTACAO
        /// Coment�rio: Observa��o vindo do retorno da integradora WMW.
        /// </summary>
        private string obsexportacao;
        [XmlElement(ElementName = "OBSEXPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Obsexportacao
        {
            get { return  obsexportacao; }
            set {  obsexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSFATUR
        /// Coment�rio: 
        /// </summary>
        private string obsfatur;
        [XmlElement(ElementName = "OBSFATUR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Obsfatur
        {
            get { return  obsfatur; }
            set {  obsfatur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGCOMMOTMIN
        /// Coment�rio: 
        /// </summary>
        private string pagcommotmin;
        [XmlElement(ElementName = "PAGCOMMOTMIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagcommotmin
        {
            get { return  pagcommotmin; }
            set {  pagcommotmin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Coment�rio: 
        /// </summary>
        private decimal percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMAJUD
        /// Coment�rio: Percentual de comiss�o, por faixa, aplicado no c�lculo da comiss�o para o ajudante.
        /// </summary>
        private decimal percomajud;
        [XmlElement(ElementName = "PERCOMAJUD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percomajud
        {
            get { return  percomajud; }
            set {  percomajud = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMTERC
        /// Coment�rio: Percentual de comiss�o, por faixa, aplicado no c�lculo da comiss�o para o motorista freteiro.
        /// </summary>
        private decimal percomterc;
        [XmlElement(ElementName = "PERCOMTERC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percomterc
        {
            get { return  percomterc; }
            set {  percomterc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERGRIS
        /// Coment�rio: Percentual Gris do carregamento.
        /// </summary>
        private decimal pergris;
        [XmlElement(ElementName = "PERGRIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pergris
        {
            get { return  pergris; }
            set {  pergris = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PONTOFUGORCARGA
        /// Coment�rio: Ponto de Fugor
        /// </summary>
        private string pontofugorcarga;
        [XmlElement(ElementName = "PONTOFUGORCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Pontofugorcarga
        {
            get { return  pontofugorcarga; }
            set {  pontofugorcarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREVCHEG
        /// Coment�rio: 
        /// </summary>
        private DateTime? prevcheg;
        [XmlElement(ElementName = "PREVCHEG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Prevcheg
        {
            get { return  prevcheg; }
            set {  prevcheg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCAIXAS
        /// Coment�rio: 
        /// </summary>
        private decimal qtcaixas;
        [XmlElement(ElementName = "QTCAIXAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtcaixas
        {
            get { return  qtcaixas; }
            set {  qtcaixas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMBUSTIVEL
        /// Coment�rio: 
        /// </summary>
        private decimal qtcombustivel;
        [XmlElement(ElementName = "QTCOMBUSTIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtcombustivel
        {
            get { return  qtcombustivel; }
            set {  qtcombustivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDPEDIDOS
        /// Coment�rio: 
        /// </summary>
        private decimal qtdpedidos;
        [XmlElement(ElementName = "QTDPEDIDOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdpedidos
        {
            get { return  qtdpedidos; }
            set {  qtdpedidos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDTOTALPRODCARGA
        /// Coment�rio: Quantidade Total por produto
        /// </summary>
        private string qtdtotalprodcarga;
        [XmlElement(ElementName = "QTDTOTALPRODCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Qtdtotalprodcarga
        {
            get { return  qtdtotalprodcarga; }
            set {  qtdtotalprodcarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTITENS
        /// Coment�rio: 
        /// </summary>
        private decimal qtitens;
        [XmlElement(ElementName = "QTITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtitens
        {
            get { return  qtitens; }
            set {  qtitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDIDOS
        /// Coment�rio: 
        /// </summary>
        private decimal qtpedidos;
        [XmlElement(ElementName = "QTPEDIDOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtpedidos
        {
            get { return  qtpedidos; }
            set {  qtpedidos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEGUNDOMON
        /// Coment�rio: Segundo em que a montagem da carga foi realizada
        /// </summary>
        private decimal segundomon;
        [XmlElement(ElementName = "SEGUNDOMON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Segundomon
        {
            get { return  segundomon; }
            set {  segundomon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEGUNDOSFECHA
        /// Coment�rio: Segundos do encerramento do carregamento
        /// </summary>
        private decimal segundosfecha;
        [XmlElement(ElementName = "SEGUNDOSFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Segundosfecha
        {
            get { return  segundosfecha; }
            set {  segundosfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEGURADA
        /// Coment�rio: Indica se o carregamento e segurado.
        /// </summary>
        private string segurada;
        [XmlElement(ElementName = "SEGURADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Segurada
        {
            get { return  segurada; }
            set {  segurada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCULOCOMISSAOFRETISTA
        /// Coment�rio: Tipo Calc. Comiss�o Fret.
        /// </summary>
        private string tipocalculocomissaofretista;
        [XmlElement(ElementName = "TIPOCALCULOCOMISSAOFRETISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocalculocomissaofretista
        {
            get { return  tipocalculocomissaofretista; }
            set {  tipocalculocomissaofretista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCARGA
        /// Coment�rio: 
        /// </summary>
        private string tipocarga;
        [XmlElement(ElementName = "TIPOCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocarga
        {
            get { return  tipocarga; }
            set {  tipocarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCOMISSAO
        /// Coment�rio: Identifica se as faixas informadas foram por Valor do Carregamento ou Peso do Carregamento ("P" ou "V").
        /// </summary>
        private string tipocomissao;
        [XmlElement(ElementName = "TIPOCOMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipocomissao
        {
            get { return  tipocomissao; }
            set {  tipocomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESO
        /// Coment�rio: 
        /// </summary>
        private decimal totpeso;
        [XmlElement(ElementName = "TOTPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Totpeso
        {
            get { return  totpeso; }
            set {  totpeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVOLUME
        /// Coment�rio: 
        /// </summary>
        private decimal totvolume;
        [XmlElement(ElementName = "TOTVOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Totvolume
        {
            get { return  totvolume; }
            set {  totvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSFERENCIA
        /// Coment�rio: Indica carga com transfer�ncia.
        /// </summary>
        private string transferencia;
        [XmlElement(ElementName = "TRANSFERENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Transferencia
        {
            get { return  transferencia; }
            set {  transferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORKG
        /// Coment�rio: Valor do frete do carregamento por kg.
        /// </summary>
        private decimal valorkg;
        [XmlElement(ElementName = "VALORKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorkg
        {
            get { return  valorkg; }
            set {  valorkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMBUSTIVEL
        /// Coment�rio: 
        /// </summary>
        private decimal vlcombustivel;
        [XmlElement(ElementName = "VLCOMBUSTIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vlcombustivel
        {
            get { return  vlcombustivel; }
            set {  vlcombustivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPAJUDANTE
        /// Coment�rio: 
        /// </summary>
        private decimal vldespajudante;
        [XmlElement(ElementName = "VLDESPAJUDANTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespajudante
        {
            get { return  vldespajudante; }
            set {  vldespajudante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIARIA
        /// Coment�rio: 
        /// </summary>
        private decimal vldiaria;
        [XmlElement(ElementName = "VLDIARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldiaria
        {
            get { return  vldiaria; }
            set {  vldiaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFIXO
        /// Coment�rio: Vl. fixo de entrega.
        /// </summary>
        private decimal vlfixo;
        [XmlElement(ElementName = "VLFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfixo
        {
            get { return  vlfixo; }
            set {  vlfixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPED
        /// Coment�rio: Vl. de entrega por pedido.
        /// </summary>
        private decimal vlped;
        [XmlElement(ElementName = "VLPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlped
        {
            get { return  vlped; }
            set {  vlped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: VLVALERETENCAO
        /// Coment�rio: 
        /// </summary>
        private decimal vlvaleretencao;
        [XmlElement(ElementName = "VLVALERETENCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvaleretencao
        {
            get { return  vlvaleretencao; }
            set {  vlvaleretencao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCarreg()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCARREG";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCarreg> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCarreg>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCarreg> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCarreg>(where);
        }

        #endregion
    }
}

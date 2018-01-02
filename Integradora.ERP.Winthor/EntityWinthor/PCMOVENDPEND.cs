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
    /// Classe referente a tabela PCMovendpend
    /// </summary>
    [XmlType("PCMOVENDPEND")]
    public class PCMovendpend : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAMADA
        /// Coment�rio: 
        /// </summary>
        private decimal camada;
        [XmlElement(ElementName = "CAMADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Camada
        {
            get { return  camada; }
            set {  camada = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: CODFABRICANTE
        /// Coment�rio: 
        /// </summary>
        private decimal codfabricante;
        [XmlElement(ElementName = "CODFABRICANTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal CodFabricante
        {
            get { return codfabricante; }
            set { codfabricante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBOX
        /// Coment�rio: C�digo do Box
        /// </summary>
        private decimal codbox;
        [XmlElement(ElementName = "CODBOX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbox
        {
            get { return  codbox; }
            set {  codbox = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Coment�rio: 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECOORIG
        /// Coment�rio: 
        /// </summary>
        private decimal codenderecoorig;
        [XmlElement(ElementName = "CODENDERECOORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codenderecoorig
        {
            get { return  codenderecoorig; }
            set {  codenderecoorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFILIALGESTAO
        /// Coment�rio: C�digo Filial Gest�o
        /// </summary>
        private string codfilialgestao;
        [XmlElement(ElementName = "CODFILIALGESTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codfilialgestao
        {
            get { return  codfilialgestao; }
            set {  codfilialgestao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCATRIB
        /// Coment�rio: Indica o c�digo do funcionario de atribui��o.
        /// </summary>
        private decimal codfuncatrib;
        [XmlElement(ElementName = "CODFUNCATRIB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncatrib
        {
            get { return  codfuncatrib; }
            set {  codfuncatrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCOFERENTE
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccoferente;
        [XmlElement(ElementName = "CODFUNCCOFERENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccoferente
        {
            get { return  codfunccoferente; }
            set {  codfunccoferente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONF
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNCEMBALADOR
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncembalador;
        [XmlElement(ElementName = "CODFUNCEMBALADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncembalador
        {
            get { return  codfuncembalador; }
            set {  codfuncembalador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCESTORNO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncestorno;
        [XmlElement(ElementName = "CODFUNCESTORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncestorno
        {
            get { return  codfuncestorno; }
            set {  codfuncestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCGER
        /// Coment�rio: Indica a matricula do funcionario respons�vel ordem servi�o.
        /// </summary>
        private decimal codfuncger;
        [XmlElement(ElementName = "CODFUNCGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncger
        {
            get { return  codfuncger; }
            set {  codfuncger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINICIOS
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncinicios;
        [XmlElement(ElementName = "CODFUNCINICIOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncinicios
        {
            get { return  codfuncinicios; }
            set {  codfuncinicios = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLIBERACAO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncliberacao;
        [XmlElement(ElementName = "CODFUNCLIBERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncliberacao
        {
            get { return  codfuncliberacao; }
            set {  codfuncliberacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCOS
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncos;
        [XmlElement(ElementName = "CODFUNCOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncos
        {
            get { return  codfuncos; }
            set {  codfuncos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCOSFIM
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncosfim;
        [XmlElement(ElementName = "CODFUNCOSFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncosfim
        {
            get { return  codfuncosfim; }
            set {  codfuncosfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOUMA
        /// Coment�rio: 
        /// </summary>
        private decimal codigouma;
        [XmlElement(ElementName = "CODIGOUMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Codigouma
        {
            get { return  codigouma; }
            set {  codigouma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMODSEP
        /// Coment�rio: C�digo do modelo de separa��o utilizado.
        /// </summary>
        private decimal codmodsep;
        [XmlElement(ElementName = "CODMODSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Codmodsep
        {
            get { return  codmodsep; }
            set {  codmodsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO
        /// Coment�rio: Indica o motivo o ajuste de estoque. 
        /// </summary>
        private decimal codmotivo;
        [XmlElement(ElementName = "CODMOTIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmotivo
        {
            get { return  codmotivo; }
            set {  codmotivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPER
        /// Coment�rio: 
        /// </summary>
        private string codoper;
        [XmlElement(ElementName = "CODOPER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codoper
        {
            get { return  codoper; }
            set {  codoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Coment�rio: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODORIG
        /// Coment�rio: 
        /// </summary>
        private decimal codprodorig;
        [XmlElement(ElementName = "CODPRODORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodorig
        {
            get { return  codprodorig; }
            set {  codprodorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CONFTOTALOS
        /// Coment�rio: Conf total da OS
        /// </summary>
        private string conftotalos;
        [XmlElement(ElementName = "CONFTOTALOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conftotalos
        {
            get { return  conftotalos; }
            set {  conftotalos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DATAENVIOVOVOLLECT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataenviovovollect;
        [XmlElement(ElementName = "DATAENVIOVOVOLLECT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataenviovovollect
        {
            get { return  dataenviovovollect; }
            set {  dataenviovovollect = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAGERACAO
        /// Coment�rio: Data e hora da gera��o do item referente a ordem de servi�o
        /// </summary>
        private DateTime? datageracao;
        [XmlElement(ElementName = "DATAGERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datageracao
        {
            get { return  datageracao; }
            set {  datageracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALIBERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataliberacao;
        [XmlElement(ElementName = "DATALIBERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataliberacao
        {
            get { return  dataliberacao; }
            set {  dataliberacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTATRIB
        /// Coment�rio: Indica a data de atribui��o.
        /// </summary>
        private DateTime? dtatrib;
        [XmlElement(ElementName = "DTATRIB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtatrib
        {
            get { return  dtatrib; }
            set {  dtatrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTESTORNO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtestorno;
        [XmlElement(ElementName = "DTESTORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtestorno
        {
            get { return  dtestorno; }
            set {  dtestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFABRICACAO
        /// Coment�rio: Data de Fabrica��o do produto.
        /// </summary>
        private DateTime? dtfabricacao;
        [XmlElement(ElementName = "DTFABRICACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfabricacao
        {
            get { return  dtfabricacao; }
            set {  dtfabricacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMCONFERENCIA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfimconferencia;
        [XmlElement(ElementName = "DTFIMCONFERENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimconferencia
        {
            get { return  dtfimconferencia; }
            set {  dtfimconferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMOS
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfimos;
        [XmlElement(ElementName = "DTFIMOS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimos
        {
            get { return  dtfimos; }
            set {  dtfimos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMOSFILA
        /// Coment�rio: Data de finaliza��o da O.S. na fila de processamento
        /// </summary>
        private DateTime? dtfimosfila;
        [XmlElement(ElementName = "DTFIMOSFILA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimosfila
        {
            get { return  dtfimosfila; }
            set {  dtfimosfila = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMPROMOLOTE
        /// Coment�rio: Data do fim da promo��o
        /// </summary>
        private DateTime? dtfimpromolote;
        [XmlElement(ElementName = "DTFIMPROMOLOTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimpromolote
        {
            get { return  dtfimpromolote; }
            set {  dtfimpromolote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMSEPARACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfimseparacao;
        [XmlElement(ElementName = "DTFIMSEPARACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimseparacao
        {
            get { return  dtfimseparacao; }
            set {  dtfimseparacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGERACAOCLP
        /// Coment�rio: Data Gera��o CLP
        /// </summary>
        private DateTime? dtgeracaoclp;
        [XmlElement(ElementName = "DTGERACAOCLP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgeracaoclp
        {
            get { return  dtgeracaoclp; }
            set {  dtgeracaoclp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGERACAOCPL
        /// Coment�rio: Data Gera��o Confer�ncia
        /// </summary>
        private DateTime? dtgeracaocpl;
        [XmlElement(ElementName = "DTGERACAOCPL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgeracaocpl
        {
            get { return  dtgeracaocpl; }
            set {  dtgeracaocpl = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOCONFERENCIA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtinicioconferencia;
        [XmlElement(ElementName = "DTINICIOCONFERENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicioconferencia
        {
            get { return  dtinicioconferencia; }
            set {  dtinicioconferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOOS
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtinicioos;
        [XmlElement(ElementName = "DTINICIOOS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicioos
        {
            get { return  dtinicioos; }
            set {  dtinicioos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOPROMOLOTE
        /// Coment�rio: Data do inicio da promo��o.
        /// </summary>
        private DateTime? dtiniciopromolote;
        [XmlElement(ElementName = "DTINICIOPROMOLOTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciopromolote
        {
            get { return  dtiniciopromolote; }
            set {  dtiniciopromolote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINTEGRACAO
        /// Coment�rio: Data da integra��o
        /// </summary>
        private DateTime? dtintegracao;
        [XmlElement(ElementName = "DTINTEGRACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtintegracao
        {
            get { return  dtintegracao; }
            set {  dtintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPRIIMP
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtpriimp;
        [XmlElement(ElementName = "DTPRIIMP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpriimp
        {
            get { return  dtpriimp; }
            set {  dtpriimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTIMP
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultimp;
        [XmlElement(ElementName = "DTULTIMP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultimp
        {
            get { return  dtultimp; }
            set {  dtultimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FLOWABAST
        /// Coment�rio: 
        /// </summary>
        private string flowabast;
        [XmlElement(ElementName = "FLOWABAST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Flowabast
        {
            get { return  flowabast; }
            set {  flowabast = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FUNCPRIIMP
        /// Coment�rio: 
        /// </summary>
        private decimal funcpriimp;
        [XmlElement(ElementName = "FUNCPRIIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Funcpriimp
        {
            get { return  funcpriimp; }
            set {  funcpriimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FUNCULTIMP
        /// Coment�rio: 
        /// </summary>
        private decimal funcultimp;
        [XmlElement(ElementName = "FUNCULTIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Funcultimp
        {
            get { return  funcultimp; }
            set {  funcultimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOESTFIMOS
        /// Coment�rio: Grupo de esta��o responsavel pela finalizacao da OS
        /// </summary>
        private decimal grupoestfimos;
        [XmlElement(ElementName = "GRUPOESTFIMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Grupoestfimos
        {
            get { return  grupoestfimos; }
            set {  grupoestfimos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ITEMSEPARADO
        /// Coment�rio: 
        /// </summary>
        private string itemseparado;
        [XmlElement(ElementName = "ITEMSEPARADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Itemseparado
        {
            get { return  itemseparado; }
            set {  itemseparado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LASTRO
        /// Coment�rio: 
        /// </summary>
        private decimal lastro;
        [XmlElement(ElementName = "LASTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Lastro
        {
            get { return  lastro; }
            set {  lastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIBERADOVOCOLLECT
        /// Coment�rio: Liberado no vocollect
        /// </summary>
        private string liberadovocollect;
        [XmlElement(ElementName = "LIBERADOVOCOLLECT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Liberadovocollect
        {
            get { return  liberadovocollect; }
            set {  liberadovocollect = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRFUNC
        /// Coment�rio: 
        /// </summary>
        private decimal matrfunc;
        [XmlElement(ElementName = "MATRFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matrfunc
        {
            get { return  matrfunc; }
            set {  matrfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: MUNICENT
        /// Coment�rio: 
        /// </summary>
        private string municent;
        [XmlElement(ElementName = "MUNICENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Municent
        {
            get { return  municent; }
            set {  municent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGRUPADOR
        /// Coment�rio: N�mero do equipamento agrupador.
        /// </summary>
        private decimal numagrupador;
        [XmlElement(ElementName = "NUMAGRUPADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numagrupador
        {
            get { return  numagrupador; }
            set {  numagrupador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Coment�rio: 
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBOX
        /// Coment�rio: 
        /// </summary>
        private decimal numbox;
        [XmlElement(ElementName = "NUMBOX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numbox
        {
            get { return  numbox; }
            set {  numbox = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMCARFIM
        /// Coment�rio: 
        /// </summary>
        private decimal numcarfim;
        [XmlElement(ElementName = "NUMCARFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcarfim
        {
            get { return  numcarfim; }
            set {  numcarfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARINI
        /// Coment�rio: 
        /// </summary>
        private decimal numcarini;
        [XmlElement(ElementName = "NUMCARINI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcarini
        {
            get { return  numcarini; }
            set {  numcarini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Coment�rio: 
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPALETE
        /// Coment�rio: 
        /// </summary>
        private decimal numpalete;
        [XmlElement(ElementName = "NUMPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numpalete
        {
            get { return  numpalete; }
            set {  numpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPALETE1
        /// Coment�rio: Numero do palete para tipo OS 22.
        /// </summary>
        private decimal numpalete1;
        [XmlElement(ElementName = "NUMPALETE1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numpalete1
        {
            get { return  numpalete1; }
            set {  numpalete1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPALETE2
        /// Coment�rio: Numero do palete para tipo OS 20.
        /// </summary>
        private decimal numpalete2;
        [XmlElement(ElementName = "NUMPALETE2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numpalete2
        {
            get { return  numpalete2; }
            set {  numpalete2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPALETE3
        /// Coment�rio: Numero do palete para tipo OS 13.
        /// </summary>
        private decimal numpalete3;
        [XmlElement(ElementName = "NUMPALETE3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numpalete3
        {
            get { return  numpalete3; }
            set {  numpalete3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDFIM
        /// Coment�rio: 
        /// </summary>
        private decimal numpedfim;
        [XmlElement(ElementName = "NUMPEDFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedfim
        {
            get { return  numpedfim; }
            set {  numpedfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDINI
        /// Coment�rio: 
        /// </summary>
        private decimal numpedini;
        [XmlElement(ElementName = "NUMPEDINI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedini
        {
            get { return  numpedini; }
            set {  numpedini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQENTREGA
        /// Coment�rio: 
        /// </summary>
        private decimal numseqentrega;
        [XmlElement(ElementName = "NUMSEQENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseqentrega
        {
            get { return  numseqentrega; }
            set {  numseqentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQMONTAGEM
        /// Coment�rio: 
        /// </summary>
        private decimal numseqmontagem;
        [XmlElement(ElementName = "NUMSEQMONTAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numseqmontagem
        {
            get { return  numseqmontagem; }
            set {  numseqmontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQSEPARACAO
        /// Coment�rio: 
        /// </summary>
        private decimal numseqseparacao;
        [XmlElement(ElementName = "NUMSEQSEPARACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numseqseparacao
        {
            get { return  numseqseparacao; }
            set {  numseqseparacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Coment�rio: 
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Coment�rio: Indica o n�mero transa��o de entrada.
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMTRANSVENDAFIM
        /// Coment�rio: 
        /// </summary>
        private decimal numtransvendafim;
        [XmlElement(ElementName = "NUMTRANSVENDAFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendafim
        {
            get { return  numtransvendafim; }
            set {  numtransvendafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAINI
        /// Coment�rio: 
        /// </summary>
        private decimal numtransvendaini;
        [XmlElement(ElementName = "NUMTRANSVENDAINI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendaini
        {
            get { return  numtransvendaini; }
            set {  numtransvendaini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSWMS
        /// Coment�rio: 
        /// </summary>
        private decimal numtranswms;
        [XmlElement(ElementName = "NUMTRANSWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranswms
        {
            get { return  numtranswms; }
            set {  numtranswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSWMSORIG
        /// Coment�rio: Indica o n�mero transa��o WMS original.
        /// </summary>
        private decimal numtranswmsorig;
        [XmlElement(ElementName = "NUMTRANSWMSORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranswmsorig
        {
            get { return  numtranswmsorig; }
            set {  numtranswmsorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Coment�rio: 
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASCARGARUA
        /// Coment�rio: N�mero de vias impressas
        /// </summary>
        private decimal numviascargarua;
        [XmlElement(ElementName = "NUMVIASCARGARUA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numviascargarua
        {
            get { return  numviascargarua; }
            set {  numviascargarua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASETIQUETA
        /// Coment�rio: Indica o controle da informa��o de impress�o de etiquetas. |Campo do tipo num�rico, de tamanho 2, sem casas decimais. 
        /// </summary>
        private decimal numviasetiqueta;
        [XmlElement(ElementName = "NUMVIASETIQUETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numviasetiqueta
        {
            get { return  numviasetiqueta; }
            set {  numviasetiqueta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOL
        /// Coment�rio: 
        /// </summary>
        private decimal numvol;
        [XmlElement(ElementName = "NUMVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvol
        {
            get { return  numvol; }
            set {  numvol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOLAGRUPADOR
        /// Coment�rio: N�mero do volume no agrupador.
        /// </summary>
        private decimal numvolagrupador;
        [XmlElement(ElementName = "NUMVOLAGRUPADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvolagrupador
        {
            get { return  numvolagrupador; }
            set {  numvolagrupador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOLPAS
        /// Coment�rio: 
        /// </summary>
        private decimal numvolpas;
        [XmlElement(ElementName = "NUMVOLPAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvolpas
        {
            get { return  numvolpas; }
            set {  numvolpas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOLPED
        /// Coment�rio: N�mero de volume do pedido.
        /// </summary>
        private decimal numvolped;
        [XmlElement(ElementName = "NUMVOLPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvolped
        {
            get { return  numvolped; }
            set {  numvolped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��o.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAOINICIADARF
        /// Coment�rio: 
        /// </summary>
        private string operacaoiniciadarf;
        [XmlElement(ElementName = "OPERACAOINICIADARF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Operacaoiniciadarf
        {
            get { return  operacaoiniciadarf; }
            set {  operacaoiniciadarf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEMTRANSF
        /// Coment�rio: CAMPO PARA PODER CONTEMPLAR C�LCULOS DE LISTAGEM DA ROTINA 1714
        /// </summary>
        private string ordemtransf;
        [XmlElement(ElementName = "ORDEMTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ordemtransf
        {
            get { return  ordemtransf; }
            set {  ordemtransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOCAMADA1
        /// Coment�rio: 
        /// </summary>
        private decimal pesocamada1;
        [XmlElement(ElementName = "PESOCAMADA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pesocamada1
        {
            get { return  pesocamada1; }
            set {  pesocamada1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOCAMADA2
        /// Coment�rio: 
        /// </summary>
        private decimal pesocamada2;
        [XmlElement(ElementName = "PESOCAMADA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pesocamada2
        {
            get { return  pesocamada2; }
            set {  pesocamada2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Coment�rio: 
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Posicao
        {
            get { return  posicao; }
            set {  posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRIORIDADERF
        /// Coment�rio: Indica a prioridade no RF.
        /// </summary>
        private decimal prioridaderf;
        [XmlElement(ElementName = "PRIORIDADERF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Prioridaderf
        {
            get { return  prioridaderf; }
            set {  prioridaderf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PULASEQCONF
        /// Coment�rio: PULAR SEQUENCIA DE CONFERENCIA
        /// </summary>
        private string pulaseqconf;
        [XmlElement(ElementName = "PULASEQCONF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pulaseqconf
        {
            get { return  pulaseqconf; }
            set {  pulaseqconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCANCEL
        /// Coment�rio: 
        /// </summary>
        private DateTime? qtcancel;
        [XmlElement(ElementName = "QTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Qtcancel
        {
            get { return  qtcancel; }
            set {  qtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCONFERIDA
        /// Coment�rio: 
        /// </summary>
        private decimal qtconferida;
        [XmlElement(ElementName = "QTCONFERIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtconferida
        {
            get { return  qtconferida; }
            set {  qtconferida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCX
        /// Coment�rio: QUANTIDADE DE CAIXAS
        /// </summary>
        private decimal qtcx;
        [XmlElement(ElementName = "QTCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtcx
        {
            get { return  qtcx; }
            set {  qtcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCXORIG
        /// Coment�rio: QUANTIDADE DE CAIXAS ORIGINAL
        /// </summary>
        private decimal qtcxorig;
        [XmlElement(ElementName = "QTCXORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtcxorig
        {
            get { return  qtcxorig; }
            set {  qtcxorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEFALTAINFORMADA
        /// Coment�rio: Identificar a qtde. de falta informada na confer�ncia.
        /// </summary>
        private decimal qtdefaltainformada;
        [XmlElement(ElementName = "QTDEFALTAINFORMADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdefaltainformada
        {
            get { return  qtdefaltainformada; }
            set {  qtdefaltainformada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTERROS
        /// Coment�rio: 
        /// </summary>
        private decimal qterros;
        [XmlElement(ElementName = "QTERROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qterros
        {
            get { return  qterros; }
            set {  qterros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTDISPANT
        /// Coment�rio: 
        /// </summary>
        private decimal qtestdispant;
        [XmlElement(ElementName = "QTESTDISPANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtestdispant
        {
            get { return  qtestdispant; }
            set {  qtestdispant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTORIG
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: QTPECAS
        /// Coment�rio: Quantidade de pe�as no item da OS
        /// </summary>
        private decimal qtpecas;
        [XmlElement(ElementName = "QTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpecas
        {
            get { return  qtpecas; }
            set {  qtpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPECASORIG
        /// Coment�rio: QUANTIDADE DE PE�AS ORIGINAL
        /// </summary>
        private decimal qtpecasorig;
        [XmlElement(ElementName = "QTPECASORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtpecasorig
        {
            get { return  qtpecasorig; }
            set {  qtpecasorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERVADA
        /// Coment�rio: 
        /// </summary>
        private decimal qtreservada;
        [XmlElement(ElementName = "QTRESERVADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtreservada
        {
            get { return  qtreservada; }
            set {  qtreservada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSEPARADA
        /// Coment�rio: 
        /// </summary>
        private decimal qtseparada;
        [XmlElement(ElementName = "QTSEPARADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtseparada
        {
            get { return  qtseparada; }
            set {  qtseparada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESPAVARIA
        /// Coment�rio: Indica o respons�vel pela avaria.
        /// </summary>
        private string respavaria;
        [XmlElement(ElementName = "RESPAVARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Respavaria
        {
            get { return  respavaria; }
            set {  respavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQCONF
        /// Coment�rio: 
        /// </summary>
        private decimal seqconf;
        [XmlElement(ElementName = "SEQCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Seqconf
        {
            get { return  seqconf; }
            set {  seqconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQPALETE
        /// Coment�rio: 
        /// </summary>
        private decimal seqpalete;
        [XmlElement(ElementName = "SEQPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Seqpalete
        {
            get { return  seqpalete; }
            set {  seqpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQUMA
        /// Coment�rio: 
        /// </summary>
        private decimal sequma;
        [XmlElement(ElementName = "SEQUMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Sequma
        {
            get { return  sequma; }
            set {  sequma = value; }
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
        /// Propriedade referente ao campo: TIPOENDERECAMENTO
        /// Coment�rio: Tipo de endere�amento
        /// </summary>
        private string tipoenderecamento;
        [XmlElement(ElementName = "TIPOENDERECAMENTO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoenderecamento
        {
            get { return  tipoenderecamento; }
            set {  tipoenderecamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOS
        /// Coment�rio: 
        /// </summary>
        private decimal tipoos;
        [XmlElement(ElementName = "TIPOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Tipoos
        {
            get { return  tipoos; }
            set {  tipoos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPROD
        /// Coment�rio: 
        /// </summary>
        private decimal tipoprod;
        [XmlElement(ElementName = "TIPOPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipoprod
        {
            get { return  tipoprod; }
            set {  tipoprod = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMovendpend()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVENDPEND";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMovendpend> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovendpend>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMovendpend> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovendpend>(where);
        }

        #endregion

    }
}

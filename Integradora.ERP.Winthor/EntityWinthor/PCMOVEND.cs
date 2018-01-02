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
    /// Classe referente a tabela PCMovend
    /// </summary>
    [XmlType("PCMOVEND")]
    public class PCMovend : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APTO
        /// Comentário: 
        /// </summary>
        private decimal apto;
        [XmlElement(ElementName = "APTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Apto
        {
            get { return  apto; }
            set {  apto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APTOO
        /// Comentário: 
        /// </summary>
        private decimal aptoo;
        [XmlElement(ElementName = "APTOO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Aptoo
        {
            get { return  aptoo; }
            set {  aptoo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMITE
        /// Comentário: 
        /// </summary>
        private decimal codemite;
        [XmlElement(ElementName = "CODEMITE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codemite
        {
            get { return  codemite; }
            set {  codemite = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFUNCEMPILHADEIRA
        /// Comentário: 
        /// </summary>
        private decimal codfuncempilhadeira;
        [XmlElement(ElementName = "CODFUNCEMPILHADEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncempilhadeira
        {
            get { return  codfuncempilhadeira; }
            set {  codfuncempilhadeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCESTORNO
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFUNCSEP
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFUNCTRANSPALETEIRA
        /// Comentário: 
        /// </summary>
        private decimal codfunctranspaleteira;
        [XmlElement(ElementName = "CODFUNCTRANSPALETEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunctranspaleteira
        {
            get { return  codfunctranspaleteira; }
            set {  codfunctranspaleteira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO
        /// Comentário: Indica o motivo o ajuste de estoque. |Campo do tipo numérico, de tamanho 6, sem casas decimais. 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODOPERADOR
        /// Comentário: 
        /// </summary>
        private decimal codoperador;
        [XmlElement(ElementName = "CODOPERADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codoperador
        {
            get { return  codoperador; }
            set {  codoperador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: 
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
        /// Propriedade referente ao campo: COMANDAEMITIDA
        /// Comentário: 
        /// </summary>
        private string comandaemitida;
        [XmlElement(ElementName = "COMANDAEMITIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Comandaemitida
        {
            get { return  comandaemitida; }
            set {  comandaemitida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
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
        /// Propriedade referente ao campo: DEPOSITO
        /// Comentário: 
        /// </summary>
        private decimal deposito;
        [XmlElement(ElementName = "DEPOSITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Deposito
        {
            get { return  deposito; }
            set {  deposito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEPOSITOO
        /// Comentário: 
        /// </summary>
        private decimal depositoo;
        [XmlElement(ElementName = "DEPOSITOO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Depositoo
        {
            get { return  depositoo; }
            set {  depositoo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTESTORNO
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTFIMABAST
        /// Comentário: 
        /// </summary>
        private DateTime? dtfimabast;
        [XmlElement(ElementName = "DTFIMABAST", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimabast
        {
            get { return  dtfimabast; }
            set {  dtfimabast = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMSEP
        /// Comentário: 
        /// </summary>
        private DateTime? dtfimsep;
        [XmlElement(ElementName = "DTFIMSEP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimsep
        {
            get { return  dtfimsep; }
            set {  dtfimsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINIABAST
        /// Comentário: 
        /// </summary>
        private DateTime? dtiniabast;
        [XmlElement(ElementName = "DTINIABAST", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniabast
        {
            get { return  dtiniabast; }
            set {  dtiniabast = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOSEP
        /// Comentário: 
        /// </summary>
        private DateTime? dtiniciosep;
        [XmlElement(ElementName = "DTINICIOSEP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciosep
        {
            get { return  dtiniciosep; }
            set {  dtiniciosep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSALDOATUAL
        /// Comentário: 
        /// </summary>
        private DateTime? dtsaldoatual;
        [XmlElement(ElementName = "DTSALDOATUAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtsaldoatual
        {
            get { return  dtsaldoatual; }
            set {  dtsaldoatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Comentário: 
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
        /// Propriedade referente ao campo: HORA
        /// Comentário: 
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
        /// Propriedade referente ao campo: HORAFIMABAST
        /// Comentário: 
        /// </summary>
        private decimal horafimabast;
        [XmlElement(ElementName = "HORAFIMABAST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horafimabast
        {
            get { return  horafimabast; }
            set {  horafimabast = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFIMSEP
        /// Comentário: 
        /// </summary>
        private decimal horafimsep;
        [XmlElement(ElementName = "HORAFIMSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horafimsep
        {
            get { return  horafimsep; }
            set {  horafimsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINIABAST
        /// Comentário: 
        /// </summary>
        private decimal horainiabast;
        [XmlElement(ElementName = "HORAINIABAST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horainiabast
        {
            get { return  horainiabast; }
            set {  horainiabast = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINICIOSEP
        /// Comentário: 
        /// </summary>
        private decimal horainiciosep;
        [XmlElement(ElementName = "HORAINICIOSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horainiciosep
        {
            get { return  horainiciosep; }
            set {  horainiciosep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINFIMABAST
        /// Comentário: 
        /// </summary>
        private decimal minfimabast;
        [XmlElement(ElementName = "MINFIMABAST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minfimabast
        {
            get { return  minfimabast; }
            set {  minfimabast = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINFIMSEP
        /// Comentário: 
        /// </summary>
        private decimal minfimsep;
        [XmlElement(ElementName = "MINFIMSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minfimsep
        {
            get { return  minfimsep; }
            set {  minfimsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MININIABAST
        /// Comentário: 
        /// </summary>
        private decimal mininiabast;
        [XmlElement(ElementName = "MININIABAST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Mininiabast
        {
            get { return  mininiabast; }
            set {  mininiabast = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MININICIOSEP
        /// Comentário: 
        /// </summary>
        private decimal mininiciosep;
        [XmlElement(ElementName = "MININICIOSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Mininiciosep
        {
            get { return  mininiciosep; }
            set {  mininiciosep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTO
        /// Comentário: 
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
        /// Propriedade referente ao campo: MODULO
        /// Comentário: 
        /// </summary>
        private decimal modulo;
        [XmlElement(ElementName = "MODULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Modulo
        {
            get { return  modulo; }
            set {  modulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVEL
        /// Comentário: 
        /// </summary>
        private decimal nivel;
        [XmlElement(ElementName = "NIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Nivel
        {
            get { return  nivel; }
            set {  nivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVELO
        /// Comentário: 
        /// </summary>
        private decimal nivelo;
        [XmlElement(ElementName = "NIVELO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Nivelo
        {
            get { return  nivelo; }
            set {  nivelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMDOC
        /// Comentário: 
        /// </summary>
        private decimal numdoc;
        [XmlElement(ElementName = "NUMDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numdoc
        {
            get { return  numdoc; }
            set {  numdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Comentário: 
        /// </summary>
        private decimal numero;
        [XmlElement(ElementName = "NUMERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numero
        {
            get { return  numero; }
            set {  numero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Comentário: 
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
        /// Comentário: 
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMVIAS
        /// Comentário: 
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
        /// Propriedade referente ao campo: PREDIO
        /// Comentário: 
        /// </summary>
        private decimal predio;
        [XmlElement(ElementName = "PREDIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Predio
        {
            get { return  predio; }
            set {  predio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREDIOO
        /// Comentário: 
        /// </summary>
        private decimal predioo;
        [XmlElement(ElementName = "PREDIOO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Predioo
        {
            get { return  predioo; }
            set {  predioo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: 
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
        /// Propriedade referente ao campo: QTPECAS
        /// Comentário: Campo para contemplar cálculos de peso variável.
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
        /// Propriedade referente ao campo: QTRESERVADA
        /// Comentário: 
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
        /// Propriedade referente ao campo: QTSALDOATUAL
        /// Comentário: 
        /// </summary>
        private decimal qtsaldoatual;
        [XmlElement(ElementName = "QTSALDOATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtsaldoatual
        {
            get { return  qtsaldoatual; }
            set {  qtsaldoatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA
        /// Comentário: 
        /// </summary>
        private decimal rua;
        [XmlElement(ElementName = "RUA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Rua
        {
            get { return  rua; }
            set {  rua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUAO
        /// Comentário: 
        /// </summary>
        private decimal ruao;
        [XmlElement(ElementName = "RUAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Ruao
        {
            get { return  ruao; }
            set {  ruao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPROD
        /// Comentário: 
        /// </summary>
        private decimal tipoprod;
        [XmlElement(ElementName = "TIPOPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipoprod
        {
            get { return  tipoprod; }
            set {  tipoprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOROTINA
        /// Comentário: Indica a versão do aplicativo.|Campo do tipo caracter, de tamanho 10. 
        /// </summary>
        private string versaorotina;
        [XmlElement(ElementName = "VERSAOROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Versaorotina
        {
            get { return  versaorotina; }
            set {  versaorotina = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMovend()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVEND";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMovend> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovend>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMovend> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovend>(where);
        }

        #endregion
    }
}

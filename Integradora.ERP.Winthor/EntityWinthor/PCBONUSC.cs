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
    /// Classe referente a tabela PCBonusc
    /// </summary>
    [XmlType("PCBONUSC")]
    public class PCBonusc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BOX
        /// Coment�rio: 
        /// </summary>
        private decimal? box;
        [XmlElement(ElementName = "BOX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Box
        {
            get { return  box; }
            set {  box = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCDESCARGA
        /// Coment�rio: 
        /// </summary>
        private string calcdescarga;
        [XmlElement(ElementName = "CALCDESCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcdescarga
        {
            get { return  calcdescarga; }
            set {  calcdescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCORECDESCARGA
        /// Coment�rio: Indica o banco do calculo de descarga.
        /// </summary>
        private decimal? codbancorecdescarga;
        [XmlElement(ElementName = "CODBANCORECDESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codbancorecdescarga
        {
            get { return  codbancorecdescarga; }
            set {  codbancorecdescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCORECREMONTE
        /// Coment�rio: Indica o c�digo do banco.
        /// </summary>
        private decimal? codbancorecremonte;
        [XmlElement(ElementName = "CODBANCORECREMONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codbancorecremonte
        {
            get { return  codbancorecremonte; }
            set {  codbancorecremonte = value; }
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
        /// Propriedade referente ao campo: CODFORNECTRANSP
        /// Coment�rio: 
        /// </summary>
        private decimal? codfornectransp;
        [XmlElement(ElementName = "CODFORNECTRANSP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codfornectransp
        {
            get { return  codfornectransp; }
            set {  codfornectransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCBONUS
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncbonus;
        [XmlElement(ElementName = "CODFUNCBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncbonus
        {
            get { return  codfuncbonus; }
            set {  codfuncbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCANCEL
        /// Coment�rio: 
        /// </summary>
        private decimal? codfunccancel;
        [XmlElement(ElementName = "CODFUNCCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunccancel
        {
            get { return  codfunccancel; }
            set {  codfunccancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFECHA
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncfecha;
        [XmlElement(ElementName = "CODFUNCFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncfecha
        {
            get { return  codfuncfecha; }
            set {  codfuncfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCRM
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncrm;
        [XmlElement(ElementName = "CODFUNCRM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncrm
        {
            get { return  codfuncrm; }
            set {  codfuncrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATABONUS
        /// Coment�rio: 
        /// </summary>
        private DateTime? databonus;
        [XmlElement(ElementName = "DATABONUS", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Databonus
        {
            get { return  databonus; }
            set {  databonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFECHACOMPLETA
        /// Coment�rio: Indica a data fechamento.
        /// </summary>
        private DateTime? datafechacompleta;
        [XmlElement(ElementName = "DATAFECHACOMPLETA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafechacompleta
        {
            get { return  datafechacompleta; }
            set {  datafechacompleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATARM
        /// Coment�rio: 
        /// </summary>
        private DateTime? datarm;
        [XmlElement(ElementName = "DATARM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datarm
        {
            get { return  datarm; }
            set {  datarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTDESCARGA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtdescarga;
        [XmlElement(ElementName = "DTDESCARGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdescarga
        {
            get { return  dtdescarga; }
            set {  dtdescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHAMENTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfechamento;
        [XmlElement(ElementName = "DTFECHAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechamento
        {
            get { return  dtfechamento; }
            set {  dtfechamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHAMENTOTOTAL
        /// Coment�rio: Indica a Data e hora de fechamento bonus.
        /// </summary>
        private DateTime? dtfechamentototal;
        [XmlElement(ElementName = "DTFECHAMENTOTOTAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechamentototal
        {
            get { return  dtfechamentototal; }
            set {  dtfechamentototal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTMONTAGEM
        /// Coment�rio: Indica a data de montagem do b�nus.
        /// </summary>
        private DateTime? dtmontagem;
        [XmlElement(ElementName = "DTMONTAGEM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtmontagem
        {
            get { return  dtmontagem; }
            set {  dtmontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITIDO
        /// Coment�rio: 
        /// </summary>
        private string emitido;
        [XmlElement(ElementName = "EMITIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emitido
        {
            get { return  emitido; }
            set {  emitido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Coment�rio: 
        /// </summary>
        private decimal? hora;
        [XmlElement(ElementName = "HORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAMONTAGEM
        /// Coment�rio: 
        /// </summary>
        private decimal? horamontagem;
        [XmlElement(ElementName = "HORAMONTAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Horamontagem
        {
            get { return  horamontagem; }
            set {  horamontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTO
        /// Coment�rio: 
        /// </summary>
        private decimal? minuto;
        [XmlElement(ElementName = "MINUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Minuto
        {
            get { return  minuto; }
            set {  minuto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOMONTAGEM
        /// Coment�rio: 
        /// </summary>
        private decimal? minutomontagem;
        [XmlElement(ElementName = "MINUTOMONTAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Minutomontagem
        {
            get { return  minutomontagem; }
            set {  minutomontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOCANCEL
        /// Coment�rio: 
        /// </summary>
        private string motivocancel;
        [XmlElement(ElementName = "MOTIVOCANCEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Motivocancel
        {
            get { return  motivocancel; }
            set {  motivocancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEMOTORISTA
        /// Coment�rio: 
        /// </summary>
        private string nomemotorista;
        [XmlElement(ElementName = "NOMEMOTORISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Nomemotorista
        {
            get { return  nomemotorista; }
            set {  nomemotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Coment�rio: 
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTLOTE
        /// Coment�rio: NUMERO TRANSA��O ENTRADA DE LOTE
        /// </summary>
        private decimal? numtransentlote;
        [XmlElement(ElementName = "NUMTRANSENTLOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtransentlote
        {
            get { return  numtransentlote; }
            set {  numtransentlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDALOTE
        /// Coment�rio: NUMERO TRANSA��O DE VENDA DE LOTE
        /// </summary>
        private decimal? numtransvendalote;
        [XmlElement(ElementName = "NUMTRANSVENDALOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtransvendalote
        {
            get { return  numtransvendalote; }
            set {  numtransvendalote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASBONUS
        /// Coment�rio: Indica a quantidade de c�pias emitidas do bonus.
        /// </summary>
        private decimal? numviasbonus;
        [XmlElement(ElementName = "NUMVIASBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Numviasbonus
        {
            get { return  numviasbonus; }
            set {  numviasbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASRECIBO
        /// Coment�rio: Indica a quantidade de vias impressa.
        /// </summary>
        private decimal? numviasrecibo;
        [XmlElement(ElementName = "NUMVIASRECIBO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Numviasrecibo
        {
            get { return  numviasrecibo; }
            set {  numviasrecibo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASRECIBOREMONTE
        /// Coment�rio: Indica o n�mero de vias de impress�o.
        /// </summary>
        private decimal? numviasreciboremonte;
        [XmlElement(ElementName = "NUMVIASRECIBOREMONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Numviasreciboremonte
        {
            get { return  numviasreciboremonte; }
            set {  numviasreciboremonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,240)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS1
        /// Coment�rio: 
        /// </summary>
        private string obs1;
        [XmlElement(ElementName = "OBS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs1
        {
            get { return  obs1; }
            set {  obs1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Coment�rio: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS3
        /// Coment�rio: 
        /// </summary>
        private string obs3;
        [XmlElement(ElementName = "OBS3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Obs3
        {
            get { return  obs3; }
            set {  obs3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS4
        /// Coment�rio: 
        /// </summary>
        private string obs4;
        [XmlElement(ElementName = "OBS4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Obs4
        {
            get { return  obs4; }
            set {  obs4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS5
        /// Coment�rio: 
        /// </summary>
        private string obs5;
        [XmlElement(ElementName = "OBS5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Obs5
        {
            get { return  obs5; }
            set {  obs5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESO
        /// Coment�rio: 
        /// </summary>
        private decimal? peso;
        [XmlElement(ElementName = "PESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Peso
        {
            get { return  peso; }
            set {  peso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBALANCA1
        /// Coment�rio: 
        /// </summary>
        private decimal? pesobalanca1;
        [XmlElement(ElementName = "PESOBALANCA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Pesobalanca1
        {
            get { return  pesobalanca1; }
            set {  pesobalanca1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBALANCA2
        /// Coment�rio: 
        /// </summary>
        private decimal? pesobalanca2;
        [XmlElement(ElementName = "PESOBALANCA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Pesobalanca2
        {
            get { return  pesobalanca2; }
            set {  pesobalanca2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOTOTAL
        /// Coment�rio: 
        /// </summary>
        private decimal? pesototal;
        [XmlElement(ElementName = "PESOTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Pesototal
        {
            get { return  pesototal; }
            set {  pesototal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLACA
        /// Coment�rio: 
        /// </summary>
        private string placa;
        [XmlElement(ElementName = "PLACA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Placa
        {
            get { return  placa; }
            set {  placa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQUEADALIBERADA
        /// Coment�rio: 
        /// </summary>
        private string qtbloqueadaliberada;
        [XmlElement(ElementName = "QTBLOQUEADALIBERADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Qtbloqueadaliberada
        {
            get { return  qtbloqueadaliberada; }
            set {  qtbloqueadaliberada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTNFS
        /// Coment�rio: 
        /// </summary>
        private decimal? qtnfs;
        [XmlElement(ElementName = "QTNFS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal? Qtnfs
        {
            get { return  qtnfs; }
            set {  qtnfs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPALETESREMONTE
        /// Coment�rio: Indica a quantidade de paletes.
        /// </summary>
        private decimal? qtpaletesremonte;
        [XmlElement(ElementName = "QTPALETESREMONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Qtpaletesremonte
        {
            get { return  qtpaletesremonte; }
            set {  qtpaletesremonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHA
        /// Coment�rio: 
        /// </summary>
        private decimal? senha;
        [XmlElement(ElementName = "SENHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Senha
        {
            get { return  senha; }
            set {  senha = value; }
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
        /// Propriedade referente ao campo: TIPODESCARGA
        /// Coment�rio: 
        /// </summary>
        private string tipodescarga;
        [XmlElement(ElementName = "TIPODESCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodescarga
        {
            get { return  tipodescarga; }
            set {  tipodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSENHA
        /// Coment�rio: 
        /// </summary>
        private string tiposenha;
        [XmlElement(ElementName = "TIPOSENHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiposenha
        {
            get { return  tiposenha; }
            set {  tiposenha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESODESCARGA
        /// Coment�rio: 
        /// </summary>
        private decimal? totpesodescarga;
        [XmlElement(ElementName = "TOTPESODESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Totpesodescarga
        {
            get { return  totpesodescarga; }
            set {  totpesodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVOLUMEDESCARGA
        /// Coment�rio: 
        /// </summary>
        private decimal? totvolumedescarga;
        [XmlElement(ElementName = "TOTVOLUMEDESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Totvolumedescarga
        {
            get { return  totvolumedescarga; }
            set {  totvolumedescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORTOTAL
        /// Coment�rio: 
        /// </summary>
        private decimal? valortotal;
        [XmlElement(ElementName = "VALORTOTAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal? Valortotal
        {
            get { return  valortotal; }
            set {  valortotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADICIONAL
        /// Coment�rio: 
        /// </summary>
        private decimal? vladicional;
        [XmlElement(ElementName = "VLADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Vladicional
        {
            get { return  vladicional; }
            set {  vladicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCARGA
        /// Coment�rio: 
        /// </summary>
        private decimal? vldescarga;
        [XmlElement(ElementName = "VLDESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Vldescarga
        {
            get { return  vldescarga; }
            set {  vldescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCARGAP
        /// Coment�rio: 
        /// </summary>
        private decimal? vldescargap;
        [XmlElement(ElementName = "VLDESCARGAP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Vldescargap
        {
            get { return  vldescargap; }
            set {  vldescargap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCARGAV
        /// Coment�rio: 
        /// </summary>
        private decimal? vldescargav;
        [XmlElement(ElementName = "VLDESCARGAV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Vldescargav
        {
            get { return  vldescargav; }
            set {  vldescargav = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Coment�rio: Valor do desconto no recibo de descarga.
        /// </summary>
        private decimal? vldesconto;
        [XmlElement(ElementName = "VLDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Vldesconto
        {
            get { return  vldesconto; }
            set {  vldesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLINFORMADO
        /// Coment�rio: 
        /// </summary>
        private decimal? vlinformado;
        [XmlElement(ElementName = "VLINFORMADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Vlinformado
        {
            get { return  vlinformado; }
            set {  vlinformado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREMONTE
        /// Coment�rio: Indica o valor do remonte.
        /// </summary>
        private decimal? vlremonte;
        [XmlElement(ElementName = "VLREMONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Vlremonte
        {
            get { return  vlremonte; }
            set {  vlremonte = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBonusc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBONUSC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBonusc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBonusc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBonusc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBonusc>(where);
        }

        #endregion
    }
}

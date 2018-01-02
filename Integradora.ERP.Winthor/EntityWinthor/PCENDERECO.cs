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
    /// Classe referente a tabela PCEndereco
    /// </summary>
    [XmlType("PCENDERECO")]
    public class PCEndereco : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APTO
        /// Coment�rio: 
        /// </summary>
        private decimal apto;
        [XmlElement(ElementName = "APTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Apto
        {
            get { return  apto; }
            set {  apto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIO
        /// Coment�rio: 
        /// </summary>
        private string bloqueio;
        [XmlElement(ElementName = "BLOQUEIO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Bloqueio
        {
            get { return  bloqueio; }
            set {  bloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODARMAZENAGEM
        /// Coment�rio: 
        /// </summary>
        private decimal codarmazenagem;
        [XmlElement(ElementName = "CODARMAZENAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Codarmazenagem
        {
            get { return  codarmazenagem; }
            set {  codarmazenagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Coment�rio: C�digo do Endere�o. |Campo do tipo num�rico, de tamanho 8, sem casas decimais, obrigat�rio. 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODESTRUTURA
        /// Coment�rio: 
        /// </summary>
        private decimal codestrutura;
        [XmlElement(ElementName = "CODESTRUTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Codestrutura
        {
            get { return  codestrutura; }
            set {  codestrutura = value; }
        }

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
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCSEP
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncultalter;
        [XmlElement(ElementName = "CODFUNCULTALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalter
        {
            get { return  codfuncultalter; }
            set {  codfuncultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: Indica o c�digo do produto.
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
        /// Propriedade referente ao campo: DEPOSITO
        /// Coment�rio: 
        /// </summary>
        private decimal deposito;
        [XmlElement(ElementName = "DEPOSITO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public decimal Deposito
        {
            get { return  deposito; }
            set {  deposito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIGITOVERIFICADOR
        /// Coment�rio: 
        /// </summary>
        private decimal digitoverificador;
        [XmlElement(ElementName = "DIGITOVERIFICADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Digitoverificador
        {
            get { return  digitoverificador; }
            set {  digitoverificador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTER
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultalter;
        [XmlElement(ElementName = "DTULTALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalter
        {
            get { return  dtultalter; }
            set {  dtultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtval;
        [XmlElement(ElementName = "DTVAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtval
        {
            get { return  dtval; }
            set {  dtval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTACAO
        /// Coment�rio: 
        /// </summary>
        private decimal estacao;
        [XmlElement(ElementName = "ESTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Estacao
        {
            get { return  estacao; }
            set {  estacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVEL
        /// Coment�rio: 
        /// </summary>
        private decimal nivel;
        [XmlElement(ElementName = "NIVEL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Nivel
        {
            get { return  nivel; }
            set {  nivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Coment�rio: 
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINVENT
        /// Coment�rio: 
        /// </summary>
        private decimal numinvent;
        [XmlElement(ElementName = "NUMINVENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numinvent
        {
            get { return  numinvent; }
            set {  numinvent = value; }
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
        /// Propriedade referente ao campo: PCKROTATIVO
        /// Coment�rio: 
        /// </summary>
        private string pckrotativo;
        [XmlElement(ElementName = "PCKROTATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pckrotativo
        {
            get { return  pckrotativo; }
            set {  pckrotativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSSUIELEVADORCARGA
        /// Coment�rio: 
        /// </summary>
        private string possuielevadorcarga;
        [XmlElement(ElementName = "POSSUIELEVADORCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Possuielevadorcarga
        {
            get { return  possuielevadorcarga; }
            set {  possuielevadorcarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREDIO
        /// Coment�rio: 
        /// </summary>
        private decimal predio;
        [XmlElement(ElementName = "PREDIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Predio
        {
            get { return  predio; }
            set {  predio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREDIOENT
        /// Coment�rio: Pr�dio para Push-back
        /// </summary>
        private decimal predioent;
        [XmlElement(ElementName = "PREDIOENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Predioent
        {
            get { return  predioent; }
            set {  predioent = value; }
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
        /// Propriedade referente ao campo: QTBLOQUEADA
        /// Coment�rio: 
        /// </summary>
        private decimal qtbloqueada;
        [XmlElement(ElementName = "QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtbloqueada
        {
            get { return  qtbloqueada; }
            set {  qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPALETEENDER
        /// Coment�rio: Campo respons�vel por armazenar a quantidad de palete enderecavei por filial.
        /// </summary>
        private decimal qtpaleteender;
        [XmlElement(ElementName = "QTPALETEENDER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtpaleteender
        {
            get { return  qtpaleteender; }
            set {  qtpaleteender = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERV
        /// Coment�rio: 
        /// </summary>
        private decimal qtreserv;
        [XmlElement(ElementName = "QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtreserv
        {
            get { return  qtreserv; }
            set {  qtreserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA
        /// Coment�rio: 
        /// </summary>
        private decimal rua;
        [XmlElement(ElementName = "RUA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Rua
        {
            get { return  rua; }
            set {  rua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUAENT
        /// Coment�rio: Rua para Push-back
        /// </summary>
        private decimal ruaent;
        [XmlElement(ElementName = "RUAENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Ruaent
        {
            get { return  ruaent; }
            set {  ruaent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: 
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOENDER
        /// Coment�rio: 
        /// </summary>
        private string tipoender;
        [XmlElement(ElementName = "TIPOENDER", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tipoender
        {
            get { return  tipoender; }
            set {  tipoender = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPAL
        /// Coment�rio: 
        /// </summary>
        private decimal tipopal;
        [XmlElement(ElementName = "TIPOPAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Tipopal
        {
            get { return  tipopal; }
            set {  tipopal = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEndereco()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCENDERECO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEndereco> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEndereco>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEndereco> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEndereco>(where);
        }

        #endregion
    }
}

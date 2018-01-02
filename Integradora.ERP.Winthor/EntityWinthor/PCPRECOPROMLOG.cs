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
    /// Classe referente a tabela PCPrecopromlog
    /// </summary>
    [XmlType("PCPRECOPROMLOG")]
    public class PCPrecopromlog : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APENASPLPAGMAX
        /// Coment�rio: 
        /// </summary>
        private string apenasplpagmax;
        [XmlElement(ElementName = "APENASPLPAGMAX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Apenasplpagmax
        {
            get { return  apenasplpagmax; }
            set {  apenasplpagmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASJORIGEMPED
        /// Coment�rio: 
        /// </summary>
        private string asjorigemped;
        [XmlElement(ElementName = "ASJORIGEMPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Asjorigemped
        {
            get { return  asjorigemped; }
            set {  asjorigemped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATIV
        /// Coment�rio: Indica o c�digo de atividade.
        /// </summary>
        private decimal codativ;
        [XmlElement(ElementName = "CODATIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codativ
        {
            get { return  codativ; }
            set {  codativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: Indica o c�digo auxiliar da embalagem.
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNCEXCLUSAO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncexclusao;
        [XmlElement(ElementName = "CODFUNCEXCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncexclusao
        {
            get { return  codfuncexclusao; }
            set {  codfuncexclusao = value; }
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
        /// Propriedade referente ao campo: CODPLPAGMAX
        /// Coment�rio: 
        /// </summary>
        private decimal codplpagmax;
        [XmlElement(ElementName = "CODPLPAGMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpagmax
        {
            get { return  codplpagmax; }
            set {  codplpagmax = value; }
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
        /// Propriedade referente ao campo: CODPRECOPROM
        /// Coment�rio: 
        /// </summary>
        private decimal codprecoprom;
        [XmlElement(ElementName = "CODPRECOPROM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codprecoprom
        {
            get { return  codprecoprom; }
            set {  codprecoprom = value; }
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
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Coment�rio: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CONSIDERACALCGIRO
        /// Coment�rio: 
        /// </summary>
        private string consideracalcgiro;
        [XmlElement(ElementName = "CONSIDERACALCGIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideracalcgiro
        {
            get { return  consideracalcgiro; }
            set {  consideracalcgiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERACALCGIROMEDIC
        /// Coment�rio: Considera no C�lculo do Giro (Medicamentos)
        /// </summary>
        private string consideracalcgiromedic;
        [XmlElement(ElementName = "CONSIDERACALCGIROMEDIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideracalcgiromedic
        {
            get { return  consideracalcgiromedic; }
            set {  consideracalcgiromedic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DGBPRECOFIXOBASE
        /// Coment�rio: 
        /// </summary>
        private decimal dgbprecofixobase;
        [XmlElement(ElementName = "DGBPRECOFIXOBASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Dgbprecofixobase
        {
            get { return  dgbprecofixobase; }
            set {  dgbprecofixobase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMVIGENCIA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfimvigencia;
        [XmlElement(ElementName = "DTFIMVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimvigencia
        {
            get { return  dtfimvigencia; }
            set {  dtfimvigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOVIGENCIA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtiniciovigencia;
        [XmlElement(ElementName = "DTINICIOVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciovigencia
        {
            get { return  dtiniciovigencia; }
            set {  dtiniciovigencia = value; }
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
        /// Propriedade referente ao campo: FRENTECX
        /// Coment�rio: 
        /// </summary>
        private string frentecx;
        [XmlElement(ElementName = "FRENTECX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Frentecx
        {
            get { return  frentecx; }
            set {  frentecx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MELCOTAMAX
        /// Coment�rio: 
        /// </summary>
        private decimal melcotamax;
        [XmlElement(ElementName = "MELCOTAMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Melcotamax
        {
            get { return  melcotamax; }
            set {  melcotamax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MELPERCRESCQTPREV
        /// Coment�rio: 
        /// </summary>
        private decimal melpercrescqtprev;
        [XmlElement(ElementName = "MELPERCRESCQTPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Melpercrescqtprev
        {
            get { return  melpercrescqtprev; }
            set {  melpercrescqtprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MELPERCRESCVALORPREV
        /// Coment�rio: 
        /// </summary>
        private decimal melpercrescvalorprev;
        [XmlElement(ElementName = "MELPERCRESCVALORPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Melpercrescvalorprev
        {
            get { return  melpercrescvalorprev; }
            set {  melpercrescvalorprev = value; }
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
        /// Propriedade referente ao campo: NUMREGIAO
        /// Coment�rio: 
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMPED
        /// Coment�rio: Indica a origem do pedido.
        /// </summary>
        private string origemped;
        [XmlElement(ElementName = "ORIGEMPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemped
        {
            get { return  origemped; }
            set {  origemped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOFIXO
        /// Coment�rio: 
        /// </summary>
        private decimal precofixo;
        [XmlElement(ElementName = "PRECOFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precofixo
        {
            get { return  precofixo; }
            set {  precofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPRECOFIXOFAMILIA
        /// Coment�rio: 
        /// </summary>
        private string utilizaprecofixofamilia;
        [XmlElement(ElementName = "UTILIZAPRECOFIXOFAMILIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaprecofixofamilia
        {
            get { return  utilizaprecofixofamilia; }
            set {  utilizaprecofixofamilia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPRECOFIXOREDE
        /// Coment�rio: 
        /// </summary>
        private string utilizaprecofixorede;
        [XmlElement(ElementName = "UTILIZAPRECOFIXOREDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaprecofixorede
        {
            get { return  utilizaprecofixorede; }
            set {  utilizaprecofixorede = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPrecopromlog()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRECOPROMLOG";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPrecopromlog> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrecopromlog>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPrecopromlog> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrecopromlog>(where);
        }

        #endregion
    }
}

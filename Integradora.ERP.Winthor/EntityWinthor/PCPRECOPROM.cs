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
    /// Classe referente a tabela PCPrecoprom
    /// </summary>
    [XmlType("PCPRECOPROM")]
    public class PCPrecoprom : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITAACRESCIMOPRECOFIXO
        /// Coment�rio: Aceita Acrescimo pre�o fixo
        /// </summary>
        private string aceitaacrescimoprecofixo;
        [XmlElement(ElementName = "ACEITAACRESCIMOPRECOFIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitaacrescimoprecofixo
        {
            get { return  aceitaacrescimoprecofixo; }
            set {  aceitaacrescimoprecofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITADESCPRECOFIXO
        /// Coment�rio: Aceita Desconto pre�o fixo
        /// </summary>
        private string aceitadescprecofixo;
        [XmlElement(ElementName = "ACEITADESCPRECOFIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitadescprecofixo
        {
            get { return  aceitadescprecofixo; }
            set {  aceitadescprecofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AGREGARST
        /// Coment�rio: Informa se  o valor de ST gerado no campo VLST est� agregado ao pre�o fixo do produto
        /// </summary>
        private string agregarst;
        [XmlElement(ElementName = "AGREGARST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agregarst
        {
            get { return  agregarst; }
            set {  agregarst = value; }
        }

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
        /// Propriedade referente ao campo: APLICADESCONTOSIMPLES
        /// Coment�rio: Aplica desconto do simples nacional no momento da venda.
        /// </summary>
        private string aplicadescontosimples;
        [XmlElement(ElementName = "APLICADESCONTOSIMPLES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicadescontosimples
        {
            get { return  aplicadescontosimples; }
            set {  aplicadescontosimples = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEVENDA
        /// Coment�rio: Classe de venda
        /// </summary>
        private string classevenda;
        [XmlElement(ElementName = "CLASSEVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classevenda
        {
            get { return  classevenda; }
            set {  classevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATIV
        /// Coment�rio: Indica o c�digo do ramo de atividade.
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
        /// Propriedade referente ao campo: CODCONDICAOVENDA
        /// Coment�rio: Condi��o de venda
        /// </summary>
        private decimal codcondicaovenda;
        [XmlElement(ElementName = "CODCONDICAOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcondicaovenda
        {
            get { return  codcondicaovenda; }
            set {  codcondicaovenda = value; }
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
        [XmlElement(ElementName = "CODPRECOPROM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
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
        /// Propriedade referente ao campo: CODREDE
        /// Coment�rio: C�digo da rede.
        /// </summary>
        private decimal codrede;
        [XmlElement(ElementName = "CODREDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrede
        {
            get { return  codrede; }
            set {  codrede = value; }
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
        /// Coment�rio: Considera politica no calculo do giro (medicamentos)
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
        /// Coment�rio: Data da �ltima altera��o. 
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
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: Indica o n�mero do lote. 
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
        /// Propriedade referente ao campo: TIPOFV
        /// Coment�rio: Tipo for�a de vendas
        /// </summary>
        private string tipofv;
        [XmlElement(ElementName = "TIPOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipofv
        {
            get { return  tipofv; }
            set {  tipofv = value; }
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

        /// <summary>
        /// Propriedade referente ao campo: VLST
        /// Coment�rio: Valor de ST que agregado ao pre�o fixo
        /// </summary>
        private decimal vlst;
        [XmlElement(ElementName = "VLST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlst
        {
            get { return  vlst; }
            set {  vlst = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPrecoprom()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRECOPROM";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPrecoprom> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrecoprom>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPrecoprom> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrecoprom>(where);
        }

        #endregion
    }
}

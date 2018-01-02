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
    /// Classe referente a tabela PCMovpreent
    /// </summary>
    [XmlType("PCMOVPREENT")]
    public class PCMovpreent : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQAVULSADARE
        /// Comentário: Aliquota avulsa de DARE.
        /// </summary>
        private decimal aliqavulsadare;
        [XmlElement(ElementName = "ALIQAVULSADARE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Aliqavulsadare
        {
            get { return  aliqavulsadare; }
            set {  aliqavulsadare = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMFRETEENT
        /// Comentário: 
        /// </summary>
        private decimal aliqicmfreteent;
        [XmlElement(ElementName = "ALIQICMFRETEENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmfreteent
        {
            get { return  aliqicmfreteent; }
            set {  aliqicmfreteent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMOUTRASDESPENT
        /// Comentário: 
        /// </summary>
        private decimal aliqicmoutrasdespent;
        [XmlElement(ElementName = "ALIQICMOUTRASDESPENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmoutrasdespent
        {
            get { return  aliqicmoutrasdespent; }
            set {  aliqicmoutrasdespent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMSVIGENTE
        /// Comentário: Aliq. ICMS vigente para o produto na UF.
        /// </summary>
        private decimal aliqicmsvigente;
        [XmlElement(ElementName = "ALIQICMSVIGENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Aliqicmsvigente
        {
            get { return  aliqicmsvigente; }
            set {  aliqicmsvigente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1
        /// Comentário: 
        /// </summary>
        private decimal aliqicms1;
        [XmlElement(ElementName = "ALIQICMS1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Aliqicms1
        {
            get { return  aliqicms1; }
            set {  aliqicms1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2
        /// Comentário: 
        /// </summary>
        private decimal aliqicms2;
        [XmlElement(ElementName = "ALIQICMS2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Aliqicms2
        {
            get { return  aliqicms2; }
            set {  aliqicms2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICST
        /// Comentário: 
        /// </summary>
        private decimal aliqicst;
        [XmlElement(ElementName = "ALIQICST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicst
        {
            get { return  aliqicst; }
            set {  aliqicst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQSTSAIDA
        /// Comentário: 
        /// </summary>
        private decimal aliqstsaida;
        [XmlElement(ElementName = "ALIQSTSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqstsaida
        {
            get { return  aliqstsaida; }
            set {  aliqstsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQUOTATIS
        /// Comentário: 
        /// </summary>
        private decimal aliquotatis;
        [XmlElement(ElementName = "ALIQUOTATIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Aliquotatis
        {
            get { return  aliquotatis; }
            set {  aliquotatis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANDPERDESCMAX
        /// Comentário: 
        /// </summary>
        private decimal andperdescmax;
        [XmlElement(ElementName = "ANDPERDESCMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Andperdescmax
        {
            get { return  andperdescmax; }
            set {  andperdescmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICPERCIVAPAUTA
        /// Comentário: Determina se o valor de IVA será agregado no valor da pauta.
        /// </summary>
        private string aplicpercivapauta;
        [XmlElement(ElementName = "APLICPERCIVAPAUTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicpercivapauta
        {
            get { return  aplicpercivapauta; }
            set {  aplicpercivapauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITACREDICMS
        /// Comentário: Indica se aproveita o crédito de ICMS na NF. 
        /// </summary>
        private string aproveitacredicms;
        [XmlElement(ElementName = "APROVEITACREDICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitacredicms
        {
            get { return  aproveitacredicms; }
            set {  aproveitacredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITACREDITOICMS
        /// Comentário: 
        /// </summary>
        private string aproveitacreditoicms;
        [XmlElement(ElementName = "APROVEITACREDITOICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitacreditoicms
        {
            get { return  aproveitacreditoicms; }
            set {  aproveitacreditoicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITACREDPISCOFINS
        /// Comentário: 
        /// </summary>
        private string aproveitacredpiscofins;
        [XmlElement(ElementName = "APROVEITACREDPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitacredpiscofins
        {
            get { return  aproveitacredpiscofins; }
            set {  aproveitacredpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASACLASSEVENDA
        /// Comentário: 
        /// </summary>
        private string asaclassevenda;
        [XmlElement(ElementName = "ASACLASSEVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Asaclassevenda
        {
            get { return  asaclassevenda; }
            set {  asaclassevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASACODDIVISAO
        /// Comentário: 
        /// </summary>
        private decimal asacoddivisao;
        [XmlElement(ElementName = "ASACODDIVISAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Asacoddivisao
        {
            get { return  asacoddivisao; }
            set {  asacoddivisao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATFQTSEP1
        /// Comentário: 
        /// </summary>
        private decimal atfqtsep1;
        [XmlElement(ElementName = "ATFQTSEP1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Atfqtsep1
        {
            get { return  atfqtsep1; }
            set {  atfqtsep1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATFQTSEP2
        /// Comentário: 
        /// </summary>
        private decimal atfqtsep2;
        [XmlElement(ElementName = "ATFQTSEP2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Atfqtsep2
        {
            get { return  atfqtsep2; }
            set {  atfqtsep2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEACRESCIMOPF
        /// Comentário: 
        /// </summary>
        private decimal baseacrescimopf;
        [XmlElement(ElementName = "BASEACRESCIMOPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseacrescimopf
        {
            get { return  baseacrescimopf; }
            set {  baseacrescimopf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEBCR
        /// Comentário: 
        /// </summary>
        private decimal basebcr;
        [XmlElement(ElementName = "BASEBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basebcr
        {
            get { return  basebcr; }
            set {  basebcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEDIFALIQUOTAS
        /// Comentário: Base da diferença entre alíquotas.
        /// </summary>
        private decimal basedifaliquotas;
        [XmlElement(ElementName = "BASEDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basedifaliquotas
        {
            get { return  basedifaliquotas; }
            set {  basedifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICMS
        /// Comentário: Campo para armazenar o valor da base de cálculo do ICMS informado no pedido de compra. 
        /// </summary>
        private decimal baseicms;
        [XmlElement(ElementName = "BASEICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Baseicms
        {
            get { return  baseicms; }
            set {  baseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICMSADICIONAL
        /// Comentário: Indica o valor Base de ICMS Adicional.
        /// </summary>
        private decimal baseicmsadicional;
        [XmlElement(ElementName = "BASEICMSADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicmsadicional
        {
            get { return  baseicmsadicional; }
            set {  baseicmsadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICMSBCR
        /// Comentário: 
        /// </summary>
        private decimal baseicmsbcr;
        [XmlElement(ElementName = "BASEICMSBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicmsbcr
        {
            get { return  baseicmsbcr; }
            set {  baseicmsbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICMSULTENT
        /// Comentário: Base de ICMS para última entrada.
        /// </summary>
        private decimal baseicmsultent;
        [XmlElement(ElementName = "BASEICMSULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicmsultent
        {
            get { return  baseicmsultent; }
            set {  baseicmsultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICMSULTENTANT
        /// Comentário: Base de ICMS para última entrada / Anterior.
        /// </summary>
        private decimal baseicmsultentant;
        [XmlElement(ElementName = "BASEICMSULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicmsultentant
        {
            get { return  baseicmsultentant; }
            set {  baseicmsultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICMS2
        /// Comentário: 
        /// </summary>
        private decimal baseicms2;
        [XmlElement(ElementName = "BASEICMS2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicms2
        {
            get { return  baseicms2; }
            set {  baseicms2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICST
        /// Comentário: 
        /// </summary>
        private decimal baseicst;
        [XmlElement(ElementName = "BASEICST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicst
        {
            get { return  baseicst; }
            set {  baseicst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICST2
        /// Comentário: 
        /// </summary>
        private decimal baseicst2;
        [XmlElement(ElementName = "BASEICST2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicst2
        {
            get { return  baseicst2; }
            set {  baseicst2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEIVAMEX
        /// Comentário: 
        /// </summary>
        private decimal baseivamex;
        [XmlElement(ElementName = "BASEIVAMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseivamex
        {
            get { return  baseivamex; }
            set {  baseivamex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASESTSAIDA
        /// Comentário: 
        /// </summary>
        private decimal basestsaida;
        [XmlElement(ElementName = "BASESTSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basestsaida
        {
            get { return  basestsaida; }
            set {  basestsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BCISS
        /// Comentário: Indica a base de ISSQN
        /// </summary>
        private decimal bciss;
        [XmlElement(ElementName = "BCISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Bciss
        {
            get { return  bciss; }
            set {  bciss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BRINDE
        /// Comentário: 
        /// </summary>
        private string brinde;
        [XmlElement(ElementName = "BRINDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Brinde
        {
            get { return  brinde; }
            set {  brinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCBCRMANUAL
        /// Comentário: Indica o calculo do BCR manual.
        /// </summary>
        private string calcbcrmanual;
        [XmlElement(ElementName = "CALCBCRMANUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcbcrmanual
        {
            get { return  calcbcrmanual; }
            set {  calcbcrmanual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDIPI
        /// Comentário: Calcula custo com cred. IPI.
        /// </summary>
        private string calccredipi;
        [XmlElement(ElementName = "CALCCREDIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredipi
        {
            get { return  calccredipi; }
            set {  calccredipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEVENDA
        /// Comentário: 
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
        /// Propriedade referente ao campo: CLASSIFICFISCAL
        /// Comentário: Classificação fiscal do produto.
        /// </summary>
        private string classificfiscal;
        [XmlElement(ElementName = "CLASSIFICFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Classificfiscal
        {
            get { return  classificfiscal; }
            set {  classificfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Cód.Auxiliar do produto.
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCERTIFIC
        /// Comentário: 
        /// </summary>
        private decimal codcertific;
        [XmlElement(ElementName = "CODCERTIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcertific
        {
            get { return  codcertific; }
            set {  codcertific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEVOL
        /// Comentário: 
        /// </summary>
        private decimal coddevol;
        [XmlElement(ElementName = "CODDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Coddevol
        {
            get { return  coddevol; }
            set {  coddevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODECF
        /// Comentário: Cód.de tributação do ECF .
        /// </summary>
        private string codecf;
        [XmlElement(ElementName = "CODECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codecf
        {
            get { return  codecf; }
            set {  codecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Comentário: 
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEQUIPAMENTO
        /// Comentário: 
        /// </summary>
        private decimal codequipamento;
        [XmlElement(ElementName = "CODEQUIPAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codequipamento
        {
            get { return  codequipamento; }
            set {  codequipamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFAB
        /// Comentário: 
        /// </summary>
        private string codfab;
        [XmlElement(ElementName = "CODFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Codfab
        {
            get { return  codfab; }
            set {  codfab = value; }
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
        /// Propriedade referente ao campo: CODFILIALNF
        /// Comentário: 
        /// </summary>
        private string codfilialnf;
        [XmlElement(ElementName = "CODFILIALNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialnf
        {
            get { return  codfilialnf; }
            set {  codfilialnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALRETIRA
        /// Comentário: 
        /// </summary>
        private string codfilialretira;
        [XmlElement(ElementName = "CODFILIALRETIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialretira
        {
            get { return  codfilialretira; }
            set {  codfilialretira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: 
        /// </summary>
        private decimal codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALFRETEENT
        /// Comentário: 
        /// </summary>
        private decimal codfiscalfreteent;
        [XmlElement(ElementName = "CODFISCALFRETEENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalfreteent
        {
            get { return  codfiscalfreteent; }
            set {  codfiscalfreteent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALOUTRASDESPENT
        /// Comentário: 
        /// </summary>
        private decimal codfiscaloutrasdespent;
        [XmlElement(ElementName = "CODFISCALOUTRASDESPENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscaloutrasdespent
        {
            get { return  codfiscaloutrasdespent; }
            set {  codfiscaloutrasdespent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECPROD
        /// Comentário: Código do fornecedor do produto.
        /// </summary>
        private decimal codfornecprod;
        [XmlElement(ElementName = "CODFORNECPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecprod
        {
            get { return  codfornecprod; }
            set {  codfornecprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONF
        /// Comentário: Indica o código do funcionário que realizou a conferência.
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
        /// Propriedade referente ao campo: CODFUNCEMBAL
        /// Comentário: Indica o código do funcionário embalador.
        /// </summary>
        private decimal codfuncembal;
        [XmlElement(ElementName = "CODFUNCEMBAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncembal
        {
            get { return  codfuncembal; }
            set {  codfuncembal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXPORTACAOWMS
        /// Comentário: 
        /// </summary>
        private decimal codfuncexportacaowms;
        [XmlElement(ElementName = "CODFUNCEXPORTACAOWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncexportacaowms
        {
            get { return  codfuncexportacaowms; }
            set {  codfuncexportacaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCIMPORTACAOWMS
        /// Comentário: 
        /// </summary>
        private decimal codfuncimportacaowms;
        [XmlElement(ElementName = "CODFUNCIMPORTACAOWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncimportacaowms
        {
            get { return  codfuncimportacaowms; }
            set {  codfuncimportacaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Comentário: 
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCQUARENTENA
        /// Comentário: 
        /// </summary>
        private decimal codfuncquarentena;
        [XmlElement(ElementName = "CODFUNCQUARENTENA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncquarentena
        {
            get { return  codfuncquarentena; }
            set {  codfuncquarentena = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCREQ
        /// Comentário: 
        /// </summary>
        private decimal codfuncreq;
        [XmlElement(ElementName = "CODFUNCREQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncreq
        {
            get { return  codfuncreq; }
            set {  codfuncreq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGENEROFISCAL
        /// Comentário: Código genero fiscal.
        /// </summary>
        private decimal codgenerofiscal;
        [XmlElement(ElementName = "CODGENEROFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codgenerofiscal
        {
            get { return  codgenerofiscal; }
            set {  codgenerofiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMTAB
        /// Comentário: 
        /// </summary>
        private decimal codicmtab;
        [XmlElement(ElementName = "CODICMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmtab
        {
            get { return  codicmtab; }
            set {  codicmtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODPASSEFISCAL
        /// Comentário: Código do passe fiscal.
        /// </summary>
        private decimal codpassefiscal;
        [XmlElement(ElementName = "CODPASSEFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codpassefiscal
        {
            get { return  codpassefiscal; }
            set {  codpassefiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODPRODPRINC
        /// Comentário: 
        /// </summary>
        private decimal codprodprinc;
        [XmlElement(ElementName = "CODPRODPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodprinc
        {
            get { return  codprodprinc; }
            set {  codprodprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODSINTEGRA
        /// Comentário: Cód.Prod. para envio no arquivo sintegra.
        /// </summary>
        private string codprodsintegra;
        [XmlElement(ElementName = "CODPRODSINTEGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codprodsintegra
        {
            get { return  codprodsintegra; }
            set {  codprodsintegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROMOCAO
        /// Comentário: 
        /// </summary>
        private string codpromocao;
        [XmlElement(ElementName = "CODPROMOCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codpromocao
        {
            get { return  codpromocao; }
            set {  codpromocao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Comentário: 
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINS
        /// Comentário: Código sit. trip. PIS/COFINS.
        /// </summary>
        private decimal codsittribpiscofins;
        [XmlElement(ElementName = "CODSITTRIBPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribpiscofins
        {
            get { return  codsittribpiscofins; }
            set {  codsittribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODST
        /// Comentário: 
        /// </summary>
        private decimal codst;
        [XmlElement(ElementName = "CODST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codst
        {
            get { return  codst; }
            set {  codst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODUSUR2
        /// Comentário: 
        /// </summary>
        private decimal codusur2;
        [XmlElement(ElementName = "CODUSUR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur2
        {
            get { return  codusur2; }
            set {  codusur2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVASILHAME
        /// Comentário: Código do Vasilhame associado ao produto.
        /// </summary>
        private decimal codvasilhame;
        [XmlElement(ElementName = "CODVASILHAME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codvasilhame
        {
            get { return  codvasilhame; }
            set {  codvasilhame = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Comentário: 
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Complemento
        {
            get { return  complemento; }
            set {  complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRACONSIGNADO
        /// Comentário: Indica o produto adquirido em consignação
        /// </summary>
        private string compraconsignado;
        [XmlElement(ElementName = "COMPRACONSIGNADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Compraconsignado
        {
            get { return  compraconsignado; }
            set {  compraconsignado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLANUMSERIE
        /// Comentário: Controla número de série.
        /// </summary>
        private string controlanumserie;
        [XmlElement(ElementName = "CONTROLANUMSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlanumserie
        {
            get { return  controlanumserie; }
            set {  controlanumserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CORVLRINDFINANC
        /// Comentário: 
        /// </summary>
        private decimal corvlrindfinanc;
        [XmlElement(ElementName = "CORVLRINDFINANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Corvlrindfinanc
        {
            get { return  corvlrindfinanc; }
            set {  corvlrindfinanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONT
        /// Comentário: 
        /// </summary>
        private decimal custocont;
        [XmlElement(ElementName = "CUSTOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocont
        {
            get { return  custocont; }
            set {  custocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONTANT
        /// Comentário: 
        /// </summary>
        private decimal custocontant;
        [XmlElement(ElementName = "CUSTOCONTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocontant
        {
            get { return  custocontant; }
            set {  custocontant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal custofin;
        [XmlElement(ElementName = "CUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofin
        {
            get { return  custofin; }
            set {  custofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINANT
        /// Comentário: 
        /// </summary>
        private decimal custofinant;
        [XmlElement(ElementName = "CUSTOFINANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinant
        {
            get { return  custofinant; }
            set {  custofinant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINEST
        /// Comentário: 
        /// </summary>
        private decimal custofinest;
        [XmlElement(ElementName = "CUSTOFINEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinest
        {
            get { return  custofinest; }
            set {  custofinest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFORNEC
        /// Comentário: Indica o último custo do produto no fornecedor.
        /// </summary>
        private decimal custofornec;
        [XmlElement(ElementName = "CUSTOFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofornec
        {
            get { return  custofornec; }
            set {  custofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTONFSEMST
        /// Comentário: Custo da NF sem ST.
        /// </summary>
        private decimal custonfsemst;
        [XmlElement(ElementName = "CUSTONFSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custonfsemst
        {
            get { return  custonfsemst; }
            set {  custonfsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTONFSEMSTANT
        /// Comentário: Custo da NF sem ST/anterior.
        /// </summary>
        private decimal custonfsemstant;
        [XmlElement(ElementName = "CUSTONFSEMSTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custonfsemstant
        {
            get { return  custonfsemstant; }
            set {  custonfsemstant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREAL
        /// Comentário: 
        /// </summary>
        private decimal custoreal;
        [XmlElement(ElementName = "CUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoreal
        {
            get { return  custoreal; }
            set {  custoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALANT
        /// Comentário: 
        /// </summary>
        private decimal custorealant;
        [XmlElement(ElementName = "CUSTOREALANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealant
        {
            get { return  custorealant; }
            set {  custorealant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALSEMST
        /// Comentário: 
        /// </summary>
        private decimal custorealsemst;
        [XmlElement(ElementName = "CUSTOREALSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealsemst
        {
            get { return  custorealsemst; }
            set {  custorealsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALSEMSTANT
        /// Comentário: 
        /// </summary>
        private decimal custorealsemstant;
        [XmlElement(ElementName = "CUSTOREALSEMSTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealsemstant
        {
            get { return  custorealsemstant; }
            set {  custorealsemstant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREP
        /// Comentário: 
        /// </summary>
        private decimal custorep;
        [XmlElement(ElementName = "CUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorep
        {
            get { return  custorep; }
            set {  custorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREPANT
        /// Comentário: 
        /// </summary>
        private decimal custorepant;
        [XmlElement(ElementName = "CUSTOREPANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorepant
        {
            get { return  custorepant; }
            set {  custorepant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENT
        /// Comentário: 
        /// </summary>
        private decimal custoultent;
        [XmlElement(ElementName = "CUSTOULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultent
        {
            get { return  custoultent; }
            set {  custoultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTANT
        /// Comentário: 
        /// </summary>
        private decimal custoultentant;
        [XmlElement(ElementName = "CUSTOULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentant
        {
            get { return  custoultentant; }
            set {  custoultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTANT2
        /// Comentário: 
        /// </summary>
        private decimal custoultentant2;
        [XmlElement(ElementName = "CUSTOULTENTANT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentant2
        {
            get { return  custoultentant2; }
            set {  custoultentant2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTFIN
        /// Comentário: 
        /// </summary>
        private decimal custoultentfin;
        [XmlElement(ElementName = "CUSTOULTENTFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentfin
        {
            get { return  custoultentfin; }
            set {  custoultentfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTFINANT
        /// Comentário: 
        /// </summary>
        private decimal custoultentfinant;
        [XmlElement(ElementName = "CUSTOULTENTFINANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentfinant
        {
            get { return  custoultentfinant; }
            set {  custoultentfinant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTMED
        /// Comentário: 
        /// </summary>
        private decimal custoultentmed;
        [XmlElement(ElementName = "CUSTOULTENTMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentmed
        {
            get { return  custoultentmed; }
            set {  custoultentmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTMEDANT
        /// Comentário: 
        /// </summary>
        private decimal custoultentmedant;
        [XmlElement(ElementName = "CUSTOULTENTMEDANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentmedant
        {
            get { return  custoultentmedant; }
            set {  custoultentmedant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENT1
        /// Comentário: 
        /// </summary>
        private decimal custoultent1;
        [XmlElement(ElementName = "CUSTOULTENT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultent1
        {
            get { return  custoultent1; }
            set {  custoultent1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENT1ANT
        /// Comentário: 
        /// </summary>
        private decimal custoultent1ant;
        [XmlElement(ElementName = "CUSTOULTENT1ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultent1ant
        {
            get { return  custoultent1ant; }
            set {  custoultent1ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENT3
        /// Comentário: 
        /// </summary>
        private decimal custoultent3;
        [XmlElement(ElementName = "CUSTOULTENT3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultent3
        {
            get { return  custoultent3; }
            set {  custoultent3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENT3ANT
        /// Comentário: 
        /// </summary>
        private decimal custoultent3ant;
        [XmlElement(ElementName = "CUSTOULTENT3ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultent3ant
        {
            get { return  custoultent3ant; }
            set {  custoultent3ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFABRICACAO
        /// Comentário: 
        /// </summary>
        private DateTime? datafabricacao;
        [XmlElement(ElementName = "DATAFABRICACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafabricacao
        {
            get { return  datafabricacao; }
            set {  datafabricacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALIBQUARENTENA
        /// Comentário: 
        /// </summary>
        private DateTime? datalibquarentena;
        [XmlElement(ElementName = "DATALIBQUARENTENA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datalibquarentena
        {
            get { return  datalibquarentena; }
            set {  datalibquarentena = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAVALIDADE
        /// Comentário: 
        /// </summary>
        private DateTime? datavalidade;
        [XmlElement(ElementName = "DATAVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datavalidade
        {
            get { return  datavalidade; }
            set {  datavalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição do produto.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO1
        /// Comentário: Descrição secundaria do produto.
        /// </summary>
        private string descricao1;
        [XmlElement(ElementName = "DESCRICAO1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Descricao1
        {
            get { return  descricao1; }
            set {  descricao1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAPURACAO
        /// Comentário: Indica a data de apuração rebaixa CMV.
        /// </summary>
        private DateTime? dtapuracao;
        [XmlElement(ElementName = "DTAPURACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtapuracao
        {
            get { return  dtapuracao; }
            set {  dtapuracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTEXPORTACAOSERVINT
        /// Comentário: 
        /// </summary>
        private DateTime? dtexportacaoservint;
        [XmlElement(ElementName = "DTEXPORTACAOSERVINT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaoservint
        {
            get { return  dtexportacaoservint; }
            set {  dtexportacaoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAOWMS
        /// Comentário: 
        /// </summary>
        private DateTime? dtexportacaowms;
        [XmlElement(ElementName = "DTEXPORTACAOWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaowms
        {
            get { return  dtexportacaowms; }
            set {  dtexportacaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMCONF
        /// Comentário: Indica a data de fim da conferência.
        /// </summary>
        private DateTime? dtfimconf;
        [XmlElement(ElementName = "DTFIMCONF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimconf
        {
            get { return  dtfimconf; }
            set {  dtfimconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOSERVPRINC
        /// Comentário: 
        /// </summary>
        private DateTime? dtimportacaoservprinc;
        [XmlElement(ElementName = "DTIMPORTACAOSERVPRINC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaoservprinc
        {
            get { return  dtimportacaoservprinc; }
            set {  dtimportacaoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOWMS
        /// Comentário: 
        /// </summary>
        private DateTime? dtimportacaowms;
        [XmlElement(ElementName = "DTIMPORTACAOWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaowms
        {
            get { return  dtimportacaowms; }
            set {  dtimportacaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOCONF
        /// Comentário: Indica a data de inicio da conferência.
        /// </summary>
        private DateTime? dtinicioconf;
        [XmlElement(ElementName = "DTINICIOCONF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicioconf
        {
            get { return  dtinicioconf; }
            set {  dtinicioconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTMOV
        /// Comentário: 
        /// </summary>
        private DateTime? dtmov;
        [XmlElement(ElementName = "DTMOV", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtmov
        {
            get { return  dtmov; }
            set {  dtmov = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTMOVLOG
        /// Comentário: 
        /// </summary>
        private DateTime? dtmovlog;
        [XmlElement(ElementName = "DTMOVLOG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtmovlog
        {
            get { return  dtmovlog; }
            set {  dtmovlog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTENTANT
        /// Comentário: 
        /// </summary>
        private DateTime? dtultentant;
        [XmlElement(ElementName = "DTULTENTANT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultentant
        {
            get { return  dtultentant; }
            set {  dtultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTWMS
        /// Comentário: Data de gravação do WMS.
        /// </summary>
        private DateTime? dtwms;
        [XmlElement(ElementName = "DTWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtwms
        {
            get { return  dtwms; }
            set {  dtwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DV
        /// Comentário: Digito verificador do produto.
        /// </summary>
        private decimal dv;
        [XmlElement(ElementName = "DV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dv
        {
            get { return  dv; }
            set {  dv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEM
        /// Comentário: Embalagem do produto.
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
        /// Propriedade referente ao campo: EMITIDO
        /// Comentário: Marcar se o bonus foi emitido ou não
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
        /// Propriedade referente ao campo: EQUIPLANC
        /// Comentário: 
        /// </summary>
        private string equiplanc;
        [XmlElement(ElementName = "EQUIPLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,64)]
        public string Equiplanc
        {
            get { return  equiplanc; }
            set {  equiplanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUEDESBLOQUEADO
        /// Comentário: 
        /// </summary>
        private string estoquedesbloqueado;
        [XmlElement(ElementName = "ESTOQUEDESBLOQUEADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Estoquedesbloqueado
        {
            get { return  estoquedesbloqueado; }
            set {  estoquedesbloqueado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADOSERVINT
        /// Comentário: 
        /// </summary>
        private string exportadoservint;
        [XmlElement(ElementName = "EXPORTADOSERVINT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportadoservint
        {
            get { return  exportadoservint; }
            set {  exportadoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATOR
        /// Comentário: 
        /// </summary>
        private decimal fator;
        [XmlElement(ElementName = "FATOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Fator
        {
            get { return  fator; }
            set {  fator = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORCUSTONATRANSF
        /// Comentário: 
        /// </summary>
        private decimal fatorcustonatransf;
        [XmlElement(ElementName = "FATORCUSTONATRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Fatorcustonatransf
        {
            get { return  fatorcustonatransf; }
            set {  fatorcustonatransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIDPONTOSFIDELIDADE
        /// Comentário: 
        /// </summary>
        private decimal fidpontosfidelidade;
        [XmlElement(ElementName = "FIDPONTOSFIDELIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Fidpontosfidelidade
        {
            get { return  fidpontosfidelidade; }
            set {  fidpontosfidelidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FUNCLANC
        /// Comentário: 
        /// </summary>
        private string funclanc;
        [XmlElement(ElementName = "FUNCLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Funclanc
        {
            get { return  funclanc; }
            set {  funclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAGNRE_CNPJCLIENTE
        /// Comentário: Campo para definir se a GNRE será paga pelo cliente.
        /// </summary>
        private string geragnre_cnpjcliente;
        [XmlElement(ElementName = "GERAGNRE_CNPJCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geragnre_Cnpjcliente
        {
            get { return  geragnre_cnpjcliente; }
            set {  geragnre_cnpjcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAICMSLIVROFISCAL
        /// Comentário: Gera ICMS livro fiscal
        /// </summary>
        private string geraicmslivrofiscal;
        [XmlElement(ElementName = "GERAICMSLIVROFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraicmslivrofiscal
        {
            get { return  geraicmslivrofiscal; }
            set {  geraicmslivrofiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: Gerou histórico para o registro, sim ou não.
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORALANC
        /// Comentário: 
        /// </summary>
        private string horalanc;
        [XmlElement(ElementName = "HORALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Horalanc
        {
            get { return  horalanc; }
            set {  horalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAPRODUCAO
        /// Comentário: 
        /// </summary>
        private DateTime? horaproducao;
        [XmlElement(ElementName = "HORAPRODUCAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Horaproducao
        {
            get { return  horaproducao; }
            set {  horaproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ICMSRESSARC
        /// Comentário: Aliq. ICMS para ressarcimento.
        /// </summary>
        private decimal icmsressarc;
        [XmlElement(ElementName = "ICMSRESSARC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Icmsressarc
        {
            get { return  icmsressarc; }
            set {  icmsressarc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Comentário: Indica se o produto é Importado.
        /// </summary>
        private string importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADOSERVPRINC
        /// Comentário: 
        /// </summary>
        private string importadoservprinc;
        [XmlElement(ElementName = "IMPORTADOSERVPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importadoservprinc
        {
            get { return  importadoservprinc; }
            set {  importadoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDLOCAL
        /// Comentário: 
        /// </summary>
        private string indlocal;
        [XmlElement(ElementName = "INDLOCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indlocal
        {
            get { return  indlocal; }
            set {  indlocal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITEMDIVERGENTE
        /// Comentário: 
        /// </summary>
        private string itemdivergente;
        [XmlElement(ElementName = "ITEMDIVERGENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Itemdivergente
        {
            get { return  itemdivergente; }
            set {  itemdivergente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITLNUMDOC
        /// Comentário: 
        /// </summary>
        private decimal itlnumdoc;
        [XmlElement(ElementName = "ITLNUMDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Itlnumdoc
        {
            get { return  itlnumdoc; }
            set {  itlnumdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVA
        /// Comentário: 
        /// </summary>
        private decimal iva;
        [XmlElement(ElementName = "IVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Iva
        {
            get { return  iva; }
            set {  iva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVARESSARC
        /// Comentário: IVA para ressarcimento.
        /// </summary>
        private decimal ivaressarc;
        [XmlElement(ElementName = "IVARESSARC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Ivaressarc
        {
            get { return  ivaressarc; }
            set {  ivaressarc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVATRIBUT
        /// Comentário: IVA da tributação do produto.
        /// </summary>
        private decimal ivatribut;
        [XmlElement(ElementName = "IVATRIBUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Ivatribut
        {
            get { return  ivatribut; }
            set {  ivatribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LBLPERCOMPROF
        /// Comentário: 
        /// </summary>
        private decimal lblpercomprof;
        [XmlElement(ElementName = "LBLPERCOMPROF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Lblpercomprof
        {
            get { return  lblpercomprof; }
            set {  lblpercomprof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LITPERCOMGER
        /// Comentário: 
        /// </summary>
        private decimal litpercomger;
        [XmlElement(ElementName = "LITPERCOMGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Litpercomger
        {
            get { return  litpercomger; }
            set {  litpercomger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LITPERCOMSUP
        /// Comentário: 
        /// </summary>
        private decimal litpercomsup;
        [XmlElement(ElementName = "LITPERCOMSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Litpercomsup
        {
            get { return  litpercomsup; }
            set {  litpercomsup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LLLBASEICMSNF
        /// Comentário: 
        /// </summary>
        private decimal lllbaseicmsnf;
        [XmlElement(ElementName = "LLLBASEICMSNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Lllbaseicmsnf
        {
            get { return  lllbaseicmsnf; }
            set {  lllbaseicmsnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LLLPERCICMNF
        /// Comentário: 
        /// </summary>
        private decimal lllpercicmnf;
        [XmlElement(ElementName = "LLLPERCICMNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Lllpercicmnf
        {
            get { return  lllpercicmnf; }
            set {  lllpercicmnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALIZACAO
        /// Comentário: 
        /// </summary>
        private string localizacao;
        [XmlElement(ElementName = "LOCALIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Localizacao
        {
            get { return  localizacao; }
            set {  localizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOLANC
        /// Comentário: 
        /// </summary>
        private string minutolanc;
        [XmlElement(ElementName = "MINUTOLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Minutolanc
        {
            get { return  minutolanc; }
            set {  minutolanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NBM
        /// Comentário: NCM do produto.
        /// </summary>
        private string nbm;
        [XmlElement(ElementName = "NBM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nbm
        {
            get { return  nbm; }
            set {  nbm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMADICAO
        /// Comentário: Indica o número de adição em que está ligados os produtos.
        /// </summary>
        private decimal numadicao;
        [XmlElement(ElementName = "NUMADICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numadicao
        {
            get { return  numadicao; }
            set {  numadicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONO
        /// Comentário: 
        /// </summary>
        private decimal numbono;
        [XmlElement(ElementName = "NUMBONO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numbono
        {
            get { return  numbono; }
            set {  numbono = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMCARANTERIOR
        /// Comentário: Indica o numero do carregamento anterior.
        /// </summary>
        private decimal numcaranterior;
        [XmlElement(ElementName = "NUMCARANTERIOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcaranterior
        {
            get { return  numcaranterior; }
            set {  numcaranterior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFORMULARIO
        /// Comentário: 
        /// </summary>
        private decimal numformulario;
        [XmlElement(ElementName = "NUMFORMULARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numformulario
        {
            get { return  numformulario; }
            set {  numformulario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFORMULARIO2
        /// Comentário: 
        /// </summary>
        private decimal numformulario2;
        [XmlElement(ElementName = "NUMFORMULARIO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numformulario2
        {
            get { return  numformulario2; }
            set {  numformulario2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMIDF
        /// Comentário: 
        /// </summary>
        private string numidf;
        [XmlElement(ElementName = "NUMIDF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numidf
        {
            get { return  numidf; }
            set {  numidf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANCCP
        /// Comentário: 
        /// </summary>
        private decimal numlanccp;
        [XmlElement(ElementName = "NUMLANCCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numlanccp
        {
            get { return  numlanccp; }
            set {  numlanccp = value; }
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
        /// Propriedade referente ao campo: NUMLOTEFAB
        /// Comentário: Indica o número de frabricação do lote.
        /// </summary>
        private string numlotefab;
        [XmlElement(ElementName = "NUMLOTEFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numlotefab
        {
            get { return  numlotefab; }
            set {  numlotefab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNEGOCIACAO
        /// Comentário: 
        /// </summary>
        private decimal numnegociacao;
        [XmlElement(ElementName = "NUMNEGOCIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numnegociacao
        {
            get { return  numnegociacao; }
            set {  numnegociacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTADEV
        /// Comentário: 
        /// </summary>
        private decimal numnotadev;
        [XmlElement(ElementName = "NUMNOTADEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotadev
        {
            get { return  numnotadev; }
            set {  numnotadev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTATRANSFENT
        /// Comentário: 
        /// </summary>
        private decimal numnotatransfent;
        [XmlElement(ElementName = "NUMNOTATRANSFENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotatransfent
        {
            get { return  numnotatransfent; }
            set {  numnotatransfent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAVENDA
        /// Comentário: 
        /// </summary>
        private decimal numnotavenda;
        [XmlElement(ElementName = "NUMNOTAVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotavenda
        {
            get { return  numnotavenda; }
            set {  numnotavenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOP
        /// Comentário: 
        /// </summary>
        private decimal numop;
        [XmlElement(ElementName = "NUMOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numop
        {
            get { return  numop; }
            set {  numop = value; }
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
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMSEQADICAO
        /// Comentário: Indica o número sequencial de controle de adição.
        /// </summary>
        private decimal numseqadicao;
        [XmlElement(ElementName = "NUMSEQADICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numseqadicao
        {
            get { return  numseqadicao; }
            set {  numseqadicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQPED
        /// Comentário: 
        /// </summary>
        private decimal numseqped;
        [XmlElement(ElementName = "NUMSEQPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseqped
        {
            get { return  numseqped; }
            set {  numseqped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSAVULSA
        /// Comentário: 
        /// </summary>
        private decimal numtransavulsa;
        [XmlElement(ElementName = "NUMTRANSAVULSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransavulsa
        {
            get { return  numtransavulsa; }
            set {  numtransavulsa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSDEV
        /// Comentário: 
        /// </summary>
        private decimal numtransdev;
        [XmlElement(ElementName = "NUMTRANSDEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransdev
        {
            get { return  numtransdev; }
            set {  numtransdev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSDEVFOR
        /// Comentário: 
        /// </summary>
        private decimal numtransdevfor;
        [XmlElement(ElementName = "NUMTRANSDEVFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransdevfor
        {
            get { return  numtransdevfor; }
            set {  numtransdevfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: 
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTULTENT
        /// Comentário: 
        /// </summary>
        private decimal numtransentultent;
        [XmlElement(ElementName = "NUMTRANSENTULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Numtransentultent
        {
            get { return  numtransentultent; }
            set {  numtransentultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTULTENTANT
        /// Comentário: 
        /// </summary>
        private decimal numtransentultentant;
        [XmlElement(ElementName = "NUMTRANSENTULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentultentant
        {
            get { return  numtransentultentant; }
            set {  numtransentultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSITEM
        /// Comentário: Número do item relacionado a tabela PCMOVPREENTCOMPLE.
        /// </summary>
        private decimal numtransitem;
        [XmlElement(ElementName = "NUMTRANSITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Numtransitem
        {
            get { return  numtransitem; }
            set {  numtransitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSOP
        /// Comentário: 
        /// </summary>
        private decimal numtransop;
        [XmlElement(ElementName = "NUMTRANSOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransop
        {
            get { return  numtransop; }
            set {  numtransop = value; }
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
        /// Propriedade referente ao campo: NUMVERBAOUTRAS
        /// Comentário: 
        /// </summary>
        private decimal numverbaoutras;
        [XmlElement(ElementName = "NUMVERBAOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numverbaoutras
        {
            get { return  numverbaoutras; }
            set {  numverbaoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERBAREBCMV
        /// Comentário: 
        /// </summary>
        private decimal numverbarebcmv;
        [XmlElement(ElementName = "NUMVERBAREBCMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numverbarebcmv
        {
            get { return  numverbarebcmv; }
            set {  numverbarebcmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOLUMESCONFERENCIA
        /// Comentário: Indica o número de volumes na conferência.
        /// </summary>
        private decimal numvolumesconferencia;
        [XmlElement(ElementName = "NUMVOLUMESCONFERENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvolumesconferencia
        {
            get { return  numvolumesconferencia; }
            set {  numvolumesconferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OTHPERCREDDEV
        /// Comentário: 
        /// </summary>
        private decimal othpercreddev;
        [XmlElement(ElementName = "OTHPERCREDDEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Othpercreddev
        {
            get { return  othpercreddev; }
            set {  othpercreddev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OTHPERDESCORIGEM
        /// Comentário: 
        /// </summary>
        private decimal othperdescorigem;
        [XmlElement(ElementName = "OTHPERDESCORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Othperdescorigem
        {
            get { return  othperdescorigem; }
            set {  othperdescorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OTHPVENDA
        /// Comentário: 
        /// </summary>
        private decimal othpvenda;
        [XmlElement(ElementName = "OTHPVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Othpvenda
        {
            get { return  othpvenda; }
            set {  othpvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OTHPVENDAORIGEM
        /// Comentário: 
        /// </summary>
        private decimal othpvendaorigem;
        [XmlElement(ElementName = "OTHPVENDAORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Othpvendaorigem
        {
            get { return  othpvendaorigem; }
            set {  othpvendaorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PASSELIVRE
        /// Comentário: Passe Livre.
        /// </summary>
        private string passelivre;
        [XmlElement(ElementName = "PASSELIVRE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Passelivre
        {
            get { return  passelivre; }
            set {  passelivre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAUTA
        /// Comentário: 
        /// </summary>
        private decimal pauta;
        [XmlElement(ElementName = "PAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pauta
        {
            get { return  pauta; }
            set {  pauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PBASERCA
        /// Comentário: 
        /// </summary>
        private decimal pbaserca;
        [XmlElement(ElementName = "PBASERCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pbaserca
        {
            get { return  pbaserca; }
            set {  pbaserca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal pbonific;
        [XmlElement(ElementName = "PBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pbonific
        {
            get { return  pbonific; }
            set {  pbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMPRAPEDIDO
        /// Comentário: Campo para armazenar o preço do produto informado no pedido de compra . 
        /// </summary>
        private decimal pcomprapedido;
        [XmlElement(ElementName = "PCOMPRAPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Pcomprapedido
        {
            get { return  pcomprapedido; }
            set {  pcomprapedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERACRESCIMOCUSTO
        /// Comentário: Indica o precentual de acrescimo para o produto informática.
        /// </summary>
        private decimal peracrescimocusto;
        [XmlElement(ElementName = "PERACRESCIMOCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Peracrescimocusto
        {
            get { return  peracrescimocusto; }
            set {  peracrescimocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERACRESCIMOPF
        /// Comentário: 
        /// </summary>
        private decimal peracrescimopf;
        [XmlElement(ElementName = "PERACRESCIMOPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Peracrescimopf
        {
            get { return  peracrescimopf; }
            set {  peracrescimopf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal perbonific;
        [XmlElement(ElementName = "PERBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perbonific
        {
            get { return  perbonific; }
            set {  perbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAGREGADORST
        /// Comentário: 
        /// </summary>
        private decimal percagregadorst;
        [XmlElement(ElementName = "PERCAGREGADORST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percagregadorst
        {
            get { return  percagregadorst; }
            set {  percagregadorst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXTGUIA
        /// Comentário: Percentual da alíquota externa para calculo do ST Guia.
        /// </summary>
        private decimal percaliqextguia;
        [XmlElement(ElementName = "PERCALIQEXTGUIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqextguia
        {
            get { return  percaliqextguia; }
            set {  percaliqextguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXTICMANTECIP
        /// Comentário: Aliquota externa para ICMS antecipado.
        /// </summary>
        private decimal percaliqexticmantecip;
        [XmlElement(ElementName = "PERCALIQEXTICMANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqexticmantecip
        {
            get { return  percaliqexticmantecip; }
            set {  percaliqexticmantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXT2
        /// Comentário: 
        /// </summary>
        private decimal percaliqext2;
        [XmlElement(ElementName = "PERCALIQEXT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqext2
        {
            get { return  percaliqext2; }
            set {  percaliqext2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQINTICMANTECIP
        /// Comentário: Aliquota interna para ICMS antecipado.
        /// </summary>
        private decimal percaliqinticmantecip;
        [XmlElement(ElementName = "PERCALIQINTICMANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqinticmantecip
        {
            get { return  percaliqinticmantecip; }
            set {  percaliqinticmantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQINT2
        /// Comentário: 
        /// </summary>
        private decimal percaliqint2;
        [XmlElement(ElementName = "PERCALIQINT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqint2
        {
            get { return  percaliqint2; }
            set {  percaliqint2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASERED
        /// Comentário: 
        /// </summary>
        private decimal percbasered;
        [XmlElement(ElementName = "PERCBASERED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbasered
        {
            get { return  percbasered; }
            set {  percbasered = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDADICIONAL
        /// Comentário: Indica o valor de Redução de Base de ICMS Adicional.
        /// </summary>
        private decimal percbaseredadicional;
        [XmlElement(ElementName = "PERCBASEREDADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbaseredadicional
        {
            get { return  percbaseredadicional; }
            set {  percbaseredadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDST
        /// Comentário: 
        /// </summary>
        private decimal percbaseredst;
        [XmlElement(ElementName = "PERCBASEREDST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredst
        {
            get { return  percbaseredst; }
            set {  percbaseredst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDSTFONTE
        /// Comentário: 
        /// </summary>
        private decimal percbaseredstfonte;
        [XmlElement(ElementName = "PERCBASEREDSTFONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredstfonte
        {
            get { return  percbaseredstfonte; }
            set {  percbaseredstfonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBON
        /// Comentário: Campo para armazenar o percentual de bonificação (em mercadoria) informado no pedido de compra. 
        /// </summary>
        private decimal percbon;
        [XmlElement(ElementName = "PERCBON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Percbon
        {
            get { return  percbon; }
            set {  percbon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONOUTRAS
        /// Comentário: 
        /// </summary>
        private decimal percbonoutras;
        [XmlElement(ElementName = "PERCBONOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percbonoutras
        {
            get { return  percbonoutras; }
            set {  percbonoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCREDICMPRESUMIDO
        /// Comentário: Campo para armazenar o percentual de Crédito presumido informado no pedido de compra. 
        /// </summary>
        private decimal perccredicmpresumido;
        [XmlElement(ElementName = "PERCCREDICMPRESUMIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perccredicmpresumido
        {
            get { return  perccredicmpresumido; }
            set {  perccredicmpresumido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Comentário: 
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCCOFINS
        /// Comentário: Indica o % de desconto COFINS aplicado na venda.
        /// </summary>
        private decimal percdesccofins;
        [XmlElement(ElementName = "PERCDESCCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesccofins
        {
            get { return  percdesccofins; }
            set {  percdesccofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCCONTRATO
        /// Comentário: 
        /// </summary>
        private decimal percdesccontrato;
        [XmlElement(ElementName = "PERCDESCCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesccontrato
        {
            get { return  percdesccontrato; }
            set {  percdesccontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFIN
        /// Comentário: 
        /// </summary>
        private decimal percdescfin;
        [XmlElement(ElementName = "PERCDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescfin
        {
            get { return  percdescfin; }
            set {  percdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFINREAL
        /// Comentário: 
        /// </summary>
        private decimal percdescfinreal;
        [XmlElement(ElementName = "PERCDESCFINREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescfinreal
        {
            get { return  percdescfinreal; }
            set {  percdescfinreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCICMSDIF
        /// Comentário: Percentual do desconto de ICMS Difererido.
        /// </summary>
        private decimal percdescicmsdif;
        [XmlElement(ElementName = "PERCDESCICMSDIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdescicmsdif
        {
            get { return  percdescicmsdif; }
            set {  percdescicmsdif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCLOGISTICO
        /// Comentário: 
        /// </summary>
        private decimal percdesclogistico;
        [XmlElement(ElementName = "PERCDESCLOGISTICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesclogistico
        {
            get { return  percdesclogistico; }
            set {  percdesclogistico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCPIS
        /// Comentário:  Indica o % de desconto PIS aplicado na venda.
        /// </summary>
        private decimal percdescpis;
        [XmlElement(ElementName = "PERCDESCPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescpis
        {
            get { return  percdescpis; }
            set {  percdescpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPADICIONAL
        /// Comentário: Campo para armazenar o percentual de ST fora da nota informado no pedido de compra. 
        /// </summary>
        private decimal percdespadicional;
        [XmlElement(ElementName = "PERCDESPADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Percdespadicional
        {
            get { return  percdespadicional; }
            set {  percdespadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPDENTRONF
        /// Comentário: Indica o percentual outras despesa na NF.
        /// </summary>
        private decimal percdespdentronf;
        [XmlElement(ElementName = "PERCDESPDENTRONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespdentronf
        {
            get { return  percdespdentronf; }
            set {  percdespdentronf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPFIN
        /// Comentário: Campo para armazenar o percentual de despesa financeira informado no pedido de compra. 
        /// </summary>
        private decimal percdespfin;
        [XmlElement(ElementName = "PERCDESPFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Percdespfin
        {
            get { return  percdespfin; }
            set {  percdespfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPFORANF
        /// Comentário: Indica o percentual de despesa fora da nota.
        /// </summary>
        private decimal percdespforanf;
        [XmlElement(ElementName = "PERCDESPFORANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespforanf
        {
            get { return  percdespforanf; }
            set {  percdespforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDIFALIQUOTAS
        /// Comentário: Percentual de diferença de tributação.
        /// </summary>
        private decimal percdifaliquotas;
        [XmlElement(ElementName = "PERCDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdifaliquotas
        {
            get { return  percdifaliquotas; }
            set {  percdifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDIREITOSADUANEIROS
        /// Comentário: Campo para armazenar o percentual dos direitos aduaneiros.
        /// </summary>
        private decimal percdireitosaduaneiros;
        [XmlElement(ElementName = "PERCDIREITOSADUANEIROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdireitosaduaneiros
        {
            get { return  percdireitosaduaneiros; }
            set {  percdireitosaduaneiros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE
        /// Comentário: 
        /// </summary>
        private decimal percfrete;
        [XmlElement(ElementName = "PERCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete
        {
            get { return  percfrete; }
            set {  percfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETEFOB
        /// Comentário: Campo para armazenar o percentual de Frete FOB (fora da nota) informado no pedido de compra. 
        /// </summary>
        private decimal percfretefob;
        [XmlElement(ElementName = "PERCFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Percfretefob
        {
            get { return  percfretefob; }
            set {  percfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETEPEDIDO
        /// Comentário: Campo para armazenar o percentual de frete informado no pedido de compra. 
        /// </summary>
        private decimal percfretepedido;
        [XmlElement(ElementName = "PERCFRETEPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Percfretepedido
        {
            get { return  percfretepedido; }
            set {  percfretepedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICM
        /// Comentário: 
        /// </summary>
        private decimal percicm;
        [XmlElement(ElementName = "PERCICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percicm
        {
            get { return  percicm; }
            set {  percicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMCP
        /// Comentário: 
        /// </summary>
        private decimal percicmcp;
        [XmlElement(ElementName = "PERCICMCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percicmcp
        {
            get { return  percicmcp; }
            set {  percicmcp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMORIGINAL
        /// Comentário: Percentual do ICMS original sem redução.
        /// </summary>
        private decimal percicmoriginal;
        [XmlElement(ElementName = "PERCICMORIGINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percicmoriginal
        {
            get { return  percicmoriginal; }
            set {  percicmoriginal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMRED
        /// Comentário: Campo para armazenar o percentual de redução do ICMS informado no pedido de compra. 
        /// </summary>
        private decimal percicmred;
        [XmlElement(ElementName = "PERCICMRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Percicmred
        {
            get { return  percicmred; }
            set {  percicmred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSDIFERIDO
        /// Comentário: Indica o percentual do ICMS diferido.
        /// </summary>
        private decimal percicmsdiferido;
        [XmlElement(ElementName = "PERCICMSDIFERIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percicmsdiferido
        {
            get { return  percicmsdiferido; }
            set {  percicmsdiferido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBST
        /// Comentário: Percentual de crédito de ICMS sobre o valor Frete FOB, utilizado no calculo do ST
        /// </summary>
        private decimal percicmsfretefobst;
        [XmlElement(ElementName = "PERCICMSFRETEFOBST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmsfretefobst
        {
            get { return  percicmsfretefobst; }
            set {  percicmsfretefobst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSPEDIDO
        /// Comentário: Campo para armazenar o percentual de ICMS informado no pedido de compra. 
        /// </summary>
        private decimal percicmspedido;
        [XmlElement(ElementName = "PERCICMSPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmspedido
        {
            get { return  percicmspedido; }
            set {  percicmspedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICM2
        /// Comentário: 
        /// </summary>
        private decimal percicm2;
        [XmlElement(ElementName = "PERCICM2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percicm2
        {
            get { return  percicm2; }
            set {  percicm2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIISUSPENSO
        /// Comentário: Percentual imposto de importação suspenso.
        /// </summary>
        private decimal perciisuspenso;
        [XmlElement(ElementName = "PERCIISUSPENSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perciisuspenso
        {
            get { return  perciisuspenso; }
            set {  perciisuspenso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPORTACAO
        /// Comentário: 
        /// </summary>
        private decimal percimportacao;
        [XmlElement(ElementName = "PERCIMPORTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percimportacao
        {
            get { return  percimportacao; }
            set {  percimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPOSTOCONSUMO
        /// Comentário: Campo para armazenar o percentual do imposto de consumo.
        /// </summary>
        private decimal percimpostoconsumo;
        [XmlElement(ElementName = "PERCIMPOSTOCONSUMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percimpostoconsumo
        {
            get { return  percimpostoconsumo; }
            set {  percimpostoconsumo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPOSTOSELO
        /// Comentário: Campo para armazenar o percentual do imposto de selo.
        /// </summary>
        private decimal percimpostoselo;
        [XmlElement(ElementName = "PERCIMPOSTOSELO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percimpostoselo
        {
            get { return  percimpostoselo; }
            set {  percimpostoselo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPPRODUTORURAL
        /// Comentário: Indica o percentual do imposto do produtor rural.
        /// </summary>
        private decimal percimpprodutorural;
        [XmlElement(ElementName = "PERCIMPPRODUTORURAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percimpprodutorural
        {
            get { return  percimpprodutorural; }
            set {  percimpprodutorural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPUREZA
        /// Comentário: 
        /// </summary>
        private decimal percimpureza;
        [XmlElement(ElementName = "PERCIMPUREZA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percimpureza
        {
            get { return  percimpureza; }
            set {  percimpureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCINSS
        /// Comentário: Indica o percentual de INSS.
        /// </summary>
        private decimal percinss;
        [XmlElement(ElementName = "PERCINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percinss
        {
            get { return  percinss; }
            set {  percinss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCINTEIRO
        /// Comentário: 
        /// </summary>
        private decimal percinteiro;
        [XmlElement(ElementName = "PERCINTEIRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percinteiro
        {
            get { return  percinteiro; }
            set {  percinteiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPI
        /// Comentário: 
        /// </summary>
        private decimal percipi;
        [XmlElement(ElementName = "PERCIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percipi
        {
            get { return  percipi; }
            set {  percipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPIPEDIDO
        /// Comentário: Campo para armazenar o percentual de IPI informado no pedido de compra. 
        /// </summary>
        private decimal percipipedido;
        [XmlElement(ElementName = "PERCIPIPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Percipipedido
        {
            get { return  percipipedido; }
            set {  percipipedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPI2
        /// Comentário: 
        /// </summary>
        private decimal percipi2;
        [XmlElement(ElementName = "PERCIPI2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percipi2
        {
            get { return  percipi2; }
            set {  percipi2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCISS
        /// Comentário: 
        /// </summary>
        private decimal perciss;
        [XmlElement(ElementName = "PERCISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perciss
        {
            get { return  perciss; }
            set {  perciss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVA
        /// Comentário: Campo para armazenar o percentual de IVA informado no pedido de compra. 
        /// </summary>
        private decimal perciva;
        [XmlElement(ElementName = "PERCIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Perciva
        {
            get { return  perciva; }
            set {  perciva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVAICMANTECIP
        /// Comentário: Aliquota de ICMS antecipado.
        /// </summary>
        private decimal percivaicmantecip;
        [XmlElement(ElementName = "PERCIVAICMANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percivaicmantecip
        {
            get { return  percivaicmantecip; }
            set {  percivaicmantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVAMEX
        /// Comentário: 
        /// </summary>
        private decimal percivamex;
        [XmlElement(ElementName = "PERCIVAMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percivamex
        {
            get { return  percivamex; }
            set {  percivamex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVA2
        /// Comentário: 
        /// </summary>
        private decimal perciva2;
        [XmlElement(ElementName = "PERCIVA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perciva2
        {
            get { return  perciva2; }
            set {  perciva2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMEXFPGC
        /// Comentário: 
        /// </summary>
        private decimal percmexfpgc;
        [XmlElement(ElementName = "PERCMEXFPGC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percmexfpgc
        {
            get { return  percmexfpgc; }
            set {  percmexfpgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMEXIEPS
        /// Comentário: 
        /// </summary>
        private decimal percmexieps;
        [XmlElement(ElementName = "PERCMEXIEPS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percmexieps
        {
            get { return  percmexieps; }
            set {  percmexieps = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMEXIVA
        /// Comentário: 
        /// </summary>
        private decimal percmexiva;
        [XmlElement(ElementName = "PERCMEXIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percmexiva
        {
            get { return  percmexiva; }
            set {  percmexiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Comentário: 
        /// </summary>
        private decimal percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Comentário: 
        /// </summary>
        private decimal percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMFILIALBROKER
        /// Comentário: Indica o percentual de comissão para filial broker.
        /// </summary>
        private decimal percomfilialbroker;
        [XmlElement(ElementName = "PERCOMFILIALBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomfilialbroker
        {
            get { return  percomfilialbroker; }
            set {  percomfilialbroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMOT
        /// Comentário: Indica o percentual de comissão para motorista.
        /// </summary>
        private decimal percommot;
        [XmlElement(ElementName = "PERCOMMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percommot
        {
            get { return  percommot; }
            set {  percommot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMSUP
        /// Comentário: 
        /// </summary>
        private decimal percomsup;
        [XmlElement(ElementName = "PERCOMSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomsup
        {
            get { return  percomsup; }
            set {  percomsup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM2
        /// Comentário: Indica a comissão do primeiro profissional.
        /// </summary>
        private decimal percom2;
        [XmlElement(ElementName = "PERCOM2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom2
        {
            get { return  percom2; }
            set {  percom2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM3
        /// Comentário: Indica a comissão do segundo profissional.
        /// </summary>
        private decimal percom3;
        [XmlElement(ElementName = "PERCOM3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom3
        {
            get { return  percom3; }
            set {  percom3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM4
        /// Comentário: Indica a comissão do terceiro profissional.
        /// </summary>
        private decimal percom4;
        [XmlElement(ElementName = "PERCOM4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom4
        {
            get { return  percom4; }
            set {  percom4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal percoutrasdesp;
        [XmlElement(ElementName = "PERCOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percoutrasdesp
        {
            get { return  percoutrasdesp; }
            set {  percoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOUTRASDESPPEDIDO
        /// Comentário: Campo para armazenar o percentual de Outras despesas (selo) informado no pedido de compra. 
        /// </summary>
        private decimal percoutrasdesppedido;
        [XmlElement(ElementName = "PERCOUTRASDESPPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Percoutrasdesppedido
        {
            get { return  percoutrasdesppedido; }
            set {  percoutrasdesppedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOUTROSCUSTOS
        /// Comentário: 
        /// </summary>
        private decimal percoutroscustos;
        [XmlElement(ElementName = "PERCOUTROSCUSTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percoutroscustos
        {
            get { return  percoutroscustos; }
            set {  percoutroscustos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCQUEBRADO
        /// Comentário: 
        /// </summary>
        private decimal percquebrado;
        [XmlElement(ElementName = "PERCQUEBRADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percquebrado
        {
            get { return  percquebrado; }
            set {  percquebrado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDICMS
        /// Comentário: Indica o percentual de crédito ICMS.
        /// </summary>
        private decimal percredicms;
        [XmlElement(ElementName = "PERCREDICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percredicms
        {
            get { return  percredicms; }
            set {  percredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSEGURO
        /// Comentário: Indica o percentual de seguro.
        /// </summary>
        private decimal percseguro;
        [XmlElement(ElementName = "PERCSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percseguro
        {
            get { return  percseguro; }
            set {  percseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCST
        /// Comentário: 
        /// </summary>
        private decimal percst;
        [XmlElement(ElementName = "PERCST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percst
        {
            get { return  percst; }
            set {  percst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSTPEDIDO
        /// Comentário: Campo para armazenar o percentual de ST informado no pedido de compra. 
        /// </summary>
        private decimal percstpedido;
        [XmlElement(ElementName = "PERCSTPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Percstpedido
        {
            get { return  percstpedido; }
            set {  percstpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSUFRAMA
        /// Comentário: 
        /// </summary>
        private decimal percsuframa;
        [XmlElement(ElementName = "PERCSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percsuframa
        {
            get { return  percsuframa; }
            set {  percsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCUMIDADE
        /// Comentário: 
        /// </summary>
        private decimal percumidade;
        [XmlElement(ElementName = "PERCUMIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percumidade
        {
            get { return  percumidade; }
            set {  percumidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVENDA
        /// Comentário: 
        /// </summary>
        private decimal percvenda;
        [XmlElement(ElementName = "PERCVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percvenda
        {
            get { return  percvenda; }
            set {  percvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVERMELHO
        /// Comentário: 
        /// </summary>
        private decimal percvermelho;
        [XmlElement(ElementName = "PERCVERMELHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percvermelho
        {
            get { return  percvermelho; }
            set {  percvermelho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVLBONIFIC
        /// Comentário: Percentual da verba em dinheiro (segue padrão da tabela PCITEM). 
        /// </summary>
        private decimal percvlbonific;
        [XmlElement(ElementName = "PERCVLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percvlbonific
        {
            get { return  percvlbonific; }
            set {  percvlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC
        /// Comentário: Campo para armazenar o percentual de desconto comercial informado no pedido de compra. 
        /// </summary>
        private decimal perdesc;
        [XmlElement(ElementName = "PERDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Perdesc
        {
            get { return  perdesc; }
            set {  perdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCCOM
        /// Comentário: 
        /// </summary>
        private decimal perdesccom;
        [XmlElement(ElementName = "PERDESCCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perdesccom
        {
            get { return  perdesccom; }
            set {  perdesccom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCCUSTO
        /// Comentário: 
        /// </summary>
        private decimal perdesccusto;
        [XmlElement(ElementName = "PERDESCCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdesccusto
        {
            get { return  perdesccusto; }
            set {  perdesccusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFIN
        /// Comentário: 
        /// </summary>
        private decimal perdescfin;
        [XmlElement(ElementName = "PERDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perdescfin
        {
            get { return  perdescfin; }
            set {  perdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFLEX
        /// Comentário: 
        /// </summary>
        private decimal perdescflex;
        [XmlElement(ElementName = "PERDESCFLEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdescflex
        {
            get { return  perdescflex; }
            set {  perdescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCISENTOICMS
        /// Comentário: 
        /// </summary>
        private decimal perdescisentoicms;
        [XmlElement(ElementName = "PERDESCISENTOICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perdescisentoicms
        {
            get { return  perdescisentoicms; }
            set {  perdescisentoicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETECMV
        /// Comentário: 
        /// </summary>
        private decimal perfretecmv;
        [XmlElement(ElementName = "PERFRETECMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perfretecmv
        {
            get { return  perfretecmv; }
            set {  perfretecmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERICM
        /// Comentário: % ICMS produto.
        /// </summary>
        private decimal pericm;
        [XmlElement(ElementName = "PERICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pericm
        {
            get { return  pericm; }
            set {  pericm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERICMFRETE
        /// Comentário: 
        /// </summary>
        private decimal pericmfrete;
        [XmlElement(ElementName = "PERICMFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pericmfrete
        {
            get { return  pericmfrete; }
            set {  pericmfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERICMGUIAPROPRIA
        /// Comentário: 
        /// </summary>
        private decimal pericmguiapropria;
        [XmlElement(ElementName = "PERICMGUIAPROPRIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Pericmguiapropria
        {
            get { return  pericmguiapropria; }
            set {  pericmguiapropria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERICMSANTECIPADO
        /// Comentário: Campo para armazenar o percentual do ICMS antecipado informado no pedido de compra. 
        /// </summary>
        private decimal pericmsantecipado;
        [XmlElement(ElementName = "PERICMSANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Pericmsantecipado
        {
            get { return  pericmsantecipado; }
            set {  pericmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Comentário: Campo para armazenar o percentual de PIS informado no pedido de compra. 
        /// </summary>
        private decimal perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERREDCOMISS
        /// Comentário: 
        /// </summary>
        private decimal perredcomiss;
        [XmlElement(ElementName = "PERREDCOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perredcomiss
        {
            get { return  perredcomiss; }
            set {  perredcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERREDCOMISSSUP
        /// Comentário: 
        /// </summary>
        private decimal perredcomisssup;
        [XmlElement(ElementName = "PERREDCOMISSSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perredcomisssup
        {
            get { return  perredcomisssup; }
            set {  perredcomisssup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBRUTO
        /// Comentário: 
        /// </summary>
        private decimal pesobruto;
        [XmlElement(ElementName = "PESOBRUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pesobruto
        {
            get { return  pesobruto; }
            set {  pesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOLIQ
        /// Comentário: Peso liquido do produto.
        /// </summary>
        private decimal pesoliq;
        [XmlElement(ElementName = "PESOLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pesoliq
        {
            get { return  pesoliq; }
            set {  pesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PISCOFINSRETIDO
        /// Comentário: Indica se o PIS/COFINS é retido.
        /// </summary>
        private string piscofinsretido;
        [XmlElement(ElementName = "PISCOFINSRETIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Piscofinsretido
        {
            get { return  piscofinsretido; }
            set {  piscofinsretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLIQPED
        /// Comentário: 
        /// </summary>
        private decimal pliqped;
        [XmlElement(ElementName = "PLIQPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pliqped
        {
            get { return  pliqped; }
            set {  pliqped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPPCONDVENDA
        /// Comentário: 
        /// </summary>
        private decimal pppcondvenda;
        [XmlElement(ElementName = "PPPCONDVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Pppcondvenda
        {
            get { return  pppcondvenda; }
            set {  pppcondvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPPPERCIPITV3
        /// Comentário: 
        /// </summary>
        private decimal ppppercipitv3;
        [XmlElement(ElementName = "PPPPERCIPITV3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ppppercipitv3
        {
            get { return  ppppercipitv3; }
            set {  ppppercipitv3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPPPUNITTV3
        /// Comentário: 
        /// </summary>
        private decimal ppppunittv3;
        [XmlElement(ElementName = "PPPPUNITTV3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ppppunittv3
        {
            get { return  ppppunittv3; }
            set {  ppppunittv3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPPSTTV3
        /// Comentário: 
        /// </summary>
        private decimal pppsttv3;
        [XmlElement(ElementName = "PPPSTTV3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pppsttv3
        {
            get { return  pppsttv3; }
            set {  pppsttv3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PPPVLIPITV3
        /// Comentário: 
        /// </summary>
        private decimal pppvlipitv3;
        [XmlElement(ElementName = "PPPVLIPITV3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pppvlipitv3
        {
            get { return  pppvlipitv3; }
            set {  pppvlipitv3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIO
        /// Comentário: 
        /// </summary>
        private decimal prazomedio;
        [XmlElement(ElementName = "PRAZOMEDIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomedio
        {
            get { return  prazomedio; }
            set {  prazomedio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOPAUTA
        /// Comentário: Indica o Preço de Pauta.
        /// </summary>
        private decimal precopauta;
        [XmlElement(ElementName = "PRECOPAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precopauta
        {
            get { return  precopauta; }
            set {  precopauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODBONIFICADO
        /// Comentário: 
        /// </summary>
        private string prodbonificado;
        [XmlElement(ElementName = "PRODBONIFICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prodbonificado
        {
            get { return  prodbonificado; }
            set {  prodbonificado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODDESCRICAOCONTRATO
        /// Comentário: Campo armazena a descrição do produto registrada no contrato.
        /// </summary>
        private string proddescricaocontrato;
        [XmlElement(ElementName = "PRODDESCRICAOCONTRATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Proddescricaocontrato
        {
            get { return  proddescricaocontrato; }
            set {  proddescricaocontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROMOCAOBIRO
        /// Comentário: 
        /// </summary>
        private string promocaobiro;
        [XmlElement(ElementName = "PROMOCAOBIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Promocaobiro
        {
            get { return  promocaobiro; }
            set {  promocaobiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: 
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA2
        /// Comentário: 
        /// </summary>
        private decimal ptabela2;
        [XmlElement(ElementName = "PTABELA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela2
        {
            get { return  ptabela2; }
            set {  ptabela2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNIT
        /// Comentário: 
        /// </summary>
        private decimal punit;
        [XmlElement(ElementName = "PUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Punit
        {
            get { return  punit; }
            set {  punit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNITCONT
        /// Comentário: 
        /// </summary>
        private decimal punitcont;
        [XmlElement(ElementName = "PUNITCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Punitcont
        {
            get { return  punitcont; }
            set {  punitcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNITNF
        /// Comentário: 
        /// </summary>
        private decimal punitnf;
        [XmlElement(ElementName = "PUNITNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Punitnf
        {
            get { return  punitnf; }
            set {  punitnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNITNOTA
        /// Comentário: 
        /// </summary>
        private decimal punitnota;
        [XmlElement(ElementName = "PUNITNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Punitnota
        {
            get { return  punitnota; }
            set {  punitnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDABASE
        /// Comentário: 
        /// </summary>
        private decimal pvendabase;
        [XmlElement(ElementName = "PVENDABASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendabase
        {
            get { return  pvendabase; }
            set {  pvendabase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAEMB
        /// Comentário: 
        /// </summary>
        private decimal pvendaemb;
        [XmlElement(ElementName = "PVENDAEMB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendaemb
        {
            get { return  pvendaemb; }
            set {  pvendaemb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAEMBALAGEM
        /// Comentário: 
        /// </summary>
        private decimal pvendaembalagem;
        [XmlElement(ElementName = "PVENDAEMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaembalagem
        {
            get { return  pvendaembalagem; }
            set {  pvendaembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA1
        /// Comentário: Valor do preço a vista, para realização de cálculo de comissão sobre preço a vista.
        /// </summary>
        private decimal pvenda1;
        [XmlElement(ElementName = "PVENDA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda1
        {
            get { return  pvenda1; }
            set {  pvenda1 = value; }
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
        /// Propriedade referente ao campo: QTAVARIA
        /// Comentário: 
        /// </summary>
        private decimal qtavaria;
        [XmlElement(ElementName = "QTAVARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtavaria
        {
            get { return  qtavaria; }
            set {  qtavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQUEADA
        /// Comentário: 
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
        /// Propriedade referente ao campo: QTCONF
        /// Comentário: Indica a quantidade conferida.
        /// </summary>
        private decimal qtconf;
        [XmlElement(ElementName = "QTCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtconf
        {
            get { return  qtconf; }
            set {  qtconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCONT
        /// Comentário: 
        /// </summary>
        private decimal qtcont;
        [XmlElement(ElementName = "QTCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtcont
        {
            get { return  qtcont; }
            set {  qtcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCX
        /// Comentário: 
        /// </summary>
        private decimal qtcx;
        [XmlElement(ElementName = "QTCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtcx
        {
            get { return  qtcx; }
            set {  qtcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVOL
        /// Comentário: 
        /// </summary>
        private decimal qtdevol;
        [XmlElement(ElementName = "QTDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtdevol
        {
            get { return  qtdevol; }
            set {  qtdevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEMBALAGEM
        /// Comentário: 
        /// </summary>
        private decimal qtembalagem;
        [XmlElement(ElementName = "QTEMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtembalagem
        {
            get { return  qtembalagem; }
            set {  qtembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTANT
        /// Comentário: 
        /// </summary>
        private decimal qtestant;
        [XmlElement(ElementName = "QTESTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestant
        {
            get { return  qtestant; }
            set {  qtestant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGERANT
        /// Comentário: 
        /// </summary>
        private decimal qtestgerant;
        [XmlElement(ElementName = "QTESTGERANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestgerant
        {
            get { return  qtestgerant; }
            set {  qtestgerant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTHORAS
        /// Comentário: 
        /// </summary>
        private decimal qthoras;
        [XmlElement(ElementName = "QTHORAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qthoras
        {
            get { return  qthoras; }
            set {  qthoras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTNOTA
        /// Comentário: 
        /// </summary>
        private decimal qtnota;
        [XmlElement(ElementName = "QTNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtnota
        {
            get { return  qtnota; }
            set {  qtnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPECAS
        /// Comentário: 
        /// </summary>
        private decimal qtpecas;
        [XmlElement(ElementName = "QTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtpecas
        {
            get { return  qtpecas; }
            set {  qtpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDIDO
        /// Comentário: Campo para armazenar a quantidade informada no pedido de compra. 
        /// </summary>
        private decimal qtpedido;
        [XmlElement(ElementName = "QTPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,26)]
        public decimal Qtpedido
        {
            get { return  qtpedido; }
            set {  qtpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSALDOEST
        /// Comentário: 
        /// </summary>
        private decimal qtsaldoest;
        [XmlElement(ElementName = "QTSALDOEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtsaldoest
        {
            get { return  qtsaldoest; }
            set {  qtsaldoest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSALDOESTGER
        /// Comentário: 
        /// </summary>
        private decimal qtsaldoestger;
        [XmlElement(ElementName = "QTSALDOESTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtsaldoestger
        {
            get { return  qtsaldoestger; }
            set {  qtsaldoestger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSEP1
        /// Comentário: 
        /// </summary>
        private decimal qtsep1;
        [XmlElement(ElementName = "QTSEP1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtsep1
        {
            get { return  qtsep1; }
            set {  qtsep1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSEP2
        /// Comentário: 
        /// </summary>
        private decimal qtsep2;
        [XmlElement(ElementName = "QTSEP2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtsep2
        {
            get { return  qtsep2; }
            set {  qtsep2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTULTENTANT
        /// Comentário: 
        /// </summary>
        private decimal qtultentant;
        [XmlElement(ElementName = "QTULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtultentant
        {
            get { return  qtultentant; }
            set {  qtultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNIT
        /// Comentário: Menor Qt.Unitária.
        /// </summary>
        private decimal qtunit;
        [XmlElement(ElementName = "QTUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtunit
        {
            get { return  qtunit; }
            set {  qtunit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNITCX
        /// Comentário: Quantidade master.
        /// </summary>
        private decimal qtunitcx;
        [XmlElement(ElementName = "QTUNITCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtunitcx
        {
            get { return  qtunitcx; }
            set {  qtunitcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNITEMB
        /// Comentário: Indica a quantidade uitaria da embalagem.
        /// </summary>
        private decimal qtunitemb;
        [XmlElement(ElementName = "QTUNITEMB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtunitemb
        {
            get { return  qtunitemb; }
            set {  qtunitemb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAEMB
        /// Comentário: 
        /// </summary>
        private decimal qtvendaemb;
        [XmlElement(ElementName = "QTVENDAEMB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtvendaemb
        {
            get { return  qtvendaemb; }
            set {  qtvendaemb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUALDIVERGENCIA
        /// Comentário: 
        /// </summary>
        private string qualdivergencia;
        [XmlElement(ElementName = "QUALDIVERGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Qualdivergencia
        {
            get { return  qualdivergencia; }
            set {  qualdivergencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEALIQEXT
        /// Comentário: 
        /// </summary>
        private decimal redbasealiqext;
        [XmlElement(ElementName = "REDBASEALIQEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Redbasealiqext
        {
            get { return  redbasealiqext; }
            set {  redbasealiqext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEIVA
        /// Comentário: 
        /// </summary>
        private decimal redbaseiva;
        [XmlElement(ElementName = "REDBASEIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Redbaseiva
        {
            get { return  redbaseiva; }
            set {  redbaseiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFCOR
        /// Comentário: 
        /// </summary>
        private string refcor;
        [XmlElement(ElementName = "REFCOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Refcor
        {
            get { return  refcor; }
            set {  refcor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Comentário: 
        /// </summary>
        private string rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,48)]
        public string Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA
        /// Comentário: Rua do produto no estoque.
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
        /// Propriedade referente ao campo: SITTRIBUT
        /// Comentário: 
        /// </summary>
        private string sittribut;
        [XmlElement(ElementName = "SITTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittribut
        {
            get { return  sittribut; }
            set {  sittribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ST
        /// Comentário: 
        /// </summary>
        private decimal st;
        [XmlElement(ElementName = "ST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal St
        {
            get { return  st; }
            set {  st = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STBCR
        /// Comentário: 
        /// </summary>
        private decimal stbcr;
        [XmlElement(ElementName = "STBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Stbcr
        {
            get { return  stbcr; }
            set {  stbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STCLIENTEGNRE
        /// Comentário: 
        /// </summary>
        private decimal stclientegnre;
        [XmlElement(ElementName = "STCLIENTEGNRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Stclientegnre
        {
            get { return  stclientegnre; }
            set {  stclientegnre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STSAIDA
        /// Comentário: 
        /// </summary>
        private decimal stsaida;
        [XmlElement(ElementName = "STSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Stsaida
        {
            get { return  stsaida; }
            set {  stsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ST2
        /// Comentário: 
        /// </summary>
        private decimal st2;
        [XmlElement(ElementName = "ST2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal St2
        {
            get { return  st2; }
            set {  st2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBTOTAL
        /// Comentário: 
        /// </summary>
        private decimal subtotal;
        [XmlElement(ElementName = "SUBTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Subtotal
        {
            get { return  subtotal; }
            set {  subtotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCST
        /// Comentário: Tipo do cálculo ST. 
        /// </summary>
        private string tipocalcst;
        [XmlElement(ElementName = "TIPOCALCST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocalcst
        {
            get { return  tipocalcst; }
            set {  tipocalcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCAPLICADO
        /// Comentário: 
        /// </summary>
        private string tipodescaplicado;
        [XmlElement(ElementName = "TIPODESCAPLICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipodescaplicado
        {
            get { return  tipodescaplicado; }
            set {  tipodescaplicado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEMPEDIDO
        /// Comentário: Indica o tipo da embalagem do pedido: V-Venda/M-Master.
        /// </summary>
        private string tipoembalagempedido;
        [XmlElement(ElementName = "TIPOEMBALAGEMPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoembalagempedido
        {
            get { return  tipoembalagempedido; }
            set {  tipoembalagempedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFATOR
        /// Comentário: 
        /// </summary>
        private string tipofator;
        [XmlElement(ElementName = "TIPOFATOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofator
        {
            get { return  tipofator; }
            set {  tipofator = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFORNEC
        /// Comentário: Indica o tipo do fornecedor.
        /// </summary>
        private string tipofornec;
        [XmlElement(ElementName = "TIPOFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofornec
        {
            get { return  tipofornec; }
            set {  tipofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOITEM
        /// Comentário: Utilizado no Faturamento (rotina 1400), gravando os seguintes valores: C - Cesta / I - Item da Cesta / N - nda.
        /// </summary>
        private string tipoitem;
        [XmlElement(ElementName = "TIPOITEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoitem
        {
            get { return  tipoitem; }
            set {  tipoitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMERC
        /// Comentário: Tipo da mercadoria.
        /// </summary>
        private string tipomerc;
        [XmlElement(ElementName = "TIPOMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomerc
        {
            get { return  tipomerc; }
            set {  tipomerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMERCDEPTO
        /// Comentário: Tipo merc. do departamento do produto.
        /// </summary>
        private string tipomercdepto;
        [XmlElement(ElementName = "TIPOMERCDEPTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomercdepto
        {
            get { return  tipomercdepto; }
            set {  tipomercdepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSEPARACAO
        /// Comentário: Indica o tipo de separação.
        /// </summary>
        private string tiposeparacao;
        [XmlElement(ElementName = "TIPOSEPARACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiposeparacao
        {
            get { return  tiposeparacao; }
            set {  tiposeparacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTIS
        /// Comentário: 
        /// </summary>
        private string tipotis;
        [XmlElement(ElementName = "TIPOTIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotis
        {
            get { return  tipotis; }
            set {  tipotis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTRIBUTMEDIC
        /// Comentário: Tipo tributação de medicamentos.
        /// </summary>
        private string tipotributmedic;
        [XmlElement(ElementName = "TIPOTRIBUTMEDIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipotributmedic
        {
            get { return  tipotributmedic; }
            set {  tipotributmedic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIS
        /// Comentário: 
        /// </summary>
        private string tis;
        [XmlElement(ElementName = "TIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Tis
        {
            get { return  tis; }
            set {  tis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESOLIQ
        /// Comentário: Total do peso líquido dos proudtos  informados na nota fiscal.
        /// </summary>
        private decimal totpesoliq;
        [XmlElement(ElementName = "TOTPESOLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totpesoliq
        {
            get { return  totpesoliq; }
            set {  totpesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSACAOTRANSFERIDA
        /// Comentário: Transferência já efetuada.
        /// </summary>
        private string transacaotransferida;
        [XmlElement(ElementName = "TRANSACAOTRANSFERIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Transacaotransferida
        {
            get { return  transacaotransferida; }
            set {  transacaotransferida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRGPCLOTE
        /// Comentário: Definir se a trigger que atualiza o PCLOTE foi acionada ao inserir o registro no PCMOVPREENT.
        /// </summary>
        private string trgpclote;
        [XmlElement(ElementName = "TRGPCLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Trgpclote
        {
            get { return  trgpclote; }
            set {  trgpclote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRIBFEDERAL
        /// Comentário: Tributação federal.
        /// </summary>
        private string tribfederal;
        [XmlElement(ElementName = "TRIBFEDERAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Tribfederal
        {
            get { return  tribfederal; }
            set {  tribfederal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRUNCARITEM
        /// Comentário: Para correção de diferenças de truncamento/arredondamento no subtotal do item das impressoras fiscais.
        /// </summary>
        private string truncaritem;
        [XmlElement(ElementName = "TRUNCARITEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Truncaritem
        {
            get { return  truncaritem; }
            set {  truncaritem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXVENDA
        /// Comentário: 
        /// </summary>
        private decimal txvenda;
        [XmlElement(ElementName = "TXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Txvenda
        {
            get { return  txvenda; }
            set {  txvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFFORNEC
        /// Comentário: UF do fornecedor do produto.
        /// </summary>
        private string uffornec;
        [XmlElement(ElementName = "UFFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uffornec
        {
            get { return  uffornec; }
            set {  uffornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE
        /// Comentário: Unidade de medida do produto.
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
        /// Propriedade referente ao campo: VALORDIREITOSADUANEIROS
        /// Comentário: Campo para armazenar o valor dos direitos aduaneiros.
        /// </summary>
        private decimal valordireitosaduaneiros;
        [XmlElement(ElementName = "VALORDIREITOSADUANEIROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valordireitosaduaneiros
        {
            get { return  valordireitosaduaneiros; }
            set {  valordireitosaduaneiros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORIMPOSTOCONSUMO
        /// Comentário: Campo para armazenar o valor do imposto de consumo.
        /// </summary>
        private decimal valorimpostoconsumo;
        [XmlElement(ElementName = "VALORIMPOSTOCONSUMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorimpostoconsumo
        {
            get { return  valorimpostoconsumo; }
            set {  valorimpostoconsumo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORIMPOSTOSELO
        /// Comentário: Campo para armazenar o valor do imposto de selo.
        /// </summary>
        private decimal valorimpostoselo;
        [XmlElement(ElementName = "VALORIMPOSTOSELO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorimpostoselo
        {
            get { return  valorimpostoselo; }
            set {  valorimpostoselo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORULTENT
        /// Comentário: 
        /// </summary>
        private decimal valorultent;
        [XmlElement(ElementName = "VALORULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorultent
        {
            get { return  valorultent; }
            set {  valorultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORULTENTANT
        /// Comentário: 
        /// </summary>
        private decimal valorultentant;
        [XmlElement(ElementName = "VALORULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorultentant
        {
            get { return  valorultentant; }
            set {  valorultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORULTENTMED
        /// Comentário: 
        /// </summary>
        private decimal valorultentmed;
        [XmlElement(ElementName = "VALORULTENTMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorultentmed
        {
            get { return  valorultentmed; }
            set {  valorultentmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORULTENTMEDANT
        /// Comentário: 
        /// </summary>
        private decimal valorultentmedant;
        [XmlElement(ElementName = "VALORULTENTMEDANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorultentmedant
        {
            get { return  valorultentmedant; }
            set {  valorultentmedant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VILOBSRATEIOBAIXACUSTO
        /// Comentário: 
        /// </summary>
        private string vilobsrateiobaixacusto;
        [XmlElement(ElementName = "VILOBSRATEIOBAIXACUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Vilobsrateiobaixacusto
        {
            get { return  vilobsrateiobaixacusto; }
            set {  vilobsrateiobaixacusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLACRESCIMOPF
        /// Comentário: 
        /// </summary>
        private decimal vlacrescimopf;
        [XmlElement(ElementName = "VLACRESCIMOPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlacrescimopf
        {
            get { return  vlacrescimopf; }
            set {  vlacrescimopf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLACRESCRODAPE
        /// Comentário: 
        /// </summary>
        private decimal vlacrescrodape;
        [XmlElement(ElementName = "VLACRESCRODAPE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlacrescrodape
        {
            get { return  vlacrescrodape; }
            set {  vlacrescrodape = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADICIONALBCST
        /// Comentário: 
        /// </summary>
        private decimal vladicionalbcst;
        [XmlElement(ElementName = "VLADICIONALBCST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vladicionalbcst
        {
            get { return  vladicionalbcst; }
            set {  vladicionalbcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADUANEIRA
        /// Comentário: 
        /// </summary>
        private decimal vladuaneira;
        [XmlElement(ElementName = "VLADUANEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vladuaneira
        {
            get { return  vladuaneira; }
            set {  vladuaneira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEGNRE
        /// Comentário: 
        /// </summary>
        private decimal vlbasegnre;
        [XmlElement(ElementName = "VLBASEGNRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlbasegnre
        {
            get { return  vlbasegnre; }
            set {  vlbasegnre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEIPI
        /// Comentário: 
        /// </summary>
        private decimal vlbaseipi;
        [XmlElement(ElementName = "VLBASEIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbaseipi
        {
            get { return  vlbaseipi; }
            set {  vlbaseipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEIPI2
        /// Comentário: 
        /// </summary>
        private decimal vlbaseipi2;
        [XmlElement(ElementName = "VLBASEIPI2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbaseipi2
        {
            get { return  vlbaseipi2; }
            set {  vlbaseipi2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEPISCOFINS
        /// Comentário: Indica o valor da base para o PIS/COFINS.
        /// </summary>
        private decimal vlbasepiscofins;
        [XmlElement(ElementName = "VLBASEPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbasepiscofins
        {
            get { return  vlbasepiscofins; }
            set {  vlbasepiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASESTFORANF
        /// Comentário: 
        /// </summary>
        private decimal vlbasestforanf;
        [XmlElement(ElementName = "VLBASESTFORANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbasestforanf
        {
            get { return  vlbasestforanf; }
            set {  vlbasestforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFIC
        /// Comentário: Campo para armazenar o valor da bonificação informado no pedido de compra. 
        /// </summary>
        private decimal vlbonific;
        [XmlElement(ElementName = "VLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vlbonific
        {
            get { return  vlbonific; }
            set {  vlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFICOUTRAS
        /// Comentário: 
        /// </summary>
        private decimal vlbonificoutras;
        [XmlElement(ElementName = "VLBONIFICOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbonificoutras
        {
            get { return  vlbonificoutras; }
            set {  vlbonificoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINS
        /// Comentário: Indica o valor do COFINS.
        /// </summary>
        private decimal vlcofins;
        [XmlElement(ElementName = "VLCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vlcofins
        {
            get { return  vlcofins; }
            set {  vlcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDCOFINS
        /// Comentário: 
        /// </summary>
        private decimal vlcredcofins;
        [XmlElement(ElementName = "VLCREDCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredcofins
        {
            get { return  vlcredcofins; }
            set {  vlcredcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDICMS
        /// Comentário: 
        /// </summary>
        private decimal vlcredicms;
        [XmlElement(ElementName = "VLCREDICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredicms
        {
            get { return  vlcredicms; }
            set {  vlcredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDICMSFRETE
        /// Comentário: 
        /// </summary>
        private decimal vlcredicmsfrete;
        [XmlElement(ElementName = "VLCREDICMSFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredicmsfrete
        {
            get { return  vlcredicmsfrete; }
            set {  vlcredicmsfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPIS
        /// Comentário: 
        /// </summary>
        private decimal vlcredpis;
        [XmlElement(ElementName = "VLCREDPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredpis
        {
            get { return  vlcredpis; }
            set {  vlcredpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPRESUMIDO
        /// Comentário: Indica o valor do credito presumido de ICMS.
        /// </summary>
        private decimal vlcredpresumido;
        [XmlElement(ElementName = "VLCREDPRESUMIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredpresumido
        {
            get { return  vlcredpresumido; }
            set {  vlcredpresumido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCCOM
        /// Comentário: 
        /// </summary>
        private decimal vldesccom;
        [XmlElement(ElementName = "VLDESCCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldesccom
        {
            get { return  vldesccom; }
            set {  vldesccom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCCUSTOCMV
        /// Comentário: 
        /// </summary>
        private decimal vldesccustocmv;
        [XmlElement(ElementName = "VLDESCCUSTOCMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldesccustocmv
        {
            get { return  vldesccustocmv; }
            set {  vldesccustocmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCFIN
        /// Comentário: 
        /// </summary>
        private decimal vldescfin;
        [XmlElement(ElementName = "VLDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescfin
        {
            get { return  vldescfin; }
            set {  vldescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCFLEX
        /// Comentário: 
        /// </summary>
        private decimal vldescflex;
        [XmlElement(ElementName = "VLDESCFLEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescflex
        {
            get { return  vldescflex; }
            set {  vldescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCICMISENCAO
        /// Comentário: 
        /// </summary>
        private decimal vldescicmisencao;
        [XmlElement(ElementName = "VLDESCICMISENCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescicmisencao
        {
            get { return  vldescicmisencao; }
            set {  vldescicmisencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCICMSDIF
        /// Comentário: Valor do desconto de ICMS Difererido.
        /// </summary>
        private decimal vldescicmsdif;
        [XmlElement(ElementName = "VLDESCICMSDIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescicmsdif
        {
            get { return  vldescicmsdif; }
            set {  vldescicmsdif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Comentário: 
        /// </summary>
        private decimal vldesconto;
        [XmlElement(ElementName = "VLDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldesconto
        {
            get { return  vldesconto; }
            set {  vldesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCPISSUFRAMA
        /// Comentário: 
        /// </summary>
        private decimal vldescpissuframa;
        [XmlElement(ElementName = "VLDESCPISSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescpissuframa
        {
            get { return  vldescpissuframa; }
            set {  vldescpissuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCREDUCAOCOFINS
        /// Comentário: Indica o valor de desconto COFINS aplicado na venda.
        /// </summary>
        private decimal vldescreducaocofins;
        [XmlElement(ElementName = "VLDESCREDUCAOCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vldescreducaocofins
        {
            get { return  vldescreducaocofins; }
            set {  vldescreducaocofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCREDUCAOPIS
        /// Comentário: Indica o valor de desconto PIS aplicado na venda.
        /// </summary>
        private decimal vldescreducaopis;
        [XmlElement(ElementName = "VLDESCREDUCAOPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vldescreducaopis
        {
            get { return  vldescreducaopis; }
            set {  vldescreducaopis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCRODAPE
        /// Comentário: 
        /// </summary>
        private decimal vldescrodape;
        [XmlElement(ElementName = "VLDESCRODAPE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescrodape
        {
            get { return  vldescrodape; }
            set {  vldescrodape = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCSUFRAMA
        /// Comentário: 
        /// </summary>
        private decimal vldescsuframa;
        [XmlElement(ElementName = "VLDESCSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescsuframa
        {
            get { return  vldescsuframa; }
            set {  vldescsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPADICIONAL
        /// Comentário: 
        /// </summary>
        private decimal vldespadicional;
        [XmlElement(ElementName = "VLDESPADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespadicional
        {
            get { return  vldespadicional; }
            set {  vldespadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPDENTRONF
        /// Comentário: Indica o Valor outras despesas na NF.
        /// </summary>
        private decimal vldespdentronf;
        [XmlElement(ElementName = "VLDESPDENTRONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespdentronf
        {
            get { return  vldespdentronf; }
            set {  vldespdentronf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPFORANF
        /// Comentário: Indica o valor da despesa fora da nota.
        /// </summary>
        private decimal vldespforanf;
        [XmlElement(ElementName = "VLDESPFORANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespforanf
        {
            get { return  vldespforanf; }
            set {  vldespforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIFALIQUOTAS
        /// Comentário: Valor da diferença de aliquotas.
        /// </summary>
        private decimal vldifaliquotas;
        [XmlElement(ElementName = "VLDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldifaliquotas
        {
            get { return  vldifaliquotas; }
            set {  vldifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIFPUNITCONT
        /// Comentário: Valor da diferença entre a soma dos itens e total da nota fiscal.
        /// </summary>
        private decimal vldifpunitcont;
        [XmlElement(ElementName = "VLDIFPUNITCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldifpunitcont
        {
            get { return  vldifpunitcont; }
            set {  vldifpunitcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Comentário: 
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETECONHEC
        /// Comentário: 
        /// </summary>
        private decimal vlfreteconhec;
        [XmlElement(ElementName = "VLFRETECONHEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfreteconhec
        {
            get { return  vlfreteconhec; }
            set {  vlfreteconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETEPORKG
        /// Comentário: Campo para armazenar o valor do frete por Kg informado no pedido de compra. 
        /// </summary>
        private decimal vlfreteporkg;
        [XmlElement(ElementName = "VLFRETEPORKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vlfreteporkg
        {
            get { return  vlfreteporkg; }
            set {  vlfreteporkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE_RATEIO
        /// Comentário: Indica o valor do frete no raterio.
        /// </summary>
        private decimal vlfrete_rateio;
        [XmlElement(ElementName = "VLFRETE_RATEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfrete_Rateio
        {
            get { return  vlfrete_rateio; }
            set {  vlfrete_rateio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMS
        /// Comentário: 
        /// </summary>
        private decimal vlicms;
        [XmlElement(ElementName = "VLICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlicms
        {
            get { return  vlicms; }
            set {  vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSBCR
        /// Comentário: 
        /// </summary>
        private decimal vlicmsbcr;
        [XmlElement(ElementName = "VLICMSBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlicmsbcr
        {
            get { return  vlicmsbcr; }
            set {  vlicmsbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSDIFERIDO
        /// Comentário: Indica o valor do ICMS diferido.
        /// </summary>
        private decimal vlicmsdiferido;
        [XmlElement(ElementName = "VLICMSDIFERIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlicmsdiferido
        {
            get { return  vlicmsdiferido; }
            set {  vlicmsdiferido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIMPORTACAO
        /// Comentário: 
        /// </summary>
        private decimal vlimportacao;
        [XmlElement(ElementName = "VLIMPORTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlimportacao
        {
            get { return  vlimportacao; }
            set {  vlimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLINDENIZ
        /// Comentário: 
        /// </summary>
        private decimal vlindeniz;
        [XmlElement(ElementName = "VLINDENIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlindeniz
        {
            get { return  vlindeniz; }
            set {  vlindeniz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLINSS
        /// Comentário: Indica o valor do INSS.
        /// </summary>
        private decimal vlinss;
        [XmlElement(ElementName = "VLINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlinss
        {
            get { return  vlinss; }
            set {  vlinss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: 
        /// </summary>
        private decimal vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIPORKG
        /// Comentário: Indica valor do IPI por KG.
        /// </summary>
        private decimal vlipiporkg;
        [XmlElement(ElementName = "VLIPIPORKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipiporkg
        {
            get { return  vlipiporkg; }
            set {  vlipiporkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI2
        /// Comentário: 
        /// </summary>
        private decimal vlipi2;
        [XmlElement(ElementName = "VLIPI2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipi2
        {
            get { return  vlipi2; }
            set {  vlipi2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISS
        /// Comentário: 
        /// </summary>
        private decimal vliss;
        [XmlElement(ElementName = "VLISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vliss
        {
            get { return  vliss; }
            set {  vliss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIVAMEX
        /// Comentário: 
        /// </summary>
        private decimal vlivamex;
        [XmlElement(ElementName = "VLIVAMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlivamex
        {
            get { return  vlivamex; }
            set {  vlivamex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEXFPGC
        /// Comentário: 
        /// </summary>
        private decimal vlmexfpgc;
        [XmlElement(ElementName = "VLMEXFPGC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlmexfpgc
        {
            get { return  vlmexfpgc; }
            set {  vlmexfpgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEXIEPS
        /// Comentário: 
        /// </summary>
        private decimal vlmexieps;
        [XmlElement(ElementName = "VLMEXIEPS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlmexieps
        {
            get { return  vlmexieps; }
            set {  vlmexieps = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEXIVA
        /// Comentário: 
        /// </summary>
        private decimal vlmexiva;
        [XmlElement(ElementName = "VLMEXIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlmexiva
        {
            get { return  vlmexiva; }
            set {  vlmexiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal vloutrasdesp;
        [XmlElement(ElementName = "VLOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutrasdesp
        {
            get { return  vloutrasdesp; }
            set {  vloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESPIMP
        /// Comentário: 
        /// </summary>
        private decimal vloutrasdespimp;
        [XmlElement(ElementName = "VLOUTRASDESPIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutrasdespimp
        {
            get { return  vloutrasdespimp; }
            set {  vloutrasdespimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRAS_RATEIO
        /// Comentário: Indica o valor de outras despesas no rateio.
        /// </summary>
        private decimal vloutras_rateio;
        [XmlElement(ElementName = "VLOUTRAS_RATEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutras_Rateio
        {
            get { return  vloutras_rateio; }
            set {  vloutras_rateio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTROS
        /// Comentário: 
        /// </summary>
        private decimal vloutros;
        [XmlElement(ElementName = "VLOUTROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutros
        {
            get { return  vloutros; }
            set {  vloutros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAICM
        /// Comentário: 
        /// </summary>
        private decimal vlpautaicm;
        [XmlElement(ElementName = "VLPAUTAICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlpautaicm
        {
            get { return  vlpautaicm; }
            set {  vlpautaicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAICMS
        /// Comentário: Indica o valor de pauta ICMS.
        /// </summary>
        private decimal vlpautaicms;
        [XmlElement(ElementName = "VLPAUTAICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautaicms
        {
            get { return  vlpautaicms; }
            set {  vlpautaicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAICMSANTEC
        /// Comentário: Vl.Pauta para ICMS antecipado.
        /// </summary>
        private decimal vlpautaicmsantec;
        [XmlElement(ElementName = "VLPAUTAICMSANTEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautaicmsantec
        {
            get { return  vlpautaicmsantec; }
            set {  vlpautaicmsantec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTA2
        /// Comentário: 
        /// </summary>
        private decimal vlpauta2;
        [XmlElement(ElementName = "VLPAUTA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlpauta2
        {
            get { return  vlpauta2; }
            set {  vlpauta2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPERCBON
        /// Comentário: Valor da verba em mercadoria (segue padrão da tabela PCITEM). 
        /// </summary>
        private decimal vlpercbon;
        [XmlElement(ElementName = "VLPERCBON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpercbon
        {
            get { return  vlpercbon; }
            set {  vlpercbon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPIS
        /// Comentário: 
        /// </summary>
        private decimal vlpis;
        [XmlElement(ElementName = "VLPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpis
        {
            get { return  vlpis; }
            set {  vlpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREDCOMISS
        /// Comentário: 
        /// </summary>
        private decimal vlredcomiss;
        [XmlElement(ElementName = "VLREDCOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlredcomiss
        {
            get { return  vlredcomiss; }
            set {  vlredcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREDCOMISSSUP
        /// Comentário: 
        /// </summary>
        private decimal vlredcomisssup;
        [XmlElement(ElementName = "VLREDCOMISSSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlredcomisssup
        {
            get { return  vlredcomisssup; }
            set {  vlredcomisssup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREPASSE
        /// Comentário: 
        /// </summary>
        private decimal vlrepasse;
        [XmlElement(ElementName = "VLREPASSE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrepasse
        {
            get { return  vlrepasse; }
            set {  vlrepasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSEGURO
        /// Comentário: Indica o valor do seguro.
        /// </summary>
        private decimal vlseguro;
        [XmlElement(ElementName = "VLSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlseguro
        {
            get { return  vlseguro; }
            set {  vlseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSISCOMEX
        /// Comentário: 
        /// </summary>
        private decimal vlsiscomex;
        [XmlElement(ElementName = "VLSISCOMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsiscomex
        {
            get { return  vlsiscomex; }
            set {  vlsiscomex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSUFRAMA
        /// Comentário: Campo para armazenar o valor do SUFRAMA informado no pedido de compra. 
        /// </summary>
        private decimal vlsuframa;
        [XmlElement(ElementName = "VLSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vlsuframa
        {
            get { return  vlsuframa; }
            set {  vlsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLULTENTCONTSEMST
        /// Comentário: Valor última entrada contábil. 
        /// </summary>
        private decimal vlultentcontsemst;
        [XmlElement(ElementName = "VLULTENTCONTSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlultentcontsemst
        {
            get { return  vlultentcontsemst; }
            set {  vlultentcontsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLULTENTCONTSEMSTANT
        /// Comentário: Valor última entrada contábil anterior.
        /// </summary>
        private decimal vlultentcontsemstant;
        [XmlElement(ElementName = "VLULTENTCONTSEMSTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlultentcontsemstant
        {
            get { return  vlultentcontsemstant; }
            set {  vlultentcontsemstant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBAADIC
        /// Comentário: 
        /// </summary>
        private decimal vlverbaadic;
        [XmlElement(ElementName = "VLVERBAADIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlverbaadic
        {
            get { return  vlverbaadic; }
            set {  vlverbaadic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBACMV
        /// Comentário: 
        /// </summary>
        private decimal vlverbacmv;
        [XmlElement(ElementName = "VLVERBACMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlverbacmv
        {
            get { return  vlverbacmv; }
            set {  vlverbacmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBACMVCLI
        /// Comentário: Indica o valor total da verba CMV registrado no pedido.
        /// </summary>
        private decimal vlverbacmvcli;
        [XmlElement(ElementName = "VLVERBACMVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlverbacmvcli
        {
            get { return  vlverbacmvcli; }
            set {  vlverbacmvcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUME
        /// Comentário: Indica o volume do produto.
        /// </summary>
        private decimal volume;
        [XmlElement(ElementName = "VOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Volume
        {
            get { return  volume; }
            set {  volume = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMovpreent()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVPREENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMovpreent> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovpreent>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMovpreent> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovpreent>(where);
        }

        #endregion
    }
}

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
    /// Classe referente a tabela PCNegfornec
    /// </summary>
    [XmlType("PCNEGFORNEC")]
    public class PCNegfornec : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFISCALBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal codfiscalbonific;
        [XmlElement(ElementName = "CODFISCALBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalbonific
        {
            get { return  codfiscalbonific; }
            set {  codfiscalbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALBONIFICINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalbonificinter;
        [XmlElement(ElementName = "CODFISCALBONIFICINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalbonificinter
        {
            get { return  codfiscalbonificinter; }
            set {  codfiscalbonificinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalinter;
        [XmlElement(ElementName = "CODFISCALINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalinter
        {
            get { return  codfiscalinter; }
            set {  codfiscalinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Comentário: 
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
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINAULTALTCOM
        /// Comentário: Código da rotina última alteração comercial
        /// </summary>
        private decimal codrotinaultaltcom;
        [XmlElement(ElementName = "CODROTINAULTALTCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codrotinaultaltcom
        {
            get { return  codrotinaultaltcom; }
            set {  codrotinaultaltcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINAULTALTCOMTAB
        /// Comentário: Código do rotina última alteração politica comercial futura
        /// </summary>
        private decimal codrotinaultaltcomtab;
        [XmlElement(ElementName = "CODROTINAULTALTCOMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codrotinaultaltcomtab
        {
            get { return  codrotinaultaltcomtab; }
            set {  codrotinaultaltcomtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINAULTALTER
        /// Comentário: Código da rotina última alteração
        /// </summary>
        private decimal codrotinaultalter;
        [XmlElement(ElementName = "CODROTINAULTALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codrotinaultalter
        {
            get { return  codrotinaultalter; }
            set {  codrotinaultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUULTALTCOM
        /// Comentário: Código do usuário última alteração
        /// </summary>
        private decimal codusuultaltcom;
        [XmlElement(ElementName = "CODUSUULTALTCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuultaltcom
        {
            get { return  codusuultaltcom; }
            set {  codusuultaltcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUULTALTCOMTAB
        /// Comentário: Código do usuário última alteração politica comercial futura
        /// </summary>
        private decimal codusuultaltcomtab;
        [XmlElement(ElementName = "CODUSUULTALTCOMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuultaltcomtab
        {
            get { return  codusuultaltcomtab; }
            set {  codusuultaltcomtab = value; }
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
        /// Comentário: Preço de Compra Anterior
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
        /// Propriedade referente ao campo: CUSTOREPTAB
        /// Comentário: 
        /// </summary>
        private decimal custoreptab;
        [XmlElement(ElementName = "CUSTOREPTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoreptab
        {
            get { return  custoreptab; }
            set {  custoreptab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONFIRMACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtconfirmacao;
        [XmlElement(ElementName = "DTCONFIRMACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtconfirmacao
        {
            get { return  dtconfirmacao; }
            set {  dtconfirmacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTCOM
        /// Comentário: Data última atualização política
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
        /// Propriedade referente ao campo: DTULTALTERPOLITICA
        /// Comentário: 
        /// </summary>
        private DateTime? dtultalterpolitica;
        [XmlElement(ElementName = "DTULTALTERPOLITICA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalterpolitica
        {
            get { return  dtultalterpolitica; }
            set {  dtultalterpolitica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVIGENCIAPOLITICA
        /// Comentário: Data da vigência da política comercial
        /// </summary>
        private DateTime? dtvigenciapolitica;
        [XmlElement(ElementName = "DTVIGENCIAPOLITICA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvigenciapolitica
        {
            get { return  dtvigenciapolitica; }
            set {  dtvigenciapolitica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMANALISE
        /// Comentário: 
        /// </summary>
        private string emanalise;
        [XmlElement(ElementName = "EMANALISE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emanalise
        {
            get { return  emanalise; }
            set {  emanalise = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXT
        /// Comentário: 
        /// </summary>
        private decimal percaliqext;
        [XmlElement(ElementName = "PERCALIQEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqext
        {
            get { return  percaliqext; }
            set {  percaliqext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQINT
        /// Comentário: 
        /// </summary>
        private decimal percaliqint;
        [XmlElement(ElementName = "PERCALIQINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqint
        {
            get { return  percaliqint; }
            set {  percaliqint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBON
        /// Comentário: 
        /// </summary>
        private decimal percbon;
        [XmlElement(ElementName = "PERCBON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percbon
        {
            get { return  percbon; }
            set {  percbon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONIFIC
        /// Comentário: % Bonificação Dinheiro
        /// </summary>
        private decimal percbonific;
        [XmlElement(ElementName = "PERCBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbonific
        {
            get { return  percbonific; }
            set {  percbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONIFICTAB
        /// Comentário: % Bonificação Dinheiro
        /// </summary>
        private decimal percbonifictab;
        [XmlElement(ElementName = "PERCBONIFICTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbonifictab
        {
            get { return  percbonifictab; }
            set {  percbonifictab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONOUTRAS
        /// Comentário: % Bonificação Outras Verbas
        /// </summary>
        private decimal percbonoutras;
        [XmlElement(ElementName = "PERCBONOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbonoutras
        {
            get { return  percbonoutras; }
            set {  percbonoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONOUTRASTAB
        /// Comentário: % Bonificação Outras Verbas Futuro
        /// </summary>
        private decimal percbonoutrastab;
        [XmlElement(ElementName = "PERCBONOUTRASTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbonoutrastab
        {
            get { return  percbonoutrastab; }
            set {  percbonoutrastab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONTAB
        /// Comentário: 
        /// </summary>
        private decimal percbontab;
        [XmlElement(ElementName = "PERCBONTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percbontab
        {
            get { return  percbontab; }
            set {  percbontab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Comentário: 
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
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
        /// Propriedade referente ao campo: PERCDESCTAB
        /// Comentário: 
        /// </summary>
        private decimal percdesctab;
        [XmlElement(ElementName = "PERCDESCTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesctab
        {
            get { return  percdesctab; }
            set {  percdesctab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC1
        /// Comentário: 
        /// </summary>
        private decimal percdesc1;
        [XmlElement(ElementName = "PERCDESC1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc1
        {
            get { return  percdesc1; }
            set {  percdesc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC1TAB
        /// Comentário: 
        /// </summary>
        private decimal percdesc1tab;
        [XmlElement(ElementName = "PERCDESC1TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc1tab
        {
            get { return  percdesc1tab; }
            set {  percdesc1tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC10
        /// Comentário: 
        /// </summary>
        private decimal percdesc10;
        [XmlElement(ElementName = "PERCDESC10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc10
        {
            get { return  percdesc10; }
            set {  percdesc10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC10TAB
        /// Comentário: 
        /// </summary>
        private decimal percdesc10tab;
        [XmlElement(ElementName = "PERCDESC10TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc10tab
        {
            get { return  percdesc10tab; }
            set {  percdesc10tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC2
        /// Comentário: 
        /// </summary>
        private decimal percdesc2;
        [XmlElement(ElementName = "PERCDESC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc2
        {
            get { return  percdesc2; }
            set {  percdesc2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC2TAB
        /// Comentário: 
        /// </summary>
        private decimal percdesc2tab;
        [XmlElement(ElementName = "PERCDESC2TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc2tab
        {
            get { return  percdesc2tab; }
            set {  percdesc2tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC3
        /// Comentário: 
        /// </summary>
        private decimal percdesc3;
        [XmlElement(ElementName = "PERCDESC3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc3
        {
            get { return  percdesc3; }
            set {  percdesc3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC3TAB
        /// Comentário: 
        /// </summary>
        private decimal percdesc3tab;
        [XmlElement(ElementName = "PERCDESC3TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc3tab
        {
            get { return  percdesc3tab; }
            set {  percdesc3tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC4
        /// Comentário: 
        /// </summary>
        private decimal percdesc4;
        [XmlElement(ElementName = "PERCDESC4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc4
        {
            get { return  percdesc4; }
            set {  percdesc4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC4TAB
        /// Comentário: 
        /// </summary>
        private decimal percdesc4tab;
        [XmlElement(ElementName = "PERCDESC4TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc4tab
        {
            get { return  percdesc4tab; }
            set {  percdesc4tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC5
        /// Comentário: 
        /// </summary>
        private decimal percdesc5;
        [XmlElement(ElementName = "PERCDESC5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc5
        {
            get { return  percdesc5; }
            set {  percdesc5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC5TAB
        /// Comentário: 
        /// </summary>
        private decimal percdesc5tab;
        [XmlElement(ElementName = "PERCDESC5TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc5tab
        {
            get { return  percdesc5tab; }
            set {  percdesc5tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC6
        /// Comentário: 
        /// </summary>
        private decimal percdesc6;
        [XmlElement(ElementName = "PERCDESC6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc6
        {
            get { return  percdesc6; }
            set {  percdesc6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC6TAB
        /// Comentário: 
        /// </summary>
        private decimal percdesc6tab;
        [XmlElement(ElementName = "PERCDESC6TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc6tab
        {
            get { return  percdesc6tab; }
            set {  percdesc6tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC7
        /// Comentário: 
        /// </summary>
        private decimal percdesc7;
        [XmlElement(ElementName = "PERCDESC7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc7
        {
            get { return  percdesc7; }
            set {  percdesc7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC7TAB
        /// Comentário: 
        /// </summary>
        private decimal percdesc7tab;
        [XmlElement(ElementName = "PERCDESC7TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc7tab
        {
            get { return  percdesc7tab; }
            set {  percdesc7tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC8
        /// Comentário: 
        /// </summary>
        private decimal percdesc8;
        [XmlElement(ElementName = "PERCDESC8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc8
        {
            get { return  percdesc8; }
            set {  percdesc8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC8TAB
        /// Comentário: 
        /// </summary>
        private decimal percdesc8tab;
        [XmlElement(ElementName = "PERCDESC8TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc8tab
        {
            get { return  percdesc8tab; }
            set {  percdesc8tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC9
        /// Comentário: 
        /// </summary>
        private decimal percdesc9;
        [XmlElement(ElementName = "PERCDESC9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc9
        {
            get { return  percdesc9; }
            set {  percdesc9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC9TAB
        /// Comentário: 
        /// </summary>
        private decimal percdesc9tab;
        [XmlElement(ElementName = "PERCDESC9TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc9tab
        {
            get { return  percdesc9tab; }
            set {  percdesc9tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPADICIONAL
        /// Comentário: 
        /// </summary>
        private decimal percdespadicional;
        [XmlElement(ElementName = "PERCDESPADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespadicional
        {
            get { return  percdespadicional; }
            set {  percdespadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPDENTRONF
        /// Comentário: Indica o percentual de outras despesas dentro da NF.
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
        /// Comentário: 
        /// </summary>
        private decimal percdespfin;
        [XmlElement(ElementName = "PERCDESPFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespfin
        {
            get { return  percdespfin; }
            set {  percdespfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPFINTAB
        /// Comentário: 
        /// </summary>
        private decimal percdespfintab;
        [XmlElement(ElementName = "PERCDESPFINTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespfintab
        {
            get { return  percdespfintab; }
            set {  percdespfintab = value; }
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
        /// Comentário: 
        /// </summary>
        private decimal percfretefob;
        [XmlElement(ElementName = "PERCFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfretefob
        {
            get { return  percfretefob; }
            set {  percfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETEFOBTAB
        /// Comentário: 
        /// </summary>
        private decimal percfretefobtab;
        [XmlElement(ElementName = "PERCFRETEFOBTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfretefobtab
        {
            get { return  percfretefobtab; }
            set {  percfretefobtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETETAB
        /// Comentário: 
        /// </summary>
        private decimal percfretetab;
        [XmlElement(ElementName = "PERCFRETETAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfretetab
        {
            get { return  percfretetab; }
            set {  percfretetab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMRED
        /// Comentário: 
        /// </summary>
        private decimal percicmred;
        [XmlElement(ElementName = "PERCICMRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmred
        {
            get { return  percicmred; }
            set {  percicmred = value; }
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
        /// Propriedade referente ao campo: PERCIVA
        /// Comentário: 
        /// </summary>
        private decimal perciva;
        [XmlElement(ElementName = "PERCIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perciva
        {
            get { return  perciva; }
            set {  perciva = value; }
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
        /// Propriedade referente ao campo: PERICM
        /// Comentário: 
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
        /// Propriedade referente ao campo: PERICMSANTECIPADO
        /// Comentário: 
        /// </summary>
        private decimal pericmsantecipado;
        [XmlElement(ElementName = "PERICMSANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pericmsantecipado
        {
            get { return  pericmsantecipado; }
            set {  pericmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Comentário: 
        /// </summary>
        private decimal perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEALIQEXT
        /// Comentário: Será utilizado para Redução da Base de Cálculo da Aliquota Externa ref a substituição Tributária na Entrada.
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
        /// Comentário: Será utilizado para Redução da Base de Cálculo de Substituição Tributária na Entrada.
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
        /// Propriedade referente ao campo: VERBADINPORPERC
        /// Comentário: Calcular verba dinheiro por percentual
        /// </summary>
        private string verbadinporperc;
        [XmlElement(ElementName = "VERBADINPORPERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verbadinporperc
        {
            get { return  verbadinporperc; }
            set {  verbadinporperc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal vlbonific;
        [XmlElement(ElementName = "VLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbonific
        {
            get { return  vlbonific; }
            set {  vlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFICTAB
        /// Comentário: 
        /// </summary>
        private decimal vlbonifictab;
        [XmlElement(ElementName = "VLBONIFICTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbonifictab
        {
            get { return  vlbonifictab; }
            set {  vlbonifictab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIPESO
        /// Comentário: 
        /// </summary>
        private decimal vlipipeso;
        [XmlElement(ElementName = "VLIPIPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlipipeso
        {
            get { return  vlipipeso; }
            set {  vlipipeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTA
        /// Comentário: 
        /// </summary>
        private decimal vlpauta;
        [XmlElement(ElementName = "VLPAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpauta
        {
            get { return  vlpauta; }
            set {  vlpauta = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCNegfornec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNEGFORNEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNegfornec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNegfornec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCNegfornec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNegfornec>(where);
        }

        #endregion
    }
}

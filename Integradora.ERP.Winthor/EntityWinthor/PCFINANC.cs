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
    /// Classe referente a tabela PCFinanc
    /// </summary>
    [XmlType("PCFINANC")]
    public class PCFinanc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AUXTMP
        /// Coment�rio: 
        /// </summary>
        private decimal auxtmp;
        [XmlElement(ElementName = "AUXTMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Auxtmp
        {
            get { return  auxtmp; }
            set {  auxtmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CMVREAL
        /// Coment�rio: 
        /// </summary>
        private decimal cmvreal;
        [XmlElement(ElementName = "CMVREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Cmvreal
        {
            get { return  cmvreal; }
            set {  cmvreal = value; }
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
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: 
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: 
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtgeracao;
        [XmlElement(ElementName = "DTGERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgeracao
        {
            get { return  dtgeracao; }
            set {  dtgeracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMPREV
        /// Coment�rio: 
        /// </summary>
        private decimal margemprev;
        [XmlElement(ElementName = "MARGEMPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Margemprev
        {
            get { return  margemprev; }
            set {  margemprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECEBREAL
        /// Coment�rio: 
        /// </summary>
        private decimal recebreal;
        [XmlElement(ElementName = "RECEBREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Recebreal
        {
            get { return  recebreal; }
            set {  recebreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECEBREAL2
        /// Coment�rio: 
        /// </summary>
        private decimal recebreal2;
        [XmlElement(ElementName = "RECEBREAL2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Recebreal2
        {
            get { return  recebreal2; }
            set {  recebreal2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECEBREAL3
        /// Coment�rio: 
        /// </summary>
        private decimal recebreal3;
        [XmlElement(ElementName = "RECEBREAL3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Recebreal3
        {
            get { return  recebreal3; }
            set {  recebreal3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECEBREAL4
        /// Coment�rio: 
        /// </summary>
        private decimal recebreal4;
        [XmlElement(ElementName = "RECEBREAL4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Recebreal4
        {
            get { return  recebreal4; }
            set {  recebreal4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOADIANTFOR
        /// Coment�rio: 
        /// </summary>
        private decimal saldoadiantfor;
        [XmlElement(ElementName = "SALDOADIANTFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoadiantfor
        {
            get { return  saldoadiantfor; }
            set {  saldoadiantfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOAPLI
        /// Coment�rio: 
        /// </summary>
        private decimal saldoapli;
        [XmlElement(ElementName = "SALDOAPLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoapli
        {
            get { return  saldoapli; }
            set {  saldoapli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOBCO
        /// Coment�rio: 
        /// </summary>
        private decimal saldobco;
        [XmlElement(ElementName = "SALDOBCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldobco
        {
            get { return  saldobco; }
            set {  saldobco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOCHDV
        /// Coment�rio: 
        /// </summary>
        private decimal saldochdv;
        [XmlElement(ElementName = "SALDOCHDV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldochdv
        {
            get { return  saldochdv; }
            set {  saldochdv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOCP
        /// Coment�rio: 
        /// </summary>
        private decimal saldocp;
        [XmlElement(ElementName = "SALDOCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldocp
        {
            get { return  saldocp; }
            set {  saldocp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOCPMANUAL
        /// Coment�rio: Indica o saldo de contas a pagar manual. 
        /// </summary>
        private decimal saldocpmanual;
        [XmlElement(ElementName = "SALDOCPMANUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldocpmanual
        {
            get { return  saldocpmanual; }
            set {  saldocpmanual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOCPOUTROS
        /// Coment�rio: Saldo contas a pagar referente a outros fornecedores.
        /// </summary>
        private decimal saldocpoutros;
        [XmlElement(ElementName = "SALDOCPOUTROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldocpoutros
        {
            get { return  saldocpoutros; }
            set {  saldocpoutros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOCR
        /// Coment�rio: 
        /// </summary>
        private decimal saldocr;
        [XmlElement(ElementName = "SALDOCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldocr
        {
            get { return  saldocr; }
            set {  saldocr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOCREDCLI
        /// Coment�rio: 
        /// </summary>
        private decimal saldocredcli;
        [XmlElement(ElementName = "SALDOCREDCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldocredcli
        {
            get { return  saldocredcli; }
            set {  saldocredcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOCRFOR
        /// Coment�rio: 
        /// </summary>
        private decimal saldocrfor;
        [XmlElement(ElementName = "SALDOCRFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldocrfor
        {
            get { return  saldocrfor; }
            set {  saldocrfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOCTRANS
        /// Coment�rio: 
        /// </summary>
        private decimal saldoctrans;
        [XmlElement(ElementName = "SALDOCTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoctrans
        {
            get { return  saldoctrans; }
            set {  saldoctrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOCX
        /// Coment�rio: 
        /// </summary>
        private decimal saldocx;
        [XmlElement(ElementName = "SALDOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldocx
        {
            get { return  saldocx; }
            set {  saldocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDODIN
        /// Coment�rio: 
        /// </summary>
        private decimal saldodin;
        [XmlElement(ElementName = "SALDODIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldodin
        {
            get { return  saldodin; }
            set {  saldodin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOEMPRESTATIVO
        /// Coment�rio: 
        /// </summary>
        private decimal saldoemprestativo;
        [XmlElement(ElementName = "SALDOEMPRESTATIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoemprestativo
        {
            get { return  saldoemprestativo; }
            set {  saldoemprestativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOEMPRESTPASSIVO
        /// Coment�rio: 
        /// </summary>
        private decimal saldoemprestpassivo;
        [XmlElement(ElementName = "SALDOEMPRESTPASSIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoemprestpassivo
        {
            get { return  saldoemprestpassivo; }
            set {  saldoemprestpassivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOESTCONSIGVEND
        /// Coment�rio: Saldo do estoque consignado de vendas. 
        /// </summary>
        private decimal saldoestconsigvend;
        [XmlElement(ElementName = "SALDOESTCONSIGVEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoestconsigvend
        {
            get { return  saldoestconsigvend; }
            set {  saldoestconsigvend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOESTFIN
        /// Coment�rio: 
        /// </summary>
        private decimal saldoestfin;
        [XmlElement(ElementName = "SALDOESTFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoestfin
        {
            get { return  saldoestfin; }
            set {  saldoestfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOESTREAL
        /// Coment�rio: 
        /// </summary>
        private decimal saldoestreal;
        [XmlElement(ElementName = "SALDOESTREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoestreal
        {
            get { return  saldoestreal; }
            set {  saldoestreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOFIN
        /// Coment�rio: 
        /// </summary>
        private decimal saldofin;
        [XmlElement(ElementName = "SALDOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldofin
        {
            get { return  saldofin; }
            set {  saldofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOINVESTATIVO
        /// Coment�rio: 
        /// </summary>
        private decimal saldoinvestativo;
        [XmlElement(ElementName = "SALDOINVESTATIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoinvestativo
        {
            get { return  saldoinvestativo; }
            set {  saldoinvestativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOINVESTPASSIVO
        /// Coment�rio: 
        /// </summary>
        private decimal saldoinvestpassivo;
        [XmlElement(ElementName = "SALDOINVESTPASSIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoinvestpassivo
        {
            get { return  saldoinvestpassivo; }
            set {  saldoinvestpassivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOLP
        /// Coment�rio: 
        /// </summary>
        private decimal saldolp;
        [XmlElement(ElementName = "SALDOLP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldolp
        {
            get { return  saldolp; }
            set {  saldolp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOREAL
        /// Coment�rio: 
        /// </summary>
        private decimal saldoreal;
        [XmlElement(ElementName = "SALDOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoreal
        {
            get { return  saldoreal; }
            set {  saldoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOREAL2
        /// Coment�rio: Saldo real considerando saldo pendente conta a receber fornecedor. 
        /// </summary>
        private decimal saldoreal2;
        [XmlElement(ElementName = "SALDOREAL2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoreal2
        {
            get { return  saldoreal2; }
            set {  saldoreal2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOTITULOVENDOR
        /// Coment�rio: 
        /// </summary>
        private decimal saldotitulovendor;
        [XmlElement(ElementName = "SALDOTITULOVENDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldotitulovendor
        {
            get { return  saldotitulovendor; }
            set {  saldotitulovendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOVALE
        /// Coment�rio: 
        /// </summary>
        private decimal saldovale;
        [XmlElement(ElementName = "SALDOVALE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldovale
        {
            get { return  saldovale; }
            set {  saldovale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDAREAL
        /// Coment�rio: 
        /// </summary>
        private decimal vendareal;
        [XmlElement(ElementName = "VENDAREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vendareal
        {
            get { return  vendareal; }
            set {  vendareal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAPREV
        /// Coment�rio: 
        /// </summary>
        private decimal vlvendaprev;
        [XmlElement(ElementName = "VLVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlvendaprev
        {
            get { return  vlvendaprev; }
            set {  vlvendaprev = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFinanc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFINANC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFinanc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFinanc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFinanc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFinanc>(where);
        }

        #endregion
    }
}

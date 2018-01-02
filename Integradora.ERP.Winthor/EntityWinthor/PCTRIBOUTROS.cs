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
    /// Classe referente a tabela PCTriboutros
    /// </summary>
    [XmlType("PCTRIBOUTROS")]
    public class PCTriboutros : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMFRETEDEVCLI
        /// Comentário: Aliquota ICMS Frete Devolução de Cliente.
        /// </summary>
        private decimal aliqicmfretedevcli;
        [XmlElement(ElementName = "ALIQICMFRETEDEVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmfretedevcli
        {
            get { return  aliqicmfretedevcli; }
            set {  aliqicmfretedevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMFRETEDEVFORNEC
        /// Comentário: Aliquota ICMS Frete Devolução de Fornecedor.
        /// </summary>
        private decimal aliqicmfretedevfornec;
        [XmlElement(ElementName = "ALIQICMFRETEDEVFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmfretedevfornec
        {
            get { return  aliqicmfretedevfornec; }
            set {  aliqicmfretedevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMFRETEENT
        /// Comentário: Indicar a alíquota a ser utilizado para tributação do valor do valor de frete CIF informado na entrada de mercadoria. 
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
        /// Propriedade referente ao campo: ALIQICMFRETEENTFUT
        /// Comentário: Aliquota ICMS Frete Entrega Futura.
        /// </summary>
        private decimal aliqicmfreteentfut;
        [XmlElement(ElementName = "ALIQICMFRETEENTFUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmfreteentfut
        {
            get { return  aliqicmfreteentfut; }
            set {  aliqicmfreteentfut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMFRETEPFENTFUT
        /// Comentário: Aliquota ICMS Frete Pessao Física Entrega Futura.
        /// </summary>
        private decimal aliqicmfretepfentfut;
        [XmlElement(ElementName = "ALIQICMFRETEPFENTFUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmfretepfentfut
        {
            get { return  aliqicmfretepfentfut; }
            set {  aliqicmfretepfentfut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal aliqicmoutrasdesp;
        [XmlElement(ElementName = "ALIQICMOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmoutrasdesp
        {
            get { return  aliqicmoutrasdesp; }
            set {  aliqicmoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMOUTRASDESPENT
        /// Comentário: Indicar a alíquota a ser utilizado para tributação do valor de outras despesas informado na entrada de mercadoria. 
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
        /// Propriedade referente ao campo: ALIQICMOUTRASDESPPF
        /// Comentário: 
        /// </summary>
        private decimal aliqicmoutrasdesppf;
        [XmlElement(ElementName = "ALIQICMOUTRASDESPPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmoutrasdesppf
        {
            get { return  aliqicmoutrasdesppf; }
            set {  aliqicmoutrasdesppf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALNF
        /// Comentário: 
        /// </summary>
        private string codfilialnf;
        [XmlElement(ElementName = "CODFILIALNF", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilialnf
        {
            get { return  codfilialnf; }
            set {  codfilialnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevoutrasdesp;
        [XmlElement(ElementName = "CODFISCALDEVOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevoutrasdesp
        {
            get { return  codfiscaldevoutrasdesp; }
            set {  codfiscaldevoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVOUTRASDESPPF
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevoutrasdesppf;
        [XmlElement(ElementName = "CODFISCALDEVOUTRASDESPPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevoutrasdesppf
        {
            get { return  codfiscaldevoutrasdesppf; }
            set {  codfiscaldevoutrasdesppf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTSERV
        /// Comentário: Indica o CFOP a ser utilizado para entrada da nota fiscal de serviço (frete)
        /// </summary>
        private decimal codfiscalentserv;
        [XmlElement(ElementName = "CODFISCALENTSERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalentserv
        {
            get { return  codfiscalentserv; }
            set {  codfiscalentserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTSERVPF
        /// Comentário: Indica o CFOP a ser utilizado para entrada da nota fiscal de serviço (frete) para pessoa física
        /// </summary>
        private decimal codfiscalentservpf;
        [XmlElement(ElementName = "CODFISCALENTSERVPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalentservpf
        {
            get { return  codfiscalentservpf; }
            set {  codfiscalentservpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALFRETE
        /// Comentário: 
        /// </summary>
        private decimal codfiscalfrete;
        [XmlElement(ElementName = "CODFISCALFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfiscalfrete
        {
            get { return  codfiscalfrete; }
            set {  codfiscalfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALFRETEDEVCLI
        /// Comentário: CFOP Frete Devolução de Cliente.
        /// </summary>
        private decimal codfiscalfretedevcli;
        [XmlElement(ElementName = "CODFISCALFRETEDEVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalfretedevcli
        {
            get { return  codfiscalfretedevcli; }
            set {  codfiscalfretedevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALFRETEDEVFORNEC
        /// Comentário: CFOP Frete Devolução de Fornecedor.
        /// </summary>
        private decimal codfiscalfretedevfornec;
        [XmlElement(ElementName = "CODFISCALFRETEDEVFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalfretedevfornec
        {
            get { return  codfiscalfretedevfornec; }
            set {  codfiscalfretedevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALFRETEENT
        /// Comentário: Indicar CFOP a ser utilizado para tributação do valor de frete CIF informado na entrada de mercadoria 
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
        /// Propriedade referente ao campo: CODFISCALFRETEENTFUT
        /// Comentário: CFOP Frete Entrega Futura.
        /// </summary>
        private decimal codfiscalfreteentfut;
        [XmlElement(ElementName = "CODFISCALFRETEENTFUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalfreteentfut
        {
            get { return  codfiscalfreteentfut; }
            set {  codfiscalfreteentfut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALFRETEENTFUTPF
        /// Comentário: Indica o CFOP frete entrega futura PF.
        /// </summary>
        private decimal codfiscalfreteentfutpf;
        [XmlElement(ElementName = "CODFISCALFRETEENTFUTPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalfreteentfutpf
        {
            get { return  codfiscalfreteentfutpf; }
            set {  codfiscalfreteentfutpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALFRETEPF
        /// Comentário: Indica o CFOP frete PF.
        /// </summary>
        private decimal codfiscalfretepf;
        [XmlElement(ElementName = "CODFISCALFRETEPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfiscalfretepf
        {
            get { return  codfiscalfretepf; }
            set {  codfiscalfretepf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal codfiscaloutrasdesp;
        [XmlElement(ElementName = "CODFISCALOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscaloutrasdesp
        {
            get { return  codfiscaloutrasdesp; }
            set {  codfiscaloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALOUTRASDESPENT
        /// Comentário: Indicar a CFOP a ser utilizado para tributação do valor de outras despesas informado na entrada de mercadoria.
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
        /// Propriedade referente ao campo: CODFISCALOUTRASDESPPF
        /// Comentário: 
        /// </summary>
        private decimal codfiscaloutrasdesppf;
        [XmlElement(ElementName = "CODFISCALOUTRASDESPPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscaloutrasdesppf
        {
            get { return  codfiscaloutrasdesppf; }
            set {  codfiscaloutrasdesppf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDASERV
        /// Comentário: Indica o CFOP a ser utilizado para saída da nota fiscal de serviço (frete)
        /// </summary>
        private decimal codfiscalsaidaserv;
        [XmlElement(ElementName = "CODFISCALSAIDASERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalsaidaserv
        {
            get { return  codfiscalsaidaserv; }
            set {  codfiscalsaidaserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDASERVPF
        /// Comentário: Indica o CFOP a ser utilizado para saída da nota fiscal de serviço (frete) para pessoa física
        /// </summary>
        private decimal codfiscalsaidaservpf;
        [XmlElement(ElementName = "CODFISCALSAIDASERVPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalsaidaservpf
        {
            get { return  codfiscalsaidaservpf; }
            set {  codfiscalsaidaservpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBUT
        /// Comentário: Código da situação tributaria 
        /// </summary>
        private string codsittribut;
        [XmlElement(ElementName = "CODSITTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codsittribut
        {
            get { return  codsittribut; }
            set {  codsittribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CSTPISCOFINS
        /// Comentário: Código de ST do Pis/Cofins.
        /// </summary>
        private decimal cstpiscofins;
        [XmlElement(ElementName = "CSTPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Cstpiscofins
        {
            get { return  cstpiscofins; }
            set {  cstpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEREDOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal perbaseredoutrasdesp;
        [XmlElement(ElementName = "PERBASEREDOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perbaseredoutrasdesp
        {
            get { return  perbaseredoutrasdesp; }
            set {  perbaseredoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEREDOUTRASDESPPF
        /// Comentário: Percentual de redução da base de ICMS de outras despt. para PF.
        /// </summary>
        private decimal perbaseredoutrasdesppf;
        [XmlElement(ElementName = "PERBASEREDOUTRASDESPPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perbaseredoutrasdesppf
        {
            get { return  perbaseredoutrasdesppf; }
            set {  perbaseredoutrasdesppf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOFINS
        /// Comentário: Percentual de cofins.
        /// </summary>
        private decimal perccofins;
        [XmlElement(ElementName = "PERCCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perccofins
        {
            get { return  perccofins; }
            set {  perccofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMFRETE
        /// Comentário: 
        /// </summary>
        private decimal percicmfrete;
        [XmlElement(ElementName = "PERCICMFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percicmfrete
        {
            get { return  percicmfrete; }
            set {  percicmfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMFRETEPF
        /// Comentário: 
        /// </summary>
        private decimal percicmfretepf;
        [XmlElement(ElementName = "PERCICMFRETEPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percicmfretepf
        {
            get { return  percicmfretepf; }
            set {  percicmfretepf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCISS
        /// Comentário: Percentual de ISS saída.
        /// </summary>
        private decimal perciss;
        [XmlElement(ElementName = "PERCISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perciss
        {
            get { return  perciss; }
            set {  perciss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPIS
        /// Comentário: Percentual de Pis.
        /// </summary>
        private decimal percpis;
        [XmlElement(ElementName = "PERCPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percpis
        {
            get { return  percpis; }
            set {  percpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSERVPREST
        /// Comentário: Perc. Repres. Incidentes form. Vlr serv. Prest.
        /// </summary>
        private decimal percservprest;
        [XmlElement(ElementName = "PERCSERVPREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percservprest
        {
            get { return  percservprest; }
            set {  percservprest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERREDUCBASEICMSFRETE
        /// Comentário: Percentual de reducao da base de icms de frete
        /// </summary>
        private decimal perreducbaseicmsfrete;
        [XmlElement(ElementName = "PERREDUCBASEICMSFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perreducbaseicmsfrete
        {
            get { return  perreducbaseicmsfrete; }
            set {  perreducbaseicmsfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Comentário: Código da situação tributária para as operações de saida de frete (conhecimento de transporte)
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
        /// Propriedade referente ao campo: UFDESTINO
        /// Comentário: 
        /// </summary>
        private string ufdestino;
        [XmlElement(ElementName = "UFDESTINO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Ufdestino
        {
            get { return  ufdestino; }
            set {  ufdestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ZERARICMSCONTRIBUINTE
        /// Comentário: Zerar o ICMS para o cliente de outro estado que, contribuinte com inscrição estadual
        /// </summary>
        private string zeraricmscontribuinte;
        [XmlElement(ElementName = "ZERARICMSCONTRIBUINTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Zeraricmscontribuinte
        {
            get { return  zeraricmscontribuinte; }
            set {  zeraricmscontribuinte = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTriboutros()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRIBOUTROS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTriboutros> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTriboutros>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTriboutros> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTriboutros>(where);
        }

        #endregion
    }
}

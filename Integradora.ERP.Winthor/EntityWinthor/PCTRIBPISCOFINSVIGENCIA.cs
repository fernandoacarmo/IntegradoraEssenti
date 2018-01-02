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
    /// Classe referente a tabela PCTribpiscofinsvigencia
    /// </summary>
    [XmlType("PCTRIBPISCOFINSVIGENCIA")]
    public class PCTribpiscofinsvigencia : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BASEPISCOFINSLIT
        /// Coment�rio: Base PIS/COFINS Litragem
        /// </summary>
        private decimal basepiscofinslit;
        [XmlElement(ElementName = "BASEPISCOFINSLIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basepiscofinslit
        {
            get { return  basepiscofinslit; }
            set {  basepiscofinslit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBPISCOFINS
        /// Coment�rio: C�digo da figura tribut�ria
        /// </summary>
        private decimal codtribpiscofins;
        [XmlElement(ElementName = "CODTRIBPISCOFINS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codtribpiscofins
        {
            get { return  codtribpiscofins; }
            set {  codtribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERADIFALIQ
        /// Coment�rio: Considera Diferencial Al�quota
        /// </summary>
        private string consideradifaliq;
        [XmlElement(ElementName = "CONSIDERADIFALIQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideradifaliq
        {
            get { return  consideradifaliq; }
            set {  consideradifaliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERADIFALIQUOTA
        /// Coment�rio: Considerar Dif. Al�quota
        /// </summary>
        private string consideradifaliquota;
        [XmlElement(ElementName = "CONSIDERADIFALIQUOTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideradifaliquota
        {
            get { return  consideradifaliquota; }
            set {  consideradifaliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERAFRETE
        /// Coment�rio: Considera Frete lan�ado na Nota Fiscal
        /// </summary>
        private string considerafrete;
        [XmlElement(ElementName = "CONSIDERAFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerafrete
        {
            get { return  considerafrete; }
            set {  considerafrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERAIPI
        /// Coment�rio: Considera IPI
        /// </summary>
        private string consideraipi;
        [XmlElement(ElementName = "CONSIDERAIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideraipi
        {
            get { return  consideraipi; }
            set {  consideraipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERAOUTRASDESP
        /// Coment�rio: Considera Outras despesas
        /// </summary>
        private string consideraoutrasdesp;
        [XmlElement(ElementName = "CONSIDERAOUTRASDESP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideraoutrasdesp
        {
            get { return  consideraoutrasdesp; }
            set {  consideraoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERAPAUTA
        /// Coment�rio: Considera Pauta
        /// </summary>
        private string considerapauta;
        [XmlElement(ElementName = "CONSIDERAPAUTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerapauta
        {
            get { return  considerapauta; }
            set {  considerapauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERAPRECOMERC
        /// Coment�rio: Considera Pre�o
        /// </summary>
        private string consideraprecomerc;
        [XmlElement(ElementName = "CONSIDERAPRECOMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideraprecomerc
        {
            get { return  consideraprecomerc; }
            set {  consideraprecomerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERAST
        /// Coment�rio: Considera ST
        /// </summary>
        private string considerast;
        [XmlElement(ElementName = "CONSIDERAST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerast
        {
            get { return  considerast; }
            set {  considerast = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERASUFRAMA
        /// Coment�rio: Considera Deduzir valor do Suframa
        /// </summary>
        private string considerasuframa;
        [XmlElement(ElementName = "CONSIDERASUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerasuframa
        {
            get { return  considerasuframa; }
            set {  considerasuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERAVLFIXOLIT
        /// Coment�rio: Considera Valor Fixo (Litragem)
        /// </summary>
        private string consideravlfixolit;
        [XmlElement(ElementName = "CONSIDERAVLFIXOLIT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideravlfixolit
        {
            get { return  consideravlfixolit; }
            set {  consideravlfixolit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOTRIBPISCOFINS
        /// Coment�rio: Descri��o Tributa��o PIS/COFINS
        /// </summary>
        private string descricaotribpiscofins;
        [XmlElement(ElementName = "DESCRICAOTRIBPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricaotribpiscofins
        {
            get { return  descricaotribpiscofins; }
            set {  descricaotribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINAL
        /// Coment�rio: Data de final da vig�ncia
        /// </summary>
        private DateTime? dtfinal;
        [XmlElement(ElementName = "DTFINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtfinal
        {
            get { return  dtfinal; }
            set {  dtfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: Data de inicio da vig�ncia
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERABASEPISCOFINSSEMALIQ
        /// Coment�rio: Gera a base do PIS/COFINS sem al�quota
        /// </summary>
        private string gerabasepiscofinssemaliq;
        [XmlElement(ElementName = "GERABASEPISCOFINSSEMALIQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerabasepiscofinssemaliq
        {
            get { return  gerabasepiscofinssemaliq; }
            set {  gerabasepiscofinssemaliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEMCONSUMO
        /// Coment�rio: Mensagem para consumo
        /// </summary>
        private string mensagemconsumo;
        [XmlElement(ElementName = "MENSAGEMCONSUMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Mensagemconsumo
        {
            get { return  mensagemconsumo; }
            set {  mensagemconsumo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEMGERAL
        /// Coment�rio: Mensagem de Informa��es Gerais
        /// </summary>
        private string mensagemgeral;
        [XmlElement(ElementName = "MENSAGEMGERAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Mensagemgeral
        {
            get { return  mensagemgeral; }
            set {  mensagemgeral = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOFINS
        /// Coment�rio: Percentual COFINS
        /// </summary>
        private decimal perccofins;
        [XmlElement(ElementName = "PERCCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perccofins
        {
            get { return  perccofins; }
            set {  perccofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOFINSCALCDI
        /// Coment�rio: Percentual COFINS para c�lculo DI
        /// </summary>
        private decimal perccofinscalcdi;
        [XmlElement(ElementName = "PERCCOFINSCALCDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perccofinscalcdi
        {
            get { return  perccofinscalcdi; }
            set {  perccofinscalcdi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOFINSCONSUMO
        /// Coment�rio: Percentual COFINS para consumo
        /// </summary>
        private decimal perccofinsconsumo;
        [XmlElement(ElementName = "PERCCOFINSCONSUMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perccofinsconsumo
        {
            get { return  perccofinsconsumo; }
            set {  perccofinsconsumo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPIS
        /// Coment�rio: Percentual PIS
        /// </summary>
        private decimal percpis;
        [XmlElement(ElementName = "PERCPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percpis
        {
            get { return  percpis; }
            set {  percpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPISCALCDI
        /// Coment�rio: Percentual PIS para C�lculo DI
        /// </summary>
        private decimal percpiscalcdi;
        [XmlElement(ElementName = "PERCPISCALCDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percpiscalcdi
        {
            get { return  percpiscalcdi; }
            set {  percpiscalcdi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPISCONSUMO
        /// Coment�rio: Percentual PIS para consumo
        /// </summary>
        private decimal percpisconsumo;
        [XmlElement(ElementName = "PERCPISCONSUMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percpisconsumo
        {
            get { return  percpisconsumo; }
            set {  percpisconsumo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RETERPISCOFINS
        /// Coment�rio: Valor a ser retido do pre�o da mercadoria (Deduzido)
        /// </summary>
        private string reterpiscofins;
        [XmlElement(ElementName = "RETERPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reterpiscofins
        {
            get { return  reterpiscofins; }
            set {  reterpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Coment�rio: C�digo Situa��o Tribut�ria
        /// </summary>
        private decimal sittribut;
        [XmlElement(ElementName = "SITTRIBUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Sittribut
        {
            get { return  sittribut; }
            set {  sittribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTCONSUMO
        /// Coment�rio: C�digo CST para consumo
        /// </summary>
        private decimal sittributconsumo;
        [XmlElement(ElementName = "SITTRIBUTCONSUMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Sittributconsumo
        {
            get { return  sittributconsumo; }
            set {  sittributconsumo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTCONSUMODEV
        /// Coment�rio: CST PIS/COFINS Consumo
        /// </summary>
        private decimal sittributconsumodev;
        [XmlElement(ElementName = "SITTRIBUTCONSUMODEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Sittributconsumodev
        {
            get { return  sittributconsumodev; }
            set {  sittributconsumodev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTDEV
        /// Coment�rio: Cod. Situ��o Tribut�ria do PIS/COFINS
        /// </summary>
        private decimal sittributdev;
        [XmlElement(ElementName = "SITTRIBUTDEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Sittributdev
        {
            get { return  sittributdev; }
            set {  sittributdev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPERCPISCOFINSDIFCONS
        /// Coment�rio: Utiliza percentuais diferentes de PIS/COFINS para venda consumo
        /// </summary>
        private string utilizapercpiscofinsdifcons;
        [XmlElement(ElementName = "UTILIZAPERCPISCOFINSDIFCONS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizapercpiscofinsdifcons
        {
            get { return  utilizapercpiscofinsdifcons; }
            set {  utilizapercpiscofinsdifcons = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINSLIT
        /// Coment�rio: Valor COFINS Litragem
        /// </summary>
        private decimal vlcofinslit;
        [XmlElement(ElementName = "VLCOFINSLIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcofinslit
        {
            get { return  vlcofinslit; }
            set {  vlcofinslit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTACOFINS
        /// Coment�rio: Valor da Pauta do COFINS
        /// </summary>
        private decimal vlpautacofins;
        [XmlElement(ElementName = "VLPAUTACOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautacofins
        {
            get { return  vlpautacofins; }
            set {  vlpautacofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAPIS
        /// Coment�rio: Valor da Pauta do PIS
        /// </summary>
        private decimal vlpautapis;
        [XmlElement(ElementName = "VLPAUTAPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautapis
        {
            get { return  vlpautapis; }
            set {  vlpautapis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPISLIT
        /// Coment�rio: Valor PIS Litragem
        /// </summary>
        private decimal vlpislit;
        [XmlElement(ElementName = "VLPISLIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpislit
        {
            get { return  vlpislit; }
            set {  vlpislit = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCTribpiscofinsvigencia()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRIBPISCOFINSVIGENCIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCTribpiscofinsvigencia> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTribpiscofinsvigencia>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCTribpiscofinsvigencia> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTribpiscofinsvigencia>(where);
        }

        #endregion
    }
}

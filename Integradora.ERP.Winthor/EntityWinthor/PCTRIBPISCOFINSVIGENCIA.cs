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
        /// Comentário: Base PIS/COFINS Litragem
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
        /// Comentário: Código da figura tributúria
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
        /// Comentário: Considera Diferencial Alíquota
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
        /// Comentário: Considerar Dif. Alíquota
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
        /// Comentário: Considera Frete lançado na Nota Fiscal
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
        /// Comentário: Considera IPI
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
        /// Comentário: Considera Outras despesas
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
        /// Comentário: Considera Pauta
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
        /// Comentário: Considera Preço
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
        /// Comentário: Considera ST
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
        /// Comentário: Considera Deduzir valor do Suframa
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
        /// Comentário: Considera Valor Fixo (Litragem)
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
        /// Comentário: Descrição Tributação PIS/COFINS
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
        /// Comentário: Data de final da vigência
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
        /// Comentário: Data de inicio da vigência
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
        /// Comentário: Gera a base do PIS/COFINS sem alíquota
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
        /// Comentário: Mensagem para consumo
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
        /// Comentário: Mensagem de Informações Gerais
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
        /// Comentário: Percentual COFINS
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
        /// Comentário: Percentual COFINS para cálculo DI
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
        /// Comentário: Percentual COFINS para consumo
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
        /// Comentário: Percentual PIS
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
        /// Comentário: Percentual PIS para Cálculo DI
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
        /// Comentário: Percentual PIS para consumo
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
        /// Comentário: Valor a ser retido do preço da mercadoria (Deduzido)
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
        /// Comentário: Código Situação Tributúria
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
        /// Comentário: Código CST para consumo
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
        /// Comentário: CST PIS/COFINS Consumo
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
        /// Comentário: Cod. Situção Tributária do PIS/COFINS
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
        /// Comentário: Utiliza percentuais diferentes de PIS/COFINS para venda consumo
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
        /// Comentário: Valor COFINS Litragem
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
        /// Comentário: Valor da Pauta do COFINS
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
        /// Comentário: Valor da Pauta do PIS
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
        /// Comentário: Valor PIS Litragem
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTribpiscofinsvigencia> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTribpiscofinsvigencia>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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

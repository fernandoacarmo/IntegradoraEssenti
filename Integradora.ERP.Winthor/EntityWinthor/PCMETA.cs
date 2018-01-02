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
    /// Classe referente a tabela PCMeta
    /// </summary>
    [XmlType("PCMETA")]
    public class PCMeta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AMORTIZACAOEFETIVIDADE
        /// Coment�rio: Percentual lan�ado para amortizar carteira efetividade semanal.
        /// </summary>
        private decimal amortizacaoefetividade;
        [XmlElement(ElementName = "AMORTIZACAOEFETIVIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Amortizacaoefetividade
        {
            get { return  amortizacaoefetividade; }
            set {  amortizacaoefetividade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLICADPREV
        /// Coment�rio: Indica a meta de clientes cadastrados.
        /// </summary>
        private decimal clicadprev;
        [XmlElement(ElementName = "CLICADPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Clicadprev
        {
            get { return  clicadprev; }
            set {  clicadprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIPOSPREV
        /// Coment�rio: 
        /// </summary>
        private decimal cliposprev;
        [XmlElement(ElementName = "CLIPOSPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Cliposprev
        {
            get { return  cliposprev; }
            set {  cliposprev = value; }
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
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO2
        /// Coment�rio: Indica o segundo c�digo da meta relacionada.
        /// </summary>
        private decimal codigo2;
        [XmlElement(ElementName = "CODIGO2", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codigo2
        {
            get { return  codigo2; }
            set {  codigo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROMOCAO
        /// Coment�rio: 
        /// </summary>
        private decimal codpromocao;
        [XmlElement(ElementName = "CODPROMOCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpromocao
        {
            get { return  codpromocao; }
            set {  codpromocao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
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
        /// Propriedade referente ao campo: DESCVLVENDAPREV
        /// Coment�rio: Indica o % desconto na meta de valor de venda.
        /// </summary>
        private decimal descvlvendaprev;
        [XmlElement(ElementName = "DESCVLVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Descvlvendaprev
        {
            get { return  descvlvendaprev; }
            set {  descvlvendaprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFETIVIDADEBISSEMANAL
        /// Coment�rio: Indica a freq��ncia de visita bissemanal esperada.
        /// </summary>
        private decimal efetividadebissemanal;
        [XmlElement(ElementName = "EFETIVIDADEBISSEMANAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Efetividadebissemanal
        {
            get { return  efetividadebissemanal; }
            set {  efetividadebissemanal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFETIVIDADEDIARIA
        /// Coment�rio: Indica a freq��ncia de visita di�ria esperada.
        /// </summary>
        private decimal efetividadediaria;
        [XmlElement(ElementName = "EFETIVIDADEDIARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Efetividadediaria
        {
            get { return  efetividadediaria; }
            set {  efetividadediaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFETIVIDADEPREV
        /// Coment�rio: Indica meta de efetividade.
        /// </summary>
        private decimal efetividadeprev;
        [XmlElement(ElementName = "EFETIVIDADEPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Efetividadeprev
        {
            get { return  efetividadeprev; }
            set {  efetividadeprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFETIVIDADESEM1PREV
        /// Coment�rio: Indica a meta de efetividade com 1 semana.
        /// </summary>
        private decimal efetividadesem1prev;
        [XmlElement(ElementName = "EFETIVIDADESEM1PREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Efetividadesem1prev
        {
            get { return  efetividadesem1prev; }
            set {  efetividadesem1prev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFETIVIDADESEM2PREV
        /// Coment�rio: Indica a efetividade 2 semanas(quinzenal).
        /// </summary>
        private decimal efetividadesem2prev;
        [XmlElement(ElementName = "EFETIVIDADESEM2PREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Efetividadesem2prev
        {
            get { return  efetividadesem2prev; }
            set {  efetividadesem2prev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFETIVIDADESEM3PREV
        /// Coment�rio: Indica a meta de efetividade com 3 semanas.
        /// </summary>
        private decimal efetividadesem3prev;
        [XmlElement(ElementName = "EFETIVIDADESEM3PREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Efetividadesem3prev
        {
            get { return  efetividadesem3prev; }
            set {  efetividadesem3prev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFETIVIDADESEM4PREV
        /// Coment�rio: Indica a efetividade 4 semanas(semanal).
        /// </summary>
        private decimal efetividadesem4prev;
        [XmlElement(ElementName = "EFETIVIDADESEM4PREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Efetividadesem4prev
        {
            get { return  efetividadesem4prev; }
            set {  efetividadesem4prev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFETIVIDADEZEROPREV
        /// Coment�rio: Indica meta sem efetividade (resto ou desconto de meta.
        /// </summary>
        private decimal efetividadezeroprev;
        [XmlElement(ElementName = "EFETIVIDADEZEROPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Efetividadezeroprev
        {
            get { return  efetividadezeroprev; }
            set {  efetividadezeroprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMPREV
        /// Coment�rio: Indica o percentual lucro meta.
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
        /// Propriedade referente ao campo: MEDIAITENSCLIPREV
        /// Coment�rio: Indica a m�dia de itens/cliente esperada.
        /// </summary>
        private decimal mediaitenscliprev;
        [XmlElement(ElementName = "MEDIAITENSCLIPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Mediaitenscliprev
        {
            get { return  mediaitenscliprev; }
            set {  mediaitenscliprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MIXMEDIOPREV
        /// Coment�rio: Mix m�dio Previsto.
        /// </summary>
        private decimal mixmedioprev;
        [XmlElement(ElementName = "MIXMEDIOPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Mixmedioprev
        {
            get { return  mixmedioprev; }
            set {  mixmedioprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MIXPREV
        /// Coment�rio: 
        /// </summary>
        private decimal mixprev;
        [XmlElement(ElementName = "MIXPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Mixprev
        {
            get { return  mixprev; }
            set {  mixprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDIDOSPREV
        /// Coment�rio: Indica a meta de pedidos/dia.
        /// </summary>
        private decimal pedidosprev;
        [XmlElement(ElementName = "PEDIDOSPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pedidosprev
        {
            get { return  pedidosprev; }
            set {  pedidosprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCLIPOSPREV
        /// Coment�rio: Percentual de clientes positivados.
        /// </summary>
        private decimal percliposprev;
        [XmlElement(ElementName = "PERCLIPOSPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percliposprev
        {
            get { return  percliposprev; }
            set {  percliposprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCRATEIO
        /// Coment�rio: Percentual de rateio entre RCA.
        /// </summary>
        private decimal percrateio;
        [XmlElement(ElementName = "PERCRATEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percrateio
        {
            get { return  percrateio; }
            set {  percrateio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERINADIMPPREV
        /// Coment�rio: Indica o percentual de inadimpl�ncia.
        /// </summary>
        private decimal perinadimpprev;
        [XmlElement(ElementName = "PERINADIMPPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perinadimpprev
        {
            get { return  perinadimpprev; }
            set {  perinadimpprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERQTDEVOLPREV
        /// Coment�rio: Indica o percentual de quant. devolvida esperado.
        /// </summary>
        private decimal perqtdevolprev;
        [XmlElement(ElementName = "PERQTDEVOLPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perqtdevolprev
        {
            get { return  perqtdevolprev; }
            set {  perqtdevolprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERVLDESCONTOPREV
        /// Coment�rio: Percentual de desconto previsto.
        /// </summary>
        private decimal pervldescontoprev;
        [XmlElement(ElementName = "PERVLDESCONTOPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pervldescontoprev
        {
            get { return  pervldescontoprev; }
            set {  pervldescontoprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERVLDEVOLPREV
        /// Coment�rio: Indica o percentual de devolu��o esperado.
        /// </summary>
        private decimal pervldevolprev;
        [XmlElement(ElementName = "PERVLDEVOLPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pervldevolprev
        {
            get { return  pervldevolprev; }
            set {  pervldevolprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIOPREV
        /// Coment�rio: Indica o prazo m�dio esperado.
        /// </summary>
        private decimal prazomedioprev;
        [XmlElement(ElementName = "PRAZOMEDIOPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomedioprev
        {
            get { return  prazomedioprev; }
            set {  prazomedioprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMEDIOKGPREV
        /// Coment�rio: Indica o pre�o m�dio/Kg esperado.
        /// </summary>
        private decimal precomediokgprev;
        [XmlElement(ElementName = "PRECOMEDIOKGPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precomediokgprev
        {
            get { return  precomediokgprev; }
            set {  precomediokgprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMEDIOPREV
        /// Coment�rio: Indica o pre�o m�dio esperado.
        /// </summary>
        private decimal precomedioprev;
        [XmlElement(ElementName = "PRECOMEDIOPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precomedioprev
        {
            get { return  precomedioprev; }
            set {  precomedioprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDCLIENTESATIVO
        /// Coment�rio: Qtd. De clientes ativos na data da inclus�o.
        /// </summary>
        private decimal qtdclientesativo;
        [XmlElement(ElementName = "QTDCLIENTESATIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtdclientesativo
        {
            get { return  qtdclientesativo; }
            set {  qtdclientesativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMEDIAITENS
        /// Coment�rio: Indica a meta de m�dia de itens por pedido.
        /// </summary>
        private decimal qtmediaitens;
        [XmlElement(ElementName = "QTMEDIAITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtmediaitens
        {
            get { return  qtmediaitens; }
            set {  qtmediaitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMETROSPREV
        /// Coment�rio: Indica a quantidade de metros previstos.
        /// </summary>
        private decimal qtmetrosprev;
        [XmlElement(ElementName = "QTMETROSPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtmetrosprev
        {
            get { return  qtmetrosprev; }
            set {  qtmetrosprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPESOPREV
        /// Coment�rio: 
        /// </summary>
        private decimal qtpesoprev;
        [XmlElement(ElementName = "QTPESOPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtpesoprev
        {
            get { return  qtpesoprev; }
            set {  qtpesoprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAFOCOPREV
        /// Coment�rio: Indica a meta de quant. venda por cliente foco.
        /// </summary>
        private decimal qtvendafocoprev;
        [XmlElement(ElementName = "QTVENDAFOCOPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtvendafocoprev
        {
            get { return  qtvendafocoprev; }
            set {  qtvendafocoprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAINVESTPREV
        /// Coment�rio: Indica a meta de quant. venda por cliente.
        /// </summary>
        private decimal qtvendainvestprev;
        [XmlElement(ElementName = "QTVENDAINVESTPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtvendainvestprev
        {
            get { return  qtvendainvestprev; }
            set {  qtvendainvestprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAPREV
        /// Coment�rio: 
        /// </summary>
        private decimal qtvendaprev;
        [XmlElement(ElementName = "QTVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtvendaprev
        {
            get { return  qtvendaprev; }
            set {  qtvendaprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Coment�rio: Rotina lan�amento.
        /// </summary>
        private decimal rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEGURADA
        /// Coment�rio: Indica carga segurada.
        /// </summary>
        private string segurada;
        [XmlElement(ElementName = "SEGURADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Segurada
        {
            get { return  segurada; }
            set {  segurada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMETA
        /// Coment�rio: 
        /// </summary>
        private string tipometa;
        [XmlElement(ElementName = "TIPOMETA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Tipometa
        {
            get { return  tipometa; }
            set {  tipometa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEDIOITEM
        /// Coment�rio: Indica a meta de valor m�dio de item.
        /// </summary>
        private decimal vlmedioitem;
        [XmlElement(ElementName = "VLMEDIOITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmedioitem
        {
            get { return  vlmedioitem; }
            set {  vlmedioitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEDIOPEDIDO
        /// Coment�rio: Indica a meta de valor m�dio de pedido.
        /// </summary>
        private decimal vlmediopedido;
        [XmlElement(ElementName = "VLMEDIOPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmediopedido
        {
            get { return  vlmediopedido; }
            set {  vlmediopedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEDIOPEDIDOSDIA
        /// Coment�rio: Indica a meta de valor m�dio de pedidos/dia.
        /// </summary>
        private decimal vlmediopedidosdia;
        [XmlElement(ElementName = "VLMEDIOPEDIDOSDIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmediopedidosdia
        {
            get { return  vlmediopedidosdia; }
            set {  vlmediopedidosdia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINVENDAPOS
        /// Coment�rio: Indica o valor m�nimode venda.
        /// </summary>
        private decimal vlminvendapos;
        [XmlElement(ElementName = "VLMINVENDAPOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlminvendapos
        {
            get { return  vlminvendapos; }
            set {  vlminvendapos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAFOCOPREV
        /// Coment�rio: Indica a meta de valor venda por cliente foco.
        /// </summary>
        private decimal vlvendafocoprev;
        [XmlElement(ElementName = "VLVENDAFOCOPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendafocoprev
        {
            get { return  vlvendafocoprev; }
            set {  vlvendafocoprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAINVESTPREV
        /// Coment�rio: Indica a meta de valor venda por cliente investimento.
        /// </summary>
        private decimal vlvendainvestprev;
        [XmlElement(ElementName = "VLVENDAINVESTPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendainvestprev
        {
            get { return  vlvendainvestprev; }
            set {  vlvendainvestprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAPREV
        /// Coment�rio: 
        /// </summary>
        private decimal vlvendaprev;
        [XmlElement(ElementName = "VLVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvendaprev
        {
            get { return  vlvendaprev; }
            set {  vlvendaprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUMEPREV
        /// Coment�rio: 
        /// </summary>
        private decimal volumeprev;
        [XmlElement(ElementName = "VOLUMEPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Volumeprev
        {
            get { return  volumeprev; }
            set {  volumeprev = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMeta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMETA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMeta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMeta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMeta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMeta>(where);
        }

        #endregion
    }
}

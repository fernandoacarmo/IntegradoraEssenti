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
    /// Classe referente a tabela PCPprodutospropostas
    /// </summary>
    [XmlType("PCPPRODUTOSPROPOSTAS")]
    public class PCPprodutospropostas : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEDITAL
        /// Comentário: Códigoedital.
        /// </summary>
        private decimal codedital;
        [XmlElement(ElementName = "CODEDITAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Codedital
        {
            get { return  codedital; }
            set {  codedital = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Códigoproduto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTO_NO_EMPENHO
        /// Comentário: Custonoempenho.
        /// </summary>
        private decimal custo_no_empenho;
        [XmlElement(ElementName = "CUSTO_NO_EMPENHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custo_No_Empenho
        {
            get { return  custo_no_empenho; }
            set {  custo_no_empenho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMPENHADO
        /// Comentário: Empenhado.
        /// </summary>
        private string empenhado;
        [XmlElement(ElementName = "EMPENHADO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Empenhado
        {
            get { return  empenhado; }
            set {  empenhado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GANHOU_LICITACAO
        /// Comentário: Ganhoulicitação.
        /// </summary>
        private string ganhou_licitacao;
        [XmlElement(ElementName = "GANHOU_LICITACAO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ganhou_Licitacao
        {
            get { return  ganhou_licitacao; }
            set {  ganhou_licitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOTE
        /// Comentário: Lote.
        /// </summary>
        private string lote;
        [XmlElement(ElementName = "LOTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public string Lote
        {
            get { return  lote; }
            set {  lote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO_ITEM
        /// Comentário: Numerodoitem.
        /// </summary>
        private decimal numero_item;
        [XmlElement(ElementName = "NUMERO_ITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Numero_Item
        {
            get { return  numero_item; }
            set {  numero_item = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_EMPENHO
        /// Comentário: Observaçãodeempenho.
        /// </summary>
        private string observacao_empenho;
        [XmlElement(ElementName = "OBSERVACAO_EMPENHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Observacao_Empenho
        {
            get { return  observacao_empenho; }
            set {  observacao_empenho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_COFINS
        /// Comentário: Percentualcofins.
        /// </summary>
        private decimal percentual_cofins;
        [XmlElement(ElementName = "PERCENTUAL_COFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Cofins
        {
            get { return  percentual_cofins; }
            set {  percentual_cofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_COMISSAO
        /// Comentário: Percentualcomissão.
        /// </summary>
        private decimal percentual_comissao;
        [XmlElement(ElementName = "PERCENTUAL_COMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Comissao
        {
            get { return  percentual_comissao; }
            set {  percentual_comissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_CONTRIBUICAO_SOCIAL
        /// Comentário: Percentualcontribuiçãosocial.
        /// </summary>
        private decimal percentual_contribuicao_social;
        [XmlElement(ElementName = "PERCENTUAL_CONTRIBUICAO_SOCIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Contribuicao_Social
        {
            get { return  percentual_contribuicao_social; }
            set {  percentual_contribuicao_social = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_CPMF
        /// Comentário: PercentualCPMF.
        /// </summary>
        private decimal percentual_cpmf;
        [XmlElement(ElementName = "PERCENTUAL_CPMF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Cpmf
        {
            get { return  percentual_cpmf; }
            set {  percentual_cpmf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_CUSTO_FIXO
        /// Comentário: Percentualcustofixo.
        /// </summary>
        private decimal percentual_custo_fixo;
        [XmlElement(ElementName = "PERCENTUAL_CUSTO_FIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Custo_Fixo
        {
            get { return  percentual_custo_fixo; }
            set {  percentual_custo_fixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_DESCONTO_COMPRA
        /// Comentário: Percentualdescontocompra.
        /// </summary>
        private decimal percentual_desconto_compra;
        [XmlElement(ElementName = "PERCENTUAL_DESCONTO_COMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Desconto_Compra
        {
            get { return  percentual_desconto_compra; }
            set {  percentual_desconto_compra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_FRETE
        /// Comentário: Percentualfrete.
        /// </summary>
        private decimal percentual_frete;
        [XmlElement(ElementName = "PERCENTUAL_FRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Frete
        {
            get { return  percentual_frete; }
            set {  percentual_frete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_FRETE_VENDA
        /// Comentário: Percentualfretevenda.
        /// </summary>
        private decimal percentual_frete_venda;
        [XmlElement(ElementName = "PERCENTUAL_FRETE_VENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Frete_Venda
        {
            get { return  percentual_frete_venda; }
            set {  percentual_frete_venda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_ICMS_COMPRA
        /// Comentário: PercentualICMScompra.
        /// </summary>
        private decimal percentual_icms_compra;
        [XmlElement(ElementName = "PERCENTUAL_ICMS_COMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Icms_Compra
        {
            get { return  percentual_icms_compra; }
            set {  percentual_icms_compra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_ICMS_VENDA
        /// Comentário: PercentualICMSvenda.
        /// </summary>
        private decimal percentual_icms_venda;
        [XmlElement(ElementName = "PERCENTUAL_ICMS_VENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Icms_Venda
        {
            get { return  percentual_icms_venda; }
            set {  percentual_icms_venda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_IPI
        /// Comentário: PercentualIPI.
        /// </summary>
        private decimal percentual_ipi;
        [XmlElement(ElementName = "PERCENTUAL_IPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Ipi
        {
            get { return  percentual_ipi; }
            set {  percentual_ipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_IR
        /// Comentário: PercentualIR.
        /// </summary>
        private decimal percentual_ir;
        [XmlElement(ElementName = "PERCENTUAL_IR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Ir
        {
            get { return  percentual_ir; }
            set {  percentual_ir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_LUCRO
        /// Comentário: Percentualdelucro.
        /// </summary>
        private decimal percentual_lucro;
        [XmlElement(ElementName = "PERCENTUAL_LUCRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Lucro
        {
            get { return  percentual_lucro; }
            set {  percentual_lucro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_PIS
        /// Comentário: PercentualPIS.
        /// </summary>
        private decimal percentual_pis;
        [XmlElement(ElementName = "PERCENTUAL_PIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Pis
        {
            get { return  percentual_pis; }
            set {  percentual_pis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_REPASSE_COMPRA
        /// Comentário: Percentualrepassecompra.
        /// </summary>
        private decimal percentual_repasse_compra;
        [XmlElement(ElementName = "PERCENTUAL_REPASSE_COMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Repasse_Compra
        {
            get { return  percentual_repasse_compra; }
            set {  percentual_repasse_compra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL_RETENCAO
        /// Comentário: Percentualretenção.
        /// </summary>
        private decimal percentual_retencao;
        [XmlElement(ElementName = "PERCENTUAL_RETENCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentual_Retencao
        {
            get { return  percentual_retencao; }
            set {  percentual_retencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECO_COMPRA
        /// Comentário: Preçocompra.
        /// </summary>
        private decimal preco_compra;
        [XmlElement(ElementName = "PRECO_COMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Preco_Compra
        {
            get { return  preco_compra; }
            set {  preco_compra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECO_INICIAL
        /// Comentário: Preçoinicial.
        /// </summary>
        private decimal preco_inicial;
        [XmlElement(ElementName = "PRECO_INICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Preco_Inicial
        {
            get { return  preco_inicial; }
            set {  preco_inicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECO_MINIMO
        /// Comentário: Preçominimo.
        /// </summary>
        private decimal preco_minimo;
        [XmlElement(ElementName = "PRECO_MINIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Preco_Minimo
        {
            get { return  preco_minimo; }
            set {  preco_minimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECO_VENDA
        /// Comentário: Preçovenda.
        /// </summary>
        private decimal preco_venda;
        [XmlElement(ElementName = "PRECO_VENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Preco_Venda
        {
            get { return  preco_venda; }
            set {  preco_venda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTD_ACRESCIMO_EMPENHO
        /// Comentário: Quantidadeacrescimodeempenho.
        /// </summary>
        private decimal qtd_acrescimo_empenho;
        [XmlElement(ElementName = "QTD_ACRESCIMO_EMPENHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtd_Acrescimo_Empenho
        {
            get { return  qtd_acrescimo_empenho; }
            set {  qtd_acrescimo_empenho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO_PRECO
        /// Comentário: Tipopreço.
        /// </summary>
        private string tipo_preco;
        [XmlElement(ElementName = "TIPO_PRECO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipo_Preco
        {
            get { return  tipo_preco; }
            set {  tipo_preco = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPprodutospropostas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPPRODUTOSPROPOSTAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPprodutospropostas> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPprodutospropostas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPprodutospropostas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPprodutospropostas>(where);
        }

        #endregion
    }
}

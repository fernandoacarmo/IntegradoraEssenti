using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{
    public class LoteEntrada
    {
        public string ti047DataValidade { get; set; }
        public string ti047LoteFabricanteIu { get; set; }
        public string ti047QtdeEntrada { get; set; }
        public string ti047DataFabricacao { get; set; }
    }

    public class NfEntradaproduto
    {
        public NfEntradaproduto()
        {
            lotes = new List<LoteEntrada>();
        }
        public string ti046ProdutoIu { get; set; }
        public string ti046DataEmissaoIe { get; set; }
        public string ti046SituacaoTributaria { get; set; }
        public string ti046ValorFrete { get; set; }
        public string ti046NaturezaOperacao { get; set; }
        public string ti046PrecoEntrada { get; set; }
        public string ti046DescontoItem { get; set; }
        public string ti046DescontoComercial { get; set; }
        public string ti046ValorDescontoItem { get; set; }
        public string ti046ValorDescontoRepasse { get; set; }
        public string ti046ValorLiquido { get; set; }
        public string ti046BaseIcmsSubstituto { get; set; }
        public string ti046ValorIcmsSubstituto { get; set; }
        public string ti046AliquotaIpi { get; set; }
        public string ti046ValorIpi { get; set; }
        public string ti046BaseIcms { get; set; }
        public string ti046ValorIcms { get; set; }
        public string ti046IsentasIcms { get; set; }
        public string ti046OutrasIcms { get; set; }
        public string ti046AliquotaIcms { get; set; }
        public string ti046IsentasIpi { get; set; }
        public string ti046BasePisCofins { get; set; }
        public string ti046AliquotaPis { get; set; }
        public string ti046ValorPis { get; set; }
        public string ti046AliquotaCofins { get; set; }
        public string ti046ValorCofins { get; set; }
        public string ti046CstCofins { get; set; }
        public string ti046CstIpi { get; set; }
        public string ti046CstPis { get; set; }
        public string ti046OrigemCompra { get; set; }
        public string ti046CstIcms { get; set; }
        public string ti046QtdeProduto { get; set; }
        public string ti046UnidadeMedidaProduto { get; set; }
        public string ti046BasePiscofinsRetido { get; set; }
        public string ti046BasePiscofinsNormal { get; set; }
        public string ti046BasePiscofinsIsento { get; set; }
        public string ti046BaseIpi { get; set; }
        public string ti046DescontoRepasse { get; set; }
        public string ti046ValorPiscofinsRetido { get; set; }
        public string ti046ValorLiquidoCalculado { get; set; }
        public string ti046ValorDespesaAcessoria { get; set; }
        public string ti046OutrasIpi { get; set; }
        public string ti046SeqItemNf { get; set; }
        public string ti046DescComplementar { get; set; }
        public List<LoteEntrada> lotes { get; set; }
    }

    public class Credito
    {
        public string ti052CodunidcreditoIu { get; set; }
        public string ti052NumcreditoIu { get; set; }
        public string ti052Tipodocumento { get; set; }
        public string ti052Dataemissao { get; set; }
        public string ti052Codfornecedor { get; set; }
        public string ti052Situacaotitulo { get; set; }
        public string ti052Valorcredito { get; set; }
        public string ti052Databaixa { get; set; }
    }

    public class NfEntradaTitulosPagar
    {
        public NfEntradaTitulosPagar()
        {
            creditos = new List<Credito>();
        }
        public string ti051NumeroTituloIu { get; set; }
        public string ti051DataLimite { get; set; }
        public string ti051ValorBruto { get; set; }
        public string ti051ObservacaoDuplicata { get; set; }
        public List<Credito> creditos { get; set; }
    }

    public class NotaEntrada
    {
        public NotaEntrada()
        {
            nfEntradaprodutos = new List<NfEntradaproduto>();
            nfEntradaTitulosPagar = new List<NfEntradaTitulosPagar>();
        }
        public string ti045UnidadeIu { get; set; }
        public string ti045NotaFiscalIu { get; set; }
        public string ti045SerieIu { get; set; }
        public string ti045DataEmissaoIu { get; set; }
        public string ti045ValorTotalNotaFiscal { get; set; }
        public string ti045NumeroChaveAcessoNfe { get; set; }
        public string ti045ValorFrete { get; set; }
        public string ti045NaturezaOperacao { get; set; }
        public string ti045DataMovimentoContabil { get; set; }
        public string ti045IdEspecialista { get; set; }
        public string ti045CodigoEmpresa { get; set; }
        public string ti045CodigoFilial { get; set; }
        public string ti045CnpjEmitente { get; set; }
        public string ti045CodigoEdc { get; set; }
        public string ti045UfEmitente { get; set; }
        public string ti045TipoNotaEntrada { get; set; }
        public string ti045SequenciaDescontos { get; set; }
        public string ti045DespesasAcessorias { get; set; }
        public string ti045TipoEmitenteIu { get; set; }
        public string ti045NotaOrigemDevolucao { get; set; }
        public List<NfEntradaproduto> nfEntradaprodutos { get; set; }
        public List<NfEntradaTitulosPagar> nfEntradaTitulosPagar { get; set; }
    }

    public class ListaNotaEntrada : WebService
    {
        public List<NotaEntrada> lista { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("NotaEntrada");
        }

        public ListaNotaEntrada()
        {
            lista = new List<NotaEntrada>();
        }
    }
}

using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{
    public class LoteCupomFiscal
    {
        public string dataEmissaoIe { get; set; }
        public string unidadeIe { get; set; }
        public string notaFiscalIe { get; set; }
        public string serieIe { get; set; }
        public string tipoNotaFiscalIe { get; set; }
        public string sistemaDestinoIe { get; set; }
        public string produtoIe { get; set; }
        public string loteFabricanteIu { get; set; }
        public string sistemaOrigemE { get; set; }
        public string operacaoRegistro { get; set; }
        public string qtdeVendida { get; set; }
        public string dataValidade { get; set; }
    }

    public class ProdutoCupomFiscal
    {
        public ProdutoCupomFiscal()
        {
            lotes = new List<LoteCupomFiscal>();
        }
        public string origemCompra { get; set; }
        public string unidadeMedidaProduto { get; set; }
        public string valorFrete { get; set; }
        public string valorIcmsSubstituido { get; set; }
        public string valorDespesaAcessoria { get; set; }
        public string dataEmissaoIe { get; set; }
        public string unidadeIe { get; set; }
        public string basePisCofinsIsento { get; set; }
        public string descComplementar { get; set; }
        public string vlPisCofinsNormal { get; set; }
        public string vlPisCofinsRetido { get; set; }
        public string notaFiscalIe { get; set; }
        public string serieIe { get; set; }
        public string tipoNotaFiscalIe { get; set; }
        public string sistemaDestinoIe { get; set; }
        public string produtoIu { get; set; }
        public string operacaoRegistro { get; set; }
        public string sistemaOrigemE { get; set; }
        public string sequencialMovimentacao { get; set; }
        public string naturezaOperacao { get; set; }
        public string qtdeVendida { get; set; }
        public string precoVenda { get; set; }
        public string descontoItem { get; set; }
        public string descontoComercial { get; set; }
        public string descontoRepasse { get; set; }
        public string descontoFinanceiro { get; set; }
        public string valorDescontoItem { get; set; }
        public string valorDescontoComercial { get; set; }
        public string valorDescontoRepasse { get; set; }
        public string valorLiquido { get; set; }
        public string baseIcmsSubstituto { get; set; }
        public string valorIcmsSubstituto { get; set; }
        public string aliquotaIpi { get; set; }
        public string baseIpi { get; set; }
        public string valorIpi { get; set; }
        public string baseIcms { get; set; }
        public string valorIcms { get; set; }
        public string isentasIcms { get; set; }
        public string outrasIcms { get; set; }
        public string aliquotaIcms { get; set; }
        public string isentasIpi { get; set; }
        public string outrasIpi { get; set; }
        public string situacaoTributaria { get; set; }
        public string basePisCofins { get; set; }
        public string aliquotaPis { get; set; }
        public string valorPis { get; set; }
        public string pisIsento { get; set; }
        public string pisRetido { get; set; }
        public string aliquotaCofins { get; set; }
        public string valorCofins { get; set; }
        public string cofinsRetido { get; set; }
        public string seqNotaFiscal { get; set; }
        public string figuraFiscalE { get; set; }
        public string percReducaoBaseIcms { get; set; }
        public string baseCalculoDifa { get; set; }
        public string baseReducaoIcms { get; set; }
        public string classificFiscalE { get; set; }
        public string cofinsIsento { get; set; }
        public string custoMedio { get; set; }
        public string aliquotaCofinsIsento { get; set; }
        public string aliquotaCofinsNormal { get; set; }
        public string aliquotaCofinsRetido { get; set; }
        public string aliquotaPisIsento { get; set; }
        public string aliquotaPisNormal { get; set; }
        public string aliquotaPisRetido { get; set; }
        public string perReducaoBaseIcmsSt { get; set; }
        public string icmsnormalTipoBasedif { get; set; }
        public string icmssubstTipoBasedif { get; set; }
        public string icmsnormalValorBasedif { get; set; }
        public string icmssubstValorBasedif { get; set; }
        public string baseIcmsRet { get; set; }
        public string baseIcmsRec { get; set; }
        public string valorIcmsRet { get; set; }
        public string valorIcmsRec { get; set; }
        public string seqitemNotaOrigDevol { get; set; }
        public string valorDiferimentoIcms { get; set; }
        public string percRedbaseIcmssubst { get; set; }
        public string percAgregadoVenda { get; set; }
        public string tributacaoPis { get; set; }
        public string valorRedbaseIcms { get; set; }
        public string aliquotaInterna { get; set; }
        public string valorRedbaseIcmssubst { get; set; }
        public string msgFiscalCofins { get; set; }
        public string msgFiscalIpi { get; set; }
        public string msgFiscalIcms { get; set; }
        public string msgFiscalPis { get; set; }
        public string msgFiscalIcmsst { get; set; }
        public string cstCofins { get; set; }
        public string cstIpi { get; set; }
        public string cstPis { get; set; }
        public string cstIcms { get; set; }
        public string flagPromocao { get; set; }
        public string valorRecupIcmsstTotal { get; set; }
        public string valorRecupIcmsUnit { get; set; }
        public string valorRecupIcmsTotal { get; set; }
        public string baseIcmsSubsNaodest { get; set; }
        public string valorIcmsSubsNaodest { get; set; }
        public string cstSomaStbTotalNf { get; set; }
        public string baseIcmsSubsAntecip { get; set; }
        public string valorIcmsSubsAntecip { get; set; }
        public string codAntecipacaoSt { get; set; }
        public string baseredIcmsubsAntecip { get; set; }
        public string percredIcmsubsAntecip { get; set; }
        public string outredIcmsubsAntecip { get; set; }
        public string iseredIcmsubsAntecip { get; set; }
        public string outrasReducaoIcms { get; set; }
        public string isentasReducaoIcms { get; set; }
        public string agregadoVenda { get; set; }
        public string percAliqInterna { get; set; }
        public string custoCompra { get; set; }
        public string tipoAvariaE { get; set; }
        public string codTabNatRecCofins { get; set; }
        public string codTabNatRecPis { get; set; }
        public string codNatReceitaCofins { get; set; }
        public string codNatReceitaPis { get; set; }
        public string codTotParcialIcms { get; set; }
        public string codContrSocApurad { get; set; }
        public List<LoteCupomFiscal> lotes { get; set; }
    }

    public class CuponsFiscal
    {
        public string unidadeIe { get; set; }
        public string dataTransacaoIu { get; set; }
        public string numeroComponenteIu { get; set; }
        public string numeroCupomIu { get; set; }
        public string seqRecebimentoIu { get; set; }
        public string sistemaDestinoIe { get; set; }
        public string tipoRecebimento { get; set; }
        public string valorRecebimento { get; set; }
        public string sistemaOrigemE { get; set; }
        public string operacaoRegistro { get; set; }
    }

    public class CupomFiscal
    {
        public CupomFiscal()
        {
            produtos = new List<ProdutoCupomFiscal>();
            cuponsFiscal = new List<CuponsFiscal>();
        }

        public string codigoEmpresa { get; set; }
        public string codigoFilial { get; set; }
        public string cnpjFilial { get; set; }
        public string dataAutorizacaoNfe { get; set; }
        public string dataEmissaoIu { get; set; }
        public string idEspecialista { get; set; }
        public string unidadeIu { get; set; }
        public string notaFiscalIu { get; set; }
        public string codigoEdc { get; set; }
        public string notaDevolucao { get; set; }
        public string percDescCom { get; set; }
        public string placaVeiculo { get; set; }
        public string codSetor { get; set; }
        public string tipoNFS { get; set; }
        public string vlPisCofinsIsento { get; set; }
        public string vlPisCofinsNormal { get; set; }
        public string vlPisCofinsRetido { get; set; }
        public string serieIu { get; set; }
        public string tipoNotaFiscalIu { get; set; }
        public string sistemaDestinoIe { get; set; }
        public string operacaoRegistro { get; set; }
        public string statusRegistro { get; set; }
        public string descErroRegistro { get; set; }
        public string dataIncRegistro { get; set; }
        public string dataPrcRegistro { get; set; }
        public string sistemaOrigemE { get; set; }
        public string flagCancelada { get; set; }
        public string cliente { get; set; }
        public string dataSaida { get; set; }
        public string dataCancelamento { get; set; }
        public string totalItens { get; set; }
        public string totalUnidades { get; set; }
        public string numeroPrenota { get; set; }
        public string descontoComercial { get; set; }
        public string valorDescontoComercial { get; set; }
        public string valorDescontoItem { get; set; }
        public string valorDescontoRepasse { get; set; }
        public string valorTotalNotaFiscal { get; set; }
        public string pesoLiquido { get; set; }
        public string pesoBruto { get; set; }
        public string totalVolumes { get; set; }
        public string numPedido { get; set; }
        public string cupomFiscal { get; set; }
        public string dataImpressao { get; set; }
        public string sequencialNfe { get; set; }
        public string statusProcessoNfe { get; set; }
        public string numeroChaveAcessoNfe { get; set; }
        public string numProtocoloEnvioNfe { get; set; }
        public string baseIcmsSubstituto { get; set; }
        public string valorIcmsSubstituto { get; set; }
        public string valorIpi { get; set; }
        public string outrasIcms { get; set; }
        public string outrasIpi { get; set; }
        public string isentasIpi { get; set; }
        public string baseIcms { get; set; }
        public string naturezaOperacao { get; set; }
        public string baseIpi { get; set; }
        public string basePiscofinsIsento { get; set; }
        public string basePiscofinsRetido { get; set; }
        public string valorPisRetido { get; set; }
        public string basePiscofinsNormal { get; set; }
        public string valorPisNormal { get; set; }
        public string valorPisIsento { get; set; }
        public string valorCofinsIsento { get; set; }
        public string valorCofinsRetido { get; set; }
        public string romaneio { get; set; }
        public string portador { get; set; }
        public string tipoSegmento { get; set; }
        public string seqNotaFiscal { get; set; }
        public string codigoIbge { get; set; }
        public string numeroSelo { get; set; }
        public string serieSelo { get; set; }
        public string valorCofinsNormal { get; set; }
        public string cnpjEmitente { get; set; }
        public string notaOrigemDevolucao { get; set; }
        public string serieOrigemDevolucao { get; set; }
        public string transportadora { get; set; }
        public string tipoVenda { get; set; }
        public string tipoFrete { get; set; }
        public string totalProdutos { get; set; }
        public string motivoCancelamentoNfe { get; set; }
        public string observacaoLivroFiscal { get; set; }
        public string valorFrete { get; set; }
        public string baseIcmsRet { get; set; }
        public string baseIcmsRec { get; set; }
        public string valorIcmsRet { get; set; }
        public string valorIcmsRec { get; set; }
        public string isentasIcms { get; set; }
        public string transportadorTipo { get; set; }
        public string transportadorCnpjCpf { get; set; }
        public string veiculoPlaca { get; set; }
        public string veiculoUf { get; set; }
        public string cnpjCpfCliente { get; set; }
        public string dataEmissaoCupomFisc { get; set; }
        public string baseIcmsSubsNaodest { get; set; }
        public string valorIcmsSubsNaodest { get; set; }
        public string baseIcmsSubsAntecip { get; set; }
        public string valorIcmsSubsAntecip { get; set; }
        public string outrasReducaoIcms { get; set; }
        public string isentasReducaoIcms { get; set; }
        public string outredIcmsubsAntecip { get; set; }
        public string iseredIcmsubsAntecip { get; set; }
        public string contOrdemOperacao { get; set; }
        public string codEmissorCupFisc { get; set; }
        public List<ProdutoCupomFiscal> produtos { get; set; }
        public List<CuponsFiscal> cuponsFiscal { get; set; }
    }

    public class ListaCupomFiscal : WebService
    {
        public List<CupomFiscal> lista { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("ListaCupomFiscal");
        }

        public ListaCupomFiscal()
        {
            lista = new List<CupomFiscal>();
        }
    }
}

using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{
    public class FechamentoCaixaHistoricoDoc
    {
        public string unidade { get; set; }
        public string numeroSequencialDocumento { get; set; }
        public string numeroSequecialBaixasTitulo { get; set; }
        public string sistemaDestino { get; set; }
        public string codigoTipoBaixaOrigem { get; set; }
        public string dataRecebimento { get; set; }
        public string codigoDocumentoRecebimento { get; set; }
        public string codigoEmpresaRecebimentoOrigem { get; set; }
        public string codigoBancoRecebimentoOrigem { get; set; }
        public string codigoAgenciaRecebimentoOrigem { get; set; }
        public string codigoCcorrenteRecebimentoOrigem { get; set; }
        public string valorRecebimentoPrincipal { get; set; }
        public string valorRecebimentoMora { get; set; }
        public string valorRecebimentoMulta { get; set; }
        public string valorRecebimentoDesconto { get; set; }
        public string indicaSintetiza { get; set; }
        public string codigoRecebimento { get; set; }
        public string codigoDocumentoOrigem { get; set; }
        public string codigoTipoDocumentoOrigem { get; set; }
        public string codigoBanco { get; set; }
        public string codigoAgencia { get; set; }
        public string codigoConta { get; set; }
        public string numeroCheque { get; set; }
        public string sistemaOrigem { get; set; }
    }

    public class FechamentoCaixa
    {
        public FechamentoCaixa()
        {
            fechamentoCaixaHistoricoDoc = new List<FechamentoCaixaHistoricoDoc>();
        }
        public string unidade { get; set; }
        public string idEspecialista { get; set; }
        public string numeroSequencialDocumento { get; set; }
        public string sistemaDestino { get; set; }
        public string codigoDocumentoOrigem { get; set; }
        public string numeroLoteOrigem { get; set; }
        public string codigoBancoOrigem { get; set; }
        public string codigoAgenciaOrigem { get; set; }
        public string codigoCcorrenteOrigem { get; set; }
        public string codigoVendedorOrigem { get; set; }
        public string codigoClienteOrigem { get; set; }
        public string codigoTipoDocumentoOrigem { get; set; }
        public string codigoSituacaoDocumentoOrigem { get; set; }
        public string dataEmissao { get; set; }
        public string dataVencimento { get; set; }
        public string valorDocumento { get; set; }
        public string percentualDescontoFinanceiro { get; set; }
        public string numeroDiasDescontoFinanceiro { get; set; }
        public string valorDesconto { get; set; }
        public string percentualDesconto { get; set; }
        public string percentualMora { get; set; }
        public string percentualMulta { get; set; }
        public string numeroDiasMulta { get; set; }
        public string codigoDocumentoDestino { get; set; }
        public string codigoPedido { get; set; }
        public string codigoNotaFiscal { get; set; }
        public string codigoSerie { get; set; }
        public string codigoReferencia { get; set; }
        public string observacaoDocumento { get; set; }
        public string indicaValorMoraDiario { get; set; }
        public string operacaoRegistro { get; set; }
        public string sistemaOrigem { get; set; }
        public List<FechamentoCaixaHistoricoDoc> fechamentoCaixaHistoricoDoc { get; set; }
    }

    public class ListaFechamentoCaixa : WebService
    {
        public List<FechamentoCaixa> lista { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("FechamentoCaixa");
        }

        public ListaFechamentoCaixa()
        {
            lista = new List<FechamentoCaixa>();
        }
    }
}

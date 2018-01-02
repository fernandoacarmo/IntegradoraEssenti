using Integradora.ECommerce.DataHub.Inherited;
using Integradora.ECommerce.DataHub.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{
    public class ProdutosUnidade
    {
        public Int32 unidadeIu { get; set; }
        public string operacaoRegistro { get; set; }
        public string classificacaoTipo { get; set; }
        public string produtoAtivo { get; set; }
        public Int32 codigoEmpresa { get; set; }
    }

    public class Produto
    {
        public Produto()
        {
            produtosUnidade = new List<ProdutosUnidade>();
        }

        public string operacaoRegistro { get; set; }
        public string idEspecialista { get; set; }
        public Int32 produtoIu { get; set; }
        public string descricao { get; set; }
        public string descricaoComplementar { get; set; }
        public string unidadeVenda { get; set; }
        public string classificacaoFiscal { get; set; }
        public string situacaoTributaria { get; set; }
        public string tributacaoPis { get; set; }
        public string codigoBarras { get; set; }
        public string familia { get; set; }
        public List<ProdutosUnidade> produtosUnidade { get; set; }
    }

    public class CadastroProduto : WebService
    {
        public CadastroProduto()
        {
            lista = new List<Produto>();
        }

        public List<Produto> lista { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("Produtos");
        }
    }
}

using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{
    public class TabelaDePrecosIten
    {
        public Int32 ti115Codpro { get; set; }
        public Int32 ti115Codder { get; set; }
        public Int32 ti115Qtdmax { get; set; }
        public Double ti115Prebas { get; set; }
        public string ti115Sitreg { get; set; }
        public string ti115Proext { get; set; }
    }

    public class TabelaPreco
    {
        public TabelaPreco()
        {
            tabelaDePrecosItens = new List<TabelaDePrecosIten>();
        
        }
        public Int32 ti114Codemp { get; set; }
        public string ti114Codtpr { get; set; }
        public string ti114Datini { get; set; }
        public string ti114Datfim { get; set; }
        public string ti114Sitreg { get; set; }
        public string ti114IdEspecialista { get; set; }
        public List<TabelaDePrecosIten> tabelaDePrecosItens { get; set; }
    }

    public class ListaTabelaPreco : WebService
    {
        public ListaTabelaPreco()
        {
            lista = new List<TabelaPreco>();
        }
        public List<TabelaPreco> lista { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("TabelaPreco");
        }

    }
}

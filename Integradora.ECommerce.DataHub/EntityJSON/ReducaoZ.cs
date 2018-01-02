using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{
    public class Aliquota
    {
        public string ti106Codstr { get; set; }
        public string ti106Alqimp { get; set; }
        public string ti106Vltimp { get; set; }
        public string ti106OperacaoRegistro { get; set; }
    }

    public class MeiosPagamento
    {
        public string ti107Codmpg { get; set; }
        public string ti107Desmpg { get; set; }
        public string ti107Vlrtot { get; set; }
        public string ti107OperacaoRegistro { get; set; }
    }

    public class TotalizadorNaoFiscal
    {
        public string ti108Codtot { get; set; }
        public string ti108Destot { get; set; }
        public string ti108Qtdope { get; set; }
        public string ti108Vlrtot { get; set; }
        public string ti108OperacaoRegistro { get; set; }
    }

    public class ReducaoZ
    {
        public ReducaoZ()
        {
            aliquotas = new List<Aliquota>();
            meiosPagamento = new List<MeiosPagamento>();
            totalizadorNaoFiscal = new List<TotalizadorNaoFiscal>();
        }
        public string ti105Codemp { get; set; }
        public string ti105Codfil { get; set; }
        public string ti105Codequ { get; set; }
        public string ti105Numser { get; set; }
        public string ti105Datref { get; set; }
        public string ti105Nummar { get; set; }
        public string ti105Numrez { get; set; }
        public string ti105Vlrgtf { get; set; }
        public string ti105Vlrbru { get; set; }
        public string ti105Vlrdsc { get; set; }
        public string ti105Vlrcan { get; set; }
        public string ti105Vlrser { get; set; }
        public string ti105Vlrgti { get; set; }
        public string ti105Vlracr { get; set; }
        public string ti105Conrei { get; set; }
        public string ti105Ideext { get; set; }
        public string ti105Coored { get; set; }
        public string ti105IdEspecialista { get; set; }
        public string ti105OperacaoRegistro { get; set; }
        public List<Aliquota> aliquotas { get; set; }
        public List<MeiosPagamento> meiosPagamento { get; set; }
        public List<TotalizadorNaoFiscal> totalizadorNaoFiscal { get; set; }
    }

    public class ListaReducaoZ : WebService
    {
        public List<ReducaoZ> lista { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("ListaReducaoZ");
        }

        public ListaReducaoZ()
        {
            lista = new List<ReducaoZ>();
        }
    }
}

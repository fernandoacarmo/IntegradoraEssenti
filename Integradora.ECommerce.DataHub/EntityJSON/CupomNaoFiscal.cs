using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{
    public class cupomNaoFiscalItem
    {
        public Int32 ti111Seqite { get; set; }
        public string ti111Ideext { get; set; }
        public string ti111Codbar { get; set; }
        public string ti111Datvct { get; set; }
        public Double ti111Vlrbrt { get; set; }
        public Double ti111Vlrmor { get; set; }
        public Double ti111Vlrmul { get; set; }
        public Double ti111Vlracr { get; set; }
        public Double ti111Vlrdsc { get; set; }
        public Double ti111Vlrliq { get; set; }
        public Int32 ti111Codote { get; set; }
        public Int32 ti111Codfot { get; set; }
        public string ti111Numtel { get; set; }
        public string ti111Prdtef { get; set; }
        public string ti111Opetef { get; set; }
        public string ti111Codcpv { get; set; }
        public string ti111Nsutef { get; set; }
    }

    public class cupomNaoFiscalPagamento
    {
        public Int32 ti112Seqpar { get; set; }
        public Int32 ti112Codfpg { get; set; }
        public string ti112Vctpar { get; set; }
        public Double ti112Vlrpar { get; set; }
        public string ti112Cattef { get; set; }
        public string ti112Catext { get; set; }
        public string ti112Nsutef { get; set; }
        public Double ti112Dscneg { get; set; }
        public string ti112Cheban { get; set; }
        public string ti112Cheage { get; set; }
        public string ti112Checta { get; set; }
        public string ti112Chenum { get; set; }
        public string ti112Codbar { get; set; }
        public string ti112Codsac { get; set; }
        public Int32 ti112Fpgtro { get; set; }
        public Double ti112Vlrtro { get; set; }
    }

    public class CupomNaoFiscal
    {
        public CupomNaoFiscal()
        {
            cupomNaoFiscalItens = new List<cupomNaoFiscalItem>();
            cupomNaoFiscalPagamentos = new List<cupomNaoFiscalPagamento>();
        }
        public Int32 ti110Codemp { get; set; }
        public Int32 ti110Codfil { get; set; }
        public Int32 ti110Codequ { get; set; }
        public Int32 ti110Numnro { get; set; }
        public Int32 ti110Numcoo { get; set; }
        public Int32 ti110Ideext { get; set; }
        public Int32 ti110Tiprec { get; set; }
        public string ti110Tipopr { get; set; }
        public string ti110Datopr { get; set; }
        public string ti110Horopr { get; set; }
        public Int32 ti110Codrep { get; set; }
        public string ti110Codcpv { get; set; }
        public string ti110Nsutef { get; set; }
        public Int32 ti110Codcli { get; set; }
        public string ti110Codban { get; set; }
        public Int32 ti110Reccan { get; set; }
        public string ti110Chvtef { get; set; }
        public string ti110IdEspecialista { get; set; }
        public List<cupomNaoFiscalItem> cupomNaoFiscalItens { get; set; }
        public List<cupomNaoFiscalPagamento> cupomNaoFiscalPagamentos { get; set; }
    }

    public class ListaCupomNaoFiscal : WebService
    {
        public ListaCupomNaoFiscal()
        {
            lista = new List<CupomNaoFiscal>();
        }

        public List<CupomNaoFiscal> lista { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("CupomNaoFiscal");
        }
    }
}

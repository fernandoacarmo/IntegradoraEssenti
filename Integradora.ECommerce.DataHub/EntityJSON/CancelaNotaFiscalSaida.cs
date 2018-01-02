using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{
    public class CancelaNotaFiscalSaida
    {
        public string ti048DataEmissaoIu { get; set; }
        public Int32 ti048UnidadeIu { get; set; }
        public Int32 ti048NotaFiscalIu { get; set; }
        public string ti048SerieIu { get; set; }
        public string ti048TipoNotaFiscalIu { get; set; }
        public string ti048CodigoEdc { get; set; }
        public Int32 ti048CodigoEmpresa { get; set; }
        public Int32 ti048CodigoFilial { get; set; }
        public string ti048DataCancelamento { get; set; }
        public string ti048IdEspecialista { get; set; }
        public Int64 ti048NumeroChaveAcessoNfe { get; set; }
        public string ti048TipNfs { get; set; }
    }

    public class ListaCancelaNotaFiscalSaida : WebService
    {
        public ListaCancelaNotaFiscalSaida()
        {
            lista = new List<CancelaNotaFiscalSaida>();
        }
        public List<CancelaNotaFiscalSaida> lista { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("CancelaNotaFiscalSaida");
        }
   }   
}

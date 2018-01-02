using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{

    public class CancelamentoCupomFiscal
    {
        public string ti113Codemp { get; set; }
        public string ti113Codfil { get; set; }
        public string ti113Numcfi { get; set; }
        public string ti113Codequ { get; set; }
        public string ti113Datemi { get; set; }
        public string ti113Cnpjfilial { get; set; }
        public string ti113Croecf { get; set; }
        public string ti113Codcli { get; set; }
        public string ti113Codrep { get; set; }
        public string ti113Obscfi { get; set; }
        public string ti113Codcpg { get; set; }
        public string ti113Numnfc { get; set; }
        public string ti113Horemi { get; set; }
        public string ti113Idtreq { get; set; }
        public string ti113IdEspecialista { get; set; }
        public string ti113DataCancelamento { get; set; }
    }

    public class ListaCancelamentoCupomFiscal : WebService
    {
        public ListaCancelamentoCupomFiscal()
        {
            lista = new List<CancelamentoCupomFiscal>();
        }

        public List<CancelamentoCupomFiscal> lista { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("ListaCancelamentoCupomFiscal");
        }
    }
}

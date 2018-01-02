using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{
    public class Creditos
    {
        public string codunidcredito { get; set; }
        public string numcredito { get; set; }
        public string tipodocumento { get; set; }
        public string dataemissao { get; set; }
        public string codfornecedoor { get; set; }
        public string situacaotitulo { get; set; }
        public string valorcredito { get; set; }
        public string databaixa { get; set; }
    }

    public class Titulo
    {
        public Titulo()
        {
            creditos = new List<Creditos>();
        }
        public string codundtit { get; set; }
        public string numtit { get; set; }
        public string tptit { get; set; }
        public string dataemissao { get; set; }
        public string codfornecedoor { get; set; }
        public string dtpagto { get; set; }
        public string vlrpago { get; set; }
        public string tpbx { get; set; }
        public string operacao_registro { get; set; }
        public string status_registro { get; set; }
        public string desc_erro_registro { get; set; }
        public string data_inc_registro { get; set; }
        public string data_prc_registro { get; set; }
        public List<Creditos> creditos { get; set; }
    }

    /// <summary>
    /// Principal
    /// </summary>
    public class ListaBaixaTituloPagar : WebService
    {
        public ListaBaixaTituloPagar()
        {
            titulo = new List<Titulo>();
        }
        public string sistema_origem_e { get; set; }
        public string sistema_destino_ie { get; set; }
        public List<Titulo> titulo { get; set; }

        public override string GetUrl()
        {
            return MontarUrl("ListaBaixaTituloPagar");
        }
    }
}

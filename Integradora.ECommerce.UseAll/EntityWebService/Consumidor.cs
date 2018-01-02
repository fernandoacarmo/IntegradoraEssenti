using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.UseAll.EntityWebService
{
    public class Consumidor : Entity
    {
        public long anidconsumidor { get; set; }
        public string asnome { get; set; }
        public string asnomeempresa { get; set; }
        public long antipoinscricao { get; set; }
        public long anidassociado { get; set; }
        public string asinscricao { get; set; }
        public string asinscricaoestadual { get; set; }
        public string ascep { get; set; }
        public string ascomplemento { get; set; }
        public long anidregiao { get; set; }
        public string asfone1 { get; set; }
        public string asfone2 { get; set; }
        public string asfone_celular { get; set; }
        public string addata_cadastro { get; set; }
        public long anidlocalentrega { get; set; }
        public string asci { get; set; }
        public string asci_orgao_emissor { get; set; }
        public string asemail { get; set; }
        public string asnomepai { get; set; }
        public string asnomemae { get; set; }
        public string asprofissao { get; set; }
        public string asestadocivil { get; set; }
        public string asnaturalidade { get; set; }
        public int ancnae { get; set; }
        public int andiavcto { get; set; }

    }
}

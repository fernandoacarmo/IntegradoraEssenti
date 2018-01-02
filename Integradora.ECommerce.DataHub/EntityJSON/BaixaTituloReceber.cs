using Integradora.ECommerce.DataHub.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.EntityJSON
{
    public class Baixa
    {
        public string codundrecdet { get; set; }
        public string numtitbxrecdet { get; set; }
        public string tptitbxrecdet { get; set; }
        public string seqtitbxrecdet { get; set; }
        public string seqtppagbxrecdet { get; set; }
        public string tprecebdet { get; set; }
        public string vlrrecebdet { get; set; }
        public string vlrjrsrecebdet { get; set; }
        public string vlrdescrecebdet { get; set; }
        public string numncrecdet { get; set; }
        public string codbcorecdet { get; set; }
        public string codagrecdet { get; set; }
        public string codccrecdet { get; set; }
        public string numchqrecdet { get; set; }
        public string vlrcustasrecdet { get; set; }
        public string dteminumncrecdet { get; set; }
        public string dtemititbxrecdet { get; set; }
    }

    public class BaixasPorSubstituicao
    {
        public string codundtitsb { get; set; }
        public string numtitsb { get; set; }
        public string tptitsb { get; set; }
        public string dtemititsb { get; set; }
    }

    /// <summary>
    /// Classe principal
    /// </summary>
    public class BaixaTitulo 
    {
        public BaixaTitulo()
        {
            baixas = new List<Baixa>();
            baixasPorSubstituicao = new List<BaixasPorSubstituicao>();
        }
        public string codundtit { get; set; }
        public string numtitbx { get; set; }
        public string tptitbx { get; set; }
        public string seqbx { get; set; }
        public string codundbxtit { get; set; }
        public string vlrpag { get; set; }
        public string vlrjuros { get; set; }
        public string vlrdesc { get; set; }
        public string tpbx { get; set; }
        public string dtemititbx { get; set; }
        public string dtpagtit { get; set; }
        public string dtbx { get; set; }
        public List<Baixa> baixas { get; set; }
        public List<BaixasPorSubstituicao> baixasPorSubstituicao { get; set; }
    }
}

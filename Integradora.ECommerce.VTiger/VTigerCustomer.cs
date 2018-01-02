using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTigerApi;

namespace Integradora.ECommerce.VTiger
{
    public class VTigerCustomer : VTigerApi.VTigerAccount
    {
        public VTigerCustomer()
        {
            accounttype = Accounttype.Customer;
        }
        public string rca;
        public string rgie;
        public string cnpj;
        public string member_of;
    }
}

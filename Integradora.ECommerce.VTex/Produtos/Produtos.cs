using Integradora.ECommerce.VTex.Inherited;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.VTex.Produtos
{
    public class Produtos : RestObject
    {
        public string EnviarEstoque(string sku, string warehouse, object jsonFormatado)
        {
            string requestRoute = string.Format("/logistics/pvt/inventory/warehouseitems/setbalance/");
//            string requestRoute = string.Format("http://logistics.{0}.com.br/api/logistics/pvt/inventory/skus/{1}/warehouses/{2}?an={3}"
//                                               , "vtexcommercestable"
//                                               , sku
//                                               , warehouse
//                                               , Biblioteca.Dictionaries.Settings.VTex_Empresa()
//                                               );

            string passo = GetRequest(requestRoute, Method.POST, jsonFormatado);

            return passo;
        }

        public string EnviarPreco(string sku, object jsonFormatado)
        {
            string requestRoute = string.Format("/api/rnb/pvt/coupon/{0}?an={1}"
                                               , sku
                                               , Biblioteca.Dictionaries.Settings.VTex_Empresa()
                                               );

            string passo = GetRequest(requestRoute, Method.POST, jsonFormatado);

//            string requestRoute = string.Format(" http://rnb.{0}.com.br/api/rnb/pvt/coupon/{1}?an={2}"
//                                               , "vtexcommercestable"
//                                               , sku
//                                               , Biblioteca.Dictionaries.Settings.VTex_Empresa()
//                                               );       
//
//            string passo = GetRequest(requestRoute, "POST", true, jsonFormatado);

            return passo;
        }

        public string ExcluirPreco(string sku)
        {
            string requestRoute = string.Format("http://rnb.{0}.com.br/api/pricing/pvt/price-sheet/{1}/?an={2}"
                                               , "vtexcommercestable"
                                               , sku
                                               , Biblioteca.Dictionaries.Settings.VTex_Empresa()
                                               );

            string passo = GetRequest(requestRoute, "DELETE", false, null);

            return passo;
        }
    }
}

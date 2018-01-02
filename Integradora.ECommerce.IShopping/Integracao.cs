using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using Integradora.ECommerce.IShopping.Retornos;

namespace Integradora.ECommerce.IShopping
{
    public sealed class Integracao : Integradora.ECommerce.Lojavirtual
    {
        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.IShopping;
        }

        public override void Initialize()
        {
            CriarCreditoParaCliente = false;
        }

        public Produtos ListarProdutos()
        {
            var webservice = new API();

            //Consultando o e-commerce
            var responseData = webservice.GetRegistros("product/list");
            //Aguardando a resposta
            webservice.AguardarPreencher(responseData);
            //Transformando string na classe de resposta
            Produtos jsonObject = JsonConvert.DeserializeObject<Produtos>(responseData.Result);

            return jsonObject;
        }
        public FormaPagamentos ListarFormaPagamentos()
        {
            var webservice = new API();

            var responseData = webservice.GetRegistros("payment/list");
            //Aguardando a resposta
            webservice.AguardarPreencher(responseData);
            //Transformando string na classe de resposta
            FormaPagamentos jsonObject = JsonConvert.DeserializeObject<FormaPagamentos>(responseData.Result);

            return jsonObject;
        }

        public Produtos ObterProduto(string id)
        {
            var webservice = new API();

            var responseData = webservice.GetRegistros(string.Format("product/{0}", id));
            //Aguardando a resposta
            webservice.AguardarPreencher(responseData);
            //Transformando string na classe de resposta
            Produtos jsonObject = JsonConvert.DeserializeObject<Produtos>(responseData.Result);

            return jsonObject;
        }

        private int ProdutoInserir(Produto registro)
        { 
            var webservice = new API();


            var responseData = webservice.PostRegistros("product/insert", registro);
            //Aguardando a resposta
            webservice.AguardarPreencher(responseData);
            //Transformando string na classe de resposta
            GravarProduto jsonObject = JsonConvert.DeserializeObject<GravarProduto>(responseData.Result);

            return jsonObject.productId;
        }

        private int ProdutoAlterar(Produto registro)
        {
            var webservice = new API();

            var responseData = webservice.PostRegistros(string.Format("product/update/{0}", registro.id), registro);
            //Aguardando a resposta
            webservice.AguardarPreencher(responseData);
            //Transformando string na classe de resposta
            GravarProduto jsonObject = JsonConvert.DeserializeObject<GravarProduto>(responseData.Result);

            return jsonObject.productId;
        }

        public int ProdutoAplicar(Produto produto)
        {
            int resultado = 0;
            if (produto.id > 0)
            {
                resultado = ProdutoAlterar(produto);
            }
            else
            {
                resultado = ProdutoInserir(produto);
            }

            return resultado;
        }

        public StatusPedido StatusPedidoListar()
        {
            var webservice = new API();

            var responseData = webservice.GetRegistros("order/status/list");
            //Aguardando a resposta
            webservice.AguardarPreencher(responseData);
            //Transformando string na classe de resposta
            StatusPedido jsonObject = JsonConvert.DeserializeObject<StatusPedido>(responseData.Result);

            return jsonObject;
        }

        public ListaPedidos PedidoListar()
        {
            var webservice = new API();
            var content = new StringContent("{\"status\": 2,\"order_type\": \"asc\",\"complete\": true,\"limit\": 50}");
            var responseData = webservice.PostRegistros("order/list", content);
            //Aguardando a resposta
            webservice.AguardarPreencher(responseData);
            //Transformando string na classe de resposta
            ListaPedidos jsonObject = JsonConvert.DeserializeObject<ListaPedidos>(responseData.Result);

            return jsonObject;
        }

        public Order ObterPedido(int numeroPedido)
        {
            throw new NotImplementedException();
        }

        public bool MudarStatus(int numeroPedido, int status, string msg)
        {
            var webservice = new API();
            var content = new StringContent(string.Format("{\"status_id\": {0},  \"track_code\": \"{1}\",  \"comments\": \"{2}\",  \"isViewable\": true}", status, string.Empty, msg));
            var responseData = webservice.PutRegistros(string.Format("order/{0}/status", numeroPedido), content);
            //Aguardando a resposta
            webservice.AguardarPreencher(responseData);
            //Transformando string na classe de resposta
            StatusAlterado jsonObject = JsonConvert.DeserializeObject<StatusAlterado>(responseData.Result);

            return jsonObject.status == 200;
        }
    }
}

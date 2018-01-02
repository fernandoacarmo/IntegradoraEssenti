using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.FBits
{
    public sealed class Webservices
    {
        const int TIMEOUT = 10000000;
        public static SyncUsuario.SyncUsuario Cliente()
        {
            SyncUsuario.SyncUsuario webservice = new SyncUsuario.SyncUsuario();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }

        public static SyncUsuarioEndereco.SyncUsuarioEndereco ClienteEndereco()
        {
            SyncUsuarioEndereco.SyncUsuarioEndereco webservice = new SyncUsuarioEndereco.SyncUsuarioEndereco();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }
        public static SyncContaCorrente.SyncContaCorrente ContaCorrente()
        {
            SyncContaCorrente.SyncContaCorrente webservice = new SyncContaCorrente.SyncContaCorrente();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }
        public static SyncCategoria.SyncCategoria ClienteCategoria()
        {
            SyncCategoria.SyncCategoria webservice = new SyncCategoria.SyncCategoria();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }
        public static SyncProdutoCategoria.SyncProdutoCategoria ProdutoCategoria()
        {
            SyncProdutoCategoria.SyncProdutoCategoria webservice = new SyncProdutoCategoria.SyncProdutoCategoria();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }
        public static SyncProdutoCombo.SyncProdutoCombo ProdutoCombo()
        {
            SyncProdutoCombo.SyncProdutoCombo webservice = new SyncProdutoCombo.SyncProdutoCombo();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }

        public static SyncProdutoEstoque.SyncProdutoEstoque ProdutoEstoque()
        {
            SyncProdutoEstoque.SyncProdutoEstoque webservice = new SyncProdutoEstoque.SyncProdutoEstoque();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }

        public static SyncProdutoFornecedor.SyncProdutoFornecedor ProdutoFornecedor()
        {
            SyncProdutoFornecedor.SyncProdutoFornecedor webservice = new SyncProdutoFornecedor.SyncProdutoFornecedor();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }

        public static SyncProdutoImagem.SyncProdutoImagem ProdutoImagem()
        {
            SyncProdutoImagem.SyncProdutoImagem webservice = new SyncProdutoImagem.SyncProdutoImagem();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }
        public static SyncProdutoPreco.SyncProdutoPreco ProdutoPreco()
        {
            SyncProdutoPreco.SyncProdutoPreco webservice = new SyncProdutoPreco.SyncProdutoPreco();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }
        public static SyncProduto.SyncProduto Produto()
        {
            SyncProduto.SyncProduto webservice = new SyncProduto.SyncProduto();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }
        public static SyncEstoque.SyncEstoque Estoque()
        {
            SyncEstoque.SyncEstoque webservice = new SyncEstoque.SyncEstoque();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }
        public static SyncPedidoStatus.SyncPedidoStatus PedidoStatus()
        {
            SyncPedidoStatus.SyncPedidoStatus webservice = new SyncPedidoStatus.SyncPedidoStatus();
            webservice.Timeout = TIMEOUT;
            return webservice;
        }
        public static SyncPedidoVenda.SyncPedidoVenda PedidoVenda()
        {
            SyncPedidoVenda.SyncPedidoVenda webservice = new SyncPedidoVenda.SyncPedidoVenda();
            System.Net.ServicePointManager.Expect100Continue = false; 
            webservice.Timeout = TIMEOUT;
            return webservice;
        }
    }
}

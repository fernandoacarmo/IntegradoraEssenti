    using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.FBits.SyncCategoria;
using Integradora.ECommerce.FBits.SyncEstoque;
using Integradora.ECommerce.FBits.SyncPedidoStatus;
using Integradora.ECommerce.FBits.SyncPedidoVenda;
using Integradora.ECommerce.FBits.SyncProduto;
using Integradora.ECommerce.FBits.SyncProdutoCategoria;
using Integradora.ECommerce.FBits.SyncProdutoCombo;
using Integradora.ECommerce.FBits.SyncProdutoFornecedor;
using Integradora.ECommerce.FBits.SyncProdutoPreco;
using Integradora.ECommerce.FBits.SyncUsuario;
using Integradora.ECommerce.FBits.SyncUsuarioEndereco;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.FBits
{
    public class Integracao : Integradora.ECommerce.Lojavirtual
    {
        string url = "";

        public enum TipoLancamento
        {
            Credito = 1,
            Debito = 2
        };

        public enum SituacaoPedido
        {
            Pago = 1,
            Aguardando_Liberação = 2,
            Cartão_Temporariamente_Negado = 3,
            Cartão_Negado = 4,
            Fraude = 5,
            Suspeito_de_Fraude = 6,
            Boleto_Expirado = 7,
            Cancelado = 8,
            Enviado = 9,
            Liberado = 10,
            Faturado_Nota_fiscal_emitida = 11
        }

        public enum FormaPagametno
        {
            Boleto = 1,
            PayPal = 2,
            Visa = 3,
            MasterCard = 4,
            American_Express = 5,
            Diners = 6,
            Aura = 7,
            Hipercard = 8,
            Google_Checkout = 9,
            ELO = 10,
            Deposito_Bancario = 11,
            Moip = 12,
            Créditos_VP = 13,
            Discover = 14,
            Mercado_Pago = 15,
            Promocao = 16,
            FastCash_Deposito = 17,
            FastCash_Transferencia = 18,
            FastCash_Financiamento = 19,
            Pagamento_Marketplace_Extra = 99
        }

        #region Propriedades herdadas
        public static string Token()
        {
            return Integradora.Biblioteca.Dictionaries.Settings.FBits_Token();
        }
        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.FBits;
        }

        public override void Initialize()
        {
            CriarCreditoParaCliente = false;
        }
        #endregion

        #region Categoria de cliente
        public IntegracaoCategoriaInfo ClienteCaregoriaSelect(string codigo)
        {
            IntegracaoCategoriaInfo retorno = null;
            try
            {
                SyncCategoria.SyncCategoria webservice = Webservices.ClienteCategoria();
                url = webservice.Url;
                //Consultando se a categoria já existe
                retorno = webservice.Select(Token(), codigo);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ClienteCaregoriaSelect", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = null;
            }
            return retorno;
        }
        public bool ClienteCategoriaInsertUpdate(IntegracaoCategoriaInfo CategoriaCliente)
        {
            bool retorno = false;
            try
            {
                //Criando o WebService
                SyncCategoria.SyncCategoria webservice = Webservices.ClienteCategoria();
                url = webservice.Url;
                 //Inserindo a nova categoria
                    retorno = webservice.Insert(Token(), CategoriaCliente);
               
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ClienteCategoriaInsertUpdate", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }
            return retorno;
        }

        public bool ClienteCategoriaDelete(IntegracaoCategoriaInfo CategoriaCliente)
        {
            bool retorno = false;
            try
            {
                //Criando o WebService
                SyncCategoria.SyncCategoria webservice = Webservices.ClienteCategoria();
                url = webservice.Url;
                retorno = webservice.Delete(Token(), CategoriaCliente.CategoriaClienteId);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ClienteCategoriaDelete", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }
            return retorno;
        }
        #endregion

        #region Cliente
        public SyncUsuario.IntegracaoUsuarioInfo[] ClienteList()
        {
            SyncUsuario.IntegracaoUsuarioInfo[] retorno = null;
            try
            {
                SyncUsuario.SyncUsuario webservice = Webservices.Cliente();
                url = webservice.Url;
                retorno = webservice.GetItems(Token());
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ClienteList", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = null;
            }
            return retorno;
        }
        public SyncUsuario.IntegracaoUsuarioInfo ClienteSelect(long usuarioId)
        {
            SyncUsuario.IntegracaoUsuarioInfo retorno = null;
            try
            {
                SyncUsuario.SyncUsuario webservice = Webservices.Cliente();
                url = webservice.Url;
                retorno = webservice.Select(Token(), usuarioId);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ClienteSelect", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = null;
            }
            return retorno;
        }
        public bool ClienteConfirm(long usuarioId)
        {
            bool retorno = false;
            try
            {
                SyncUsuario.SyncUsuario webservice = Webservices.Cliente();
                url = webservice.Url;
                retorno = webservice.Complete(Token(), usuarioId);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ClienteConfirm", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }
            return retorno;
        }
        #endregion

        #region Endereço de cliente
        public IntegracaoUsuarioEnderecoInfo[] ClienteEnderecoList()
        {
            IntegracaoUsuarioEnderecoInfo[] retorno = null;
            try
            {
                SyncUsuarioEndereco.SyncUsuarioEndereco webservice = Webservices.ClienteEndereco();
                url = webservice.Url;
                retorno = webservice.GetItems(Token());
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ClienteEnderecoList", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = null;
            }
            return retorno;
        }

        public bool ClienteEnderecoConfirm(long enderecoid)
        {
            bool retorno = false;
            try
            {
                SyncUsuarioEndereco.SyncUsuarioEndereco webservice = Webservices.ClienteEndereco();
                url = webservice.Url;
                retorno = webservice.Complete(Token(), enderecoid);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ClienteEnderecoConfirm", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }
            return retorno;
        }
        #endregion

        #region Conta Corrente
        public string ContaCorrenteInsert(string usuarioId, string valor, TipoLancamento tipo, int NumPedido, string historico)
        {
            string retorno = "";
            try
            {
                SyncContaCorrente.SyncContaCorrente webservice = Webservices.ContaCorrente();
                url = webservice.Url;
                retorno = webservice.RegistrarCredito(Token(), usuarioId, valor, (int)tipo, NumPedido, historico);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ContaCorrenteInsert", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = "";
            }
            return retorno;
        }
        #endregion

        #region Pedidos
        public IntegracaoPedidoVendaInfo[] PedidoList()
        {            
            IntegracaoPedidoVendaInfo[] retorno = null;
            try
            {
                SyncPedidoVenda.SyncPedidoVenda webservice = Webservices.PedidoVenda();
                url = webservice.Url;
                retorno = webservice.GetItems(Token());
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "PedidoList", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = null;
            }
            return retorno;
        }

        public bool PedidoConfirm(long pedidoId)
        {
            bool retorno = false;
            try
            {
                SyncPedidoVenda.SyncPedidoVenda webservice = Webservices.PedidoVenda();
                url = webservice.Url;
                retorno = webservice.Complete(Token(), pedidoId);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "PedidoConfirm", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }

            return retorno;
        }

        public bool PedidoUpdateStatus(IntegracaoPedidoStatusInfo pedido)
        {
            bool retorno = false;
            try
            {
                SyncPedidoStatus.SyncPedidoStatus webservice = Webservices.PedidoStatus();
                url = webservice.Url;
                retorno = webservice.UpdateStatus(Token(), pedido);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "PedidoUpdateStatus", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }
            return retorno;
        }

        #endregion

        #region Estoque
        public bool EstoqueUpdate(IntegracaoItemEstoqueInfo estoque)
        {
            bool retorno = false;
            try
            {
                SyncEstoque.SyncEstoque webservice = Webservices.Estoque();
                url = webservice.Url;
                retorno = webservice.Update(Token(), estoque);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "EstoqueUpdate", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }
            return retorno;
        }
        #endregion

        #region Imagem
        public bool ImagemInserir(string sku, string imagemBase64, string imagemFormato, bool isPrincipal)
        {
            bool retorno = false;
            try
            {
                SyncProdutoImagem.SyncProdutoImagem webservice = Webservices.ProdutoImagem();
                url = webservice.Url;
                retorno = webservice.Insert(Token(), sku, imagemBase64, imagemFormato, isPrincipal);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ImagemInserir", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }
            return retorno;
        }

        public bool ImagemDelete(string sku, string imagemBase64)
        {
            bool retorno = false;
            try
            {
                SyncProdutoImagem.SyncProdutoImagem webservice = Webservices.ProdutoImagem();
                url = webservice.Url;
                retorno = webservice.Delete(Token(), sku);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ImagemDelete", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }

            return retorno;
        }
        #endregion

        #region Combo
        public bool ComboInserir(IntegracaoProdutoCombo combo)
        {
            bool retorno = false;
            try
            {
                SyncProdutoCombo.SyncProdutoCombo webservice = Webservices.ProdutoCombo();
                url = webservice.Url;
                retorno = webservice.Insert(Token(), combo);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ComboInserir", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }

            return retorno;
        }
        #endregion

        #region Preço
        public bool PrecoAtualizar(IntegracaoProdutoPrecoInfo preco)
        {
            bool retorno = false;
            try
            {
                SyncProdutoPreco.SyncProdutoPreco webservice = Webservices.ProdutoPreco();
                url = webservice.Url;
                retorno = webservice.Update(Token(), preco);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "PrecoAtualizar", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }

            return retorno;
        }
        #endregion

        #region Categoria de produto
        public bool CategoriaProdutoInserir(IntegracaoProdutoCategoriaInfo categoriaproduto)
        {
            bool retorno = false;
            try
            {
                SyncProdutoCategoria.SyncProdutoCategoria webservice = Webservices.ProdutoCategoria();
                url = webservice.Url;
                retorno = webservice.Insert(Token(), categoriaproduto);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "CategoriaProdutoInserir", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }

            return retorno;
        }

        public bool CategoriaProdutoDelete(string Categoria, string SKU)
        {
            bool retorno = false;
            try
            {
                SyncProdutoCategoria.SyncProdutoCategoria webservice = Webservices.ProdutoCategoria();
                url = webservice.Url;
                retorno = webservice.Delete(Token(), Categoria, SKU);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "CategoriaProdutoDelete", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }

            return retorno;
        }
        #endregion

        #region Fornecedor
        public bool FornecedorInserir(IntegracaoProdutoFornecedorInfo fornecedor)
        {
            bool retorno = false;
            try
            {
                SyncProdutoFornecedor.SyncProdutoFornecedor webservice = Webservices.ProdutoFornecedor();
                url = webservice.Url;
                retorno = webservice.Sync(Token(), fornecedor);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "FornecedorInserir", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }

            return retorno;
        }
        #endregion

        #region Produto
        public bool ProdutoInserir(IntegracaoProdutoVarianteInfo Produto)
        {
            bool retorno = false;
            try
            {
                SyncProduto.SyncProduto webservice = Webservices.Produto();
                url = webservice.Url;
                retorno = webservice.Insert(Token(), Produto);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ProdutoInserir", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }
            return retorno;
        }

        public bool ProdutoExiste(string sku)
        { 
            bool retorno = false;
            try
            {
                SyncProduto.SyncProduto webservice = Webservices.Produto();
                url = webservice.Url;
                retorno = (webservice.GetProdutoIdBySKU(Token(), sku).Count() > 0);               
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.FBits", "ProdutoExiste", string.Format("URL: {0} " + Environment.NewLine + " Erro: {1}", url, ex.ToString()));
                retorno = false;
            }
            return retorno;
        }

        #endregion
    }
}

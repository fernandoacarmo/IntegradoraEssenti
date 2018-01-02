using Integradora.ECommerce.Magento002.MagentoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Magento002
{
    public sealed class Integracao : Integradora.ECommerce.Lojavirtual
    {
        private string Sessao { get; set; }
        private string StoreID = "1";
        private string TypeProduto = "simple";
        private string IdentifierType = "sku";

        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.Magento;
        }
        public override void Initialize()
        {
            CriarCreditoParaCliente = false;
        }

        #region Conexão
        private MagentoService.PortTypeClient WebServiceAbrir()
        {
            try
            {
                string url = Biblioteca.Dictionaries.Settings.Magento002_Url();
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "MagentoService.PortType";
                binding.MaxReceivedMessageSize = 2147483647;
                binding.MaxBufferSize = 2147483647;
                binding.Security.Mode = BasicHttpSecurityMode.Transport;
                //Endereço do webservice
                EndpointAddress remoteAddress = new EndpointAddress(url);
                //Carregando o webservice
                MagentoService.PortTypeClient cliente = new MagentoService.PortTypeClient(binding, remoteAddress);
                //Configurando TimeOut
                cliente.Endpoint.Binding.SendTimeout = new TimeSpan(0, 2, 30);
                cliente.Endpoint.Binding.ReceiveTimeout = new TimeSpan(0, 2, 30);
                cliente.Endpoint.Binding.OpenTimeout = new TimeSpan(0, 2, 30);
                cliente.Endpoint.Binding.CloseTimeout = new TimeSpan(0, 2, 30);

                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                string usuario = Biblioteca.Dictionaries.Settings.Magento002_Username();
                string senha = Biblioteca.Dictionaries.Settings.Magento002_Password();

                Sessao = cliente.login(usuario, senha);

                return cliente;
            }
            catch (Exception ex)
            {
                Sessao = "";
                Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "WebService  Abrir", ex.ToString());
                return null;
            }
        }
        private void WebServiceFechar(MagentoService.PortTypeClient conexao)
        {
            try
            {
                try
                {
                    //Fechando a conexão
                            if (conexao != null)
                            {
                                conexao.endSession(Sessao);
                                conexao.Close();
                            }
                }
                catch
                {
                }
            }
            finally
            {
                //Limpando o código da sessão pagara gerar uma nova
                Sessao = "";
            }
        }
        #endregion

        #region Funções auxiliares
        private string ObterSetID(string categoria)
        {
            var Conector = WebServiceAbrir();
            string retorno = "-1";
            if (Conector != null)
            {
                try
                {
                    catalogProductAttributeSetEntity SetDefault = new catalogProductAttributeSetEntity();

                    var SetList = Conector.catalogProductAttributeSetList(Sessao);
                    foreach (var item in SetList)
                    {
                        if (item.name.ToUpper() == "DEFAULT")
                        {
                            SetDefault = item;
                        }
                        if (item.name.ToUpper() == categoria.ToUpper())
                        {
                            retorno = item.set_id.ToString();
                        }
                    }

                    if ((SetDefault != null) && (retorno == "-1"))
                    {
                        retorno = SetDefault.set_id.ToString();
                    }
                    else
                    {
                        retorno = "-1";
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }
        #endregion

        #region Produtos
        public catalogProductEntity[] ProdutoListar()
        {
            var Conector = WebServiceAbrir();
            catalogProductEntity[] products = null;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        products = Conector.catalogProductList(Sessao, null, StoreID);

                        return products;
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "ProdutoListar", ex.ToString());
                        products = null;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return products;
        }

        public int ProdutoInserir(catalogProductCreateEntity registro, string sku, string categoria)
        {
            var Conector = WebServiceAbrir();
            int retorno = -1;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        string categoria_id = ObterSetID(categoria);

                        retorno = Conector.catalogProductCreate(Sessao
                                                            , TypeProduto
                                                            , categoria_id
                                                            , sku
                                                            , registro
                                                            , StoreID);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "ProdutoInserir", ex.ToString());
                        retorno = -1;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }

        public bool ProdutoAlterar(catalogProductCreateEntity registro, string Product_Id)
        {
            var Conector = WebServiceAbrir();
            bool retorno = false;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.catalogProductUpdate(Sessao
                                                            , Product_Id
                                                            , registro
                                                            , StoreID
                                                            , "Product_Id");
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "ProdutoAlterar", "Produto: " + Product_Id + " - Erro: " + ex.ToString());
                        retorno = false;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }
        public associativeEntity ProdutoAtributoCriar(string chave, string valor)
        {
            associativeEntity atributo = new associativeEntity();
            atributo.key = chave;
            atributo.value = string.IsNullOrEmpty(valor) ? "-" : valor;

            return atributo;
        }

        public catalogProductReturnEntity ProdutoCarregar(string Product_Id)
        {
            var Conector = WebServiceAbrir();
            catalogProductReturnEntity retorno = null;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        catalogProductRequestAttributes atributos = new catalogProductRequestAttributes();
                        //atributos.attributes = new string[] { "name", "description", "short_description", "meta_description", "meta_keyword", "tax_class_id", "url_key", "url_path" };
                        atributos.additional_attributes = new string[] { "ean" };

                        retorno = Conector.catalogProductInfo(Sessao
                                                          , Product_Id
                                                          , StoreID
                                                          , atributos
                                                          , "Product_Id"
                                                          );
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "ProdutoCarregar", ex.ToString());
                        retorno = null;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }

        public string ProdutoEan(string sku)
        {
            var Conector = WebServiceAbrir();
            string resultado = "";
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        catalogProductRequestAttributes atributos = new catalogProductRequestAttributes();
                        atributos.attributes = new string[] { "name", "description", "short_description", "meta_description", "meta_keyword", "tax_class_id", "url_key", "url_path" };
                        atributos.additional_attributes = new string[] { "ean" };

                        catalogProductReturnEntity retorno = Conector.catalogProductInfo(Sessao
                                                               , sku
                                                               , StoreID
                                                               , atributos
                                                               , IdentifierType);
                        if (retorno != null)
                        {
                            if (retorno.additional_attributes.Count() > 0)
                            {
                                resultado = retorno.additional_attributes[0].value;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "ProdutoEan", "Código EAN não localizado para o produto: " + sku);
                        resultado = "";
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }

            return resultado;
        }
        public int ProdutoExcluir(string sku)
        {
            var Conector = WebServiceAbrir();
            int retorno = -1;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.catalogProductDelete(Sessao
                                                            , sku
                                                            , IdentifierType);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "ProdutoExcluir", ex.ToString());
                        retorno = -1;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }

        #endregion

        #region Categorias
        public int CategoriaInserir(int CategoriaPai, catalogCategoryEntityCreate registro)
        {
            var Conector = WebServiceAbrir();
            int retorno = -1;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.catalogCategoryCreate(Sessao, CategoriaPai, registro, StoreID);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "CategoriaInserir", ex.ToString());
                        retorno = -1;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }

        public bool CategoriaAlterar(int CategoriaPai, catalogCategoryEntityCreate registro)
        {
            var Conector = WebServiceAbrir();
            bool retorno = false;
            if (Conector != null)
            {

                try
                {
                    try
                    {
                        retorno = Conector.catalogCategoryUpdate(Sessao, CategoriaPai, registro, StoreID);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "CategoriaAlterar", ex.ToString());
                        retorno = false;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }

        public bool CategoriaExcluir(int CategoriaID)
        {
            var Conector = WebServiceAbrir();
            bool retorno = false;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.catalogCategoryDelete(Sessao, CategoriaID);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "CategoriaExcluir", ex.ToString());
                        retorno = false;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }
        #endregion

        #region Clientes
        public bool ClienteExcluir(int CustomerID)
        {
            var Conector = WebServiceAbrir();
            bool retorno = false;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.customerCustomerDelete(Sessao, CustomerID);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "ClienteExcluir", ex.ToString());
                        retorno = false;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }
        public int ClienteIncluir(customerCustomerEntityToCreate registro)
        {
            var Conector = WebServiceAbrir();
            int retorno = -1;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.customerCustomerCreate(Sessao, registro);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "ClienteIncluir", ex.ToString());
                        retorno = -1;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
                
        }
        public bool ClienteAlterar(customerCustomerEntityToCreate registro, int CustomerID)
        {
            var Conector = WebServiceAbrir();
            bool retorno = false;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.customerCustomerUpdate(Sessao, CustomerID, registro);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "ClienteAlterar", ex.ToString());
                        retorno = false;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }

        public string EstadoCarregar(string region)
        {
            string resultado = "";
            var Conector = WebServiceAbrir();
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        directoryRegionEntity[] ListaEstados = Conector.directoryRegionList(Sessao, "BR");

                        foreach (var item in ListaEstados)
                        {
                            if (item.region_id == region)
                            {
                                resultado = item.code.ToUpper();
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "Estado", ex.ToString());
                        resultado = "";
                    }
                    return resultado;
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return resultado;
        }
        public customerCustomerEntity ClienteCarregar(int CustomerID)
        {
            var Conector = WebServiceAbrir();
            customerCustomerEntity retorno = null;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        string[] atributos = new string[6];

                        atributos[0] = "email";
                        atributos[1] = "taxvat";
                        atributos[2] = "firstname";
                        atributos[3] = "middlename";
                        atributos[4] = "lastname";
                        atributos[5] = "dob";

                        retorno = Conector.customerCustomerInfo(Sessao, CustomerID, atributos);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "ClienteCarregar", ex.ToString());
                        retorno = null;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }


        #endregion

        #region Pedidos
        public salesOrderListEntity[] PedidosListar(string statusPedido)
        {
            var Conector = WebServiceAbrir();
            salesOrderListEntity[] retorno = null;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        //Conjunto de filtro
                        complexFilter[] ConjuntoFiltro = new complexFilter[3];
                        complexFilter Filtro = new complexFilter();
                        associativeEntity ChaveValor = new associativeEntity();

                        #region Filtro da data inicial
                        ChaveValor.key = "from";
                        ChaveValor.value = (DateTime.Now.Date.AddDays(-7)).ToString();

                        Filtro.key = "created_at";
                        Filtro.value = ChaveValor;

                        ConjuntoFiltro[0] = Filtro;
                        #endregion

                        #region Filtro da data final
                        ChaveValor.key = "to";
                        ChaveValor.value = (DateTime.Now.Date).ToString();

                        Filtro.key = "created_at"; 
                        Filtro.value = ChaveValor;

                        ConjuntoFiltro[1] = Filtro;
                        #endregion

                        #region Posicao do pedido
                        ChaveValor.key = "eq";
                        ChaveValor.value = statusPedido;

                        Filtro.key = "status";
                        Filtro.value = ChaveValor;

                        ConjuntoFiltro[2] = Filtro;
                        #endregion

                        //Coletor de filtro
                        filters ColecaoFiltros = new filters();
                        ColecaoFiltros.complex_filter = ConjuntoFiltro;

                        retorno = Conector.salesOrderList(Sessao, ColecaoFiltros);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "PedidosListar", ex.ToString());
                        retorno = null;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }

        public salesOrderEntity PedidosCarregar(string numeroPedido)
        {
            var Conector = WebServiceAbrir();
            salesOrderEntity retorno = null;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.salesOrderInfo(Sessao, numeroPedido);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "PedidosCarregar", ex.ToString());
                        retorno = null;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }

        public bool PedidoCancelar(string numeroPedidoECommerce)
        {
            int retorno = -1;
            var Conector = WebServiceAbrir();
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        //Modificando o status
                        retorno = Conector.salesOrderCancel(Sessao
                                                           , numeroPedidoECommerce
                                                           );
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "PedidoCancelar", ex.ToString());
                        retorno = -1;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno > 0;
        }

        public string GerarPagamento(string numeroPedidoECommerce)
        { 
            string retorno = "";
            var Conector = WebServiceAbrir();
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        //Modificando o status
                        orderItemIdQty[] item = new orderItemIdQty[1];

                        retorno = Conector.salesOrderInvoiceCreate( Sessao
                                                                  , numeroPedidoECommerce
                                                                  , item
                                                                  , "Pagamento realizado"
                                                                  , ""
                                                                  , "S"
                                                                  );
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "GerarPagamento", ex.ToString());
                        retorno = "";
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno;
        }
        
        public bool PedidosAtualizarStatus(string numeroPedidoECommerce
                                          , string novoStatus
                                          , string comentario
                                          , Integradora.Biblioteca.Dictionaries.Tips.SimNao enviarMsg
                                          , string numeroPedidoERP
                                          , string numeroPedidoMarketPlace
                                          , string eMailCliente
                                          , string chaveNFe
                                          , string serieNF
                                          , string numeroNF)
        {
            int retorno = -1;
            var Conector = WebServiceAbrir();
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        //Modificando o status
                        retorno = Conector.salesOrderAddComment(Sessao
                                                            , numeroPedidoECommerce
                                                            , novoStatus
                                                            , comentario
                                                            , 1);

                        if (retorno > -1)
                        {
                            if (novoStatus == "faturado")
                            {
                                #region Informação obrigatório no filtro
                                orderItemIdQty item = new orderItemIdQty();
                                item.order_item_id = 1;
                                item.qty = 1;

                                orderItemIdQty[] ItemNF = new orderItemIdQty[1];
                                ItemNF[0] = item;
                                #endregion

                                #region Dados da nota fiscal gerada
                                //salesInvoiceCustomParams dadosNF = new salesInvoiceCustomParams();
                                //dadosNF.nf_chave = chaveNFe;
                                //dadosNF.nf_serie = serieNF;
                                //dadosNF.nf_link = "";
                                //dadosNF.nf_numero = numeroNF;
                                #endregion

                                Conector.salesOrderInvoiceCreate(Sessao
                                                                , numeroPedidoECommerce
                                                                , ItemNF
                                                                , ""
                                                                , eMailCliente
                                                                , ""
                                    //, dadosNF
                                                                );
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "PedidosAtualizarStatus", ex.ToString());
                        retorno = -1;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return retorno > 0;
        }
        #endregion

        public void EnviarEstoque(string sku, decimal qtde)
        {
            int retorno = -1;
            var Conector = WebServiceAbrir();
            if (Conector != null)
            {
                try
                {

                    try
                    {
                        catalogProductRequestAttributes atributos = new catalogProductRequestAttributes();
                        //atributos.attributes = new string[] { "name", "product_id", "description", "short_description", "meta_description", "meta_keyword", "tax_class_id", "url_key", "url_path" };
                        atributos.attributes = new string[] { "product_id" };
                        catalogProductReturnEntity produto = null;
                        try
                        {
                             produto = Conector.catalogProductInfo(Sessao
                                                                   , sku
                                                                   , StoreID
                                                                   , atributos
                                                                   , IdentifierType);
                        }
                        catch (Exception ex)
                        {
                            Biblioteca.Tools.Logs.GerarLog( "Integradora.ECommerce.Magento002"
                                                          , "EnviarEstoque"
                                                          , "Erro ao buscar cadastro do produto: " + sku + " - " +ex.ToString());
                            WebServiceFechar(Conector);
                            produto = null;
                        }

                        if (produto != null)
                        {
                            //Modificando o status
                            catalogInventoryStockItemUpdateEntity dados = new catalogInventoryStockItemUpdateEntity();
                            dados.qty = qtde.ToString();
                            dados.is_in_stock = qtde > 0 ? 1 : 0;
                            dados.is_in_stockSpecified = true;
                            dados.is_qty_decimal = 1;
                            dados.is_qty_decimalSpecified = true;

                            retorno = Conector.catalogInventoryStockItemUpdate( Sessao
                                                                              , produto.product_id
                                                                              , dados
                                                                              );
                        }
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "EnviarEstoque", "Erro ao enviar estoque do produto: " + sku + " - " + ex.ToString());
                        WebServiceFechar(Conector);
                        retorno = -1;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
        }

        public void EnviarPreco(string sku, decimal? preco)
        {
            var Conector = WebServiceAbrir();
            bool retorno = false;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        catalogProductCreateEntity registro = new catalogProductCreateEntity();
                        registro.price = preco.ToString();
                        //registro.special_price = preco.ToString();

                        retorno = Conector.catalogProductUpdate( Sessao
                                                               , sku
                                                               , registro
                                                               , StoreID
                                                               , IdentifierType);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento002", "EnviarPreco", "Produto/SKU: " + sku + " - Erro: " + ex.ToString());
                        retorno = false;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
        }
    }
}

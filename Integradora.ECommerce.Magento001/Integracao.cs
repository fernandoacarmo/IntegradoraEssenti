using Integradora.ECommerce.Magento001.MagentoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Magento001
{
    public sealed class Integracao : Integradora.ECommerce.Lojavirtual
    {
        private string Sessao { get; set; }
        private string StoreID = "1";
        private string TypeProduto = "simple";
        private string IdentifierType = "sku";
        private catalogAttributeEntity[] listaAtributosObrigatorios;

        public catalogAttributeEntity[] ListaAtributosObrigatorios
        {
            get
            {
                if (listaAtributosObrigatorios == null)
                {
                    listaAtributosObrigatorios = ProdutoAtributosObrigatorio(Biblioteca.Dictionaries.Settings.MagentoGrupoAtributo());
                }
                return listaAtributosObrigatorios;
            }
            set
            {
                listaAtributosObrigatorios = value;
            }
        }

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
                string url = Biblioteca.Dictionaries.Settings.Magento001_Url();
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

                string usuario = Biblioteca.Dictionaries.Settings.Magento001_Username();
                string senha = Biblioteca.Dictionaries.Settings.Magento001_Password();

                Sessao = cliente.login(usuario, senha);

                return cliente;
            }
            catch (Exception ex)
            {
                Sessao = "";
                Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "WebServiceAbrir", ex.ToString());
                return null;
            }
        }
        private void WebServiceFechar(MagentoService.PortTypeClient conexao)
        {
            try
            {
                //Fechando a conexão
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
            catch
            {
            }
            //Limpando o código da sessão pagara gerar uma nova
            Sessao = "";
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
                            break;
                        }
                    }

                    if ((SetDefault != null) && (retorno == "-1"))
                    {
                        retorno = SetDefault.set_id.ToString();
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

                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "ProdutoListar", ex.ToString());
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

        public int ProdutoPersistir(catalogProductCreateEntity registro, string sku, string categoria, string Loja)
        {
            if (string.IsNullOrEmpty(Loja))
            {
                Loja = StoreID;
            }

            int resultado = -1;
            Biblioteca.Tools.XML.Export(registro, sku);
            try
            {
                //Verificando se o produto existe
                catalogProductReturnEntity produto = null;
                //Pesquisa pelo SKU
                produto = ProdutoExiste(sku, "sku", Loja);
                if (produto == null)
                {  //Senao achou pesquisa pelo product_id
                    produto = ProdutoExiste(sku, "product_id", Loja);
                }

                if (produto != null) //Senão existe insere o produto 
                {
                    //Mantendo algumas informações alterado no próprio site
                    registro.description = produto.description;
                    registro.short_description = produto.short_description;
                    registro.meta_description = produto.meta_description;
                    registro.meta_keyword = produto.meta_keyword;
                    registro.meta_title = produto.meta_title;
                    registro.name = produto.name;
                    registro.tax_class_id = produto.tax_class_id;
                    registro.url_key = produto.url_key;
                    registro.url_path = produto.url_path;

                    sku = produto.sku;

                    resultado = ProdutoAlterar(registro, sku, Loja) ? 1 : -1;
                }
                else //Senão atualiza o cadastro do prdouto 
                {
                    resultado = ProdutoInserir(registro, sku, categoria, Loja);
                }
            }
            catch (Exception ex)
            {
                Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "ProdutoPersistir", ex.ToString());
                resultado = -1;
            }
            return resultado;
        }

        public catalogProductReturnEntity ProdutoExiste(string codigo, string TipoCampo, string Loja)
        {
            var Conector = WebServiceAbrir();

            if (string.IsNullOrEmpty(Loja))
                Loja = StoreID;

            catalogProductReturnEntity retorno = null;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        catalogProductRequestAttributes atributo = new catalogProductRequestAttributes();
                        atributo.attributes = new string[]
                 {    "name"
                    , "description"
                    , "short_description" 
                    , "meta_description"
                    , "meta_keyword"
                    , "tax_class_id"
                    , "url_key"
                    , "url_path"
                };

                        retorno = Conector.catalogProductInfo(Sessao
                                                             , codigo //productid
                                                             , Loja
                                                             , atributo
                                                             , TipoCampo
                                                             );
                    }
                    catch
                    {
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
        private int ProdutoInserir(catalogProductCreateEntity registro, string sku, string categoria, string Loja)
        {
            string categoria_id = ObterSetID(categoria);
            int retorno = -1;
            var Conector = WebServiceAbrir();
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.catalogProductCreate(Sessao
                                                               , TypeProduto
                                                               , categoria_id
                                                               , sku
                                                               , registro
                                                               , Loja);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001"
                                                      , "ProdutoInserir"
                                                      , string.Format("Erro ao inserir produto: {0} - Erro: {1}", sku, ex.ToString()));
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

        private bool ProdutoAlterar(catalogProductCreateEntity registro, string sku, string Loja)
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
                                                               , sku
                                                               , registro
                                                               , Loja 
                                                               , IdentifierType);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001"
                                                      , "ProdutoAlterar"
                                                      , string.Format("Erro ao atualizar produto: {0} - Erro: {1}", sku, ex.ToString()));
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

        public int ProdutoExcluir(catalogProductCreateEntity registro, string sku)
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
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "ProdutoExcluir", ex.ToString());
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

        public associativeEntity ProdutoAtributoSimplesCriar(string chave, string valor)
        {
            associativeEntity atributo = new associativeEntity();
            atributo.key = chave;
            try
            {
                atributo.value = string.IsNullOrEmpty(valor) ? "" : valor;
            }
            catch
            {
                atributo.value = "";
            }

            return atributo;
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
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "CategoriaInserir", ex.ToString());
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
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "CategoriaAlterar", ex.ToString());
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
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "CategoriaExcluir", ex.ToString());
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
            bool resultado = false;
            if (CustomerID > 0)
            {
                var Conector = WebServiceAbrir();
                if (Conector != null)
                {
                    try
                    {
                        try
                        {
                            resultado = Conector.customerCustomerDelete(Sessao, CustomerID);
                        }
                        catch (Exception ex)
                        {
                            Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "ClienteExcluir", ex.ToString());
                            resultado = false;
                        }
                    }
                    finally
                    {
                        WebServiceFechar(Conector);
                    }
                }
            }
            return resultado;
        }

        public int ClientePersistir(customerCustomerEntityToCreate registro, customerAddressEntityCreate endereco, int CustomerID)
        {
            int resultado = -1;
            try
            {
                bool Encontrou = false;

                if (ClienteExiste("taxvat", registro.taxvat, registro))
                {
                    Encontrou = true;
                    CustomerID = registro.customer_id;
                }
                else
                {
                    if ((!string.IsNullOrEmpty(registro.email)) && (ClienteExiste("email", registro.email, registro)))
                    {
                        Encontrou = true;
                        CustomerID = registro.customer_id;
                    }
                    else
                    {
                        if ((registro.customer_id > 0) && (ClienteExiste("customer_id", registro.customer_id.ToString(), registro)))
                        {
                            Encontrou = true;
                            CustomerID = registro.customer_id;
                        }

                    }
                }

                if (Encontrou)
                {
                    resultado = ClienteAlterar(registro, CustomerID);
                }
                else
                {
                    resultado = ClienteIncluir(registro);
                }

                if (resultado > 0)
                {
                    ClienteEndereco(endereco, resultado);
                }
            }
            catch (Exception ex)
            {
                Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "ProdutoPersistir", ex.ToString());
                resultado = -1;
            }
            return resultado;
        }

        private void ClienteEndereco(customerAddressEntityCreate endereco, int CustomerID)
        {
            if (CustomerID > 0)
            {
                var Conector = WebServiceAbrir();
                if (Conector != null)
                {
                    try
                    {
                        try
                        {
                            customerAddressEntityItem[] listaEnderecos = Conector.customerAddressList(Sessao, CustomerID);
                            if (listaEnderecos.Count() > 0)
                            {
                                Conector.customerAddressUpdate(Sessao, listaEnderecos[0].customer_address_id, endereco);
                            }
                            else
                            {
                                Conector.customerAddressCreate(Sessao, CustomerID, endereco);
                            }

                        }
                        catch (Exception ex)
                        {
                            Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "ClienteEndereco", ex.ToString());
                            //resultado = false;
                        }
                    }
                    finally
                    {
                        WebServiceFechar(Conector);
                    }
                }
            }
        }

        public bool ClienteExiste(string campoPesquisa, string valorPesquisa, customerCustomerEntityToCreate registro)
        {
            bool resultado = false;
            if (string.IsNullOrEmpty(campoPesquisa))
                return false;

            if (string.IsNullOrEmpty(valorPesquisa))
                return false;

            var Conector = WebServiceAbrir();
            if (Conector != null)
            {
                try
                {
                    filters filtro = new filters();
                    try
                    {
                        associativeEntity itemfiltro = new associativeEntity();
                        itemfiltro.key = campoPesquisa;
                        itemfiltro.value = valorPesquisa;

                        associativeEntity[] listafiltro = new associativeEntity[1];
                        listafiltro[0] = itemfiltro;

                        filtro.filter = listafiltro;
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001"
                                                      , "ClienteExiste"
                                                      , "Erro ao montar filtro de pesquisa de cliente" + Environment.NewLine
                                                      + "Campo: " + campoPesquisa + Environment.NewLine
                                                      + "Valor: " + valorPesquisa + Environment.NewLine
                                                      + "Erro: " + ex.ToString());
                        resultado = false;
                    }

                    customerCustomerEntity[] retorno = null;
                    try
                    {
                        retorno = Conector.customerCustomerList(Sessao, filtro);

                        if (retorno != null)
                        {
                            resultado = retorno[0].customer_id > 0;

                            if (resultado)
                            {
                                registro.customer_id = retorno[0].customer_id;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001"
                                                      , "ClienteExiste"
                                                      , "Erro no retorno dos dados do cliente" + Environment.NewLine
                                                      + "Campo: " + campoPesquisa + Environment.NewLine
                                                      + "Valor: " + valorPesquisa + Environment.NewLine
                                                      + "Erro: " + ex.ToString());
                        resultado = false;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }


            return resultado;
        }
        public int ClienteIncluir(customerCustomerEntityToCreate registro)
        {
            int resultado = -1;
            var Conector = WebServiceAbrir();
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        Biblioteca.Tools.XML.Export(registro, string.Format("cliente_{0}", registro.customer_id));

                        resultado = Conector.customerCustomerCreate(Sessao, registro);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "ClienteIncluir", ex.ToString());
                        resultado = -1;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return resultado;
        }
        public int ClienteAlterar(customerCustomerEntityToCreate registro, int CustomerID)
        {
            int resultado = -1;
            var Conector = WebServiceAbrir();
            Biblioteca.Tools.XML.Export(registro, string.Format("clientecadastrado_{0}", registro.customer_id));
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        if (Conector.customerCustomerUpdate(Sessao, CustomerID, registro))
                        {
                            resultado = CustomerID;
                        }
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "ClienteAlterar", ex.ToString());
                        resultado = -1;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }
            return resultado;
        }

        public customerAddressEntityItem[] CarregarEndereco(int CustomerID)
        {
            var Conector = WebServiceAbrir();
            customerAddressEntityItem[] retorno = null;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.customerAddressList(Sessao, CustomerID);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "CarregarEndereco", ex.ToString());
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
                        atributos[5] = "customer_id";

                        retorno = Conector.customerCustomerInfo(Sessao, CustomerID, atributos);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "ClienteCarregar", ex.ToString());
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

        public bool PedidoCancelar(string numeroPedidoECommerce)
        {
            bool retorno = false;
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
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "PedidoCancelar", ex.ToString());
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
                        ChaveValor.value = (DateTime.Now.Date.AddDays(-70)).ToString();

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
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "PedidosListar", ex.ToString());
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

        public int EnviarPrecoPromocional(string produto, string preco, DateTime dataInicial, DateTime datafinal)
        { 
            var Conector = WebServiceAbrir();
            int retorno = -1;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.catalogProductSetSpecialPrice( Sessao
                                                                        , produto
                                                                        , preco
                                                                        , dataInicial.ToString()
                                                                        , datafinal.ToString()
                                                                        , StoreID
                                                                        , "");
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001"
                                                      , "EnviarPrecoPromocional"
                                                      , string.Format("Preço {0} enviado para o produto {1}, para o periodo: {2} à {3} - Retorno: {4}"
                                                                     , preco, produto, dataInicial.ToString(), datafinal.ToString(), retorno.ToString()
                                                                     ));
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "EnviarPrecoPromocional", ex.ToString());
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
        public salesOrderInfoCustomEntity PedidosCarregar(string numeroPedido)
        {
            var Conector = WebServiceAbrir();
            salesOrderInfoCustomEntity retorno = null;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.salesOrderInfoCustom(Sessao, numeroPedido);

                        if (retorno != null)
                            Biblioteca.Tools.XML.Export(retorno, numeroPedido);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "PedidosCarregar", ex.ToString());
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
            bool retorno = false;
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
                                                            , enviarMsg.ToString()
                                                            , numeroPedidoERP
                                                            , numeroPedidoMarketPlace);

                        if (retorno)
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
                                salesInvoiceCustomParams dadosNF = new salesInvoiceCustomParams();
                                dadosNF.nf_chave = chaveNFe;
                                dadosNF.nf_serie = serieNF;
                                dadosNF.nf_link = "";
                                dadosNF.nf_numero = numeroNF;
                                #endregion

                                Conector.salesOrderInvoiceCreate(Sessao
                                                                , numeroPedidoECommerce
                                                                , ItemNF
                                                                , ""
                                                                , eMailCliente
                                                                , ""
                                                                , dadosNF
                                                                );
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "PedidosAtualizarStatus", ex.ToString());
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


        public catalogAttributeEntity[] ProdutoAtributosObrigatorio(string GrupoAtributoEspecial)
        {
            catalogAttributeEntity[] retorno = null;
            if (!string.IsNullOrEmpty(GrupoAtributoEspecial))
            {
                string categoria = ObterSetID(GrupoAtributoEspecial);

                if (categoria != "-1")
                {
                    var Conector = WebServiceAbrir();
                    if (Conector != null)
                    {
                        try
                        {
                            try
                            {
                                retorno = Conector.catalogProductAttributeList(Sessao, Convert.ToInt32(categoria));
                            }
                            catch (Exception ex)
                            {
                                Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "ProdutoAtributosObrigatorio", ex.ToString());
                                retorno = null;
                            }
                        }
                        finally
                        {
                            WebServiceFechar(Conector);
                        }
                    }
                }
            }

            return retorno;
        }

        public bool ProdutoAtributosValorCriar(int idAtributo, string valor)
        {
            bool retorno = false;
            var Conector = WebServiceAbrir();
            if (Conector != null)
            {
                try
                {
                    try
                    {

                        string[] storeIdLocal = new string[2];
                        storeIdLocal[0] = "0";
                        storeIdLocal[1] = StoreID;

                        catalogProductAttributeOptionLabelEntity label = new catalogProductAttributeOptionLabelEntity();
                        label.value = valor;
                        label.store_id = storeIdLocal;

                        catalogProductAttributeOptionLabelEntity[] labelLocal = new catalogProductAttributeOptionLabelEntity[1];
                        labelLocal[0] = label;

                        catalogProductAttributeOptionEntityToAdd data = new catalogProductAttributeOptionEntityToAdd();
                        data.order = 0;
                        data.is_default = 1;
                        data.label = labelLocal;

                        retorno = Conector.catalogProductAttributeAddOption(Sessao
                                                                           , idAtributo.ToString()
                                                                           , data);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "ProdutoAtributosValorCriar", ex.ToString());
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

        public catalogAttributeOptionEntity[] ListarAtributaosOpcao(int idAtributo)
        {
            var Conector = WebServiceAbrir();
            catalogAttributeOptionEntity[] retorno = null;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        retorno = Conector.catalogProductAttributeOptions(Sessao, idAtributo.ToString(), StoreID);
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001"
                                                     , "ListarAtributaosOpcao"
                                                     , ex.ToString());
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

        public associativeMultiEntity ProdutoAtributoMultiploCriar(string chave, string valor)
        {
            associativeMultiEntity atributo = new associativeMultiEntity();
            atributo.key = chave;
            try
            {
                if (!string.IsNullOrEmpty(valor))
                {
                    atributo.value = valor.Split(',');
                    int i = 0;
                    foreach (var item in atributo.value)
                    {
                        if (!string.IsNullOrEmpty(item))
                        {
                            atributo.value[i] = item.Trim().TrimEnd().TrimStart();
                        }
                        i++;
                    }
                }
            }
            catch
            {

            }

            return atributo;
        }

        public string ObterIDAtributo(int idAtributo, string Valor)
        {
            var Conector = WebServiceAbrir();
            string retorno = Valor;
            if (Conector != null)
            {
                try
                {
                    try
                    {
                        catalogProductAttributeEntity dados = Conector.catalogProductAttributeInfo(Sessao, idAtributo.ToString());

                        catalogAttributeOptionEntity registro = dados.options.Where(c => c.label.ToUpper() == Valor.ToUpper()).FirstOrDefault();
                        if (registro != null)
                        {
                            retorno = registro.value;
                        }
                    }
                    catch (Exception ex)
                    {
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001"
                                                      , "ObterIDAtributo"
                                                      , ex.ToString());
                        retorno = Valor;
                    }
                }
                finally
                {
                    WebServiceFechar(Conector);
                }
            }

            return retorno;
        }

        #region Carrinho de comrpa
        public int EnviarCarrinho( shoppingCartCustomerEntity cliente
                                 , shoppingCartCustomerAddressEntity[] enderecos
                                 , shoppingCartPaymentMethodEntity formaPagamento
                                 , shoppingCartProductEntity[] produtos
                                 , string Loja
                                 , decimal ValorFrete
                                 , decimal NumeroPedido
                                 )
        {
            int numCarrinho = -1;
            string resultado = "0";
            string tipoFrete = ValorFrete > 0 ? "shopp_custom_price_standard" : "freeshipping_freeshipping";

            if (string.IsNullOrEmpty(Loja))
            {
                Loja = StoreID;
            }
            //Abrindo conexão com o webservice do Magento
            var Conector = WebServiceAbrir();
            if (Conector != null)
            {
                try
                {
                    try
                    { //Abrindo carrinho 
                        numCarrinho = Conector.shoppingCartCreate(Sessao, StoreID);
                        if (numCarrinho > 0)
                        {  //Enviar cliente
                            Biblioteca.Tools.XML.Export(cliente, string.Format("{0}_cliente", numCarrinho.ToString()));
                            Biblioteca.Tools.XML.Export(enderecos, string.Format("{0}_enderecos", numCarrinho.ToString()));
                            Biblioteca.Tools.XML.Export(formaPagamento, string.Format("{0}_pagamento", numCarrinho.ToString()));
                            Biblioteca.Tools.XML.Export(produtos, string.Format("{0}_produtos", numCarrinho.ToString()));

                            bool sucesso = Conector.shoppingCartCustomerSet(Sessao, numCarrinho, cliente, Loja);
                            if (sucesso)
                            {   //Enviar endereços
                                sucesso = Conector.shoppingCartCustomerAddresses(Sessao, numCarrinho, enderecos, Loja);
                                if (sucesso)
                                {   //Enviar produtos
                                    sucesso = Conector.shoppingCartProductAdd(Sessao, numCarrinho, produtos, Loja);
                                    if (sucesso)
                                    {//Enviar a forma de entrega
                                        sucesso = Conector.shoppingCartShippingMethod(Sessao, numCarrinho, tipoFrete, Loja, Convert.ToDouble(ValorFrete));
                                        if (sucesso)
                                        { //Enviar a forma de pagamento
                                            sucesso = Conector.shoppingCartPaymentMethod(Sessao, numCarrinho, formaPagamento, Loja);
                                            if (sucesso)
                                            {   //Obter licencas;
                                                string[] licencas = ObterLicencasMagento(numCarrinho, Conector);
                                                //Criar pedido no carrinho
                                                resultado = Conector.shoppingCartOrder(Sessao, numCarrinho, Loja, licencas);
                                                if (string.IsNullOrEmpty(resultado))
                                                {
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    { //Tramento da excessão
                        Biblioteca.Tools.Logs.GerarLog( "Integradora.ECommerce.Magento001"
                                                      , "EnviarCarrinho"
                                                      , "Pedido: " + NumeroPedido.ToString() + " - Erro: " + ex.ToString());
                        numCarrinho = -1;
                        resultado = "0";
                    }
                }
                finally
                { //Fechando a conexão
                    WebServiceFechar(Conector);
                }
            }

            return Convert.ToInt32(resultado);
        }

        private string[] ObterLicencasMagento(int numCarrinho, PortTypeClient Conector)
        {
            shoppingCartLicenseEntity[] lista = Conector.shoppingCartLicense(Sessao, numCarrinho, StoreID);
            string[] licencas = new string[lista.Count()];
            int posicao = 0;
            foreach (var item in lista)
            {
                licencas[posicao] = item.agreement_id;
                posicao++;
            }
            return licencas;
        }
        #endregion

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
                        Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.Magento001", "Estado", ex.ToString());
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

    }
}

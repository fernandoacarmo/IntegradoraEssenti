using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.Magento001.MagentoService;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Magento001
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.Magento001.Integracao LojaECommerce { get; set; }
        private string LojaPedidoFinanceiro = "2"; //Colocar como parâmetro no arquivo .CONFIG

        public Enviar()
        {
            LojaECommerce = new ECommerce.Magento001.Integracao();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadECommerce("");

            foreach (var item in lista)
            {
                try
                {
                    if ((item.Id != "00000000.0000.0000") && (item.Id != "AAAAAAAAAAAAAAAAAA"))
                    {
                        string filtro = "rowid = '" + item.Id + "'";
                        //Criando a classe e carregando
                        if (item.Tabela.Substring(0, 2) == "VW")
                            filtro = "b.rid = '" + item.Id + "'";

                        //Criando a classe e carregando
                        var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, filtro);
                        //Caso tenha encontrado processa
                        if (integracao != null)
                        {
                            switch (item.Tabela)
                            {
                                case "VWMAGENTOPRODUTOS":
                                    SendProduto((VWMagentoProdutos)integracao
                                               , (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao
                                               , ""
                                               , 0 //preço de venda
                                               , 0  //estoque
                                               );
                                    break;
                                case "PCCLIENT":
                                    SendCliente((PCClient)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCPEDC":
                                    SendPedidoCarrinho((PCPedc)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                            }
                        }
                    }
                    using (var transaction = new System.Transactions.CommittableTransaction())
                    { //O magento cancela a transação
                        try
                        {
                            Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Processo.Notificar("Integradora.Norma.Winthor.Magento001", "Send", ex);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Processo.Notificar("Integradora.Norma.Winthor.Magento001", "Send", ex);
                }
            }
        }

        private void SendPedidoCarrinho(PCPedc registro, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            try
            {
                if (registro.Numpedweb > 0)
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001"
                                 , "SendPedidoCarrinho"
                                 , string.Format("Pedido já enviado para o e-commerce, pedido winthor: {0} - pedido E-Commerce {1} ", registro.Numped.ToString(), registro.Numpedweb.ToString()));
                    return;
                }
                //Objetos a ser enviado para o magento

                //Cliente
                shoppingCartCustomerEntity ClienteMagento = new shoppingCartCustomerEntity();
                //Endereços: Sempre dois endereços, um de entrega e outro de recebimento
                shoppingCartCustomerAddressEntity[] ListaEnderecoMagento = new shoppingCartCustomerAddressEntity[2];
                //Forma de pagamentos
                shoppingCartPaymentMethodEntity formaPagamento = new shoppingCartPaymentMethodEntity();

                //Configurando a forma de pagamento
                formaPagamento.method = "shopp_pagamento_link";

                //Carregando cliente do pedido
                PCClient cliente = PCClient.Listar(string.Format("CODCLI = {0}", registro.Codcli)).Single();
                //Carrega o cliente caso já exista no magento
                if (cliente.Codcliweb <= 0)
                {
                    SendCliente(cliente, 0);
                    cliente = PCClient.Listar(string.Format("CODCLI = {0}", registro.Codcli)).Single();
                }
                customerCustomerEntity CadastroCliente = LojaECommerce.ClienteCarregar(Convert.ToInt32(cliente.Codcliweb));
                //Preenchendo os dados que já estava no site
                if (CadastroCliente != null)
                {
                    ClienteMagento.customer_idSpecified = true;
                    ClienteMagento.customer_id = CadastroCliente.customer_id;
                    ClienteMagento.email = CadastroCliente.email;
                    ClienteMagento.firstname = CadastroCliente.firstname;
                    ClienteMagento.lastname = CadastroCliente.lastname;
                    ClienteMagento.website_id = CadastroCliente.website_id;
                    ClienteMagento.store_id = CadastroCliente.store_id;
                    ClienteMagento.group_id = CadastroCliente.group_id;
                    ClienteMagento.group_idSpecified = true;
                    ClienteMagento.store_idSpecified = true;
                    ClienteMagento.website_idSpecified = true;
                    ClienteMagento.password = CadastroCliente.password_hash;
                    ClienteMagento.mode = "customer";
                }
                else
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001"
                                 , "SendPedidoCarrinho"
                                 , string.Format("Cliente não cadastrado, pedido: {0} - cliente {1} ", registro.Numped.ToString(), registro.Codcli.ToString()));
                    return;
                }

                //Listar endereços que já esta no Magento
                customerAddressEntityItem[] ListaEndereco = LojaECommerce.CarregarEndereco(CadastroCliente.customer_id);
                //Preenchedo a variavel de endereço
                var i = 0;
                foreach (var item in ListaEndereco)
                {
                    shoppingCartCustomerAddressEntity EnderecoMagento = EnderecoParaPedido(cliente, item);
                    ListaEnderecoMagento[i] = EnderecoMagento;
                    i++;
                }
                //Caso não tenha os dois endereços, duplica
                if (ListaEndereco.Count() == 1)
                {
                    shoppingCartCustomerAddressEntity EnderecoMagento = EnderecoParaPedido(cliente, ListaEndereco.FirstOrDefault());
                    EnderecoMagento.mode = EnderecoMagento.mode == "billing" ? "shipping" : "billing";
                    ListaEnderecoMagento[1] = EnderecoMagento;
                }

                //Montar lista de produtos a ser enviado para o Magento
                List<PCPedi> produtos = PCPedi.Listar(string.Format("NUMPED = {0}", registro.Numped));
                shoppingCartProductEntity[] ListaProdutosMagento = new shoppingCartProductEntity[produtos.Count()];

                int posicao = 0;
                DateTime dataServidor = cliente.DataServidor();
                foreach (var item in produtos)
                {
                    shoppingCartProductEntity ProdutoMagento = new shoppingCartProductEntity();

//                    List<VWMagentoProdutos> cadastroProduto = VWMagentoProdutos.Listar("CODPROD = " + item.Codprod.ToString());
//                    foreach (var prod in cadastroProduto)
//                    {
//                        SendProduto(prod, 0, LojaPedidoFinanceiro, item.Pvenda, item.Qt);
//                    }

                    catalogProductReturnEntity produtocadastrado = LojaECommerce.ProdutoExiste(item.Codprod.ToString(), "sku", LojaPedidoFinanceiro);
                    if (produtocadastrado != null)
                    {   //Enviar preço promocional
                        ProdutoMagento.qtySpecified = true;
                        ProdutoMagento.qty = Convert.ToDouble(item.Qt);
                        ProdutoMagento.sku = produtocadastrado.sku;
                        ProdutoMagento.product_id = produtocadastrado.product_id;
                        ProdutoMagento.custom_price = Convert.ToDouble(item.Pvenda);
                        ProdutoMagento.custom_priceSpecified = true;
                    }
                    else
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.Magento001"
                                     , "SendPedidoCarrinho"
                                     , string.Format("Produto não cadastrado, pedido: {0} - produto {1}", registro.Numped.ToString(), item.Codprod.ToString()));
                        return;
                    }

                    ListaProdutosMagento[posicao] = ProdutoMagento;
                    posicao++;
                }

                int CarrinhoCompra = LojaECommerce.EnviarCarrinho(ClienteMagento, ListaEnderecoMagento, formaPagamento, ListaProdutosMagento, LojaPedidoFinanceiro, registro.Vlfrete, registro.Numped);

                if (CarrinhoCompra > 0)
                {
                    LojaECommerce.PedidosAtualizarStatus(CarrinhoCompra.ToString()                              //string numeroPedidoECommerce     
                                                        , "pending" //string novoStatus
                                                        , "Informado o número do pedido do ERP"                 //string comentario
                                                        , Integradora.Biblioteca.Dictionaries.Tips.SimNao.Nao   //string enviarMsg
                                                        , registro.Numped.ToString()                            //string numeroPedidoERP
                                                        , ""                                                    //string numeroPedidoMarketPlace
                                                        , ClienteMagento.email                                  //string eMailCliente
                                                        , ""                                                    //string chaveNFe
                                                        , ""                                                    //string serieNF
                                                        , ""                                                    //string numeroNF)
                                                        );

                    registro.ExecutarComando(string.Format(@"UPDATE PCPEDC  
                                                                SET ESC_DTENVIOPROTHEUS = SYSDATE
                                                                  , LOG                 = 'Enviado para receber no site'
                                                                  , NUMPEDWEB           = {1}
                                                                  , CODMOTIVO           = {2}
                                                                  , CODMOTBLOQUEIO      = {3}
                                                               WHERE NUMPED             = {0}"
                                                           , registro.Numped.ToString()
                                                           , CarrinhoCompra.ToString()
                                                           , Biblioteca.Dictionaries.Settings.CodMotivoBloqueioAguardaPagto().ToString()
                                                           , Biblioteca.Dictionaries.Settings.CodMotivoBloqueioAguardaPagto().ToString()
                                                           )
                                           );
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001"
                                 , "SendPedidoCarrinho"
                                 , string.Format("Pedido gerado com sucesso: Pedido Winthor {0} - Pedido E-commerce: {1}", registro.Numped.ToString(), CarrinhoCompra.ToString()));
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento001"
                             , "SendPedidoCarrinho"
                             , string.Format("Erro ao enviar pedido para carrinho, pedido: {0} - {1}", registro.Numped.ToString(), ex.ToString()));
            }
        }

        private static shoppingCartCustomerAddressEntity EnderecoParaPedido(PCClient cliente, customerAddressEntityItem item)
        {
            shoppingCartCustomerAddressEntity EnderecoMagento = new shoppingCartCustomerAddressEntity();
            EnderecoMagento.is_default_billing = item.is_default_billing ? 1 : 0;
            EnderecoMagento.is_default_shipping = item.is_default_shipping ? 1 : 0;
            EnderecoMagento.country_id = item.country_id;
            EnderecoMagento.firstname = item.firstname;
            EnderecoMagento.lastname = item.lastname;
            EnderecoMagento.company = item.company;
            EnderecoMagento.fax = item.fax;
            EnderecoMagento.telephone = item.telephone;
            EnderecoMagento.street = item.street;
            EnderecoMagento.city = item.city;
            EnderecoMagento.postcode = item.postcode;
            EnderecoMagento.region = item.region;
            //EnderecoMagento.address_id = item.customer_address_id.ToString();
            EnderecoMagento.region_id = item.region_id.ToString();
            EnderecoMagento.mode = item.is_default_billing ? "billing" : "shipping";

            EnderecoMagento.street = string.IsNullOrEmpty(EnderecoMagento.street) ? "Nao informado" : EnderecoMagento.street;
            EnderecoMagento.city = string.IsNullOrEmpty(EnderecoMagento.city) ? "SAO PAULO" : EnderecoMagento.city;
            EnderecoMagento.postcode = string.IsNullOrEmpty(EnderecoMagento.postcode) ? "000-00000" : EnderecoMagento.postcode;
            EnderecoMagento.region = string.IsNullOrEmpty(cliente.Estcob) ? "SP" : EnderecoMagento.region;
            return EnderecoMagento;
        }

        private void SendCliente(PCClient registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            try
            {
                string emaildestinatario = string.IsNullOrEmpty(registros.Email) ? registros.Emailnfe : registros.Email;
                if (string.IsNullOrEmpty(emaildestinatario))
                {
                    Logs.GerarLog("Integradora.Normal.Winthor.Magento001"
                                 , "SendCliente", string.Format("Cliente {0} sem e-mail não pode ser enviado!", registros.Codcli.ToString()));
                    return;
                }

                if (string.IsNullOrEmpty(registros.Cgcent))
                {
                    Logs.GerarLog("Integradora.Normal.Winthor.Magento001"
                                 , "SendCliente", string.Format("Cliente {0} sem CNPJ/CPF não pode ser enviado!", registros.Codcli.ToString()));
                    return;
                }
                customerCustomerEntityToCreate entidadeMagento = new customerCustomerEntityToCreate();
                if (registros.Codcliweb > 0)
                {
                    entidadeMagento.customer_id = Convert.ToInt32(registros.Codcliweb);
                }
                entidadeMagento.dob = registros.Dtnasc.ToString();
                entidadeMagento.email = emaildestinatario.ToLower();
                entidadeMagento.website_id = 1;
                entidadeMagento.group_id = 1;
                entidadeMagento.store_id = 1;
                entidadeMagento.firstname = registros.Cliente.Split(' ').FirstOrDefault();
                entidadeMagento.lastname = registros.Cliente.Substring(entidadeMagento.firstname.Length, (registros.Cliente.Length - entidadeMagento.firstname.Length));
                entidadeMagento.password = registros.Cliente.Substring(1, 3) + "2122";
                entidadeMagento.gender = string.IsNullOrEmpty(registros.Sexo) ? 1 : (registros.Sexo == "M" ? 1 : 2);
                entidadeMagento.taxvat = Biblioteca.Tools.Numbers.OnlyNumbers(registros.Cgcent);

                customerAddressEntityCreate enderecoMagento = new customerAddressEntityCreate();

                string[] enderecocompleto = new string[4];
                enderecocompleto[0] = registros.Enderent;
                enderecocompleto[1] = registros.Numeroent;
                enderecocompleto[2] = registros.Complementoent;
                enderecocompleto[3] = registros.Bairroent;

                enderecoMagento.street = enderecocompleto;
                enderecoMagento.is_default_billing = true;
                enderecoMagento.is_default_shipping = true;
                enderecoMagento.city = registros.Municent;
                enderecoMagento.company = registros.Cliente;
                enderecoMagento.country_id = "BR"; // registros.Codpais.ToString();
                enderecoMagento.fax = registros.Faxcli;
                enderecoMagento.firstname = entidadeMagento.firstname;
                enderecoMagento.lastname = entidadeMagento.lastname;
                enderecoMagento.middlename = entidadeMagento.middlename;
                enderecoMagento.postcode = registros.Cepent;
                enderecoMagento.telephone = string.IsNullOrEmpty(registros.Telent) ? registros.Telcob : registros.Telent;
                enderecoMagento.region = registros.Estent;
                enderecoMagento.telephone = registros.Telcom;

                int CodigoMagento = 0;
                switch (replicacaoAcao)
                {
                    case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Incluir:
                        CodigoMagento = LojaECommerce.ClientePersistir(entidadeMagento, enderecoMagento, entidadeMagento.customer_id);
                        break;
                    case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Alterar:
                        CodigoMagento = LojaECommerce.ClientePersistir(entidadeMagento, enderecoMagento, entidadeMagento.customer_id);
                        break;
                    case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Excluir:
                        LojaECommerce.ClienteExcluir(entidadeMagento.customer_id);
                        break;
                    default:
                        break;
                }

                if (CodigoMagento > 0)
                {
                    if (registros.Codcliweb != CodigoMagento)
                    {
                        using (var transaction = new System.Transactions.CommittableTransaction())
                        { //O magento cancela a transação, por ficou só nesta parte
                            try
                            {
                                registros.Codcliweb = CodigoMagento;
                                registros.Gravar();

                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                Processo.Notificar("Integradora.Norma.Winthor.Magento001", "Send", ex);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento001"
                             , "SendProduto"
                             , string.Format("Erro ao enviar o cliente: {0} - {1}", registros.Codcli.ToString(), ex.ToString()));
            }
        }

        private void SendProduto(VWMagentoProdutos registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao, string Loja, decimal preco, decimal qtpedida)
        {
            int retorno = -1;

            try
            {
                //Declaraçaõ das variaveis utilizadas
                string SKU = registros.Codprod.ToString();
                catalogProductCreateEntity entidadeMagento = new catalogProductCreateEntity();
                if (preco == 0)
                {
                    preco = registros.Pvenda;
                }
                decimal precooferta = registros.Poferta;
                #region Dados do cadastrais
                //Montando produto a ser enviado
                entidadeMagento.name = entidadeMagento.description;
                entidadeMagento.description = registros.Nomeecommerce;
                entidadeMagento.short_description = registros.Descricao;
                entidadeMagento.meta_description = registros.Sku + "-" + registros.Nomeecommerce;
                entidadeMagento.meta_keyword = entidadeMagento.meta_description;
                entidadeMagento.meta_title = entidadeMagento.description;
                entidadeMagento.tax_class_id = "4";
                entidadeMagento.url_key = Integradora.Biblioteca.Tools.Formats.DecricaoToURL(registros.Codprod.ToString() + "-" + entidadeMagento.description);
                entidadeMagento.url_path = entidadeMagento.url_key;
                entidadeMagento.custom_design = "";
                entidadeMagento.custom_layout_update = "";
                entidadeMagento.gift_message_available = "";
                entidadeMagento.has_options = "";
                entidadeMagento.options_container = "";
                entidadeMagento.price = precooferta.ToString().Replace(",", ".");
                entidadeMagento.special_price = preco.ToString().Replace(",", ".");   // preco.ToString().Replace(",", ".");
                entidadeMagento.special_from_date = "";
                entidadeMagento.special_to_date = "";
                entidadeMagento.status = registros.Enviaecommerce == "S" ? "1" : "2";
                entidadeMagento.visibility = "4";
                entidadeMagento.weight = registros.Pesoliq.ToString().Replace(",", ".");
                
              //  string[] ListaCategorias = new string[1];
              //  ListaCategorias[0] = "21"; // Biblioteca.Dictionaries.Settings.MagentoGrupoAtributo();
              //  entidadeMagento.categories = ListaCategorias;

                string[] website = new string[1];
                website[0] = "1";
                entidadeMagento.websites = website;
                #endregion

                #region Estoque
                catalogInventoryStockItemUpdateEntity estoqueMagento = new catalogInventoryStockItemUpdateEntity();
                estoqueMagento.is_in_stock = registros.Obs == "PV" ? 0 : 1;
                estoqueMagento.is_in_stockSpecified = true;
                estoqueMagento.qty = (registros.Qtestoque + qtpedida).ToString().Replace(",", ".");

                entidadeMagento.stock_data = estoqueMagento;
                #endregion

                #region Atributos adicionais Simples
                associativeEntity[] AtributosAdicionais = new associativeEntity[43];

                AtributosAdicionais[00] = LojaECommerce.ProdutoAtributoSimplesCriar("name", registros.Nomeecommerce); //Tipo: Texto, aceita qualquer valor
                AtributosAdicionais[01] = LojaECommerce.ProdutoAtributoSimplesCriar("description", registros.Nomeecommerce);//Tipo: Texto, aceita qualquer valor
                AtributosAdicionais[02] = LojaECommerce.ProdutoAtributoSimplesCriar("short_description", registros.Descricao);//Tipo: Texto, aceita qualquer valor
                AtributosAdicionais[03] = LojaECommerce.ProdutoAtributoSimplesCriar("pais", string.IsNullOrEmpty(registros.Esc_pais) ? "" : registros.Esc_pais.ToString());
                AtributosAdicionais[04] = LojaECommerce.ProdutoAtributoSimplesCriar("safra", registros.Esc_safra);
                AtributosAdicionais[05] = LojaECommerce.ProdutoAtributoSimplesCriar("regiao", registros.Esc_regiao);
                AtributosAdicionais[06] = LojaECommerce.ProdutoAtributoSimplesCriar("vinicola", registros.Esc_vinicola);
                AtributosAdicionais[07] = LojaECommerce.ProdutoAtributoSimplesCriar("detalhesvinicola", registros.Esc_detalhesvinicola); //Tipo: Texto, aceita qualquer valor
                AtributosAdicionais[08] = LojaECommerce.ProdutoAtributoSimplesCriar("coloracao", registros.Esc_coloracao);
                AtributosAdicionais[09] = LojaECommerce.ProdutoAtributoSimplesCriar("teoralcoolico", registros.Esc_teoralcoolico);
                AtributosAdicionais[10] = LojaECommerce.ProdutoAtributoSimplesCriar("tipo", registros.Esc_tipo);
                AtributosAdicionais[11] = LojaECommerce.ProdutoAtributoSimplesCriar("classificacao", registros.Esc_classificacao);
                AtributosAdicionais[12] = LojaECommerce.ProdutoAtributoSimplesCriar("tipoderolha", registros.Esc_tipoderolha);
                AtributosAdicionais[13] = LojaECommerce.ProdutoAtributoSimplesCriar("visual", registros.Esc_visual); //Tipo: Texto, aceita qualquer valor
                AtributosAdicionais[14] = LojaECommerce.ProdutoAtributoSimplesCriar("olfato", registros.Esc_olfato);//Tipo: Texto, aceita qualquer valor
                AtributosAdicionais[15] = LojaECommerce.ProdutoAtributoSimplesCriar("gustativo", registros.Esc_gustativo);//Tipo: Texto, aceita qualquer valor
                AtributosAdicionais[16] = LojaECommerce.ProdutoAtributoSimplesCriar("harmonizacao", registros.Esc_harmonizacao);
                AtributosAdicionais[17] = LojaECommerce.ProdutoAtributoSimplesCriar("capacidade", registros.Esc_capacidade);
                AtributosAdicionais[18] = LojaECommerce.ProdutoAtributoSimplesCriar("amadurecimento", registros.Esc_amadurecimento);
                AtributosAdicionais[19] = LojaECommerce.ProdutoAtributoSimplesCriar("potencialdeguarda", registros.Esc_potencialdeguarda);
                AtributosAdicionais[20] = LojaECommerce.ProdutoAtributoSimplesCriar("temperaturadeservico", registros.Esc_temperaturadeservico);
                AtributosAdicionais[21] = LojaECommerce.ProdutoAtributoSimplesCriar("premiacoes", registros.Esc_premiacoes); //Texto, aceita qualquer valor
                AtributosAdicionais[22] = LojaECommerce.ProdutoAtributoSimplesCriar("varietalassemblagem", registros.Esc_varietalassemblagem);

                AtributosAdicionais[23] = LojaECommerce.ProdutoAtributoSimplesCriar("status", entidadeMagento.status);
                AtributosAdicionais[24] = LojaECommerce.ProdutoAtributoSimplesCriar("visibility", entidadeMagento.visibility);
                AtributosAdicionais[25] = LojaECommerce.ProdutoAtributoSimplesCriar("created_at", registros.DataHoraServidor().ToString());
                AtributosAdicionais[26] = LojaECommerce.ProdutoAtributoSimplesCriar("updated_at", registros.DataHoraServidor().ToString());
                AtributosAdicionais[27] = LojaECommerce.ProdutoAtributoSimplesCriar("price", entidadeMagento.price);
                AtributosAdicionais[28] = LojaECommerce.ProdutoAtributoSimplesCriar("tax_class_id", entidadeMagento.tax_class_id);
                AtributosAdicionais[29] = LojaECommerce.ProdutoAtributoSimplesCriar("samples_title", entidadeMagento.description);
                AtributosAdicionais[30] = LojaECommerce.ProdutoAtributoSimplesCriar("links_purchased_separately", entidadeMagento.url_key);
                AtributosAdicionais[31] = LojaECommerce.ProdutoAtributoSimplesCriar("links_title", entidadeMagento.url_key);
                AtributosAdicionais[32] = LojaECommerce.ProdutoAtributoSimplesCriar("price_view", "0");
                AtributosAdicionais[33] = LojaECommerce.ProdutoAtributoSimplesCriar("price_type", "0");
                AtributosAdicionais[34] = LojaECommerce.ProdutoAtributoSimplesCriar("sku_type", "1");
                AtributosAdicionais[35] = LojaECommerce.ProdutoAtributoSimplesCriar("weight_type", "0");
                AtributosAdicionais[36] = LojaECommerce.ProdutoAtributoSimplesCriar("shipment_type", "default");
                AtributosAdicionais[37] = LojaECommerce.ProdutoAtributoSimplesCriar("brand", registros.Marca);
                AtributosAdicionais[38] = LojaECommerce.ProdutoAtributoSimplesCriar("ean", registros.Codauxiliar <= 0 ? "." : registros.Codauxiliar.ToString());
                AtributosAdicionais[39] = LojaECommerce.ProdutoAtributoSimplesCriar("ncm", registros.Nbm);
                AtributosAdicionais[40] = LojaECommerce.ProdutoAtributoSimplesCriar("mpn", registros.Codfab);
                AtributosAdicionais[41] = LojaECommerce.ProdutoAtributoSimplesCriar("sku", SKU);
                AtributosAdicionais[42] = LojaECommerce.ProdutoAtributoSimplesCriar("weight", registros.Pesoliq.ToString());
                #endregion

                #region Atributos adicionais Multiplos
                //int idUvas = 221;
                associativeMultiEntity[] AtributosMultiAdicionais = new associativeMultiEntity[2];

                if (!string.IsNullOrEmpty(registros.Esc_uvas))
                {
                    string[] stringList = new string[10];
                    stringList[0] = registros.Esc_uvas1 == "0" ? string.Empty : registros.Esc_uvas1;
                    stringList[1] = registros.Esc_uvas2 == "0" ? string.Empty : registros.Esc_uvas2;
                    stringList[2] = registros.Esc_uvas3 == "0" ? string.Empty : registros.Esc_uvas3;
                    stringList[3] = registros.Esc_uvas4 == "0" ? string.Empty : registros.Esc_uvas4;
                    stringList[4] = registros.Esc_uvas5 == "0" ? string.Empty : registros.Esc_uvas5;
                    stringList[5] = registros.Esc_uvas6 == "0" ? string.Empty : registros.Esc_uvas6;
                    stringList[6] = registros.Esc_uvas7 == "0" ? string.Empty : registros.Esc_uvas7;
                    stringList[7] = registros.Esc_uvas8 == "0" ? string.Empty : registros.Esc_uvas8;
                    stringList[8] = registros.Esc_uvas9 == "0" ? string.Empty : registros.Esc_uvas9;
                    stringList[9] = registros.Esc_uvas  == "0" ? string.Empty : registros.Esc_uvas;

                    AtributosMultiAdicionais[0] = LojaECommerce.ProdutoAtributoMultiploCriar("uvas", String.Join(",", stringList));
                }

                if (!string.IsNullOrEmpty(registros.Esc_harmonizacao))
                {
                    string[] stringList = new string[4];
                    stringList[0] = registros.Esc_harmonizacao1 == "0" ? string.Empty : registros.Esc_harmonizacao1;
                    stringList[1] = registros.Esc_harmonizacao2 == "0" ? string.Empty : registros.Esc_harmonizacao2;
                    stringList[2] = registros.Esc_harmonizacao3 == "0" ? string.Empty : registros.Esc_harmonizacao3;
                    stringList[3] = registros.Esc_harmonizacao  == "0" ? string.Empty : registros.Esc_harmonizacao;

                    AtributosMultiAdicionais[1] = LojaECommerce.ProdutoAtributoMultiploCriar("harmonizacao", String.Join(",", stringList));
                }
                #endregion

                catalogProductAdditionalAttributesEntity ListaAtributosAdicionais = new catalogProductAdditionalAttributesEntity();
                ListaAtributosAdicionais.single_data = AtributosAdicionais;
                ListaAtributosAdicionais.multi_data = AtributosMultiAdicionais;


                entidadeMagento.additional_attributes = ListaAtributosAdicionais;

                //if (ValidarAtributos(SKU, AtributosAdicionais, AtributosMultiAdicionais))
                {
                    //Enviando conforme comando selecionado
                    switch (replicacaoAcao)
                    {
                        case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Incluir:
                            retorno = LojaECommerce.ProdutoPersistir(entidadeMagento, SKU, Biblioteca.Dictionaries.Settings.MagentoGrupoAtributo(), Loja);
                            break;
                        case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Alterar:
                            retorno = LojaECommerce.ProdutoPersistir(entidadeMagento, SKU, Biblioteca.Dictionaries.Settings.MagentoGrupoAtributo(), Loja);
                            break;
                        case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Excluir:
                            retorno = LojaECommerce.ProdutoExcluir(entidadeMagento, SKU);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                retorno = -1;
                Logs.GerarLog("Integradora.Norma.Winthor.Magento001"
                             , "SendProduto"
                             , string.Format("Erro ao enviar o produto: {0} - {1}", registros.Codprod.ToString(), ex.ToString()));
            }

            if (retorno > -1)
            {
                if (Biblioteca.Dictionaries.Settings.Debugando())
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001"
                                 , "SendProduto"
                                 , string.Format("Produto enviado com sucesso: {0} - Estoque: {1}", registros.Codprod.ToString(), registros.Qtestoque.ToString()));
                }
            }
        }

        private bool ValidarAtributos(string Produto
                                     , associativeEntity[] AtributosAdicionaisSimples
                                     , associativeMultiEntity[] AtributosAdicionaisMultiplos)
        {
            try
            {
                //Lista de possíveis erros encontrados
                ArrayList listaPendencias = new ArrayList();
                //Lendo todos os atributos
                if (LojaECommerce.ListaAtributosObrigatorios != null)
                {
                    foreach (var item in LojaECommerce.ListaAtributosObrigatorios)
                    {
                        associativeMultiEntity atributoMultiplo = null;
                        associativeEntity atributoSimples = null;
                        //Verifica se o atributo esta existe
                        atributoSimples = AtributosAdicionaisSimples.Where(c => c.key.ToUpper() == item.code.ToUpper()).FirstOrDefault();
                        if (atributoSimples == null)
                            atributoMultiplo = AtributosAdicionaisMultiplos.Where(c => c.key.ToUpper() == item.code.ToUpper()).FirstOrDefault();

                        //Veja se o atributo esta sendo envaido
                        if ((atributoSimples == null) && (atributoMultiplo == null))
                        {//Mesmo não estando sendo enviado só valida se for obrigatório
                            if (item.required == "1")
                            {
                                listaPendencias.Add(string.Format("Atributo {0} não esta sendo enviado e é obrigatório!", item.code));
                            }
                        }
                        else
                        {//Caso esteja sendo enviado, verifica se é obrigatório e se esta preenchido
                            string valoratributo = (atributoSimples == null) ? atributoMultiplo.value[0] : atributoSimples.value;
                            if ((item.required == "1") && (string.IsNullOrEmpty(valoratributo)))
                            {
                                listaPendencias.Add(string.Format("Atributo {0} é obrigatório seu preenchimento!", item.code));
                            }
                        }
                    }

                    if (listaPendencias.Count > 0)
                    {
                        string listandoAtributos = "";
                        foreach (var item in listaPendencias)
                        {
                            listandoAtributos += item.ToString() + Environment.NewLine;
                        }
                        Logs.GerarLog("Integradora.Norma.Winthor.Magento001"
                                     , "ValidarAtributos"
                                     , string.Format("Falta o preenchimento do(s) atributo(s) para o produto: {0}" + Environment.NewLine +
                                                     "Atributo(s): {1}", Produto, listandoAtributos));
                    }
                    else
                    {
                        foreach (var item in LojaECommerce.ListaAtributosObrigatorios)
                        {
                            //Validar opção de atributos de seleção / multiescolha
                            if (item.type != null)
                            {
                                if (item.type.Contains("select"))
                                {
                                    //Achando o atributo na lista enviado por este aplicativo
                                    var atributoSimples = AtributosAdicionaisSimples.Where(c => c.key.ToUpper() == item.code.ToUpper()).FirstOrDefault();
                                    //Veja se o atributo esta sendo enviado
                                    if (atributoSimples != null)
                                    {   //Carregando as opções de escolha do atributo
                                        catalogAttributeOptionEntity[] ListaOpcoes = LojaECommerce.ListarAtributaosOpcao(item.attribute_id);
                                        //Verificando se uma das opções de escolha e igual a que esta sendo passada para este atributo
                                        var atributoOpcao = ListaOpcoes.Where(c => c.label.ToUpper() == atributoSimples.value.ToUpper()).FirstOrDefault();
                                        //Caso não encontre, cadastra
                                        if (atributoOpcao == null)
                                        {
                                            LojaECommerce.ProdutoAtributosValorCriar(item.attribute_id, atributoSimples.value);
                                        }

                                        atributoSimples.value = LojaECommerce.ObterIDAtributo(item.attribute_id, atributoSimples.value);
                                    }
                                    else
                                    {
                                        //Achando o atributo na lista enviado por este aplicativo
                                        var atributoMultiplo = AtributosAdicionaisMultiplos.Where(c => c.key.ToUpper() == item.code.ToUpper()).FirstOrDefault();
                                        if (atributoMultiplo != null)
                                        {   //Carregando as opções de escolha do atributo
                                            catalogAttributeOptionEntity[] ListaOpcoes = LojaECommerce.ListarAtributaosOpcao(item.attribute_id);
                                            //Verificando se uma das opções de escolha e igual a que esta sendo passada para este atributo
                                            int i = 0;
                                            foreach (var registro in atributoMultiplo.value)
                                            {
                                                var atributoOpcao = ListaOpcoes.Where(c => c.label.ToUpper() == registro.ToUpper()).FirstOrDefault();
                                                //Caso não encontre, cadastra
                                                if (atributoOpcao == null)
                                                {
                                                    LojaECommerce.ProdutoAtributosValorCriar(item.attribute_id, registro);
                                                }

                                                atributoMultiplo.value[i] = LojaECommerce.ObterIDAtributo(item.attribute_id, registro);
                                                i++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return listaPendencias.Count == 0;
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento001"
                             , "ValidarAtributos"
                             , string.Format("Erro ao validar atributos do produto: {0}" + Environment.NewLine +
                                             "Erro: {1}", Produto, ex.ToString()));
                return false;
            }
        }
    }
}

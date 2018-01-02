using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.FBits.SyncPedidoVenda;
using Integradora.ECommerce.FBits.SyncUsuarioEndereco;
using Integradora.ERP.Winthor.Domain;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.FBits
{
    class Receber : IProcessIntegration
    {
        public Integradora.ECommerce.FBits.Integracao LojaECommerce { get; set; }
        public Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda { get; set; }

        public Receber()
        {
            LojaECommerce = new ECommerce.FBits.Integracao();
            PedidoForcaVenda = new ERP.Winthor.Domain.PedidoWeb();
        }
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            ReceiveCliente();
            ReceiveClienteEndereco();
            ReceivePedidos();
        }

        private void ReceivePedidos()
        {
            IntegracaoPedidoVendaInfo[] Lista = LojaECommerce.PedidoList();
            if (Lista != null)
            {
                foreach (var ecommerce in Lista)
                {
                    decimal numPedido = 0;
                    decimal codRCA = 0;
                    bool commitTransacao = false;

                    Biblioteca.Tools.XML.Export(ecommerce, "Pedido_" + ecommerce.PedidoId.ToString());

                    List<int> pedidoQuePodeImpoartar = new List<int> { 1, 2 };
                    if (pedidoQuePodeImpoartar.Contains(ecommerce.Status))
                    //if ((ecommerce.Status >= 1) && (ecommerce.Status <= 2))
                    {
                        if (!Integradora.ERP.Winthor.Domain.PedidoWeb.PedidoExiste(ecommerce.PedidoId.ToString()))
                        {
                            using (var transaction = new System.Transactions.CommittableTransaction())
                            {
                                if (ESTLogpedidoecommerce.Validar(ecommerce.PedidoId.ToString(), "FBITS"))
                                {
                                    try
                                    {
                                        if (!ClienteJaCadastrado(ecommerce.UsuarioId.ToString()
                                           , ecommerce.Usuario.CPF
                                           , ecommerce.Usuario.CNPJ))
                                        {
                                            //Não existindo e feito o cadastro do cliente
                                            PedidoForcaVenda.ClienteInicializar();
                                        }
                                        //Sempre cadastra um novo cliente ou atualiza
                                        ClienteInserir(false
                                                      , ecommerce.Usuario.UsuarioId
                                                      , ecommerce.Usuario.TipoPessoaId
                                                      , ecommerce.Usuario.Nome
                                                      , ecommerce.Usuario.RazaoSocial
                                                      , ecommerce.Usuario.CPF
                                                      , ecommerce.Usuario.CNPJ
                                                      , ecommerce.Usuario.Email
                                                      , ecommerce.Usuario.RG
                                                      , ecommerce.Usuario.OrgaoEmissor
                                                      , ecommerce.Usuario.NomeMae
                                                      , ecommerce.Usuario.TelefoneResidencial
                                                      , ecommerce.Usuario.TelefoneCelular
                                                      , ecommerce.Usuario.TelefoneComercial
                                                      , ecommerce.Usuario.DataNascimento
                                                      , ecommerce.Usuario.InscricaoEstadual
                                                      , ecommerce.Usuario.DataCriacao
                                                      , ecommerce.Endereco
                                                      , ecommerce.Numero
                                                      , ecommerce.Complemento
                                                      , ecommerce.Bairro
                                                      , ecommerce.Cidade
                                                      , ecommerce.Estado
                                                      , ecommerce.Cep);

                                        PedidoForcaVenda.PedidoInicializar();
                                        PedidoForcaVenda.Cabecalho.Numpedcli = ecommerce.PedidoId.ToString();
                                        PedidoForcaVenda.Cabecalho.Data = ecommerce.DataPedido;
                                        PedidoForcaVenda.Cabecalho.Vlfrete = ecommerce.ValorFrete;
                                        PedidoForcaVenda.Cabecalho.Dtentrega = ecommerce.DataEntrega;
                                        //PedidoForcaVenda.Cabecalho.Vldescontocupom = ecommerce.ValorCupomDesconto;
                                        PedidoForcaVenda.Cabecalho.Vldescontofinanceiro = ecommerce.ValorCupomDesconto;
                                        PedidoForcaVenda.Cabecalho.ESC_Vloutrasdespweb = ecommerce.ValorJuros + ecommerce.ValorServicos;
                                        PedidoForcaVenda.Cabecalho.Obsentrega1 = ecommerce.Endereco + ", ";
                                        PedidoForcaVenda.Cabecalho.Obsentrega1 = PedidoForcaVenda.Cabecalho.Obsentrega1 + (string.IsNullOrEmpty(ecommerce.Numero) ? " " : ecommerce.Numero + ", ");
                                        PedidoForcaVenda.Cabecalho.Obsentrega1 = PedidoForcaVenda.Cabecalho.Obsentrega1 + (Biblioteca.Tools.Formats.FormatoWinthor(ecommerce.Bairro) + ", ");
                                        PedidoForcaVenda.Cabecalho.Obsentrega1 = PedidoForcaVenda.Cabecalho.Obsentrega1 + (Biblioteca.Tools.Formats.FormatoWinthor(ecommerce.Cidade) + ", ");
                                        PedidoForcaVenda.Cabecalho.Obsentrega1 = PedidoForcaVenda.Cabecalho.Obsentrega1 + (string.IsNullOrEmpty(ecommerce.Estado) ? " " : ecommerce.Estado + ", ");
                                        PedidoForcaVenda.Cabecalho.Obsentrega1 = PedidoForcaVenda.Cabecalho.Obsentrega1 + (string.IsNullOrEmpty(ecommerce.Complemento) ? " " : ecommerce.Complemento + ", ");
                                        PedidoForcaVenda.Cabecalho.Obsentrega2 = "Período agendado: " + String.Format("{0:MM/dd/yyyy}", ecommerce.DataEntrega) + ' ' + ecommerce.EntregaAgendadaPeriodo;

                                        if (!string.IsNullOrEmpty(ecommerce.NomeDestino))
                                        {
                                            PedidoForcaVenda.Cabecalho.Obsentrega3 = string.Format("Resp. pelo recebimento: {0}", ecommerce.NomeDestino);
                                        }
                                        //Pedido para hortifrute especifico da Decisão
                                        PedidoViaEmail pedidohortifrute = new PedidoViaEmail();

                                        foreach (var item in ecommerce.Itens)
                                        {
                                            //Classe que representa o item na lista
                                            Integradora.ERP.Winthor.EntityWinthor.PCPeditemp itemPedido = null;
                                            var Produto = PedidoForcaVenda.ObterTabelaProduto(item.SKU, PedidoForcaVenda.Cabecalho.Codfilial);
                                            if ((Produto != null)  && (Produto.Codprod > 0))
                                            {
                                                //Verificando se o produto já esta no pedido
                                                itemPedido = PedidoForcaVenda.Itens.Find(l => l.Codprod == Convert.ToDecimal(item.SKU));
                                                if (itemPedido == null)
                                                {   //Inserindo um novo produto
                                                    itemPedido = PedidoForcaVenda.NovoItemPedido();

                                                    itemPedido.Numseq = PedidoForcaVenda.Itens.Count + 1;
                                                    itemPedido.Codprod = Produto.Codprod;
                                                    itemPedido.Codauxiliar = Convert.ToDecimal(item.SKU);
                                                    itemPedido.Qt = item.ProdutoQuantidade;
                                                    itemPedido.Ptabela = item.Preco_Venda;
                                                    itemPedido.Pvenda = item.PrecoUnitario;
                                                    if (itemPedido.Ptabela != itemPedido.Pvenda)
                                                    {
                                                        //Calculando desconto
                                                        itemPedido.Perdesc = (1 - (itemPedido.Pvenda / itemPedido.Ptabela)) * 100;
                                                    }
                                                    PedidoForcaVenda.Itens.Add(itemPedido);
                                                }
                                                else
                                                {    //Se já estiver no pedido, apenas adiciona a quantidade
                                                    itemPedido.Qt += item.ProdutoQuantidade;
                                                }

                                                //Especifico para a Decisão, enviar e-mail de produtos hortifruti
                                                if (Produto.Codepto == 16)
                                                {
                                                    //var CodCategoria = Convert.ToString( Convert.ToDecimal( Produto.Codcategoria));
                                                    if (!Produto.Descricao.ToUpper().Contains("OVO "))
                                                    {
                                                        //Verificando se já existe cabeçalho para este pe/dido/fornecedor
                                                        Cabecalho CabecalhoPedidoEmail = pedidohortifrute.Pedidos.Find(l => l.codFornecedor == Convert.ToDecimal(Produto.Codfornec));
                                                        if (CabecalhoPedidoEmail == null)
                                                        {   //Criando um novo cabeçalho
                                                            CabecalhoPedidoEmail = new Cabecalho();
                                                            CabecalhoPedidoEmail.codFornecedor = Numbers.ToInt32(Produto.Codfornec.ToString());
                                                            CabecalhoPedidoEmail.dataRecebimento = PedidoForcaVenda.Cabecalho.Data;
                                                            CabecalhoPedidoEmail.dataEntrega = PedidoForcaVenda.Cabecalho.Data.AddDays(1);
                                                            CabecalhoPedidoEmail.pedidoWeb = PedidoForcaVenda.Cabecalho.Numpedcli;
                                                            CabecalhoPedidoEmail.DadosFornecedor();
                                                            CabecalhoPedidoEmail.codCliente = PedidoForcaVenda.Cliente.Codcli;
                                                            CabecalhoPedidoEmail.cliente = PedidoForcaVenda.Cliente.Cliente;
                                                            //Adicionando na lista
                                                            pedidohortifrute.Pedidos.Add(CabecalhoPedidoEmail);
                                                        }
                                                        //Inserindo itens
                                                        Itens itemPedidoEmail = new Itens();
                                                        itemPedidoEmail.codProduto = Produto.Codprod;
                                                        itemPedidoEmail.descricao = string.IsNullOrEmpty(item.Nome) ? Produto.Descricao : item.Nome;
                                                        itemPedidoEmail.quantidade = item.ProdutoQuantidade;

                                                        CabecalhoPedidoEmail.ListaItens.Add(itemPedidoEmail);
                                                    }
                                                }
                                            }
                                        }

                                        decimal vnValorTotalJuros = 0;
                                        foreach (var parcelamento in ecommerce.FormasPagamento)
                                        {
                                            CarregarFormaPagamento(PedidoForcaVenda, parcelamento);
                                            for (int i = 0; i < parcelamento.NumeroParcelas; i++)
                                            {
                                                if (parcelamento.PedidoPagamentoId > 0) //Verifica se e parcela
                                                {
                                                    Integradora.ERP.Winthor.EntityWinthor.PCPresttemp parcelaPedido = PedidoForcaVenda.NovaParcela();

                                                    parcelaPedido.Valor = parcelamento.ValorParcela; // Já vem embutido no valor da parcela:  + parcelamento.ValorJuros - parcelamento.ValorDesconto;
                                                    parcelaPedido.Esc_Vldesconto = parcelamento.ValorDesconto;
                                                    parcelaPedido.Esc_Vljuros = parcelamento.ValorJuros;
                                                    parcelaPedido.Prest = (i + 1).ToString();
                                                    parcelaPedido.Presttef = parcelaPedido.Prest;
                                                    parcelaPedido.Codcob = PedidoForcaVenda.Cabecalho.Codcob;
                                                    parcelaPedido.Codplpag = PedidoForcaVenda.Cabecalho.Codplpag;
                                                    parcelaPedido.NSUTef = Biblioteca.Tools.Numbers.OnlyNumbers(parcelamento.CodigoSegurancaCartaoCredito);
                                                    if (!string.IsNullOrEmpty(parcelaPedido.NSUTef))
                                                    {//Se for pagamento com cartão devera fazer o ajuste do financeiro
                                                        PedidoForcaVenda.Cabecalho.ESC_AjustarFinanceiro = "S";
                                                    }
                                                    vnValorTotalJuros = vnValorTotalJuros + parcelamento.ValorJuros;
                                                    PedidoForcaVenda.Parcelas.Add(parcelaPedido);
                                                }
                                                else //Verifica se é desconto com crédito de cliente
                                                {
                                                    PedidoForcaVenda.Cabecalho.Vldescontofinanceiro = PedidoForcaVenda.Cabecalho.Vldescontofinanceiro + parcelamento.ValorTotal;
                                                }
                                            }
                                        }

                                        //Gravar juros em outras despesas
                                        PedidoForcaVenda.Cabecalho.ESC_Vloutrasdespweb = PedidoForcaVenda.Cabecalho.ESC_Vloutrasdespweb + vnValorTotalJuros;

                                        //Gravar o cliente (inserindo ou atualizando dados
                                        commitTransacao = PedidoForcaVenda.PedidoGravar();
                                        if (commitTransacao)
                                        {
                                            numPedido = PedidoForcaVenda.Cabecalho.Numpedweb;
                                            codRCA = PedidoForcaVenda.Cabecalho.Codusur;
                                            //Enviando e-mail
                                            if (pedidohortifrute.Pedidos.Count > 0)
                                            {
                                                pedidohortifrute.EnviarEmail(numPedido);
                                            }
                                        }

                                        if (commitTransacao)
                                        {
                                            transaction.Commit();
                                        }
                                        else
                                        {
                                            transaction.Rollback();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        transaction.Rollback();
                                        ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.Fbits.Receber"
                                                                          , "ReceivePedidos"
                                                                          , string.Format("Erro ao gravar o pedido, pedido: {0} - {1}", PedidoForcaVenda.Cabecalho.Numpedcli, ex.ToString())
                                                                          , PedidoForcaVenda.Cabecalho.Numpedcli
                                                                          , PedidoForcaVenda.Cabecalho.Numpedrca
                                                                          , "N"
                                                                          , "FBITS");
                                    }
                                }
                            }

                            if (numPedido > 0)
                            {
                                bool importado = false;
                                importado = ExecutarIntegradora(numPedido, codRCA, PedidoForcaVenda);
                                if (importado)
                                {
                                    if (FinalizarIntegracaoPedido(numPedido, PedidoForcaVenda))
                                    {
                                        LojaECommerce.PedidoConfirm(ecommerce.PedidoId);
                                    }
                                }
                                numPedido = 0;
                                codRCA = 0;
                            }
                        }
                        else
                        {//Pedido já existe... marcar para não ser importado novamente.
                            LojaECommerce.PedidoConfirm(ecommerce.PedidoId);
                        }
                    }
                    else
                    { //Pedido cancelado
                        if (ecommerce.Status == 8)
                        {   //Verifica se o pedido existe                            
                            Logs.GerarLog("Verifica se e para cancelar o pedido: " + ecommerce.PedidoId.ToString());
                            try
                            {   //Listando o pedido 
                                PCPedc pedido = PCPedc.Listar(string.Format("UPPER(NUMPEDCLI) = '{0}' AND ROWNUM = 1", ecommerce.PedidoId.ToString())).FirstOrDefault();
                                //Encontrado tenta cancelar
                                if (pedido.Numped > 0)
                                {   //Iniciando a transação
                                    using (var transaction = new System.Transactions.CommittableTransaction())
                                    {   
                                        string cancelado = "";
                                        try
                                        {   //Executando a procedure de cancelamento de pedido
                                            cancelado = Integradora.ERP.Winthor.Domain.CancelarPedido.Cancelar(pedido.Numped, "Cancelamento do pedido no e-commerce");

                                            if (cancelado == "OK")
                                            {//Comitando a transação 
                                                transaction.Commit();
                                            }
                                            else
                                            { //Gerando a mensagem do não cancelamento
                                                transaction.Rollback();
                                                ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.Fbits.Receber"
                                                                                  , "ReceivePedidos"
                                                                                  , string.Format("Não foi possível cancelar o pedido: {0} - {1}", ecommerce.PedidoId.ToString(), cancelado)
                                                                                  , pedido.Numpedcli
                                                                                  , pedido.Numpedrca
                                                                                  , "N"
                                                                                  , "FBITS");
                                            }

                                        }
                                        catch (Exception ex)
                                        {  //Tramento da exceção
                                            transaction.Rollback();
                                            ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.Fbits.Receber"
                                                                              , "ReceivePedidos"
                                                                              , string.Format("Erro ao cancelar o pedido, pedido: {0} - {1}", ecommerce.PedidoId.ToString(), ex.ToString())
                                                                              , pedido.Numpedcli
                                                                              , pedido.Numpedrca
                                                                              , "N"
                                                                              , "FBITS");
                                        }
                                    }
                                }
                            }
                            catch
                            { 
                                //Pedido não localizado
                            }
                            //Canceal
                            LojaECommerce.PedidoConfirm(ecommerce.PedidoId);
                        }
                    }
                }
            }

        }

        private static bool CarregarFormaPagamento(Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda, PedidoPagamentoInfo parcelamento)
        {
            Ecommerceformapagto FormaPagamento = null;
            bool resultado = false;
            try
            {
                string filtro = string.Format("CODCOB IS NOT NULL AND CODPLPAG IS NOT NULL AND  ECommerce = 'FBits' AND CODIGONOECOMMERCE = '{0}' AND ROWNUM = 1",
                                              parcelamento.FormaPagamentoId.ToString());
                FormaPagamento = Ecommerceformapagto.Listar(filtro).Single();
                PedidoForcaVenda.Cabecalho.Codcob = FormaPagamento.Codcob;
                PedidoForcaVenda.Cabecalho.Codplpag = FormaPagamento.Codplpag;


                filtro = string.Format("CODPLPAG IS NOT NULL AND ECommerce = 'FBits' AND CODIGONOECOMMERCE = '{0}' AND NUMPARCELA = {1} AND ROWNUM = 1"
                                      , parcelamento.FormaPagamentoId.ToString()
                                      , parcelamento.NumeroParcelas.ToString());

                try
                {
                    Ecommerceformapagto_Parcela TipoParcela = Ecommerceformapagto_Parcela.Listar(filtro).Single();
                    if (TipoParcela.Codplpag > 0)
                    {
                        PedidoForcaVenda.Cabecalho.Codplpag = TipoParcela.Codplpag;
                    }
                }
                catch
                {
                    PedidoForcaVenda.Cabecalho.Codplpag = FormaPagamento.Codplpag;
                }

                resultado = true;
            }
            catch
            {
                resultado = false;
            }

            return resultado;
        }
        private void ReceiveClienteEndereco()
        {
            IntegracaoUsuarioEnderecoInfo[] Lista = LojaECommerce.ClienteEnderecoList();
            if (Lista != null)
            {
                foreach (var localicazacao in Lista)
                {
                    using (var transaction = new System.Transactions.CommittableTransaction())
                    {
                        try
                        {
                            //Verifica se o cliente existe primeiro
                            if (ClienteJaCadastrado(localicazacao.UsuarioId.ToString(), localicazacao.CPF, localicazacao.CNPJ))
                            {//Procura se o endereço existe
                                string documento = string.IsNullOrEmpty(localicazacao.CPF) ? localicazacao.CNPJ : localicazacao.CPF;
                                documento = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(documento);

                                string Filtro = "CODENDENTCLI = {0} AND CODCLI IN (SELECT CODCLI FROM PCCLIENT WHERE ((CODCLIWEB = '{1}') OR (REGEXP_REPLACE(CGCENT, '[^0-9]','') = '{2}')))";
                                if (!PedidoForcaVenda.EnderecoExiste(string.Format(Filtro
                                                                                  , localicazacao.EnderecoId.ToString()
                                                                                  , localicazacao.UsuarioId.ToString()
                                                                                  , documento)))
                                {//Inserindo um novo endereço
                                    PedidoForcaVenda.EnderecoInicializar();
                                    PedidoForcaVenda.Endereco.Codendentcli = localicazacao.EnderecoId;
                                    PedidoForcaVenda.Endereco.Codcli = PedidoForcaVenda.Cliente.Codcli;
                                }
                                PedidoForcaVenda.Endereco.Bairroent = Biblioteca.Tools.Formats.FormatoWinthor(localicazacao.Bairro);
                                PedidoForcaVenda.Endereco.Municent = Biblioteca.Tools.Formats.FormatoWinthor(localicazacao.Cidade);
                                PedidoForcaVenda.Endereco.Estent = localicazacao.Estado;
                                PedidoForcaVenda.Endereco.Cepent = localicazacao.CEP;
                                PedidoForcaVenda.Endereco.Enderent = Biblioteca.Tools.Formats.FormatoWinthor(localicazacao.Endereco);
                                PedidoForcaVenda.Endereco.Complementoent = Biblioteca.Tools.Formats.FormatoWinthor(localicazacao.Complemento);
                                PedidoForcaVenda.Endereco.Numeroent = localicazacao.Numero;



                                if (PedidoForcaVenda.EnderecoGravar())
                                {
                                    //Marca endereço como já importado
                                    LojaECommerce.ClienteEnderecoConfirm(localicazacao.EnderecoId);
                                }
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Processo.Notificar("Integradora.Norma.Winthor.FBits", "ReceiveClienteEndereco", ex);
                        }
                    }
                }
            }
        }
        private bool ClienteJaCadastrado(string codclienteWeb, string CPF, string CNPJ)
        {
            bool retorno = false;

            //Primeiro procura pelo Código
            string filtro = "(CODCLIWEB = '{0}')";
            retorno = PedidoForcaVenda.ClienteExiste(string.Format(filtro
                                                                  , codclienteWeb));
            if (!retorno)
            {   //Depois pelo CNPJ/CPF
                string documento = string.IsNullOrEmpty(CPF) ? CNPJ : CPF;
                documento = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(documento);
                filtro = "(REGEXP_REPLACE(CGCENT, '[^0-9]','') = '{0}')";
                retorno = PedidoForcaVenda.ClienteExiste(string.Format(filtro, documento));
            }

            PedidoForcaVenda.ClienteJaExiste = retorno;

            return retorno;
        }
        private void ReceiveCliente()
        {
            Integradora.ECommerce.FBits.SyncUsuario.IntegracaoUsuarioInfo[] Lista = LojaECommerce.ClienteList();
            if (Lista != null)
            {
                foreach (var consumidor in Lista)
                {
                    using (var transaction = new System.Transactions.CommittableTransaction())
                    {
                        try
                        {
                            PedidoForcaVenda.ClienteJaExiste = true;
                            if (!ClienteJaCadastrado(consumidor.UsuarioId.ToString(), consumidor.CPF, consumidor.CNPJ))
                            {
                                PedidoForcaVenda.ClienteInicializar();
                                PedidoForcaVenda.ClienteJaExiste = false;
                            }
                            ClienteInserir(true
                                          , consumidor.UsuarioId
                                          , consumidor.TipoPessoaId
                                          , consumidor.Nome
                                          , consumidor.RazaoSocial
                                          , consumidor.CPF
                                          , consumidor.CNPJ
                                          , consumidor.Email
                                          , consumidor.RG
                                          , consumidor.OrgaoEmissor
                                          , consumidor.NomeMae
                                          , consumidor.TelefoneResidencial
                                          , consumidor.TelefoneCelular
                                          , consumidor.TelefoneComercial
                                          , consumidor.DataNascimento
                                          , consumidor.InscricaoEstadual
                                          , consumidor.DataCriacao
                                          , consumidor.Endereco
                                          , consumidor.Numero
                                          , consumidor.Complemento
                                          , consumidor.Bairro
                                          , consumidor.Cidade
                                          , consumidor.Estado
                                          , consumidor.CEP
                                          );
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Processo.Notificar("Integradora.Norma.Winthor.FBits", "ReceiveCliente", ex);
                        }
                    }
                }
            }
        }
        private void ClienteInserir(bool viaCadastroCliente, long UsuarioId, int TipoPessoaId, string Nome, string RazaoSocial, string CPF, string CNPJ, string Email, string RG, string OrgaoEmissor, string NomeMae, string TelefoneResidencial,
                                    string TelefoneCelular, string TelefoneComercial, DateTime? DataNascimento, string InscricaoEstadual, DateTime DataCriacao, string Endereco, string Numero, string Complemento,
                                    string Bairro, string Cidade, string Estado, string CEP)
        {
            try
            {
                PedidoForcaVenda.Cliente.Codcliweb = UsuarioId;
                if (TipoPessoaId == 1)
                {
                    PedidoForcaVenda.Cliente.Cliente = string.IsNullOrEmpty(Nome) ? "Nome não informado" : Nome.ToUpper() ;
                    PedidoForcaVenda.Cliente.Cgcent = CPF;
                }
                else
                {
                    PedidoForcaVenda.Cliente.Cliente = string.IsNullOrEmpty(RazaoSocial) ? "Nome não informado" : RazaoSocial.ToUpper();
                    PedidoForcaVenda.Cliente.Cgcent = CNPJ;
                }
                PedidoForcaVenda.Cliente.Sexo = "M";
                PedidoForcaVenda.Cliente.Cgcent = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(PedidoForcaVenda.Cliente.Cgcent);
                PedidoForcaVenda.Cliente.Email = string.IsNullOrEmpty(Email) ? "" : Email.ToLower();
                PedidoForcaVenda.Cliente.Rg = RG;
                PedidoForcaVenda.Cliente.Orgaorg = string.IsNullOrEmpty(OrgaoEmissor) ? "" : OrgaoEmissor.ToUpper();
                PedidoForcaVenda.Cliente.Filiacaomae = string.IsNullOrEmpty(NomeMae) ? "" : NomeMae.ToUpper();
                PedidoForcaVenda.Cliente.Telent = TelefoneResidencial;
                PedidoForcaVenda.Cliente.Telcelent = TelefoneCelular;
                PedidoForcaVenda.Cliente.Telcom = TelefoneComercial;
                PedidoForcaVenda.Cliente.Dtnasc = DataNascimento;
                PedidoForcaVenda.Cliente.Empresa = string.IsNullOrEmpty(RazaoSocial) ? "" : RazaoSocial.ToUpper();
                PedidoForcaVenda.Cliente.Fantasia = string.IsNullOrEmpty(Nome) ? "" : Nome.ToUpper();
                PedidoForcaVenda.Cliente.Inscestadual = InscricaoEstadual;
                PedidoForcaVenda.Cliente.Dtcadastro = DataCriacao;
                if (viaCadastroCliente)
                {
                    PedidoForcaVenda.Cliente.Enderent = Biblioteca.Tools.Formats.FormatoWinthor(Endereco);
                    PedidoForcaVenda.Cliente.Numeroent = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(Numero);
                    PedidoForcaVenda.Cliente.Bairroent = Biblioteca.Tools.Formats.FormatoWinthor(Bairro);
                    PedidoForcaVenda.Cliente.Municent = Biblioteca.Tools.Formats.FormatoWinthor(Cidade);
                    PedidoForcaVenda.Cliente.Estent = string.IsNullOrEmpty(Estado) ? "" : Estado.ToUpper();
                    PedidoForcaVenda.Cliente.Cepent = CEP;
                }
                PedidoForcaVenda.Cliente.Endercom = Biblioteca.Tools.Formats.FormatoWinthor(Endereco);
                PedidoForcaVenda.Cliente.Numerocom = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(Numero);
                PedidoForcaVenda.Cliente.Bairrocom = Biblioteca.Tools.Formats.FormatoWinthor(Bairro);
                PedidoForcaVenda.Cliente.Municcom = Biblioteca.Tools.Formats.FormatoWinthor(Cidade);
                PedidoForcaVenda.Cliente.Estcom = string.IsNullOrEmpty(Estado) ? "" : Estado.ToUpper();
                PedidoForcaVenda.Cliente.Cepcom = CEP;
                PedidoForcaVenda.Cliente.Aceitavendafracao = "S";
                PedidoForcaVenda.Cliente.Validarmultiplovenda = "S";
                PedidoForcaVenda.Cliente.Usacreclifat = "S";
                PedidoForcaVenda.Cliente.Codcontab = Biblioteca.Dictionaries.Settings.ContaContabilCliente();

                if (!string.IsNullOrEmpty(Complemento))
                {
                    int tamanho = Complemento.Length < 55 ? Complemento.Length : 55;
                    if (viaCadastroCliente)
                    {
                        PedidoForcaVenda.Cliente.Complementoent = Complemento.Substring(0, tamanho);
                    }
                    PedidoForcaVenda.Cliente.Complementocom = Complemento.Substring(0, tamanho);
                }

                if (PedidoForcaVenda.ClienteGravar())
                {  //Marca cliente como  já importado
                    LojaECommerce.ClienteConfirm(UsuarioId);
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.FBits", "ClienteInserir", ex.ToString());
            }
        }

        private static bool ExecutarIntegradora(decimal numPedido, decimal codRCA, Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda)
        {
            if (Biblioteca.Dictionaries.Settings.Debugando())
            {
                Logs.GerarLog("Executando integradora do Winthor no pedido: " + numPedido.ToString());
            }
            bool importado = false;
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    PedidoForcaVenda.IntegrarPedido_Modelo_01(numPedido, codRCA);
                    transaction.Commit();
                    importado = true;
                    if (Biblioteca.Dictionaries.Settings.Debugando())
                    {
                        Logs.GerarLog("Concluido a integradora do Winthor no pedido: " + numPedido.ToString());
                    }
                }
                catch (Exception erro)
                {
                    transaction.Rollback();
                    importado = false;
                    ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.FBits.Receber"
                                                      , "ExecutarIntegradora"
                                                      , "Pedido: " + numPedido.ToString() + " erro: " + erro
                                                      , PedidoForcaVenda.Cabecalho.Numpedcli
                                                      , PedidoForcaVenda.Cabecalho.Numpedrca
                                                      , "N"
                                                      , "FBITS");
                }
            }
            return importado;
        }

        private static bool FinalizarIntegracaoPedido(decimal numPedido, Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda)
        {
            bool retorno = false;
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    Logs.GerarLog("Consulta se o pedido foi importado: " + PedidoForcaVenda.Cabecalho.Numpedweb.ToString());
                    //Obtendo pedido importado para ver se foi realmente gerado
                    if (PedidoForcaVenda.PedidoConsultar(PedidoForcaVenda.Cabecalho.Numpedweb))
                    {  //Verifica se foi realmente importado com sucesso
                        Logs.GerarLog("Consulta se o foi importado com sucesso: " + PedidoForcaVenda.Cabecalho.Numpedweb.ToString());
                        if (PedidoForcaVenda.Cabecalho.Importado == "S")
                        {
                            Logs.GerarLog("Consulta se tem valor de desconto cupom: " + PedidoForcaVenda.Cabecalho.Numpedweb.ToString());
                            if (PedidoForcaVenda.Cabecalho.Vldescontocupom > 0)
                            {
                                Logs.GerarLog("Gerar crédito de cliente: " + PedidoForcaVenda.Cabecalho.Numpedweb.ToString());
                                MovimentarCaixa caixa = new MovimentarCaixa();

                                caixa.LancarCreditoCliente(PedidoForcaVenda.Cabecalho.Codcli
                                                          , PedidoForcaVenda.Cabecalho.Codfilial
                                                          , PedidoForcaVenda.Cabecalho.Vldescontocupom.Value
                                                          , PedidoForcaVenda.Cabecalho.Numped);

                                caixa.LancarDespesaCredito(PedidoForcaVenda.Cabecalho.Codcli
                                                          , PedidoForcaVenda.Cabecalho.Codfilial
                                                          , PedidoForcaVenda.Cabecalho.Vldescontocupom.Value
                                                          , PedidoForcaVenda.Cabecalho.Numped);
                            }

                            ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.FBits.Receber"
                                  , "FinalizarIntegracaoPedido"
                                  , "Pedido: " + numPedido.ToString() + " importado."
                                  , PedidoForcaVenda.Cabecalho.Numpedcli
                                  , PedidoForcaVenda.Cabecalho.Numpedrca
                                  , "S"
                                  , "FBITS");
                            retorno = true;
                        }
                        else
                        {  //Senão notifica o motivo da não importação
                            ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.FBits.Receber"
                                  , "FinalizarIntegracaoPedido"
                                  , "Pedido: " + numPedido.ToString() + " não importado: " + PedidoForcaVenda.Cabecalho.Observacao_Pc
                                  , PedidoForcaVenda.Cabecalho.Numpedcli
                                  , PedidoForcaVenda.Cabecalho.Numpedrca
                                  , "N"
                                  , "FBITS");
                            //Apagar pedido
                            if (!Biblioteca.Dictionaries.Settings.Debugando())
                            {
                                //   PedidoForcaVenda.PedidoApagar();
                            }
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception erro)
                {
                    retorno = false;
                    transaction.Rollback();
                    ESTLogpedidoecommerce.GerarExcecao("Integradora.Norma.Winthor.FBits.Receber"
                                                      , "FinalizarIntegracaoPedido"
                                                      , "Pedido: " + numPedido.ToString() + " erro: " + erro
                                                      , PedidoForcaVenda.Cabecalho.Numpedcli
                                                      , PedidoForcaVenda.Cabecalho.Numpedrca
                                                      , "N"
                                                      , "FBITS"
                                                      );
                }
            }
            return retorno;
        }
    }
}

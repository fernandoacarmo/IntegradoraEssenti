using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityPedidoDireto;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ERP.Winthor.Domain
{
    public class PedidoDireto
    {
        public PedidoDireto()
        {

        }

        public string ValidarCabecalhoPedido(Pedido pedido, bool ValidarParcelas)
        {
            //Exportar o pedido para arquivo XML
            Biblioteca.Tools.XML.Export(pedido, "Pedido_" + pedido.Numpedido.ToString());

            //Validar CNPJ/CPF
            if (string.IsNullOrEmpty(pedido.Cliente.CNPJCPF))
            {
                return "CNPJ/CPF do cliente não informado!";
            }
            //Validar código vendedor
            if (pedido.Codvendedor <= 0)
            {
                pedido.Codvendedor = Biblioteca.Dictionaries.Settings.CodRCA();
            }
            if (pedido.Codvendedor <= 0)
            {
                return "Código do vendedor não informado!";
            }
            if (pedido.Codsupervisor <= 0)
            {
                pedido.Codsupervisor = Biblioteca.Dictionaries.Settings.CodSupervisor();
            }
            if (pedido.Codsupervisor <= 0)
            {
                return "Código do supervisor não informado!";
            }
            //Validar quantidade de itens
            if (pedido.Itens.Count <= 0)
            {
                return "Nenhum item inserido!";
            }
            //Validar quantidade de parcelas
            if ((ValidarParcelas) && (pedido.Parcelas.Count <= 0))
            {
                return "Nenhuma parcela inserida!";
            }

            if (PCPedc.Existe("NUMPED = " + pedido.Numpedido.ToString()))
            {
                Biblioteca.Tools.Logs.GerarLog("Integradora.ERP.Winthor", "ValidarCabecalhoPedido", string.Format("Pedido {0} já foi importado!", pedido.Numpedido.ToString()));

                return "JaExiste";
            }

            return "OK";
        }

        public string Gravar(Pedido pedido)
        {
            //Validar cabeçalho do pedido
            string resultado = ValidarCabecalhoPedido(pedido, false);
            if (resultado == "JaExiste")
            {
                return "OK";
            }

            if (resultado != "OK")
            {
                Biblioteca.Tools.Logs.GerarLog("Integradora.ERP.Winthor"
                                    , "Gravar"
                                    , string.Format("Erro na validação do pedido: {0}, erro: {1}", pedido.Numpedido.ToString(), resultado));
                return resultado;
            }
            else
            {
                //Classe de persistência
                Persistencia ba = new Persistencia(PCPedc.GetStringConnection());
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        pedido.Cliente.Codcliente = AtualizarCadastroCliente(pedido.Cliente);
                        if (pedido.Cliente.Codcliente <= 0)
                        {
                            return "Erro na validação do cliente";
                        }

                        string Parametro_UsaWMS = "N";
                        try
                        {
                            Parametro_UsaWMS = PCFilial.Listar(string.Format("CODIGO = '{0}'", pedido.Codfilial)).FirstOrDefault().Usawms;
                        }
                        catch
                        {
                            Parametro_UsaWMS = "N";
                        }

                        PCPedc Cabecalho = new PCPedc();
                        Cabecalho.Numped = pedido.Numpedido;
                        Cabecalho.Numpedcli = pedido.Numpedido.ToString();
                        Cabecalho.Codcli = pedido.Cliente.Codcliente;
                        Cabecalho.Coddistrib = "1";
                        Cabecalho.Tipooper = "B";
                        Cabecalho.Codpraca = pedido.Cliente.Codpraca;
                        Cabecalho.Codusur = pedido.Codvendedor;
                        Cabecalho.Codsupervisor = pedido.Codsupervisor;
                        Cabecalho.Dtimportado = Cabecalho.DataHoraServidor();
                        Cabecalho.Data = pedido.Dtemissao;
                        Cabecalho.Vlatend = pedido.Valortotal;
                        Cabecalho.Vlfrete = pedido.Valorfrete;
                        Cabecalho.Vlfretenf = pedido.Valorfrete;
                        Cabecalho.Vlsubtotal = pedido.Valortotal;
                        Cabecalho.Vltabela = pedido.Valortotal;
                        Cabecalho.Vltotal = pedido.Valortotal;
                        Cabecalho.Vldesconto = pedido.Valordesconto;
                        //Parâmetros 
                        Cabecalho.Codemitente = Biblioteca.Dictionaries.Settings.Matricula();
                        Cabecalho.Codfilial = Biblioteca.Dictionaries.Settings.CodFilialVenda();
                        Cabecalho.Codfilialnf = Biblioteca.Dictionaries.Settings.CodFilialVenda();
                        Cabecalho.Codcob = Biblioteca.Dictionaries.Settings.CodCobranca();
                        Cabecalho.Codplpag = Biblioteca.Dictionaries.Settings.CodPlanoPagamento();
                        Cabecalho.Codpraca = pedido.Cliente.Codpraca;
                        //Campos com valores fixos
                        Cabecalho.Condvenda = 1;
                        Cabecalho.Brinde = "N";
                        Cabecalho.Importado = "S";
                        Cabecalho.Posicao = "L";
                        Cabecalho.Origemped = "C";
                        Cabecalho.Rotina = "Integradora";
                        Cabecalho.Rotinalanc = "Integradora";
                        Cabecalho.Rotinalancultalt = "Integradora";
                        //Calculado nos itens
                        Cabecalho.Totpeso = 0;
                        Cabecalho.Totpesoliq = 0;
                        //A verificar

                        PCProdut CadastroProduto = null;
                        bool InseririuPeloMenosUmProduto = false;
                        foreach (var item in pedido.Itens)
                        {
                            try
                            {   //Localizando o produto
                                CadastroProduto = PCProdut.Listar("CODPROD = " + item.Codproduto.ToString()).FirstOrDefault();
                            }
                            catch
                            {
                                CadastroProduto = null;
                            }

                            if (CadastroProduto == null)
                            {
                                //Cadastrando um novo produto 
                                CadastroProduto = new PCProdut();
                                CadastroProduto.Codprod = item.Codproduto;
                                CadastroProduto.Descricao = item.Descricao;
                                CadastroProduto.Unidade = item.Unidade;
                                CadastroProduto.Unidademaster = item.Unidademaster;
                                CadastroProduto.Embalagem = string.IsNullOrEmpty(item.Embalagem) ? item.Unidade : item.Embalagem;
                                CadastroProduto.Codfunccadastro = Biblioteca.Dictionaries.Settings.Matricula();
                                CadastroProduto.Codfuncultalter = Biblioteca.Dictionaries.Settings.Matricula();
                                CadastroProduto.Codinterno = item.Codproduto.ToString();
                                //CadastroProduto.Codmarca = 0;
                                CadastroProduto.Dtcadastro = CadastroProduto.DataServidor();
                                CadastroProduto.Dtultalter = CadastroProduto.DataServidor();
                                CadastroProduto.Importado = "S";
                                CadastroProduto.Codauxiliar = item.Codauxiliar;
                                CadastroProduto.Pesobruto = item.Pesobruto;
                                CadastroProduto.Pesoliq = item.Pesoliquido;
                                CadastroProduto.Qtunit = item.Qtdeunitaria;
                                CadastroProduto.Qtunitcx = item.Qtdecaixa;
                                CadastroProduto.Revenda = "S";
                                CadastroProduto.Rotinalanc = Cabecalho.Rotinalanc;
                                CadastroProduto.Usawms = Parametro_UsaWMS;
                                CadastroProduto.Naturezaproduto = "OT";
                                CadastroProduto.Sugvenda = 0;
                                CadastroProduto.Cestabasicalegis = "N";
                                CadastroProduto.Codepto = Biblioteca.Dictionaries.Settings.CodDepartamento();
                                CadastroProduto.Codsec = Biblioteca.Dictionaries.Settings.CodSecao();
                                CadastroProduto.Codfornec = Biblioteca.Dictionaries.Settings.CodFornecedor();
                                CadastroProduto.Pvenda = item.Precovenda;
                                CadastroProduto.Ptabelafornec = item.Precotabela;
                                CadastroProduto.Aceitavendafracao = "N";
                                CadastroProduto.Enviainftecnicanfe = "N";
                                CadastroProduto.Tipoestoque = "PA";
                                CadastroProduto.Qttotpal = 1;
                                CadastroProduto.Volume = 1;
                                CadastroProduto.Rua = 1;
                                CadastroProduto.Rua2 = 1;
                                CadastroProduto.Ruact = 1;
                                CadastroProduto.Ruacx = 1;
                                CadastroProduto.Apto = 1;
                                CadastroProduto.Apto2 = 1;
                                CadastroProduto.Aptoct = 1;
                                CadastroProduto.Aptocx = 1;
                                CadastroProduto.Numero = 1;
                                CadastroProduto.Numero2 = 1;
                                CadastroProduto.Numeroct = 1;
                                CadastroProduto.Numerocx = 1;
                                CadastroProduto.Modulo = 1;
                                CadastroProduto.Modulo2 = 1;
                                CadastroProduto.Moduloct = 1;
                                CadastroProduto.Modulocx = 1;
                                CadastroProduto.Deposito = 1;
                                CadastroProduto.Depositocx = 1;
                                CadastroProduto.Nivel = 1;
                                CadastroProduto.Nivelcx = 1;
                                CadastroProduto.Predio = 1;
                                CadastroProduto.Prediocx = 1;
                                CadastroProduto.Dtimportintegracao = CadastroProduto.DataServidor();
                                CadastroProduto.Enviarforcavendas = "N";
                                CadastroProduto.Fracionado = "N";
                                CadastroProduto.Freteespecial = "N";
                                CadastroProduto.Multiplo = 1;
                                CadastroProduto.Pesovariavel = "N";
                                CadastroProduto.Precofixo = "N";
                                CadastroProduto.Temrepos = 1;
                                CadastroProduto.Usaclassificacao = "N";
                                CadastroProduto.Tipoprod = 1;
                                CadastroProduto.Codtipoestruturapul = 1;

                                try
                                {
                                    ba.Inserir(CadastroProduto);
                                    Logs.GerarLog("Integradora.ERP.Winthor", "Gravar", string.Format("Produto {0} foi cadastrado!", item.Codproduto.ToString()));
                                }
                                catch (Exception ex)
                                {
                                    Logs.GerarLog("Integradora.ERP.Winthor", "Gravar", string.Format("Produto {0} não cadastrado! Erro: {1}", item.Codproduto.ToString(), ex.ToString()));
                                    CadastroProduto = null;
                                }
                            }

                            if (CadastroProduto != null)
                            {

                                Cadastrar_ProdutoPorFilial(ba, Cabecalho, item);
                                Cadastrar_Estoque(ba, Cabecalho, item);

                                PCPedi ItemPedido = null;
                                try
                                {
                                    ItemPedido = PCPedi.Listar(string.Format("NUMPED = {0} AND CODPROD = {1}", Cabecalho.Numped, item.Codproduto)).Single();
                                    if (ItemPedido.Codprod > 0)
                                    {
                                        InseririuPeloMenosUmProduto = true;
                                    }
                                }
                                catch
                                {
                                    //Inserindo produto no pedido
                                    ItemPedido = new PCPedi();
                                    ItemPedido.Numped = Cabecalho.Numped;
                                    ItemPedido.Codprod = item.Codproduto;
                                    ItemPedido.Qt = item.Quantidade; ;
                                    ItemPedido.Pvenda = item.Precovenda;
                                    ItemPedido.Pvenda1 = item.Precovenda;
                                    ItemPedido.Pvendaanterior = item.Precovenda;
                                    ItemPedido.Ptabela = item.Precotabela;
                                    ItemPedido.Numseq = item.Numitem;
                                    ItemPedido.Codcli = Cabecalho.Codcli;
                                    //ItemPedido.Codfilialretira = Biblioteca.Dictionaries.Settings.CodFilialRetira();
                                    ItemPedido.Codfuncultalter = Biblioteca.Dictionaries.Settings.Matricula();
                                    ItemPedido.Codplpag = Cabecalho.Codplpag;
                                    ItemPedido.Codusur = Cabecalho.Codusur;
                                    ItemPedido.Condvenda = Cabecalho.Condvenda;
                                    ItemPedido.Data = Cabecalho.Data;
                                    ItemPedido.Dtlanc = Cabecalho.Data;
                                    ItemPedido.Dtultlalter = Cabecalho.Data;
                                    ItemPedido.Numcar = Cabecalho.Numcar;
                                    //ItemPedido.Pesobruto = Convert.ToDecimal(CadastroProduto.Pesobruto) * item.Quantidade;
                                    ItemPedido.Qtunitcx = CadastroProduto.Qtunitcx;
                                    ItemPedido.Rotina = Cabecalho.Rotina;
                                    ItemPedido.Unidade = CadastroProduto.Unidade;
                                    ItemPedido.Posicao = Cabecalho.Posicao;
                                    ItemPedido.Brinde = "N";
                                    ItemPedido.Dtentrega = Cabecalho.Dtentrega;
                                    ItemPedido.Numcar = Cabecalho.Numcar;
                                    ItemPedido.Unidade = CadastroProduto.Unidade;

                                    //Atualizando informação do cabeçalho
                                    Cabecalho.Totpeso += ItemPedido.Pesobruto;
                                    Cabecalho.Totpesoliq += Convert.ToDecimal(CadastroProduto.Pesoliq) * item.Quantidade;

                                    try
                                    {
                                        ba.Inserir(ItemPedido);
                                        InseririuPeloMenosUmProduto = true;
                                    }
                                    catch (Exception ex)
                                    {
                                        transaction.Rollback();
                                        return "Erro ao inserir item do pedido: " + ex.ToString();
                                    }
                                }

                            }
                        }

                        if (InseririuPeloMenosUmProduto)
                        {
                            try
                            {
                                ba.Inserir(Cabecalho);
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                return "Erro ao inserir cabeçalho: " + ex.ToString();
                            }
                        }
                        else
                        {
                            transaction.Rollback();
                            resultado = "Nenhum produto encontrado para o pedido: " + Cabecalho.Numped;
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Logs.GerarLog("Integradora.ERP.Winthor", "Gravar", string.Format("Erro ao gravar pedido: {0} - Erro: {1}", pedido.Numpedido.ToString(), ex.ToString()));

                        resultado = ex.ToString();
                    }
                }
            }

            return resultado;
        }

        private void Cadastrar_Estoque(Persistencia ba, PCPedc Cabecalho, ItemPedido item)
        {
            PCEst Estoque = null;
            try
            {   //Localizando o produto
                Estoque = PCEst.Listar(string.Format("CODPROD = {0} AND CODFILIAL = '{1}'"
                                                    , item.Codproduto.ToString()
                                                    , Cabecalho.Codfilial)).FirstOrDefault();
            }
            catch
            {
                Estoque = null;
            }

            if (Estoque == null)
            {
                Estoque = new PCEst();
                Estoque.Codprod = item.Codproduto;
                Estoque.Codfilial = Cabecalho.Codfilial;
                try
                {
                    ba.Inserir(Estoque);
                    Logs.GerarLog("Integradora.ERP.Winthor", "Cadastrar_Estoque", string.Format("Estoque do produto {0} foi cadastrado!", item.Codproduto.ToString()));
                }
                catch (Exception ex)
                {
                    Logs.GerarLog("Integradora.ERP.Winthor", "Cadastrar_Estoque", string.Format("Estoque do produto {0} não cadastrado! Erro: {1}", item.Codproduto.ToString(), ex.ToString()));
                    Estoque = null;
                }
            }
        }

        private static void Cadastrar_ProdutoPorFilial(Persistencia ba, PCPedc Cabecalho, ItemPedido item)
        {
            PCProdfilial CadastroProdutoFilial = null;
            try
            {   //Localizando o produto
                CadastroProdutoFilial = PCProdfilial.Listar(string.Format("CODPROD = {0} AND CODFILIAL = '{1}'"
                                                                        , item.Codproduto.ToString()
                                                                        , Cabecalho.Codfilial)).FirstOrDefault();
            }
            catch
            {
                CadastroProdutoFilial = null;
            }

            if (CadastroProdutoFilial == null)
            {
                CadastroProdutoFilial = new PCProdfilial();

                CadastroProdutoFilial.Codprod = item.Codproduto;
                CadastroProdutoFilial.Codfilial = Cabecalho.Codfilial;
                CadastroProdutoFilial.Ativo = "S";
                CadastroProdutoFilial.Calccredipi = "N";
                CadastroProdutoFilial.Codcomprador = 1;
                CadastroProdutoFilial.Codfuncultalter = Biblioteca.Dictionaries.Settings.Matricula();
                CadastroProdutoFilial.Codrotinaultaltcom = Biblioteca.Dictionaries.Settings.Rotina();
                CadastroProdutoFilial.Codrotinaultalter = Biblioteca.Dictionaries.Settings.Rotina();
                CadastroProdutoFilial.Foralinha = "N";
                CadastroProdutoFilial.Proibidavenda = "N";
                CadastroProdutoFilial.Fracionado = "N";
                CadastroProdutoFilial.Geraicmslivrofiscal = "N";
                CadastroProdutoFilial.Geraicmslivrofiscaldevfornec = "N";
                CadastroProdutoFilial.Geraicmslivrofiscalent = "N";
                CadastroProdutoFilial.Revenda = "S";
                CadastroProdutoFilial.Codtipoestruturapul = 1;
                CadastroProdutoFilial.Tipoprod = 1;
                CadastroProdutoFilial.Qttotpal = 1;
                try
                {
                    ba.Inserir(CadastroProdutoFilial);
                    Logs.GerarLog("Integradora.ERP.Winthor", "Cadastrar_ProdutoPorFilial", string.Format("Produto x filial {0} foi cadastrado!", item.Codproduto.ToString()));
                }
                catch (Exception ex)
                {
                    Logs.GerarLog("Integradora.ERP.Winthor", "Cadastrar_ProdutoPorFilial", string.Format("Produto x filial {0} não cadastrado! Erro: {1}", item.Codproduto.ToString(), ex.ToString()));
                    CadastroProdutoFilial = null;
                }

            }
        }


        private long AtualizarCadastroCliente(Cliente cliente)
        {
            ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda = new ERP.Winthor.Domain.PedidoWeb();

            string CNPJ_CPF = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(cliente.CNPJCPF);
            //Verifica se o cliente do pedido existe no Winthor
            if (!PedidoForcaVenda.ClienteExiste("REGEXP_REPLACE(CGCENT, '[^0-9]','') = '" + CNPJ_CPF + "'"))
            {
                //Criando um novo cliente
                PedidoForcaVenda.ClienteInicializar();

                PedidoForcaVenda.Cliente.Cliente = Formats.FormatoWinthor(cliente.Razaosocial);
                PedidoForcaVenda.Cliente.Fantasia = Formats.FormatoWinthor(cliente.Nomefantasia);
                PedidoForcaVenda.Cliente.Enderent = Formats.FormatoWinthor(cliente.Endereco);
                PedidoForcaVenda.Cliente.Bairroent = Formats.FormatoWinthor(cliente.Bairro);
                PedidoForcaVenda.Cliente.Complementoent = Formats.FormatoWinthor(cliente.Complemento);
                PedidoForcaVenda.Cliente.Numeroent = Formats.FormatoWinthor(cliente.Numero);
                PedidoForcaVenda.Cliente.Municent = Formats.FormatoWinthor(cliente.Cidade);
                PedidoForcaVenda.Cliente.Estent = Formats.FormatoWinthor(cliente.Estado);
                //PedidoForcaVenda.Cliente.Paisent = Formats.FormatoWinthor(client);
                PedidoForcaVenda.Cliente.Ieent = string.IsNullOrEmpty(cliente.Inscricaoestadual) ? "ISENTO" : Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(cliente.Inscricaoestadual);
                //PedidoForcaVenda.Cliente.Pontorefer = Formats.FormatoWinthor(VTexPedido.shippingData.address.reference);
                PedidoForcaVenda.Cliente.Site = "PROTHEUS";
                PedidoForcaVenda.Cliente.Cgcent = CNPJ_CPF;
                PedidoForcaVenda.Cliente.Dtultcomp = PedidoForcaVenda.Cliente.DataServidor();
                PedidoForcaVenda.Cliente.Dtultvisita = PedidoForcaVenda.Cliente.Dtultcomp;
                PedidoForcaVenda.Cliente.Email = string.IsNullOrEmpty(cliente.Email) ? "" : cliente.Email.ToLower();
                PedidoForcaVenda.Cliente.Telent = cliente.Telefone;
                PedidoForcaVenda.Cliente.Telcelent = cliente.Celular;
                PedidoForcaVenda.Cliente.Cepent = cliente.CEP;

                PedidoForcaVenda.ClienteGravar();
            }


            cliente.Codcliente = Convert.ToInt32(PedidoForcaVenda.Cliente.Codcli);
            cliente.Codpraca = Convert.ToInt32(PedidoForcaVenda.Cliente.Codpraca);

            return cliente.Codcliente;
        }

    }
}

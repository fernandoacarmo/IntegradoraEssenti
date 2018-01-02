using Integradora.ECommerce.Ajuri.Comum;
using Integradora.ECommerce.Ajuri.Metodos;
using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Serialization;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using Integradora.ECommerce.Ajuri.Retornos;
using System.Xml;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.View;

namespace Integradora.WebServiceOMBoat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.


    public class ServiceTrafego : IServiceTrafego
    {
        #region Propriedades
        private Cadastrar cadastrar { get; set; }

        #endregion

        #region Funções auxiliares
        private ResponseOf retornoPadrao(string TickedID, Respostas respostas, String quantidadeRegistro, String pid)
        {
            ResponseOf retorno = new ResponseOf();

            retorno.Requestdate = DateTime.Now.ToString();
            retorno.Responseticket = retorno.Requestdate;
            retorno.Requestticket = TickedID;
            retorno.Status = respostas.status();
            retorno.Detail = quantidadeRegistro;
            retorno.Message = respostas.mensagemRespostas();
            retorno.Pid = pid;

            return retorno;
        }

        private ResponseOf retornoBase(IBaseAjuri registro, Respostas respostas, String quantidadeRegistro)
        {
            return retornoPadrao(registro.Ticket.Id
                                , respostas
                                , quantidadeRegistro
                                , registro.Ticket.Pid
                                );
        }

        private string NomeArquivoXML(string nomeBase)
        {
            string nome = nomeBase;
            Random randnum = new Random();
            randnum.Next();

            nome = nome + randnum.Next().ToString();

            return nome;
        }
        #endregion

        public ServiceTrafego()
        {
            cadastrar = new Cadastrar();
        }

        /// <summary>
        /// Importação de pessoas: Cliente, Fornecedor, Fabricante e Destinatários
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public ResponseOf wms_entidade(AlimentaEntidadeMestraXML xml)
        {
            Respostas respostas = new Respostas();
            string nomeXML = NomeArquivoXML("AlimentaEntidadeMestra");

            if (xml != null)
            {
                Biblioteca.Tools.XML.Export(xml, nomeXML);

                //Importando registros
                foreach (var item in xml.AlimentaEntidadeMestra.Entidades.Entidade)
                {
                    if (item.Iscliente == "SIM") //Importar clientes
                    {
                        respostas.processado = cadastrar.ImportarCliente(item) > 0;
                    }
                    if (item.Isdestinatario == "SIM") //Importar destinatários
                    {
                        respostas.processado = cadastrar.ImportarCliente(item) > 0;
                    }
                    if (item.Isfornecedor == "SIM") //Importar fornecedor
                    {
                        respostas.processado = cadastrar.ImportarFornecedor(item) > 0;
                    }
                    if (item.Isfabricante == "SIM") //Importar fabricante
                    {
                        respostas.processado = cadastrar.ImportarFabricante(item) > 0;
                    }
                }
            }
            else
            {
                xml = new AlimentaEntidadeMestraXML();
                respostas.ClaseNaoInformada();
            }

            //Montando o retorno - Resultado do processamento
            ResponseOf retorno = retornoBase(xml.AlimentaEntidadeMestra
                                            , respostas
                                            , xml.AlimentaEntidadeMestra.Entidades.Entidade.Count().ToString()
                                            );
            Biblioteca.Tools.XML.Export(retorno, nomeXML + "_Resposta");
            return retorno;
        }

        /// <summary>
        /// Importação de cadastro de produtos
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public ResponseOf wms_produto(AlimentaProdutoXML xml)
        {
            Respostas respostas = new Respostas();
            string nomeXML = NomeArquivoXML("alimentaProduto");

            if (xml != null)
            {
                Biblioteca.Tools.XML.Export(xml, nomeXML);
                //Importando registros
                foreach (var item in xml.AlimentaProduto.Produtos.Produto)
                {
                    respostas.processado = cadastrar.ImportarProduto(item, "") > 0;
                }
            }
            else
            {
                xml = new AlimentaProdutoXML();
                respostas.ClaseNaoInformada();
            }

            //Montando o retorno - Resultado do processamento
            ResponseOf retorno = retornoBase(xml.AlimentaProduto
                                            , respostas
                                            , xml.AlimentaProduto.Produtos.Produto.Count().ToString()
                                            );
            Biblioteca.Tools.XML.Export(retorno, nomeXML + "_Resposta");
            return retorno;
        }

        /// <summary>
        /// Importar nota fiscal de entrada ou pedidos de vendas (AR)
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public ResponseOf wms_inout(AlimentaIOXML xml)
        {
            Respostas respostas = new Respostas();
            string nomeXML = NomeArquivoXML("alimentaIO");

            if (xml != null)
            {
                Biblioteca.Tools.XML.Export(xml, nomeXML);
                foreach (var item in xml.AlimentaIO.Documentos.Documento)
                {
                    if (item.Tipo == "ENTRADA")
                    {
                        respostas = cadastrar.ImportarDocumentoEntrada(item);
                    }
                    if (item.Tipo == "SAIDA")
                    {
                        respostas = cadastrar.ImportarDocumentoSaida(item);
                    }
                }
            }
            else
            {
                xml = new AlimentaIOXML();
                respostas.ClaseNaoInformada();
            }

            //Montando o retorno - Resultado do processamento
            ResponseOf retorno = retornoBase(xml.AlimentaIO
                                            , respostas
                                            , xml.AlimentaIO.Documentos.Documento.Count().ToString()
                                            );

            Biblioteca.Tools.XML.Export(retorno, nomeXML + "_Resposta");
            return retorno;
        }

        /// <summary>
        /// Cancelamento de nota fiscal de entrada ou pedidos de vendas (AR)
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public ResponseOf wms_inout_cancela(CancelarIOXML xml)
        {
            Respostas respostas = new Respostas();
            string nomeXML = NomeArquivoXML("cancelarIO");

            if (xml != null)
            {
                Biblioteca.Tools.XML.Export(xml, nomeXML);
                foreach (var item in xml.CancelarIO.Documentos.Cancelamento)
                {
                    respostas = cadastrar.ImportarCancelarDocumento(item);
                }
            }
            else
            {
                xml = new CancelarIOXML();
                respostas.ClaseNaoInformada();
            }

            //Montando o retorno - Resultado do processamento
            ResponseOf retorno = retornoBase(xml.CancelarIO
                                            , respostas
                                            , xml.CancelarIO.Documentos.Cancelamento.Count().ToString()
                                            );

            Biblioteca.Tools.XML.Export(retorno, nomeXML + "_Resposta");
            return retorno;
        }

        /// <summary>
        /// Gerenciar estoque: Bloquear e desbloquear
        /// </summary>
        /// <param name="xml"></param> 
        /// <returns></returns>
        public RetornaAtuarEstoque wms_estoque_atuacao(AlimentaAtuarEstoqueXML xml)
        {
            Respostas respostas = new Respostas();
            string nomeXML = NomeArquivoXML("AlimentaAtuarEstoque");
            //Montando o retorno - Resultado do processamento
            RetornaAtuarEstoque retorno = new RetornaAtuarEstoque();

            if (xml != null)
            {
                Biblioteca.Tools.XML.Export(xml, nomeXML);
                foreach (var item in xml.AlimentaAtuarEstoque.Atuacoes.Atuacao)
                {
                    respostas = cadastrar.ExecutarTemSaldo( item.Produto.Partnumber
                                                          , item.Serial
                                                          , item.Lote
                                                          , Convert.ToDecimal(item.Quantidade)
                                                          , !item.Tipo.Contains("DESBLOQUEAR")
                                                          );

                    if (respostas.mensagem != "OK")
                    {
                        respostas.processado = false;
                        break;
                    }
                }

                if (respostas.mensagem == "OK")
                {
                    foreach (var item in xml.AlimentaAtuarEstoque.Atuacoes.Atuacao)
                    {
                        respostas = cadastrar.ImportarEstoqueBloqueioDesbloqueio(item);
                        AtuacaoRetornaAtuarEstoque atuacao = new AtuacaoRetornaAtuarEstoque();

//                        atuacao.Almoxarifado.Codigo = item.Almoxarifado.Codigo;
//                        atuacao.Almoxarifado.Descricao = item.Almoxarifado.Descricao;
                        atuacao.Cliente.Documentofederal = item.Cliente.Documentofederal;
                        atuacao.Cliente.Razaosocial = item.Cliente.Razaosocial;
                        atuacao.Datafabricacao = item.Datafabricacao;
                        atuacao.Datavencimento = item.Datavencimento;
                        atuacao.Descricao = item.Descricao;
//                        atuacao.Fornecedor.Documentofederal = item.Fornecedor.Documentofederal;
//                        atuacao.Fornecedor.Razaosocial = item.Fornecedor.Razaosocial;
                        atuacao.Lote = item.Lote;
                        atuacao.Modelo = item.Modelo;
                        atuacao.Motivo.Codigo = item.Motivo.Codigo;
//                        atuacao.Posicao.Coluna = item.Posicao.Coluna;
//                        atuacao.Posicao.Nivel = item.Posicao.Nivel;
//                        atuacao.Posicao.Rua = item.Posicao.Rua;
//                        atuacao.Predio.Codigo = item.Predio.Codigo;
//                        atuacao.Predio.Descricao = item.Predio.Descricao;
                        atuacao.Produto.Descricao = item.Produto.Descricao;
                        atuacao.Produto.Partnumber = item.Produto.Partnumber;
                        atuacao.Quantidadeunidades = item.Quantidade;
                        atuacao.Serial = item.Serial;
                        atuacao.Tipo = item.Tipo;
                        foreach (var itemLivre in item.Livres.Livre)
                        {
                            LivreRetornaAtuarEstoque livreatuacao = new LivreRetornaAtuarEstoque();
                            livreatuacao.Indice = itemLivre.Indice;
                            livreatuacao.Nome = itemLivre.Nome;
                            livreatuacao.Valor = itemLivre.Valor;
                            atuacao.Livres.Livre.Add(livreatuacao);
                        }

                        retorno.Atuacoes.Atuacao.Add(atuacao);
                    }
                }
                else
                {
                    retorno.Status = "ERROR";
                }
            }
            else
            {
                xml = new AlimentaAtuarEstoqueXML();
                respostas.ClaseNaoInformada();
            }

            retorno.Ticket.ObterDados();
            retorno.Target.Observacoes = respostas.mensagem;
            retorno.Target.ObterDados();
            retorno.Status = respostas.status();

            return retorno;
        }

        /// <summary>
        /// Ajustar estoque: Acerto ou transferência
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public RetornaCorrigeEstoque wms_estoque_corrige(CorrigeEstoqueXML xml)
        {
            Respostas respostas = new Respostas();

            //Montando o retorno - Resultado do processamento
            RetornaCorrigeEstoque retorno = new RetornaCorrigeEstoque();
            string nomeXML = NomeArquivoXML("corrigeEstoque");
            if (xml != null)
            {
                Biblioteca.Tools.XML.Export(xml, nomeXML);

                foreach (var item in xml.CorrigeEstoque.Correcoes.Correcao)
                {
                    respostas = cadastrar.ExecutarTemSaldo( item.Origem.Produto.Partnumber
                                                          , item.Origem.Serial
                                                          , item.Origem.Lote
                                                          , Convert.ToDecimal(item.Origem.Quantidadeunidades)
                                                          , true
                                                          );

                    if (respostas.mensagem != "OK")
                    {
                        respostas.processado = false;
                        break;
                    }
                }

                if (respostas.mensagem == "OK")
                {

                    foreach (var item in xml.CorrigeEstoque.Correcoes.Correcao)
                    {
                        respostas = cadastrar.ImportarEstoqueTransferenciaAcerto(item);

                        CorrecaoRetornaCorrigeEstoque correcao = new CorrecaoRetornaCorrigeEstoque();
                        correcao.Tipo = item.Tipo;
                        correcao.Cliente.Documentofederal = item.Cliente.Documentofederal;
                        correcao.Cliente.Razaosocial = item.Cliente.Razaosocial;
                        correcao.Destino.Fabricacao = item.Destino.Fabricacao;
                        correcao.Destino.Lote = item.Destino.Lote;
                        correcao.Destino.Modelo = item.Destino.Modelo;
                        correcao.Destino.Produto.Partnumber = item.Destino.Produto.Partnumber;
                        correcao.Destino.Quantidadeunidades = item.Destino.Quantidadeunidades;
                        correcao.Destino.Serial = item.Destino.Serial;
                        correcao.Destino.Vencimento = item.Destino.Vencimento;
                        correcao.Filial.Codigo = item.Filial.Codigo;
                        correcao.Filial.Documentofederal = item.Filial.Documentofederal;
                        correcao.Filial.Razaosocial = item.Filial.Razaosocial;
                        correcao.Origem.Fabricacao = item.Origem.Fabricacao;
                        correcao.Origem.Lote = item.Origem.Lote;
                        correcao.Origem.Modelo = item.Origem.Modelo;
                        correcao.Origem.Produto.Partnumber = item.Origem.Produto.Partnumber;
                        correcao.Origem.Quantidadeunidades = item.Origem.Quantidadeunidades;
                        correcao.Origem.Serial = item.Origem.Serial;
                        correcao.Origem.Vencimento = item.Origem.Vencimento;

                        foreach (var itemLivre in item.Livres.Livre)
                        {
                            LivreRetornaCorrigeEstoque livreatuacao = new LivreRetornaCorrigeEstoque();
                            livreatuacao.Indice = itemLivre.Indice;
                            livreatuacao.Nome = itemLivre.Nome;
                            livreatuacao.Valor = itemLivre.Valor;
                            correcao.Livres.Livre.Add(livreatuacao);
                        }

                        retorno.Correcoes.Correcao.Add(correcao);
                    }
                }
                else
                {
                    retorno.Status = "ERROR";
                }
            }
            else
            {
                xml = new CorrigeEstoqueXML();
                respostas.ClaseNaoInformada();
            }

            retorno.Ticket.ObterDados();
            //retorno.Ticket.Observacoes = respostas.mensagem;
            retorno.Target.ObterDados();
            retorno.Target.Observacoes = respostas.mensagem;

            retorno.Status = respostas.status();

            Biblioteca.Tools.XML.Export(retorno, nomeXML + "_Resposta");


            return retorno;
        }

        /// <summary>
        /// Inventário
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public ResponseOf wms_inventario(InventarioXML xml)
        {
            Respostas respostas = new Respostas();
            string nomeXML = NomeArquivoXML("inventario");

            if (xml != null)
            {
                Biblioteca.Tools.XML.Export(xml, nomeXML);
                if (xml.Inventario.Tipo == "NOVO")
                {
                    respostas.processado = cadastrar.ImportarInventarioAbertura(xml.Inventario);
                }
            }
            else
            {
                xml = new InventarioXML();
                respostas.ClaseNaoInformada();
            }

            //Montando o retorno - Resultado do processamento
            ResponseOf retorno = retornoPadrao(xml.Inventario.Inventario_id
                                              , respostas
                                              , xml.Inventario.Material.Item.Count().ToString()
                                              , ""
                                              );
            Biblioteca.Tools.XML.Export(retorno, nomeXML + "_Resposta");
            return retorno;
        }

        public ResponseOf wms_inventarioConferido(RetornaInventarioXML xml)
        {
            Respostas respostas = new Respostas();
            string nomeXML = NomeArquivoXML("retornoinventario");

            if (xml != null)
            {
                Biblioteca.Tools.XML.Export(xml, nomeXML);
                if (xml.RetornaInventario.Tipo == "RETORNOLOTE")
                {
                    respostas.processado = cadastrar.ImportarInventarioFechamento(xml.RetornaInventario);
                }
            }
            else
            {
                xml = new RetornaInventarioXML();
                respostas.ClaseNaoInformada();
            }

            //Montando o retorno - Resultado do processamento
            ResponseOf retorno = retornoPadrao(xml.RetornaInventario.Inventario_id
                                              , respostas
                                              , xml.RetornaInventario.Itens.Item.Count().ToString()
                                              , ""
                                              );
            Biblioteca.Tools.XML.Export(retorno, nomeXML + "_Resposta");
            return retorno;
        }

        public ResponseStatusDocumento wms_statusDocumento(string tipoDocumento, string numeroDocumento)
        {
            ResponseStatusDocumento retorno = new ResponseStatusDocumento();

            retorno.Tipo = tipoDocumento;
            retorno.Numero = Biblioteca.Tools.Numbers.OnlyNumbers(numeroDocumento);
            retorno.Numero = string.IsNullOrEmpty(retorno.Numero) ? "Todos" : numeroDocumento;
            if (string.IsNullOrEmpty(tipoDocumento))
            {
                retorno.Status = "ERROR: Tipo do documento não informado";
                return retorno;
            }

            if (tipoDocumento == "ENTRADA")
            {
                retorno.Documentos.Documento = cadastrar.ObterStatusEntradas(numeroDocumento);
                retorno.Status = "SUCCESS";
                return retorno;
            }
            else
            {

                if (tipoDocumento == "SAIDA")
                {
                    retorno.Documentos.Documento = cadastrar.ObterStatusSaidas(numeroDocumento);
                    retorno.Status = "SUCCESS";
                    return retorno;
                }
                else
                {
                    retorno.Status = "ERROR: Tipo do documento deve ser ENTRADA para nota fiscal de entrada ou SAIDA para pedido/AR";
                    return retorno;
                }
            }
        }

        public ResponsePosicaoEstoquePorMotivo wms_posicaoEstoquePorMotivo(string motivo, string partNumber, string lote)
        {
            ResponsePosicaoEstoquePorMotivo retorno = new ResponsePosicaoEstoquePorMotivo();

            retorno.Estoques = new Estoques();
            retorno.Estoques.Estoque = new System.Collections.Generic.List<Estoque>();

            string filtro = " 1=1 ";
            if (!string.IsNullOrEmpty(motivo))
                filtro = filtro + " AND MOTIVO = '" + motivo + "'";
            if (!string.IsNullOrEmpty(partNumber))
                filtro = filtro + " AND NUMAJURI = '" + partNumber + "'";
            if (!string.IsNullOrEmpty(lote))
                filtro = filtro + " AND NUMLOTE = '" + lote + "'";

            var estoque = ESTEstoquemotivo.Listar(filtro);
            if (estoque.Count() > 0)
            {
                foreach (var item in estoque)
                {
                    Estoque lista = new Estoque();

                    lista.Lote = item.Numlote;
                    lista.Partnumber = item.Numajuri;
                    lista.Quantidade = item.Qtsaldo;
                    lista.Motivo = item.Motivo;
                    lista.Serial = item.Serial;
                    lista.Modelo = item.Modelo;

                    if (item.Dtfabricacao != null)
                        lista.Fabricacao = Calendars.ToDateTime(item.Dtfabricacao).Date.ToString(Calendars.GetMascaraDataXML());
                    if (item.Dtvalidade != null)
                        lista.Vencimento = Calendars.ToDateTime(item.Dtvalidade).Date.ToString(Calendars.GetMascaraDataXML());

                    retorno.Estoques.Estoque.Add(lista);
                }
                retorno.Status = "SUCCESS";
            }

            if ((string.IsNullOrEmpty(motivo)) || (motivo == "DISPONIVEL"))
            {
                filtro = "1=1";
                if (!string.IsNullOrEmpty(partNumber))
                    filtro = filtro + " AND NUMAJURI = '" + partNumber + "'";
                if (!string.IsNullOrEmpty(lote))
                    filtro = filtro + " AND NUMLOTE = '" + lote + "'";

                var disponivel = EsvEstoqueDisponivel.Listar(filtro);
                if (disponivel.Count() > 0)
                {
                    foreach (var item in disponivel)
                    {
                        Estoque lista = new Estoque();

                        lista.Lote = item.Numlote;
                        lista.Partnumber = item.Numajuri;
                        lista.Quantidade = item.Qtsaldo;
                        lista.Motivo = item.Motivo;
                        lista.Serial = item.Serial;
                        lista.Modelo = item.Modelo;

                        if (item.Dtfabricacao != null)
                            lista.Fabricacao = Calendars.ToDateTime(item.Dtfabricacao).Date.ToString(Calendars.GetMascaraDataXML());
                        if (item.Dtvalidade != null)
                            lista.Vencimento = Calendars.ToDateTime(item.Dtvalidade).Date.ToString(Calendars.GetMascaraDataXML());

                        retorno.Estoques.Estoque.Add(lista);
                    }
                    retorno.Status = "SUCCESS";
                }
            }

            if (retorno.Estoques.Estoque.Count == 0)
            {
                retorno.Status = "ERROR: Nenhum registro encontrado para o filtro informado!";
            }
            else
            {
                retorno.Status = "SUCCESS";
            }

            return retorno;
        }
    }
}

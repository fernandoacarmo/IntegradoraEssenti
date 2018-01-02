using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.FBits.SyncCategoria;
using Integradora.ECommerce.FBits.SyncEstoque;
using Integradora.ECommerce.FBits.SyncProduto;
using Integradora.ECommerce.FBits.SyncProdutoCategoria;
using Integradora.ECommerce.FBits.SyncProdutoCombo;
using Integradora.ECommerce.FBits.SyncProdutoFornecedor;
using Integradora.ECommerce.FBits.SyncProdutoPreco;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.FBits
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.FBits.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.FBits.Integracao();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadECommerce("1=1 order by dtinclusao");
            foreach (var item in lista)
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        if (Biblioteca.Dictionaries.Settings.Debugando())
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.FBits", "Process", "Enviar: " + item.Tabela);
                        }

                        string filtro = "rowid = '" + item.Id + "'";

                        //Criando a classe e carregando
                        if (item.Tabela.Substring(0, 2) == "VW")
                            filtro = "B.rid = '" + item.Id + "'";

                        var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, filtro);

                        //Caso tenha encontrado processa
                        if (integracao != null)
                        {
                            switch (item.Tabela.ToString())
                            {
                                case "VWEMBALAGENS":
                                    SendEmbalagem((VWEmbalagens)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "VWFORMULACAO":
                                    SendFormulacao((VWFormulacao)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCDEPTOWEB":
                                    SendDepartamento((PCDeptoweb)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCSECAOWEB":
                                    SendSecao((PCSecaoweb)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCCATEGORIAWEB":
                                    SendCategoria((PCCategoriaweb)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCSUBCATEGORIAEB":
                                    SendSubcategoria((PCSubcategoriaweb)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCCRECLI":
                                    SendCreditoCliente((PCCrecli)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCNFSAID":
                                    SendNotaFiscal((PCNfsaid)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                            }
                        }
                        else
                        {
                            if (Biblioteca.Dictionaries.Settings.Debugando())
                            {
                                Logs.GerarLog("Integradora.Norma.Winthor.FBits", "Process", string.Format("Nenhum registro encontrado para a tabela: {0} - Filtro: {1}", item.Tabela, filtro));
                            }
                        }

                        Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.FBits", "Process", ex);
                    }
                }
            }
        }

        private void SendNotaFiscal(PCNfsaid dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            try
            {
                if (!string.IsNullOrEmpty(dados.Numpedcli))
                {
                    ECommerce.FBits.SyncPedidoStatus.IntegracaoPedidoStatusInfo pedido = new ECommerce.FBits.SyncPedidoStatus.IntegracaoPedidoStatusInfo();

                    pedido.ChaveAcessoNFE = dados.Chavenfe;
                    pedido.DataEvento = Calendars.ToDateTime(dados.Dtfat);
                    pedido.NumeroNotaFiscal = dados.Numnota.ToString();
                    pedido.PedidoId = Convert.ToInt64(dados.Numpedcli);
                    pedido.SerieNFE = dados.Serie;

                    LojaECommerce.PedidoUpdateStatus(pedido);
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits"
                                  , "SendNotaFiscal"
                                  , string.Format("Errro ao enviar dados da nota fiscal: {0} - {1}", dados.Numnota.ToString(), ex.ToString()));
            }
        }

        private void SendCreditoCliente(PCCrecli dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            try
            {
                string usuarioId = "";
                try
                {
                    usuarioId = PCClient.Listar("CODCLI = " + dados.Codcli).FirstOrDefault().Codcliweb.ToString();
                }
                catch
                {//Cliente não e cliente do e-commerce
                    return;
                }

                string numPedidoWeb = "";
                try
                {
                    numPedidoWeb = PCPedctemp.Listar("NUMPED = " + dados.Numped).FirstOrDefault().Numpedweb.ToString();
                }
                catch
                {
                    return;
                }

                //Inserindo o crédito de cliente ao cancelar o pedido
                LojaECommerce.ContaCorrenteInsert(usuarioId
                                                 , dados.Valor.ToString()
                                                 , ECommerce.FBits.Integracao.TipoLancamento.Credito
                                                 , Convert.ToInt32(numPedidoWeb)
                                                 , dados.Obs);
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits"
                                  , "SendCreditoCliente"
                                  , string.Format("Crédito de cliente não enviado: {0} - {1}", dados.Numlanc.ToString(), ex.ToString()));
            }
        }

        private void SendSubcategoria(PCSubcategoriaweb dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            try
            {
                IntegracaoCategoriaInfo registro = new IntegracaoCategoriaInfo();

                string montarcodigo = dados.Codsecao.ToString() + dados.Codcategoria.ToString() + dados.Codsubcategoria.ToString();

                registro.CategoriaClientePaiId = (dados.Codcategoria + 2000000).ToString();
                registro.CategoriaClienteId = montarcodigo;
                registro.Nome = dados.Descricao;

                LojaECommerce.ClienteCategoriaInsertUpdate(registro);
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits", "SendSubcategoria", string.Format("SubCategoria não enviado: {0} - {1}", dados.Codsubcategoria.ToString(), ex.ToString()));
            }
        }

        private void SendCategoria(PCCategoriaweb dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            try
            {
                IntegracaoCategoriaInfo registro = new IntegracaoCategoriaInfo();
                registro.CategoriaClientePaiId = (dados.Codsecao + 1000000).ToString();
                registro.CategoriaClienteId = (dados.Codcategoria + 2000000).ToString();
                registro.Nome = dados.Descricao;

                LojaECommerce.ClienteCategoriaInsertUpdate(registro);
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits", "SendCategoria", string.Format("Categoria não enviado: {0} - {1}", dados.Codcategoria.ToString(), ex.ToString()));
            }
        }

        private void SendSecao(PCSecaoweb dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            try
            {
                IntegracaoCategoriaInfo registro = new IntegracaoCategoriaInfo();
                registro.CategoriaClientePaiId = dados.Coddepto.ToString();
                registro.CategoriaClienteId = (dados.Codsecao + 1000000).ToString();
                registro.Nome = dados.Descricao;

                LojaECommerce.ClienteCategoriaInsertUpdate(registro);
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits", "SendSecao", string.Format("Seção não enviado: {0} - {1}", dados.Codsecao.ToString(), ex.ToString()));
            }
        }

        private void SendDepartamento(PCDeptoweb departamento, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            try
            {
                IntegracaoCategoriaInfo registro = new IntegracaoCategoriaInfo();
                registro.CategoriaClienteId = departamento.Coddepto.ToString();
                registro.Nome = departamento.Descricao;

                LojaECommerce.ClienteCategoriaInsertUpdate(registro);
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits", "SendDepartamento", string.Format("Departamento não enviado: {0} - {1}", departamento.Coddepto.ToString(), ex.ToString()));
            }
        }
        private void SendFormulacao(VWFormulacao formulacao, Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao Acao)
        {
            IntegracaoProdutoCombo registro = new IntegracaoProdutoCombo();

            registro.FabricanteId = Convert.ToInt32(formulacao.Codfornec);
            registro.Nome = formulacao.Descricaoacab;
            if (formulacao.Poferta > 0)
            {
                registro.Valor = formulacao.Poferta;
            }
            else
            {
                registro.Valor = formulacao.Pvenda;
            }

            IntegracaoProdutoComboComponente item = new IntegracaoProdutoComboComponente();
            item.SKU = formulacao.Codauxiliarmp.ToString();
            item.Quantidade = Convert.ToInt32(formulacao.Qtprodamp);
            item.Variante = false;
            registro.ListaComponentes[0] = item;

            LojaECommerce.ComboInserir(registro);
        }

        private void SendEmbalagem(VWEmbalagens embalagem, Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao Acao)
        {
            if (Biblioteca.Dictionaries.Settings.Debugando())
            {
                Logs.GerarLog("Integradora.Norma.Winthor.FBits", "SendEmbalagem", "enviando embalagem: " + embalagem.SKU.ToString());
            }
            bool retorno = false;

            IntegracaoProdutoVarianteInfo registro = new IntegracaoProdutoVarianteInfo();

            registro.FabricanteNome = embalagem.Fabricante;
            registro.Nome = embalagem.DescricaoWEB.Replace("´", "").Replace("`", "").Replace("@", "");
            registro.SKU = embalagem.SKU.ToString();
            registro.PrecoDe = embalagem.Pvenda;
            registro.PrecoPor = embalagem.Poferta > 0 ? embalagem.Poferta : embalagem.Pvenda;
            registro.PrecoCusto = embalagem.Custo;
            registro.TrocaGratis = embalagem.Trocagratis > 0;
            registro.PrazoEntrega = Convert.ToInt16(embalagem.Prazoentrega);
            registro.FreteGratis = Convert.ToInt16(embalagem.Fretegratis);
            registro.Peso = Convert.ToInt32(embalagem.Peso * 100);
            registro.Altura = Convert.ToDouble(embalagem.Altura);
            registro.DataAtualizacao = embalagem.DataServidor();
            registro.DataCriacao = registro.DataAtualizacao;
            registro.Garantia = 0;
            if (embalagem.Qtestoque >= 0)
            {
                registro.EstoqueFisico = Convert.ToInt32(embalagem.Qtestoque);
            }
            registro.Comprimento = 0;
            registro.isTelevendas = false;
            registro.Largura = 0;
            if (embalagem.Esc_vinculoweb == "S")
            {
                registro.IdPai = embalagem.MenorCodAuxiliar.ToString();

                registro.ListaAtributos = new IntegracaoAtributoInfo[1];
                IntegracaoAtributoInfo atributo = new IntegracaoAtributoInfo();
                atributo.Nome = "SELECIONE ABAIXO A OPÇÃO DE COMPRA:";
                atributo.Valor = embalagem.Qtunit.ToString() + " Unidade(s)";
                atributo.Tipo = AtributoTipo.Selecao;
                atributo.ExibirAtributo = true;
                atributo.VariacaoPreco = 0;
                registro.ListaAtributos[0] = atributo;
            }
            else
            {
                registro.IdPai = "";
            }


            #region Descontinuado
            //             List<PCEmbalagem> ListaProduto = PCEmbalagem.Listar(string.Format(@"CODFILIAL = '{0}' 
            //                                                                             AND CODPROD = {1} 
            //                                                                             AND CODPROD IN (104651, 104740, 104744, 104678) 
            //                                                                             AND CODAUXILIAR <> {2} 
            //                                                                             AND DESCRICAOWEB IS NOT NULL"
            //                                                                , embalagem.Codfilial
            //                                                                , embalagem.Codprod
            //                                                                , embalagem.SKU));
            //            
            //             if (ListaProduto.Count > 0)
            //             {
            //                 registro.ListaAtributos = new IntegracaoAtributoInfo[ListaProduto.Count];
            //            
            //                 int contador = 0;
            //                 foreach (var item in ListaProduto)
            //                 {
            //            
            //                     IntegracaoAtributoInfo atributo = new IntegracaoAtributoInfo();
            //                     atributo.Nome = "QUERO COMPRAR NO:";
            //                     atributo.Valor = item.Qtunit.ToString() + " Unidade(s)";
            //                     atributo.Tipo = AtributoTipo.Selecao;
            //                     atributo.ExibirAtributo = true;
            //                     atributo.VariacaoPreco = 0;
            //            
            //                     registro.ListaAtributos[contador] = atributo;
            //            
            //                     contador = contador + 1;
            //                 }
            //             }
            //            if ((embalagem.Codprod == 104651) ||
            //                (embalagem.Codprod == 104740) ||
            //                (embalagem.Codprod == 104744) ||
            //                (embalagem.Codprod == 104678))
            //            {
            //                registro.ListaAtributos = new IntegracaoAtributoInfo[1];
            //                IntegracaoAtributoInfo atributo = new IntegracaoAtributoInfo();
            //                atributo.Nome = "QUERO COMPRAR NO:";
            //                atributo.Valor = embalagem.Qtunit.ToString() + " Unidade(s)";
            //                atributo.Tipo = AtributoTipo.Selecao;
            //                atributo.ExibirAtributo = true;
            //                atributo.VariacaoPreco = 0;
            //                registro.ListaAtributos[0] = atributo;
            //            }
            #endregion

            registro.ListaInformacoes = new IntegracaoInformacaoInfo[13];

            for (int i = 1; i < 14; i++)
            { //Outras informações
                IntegracaoInformacaoInfo item = new IntegracaoInformacaoInfo();
                item.TipoInformacaoProdId = i;
                switch (i)
                {
                    case 01://- Informações
                        item.Titulo = "Informações";
                        item.Texto = embalagem.Infoprodweb;
                        break;
                    #region Descontinuado
                    //                    case 02://- Benefícios
                    //                        item.Titulo = "Especificações";
                    //                        item.Texto = embalagem.Aplicacoes;
                    //                        break;
                    //                    case 03://- Especificações
                    //                        item.Titulo = "Especificações";
                    //                        item.Texto = embalagem.Aplicacoes;
                    //                        break;
                    //                    case 04://- Dados Técnicos
                    //                        item.Titulo = "Dados Técnicos";
                    //                        item.Texto = embalagem.Dadostecnicos;
                    //                        break;
                    //                    case 05://- Composição
                    //                        item.Titulo = "Composição";
                    //                        item.Texto = "";
                    //                        break;
                    //                    case 06://- Modo de Usar
                    //                        item.Titulo = "Modo de Usar";
                    //                        item.Texto = "";
                    //                        break;
                    //                    case 07://- Cuidados
                    //                        item.Titulo = "Cuidados";
                    //                        item.Texto = embalagem.Informacoestecnicas;
                    //                        break;
                    //                    case 08://- Itens Inclusos
                    //                        item.Titulo = "Itens Inclusos";
                    //                        item.Texto = "";
                    //                        break;
                    //                    case 09://- Dicas
                    //                        item.Titulo = "Dicas";
                    //                        item.Texto = "";
                    //                        break;
                    //                    case 10://- Vídeo
                    //                        item.Titulo = "Vídeo";
                    //                        item.Texto = "";
                    //                        break;
                    //                    case 11://- Descrição
                    //                        item.Titulo = "Descrição";
                    //                        item.Texto = embalagem.Descricao;
                    //                        break;
                    #endregion
                    case 12://- Valor Referente
                        if ((embalagem.Punitario > 0) && (embalagem.Qtunit >= 1) && (embalagem.Esc_vinculoweb == "S"))
                        {
                            string textoformatado = string.Format("No atacado este produto sai por R$ {0:C}", embalagem.Punitario.ToString());
                            item.Titulo = "Valor Referente";
                            item.Texto = "<span style=\"color:#ff0000;\">" + textoformatado + "</span>";
                        }
                        else
                        {
                            item.Titulo = "";
                            item.Texto = "";
                        }

                        break;
                    #region Descontinuado
                    //                    case 13://- PopUp Referente
                    //                        item.Titulo = "PopUp Referente";
                    //                        item.Texto = "";
                    //                        break;
                    #endregion
                    default:
                        item.Titulo = "";
                        break;
                }
                if (item.Titulo != "")
                {
                    registro.ListaInformacoes[i - 1] = item;
                }
            }

            Biblioteca.Tools.XML.Export(registro, "embalagem");
            switch (Acao)
            {
                case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Incluir:
                    retorno = true; //LojaECommerce.ProdutoInserir(registro);
                    break;
                case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Alterar:
                    retorno = LojaECommerce.ProdutoInserir(registro);
                    break;
                case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Excluir:
                    retorno = true;
                    break;
            }


            if (retorno)
            {
                //Embalagem
                SendCategorizador(embalagem);
                //Estoque
                if (embalagem.Qtestoque >= 0)
                {
                    SendEstoque(embalagem);
                }
                //Tabela de preço
                SendPreco(embalagem);
                //Fornecedor
                SendFornecedor(embalagem);
            }
            else
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits", "SendEmbalagem", string.Format("Produto não enviado: {0} - Ação: {1}", embalagem.SKU.ToString(), Acao.ToString()));
            }
        }

        private void SendCategorizador(VWEmbalagens embalagem)
        {
            try
            {
                if (!string.IsNullOrEmpty(embalagem.Categorizador))
                {
                    IntegracaoProdutoCategoriaInfo registro = new IntegracaoProdutoCategoriaInfo();

                    registro.CategoriaClienteId = embalagem.Categorizador;
                    registro.SKU = embalagem.SKU.ToString();

                    LojaECommerce.CategoriaProdutoInserir(registro);
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits", "SendDepartamentoSecao", string.Format("Produto não enviado: {0}, Categoria: {1} - {2}", embalagem.SKU.ToString(), embalagem.Categorizador.ToString(), ex.ToString()));
            }
        }

        private void SendFornecedor(VWEmbalagens embalagem)
        {
            try
            {
                IntegracaoProdutoFornecedorInfo fornecedor = new IntegracaoProdutoFornecedorInfo();
                fornecedor.Cnpj = embalagem.Cgc;
                fornecedor.Endereco = embalagem.Endereco;
                fornecedor.EnderecoBairro = embalagem.Bairro;
                fornecedor.EnderecoCEP = embalagem.Cep;
                fornecedor.EnderecoCidade = embalagem.Cidade;
                fornecedor.EnderecoComplemento = embalagem.Complemento;
                fornecedor.EnderecoNumero = embalagem.Numero;
                fornecedor.EnderecoUF = embalagem.Estado;
                fornecedor.RazaoSocial = embalagem.Fornecedor;
                fornecedor.SKU = embalagem.SKU.ToString();

                LojaECommerce.FornecedorInserir(fornecedor);
            }
            catch (Exception)
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits", "SendFornecedor", string.Format("Produto não enviado: {0}", embalagem.SKU.ToString()));
            }
        }

        private void SendPreco(VWEmbalagens embalagem)
        {
            try
            {
                IntegracaoProdutoPrecoInfo preco = new IntegracaoProdutoPrecoInfo();
                preco.SKU = embalagem.SKU.ToString();
                preco.PrecoCusto = embalagem.Custo;
                preco.PrecoDe = embalagem.Pvenda;
                preco.PrecoPor = embalagem.Poferta > 0 ? embalagem.Poferta : embalagem.Pvenda;

                LojaECommerce.PrecoAtualizar(preco);
            }
            catch (Exception)
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits", "SendPreco", string.Format("Produto não enviado: {0}", embalagem.SKU.ToString()));
            }
        }

        private void SendEstoque(VWEmbalagens embalagem)
        {
            try
            {
                IntegracaoItemEstoqueInfo estoque = new IntegracaoItemEstoqueInfo();

                estoque.SKU = embalagem.SKU.ToString();
                estoque.PrecoDe = embalagem.Pvenda;
                estoque.PrecoPor = embalagem.Poferta;
                estoque.Quantidade = Convert.ToInt32(embalagem.Qtestoque);
                estoque.QuantidadeReservada = Convert.ToInt32(embalagem.Qtreserv);
                estoque.Disponivel = embalagem.Qtestoque > embalagem.Qtreserv;
                estoque.ValorCusto = embalagem.Custo;

                estoque.Valido = embalagem.Qtestoque > 0; // true;

                LojaECommerce.EstoqueUpdate(estoque);
            }
            catch (Exception)
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits", "SendEstoque", string.Format("Produto não enviado: {0}", embalagem.SKU.ToString()));
            }
        }

        private void SendRamoAtividade(PCAtivi pcativi, Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao Acao)
        {
            try
            {
                IntegracaoCategoriaInfo registro = new IntegracaoCategoriaInfo();

                registro.CategoriaClienteId = pcativi.Codativ.ToString();
                registro.CategoriaClientePaiId = pcativi.Codativprinc.ToString();
                registro.Nome = pcativi.Ramo;

                switch (Acao)
                {
                    case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Incluir:
                        LojaECommerce.ClienteCategoriaInsertUpdate(registro);
                        break;
                    case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Alterar:
                        LojaECommerce.ClienteCategoriaInsertUpdate(registro);
                        break;
                    case Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Excluir:
                        LojaECommerce.ClienteCategoriaDelete(registro);
                        break;
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.FBits", "SendRamoAtividade", string.Format("Ramos de atividade envidado: {0} - {1}", pcativi.Codativ.ToString(), ex));
            }
        }
    }
}

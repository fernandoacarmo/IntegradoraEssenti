using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using Integradora.ERP.Winthor.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Corpem
{
    class Receber : IProcessIntegration
    {
        public Integradora.ECommerce.Corpem.Integracao LojaECommerce { get; set; }

        public Receber()
        {
            LojaECommerce = new ECommerce.Corpem.Integracao();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            string script = "(B.URLWMSCORPEM is NOT NULL) and (NVL(B.USAWMSCORPEM,'N') = 'S')";
            List<VWFiliais> listaFilias = VWFiliais.Listar(script);

            foreach (var item in listaFilias)
            {
                try
                {
                    ReceiveProduto(item.Urlwmscorpem);
                    ReceibeEmbalagem(item.Urlwmscorpem);

                    ReceiveNotaEntrada(item.Urlwmscorpem);

                    ReceivePedidoSaida(item.Urlwmscorpem);
                    ReceivePrePedidoSaida(item.Urlwmscorpem);

                    ReceiveInventario(item.Urlwmscorpem);
                }
                catch
                {
                    continue;
                }
            }
        }

        private void ReceiveInventario(string url)
        {
            Int64 codigoInventarioCorpem = 0;
            Int32 codigoSequencia = 0;
            Decimal codigoInventarioWinthor = 0;
            DateTime datainventario = DateTime.Now;

            try
            {
                var lista = LojaECommerce.ListarInventario(url);
                if (lista.Count() > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            PCEst estoque = PCEst.Listar(string.Format("CODFILIAL = '{0}' AND CODPROD = {1}", item.Codfilial, item.Codproduto.ToString())).FirstOrDefault();
                            using (var transaction = new System.Transactions.CommittableTransaction())
                            {
                                try
                                {
                                    PCInventrot inventario = new PCInventrot();
                                    if (codigoInventarioCorpem != item.Codigo)
                                    {
                                        codigoInventarioWinthor = inventario.Proximo("PCCONSUM", "PROXNUMINVENTROT"); //Obter número do inventário no Winthor
                                        codigoSequencia = 0;
                                        codigoInventarioCorpem = item.Codigo;
                                    }

                                    inventario.Numinvent = codigoInventarioWinthor;
                                    inventario.Codfilial = item.Codfilial;
                                    inventario.Codprod = item.Codproduto;
                                    inventario.Qt1 = item.Quantidade;
                                    inventario.Data = datainventario.Date;
                                    inventario.Datacont1 = datainventario.Date;
                                    inventario.Numseq = codigoSequencia;
                                    inventario.Qtest = estoque.Qtest;
                                    inventario.Qtestger = estoque.Qtestger;
                                    inventario.Qtcont = estoque.Qtest;
                                    inventario.Custo = estoque.Custorep;

                                    if (inventario.Gravar())
                                    {
                                        LojaECommerce.UpdateStatusInventario(item, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.AtualizadoNoWinthor).ToString().PadLeft(2, '0'), url);
                                    }
                                    else
                                    {
                                        LojaECommerce.UpdateStatusInventario(item, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);
                                    }

                                    codigoSequencia = +codigoSequencia;

                                    transaction.Commit();
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    LojaECommerce.UpdateStatusInventario(item, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);

                                    Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                                      , "ReceiveInventario"
                                                      , string.Format("Erro ao gravar inventário: {0}, produto: {1} - Erro: {2}"
                                                                     , item.Codigo.ToString()
                                                                     , item.Codproduto.ToString()
                                                                     , ex.ToString()));
                                    continue;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            LojaECommerce.UpdateStatusInventario(item, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);
                            Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                              , "ReceiveInventario"
                                              , string.Format("Produto não localizado: Filial: {0}, Produto: {1} - Erro: {2}"
                                                             , item.Codigo.ToString()
                                                             , item.Codproduto.ToString()
                                                             , ex.ToString()));
                            continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.Corpem", "ReceiveInventario", "Obtem lista do webservice" + ex.ToString());
            }
        }

        private void ReceibeEmbalagem(string url)
        {
            try
            {
                var lista = LojaECommerce.ListarEmbalagem(url);
                if (lista.Count() > 0)
                {
                    foreach (var item in lista)
                    {
                        using (var transaction = new System.Transactions.CommittableTransaction())
                        {
                            PCEmbalagem registro = null;
                            try
                            {  //Verifica se existe a embalagem
                                registro = PCEmbalagem.Listar(string.Format("CODAUXILIAR = {0} AND CODFILIAL = '{1}'", item.Codbarra.ToString(), item.Codfilial)).FirstOrDefault();
                            }
                            catch
                            {   //Se não existe criar um novo produto
                                registro = new PCEmbalagem();
                                registro.Codauxiliar = item.Codbarra;
                                registro.Codfilial = item.Codfilial;
                                registro.Codprod = item.Codproduto;
                                registro.Descricaoweb = item.Descricao;
                                registro.Dtultalt = DateTime.Now;
                                registro.Excluido = "N";
                            }
                            try
                            {
                                registro.Altura = item.Altura;
                                registro.Comprimento = item.Comprimento;
                                registro.Largura = item.Largura;
                                registro.Pesobruto = item.Pesobruto;
                                registro.Pesoliq = item.Pesoliquido;
                                registro.Volume = item.Volume;
                                registro.Unidade = item.Unidade;
                                registro.Qtunit = item.Qtunitaria;

                                if (registro.Gravar())
                                {
                                    LojaECommerce.UpdateStatusEmbalagem(item, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.AtualizadoNoWinthor).ToString().PadLeft(2, '0'), url);
                                }
                                else
                                {
                                    LojaECommerce.UpdateStatusEmbalagem(item, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);
                                }
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                LojaECommerce.UpdateStatusEmbalagem(item, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);

                                Processo.Notificar("Integradora.Norma.Winthor.Corpem", "ReceiveEmbalagem", "Código de barra: " + item.Codbarra.ToString() + " - Erro: " + ex.ToString());
                                continue;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.Corpem", "ReceiveEmbalagem", "Obtem lista do webservice: " + ex.ToString());
            }
        }

        private void ReceiveProduto(string url)
        {
            try
            {
                var lista = LojaECommerce.ListarProduto(url);
                foreach (var item in lista)
                {
                    using (var transaction = new System.Transactions.CommittableTransaction())
                    {
                        try
                        {
                            PCProdut registro = PCProdut.Listar(string.Format("CODPROD = {0}", item.Codigo.ToString())).FirstOrDefault();

                            registro.Alturam3 = item.Altura;
                            registro.Comprimentom3 = item.Comprimento;
                            registro.Larguram3 = item.Largura;
                            registro.Pesobruto = item.Pesobruto;
                            registro.Pesoliq = item.Pesoliquido;
                            registro.Volume = item.Volume;
                            registro.Unidade = registro.Unidade;

                            if (registro.Gravar())
                            {
                                LojaECommerce.UpdateStatusProduto(item, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.AtualizadoNoWinthor).ToString().PadLeft(2, '0'), url);
                            }
                            else
                            {
                                LojaECommerce.UpdateStatusProduto(item, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            LojaECommerce.UpdateStatusProduto(item, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);

                            Processo.Notificar("Integradora.Norma.Winthor.Corpem", "ReceiveProduto", "Produto: " + item.Codigo.ToString() + " - Erro: " + ex.ToString());
                            continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.Corpem", "ReceiveProduto", "Obtem lista do webservice" + ex.ToString());
            }
        }

        private void ReceiveNotaEntrada(string url)
        {
            try
            {
                var listaESTNotaEntrada = LojaECommerce.ListarNotaEntrada(url);
                if (listaESTNotaEntrada == null)
                {
                    return;
                }
                foreach (var itemESTNotaEntrada in listaESTNotaEntrada)
                {
                    using (var transaction = new System.Transactions.CommittableTransaction())
                    {
                        try
                        {
                            bool registroEncontrado = false;
                            PCNfent notaentrada = null;
                            //Atualizar o pedido
                            try
                            {
                                notaentrada = PCNfent.Listar(string.Format("NUMTRANSENT = {0} AND CODCONT = CODCONTFOR", itemESTNotaEntrada.Numtransacao.ToString())).FirstOrDefault();
                                registroEncontrado = true;
                            }
                            catch
                            {
                                registroEncontrado = false;
                            }
                            if (registroEncontrado)
                            {
                                decimal numeroBonus = notaentrada.Proximo("PCCONSUM", "PROXNUMBONUS");
                                notaentrada.Numbonus = numeroBonus;

                                DateTime dataprocessamento = notaentrada.DataHoraServidor();

                                //Criando o bonus;
                                PCBonusc bonus = new PCBonusc();
                                bonus.Codfilial = notaentrada.Codfilial;
                                bonus.Numbonus = numeroBonus;
                                bonus.Dtdescarga = dataprocessamento.Date;
                                bonus.Databonus = dataprocessamento.Date;
                                bonus.Qtnfs = 1;
                                bonus.Codfuncbonus = Biblioteca.Dictionaries.Settings.Matricula();
                                bonus.Valortotal = notaentrada.Vltotal;
                                bonus.Pesototal = 0;
                                bonus.Numviasbonus = 1;
                                bonus.Hora = dataprocessamento.Hour;
                                bonus.Minuto = dataprocessamento.Minute;
                                bonus.Horamontagem = dataprocessamento.Hour;
                                bonus.Minutomontagem = dataprocessamento.Minute;
                                if (!string.IsNullOrEmpty(notaentrada.Codfornecfrete.ToString()))
                                {
                                    bonus.Codfornectransp = notaentrada.Codfornecfrete;
                                }

                                //Listar itens da nota fiscal
                                bool PodeFecharBonus = true;
                                var listaESTNotaEntradaItem = LojaECommerce.ListarNotaentradaitens(url, itemESTNotaEntrada.Numtransacao);
                                if (listaESTNotaEntradaItem.Count() > 0)
                                {
                                    foreach (var item in listaESTNotaEntradaItem)
                                    {
                                        //Gravar item do pedido
                                        PCMov produto = null;
                                        try
                                        {
                                            produto = PCMov.Listar(string.Format("NUMTRANSENT = {0} AND CODPROD = {1} AND NUMSEQ = {2}"
                                                                 , item.Numtransacao.ToString()
                                                                 , item.Codproduto.ToString()
                                                                 , item.Numseq.ToString())).FirstOrDefault();
                                            registroEncontrado = true;
                                        }
                                        catch
                                        {
                                            Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                                         , "ReceiveNotaEntrada"
                                                         , string.Format("Listando produto da entrada - Numtransent: {0}, produto {1}, sequencia {2} - Não encontrado"
                                                                        , item.Numtransacao.ToString()
                                                                        , item.Codproduto.ToString()
                                                                        , item.Numseq.ToString()));
                                            registroEncontrado = false;
                                        }
                                        if (registroEncontrado)
                                        {
                                            produto.Numbonus = numeroBonus;
                                            notaentrada.Gravar();

                                            //Gravar item do bonus
                                            PCBonusi itemBonus = new PCBonusi();
                                            itemBonus.Numbonus = numeroBonus;
                                            //itemBonus.Numlote = string.IsNullOrEmpty(produto.Numlote.ToString()) ? "0" : produto.Numlote;
                                            itemBonus.Numlote = "0";
                                            itemBonus.Codprod = item.Codproduto;
                                            itemBonus.Qtnf = item.Quantidade;
                                            itemBonus.Qtentrada = item.Qtarmazenada;
                                            itemBonus.Numseq = item.Numseq;

                                            if ((PodeFecharBonus) && (itemBonus.Qtnf != itemBonus.Qtentrada))
                                            {
                                                PodeFecharBonus = false;
                                            }
                                            itemBonus.Gravar();

                                            //Totalizar o peso do bônus 
                                            bonus.Pesototal = bonus.Pesototal + (produto.Qt * produto.Pesoliq);
                                        }
                                    }

                                    if (PodeFecharBonus)
                                    { //Bonus sem divergência fecha direto
                                        bonus.Dtfechamento = dataprocessamento.Date;
                                        bonus.Codfuncfecha = bonus.Codfuncbonus;
                                        bonus.Datafechacompleta = dataprocessamento;
                                        bonus.Dtfechamentototal = dataprocessamento.Date;
                                    }
                                    if (bonus.Gravar())
                                    {
                                        LojaECommerce.UpdateStatusNotaEntrada(itemESTNotaEntrada, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.AtualizadoNoWinthor).ToString().PadLeft(2, '0'), url);
                                    }
                                    else
                                    {
                                        LojaECommerce.UpdateStatusNotaEntrada(itemESTNotaEntrada, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);
                                    }
                                }
                                transaction.Commit();
                            }
                            else
                            {
                                transaction.Rollback();
                                continue;
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            LojaECommerce.UpdateStatusNotaEntrada(itemESTNotaEntrada, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);

                            Processo.Notificar("Integradora.Norma.Winthor.Corpem", "ReceiveNotaEntrada", "Erro no recebimento da entrada - Numtransent: " + itemESTNotaEntrada.Numtransacao.ToString() + " - Erro: " + ex.ToString());
                            continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.Corpem", "ReceiveNotaEntrada", "Obtem lista do webservice" + ex.ToString());
            }
        }

        private void ReceivePedidoSaida(string url)
        {
            try
            {
                var lista = LojaECommerce.ListarPedidosaida(url);
                if (lista == null)
                {
                    return;
                }

                foreach (var pedidoCorpem in lista)
                {
                    PCPedc pedido = PCPedc.Listar("NUMPED = " + pedidoCorpem.Numpedido.ToString()).FirstOrDefault();
                    try
                    {
                        using (var transaction = new System.Transactions.CommittableTransaction())
                        {
                            try
                            {
                                //Atualizando o total do volume

                                pedido.Numvolume = pedidoCorpem.Qtvolumes;
                                pedido.Codfuncconf = Biblioteca.Dictionaries.Settings.Matricula();
                                pedido.Dtfinalcheckout = pedido.DataHoraServidor();
                                pedido.URLrastreamento = pedidoCorpem.URLrastreamento;
                                pedido.Codrastreamento = pedidoCorpem.Codrastreamento;

                                if (!string.IsNullOrEmpty(pedidoCorpem.Cnpj_transportadora))
                                {
                                    try
                                    {
                                        PCFornec transportadora = PCFornec.Listar("REGEXP_REPLACE(CGC, '[^0-9]','') = '" + pedidoCorpem.Cnpj_transportadora + "' AND DTEXCLUSAO IS NULL").FirstOrDefault();
                                        pedido.Codfornecfrete = transportadora.Codfornec;
                                        pedido.Codtransp = transportadora.Codfornec;
                                    }
                                    catch
                                    {
                                        Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                                          , "ReceivePedidoSaida"
                                                          , "Transportadora Não Encontrada para o Pedido: " + pedidoCorpem.Numpedido.ToString() + " - Transportadora: " + pedidoCorpem.Cnpj_transportadora + ", Será considerada a Selecionada no Pedido do Winthor.");
                                    }
                                }
                                pedido.Gravar();

                                var listaProduto = LojaECommerce.ListarPedidosaidaitens(url, pedidoCorpem.Numpedido);
                                if (listaProduto.Count() > 0)
                                {
                                    foreach (var produto in listaProduto)
                                    {

                                        Persistencia ba = new Persistencia(PCPedc.GetStringConnection());
                                        string resultado = "";

                                        resultado = ba.ExecutarProcedure(FuncoesBanco.cortepedido()
                                                            , "vfilial;vcodprod;vdatainicial;vdatafinal;vqtseparada;vpedido;vmatricula;vrotina;vNumSeq;vMotivo;vresultado"
                                                            , pedidoCorpem.Codfilial.ToString() + ";" +
                                                              produto.Codproduto.ToString() + ";" +
                                                              pedido.Data.Value.ToShortDateString() + ";" +
                                                              pedido.Data.Value.ToShortDateString() + ";" +
                                                              produto.Qtatendido.ToString() + ";" +
                                                              pedidoCorpem.Numpedido.ToString() + ";" +
                                                              Biblioteca.Dictionaries.Settings.Matricula().ToString() + ";" +
                                                              Biblioteca.Dictionaries.Settings.Rotina().ToString() + ";" +
                                                              produto.Numseq.ToString() + ";" +
                                                              ";" +
                                                              "EXECUTANDO").ToString();

                                        if (resultado == "False")
                                        {
                                            LojaECommerce.UpdateStatusPedidoSaida(pedidoCorpem, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.AtualizadoNoWinthor).ToString().PadLeft(2, '0'), url);

                                            Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                                              , "ReceivePedidoSaida"
                                                              , string.Format("Não Foi Possivel Fazer Corte do Pedido: {0} do Produto: {1}"
                                                                             , pedidoCorpem.Numpedido.ToString()
                                                                             , produto.Codproduto.ToString()));
                                        }

                                        if (resultado == "True")
                                        {
                                            LojaECommerce.UpdateStatusPedidoSaida(pedidoCorpem, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.AtualizadoNoWinthor).ToString().PadLeft(2, '0'), url);
                                        }
                                        else
                                        {
                                            LojaECommerce.UpdateStatusPedidoSaida(pedidoCorpem, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);
                                            Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                                              , "ReceivePedidoSaida"
                                                              , string.Format("Erro ao efetuar atualização do pedido: {0} - Erro: {1} - Parametros: {2}"
                                                                             , pedidoCorpem.Numpedido.ToString()
                                                                             , resultado
                                                                             , "Filial:" + pedidoCorpem.Codfilial.ToString() + ";" +
                                                                               "Produto:" + produto.Codproduto.ToString() + ";" +
                                                                               "Dt.Inicio:" + pedido.Data.Value.ToShortDateString() + ";" +
                                                                               "Dt.Final:" + pedido.Data.Value.ToShortDateString() + ";" +
                                                                               "Qt.Atendido:" + produto.Qtatendido.ToString() + ";" +
                                                                               "Pedido:" + pedidoCorpem.Numpedido.ToString() + ";" +
                                                                               "Matrícula:" + Biblioteca.Dictionaries.Settings.Matricula().ToString() + ";" +
                                                                               "Rotina:" + Biblioteca.Dictionaries.Settings.Rotina().ToString() + ";" +
                                                                               "Resultado Pkg Corte:" + resultado));
                                        }
                                    }
                                }
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                LojaECommerce.UpdateStatusPedidoSaida(pedidoCorpem, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);

                                Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                                  , "ReceivePedidoSaida"
                                                  , string.Format("Erro ao efetuar corte item do pedido: {0} - Erro: {1}"
                                                                 , pedidoCorpem.Numpedido.ToString()
                                                                 , ex.ToString()));
                                continue;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        LojaECommerce.UpdateStatusPedidoSaida(pedidoCorpem, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);

                        Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                          , "ReceivePedidoSaida"
                                          , "Pedido não encontrado: " + pedidoCorpem.Numpedido.ToString() + " - Erro: " + ex.ToString());
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.Corpem", "ReceivePedidoSaida", "Obtem lista do webservice: " + ex.ToString());
            }
        }

        private void ReceivePrePedidoSaida(string url)
        {
            try
            {
                var lista = LojaECommerce.ListarPrePedidosaida(url);
                if (lista == null)
                {
                    return;
                }

                foreach (var pedidoCorpem in lista)
                {
                    PCPedc pedido = PCPedc.Listar("NUMPED = " + pedidoCorpem.Numpedido.ToString()).FirstOrDefault();
                    try
                    {
                        using (var transaction = new System.Transactions.CommittableTransaction())
                        {
                            try
                            {
                                //Atualizando o total do volume
                                pedido.Numvolume = pedidoCorpem.Qtvolumes;
                                pedido.Codfuncconf = Biblioteca.Dictionaries.Settings.Matricula();
                                pedido.URLrastreamento = pedidoCorpem.URLrastreamento;
                                pedido.Codrastreamento = pedidoCorpem.Codrastreamento;
                                pedido.Dtfinalcheckout = pedido.DataServidor();
                                if (!string.IsNullOrEmpty(pedidoCorpem.Cnpj_transportadora))
                                {
                                    try
                                    {
                                        PCFornec transportadora = PCFornec.Listar("REGEXP_REPLACE(CGC, '[^0-9]','') = '" + pedidoCorpem.Cnpj_transportadora + "'").FirstOrDefault();
                                        pedido.Codfornecfrete = transportadora.Codfornec;
                                    }
                                    catch
                                    {
                                        Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                                          , "ReceivePrePedidoSaida"
                                                          , "Transportadora Não Encontrada para o Pedido: " + pedidoCorpem.Numpedido.ToString() + " - Transportadora: " + pedidoCorpem.Cnpj_transportadora);
                                    }
                                }
                                pedido.Gravar();

                                var listaProduto = LojaECommerce.ListarPedidosaidaitens(url, pedidoCorpem.Numpedido);
                                if (listaProduto.Count() > 0)
                                {
                                    foreach (var produto in listaProduto)
                                    {

                                        Persistencia ba = new Persistencia(PCPedc.GetStringConnection());
                                        string resultado = "";

                                        ba.ExecutarProcedure(FuncoesBanco.cortepedido()
                                                            , "vfilial;vcodprod;vdatainicial;vdatafinal;vqtseparada;vpedido;vmatricula;vrotina;vNumSeq;vMotivo;vresultado"
                                                            , pedidoCorpem.Codfilial + ";" +
                                                              produto.Codproduto.ToString() + ";" +
                                                              pedido.Data + ";" +
                                                              pedido.Data + ";" +
                                                              produto.Qtatendido.ToString() + ";" +
                                                              Biblioteca.Dictionaries.Settings.Matricula().ToString() + ";" +
                                                              Biblioteca.Dictionaries.Settings.Rotina().ToString() + ";" +
                                                              produto.Numseq.ToString() + ";" +
                                                              ";" +
                                                              resultado);

                                        if (resultado == "OK")
                                        {
                                            LojaECommerce.UpdateStatusPrePedidoSaida(pedidoCorpem, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.AtualizadoNoWinthor).ToString().PadLeft(2, '0'), url);

                                        }
                                        else
                                        {
                                            LojaECommerce.UpdateStatusPrePedidoSaida(pedidoCorpem, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);
                                            Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                                              , "ReceivePrePedidoSaida"
                                                              , string.Format("Erro ao efetuar atualização do pedido: {0} - Erro: {1}"
                                                                             , pedidoCorpem.Numpedido.ToString()
                                                                             , resultado));
                                        }
                                    }
                                }
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                LojaECommerce.UpdateStatusPrePedidoSaida(pedidoCorpem, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);

                                Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                                  , "ReceivePrePedidoSaida"
                                                  , string.Format("Erro ao efetuar corte item do pedido: {0} - Erro: {1}"
                                                                 , pedidoCorpem.Numpedido.ToString()
                                                                 , ex.ToString()));
                                continue;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        LojaECommerce.UpdateStatusPrePedidoSaida(pedidoCorpem, ((int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoCorpem.ErroAtualizacaoWinthor).ToString().PadLeft(2, '0'), url);

                        Processo.Notificar("Integradora.Norma.Winthor.Corpem"
                                          , "ReceivePrePedidoSaida"
                                          , "Pedido não encontrado: " + pedidoCorpem.Numpedido.ToString() + " - Erro: " + ex.ToString());
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.Corpem", "ReceivePrePedidoSaida", "Obtem lista do webservice: " + ex.ToString());
            }
        }
    }
}

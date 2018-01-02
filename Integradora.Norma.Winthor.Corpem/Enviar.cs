using Integradora.Biblioteca.Dictionaries;
using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.Corpem.SyncTrafegoCorpem;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Corpem
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.Corpem.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.Corpem.Integracao();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ERP.Winthor.EntityEssenti.Estreplicacao_Corpem.Listar("1=1 ORDER BY DTINCLUSAO");
            foreach (var item in lista)
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        if (Biblioteca.Dictionaries.Settings.Debugando())
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.Corpem", "Send", "Enviando " + item.Tabela);
                        }
                        //Criando a classe e carregando
                        var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, "rowid = '" + item.Id + "'");
                        //Caso tenha encontrado processa
                        if (integracao != null)
                        {
                            string resultado = "";

                            switch (item.Tabela)
                            {
                                case "PCCLIENT":
                                    resultado = SendCliente((PCClient)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCDEPTO":
                                    resultado = SendDepartamento((PCDepto)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCEMBALAGEM":
                                    resultado = SendEmbalagem((PCEmbalagem)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCCLIENTENDENT":
                                    resultado = SendEndereco((PCClientendent)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCFILIAL":
                                    resultado = SendFilial((PCFilial)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCFORNEC":
                                    resultado = SendFornecedor((PCFornec)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCGERENTE":
                                    resultado = SendGerente((PCGerente)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCMARCA":
                                    resultado = SendMarca((PCMarca)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCNCM":
                                    resultado = SendNcm((PCNcm)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCNFENT":
                                    resultado = SendNotaEntrada((PCNfent)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCNFSAID":
                                    resultado = SendNotaSaida((PCNfsaid)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCPEDC":
                                    resultado = SendPedidoSaida((PCPedc)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCPEDCPRE":
                                    resultado = SendPrePedidoSaida((PCPedc)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCPRODUT":
                                    resultado = SendProduto((PCProdut)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCFORMPROD":
                                    resultado = SendKit((PCFormprod)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCATIVI":
                                    resultado = SendRamoAtividade((PCAtivi)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCUSUARI":
                                    resultado = SendRCA((PCUsuari)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCSECAO":
                                    resultado = SendSecao((PCSecao)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                                case "PCSUPERV":
                                    resultado = SendSupervisor((PCSuperv)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    break;
                            }

                            if ((!string.IsNullOrEmpty(resultado)) && (resultado != "OK"))
                            {
                                Processo.Notificar("Integradora.Norma.Winthor.Corpem", "Send", string.Format("Erro ao enviar {0} - Erro: {1}", item.Tabela, resultado));
                            }
                        }

                        Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.Corpem", "Send", ex);
                        continue;
                    }
                }
            }
        }

        private string ObterCNPJ_CPF_Filial(string codigoFilial)
        {
            string retorno = "";
            try
            {
                PCFilial filial = PCFilial.Listar("CODIGO = '" + codigoFilial + "'").Single();
                if (!string.IsNullOrEmpty(filial.Cgc))
                {
                    retorno = filial.Cgc.Replace("/", "").Replace("-", "").Replace(".", "");
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Corpem", "ObterCNPJ_CPF_Filial", "Erro ao buscar CNPJ da filial: " + ex.ToString());
                retorno = "";
            }
            return retorno;
        }
        private string ObterCNPJ_CPF_Forncedor(int codigoFornecedor)
        {
            string retorno = "";
            try
            {
                PCFornec fornecedor = PCFornec.Listar("CODFORNEC = '" + codigoFornecedor.ToString() + "'").Single();
                if (!string.IsNullOrEmpty(fornecedor.Cgc))
                {
                    retorno = fornecedor.Cgc.Replace("/", "").Replace("-", "").Replace(".", "");
                }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Corpem", "ObterCNPJ_CPF_Forncedor", "Erro ao buscar CNPJ do fornecedor/transprotadora: " + ex.ToString());
                retorno = "";
            }
            return retorno;
        }
        private List<VWFiliais> ListarFiliaisCorpem(string codFilial)
        {

            string script = "(URLWMSCORPEM is NOT NULL) and (NVL(B.USAWMSCORPEM,'N') = 'S')";
            if (!string.IsNullOrEmpty(codFilial))
            {
                script = script + string.Format(" AND CODIGO = '{0}'", codFilial);
            }

            List<VWFiliais> listaFilias = VWFiliais.Listar(script);

            return listaFilias;
        }
        private Int32 ObterCidadeIBGE(decimal CodCidade)
        {
            Int32 valor = 0;
            if (CodCidade > 0)
            {
                try
                {
                    PCCidade cidade = PCCidade.Listar("CODCIDADE = " + CodCidade.ToString()).FirstOrDefault();
                    valor = Numbers.ToInt32(cidade.Codibge.ToString());
                }
                catch
                {
                    valor = 0;
                }
            }
            return valor;
        }
        private string ObterObservacao(string Texto1, string Texto2, string Texto3, string Texto4)
        {
            string resultado = "";

            if (!string.IsNullOrEmpty(Texto1))
            {
                resultado = resultado + Texto1 + " ";
            }
            if (!string.IsNullOrEmpty(Texto2))
            {
                resultado = resultado + Texto2 + " ";
            }
            if (!string.IsNullOrEmpty(Texto3))
            {
                resultado = resultado + Texto3 + " ";
            }
            if (!string.IsNullOrEmpty(Texto4))
            {
                resultado = resultado + Texto4;
            }

            return resultado;
        }
        private string SendKit(PCFormprod dados, Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTKit registro = new ESTKit();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codigo = Convert.ToInt32(dados.Codprodacab);
                registro.Codinsumo = Convert.ToInt32(dados.Codprodmp);
                registro.Qtde = Convert.ToInt32(dados.Qtprodmp);

                //Enviar para cada filial que tiver a URL informada
                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateKit(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }

            return retorno;
        }
        private string SendSupervisor(PCSuperv dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTSupervisor registro = new ESTSupervisor();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codigo = Convert.ToInt32(dados.Codsupervisor);
                registro.Codgerente = Convert.ToInt32(dados.Codgerente);
                registro.Nome = dados.Nome;

                //Enviar para cada filial que tiver a URL informada
                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateSupervisor(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }

            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }

            return retorno;
        }
        private string SendRCA(PCUsuari dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTRca registro = new ESTRca();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codigo = Convert.ToInt32(dados.Codusur);
                registro.Codsupervisor = Convert.ToInt32(dados.Codsupervisor);
                registro.Nome = dados.Nome;

                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateRCA(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }

            return retorno;
        }
        private string SendRamoAtividade(PCAtivi dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTRamoatividade registro = new ESTRamoatividade();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codigo = Convert.ToInt32(dados.Codativ);
                registro.Descricao = dados.Ramo;

                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateRamoAtividade(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno =  ex.ToString();
            }
            return retorno;
        }
        private string SendPedidoSaidaItem(PCPedi dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao, string url)
        {
            try
            {
                ESTPedidosaidaitens registro = new ESTPedidosaidaitens();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codproduto = Convert.ToInt32(dados.Codprod);
                registro.Numpedido = Convert.ToInt64(dados.Numped);
                registro.Numseq = Convert.ToInt32(dados.Numseq);
                registro.Qtatendido = Math.Round(dados.Qt, 2);
                registro.Qtcorte = Math.Round(dados.Qtfalta, 2);
                registro.Quantidade = Math.Round(dados.Qt, 2);
                registro.Vlunitario = dados.Pvenda;
                registro.Vltotal = registro.Quantidade * registro.Vlunitario;

                return LojaECommerce.InsertUpdatePedidoSaidaItens(registro, url);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        private string SendPrePedidoSaidaItem(PCPedi dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao, string url)
        {
            try
            {
                ESTPrePedidosaidaitens registro = new ESTPrePedidosaidaitens();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codproduto = Convert.ToInt32(dados.Codprod);
                registro.Numpedido = Convert.ToInt64(dados.Numped);
                registro.Numseq = Convert.ToInt32(dados.Numseq);
                registro.Qtatendido = Math.Round(dados.Qt, 2);
                registro.Qtcorte = Math.Round(dados.Qtfalta, 2);
                registro.Quantidade = Math.Round(dados.Qt, 2);
                registro.Vlunitario = dados.Pvenda;
                registro.Vltotal = registro.Quantidade * registro.Vlunitario;

                return LojaECommerce.InsertUpdatePrePedidoSaidaItens(registro, url);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        private string SendNotaItem(PCMov dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao, string url)
        {
            if (Biblioteca.Dictionaries.Settings.Debugando())
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Corpem", "SendNotaItem", "Enviando PCMOV - Codoper: " + dados.Codoper);
            }
            if (!string.IsNullOrEmpty(dados.Codoper))
            {
                if (dados.Codoper.Substring(0, 1) == "E")
                {
                    return SendNotaEntradaItem(dados, replicacaoAcao, url);
                }
                else
                {
                    return SendNotaSaidaItem(dados, replicacaoAcao, url);
                }
            }
            else
            {
                return string.Format("Item da nota fiscal sem CODST - Numtransitem: {0}", dados.Numtransitem.ToString());
            }
        }
        private string SendNotaSaidaItem(PCMov dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao, string url)
        {
            try
            {
                ESTNotasaidaitens registro = new ESTNotasaidaitens();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codproduto = Convert.ToInt32(dados.Codprod);
                registro.Numtransacao = Convert.ToInt64(dados.Numtransvenda);
                registro.Numseq = Convert.ToInt32(dados.Numseq);
                registro.Qtatendido = Math.Round(dados.Qt, 2);
                registro.Qtcorte = 0;
                registro.Quantidade = Math.Round(dados.Qt, 2);
                registro.Vlunitario = dados.Punit;
                registro.Vltotal = registro.Quantidade * registro.Vlunitario;

                return LojaECommerce.InsertUpdateNotaSaidaItens(registro, url);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        private string SendNotaEntradaItem(PCMov dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao, string url)
        {
            try
            {
                ESTNotaentradaitens registro = new ESTNotaentradaitens();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codproduto = Convert.ToInt32(dados.Codprod);
                registro.Numtransacao = Convert.ToInt64(dados.Numtransent);
                registro.Numseq = Convert.ToInt32(dados.Numseq);
                registro.Qtavaria = dados.Qtavaria ?? 0;
                registro.Quantidade = dados.Qt;
                registro.Vlunitario = dados.Punit;
                registro.Vltotal = registro.Quantidade * registro.Vlunitario;

                return LojaECommerce.InsertUpdateNotaEntradaItens(registro, url);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        private string SendNcm(PCNcm dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTNcm registro = new ESTNcm();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Capitulo = Convert.ToInt16(dados.Capitulo);
                registro.Codigo = dados.Codncmex;
                registro.Descricao = dados.Descricao;
                registro.Ncm = Convert.ToInt32(dados.Codncm);

                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateNCM(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }
            return retorno;
        }
        private string SendMarca(PCMarca dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTMarca registro = new ESTMarca();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codigo = Convert.ToInt32(dados.Codmarca);
                registro.Descricao = dados.Marca;

                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateMarca(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }
            return retorno;
        }
        private string SendGerente(PCGerente dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTGerente registro = new ESTGerente();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codigo = Convert.ToInt32(dados.Codgerente);
                registro.Nome = dados.Nomegerente;

                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateGerente(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }
            return retorno;
        }
        private string SendFilial(PCFilial dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTFilial registro = new ESTFilial();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codigo = dados.Codigo;
                registro.Nome = dados.Razaosocial;
                registro.Tipopessoa = "J";
                registro.Cnpj_Cpf = dados.Cgc;
                registro.Ie = string.IsNullOrEmpty(dados.Ie) ? "ISENTO" : dados.Ie;
                registro.Endereco = dados.Endereco;
                registro.Codibge = 0;
                registro.Cidade = dados.Cidade;
                registro.Estado = dados.Uf;
                registro.Bairro = dados.Bairro;
                registro.Numero = dados.Numero.ToString();
                registro.Cep = dados.Cep;
                registro.Telefone = Numbers.OnlyNumbers( dados.Telefone );
                registro.Celular = "";
                registro.Fax = dados.Fax;
                registro.Email = dados.Email;

                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateFilial(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }

            return retorno;
        }
        private string SendEndereco(PCClientendent dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTEndereco registro = new ESTEndereco();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Bairro = dados.Bairroent;
                registro.Celular = "";
                registro.Cep = dados.Cepent;
                registro.Cidade = dados.Municent;
                registro.Codcliente = Convert.ToInt32(dados.Codcli);
                registro.Codibge = ObterCidadeIBGE(dados.Codcidade);
                registro.Codigo = Convert.ToInt32(dados.Codendentcli);
                registro.Email = "";
                registro.Estado = dados.Estent;
                registro.Fax = "";
                registro.Numero = dados.Numeroent;
                registro.Telefone = "";

                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateEndereco(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }
            return retorno;
        }
        private string SendEmbalagem(PCEmbalagem dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTEmbalagem registro = new ESTEmbalagem();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codbarra = dados.Codauxiliar;
                registro.Codfilial = dados.Codfilial;
                registro.Codproduto = Convert.ToInt32(dados.Codprod);
                registro.Descricao = dados.Embalagem;
                registro.Altura = dados.Altura ?? 0;
                registro.Largura = dados.Largura ?? 0;
                registro.Comprimento = dados.Comprimento ?? 0;
                registro.Embalagem = dados.Embalagem;
                registro.Pesobruto = dados.Pesobruto ?? 0;
                registro.Pesoliquido = dados.Pesoliq ?? 0;
                registro.Qtunitaria = dados.Qtunit ?? 1;
                registro.Unidade = dados.Unidade;
                registro.Volume = dados.Volume ?? 0;

                if (string.IsNullOrEmpty(registro.Descricao))
                {
                    registro.Descricao = string.IsNullOrEmpty(dados.Descricaoecf) ? dados.Descricaoweb : dados.Descricaoecf;
                }

                if (!string.IsNullOrEmpty(registro.Descricao))
                {
                    List<VWFiliais> lista = ListarFiliaisCorpem(registro.Codfilial);
                    if (lista.Count > 0)
                    {
                        foreach (var item in lista)
                        {
                            try
                            {
                                string resultadoWeb = LojaECommerce.InsertUpdateEmbalagem(registro, item.Urlwmscorpem);
                                if (resultadoWeb != "OK")
                                    retorno = retorno + " " + resultadoWeb;
                            }
                            catch (Exception ex)
                            {
                                retorno = retorno + " " + ex.ToString();
                                continue;
                            }
                        }
                    }
                    else
                    {
                        retorno = "Nenhum filial encontrado para ser enviado o registro";
                    }
                }
                else
                {
                    retorno = string.Format("Embalagem: {0} - Produto: {1}: Descrição não preenchida!", dados.Codauxiliar.ToString(), dados.Codprod.ToString());
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }
            return retorno;
        }
        private string SendFornecedor(PCFornec dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTFornecedor registro = new ESTFornecedor();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Bairro = dados.Bairro;
                registro.Celular = dados.Com_Celular;
                registro.Cep = dados.Cep;
                registro.Cidade = dados.Municob;
                registro.Cnpj_Cpf = dados.Cgc;
                registro.Codigo = Convert.ToInt32(dados.Codcli);
                registro.Email = dados.Email;
                registro.Endereco = dados.Ender;
                registro.Estado = dados.Estado;
                registro.Fax = dados.Faxfab;
                registro.Ie = string.IsNullOrEmpty(dados.Ie) ? "ISENTO" : dados.Ie;
                registro.Nome = dados.Fornecedor;
                registro.Numero = dados.Numeroend;
                registro.Telefone = Numbers.OnlyNumbers( dados.Telefoneadm );
                registro.Tipopessoa = string.IsNullOrEmpty(dados.Tipopessoa) ? "F" : dados.Tipopessoa;
                registro.Tipofornecedor = string.IsNullOrEmpty(dados.Tipofornec) ? "R" : dados.Tipofornec;

                //Enviar para cada filial que tiver a URL informada
                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateFornecedor(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }
            return retorno;
        }
        private string SendCliente(PCClient dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTCliente registro = new ESTCliente();
                registro.Bairro = dados.Bairroent;
                registro.Celular = Numbers.OnlyNumbers( dados.Telcelent );
                registro.Cep = dados.Cepent;
                registro.Cidade = dados.Municent;
                registro.Cnpj_Cpf = dados.Cgcent;
                registro.Codigo = Convert.ToInt32(dados.Codcli);
                registro.Email = dados.Email;
                registro.Endereco = dados.Enderent;
                registro.Estado = dados.Estent;
                registro.Fax = dados.Faxcli;
                registro.Ie = string.IsNullOrEmpty(dados.Ieent) ? "ISENTO" : dados.Ieent;
                registro.Nome = dados.Cliente;
                registro.Numero = dados.Numeroent;
                registro.Telefone = Numbers.OnlyNumbers( dados.Telent );
                registro.Tipopessoa = dados.Tipofj;
                if (string.IsNullOrEmpty(registro.Tipopessoa))
                {
                    registro.Tipopessoa = registro.Cnpj_Cpf.Length >= 14 ? "F" : "J";
                }
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');

                //Enviar para cada filial que tiver a URL informada
                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateCliente(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }
            return retorno;
        }
        private string SendSecao(PCSecao dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTSecao registro = new ESTSecao();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codigo = Convert.ToInt32(dados.Codsec);
                registro.Descricao = dados.Descricao;
                registro.Coddepartamento = Convert.ToInt32(dados.Codepto);

                //Enviar para cada filial que tiver a URL informada
                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateSecao(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }
            return retorno;
        }
        private string SendDepartamento(PCDepto dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTDepartamento registro = new ESTDepartamento();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codigo = Convert.ToInt32(dados.Codepto);
                registro.Descricao = dados.Descricao;

                //Enviar para cada filial que tiver a URL informada
                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateDepartamento(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString();
            }
            return retorno;
        }
        private string SendProduto(PCProdut dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {
                ESTProduto registro = new ESTProduto();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codigo = Convert.ToInt32(dados.Codprod);
                registro.Descricao = dados.Descricao;
                registro.Altura = dados.Alturam3 ?? 0;
                registro.Codbarra = dados.Codauxiliar ?? 0;
                registro.CodbarraDUN = dados.Codauxiliar2 ?? 0;
                registro.Codmarca = Convert.ToInt32(dados.Codmarca);
                registro.Codncm = dados.Codncmex;
                registro.Codsecao = Convert.ToInt32(dados.Codsec);
                registro.Comprimento = dados.Comprimentom3 ?? 0;
                registro.Embalagem = dados.Embalagem;
                registro.Largura = dados.Larguram3 ?? 0;
                registro.Ncm = dados.Nbm;
                registro.Pesobruto = dados.Pesobruto ?? 0;
                registro.Pesoliquido = dados.Pesoliq ?? 0;
                registro.Unidade = dados.Unidade;
                registro.Volume = dados.Volume ?? 0;
                registro.Codfabrica = dados.Codfab;

                //Enviar para cada filial que tiver a URL informada
                List<VWFiliais> lista = ListarFiliaisCorpem("");
                if (lista.Count > 0)
                {
                    foreach (var item in lista)
                    {
                        try
                        {
                            string resultadoWeb = LojaECommerce.InsertUpdateProduto(registro, item.Urlwmscorpem);
                            if (resultadoWeb != "OK")
                                retorno = retorno + " " + resultadoWeb;
                        }
                        catch (Exception ex)
                        {
                            retorno = retorno + " " + ex.ToString();
                            continue;
                        }
                    }
                }
                else
                {
                    retorno = "Nenhum filial encontrado para ser enviado o registro";
                }
            }
            catch (Exception ex)
            {
                retorno =  ex.ToString();
            }

            return retorno;
        }
        private string SendNotaEntrada(PCNfent dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string resultado = "";
            string resultadoitem = "";
            try
            {
                ESTNotaentrada registro = new ESTNotaentrada();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Chavenfe = dados.Chavenfe;
                registro.Codfornecedor = Convert.ToInt32(dados.Codfornec);
                registro.Codfilial = string.IsNullOrEmpty(dados.Codfilialnf) ? dados.Codfilial : dados.Codfilialnf;
                registro.Dtfaturamento = dados.Dtemissao;
                registro.Numnota = Convert.ToInt64(dados.Numnota);
                registro.Numpedido = Convert.ToInt64(dados.Numpedprinc);
                registro.Tipofrete = "C";
                registro.Vltotal = dados.Vltotal;
                registro.Numtransacao = Convert.ToInt64(dados.Numtransent);
                registro.Dtemissao = dados.Dtemissao;
                registro.Serie = dados.Serie;
                registro.Codtransportadora = Convert.ToInt32(dados.Codfornecfrete);
                registro.Cnpj_filial = ObterCNPJ_CPF_Filial(registro.Codfilial);
                registro.Observacao = dados.Obs + " " + dados.Obs1 + " " + dados.Obs2;
                registro.URLrastreamento = "";
                registro.Codrastreamento = "";

                if (registro.Codtransportadora > 0)
                {
                    registro.Cnpj_transportadora = ObterCNPJ_CPF_Forncedor(registro.Codtransportadora);
                }

                string emissaoproprio = string.IsNullOrEmpty(dados.Emissaopropria) ? "N" : dados.Emissaopropria;

                switch (dados.Tipodescarga)
                {
                    case "6": registro.Tiponota = "DV";
                        break;
                    case "7": registro.Tiponota = "DV";
                        break;
                    case "8": registro.Tiponota = "DV";
                        break;
                    case "R": registro.Tiponota = "SR";
                        break;
                    case "I": registro.Tiponota = "CI";
                        break;
                    default: registro.Tiponota = "CO";
                        break;
                }

                if (emissaoproprio == "N")
                {
                    try
                    {
                        PCFornec fornecedor = PCFornec.Listar("CODFORNEC = " + dados.Codfornec.ToString()).Single();
                        if (!string.IsNullOrEmpty(fornecedor.Cgc))
                        {
                            registro.Cnpj_Cpf = fornecedor.Cgc.Replace("/", "").Replace("-", "").Replace(".", "");
                            registro.Razaosocial = fornecedor.Fornecedor;
                            registro.Cep = fornecedor.Cep;
                            registro.Estado = fornecedor.Estado;
                            registro.Cidade = fornecedor.Cidade;
                            registro.Bairro = fornecedor.Bairro;
                            registro.Endereco = fornecedor.Ender;
                            registro.Numero = fornecedor.Numeroend;
                            registro.Complemento = fornecedor.Complementoend;
                            registro.Pontoreferencia = "";
                            registro.Codibge = ObterCidadeIBGE(fornecedor.Codcidade);
                            registro.Obsentrega = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        resultado = "Fornecedor não localizado! (PCFORNEC)" + ex.ToString();
                        try
                        {
                            PCClient cliente = PCClient.Listar("CODCLI = " + dados.Codfornecnf.ToString()).Single();
                            if (!string.IsNullOrEmpty(cliente.Cgcent))
                            {
                                registro.Cnpj_Cpf = cliente.Cgcent.Replace("/", "").Replace("-", "").Replace(".", "");
                                registro.Razaosocial = cliente.Cliente;
                                registro.Cep = cliente.Cepent;
                                registro.Estado = cliente.Estent;
                                registro.Cidade = cliente.Municent;
                                registro.Bairro = cliente.Bairroent;
                                registro.Endereco = cliente.Enderent;
                                registro.Numero = cliente.Numeroent;
                                registro.Complemento = cliente.Complementoent;
                                registro.Pontoreferencia = "";
                                registro.Codibge = ObterCidadeIBGE(cliente.Codcidade);
                                registro.Obsentrega = "";
                            }
                        }
                        catch (Exception ex1)
                        {
                            resultado = "Fornecedor (PCCLIENT) não localizado! " + ex1.ToString();
                        }
                    }

                    registro.Cnpj_emitente = registro.Cnpj_filial;
                }
                else
                {
                    try
                    {
                        PCFornec fornecedor = PCFornec.Listar("CODFORNEC = " + dados.Codfornec.ToString()).Single();
                        if (!string.IsNullOrEmpty(fornecedor.Cgc))
                        {
                            registro.Cnpj_Cpf = fornecedor.Cgc.Replace("/", "").Replace("-", "").Replace(".", "");
                            registro.Razaosocial = fornecedor.Fornecedor;
                            registro.Cep = fornecedor.Cep;
                            registro.Estado = fornecedor.Estado;
                            registro.Cidade = fornecedor.Cidade;
                            registro.Bairro = fornecedor.Bairro;
                            registro.Endereco = fornecedor.Ender;
                            registro.Numero = fornecedor.Numeroend;
                            registro.Complemento = fornecedor.Complementoend;
                            registro.Pontoreferencia = "";
                            registro.Codibge = ObterCidadeIBGE(fornecedor.Codcidade);
                            registro.Obsentrega = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        resultado = "Fornecedor não localizado! (PCFORNEC)" + ex.ToString();
                        try
                        {
                            PCClient cliente = PCClient.Listar("CODCLI = " + dados.Codfornecnf.ToString()).Single();
                            if (!string.IsNullOrEmpty(cliente.Cgcent))
                            {
                                registro.Cnpj_Cpf = cliente.Cgcent.Replace("/", "").Replace("-", "").Replace(".", "");
                                registro.Razaosocial = cliente.Cliente;
                                registro.Cep = cliente.Cepent;
                                registro.Estado = cliente.Estent;
                                registro.Cidade = cliente.Municent;
                                registro.Bairro = cliente.Bairroent;
                                registro.Endereco = cliente.Enderent;
                                registro.Numero = cliente.Numeroent;
                                registro.Complemento = cliente.Complementoent;
                                registro.Pontoreferencia = "";
                                registro.Codibge = ObterCidadeIBGE(cliente.Codcidade);
                                registro.Obsentrega = "";
                            }
                        }
                        catch (Exception ex1)
                        {
                            resultado = "Fornecedor (PCCLIENT) não localizado! " + ex1.ToString();
                        }
                    }

                    registro.Cnpj_emitente = registro.Cnpj_filial;
                }

                //Carregando itens da nota fiscal
                List<PCMov> ListaItens = PCMov.Listar("NUMTRANSENT = " + dados.Numtransent.ToString());

                //Senão tiver itens não grava a nota fiscal
                if (ListaItens.Count() > 0)
                {
                    registro.Qtitens = ListaItens.Count();

                    string codigo = ListaItens.FirstOrDefault().Codfilialretira;
                    if (string.IsNullOrEmpty(codigo))
                    {
                        registro.Cnpj_filialemissor = registro.Cnpj_emitente;
                        codigo = registro.Codfilial;
                    }
                    else
                    {
                        registro.Cnpj_filialemissor = ObterCNPJ_CPF_Filial(codigo);
                    }

                    List<VWFiliais> lista = ListarFiliaisCorpem(codigo);
                    if (lista.Count > 0)
                    {
                        foreach (var item in lista)
                        {
                            resultado = LojaECommerce.InsertUpdateNotaEntrada(registro, item.Urlwmscorpem);
                            if (resultado == "OK")
                            {
                                foreach (var itemProduto in ListaItens)
                                {
                                    resultadoitem = SendNotaItem(itemProduto, replicacaoAcao, item.Urlwmscorpem);
                                    if (resultadoitem != "OK")
                                    {
                                        resultado = resultado + resultadoitem;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        resultado = "Nenhum filial encontrado para ser enviado o registro";
                    }                  
                }
                else
                {
                    resultado = "Sem item na nota fiscal para ser enviada!";
                }
                return resultado;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        private string SendNotaSaida(PCNfsaid dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string resultado = "";
            string resultadoitem = "";
            try
            {
                ESTNotasaida registro = new ESTNotasaida();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Chavenfe = dados.Chavenfe;
                registro.Codcliente = Convert.ToInt32(dados.Codcli);
                registro.Codfilial = string.IsNullOrEmpty(dados.Codfilialnf) ? dados.Codfilial : dados.Codfilialnf;
                registro.Dtfaturamento = dados.Dtfat;
                registro.Numnota = Convert.ToInt64(dados.Numnota);
                registro.Numpedido = Convert.ToInt64(dados.Numped);
                registro.Tipofrete = string.IsNullOrEmpty(dados.Tipofrete) ? "C" : dados.Tipofrete;
                registro.Vltotal = dados.Vltotal;
                registro.Numtransacao = Convert.ToInt64(dados.Numtransvenda);
                registro.Dtemissao = dados.Dtsaida;
                registro.Serie = dados.Serie;
                registro.Cnpj_filial = ObterCNPJ_CPF_Filial(registro.Codfilial);
                registro.Codtransportadora = Convert.ToInt32(dados.Codfornecfrete);
                registro.Observacao = dados.Obs + " ";
                registro.URLrastreamento = "";
                registro.Codrastreamento = "";

                if (registro.Codtransportadora > 0)
                {
                    registro.Cnpj_transportadora = ObterCNPJ_CPF_Forncedor(registro.Codtransportadora);
                }

                try
                {
                    PCClient cliente = PCClient.Listar("CODCLI = " + dados.Codcli.ToString()).Single();

                    registro.Cnpj_Cpf = cliente.Cgcent.Replace("/", "").Replace("-", "").Replace(".", "");
                    registro.Razaosocial = cliente.Cliente;
                    registro.Cep = cliente.Cepent;
                    registro.Estado = cliente.Estent;
                    registro.Cidade = cliente.Municent;
                    registro.Bairro = cliente.Bairroent;
                    registro.Endereco = cliente.Enderent;
                    registro.Numero = cliente.Numeroent;
                    registro.Complemento = cliente.Complementoent;
                    registro.Pontoreferencia = cliente.Pontorefer;
                    registro.Codibge = ObterCidadeIBGE(cliente.Codcidade);
                    registro.Obsentrega = "";
                }
                catch (Exception ex)
                {
                    resultado = "Cliente não localizado! " + ex.ToString();
                }

                if (dados.Tipovenda == "DF")
                {
                    registro.Tiponota = "DC";

                }
                else
                {
                    switch (Convert.ToInt32(dados.Condvenda))
                    {
                        case 7: registro.Tiponota = "SR";
                            break;
                        case 10: registro.Tiponota = "TR";
                            break;
                        default: registro.Tiponota = "VD";
                            break;
                    }
                }
                //Carregando os itens
                List<PCMov> ListaItens = PCMov.Listar("NUMTRANSVENDA = " + dados.Numtransvenda.ToString());

                if (ListaItens.Count() > 0)
                {
                    string codigo = ListaItens.FirstOrDefault().Codfilialretira;
                    if (string.IsNullOrEmpty(codigo))
                    {
                        registro.Cnpj_filialemissor = registro.Cnpj_filial;
                        codigo = registro.Codfilial;
                    }
                    else
                    {
                        registro.Cnpj_filialemissor = ObterCNPJ_CPF_Filial(codigo);
                    }

                    registro.Qtitens = ListaItens.Count();

                    List<VWFiliais> lista = ListarFiliaisCorpem(codigo);
                    if (lista.Count > 0)
                    {
                        foreach (var item in lista)
                        {
                            resultado = LojaECommerce.InsertUpdateNotaSaida(registro, item.Urlwmscorpem);
                            if (resultado == "OK")
                            {
                                foreach (var itemProduto in ListaItens)
                                {
                                    resultadoitem = SendNotaItem(itemProduto, replicacaoAcao, item.Urlwmscorpem);
                                    if (resultadoitem != "OK")
                                    {
                                        resultado += resultadoitem;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        resultado = "Nenhum filial encontrado para ser enviado o registro";
                    }
                }

                return resultado;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        private string SendPedidoSaida(PCPedc dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string resultado = "";
            string resultadoitem = "";
            try
            {
                ESTPedidosaida registro = new ESTPedidosaida();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codcliente = Convert.ToInt32(dados.Codcli);
                registro.Codendereco = Convert.ToInt32(dados.Codendent);
                registro.Codfilial = string.IsNullOrEmpty(dados.Codfilialnf) ? dados.Codfilial : dados.Codfilialnf;
                registro.Codprofissional = Convert.ToInt32(dados.Codprofissional);
                registro.Codrca = Convert.ToInt32(dados.Codusur);
                registro.Codsupervisor = Convert.ToInt32(dados.Codsupervisor);
                registro.Numnota = Convert.ToInt64(dados.Numnota);
                registro.Numpedido = Convert.ToInt64(dados.Numped);
                registro.Tipofrete = string.IsNullOrEmpty(dados.Fretedespacho) ? "C" : dados.Fretedespacho;
                registro.Vltotal = dados.Vlatend;
                registro.Cnpj_filial = ObterCNPJ_CPF_Filial(registro.Codfilial);
                registro.Codtransportadora = Convert.ToInt32(dados.Codfornecfrete);
                registro.Observacao = ObterObservacao(dados.Obs, dados.Obs1, dados.Obs2, " ");
                registro.URLrastreamento = dados.URLrastreamento;
                registro.Codrastreamento = dados.Codrastreamento;

                registro.Data = dados.Data;
                registro.Numpedrca = Convert.ToInt64(dados.Numpedrca);

                registro.Dtprevisaoentrega = null;
                
                if (dados.Origemped.ToUpper().Equals("W"))
                {
                    registro.Dtprevisaoentrega = Convert.ToDateTime(Calendars.ToDateTime(dados.Dtentrega).Date.ToShortDateString());
                }

                registro.Dtlibera = dados.Dtlibera == null ? dados.Data : dados.Dtlibera;
                registro.Dtlibera = Convert.ToDateTime(Calendars.ToDateTime(registro.Dtlibera).Date.ToShortDateString());

                if (dados.Codendentcli > 0)
                {
                    try
                    {
                        PCClientendent Endereco = PCClientendent.Listar(string.Format("CODCLI = {0} and CODENDENTCLI = {1}", dados.Codcli, dados.Codendentcli)).Single();
                        if (!string.IsNullOrEmpty(Endereco.Enderent))
                        {
                            registro.Observacao = registro.Observacao + Endereco.Enderent + ", ";
                        }
                        if (!string.IsNullOrEmpty(Endereco.Bairroent))
                        {
                            registro.Observacao = registro.Observacao + Endereco.Bairroent + ", ";
                        }
                        if (!string.IsNullOrEmpty(Endereco.Municent))
                        {
                            registro.Observacao = registro.Observacao + Endereco.Municent + ", ";
                        }
                        if (!string.IsNullOrEmpty(Endereco.Estent))
                        {
                            registro.Observacao = registro.Observacao + Endereco.Estent + ", ";
                        }
                        if (!string.IsNullOrEmpty(Endereco.Complementoent))
                        {
                            registro.Observacao = registro.Observacao + Endereco.Complementoent + ", ";
                        }
                        if (!string.IsNullOrEmpty(Endereco.Cepent))
                        {
                            registro.Observacao = registro.Observacao + Endereco.Cepent;
                        }
                    }
                    catch
                    {
                    }
                }

                registro.Obsentrega = ObterObservacao(dados.Obsentrega1, dados.Obsentrega2, dados.Obsentrega3, dados.Obsentrega4);

                if (registro.Codtransportadora > 0)
                {
                    registro.Cnpj_transportadora = ObterCNPJ_CPF_Forncedor(registro.Codtransportadora);
                }

                try
                {
                    PCClient cliente = PCClient.Listar("CODCLI = " + dados.Codcli.ToString()).Single();

                    registro.Cnpj_Cpf = cliente.Cgcent.Replace("/", "").Replace("-", "").Replace(".", "");
                    registro.Razaosocial = cliente.Cliente;
                    registro.Cep = cliente.Cepent;
                    registro.Estado = cliente.Estent;
                    registro.Cidade = cliente.Municent;
                    registro.Bairro = cliente.Bairroent;
                    registro.Endereco = cliente.Enderent;
                    registro.Numero = cliente.Numeroent;
                    registro.Complemento = cliente.Complementoent;
                    registro.Pontoreferencia = cliente.Pontorefer;
                    registro.Codibge = ObterCidadeIBGE(cliente.Codcidade);
                    registro.Email = string.IsNullOrEmpty(cliente.Email) ? cliente.Emailnfe : cliente.Email;
                    registro.Telefone = string.IsNullOrEmpty(Numbers.OnlyNumbers(cliente.Telent)) ? Numbers.OnlyNumbers(cliente.Telcom) : Numbers.OnlyNumbers(cliente.Telent);

                }
                catch (Exception ex)
                {
                    resultado = "Cliente não localizado! " + ex.ToString();
                }

                //Carregando os itens do pedido
                List<PCPedi> ListaItens = PCPedi.Listar("NUMPED = " + dados.Numped.ToString());
                if (ListaItens.Count() > 0)
                {
                    string codigo = ListaItens.FirstOrDefault().Codfilialretira;
                    if (string.IsNullOrEmpty(codigo))
                    {
                        registro.Cnpj_filialemissor = registro.Cnpj_filial;
                        codigo = registro.Codfilial;
                    }
                    else
                    {
                        registro.Cnpj_filialemissor = ObterCNPJ_CPF_Filial(codigo);
                    }

                    registro.Qtitens = ListaItens.Count();

                    //Enviar para cada filial que tiver a URL informada
                    List<VWFiliais> lista = ListarFiliaisCorpem(codigo);
                    if (lista.Count > 0)
                    {
                        foreach (var item in lista)
                        {
                            resultado = LojaECommerce.InsertUpdatePedidoSaida(registro, item.Urlwmscorpem);
                            if (resultado == "OK")
                            { //Se tiver inserindo o cabeçalho lança os pedidos
                                foreach (var itemProduto in ListaItens)
                                {
                                    resultadoitem = SendPedidoSaidaItem(itemProduto, replicacaoAcao, item.Urlwmscorpem);
                                    if (resultadoitem != "OK")
                                    {
                                        resultado += resultadoitem;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        resultado = "Nenhum filial encontrado para ser enviado o registro";
                    }
                }

                return resultado;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        private string SendPrePedidoSaida(PCPedc dados, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string resultado = "";
            string resultadoitem = "";
            try
            {
                if (Biblioteca.Dictionaries.Settings.Debugando())
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Corpem", "SendPrePedidoSaida", "Enviando pré-pedido, número: " + dados.Numped.ToString());
                }
                ESTPrePedidosaida registro = new ESTPrePedidosaida();
                registro.Semaforo = ((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWMS).ToString().PadLeft(2, '0');
                registro.Codcliente = Convert.ToInt32(dados.Codcli);
                registro.Codendereco = Convert.ToInt32(dados.Codendent);
                registro.Codfilial = string.IsNullOrEmpty(dados.Codfilialnf) ? dados.Codfilial : dados.Codfilialnf;
                registro.Codprofissional = Convert.ToInt32(dados.Codprofissional);
                registro.Codrca = Convert.ToInt32(dados.Codusur);
                registro.Codsupervisor = Convert.ToInt32(dados.Codsupervisor);
                registro.Numnota = Convert.ToInt64(dados.Numnota);
                registro.Numpedido = Convert.ToInt64(dados.Numped);
                registro.Tipofrete = string.IsNullOrEmpty(dados.Fretedespacho) ? "C" : dados.Fretedespacho;
                registro.Vltotal = dados.Vltotal;
                registro.Cnpj_filial = ObterCNPJ_CPF_Filial(registro.Codfilial);
                registro.Codtransportadora = Convert.ToInt32(dados.Codfornecfrete);
                registro.Observacao = dados.Obs + " " + dados.Obs1 + " " + dados.Obs2;
                registro.Obsentrega = dados.Obsentrega1 + " " + dados.Obsentrega2 + " " + dados.Obsentrega3 + " " + dados.Obsentrega4;
                registro.URLrastreamento = dados.URLrastreamento;
                registro.Codrastreamento = dados.Codrastreamento;
                registro.Data = dados.Data;
                registro.Numpedrca = Convert.ToInt64(dados.Numpedrca);
                registro.Dtprevisaoentrega = Convert.ToDateTime(Calendars.ToDateTime(dados.Dtentrega).Date.ToShortDateString());
                registro.Dtlibera = dados.Dtlibera == null ? dados.Data : dados.Dtlibera;
                registro.Dtlibera = Convert.ToDateTime(Calendars.ToDateTime(registro.Dtlibera).Date.ToShortDateString());

                if (registro.Codtransportadora > 0)
                {
                    registro.Cnpj_transportadora = ObterCNPJ_CPF_Forncedor(registro.Codtransportadora);
                }

                try
                {
                    if (Biblioteca.Dictionaries.Settings.Debugando())
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.Corpem", "SendPrePedidoSaida", "Obtendo dados do cliente: " + dados.Codcli.ToString());
                    }

                    PCClient cliente = PCClient.Listar("CODCLI = " + dados.Codcli.ToString()).Single();

                    registro.Cnpj_Cpf = cliente.Cgcent.Replace("/", "").Replace("-", "").Replace(".", "");
                    registro.Razaosocial = cliente.Cliente;
                    registro.Cep = cliente.Cepent;
                    registro.Estado = cliente.Estent;
                    registro.Cidade = cliente.Municent;
                    registro.Bairro = cliente.Bairroent;
                    registro.Endereco = cliente.Enderent;
                    registro.Numero = cliente.Numeroent;
                    registro.Complemento = cliente.Complementoent;
                    registro.Pontoreferencia = cliente.Pontorefer;
                    registro.Codibge = ObterCidadeIBGE(cliente.Codcidade);
                    registro.Email = string.IsNullOrEmpty(cliente.Email) ? cliente.Emailnfe : cliente.Email;
                    registro.Telefone = string.IsNullOrEmpty(Numbers.OnlyNumbers(cliente.Telent)) ? Numbers.OnlyNumbers(cliente.Telcom) : Numbers.OnlyNumbers(cliente.Telent);
                }
                catch (Exception ex)
                {
                    resultado = "Cliente não localizado! " + ex.ToString();
                    return resultado;
                }


                if (Biblioteca.Dictionaries.Settings.Debugando())
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.Corpem", "SendPrePedidoSaida", "Listando itens do pedido");
                }

                //Carregando os itens dos pedidos
                List<PCPedi> ListaItens = PCPedi.Listar("NUMPED = " + dados.Numped.ToString());

                if (ListaItens.Count() > 0)
                {
                    string codigo = ListaItens.FirstOrDefault().Codfilialretira;
                    if (string.IsNullOrEmpty(codigo))
                    {
                        registro.Cnpj_filialemissor = registro.Cnpj_filial;
                        codigo = registro.Codfilial;
                    }
                    else
                    {
                        registro.Cnpj_filialemissor = ObterCNPJ_CPF_Filial(codigo);
                    }

                    registro.Qtitens = ListaItens.Count();

                    if (Biblioteca.Dictionaries.Settings.Debugando())
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.Corpem", "SendPrePedidoSaida", "Enviando para webservice. Gerando XML");
                        Biblioteca.Tools.XML.Export(registro, "PCPEDCPC");
                    }

                    List<VWFiliais> lista = ListarFiliaisCorpem(codigo);
                    if (lista.Count > 0)
                    {
                        foreach (var item in lista)
                        {
                            resultado = LojaECommerce.InsertUpdatePrePedidoSaida(registro, item.Urlwmscorpem);
                            if (resultado == "OK")
                            {
                                if (Biblioteca.Dictionaries.Settings.Debugando())
                                {
                                    Logs.GerarLog("Integradora.Norma.Winthor.Corpem", "SendPrePedidoSaida", "Enviando os itens dos pedidos");
                                }
                                foreach (var itemProduto in ListaItens)
                                {
                                    resultadoitem = SendPrePedidoSaidaItem(itemProduto, replicacaoAcao, item.Urlwmscorpem);
                                    if (resultadoitem != "OK")
                                    {
                                        resultado += resultadoitem;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        resultado = "Nenhum filial encontrado para ser enviado o registro";
                    }
                }

                return resultado;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}

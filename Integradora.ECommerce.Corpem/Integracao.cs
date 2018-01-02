using Integradora.Biblioteca.Dictionaries;
using Integradora.Biblioteca.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Corpem
{
    public class Integracao : Integradora.ECommerce.Lojavirtual
    {
        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.Corpem;
        }
        public override void Initialize()
        {
            CriarCreditoParaCliente = false;
        }
        private string TratarMensagemRetorno(string retorno, string metodo)
        {
            if (retorno != "OK")
            {
                Logs.GerarLog("Integradora.ECommerce.Corpem", metodo, retorno);
            }

            return retorno;
        }

        private SyncTrafegoCorpem.ServiceTrafegoClient WebService(string url)
        {
            //Classe do webservice
            SyncTrafegoCorpem.ServiceTrafegoClient webservice = null;
            try
            {
                //Configuração do serviço
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "BasicHttpBinding_IServiceTrafego";
                binding.MaxReceivedMessageSize = 2147483647;
                binding.MaxBufferSize = 2147483647;
                //Endereço do webservice
                EndpointAddress remoteAddress = new EndpointAddress(url);
                //Carregando o webservice
                webservice = new SyncTrafegoCorpem.ServiceTrafegoClient(binding, remoteAddress);
                //Abrindo a conexão
                webservice.Open();
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.Corpem", "WebService", ex);
            }
            return webservice;
        }

        private string UpdateStatusObjeto(SyncTrafegoCorpem.OracleTable registro, string semaforo, string url)
        {
            string retorno = "";
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    var tabela = registro.GetType().Name.ToString();
                    tabela = tabela.ToUpper();

                    switch (tabela)
                    {
                        case "ESTCLIENTE":
                            retorno = webservice.UpdateStatusCliente((SyncTrafegoCorpem.ESTCliente)registro, semaforo);
                            break;
                        case "ESTDEPARTAMENTO":
                            retorno = webservice.UpdateStatusDepartamento((SyncTrafegoCorpem.ESTDepartamento)registro, semaforo);
                            break;
                        case "ESTEMBALAGEM":
                            retorno = webservice.UpdateStatusEmbalagem((SyncTrafegoCorpem.ESTEmbalagem)registro, semaforo);
                            break;
                        case "ESTENDERECO":
                            retorno = webservice.UpdateStatusEndereco((SyncTrafegoCorpem.ESTEndereco)registro, semaforo);
                            break;
                        case "ESTFILIAL":
                            retorno = webservice.UpdateStatusFilial((SyncTrafegoCorpem.ESTFilial)registro, semaforo);
                            break;
                        case "ESTFORNECEDOR":
                            retorno = webservice.UpdateStatusFornecedor((SyncTrafegoCorpem.ESTFornecedor)registro, semaforo);
                            break;
                        case "ESTGERENTE":
                            retorno = webservice.UpdateStatusGerente((SyncTrafegoCorpem.ESTGerente)registro, semaforo);
                            break;
                        case "ESTMARCA":
                            retorno = webservice.UpdateStatusMarca((SyncTrafegoCorpem.ESTMarca)registro, semaforo);
                            break;
                        case "ESTNCM":
                            retorno = webservice.UpdateStatusNcm((SyncTrafegoCorpem.ESTNcm)registro, semaforo);
                            break;
                        case "ESTNOTAENTRADA":
                            retorno = webservice.UpdateStatusNotaEntrada((SyncTrafegoCorpem.ESTNotaentrada)registro, semaforo);
                            break;
                        case "ESTNOTAENTRADAITENS":
                            retorno = webservice.UpdateStatusNotaEntradaItens((SyncTrafegoCorpem.ESTNotaentradaitens)registro, semaforo);
                            break;
                        case "ESTNOTASAIDA":
                            retorno = webservice.UpdateStatusNotaSaida((SyncTrafegoCorpem.ESTNotasaida)registro, semaforo);
                            break;
                        case "ESTNOTASAIDAITENS":
                            retorno = webservice.UpdateStatusNotaSaidaItens((SyncTrafegoCorpem.ESTNotasaidaitens)registro, semaforo);
                            break;
                        case "ESTPEDIDOSAIDA":
                            retorno = webservice.UpdateStatusPedidoSaida((SyncTrafegoCorpem.ESTPedidosaida)registro, semaforo);
                            break;
                        case "ESTPEDIDOSAIDAITENS":
                            retorno = webservice.UpdateStatusPedidoSaidaItens((SyncTrafegoCorpem.ESTPedidosaidaitens)registro, semaforo);
                            break;
                        case "ESTPREPEDIDOSAIDA":
                            retorno = webservice.UpdateStatusPrePedidoSaida((SyncTrafegoCorpem.ESTPrePedidosaida)registro, semaforo);
                            break;
                        case "ESTPREPEDIDOSAIDAITENS":
                            retorno = webservice.UpdateStatusPrePedidoSaidaItens((SyncTrafegoCorpem.ESTPrePedidosaidaitens)registro, semaforo);
                            break;
                        case "ESTPRODUTO":
                            retorno = webservice.UpdateStatusProduto((SyncTrafegoCorpem.ESTProduto)registro, semaforo);
                            break;
                        case "ESTKIT":
                            retorno = webservice.UpdateStatusKit((SyncTrafegoCorpem.ESTKit)registro, semaforo);
                            break;
                        case "ESTRAMOATIVIDADE":
                            retorno = webservice.UpdateStatusRamoatividade((SyncTrafegoCorpem.ESTRamoatividade)registro, semaforo);
                            break;
                        case "ESTRCA":
                            retorno = webservice.UpdateStatusRca((SyncTrafegoCorpem.ESTRca)registro, semaforo);
                            break;
                        case "ESTSECAO":
                            retorno = webservice.UpdateStatusSecao((SyncTrafegoCorpem.ESTSecao)registro, semaforo);
                            break;
                        case "ESTSUPERVISOR":
                            retorno = webservice.UpdateStatusSupervisor((SyncTrafegoCorpem.ESTSupervisor)registro, semaforo);
                            break;
                        case "ESTINVENTARIO":
                            retorno = webservice.UpdateStatusInventario((SyncTrafegoCorpem.ESTInventario)registro, semaforo);
                            break;

                        default:
                            break;
                    }
                }
                finally
                {
                    webservice.Close();
                }
            }

            return TratarMensagemRetorno(retorno, "UpdateStatusObjeto");
        }

        private string InsertUpdateObjeto(SyncTrafegoCorpem.OracleTable registro, string url)
        {
            string retorno = "";
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    var tabela = registro.GetType().Name.ToString();
                    tabela = tabela.ToUpper();

                    switch (tabela)
                    {
                        case "ESTCLIENTE":
                            retorno = webservice.InsertUpdateCliente((SyncTrafegoCorpem.ESTCliente)registro);
                            break;
                        case "ESTDEPARTAMENTO":
                            retorno = webservice.InsertUpdateDepartamento((SyncTrafegoCorpem.ESTDepartamento)registro);
                            break;
                        case "ESTEMBALAGEM":
                            retorno = webservice.InsertUpdateEmbalagem((SyncTrafegoCorpem.ESTEmbalagem)registro);
                            break;
                        case "ESTENDERECO":
                            retorno = webservice.InsertUpdateEndereco((SyncTrafegoCorpem.ESTEndereco)registro);
                            break;
                        case "ESTFILIAL":
                            retorno = webservice.InsertUpdateFilial((SyncTrafegoCorpem.ESTFilial)registro);
                            break;
                        case "ESTFORNECEDOR":
                            retorno = webservice.InsertUpdateFornecedor((SyncTrafegoCorpem.ESTFornecedor)registro);
                            break;
                        case "ESTGERENTE":
                            retorno = webservice.InsertUpdateGerente((SyncTrafegoCorpem.ESTGerente)registro);
                            break;
                        case "ESTMARCA":
                            retorno = webservice.InsertUpdateMarca((SyncTrafegoCorpem.ESTMarca)registro);
                            break;
                        case "ESTNCM":
                            retorno = webservice.InsertUpdateNcm((SyncTrafegoCorpem.ESTNcm)registro);
                            break;
                        case "ESTNOTAENTRADA":
                            retorno = webservice.InsertUpdateNotaEntrada((SyncTrafegoCorpem.ESTNotaentrada)registro);
                            break;
                        case "ESTNOTAENTRADAITENS":
                            retorno = webservice.InsertUpdateNotaEntradaItens((SyncTrafegoCorpem.ESTNotaentradaitens)registro);
                            break;
                        case "ESTNOTASAIDA":
                            retorno = webservice.InsertUpdateNotaSaida((SyncTrafegoCorpem.ESTNotasaida)registro);
                            break;
                        case "ESTNOTASAIDAITENS":
                            retorno = webservice.InsertUpdateNotaSaidaItens((SyncTrafegoCorpem.ESTNotasaidaitens)registro);
                            break;
                        case "ESTPEDIDOSAIDA":
                            retorno = webservice.InsertUpdatePedidoSaida((SyncTrafegoCorpem.ESTPedidosaida)registro);
                            break;
                        case "ESTPEDIDOSAIDAITENS":
                            retorno = webservice.InsertUpdatePedidoSaidaItens((SyncTrafegoCorpem.ESTPedidosaidaitens)registro);
                            break;
                        case "ESTPREPEDIDOSAIDA":
                            retorno = webservice.InsertUpdatePrePedidoSaida((SyncTrafegoCorpem.ESTPrePedidosaida)registro);
                            break;
                        case "ESTPREPEDIDOSAIDAITENS":
                            retorno = webservice.InsertUpdatePrePedidoSaidaItens((SyncTrafegoCorpem.ESTPrePedidosaidaitens)registro);
                            break;
                        case "ESTPRODUTO":
                            retorno = webservice.InsertUpdateProduto((SyncTrafegoCorpem.ESTProduto)registro);
                            break;
                        case "ESTKIT":
                            retorno = webservice.InsertUpdateKit((SyncTrafegoCorpem.ESTKit)registro);
                            break;
                        case "ESTRAMOATIVIDADE":
                            retorno = webservice.InsertUpdateRamoatividade((SyncTrafegoCorpem.ESTRamoatividade)registro);
                            break;
                        case "ESTRCA":
                            retorno = webservice.InsertUpdateRca((SyncTrafegoCorpem.ESTRca)registro);
                            break;
                        case "ESTSECAO":
                            retorno = webservice.InsertUpdateSecao((SyncTrafegoCorpem.ESTSecao)registro);
                            break;
                        case "ESTSUPERVISOR":
                            retorno = webservice.InsertUpdateSupervisor((SyncTrafegoCorpem.ESTSupervisor)registro);
                            break;
                        case "ESTINVENTARIO":
                            retorno = webservice.InsertUpdateInventario((SyncTrafegoCorpem.ESTInventario)registro);
                            break;
                        default:
                            break;
                    }
                }
                finally
                {
                    webservice.Close();
                }
            }
            else
            {
                retorno = "Não foi possível abrir o webservice!";
            }

            return TratarMensagemRetorno(retorno, "InsertUpdateObjeto");
        }

        private string DeleteObjeto(SyncTrafegoCorpem.OracleTable registro, string url)
        {
            string retorno = "";
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    var tabela = registro.GetType().Name.ToString();
                    tabela = tabela.ToUpper();

                    switch (tabela)
                    {
                        case "ESTCLIENTE":
                            retorno = webservice.DeleteCliente((SyncTrafegoCorpem.ESTCliente)registro);
                            break;
                        case "ESTDEPARTAMENTO":
                            retorno = webservice.DeleteDepartamento((SyncTrafegoCorpem.ESTDepartamento)registro);
                            break;
                        case "ESTEMBALAGEM":
                            retorno = webservice.DeleteEmbalagem((SyncTrafegoCorpem.ESTEmbalagem)registro);
                            break;
                        case "ESTENDERECO":
                            retorno = webservice.DeleteEndereco((SyncTrafegoCorpem.ESTEndereco)registro);
                            break;
                        case "ESTFILIAL":
                            retorno = webservice.DeleteFilial((SyncTrafegoCorpem.ESTFilial)registro);
                            break;
                        case "ESTFORNECEDOR":
                            retorno = webservice.DeleteFornecedor((SyncTrafegoCorpem.ESTFornecedor)registro);
                            break;
                        case "ESTGERENTE":
                            retorno = webservice.DeleteGerente((SyncTrafegoCorpem.ESTGerente)registro);
                            break;
                        case "ESTMARCA":
                            retorno = webservice.DeleteMarca((SyncTrafegoCorpem.ESTMarca)registro);
                            break;
                        case "ESTNCM":
                            retorno = webservice.DeleteNcm((SyncTrafegoCorpem.ESTNcm)registro);
                            break;
                        case "ESTNOTAENTRADA":
                            retorno = webservice.DeleteNotaEntrada((SyncTrafegoCorpem.ESTNotaentrada)registro);
                            break;
                        case "ESTNOTAENTRADAITENS":
                            retorno = webservice.DeleteNotaEntradaItens((SyncTrafegoCorpem.ESTNotaentradaitens)registro);
                            break;
                        case "ESTNOTASAIDA":
                            retorno = webservice.DeleteNotaSaida((SyncTrafegoCorpem.ESTNotasaida)registro);
                            break;
                        case "ESTNOTASAIDAITENS":
                            retorno = webservice.DeleteNotaSaidaItens((SyncTrafegoCorpem.ESTNotasaidaitens)registro);
                            break;
                        case "ESTPEDIDOSAIDA":
                            retorno = webservice.DeletePedidoSaida((SyncTrafegoCorpem.ESTPedidosaida)registro);
                            break;
                        case "ESTPEDIDOSAIDAITENS":
                            retorno = webservice.DeletePedidoSaidaItens((SyncTrafegoCorpem.ESTPedidosaidaitens)registro);
                            break;
                        case "ESTPREPEDIDOSAIDA":
                            retorno = webservice.DeletePrePedidoSaida((SyncTrafegoCorpem.ESTPrePedidosaida)registro);
                            break;
                        case "ESTPREPEDIDOSAIDAITENS":
                            retorno = webservice.DeletePrePedidoSaidaItens((SyncTrafegoCorpem.ESTPrePedidosaidaitens)registro);
                            break;
                        case "ESTPRODUTO":
                            retorno = webservice.DeleteProduto((SyncTrafegoCorpem.ESTProduto)registro);
                            break;
                        case "ESTKIT":
                            retorno = webservice.DeleteKit((SyncTrafegoCorpem.ESTKit)registro);
                            break;
                        case "ESTRAMOATIVIDADE":
                            retorno = webservice.DeleteRamoatividade((SyncTrafegoCorpem.ESTRamoatividade)registro);
                            break;
                        case "ESTRCA":
                            retorno = webservice.DeleteRca((SyncTrafegoCorpem.ESTRca)registro);
                            break;
                        case "ESTSECAO":
                            retorno = webservice.DeleteSecao((SyncTrafegoCorpem.ESTSecao)registro);
                            break;
                        case "ESTSUPERVISOR":
                            retorno = webservice.DeleteSupervisor((SyncTrafegoCorpem.ESTSupervisor)registro);
                            break;
                        case "ESTINVENTARIO":
                            retorno = webservice.DeleteInventario((SyncTrafegoCorpem.ESTInventario)registro);
                            break;
                        default:
                            break;
                    }
                }
                finally
                {
                    webservice.Close();
                }
            }

            return TratarMensagemRetorno(retorno, "InsertUpdateObjeto");
        }

        public string InsertUpdateCliente(SyncTrafegoCorpem.ESTCliente registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateDepartamento(SyncTrafegoCorpem.ESTDepartamento registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateEmbalagem(SyncTrafegoCorpem.ESTEmbalagem registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateEndereco(SyncTrafegoCorpem.ESTEndereco registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateFilial(SyncTrafegoCorpem.ESTFilial registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateFornecedor(SyncTrafegoCorpem.ESTFornecedor registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateGerente(SyncTrafegoCorpem.ESTGerente registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateMarca(SyncTrafegoCorpem.ESTMarca registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateNCM(SyncTrafegoCorpem.ESTNcm registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateNotaEntrada(SyncTrafegoCorpem.ESTNotaentrada registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateNotaEntradaItens(SyncTrafegoCorpem.ESTNotaentradaitens registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateNotaSaida(SyncTrafegoCorpem.ESTNotasaida registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateNotaSaidaItens(SyncTrafegoCorpem.ESTNotasaidaitens registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdatePedidoSaida(SyncTrafegoCorpem.ESTPedidosaida registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdatePedidoSaidaItens(SyncTrafegoCorpem.ESTPedidosaidaitens registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdatePrePedidoSaida(SyncTrafegoCorpem.ESTPrePedidosaida registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdatePrePedidoSaidaItens(SyncTrafegoCorpem.ESTPrePedidosaidaitens registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateProduto(SyncTrafegoCorpem.ESTProduto registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateKit(SyncTrafegoCorpem.ESTKit registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateRamoAtividade(SyncTrafegoCorpem.ESTRamoatividade registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateRCA(SyncTrafegoCorpem.ESTRca registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateSecao(SyncTrafegoCorpem.ESTSecao registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateSupervisor(SyncTrafegoCorpem.ESTSupervisor registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }
        public string InsertUpdateInventario(SyncTrafegoCorpem.ESTInventario registro, string url)
        {
            return InsertUpdateObjeto(registro, url);
        }

        public Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTProduto[] ListarProduto(string url)
        {
            Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTProduto[] lista = null;
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    lista = webservice.ListProduto(((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWinthor).ToString().PadLeft(2,'0'));

                }
                finally
                {
                    webservice.Close();
                }
            }

            return lista;
        }

        public Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTInventario[] ListarInventario(string url)
        {
            Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTInventario[] lista = null;
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    lista = webservice.ListInventario(((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWinthor).ToString().PadLeft(2, '0'));

                }
                finally
                {
                    webservice.Close();
                }
            }

            return lista;
        }

        public Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTEmbalagem[] ListarEmbalagem(string url)
        {
            Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTEmbalagem[] lista = null;
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    lista = webservice.ListEmbalagem(((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWinthor).ToString().PadLeft(2, '0'));

                }
                finally
                {
                    webservice.Close();
                }
            }

            return lista;
        }

        public Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTNotaentrada[] ListarNotaEntrada(string url)
        {
            Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTNotaentrada[] lista = null;
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    lista = webservice.ListNotaEntrada(((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWinthor).ToString().PadLeft(2, '0'));

                }
                finally
                {
                    webservice.Close();
                }
            }

            return lista;
        }

        public Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTNotaentradaitens[] ListarNotaentradaitens(string url, Int64 numeroTransacao)
        {
            Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTNotaentradaitens[] lista = null;
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    lista = webservice.ListNotaEntradaItens(numeroTransacao);

                }
                finally
                {
                    webservice.Close();
                }
            }

            return lista;
        }

        public Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTNotasaida[] ListarNotaSaida(string url)
        {
            Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTNotasaida[] lista = null;
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    lista = webservice.ListNotaSaida(((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWinthor).ToString().PadLeft(2, '0'));

                }
                finally
                {
                    webservice.Close();
                }
            }

            return lista;
        }

        public Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTNotasaidaitens[] ListarNotasaida(string url, Int64 numeroTransacao)
        {
            Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTNotasaidaitens[] lista = null;
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    lista = webservice.ListNotaSaidaItens(numeroTransacao);

                }
                finally
                {
                    webservice.Close();
                }
            }

            return lista;
        }

        public Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTPedidosaida[] ListarPedidosaida(string url)
        {
            Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTPedidosaida[] lista = null;
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    lista = webservice.ListPedidoSaida(((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWinthor).ToString().PadLeft(2, '0'));

                }
                finally
                {
                    webservice.Close();
                }
            }

            return lista;
        }

        public Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTPedidosaidaitens[] ListarPedidosaidaitens(string url, Int64 numeroPedido)
        {
            Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTPedidosaidaitens[] lista = null;
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    lista = webservice.ListPedidoSaidaItens(numeroPedido);

                }
                finally
                {
                    webservice.Close();
                }
            }

            return lista;
        }

        public Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTPrePedidosaida[] ListarPrePedidosaida(string url)
        {
            Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTPrePedidosaida[] lista = null;
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    lista = webservice.ListPrePedidoSaida(((int)Tips.SemaforoPosicaoCorpem.DisponivelParaWinthor).ToString().PadLeft(2, '0'));

                }
                finally
                {
                    webservice.Close();
                }
            }

            return lista;
        }

        public Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTPrePedidosaidaitens[] ListarPrePedidosaidaitens(string url, Int64 numeroPedido)
        {
            Integradora.ECommerce.Corpem.SyncTrafegoCorpem.ESTPrePedidosaidaitens[] lista = null;
            var webservice = WebService(url);
            if (webservice != null)
            {
                try
                {
                    lista = webservice.ListPrePedidoSaidaItens( numeroPedido );

                }
                finally
                {
                    webservice.Close();
                }
            }

            return lista;
        }

        public string UpdateStatusCliente(SyncTrafegoCorpem.ESTCliente registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusDepartamento(SyncTrafegoCorpem.ESTDepartamento registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusEmbalagem(SyncTrafegoCorpem.ESTEmbalagem registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusEndereco(SyncTrafegoCorpem.ESTEndereco registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusFilial(SyncTrafegoCorpem.ESTFilial registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusFornecedor(SyncTrafegoCorpem.ESTFornecedor registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusGerente(SyncTrafegoCorpem.ESTGerente registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusMarca(SyncTrafegoCorpem.ESTMarca registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusNCM(SyncTrafegoCorpem.ESTNcm registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusNotaEntrada(SyncTrafegoCorpem.ESTNotaentrada registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusNotaEntradaItens(SyncTrafegoCorpem.ESTNotaentradaitens registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusNotaSaida(SyncTrafegoCorpem.ESTNotasaida registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusNotaSaidaItens(SyncTrafegoCorpem.ESTNotasaidaitens registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusPedidoSaida(SyncTrafegoCorpem.ESTPedidosaida registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusPedidoSaidaItens(SyncTrafegoCorpem.ESTPedidosaidaitens registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusPrePedidoSaida(SyncTrafegoCorpem.ESTPrePedidosaida registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusPrePedidoSaidaItens(SyncTrafegoCorpem.ESTPrePedidosaidaitens registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusProduto(SyncTrafegoCorpem.ESTProduto registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusKit(SyncTrafegoCorpem.ESTKit registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusRamoAtividade(SyncTrafegoCorpem.ESTRamoatividade registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusRCA(SyncTrafegoCorpem.ESTRca registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusSecao(SyncTrafegoCorpem.ESTSecao registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusSupervisor(SyncTrafegoCorpem.ESTSupervisor registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }
        public string UpdateStatusInventario(SyncTrafegoCorpem.ESTInventario registro, string status, string url)
        {
            return UpdateStatusObjeto(registro, status, url);
        }

        public string DeleteCliente(SyncTrafegoCorpem.ESTCliente registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteDepartamento(SyncTrafegoCorpem.ESTDepartamento registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteEmbalagem(SyncTrafegoCorpem.ESTEmbalagem registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteEndereco(SyncTrafegoCorpem.ESTEndereco registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteFilial(SyncTrafegoCorpem.ESTFilial registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteFornecedor(SyncTrafegoCorpem.ESTFornecedor registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteGerente(SyncTrafegoCorpem.ESTGerente registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteMarca(SyncTrafegoCorpem.ESTMarca registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteNCM(SyncTrafegoCorpem.ESTNcm registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteNotaEntrada(SyncTrafegoCorpem.ESTNotaentrada registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteNotaEntradaItens(SyncTrafegoCorpem.ESTNotaentradaitens registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteNotaSaida(SyncTrafegoCorpem.ESTNotasaida registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteNotaSaidaItens(SyncTrafegoCorpem.ESTNotasaidaitens registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeletePedidoSaida(SyncTrafegoCorpem.ESTPedidosaida registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeletePedidoSaidaItens(SyncTrafegoCorpem.ESTPedidosaidaitens registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeletePrePedidoSaida(SyncTrafegoCorpem.ESTPrePedidosaida registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeletePrePedidoSaidaItens(SyncTrafegoCorpem.ESTPrePedidosaidaitens registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteProduto(SyncTrafegoCorpem.ESTProduto registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteKit(SyncTrafegoCorpem.ESTKit registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteRamoAtividade(SyncTrafegoCorpem.ESTRamoatividade registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteRCA(SyncTrafegoCorpem.ESTRca registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteSecao(SyncTrafegoCorpem.ESTSecao registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteSupervisor(SyncTrafegoCorpem.ESTSupervisor registro, string url)
        {
            return DeleteObjeto(registro, url);
        }
        public string DeleteInventario(SyncTrafegoCorpem.ESTInventario registro, string url)
        {
            return DeleteObjeto(registro, url);
        }

    }
}

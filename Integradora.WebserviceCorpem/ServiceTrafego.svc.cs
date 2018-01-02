using Integradora.Biblioteca.Dictionaries;
using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ERP.Corpem.Entity;
using Integradora.ERP.Corpem.Inherited;
using Integradora.ERP.Corpem.Persistente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Integradora.WebserviceCorpem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTrafego : IServiceTrafego
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        private string InsertUpdateDelete(OracleTable registro, Tips.ReplicacaoAcao acao)
        {
            string retorno;
            try
            {
                Persistencia ba = new Persistencia(ESTNotaentrada.GetStringConnection());

                switch (acao)
                {
                    case Tips.ReplicacaoAcao.Incluir:
                        registro.Dtinclusao = DateTime.Now;
                        registro.Dtalteracao = DateTime.Now;
                        registro.Semaforo = registro.Semaforo;
                        ba.Inserir(registro);
                        break;
                    case Tips.ReplicacaoAcao.Alterar:
                        registro.Dtinclusao = registro.Dtinclusao == null ? DateTime.Now : registro.Dtinclusao;
                        registro.Dtalteracao = DateTime.Now;
                        ba.Alterar(registro);
                        break;
                    case Tips.ReplicacaoAcao.Excluir:
                        ba.Excluir(registro);
                        break;
                    default:
                        break;
                }
                retorno = "OK";
            }
            catch (Exception ex)
            {
                retorno = "Erro ao persistir registro: " + ex;
                Logs.GerarLog("Integradora.WebserviceCorpem", "InsertUpdateDelete", string.Format("Tabela: {0} - Erro: {1}", registro.GetTableName(), ex));
            }

            return retorno;
        }

        #region Clientes
        public List<ESTCliente> ListCliente(string semaforo)
        {
            return ESTCliente.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateCliente(ESTCliente registro)
        {
            return InsertUpdateDeleteCliente(registro, false);
        }

        public string DeleteCliente(ESTCliente registro)
        {
            return InsertUpdateDeleteCliente(registro, true);
        }

        public string UpdateStatusCliente(ESTCliente registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;
            return InsertUpdateDeleteCliente(registro, false);
        }

        private string InsertUpdateDeleteCliente(ESTCliente registro, bool exclusao)
        {
            string retorno = "";
            ESTCliente pesquisa = null;
            try
            {
                pesquisa = ESTCliente.Listar("CODIGO = " + registro.Codigo.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Departamentos
        public List<ESTDepartamento> ListDepartamento(string semaforo)
        {
            return ESTDepartamento.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateDepartamento(ESTDepartamento registro)
        {
            return InsertUpdateDeleteDepartamento(registro, false);
        }

        public string DeleteDepartamento(ESTDepartamento registro)
        {
            return InsertUpdateDeleteDepartamento(registro, true);
        }

        public string UpdateStatusDepartamento(ESTDepartamento registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteDepartamento(registro, false);
        }

        private string InsertUpdateDeleteDepartamento(ESTDepartamento registro, bool exclusao)
        {
            string retorno = "";
            ESTDepartamento pesquisa = null;
            try
            {
                pesquisa = ESTDepartamento.Listar("CODIGO = " + registro.Codigo.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Embalagens
        public List<ESTEmbalagem> ListEmbalagem(string semaforo)
        {
            return ESTEmbalagem.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateEmbalagem(ESTEmbalagem registro)
        {
            return InsertUpdateDeleteEmbalagem(registro, false);
        }

        public string DeleteEmbalagem(ESTEmbalagem registro)
        {
            return InsertUpdateDeleteEmbalagem(registro, true);
        }

        public string UpdateStatusEmbalagem(ESTEmbalagem registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteEmbalagem(registro, false);
        }

        private string InsertUpdateDeleteEmbalagem(ESTEmbalagem registro, bool exclusao)
        {
            string retorno = "";
            ESTEmbalagem pesquisa = null;
            try
            {
                pesquisa = ESTEmbalagem.Listar(string.Format("CODFILIAL = '{0}' AND CODBARRA = {1}", registro.Codfilial, registro.Codbarra.ToString())).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Enderecos
        public List<ESTEndereco> ListEndereco(string semaforo)
        {
            return ESTEndereco.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateEndereco(ESTEndereco registro)
        {
            return InsertUpdateDeleteEndereco(registro, false);
        }

        public string DeleteEndereco(ESTEndereco registro)
        {
            return InsertUpdateDeleteEndereco(registro, true);
        }

        public string UpdateStatusEndereco(ESTEndereco registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteEndereco(registro, false);
        }

        private string InsertUpdateDeleteEndereco(ESTEndereco registro, bool exclusao)
        {
            string retorno = "";
            ESTEndereco pesquisa = null;
            try
            {
                pesquisa = ESTEndereco.Listar("CODIGO = " + registro.Codigo.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Filiais
        public List<ESTFilial> ListFilial(string semaforo)
        {
            return ESTFilial.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateFilial(ESTFilial registro)
        {
            return InsertUpdateDeleteFilial(registro, false);
        }

        public string DeleteFilial(ESTFilial registro)
        {
            return InsertUpdateDeleteFilial(registro, true);
        }

        public string UpdateStatusFilial(ESTFilial registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteFilial(registro, false);
        }

        private string InsertUpdateDeleteFilial(ESTFilial registro, bool exclusao)
        {
            string retorno = "";
            ESTFilial pesquisa = null;
            try
            {
                pesquisa = ESTFilial.Listar(string.Format("CODIGO = '{0}'", registro.Codigo)).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Fornecedores
        public List<ESTFornecedor> ListFornecedor(string semaforo)
        {
            return ESTFornecedor.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateFornecedor(ESTFornecedor registro)
        {
            return InsertUpdateDeleteFornecedor(registro, false);
        }

        public string DeleteFornecedor(ESTFornecedor registro)
        {
            return InsertUpdateDeleteFornecedor(registro, true);
        }

        public string UpdateStatusFornecedor(ESTFornecedor registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteFornecedor(registro, false);
        }

        private string InsertUpdateDeleteFornecedor(ESTFornecedor registro, bool exclusao)
        {
            string retorno = "";
            ESTFornecedor pesquisa = null;
            try
            {
                pesquisa = ESTFornecedor.Listar("CODIGO = " + registro.Codigo.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Gerentes
        public List<ESTGerente> ListGerente(string semaforo)
        {
            return ESTGerente.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateGerente(ESTGerente registro)
        {
            return InsertUpdateDeleteGerente(registro, false);
        }

        public string DeleteGerente(ESTGerente registro)
        {
            return InsertUpdateDeleteGerente(registro, true);
        }

        public string UpdateStatusGerente(ESTGerente registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteGerente(registro, false);
        }

        private string InsertUpdateDeleteGerente(ESTGerente registro, bool exclusao)
        {
            string retorno = "";
            ESTGerente pesquisa = null;
            try
            {
                pesquisa = ESTGerente.Listar("CODIGO = " + registro.Codigo.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Marcas
        public List<ESTMarca> ListMarca(string semaforo)
        {
            return ESTMarca.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateMarca(ESTMarca registro)
        {
            return InsertUpdateDeleteMarca(registro, false);
        }

        public string DeleteMarca(ESTMarca registro)
        {
            return InsertUpdateDeleteMarca(registro, true);
        }

        public string UpdateStatusMarca(ESTMarca registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteMarca(registro, false);
        }

        private string InsertUpdateDeleteMarca(ESTMarca registro, bool exclusao)
        {
            string retorno = "";
            ESTMarca pesquisa = null;
            try
            {
                pesquisa = ESTMarca.Listar("CODIGO = " + registro.Codigo.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region NCMs
        public List<ESTNcm> ListNcm(string semaforo)
        {
            return ESTNcm.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateNcm(ESTNcm registro)
        {
            return InsertUpdateDeleteNcm(registro, false);
        }

        public string DeleteNcm(ESTNcm registro)
        {
            return InsertUpdateDeleteNcm(registro, true);
        }

        public string UpdateStatusNcm(ESTNcm registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteNcm(registro, false);
        }

        private string InsertUpdateDeleteNcm(ESTNcm registro, bool exclusao)
        {
            string retorno = "";
            ESTNcm pesquisa = null;
            try
            {
                pesquisa = ESTNcm.Listar(string.Format( "CODIGO = '{0}'", registro.Codigo)).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Inventario
        public List<ESTInventario> ListInventario(string semaforo)
        {
            return ESTInventario.Listar(string.Format("SEMAFORO = '{0}' ORDER BY CODIGO", semaforo));
        }
        public string InsertUpdateInventario(ESTInventario registro)
        {
            return InsertUpdateDeleteInventario(registro, false);
        }

        public string DeleteInventario(ESTInventario registro)
        {
            return InsertUpdateDeleteInventario(registro, true);
        }

        public string UpdateStatusInventario(ESTInventario registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteInventario(registro, false);
        }

        private string InsertUpdateDeleteInventario(ESTInventario registro, bool exclusao)
        {
            string retorno = "";
            ESTInventario pesquisa = null;
            try
            {
                pesquisa = ESTInventario.Listar(string.Format("CODIGO = '{0}'", registro.Codigo)).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Notaentradas
        public List<ESTNotaentrada> ListNotaEntrada(string semaforo)
        {
            return ESTNotaentrada.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateNotaEntrada(ESTNotaentrada registro)
        {
            return InsertUpdateDeleteNotaentrada(registro, false);
        }

        public string DeleteNotaEntrada(ESTNotaentrada registro)
        {
            return InsertUpdateDeleteNotaentrada(registro, true);
        }

        public string UpdateStatusNotaEntrada(ESTNotaentrada registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteNotaentrada(registro, false);
        }

        private string InsertUpdateDeleteNotaentrada(ESTNotaentrada registro, bool exclusao)
        {
            string retorno = "";
            ESTNotaentrada pesquisa = null;
            try
            {
                pesquisa = ESTNotaentrada.Listar("NUMTRANSACAO = " + registro.Numtransacao.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Notaentradasitens
        public List<ESTNotaentradaitens> ListNotaEntradaItens(Int64 numTransacao)
        {
            return ESTNotaentradaitens.Listar(string.Format("NUMTRANSACAO = {0}", numTransacao.ToString()));
        }
        public string InsertUpdateNotaEntradaItens(ESTNotaentradaitens registro)
        {
            return InsertUpdateDeleteNotaentradaitens(registro, false);
        }

        public string DeleteNotaEntradaItens(ESTNotaentradaitens registro)
        {
            return InsertUpdateDeleteNotaentradaitens(registro, true);
        }

        public string UpdateStatusNotaEntradaItens(ESTNotaentradaitens registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteNotaentradaitens(registro, false);
        }

        private string InsertUpdateDeleteNotaentradaitens(ESTNotaentradaitens registro, bool exclusao)
        {
            string retorno = "";
            ESTNotaentradaitens pesquisa = null;
            try
            {
                pesquisa = ESTNotaentradaitens.Listar(string.Format("NUMTRANSACAO = {0} AND CODPRODUTO = {1} AND NUMSEQ = {2}"
                                                                   , registro.Numtransacao.ToString()
                                                                   , registro.Codproduto.ToString()
                                                                   , registro.Numseq.ToString())).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Notasaidas
        public List<ESTNotasaida> ListNotaSaida(string semaforo)
        {
            return ESTNotasaida.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateNotaSaida(ESTNotasaida registro)
        {
            return InsertUpdateDeleteNotasaida(registro, false);
        }

        public string DeleteNotaSaida(ESTNotasaida registro)
        {
            return InsertUpdateDeleteNotasaida(registro, true);
        }

        public string UpdateStatusNotaSaida(ESTNotasaida registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteNotasaida(registro, false);
        }

        private string InsertUpdateDeleteNotasaida(ESTNotasaida registro, bool exclusao)
        {
            string retorno = "";
            ESTNotasaida pesquisa = null;
            try
            {
                pesquisa = ESTNotasaida.Listar("NUMTRANSACAO = " + registro.Numtransacao.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Notasaidasitens
        public List<ESTNotasaidaitens> ListNotaSaidaItens(Int64 numTransacao)
        {
            return ESTNotasaidaitens.Listar(string.Format("NUMTRANSACAO = {0}", numTransacao.ToString()));
        }
        public string InsertUpdateNotaSaidaItens(ESTNotasaidaitens registro)
        {
            return InsertUpdateDeleteNotasaidaitens(registro, false);
        }

        public string DeleteNotaSaidaItens(ESTNotasaidaitens registro)
        {
            return InsertUpdateDeleteNotasaidaitens(registro, true);
        }

        public string UpdateStatusNotaSaidaItens(ESTNotasaidaitens registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteNotasaidaitens(registro, false);
        }

        private string InsertUpdateDeleteNotasaidaitens(ESTNotasaidaitens registro, bool exclusao)
        {
            string retorno = "";
            ESTNotasaidaitens pesquisa = null;
            try
            {
                pesquisa = ESTNotasaidaitens.Listar(string.Format("NUMTRANSACAO = {0} AND CODPRODUTO = {1} AND NUMSEQ = {2}"
                                                                   , registro.Numtransacao.ToString()
                                                                   , registro.Codproduto.ToString()
                                                                   , registro.Numseq.ToString())).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Pedidosaidas
        public List<ESTPedidosaida> ListPedidoSaida(string semaforo)
        {
            return ESTPedidosaida.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdatePedidoSaida(ESTPedidosaida registro)
        {
            return InsertUpdateDeletePedidosaida(registro, false);
        }

        public string DeletePedidoSaida(ESTPedidosaida registro)
        {
            return InsertUpdateDeletePedidosaida(registro, true);
        }

        public string UpdateStatusPedidoSaida(ESTPedidosaida registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = registro.DataHoraServidor();

            return InsertUpdateDeletePedidosaida(registro, false);
        }

        private string InsertUpdateDeletePedidosaida(ESTPedidosaida registro, bool exclusao)
        {
            string retorno = "";
            ESTPedidosaida pesquisa = null;
            try
            {
                pesquisa = ESTPedidosaida.Listar("NUMPEDIDO = " + registro.Numpedido.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Pedidosaidasitens
        public List<ESTPedidosaidaitens> ListPedidoSaidaItens(Int64 numPedido)
        {
            return ESTPedidosaidaitens.Listar(string.Format("NUMPEDIDO = {0}", numPedido.ToString()));
        }
        public string InsertUpdatePedidoSaidaItens(ESTPedidosaidaitens registro)
        {
            return InsertUpdateDeletePedidosaidaitens(registro, false);
        }

        public string DeletePedidoSaidaItens(ESTPedidosaidaitens registro)
        {
            return InsertUpdateDeletePedidosaidaitens(registro, true);
        }

        public string UpdateStatusPedidoSaidaItens(ESTPedidosaidaitens registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeletePedidosaidaitens(registro, false);
        }

        private string InsertUpdateDeletePedidosaidaitens(ESTPedidosaidaitens registro, bool exclusao)
        {
            string retorno = "";
            ESTPedidosaidaitens pesquisa = null;
            try
            {
                pesquisa = ESTPedidosaidaitens.Listar(string.Format("NUMPEDIDO = {0} AND CODPRODUTO = {1} AND NUMSEQ = {2}"
                                                                   , registro.Numpedido.ToString()
                                                                   , registro.Codproduto.ToString()
                                                                   , registro.Numseq.ToString())).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region PrePedidosaidas
        public List<ESTPrePedidosaida> ListPrePedidoSaida(string semaforo)
        {
            return ESTPrePedidosaida.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdatePrePedidoSaida(ESTPrePedidosaida registro)
        {
            return InsertUpdateDeletePrePedidosaida(registro, false);
        }

        public string DeletePrePedidoSaida(ESTPrePedidosaida registro)
        {
            return InsertUpdateDeletePrePedidosaida(registro, true);
        }

        public string UpdateStatusPrePedidoSaida(ESTPrePedidosaida registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeletePrePedidosaida(registro, false);
        }

        private string InsertUpdateDeletePrePedidosaida(ESTPrePedidosaida registro, bool exclusao)
        {
            string retorno = "";
            ESTPrePedidosaida pesquisa = null;
            try
            {
                pesquisa = ESTPrePedidosaida.Listar("NUMPEDIDO = " + registro.Numpedido.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Pedidosaidasitens
        public List<ESTPrePedidosaidaitens> ListPrePedidoSaidaItens(Int64 numPedido)
        {
            return ESTPrePedidosaidaitens.Listar(string.Format("NUMPEDIDO = {0}", numPedido.ToString()));
        }
        public string InsertUpdatePrePedidoSaidaItens(ESTPrePedidosaidaitens registro)
        {
            return InsertUpdateDeletePrePedidosaidaitens(registro, false);
        }

        public string DeletePrePedidoSaidaItens(ESTPrePedidosaidaitens registro)
        {
            return InsertUpdateDeletePrePedidosaidaitens(registro, true);
        }

        public string UpdateStatusPrePedidoSaidaItens(ESTPrePedidosaidaitens registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeletePrePedidosaidaitens(registro, false);
        }

        private string InsertUpdateDeletePrePedidosaidaitens(ESTPrePedidosaidaitens registro, bool exclusao)
        {
            string retorno = "";
            ESTPrePedidosaidaitens pesquisa = null;
            try
            {
                pesquisa = ESTPrePedidosaidaitens.Listar(string.Format("NUMPEDIDO = {0} AND CODPRODUTO = {1} AND NUMSEQ = {2}"
                                                                   , registro.Numpedido.ToString()
                                                                   , registro.Codproduto.ToString()
                                                                   , registro.Numseq.ToString())).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Produtos
        public List<ESTProduto> ListProduto(string semaforo)
        {
            return ESTProduto.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateProduto(ESTProduto registro)
        {
            return InsertUpdateDeleteProduto(registro, false);
        }

        public string DeleteProduto(ESTProduto registro)
        {
            return InsertUpdateDeleteProduto(registro, true);
        }

        public string UpdateStatusProduto(ESTProduto registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteProduto(registro, false);
        }

        private string InsertUpdateDeleteProduto(ESTProduto registro, bool exclusao)
        {
            string retorno = "";
            ESTProduto pesquisa = null;
            try
            {
                pesquisa = ESTProduto.Listar("CODIGO = " + registro.Codigo.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Kits
        public List<ESTKit> ListKit(string semaforo)
        {
            return ESTKit.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateKit(ESTKit registro)
        {
            return InsertUpdateDeleteKit(registro, false);
        }

        public string DeleteKit(ESTKit registro)
        {
            return InsertUpdateDeleteKit(registro, true);
        }

        public string UpdateStatusKit(ESTKit registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteKit(registro, false);
        }

        private string InsertUpdateDeleteKit(ESTKit registro, bool exclusao)
        {
            string retorno = "";
            ESTKit pesquisa = null;
            try
            {
                pesquisa = ESTKit.Listar(string.Format("CODIGO = {0} AND CODINSUMO = {1}",registro.Codigo.ToString(), registro.Codinsumo.ToString())).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Ramo de atividade
        public List<ESTRamoatividade> ListRamoatividade(string semaforo)
        {
            return ESTRamoatividade.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateRamoatividade(ESTRamoatividade registro)
        {
            return InsertUpdateDeleteRamoatividade(registro, false);
        }

        public string DeleteRamoatividade(ESTRamoatividade registro)
        {
            return InsertUpdateDeleteRamoatividade(registro, true);
        }

        public string UpdateStatusRamoatividade(ESTRamoatividade registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteRamoatividade(registro, false);
        }

        private string InsertUpdateDeleteRamoatividade(ESTRamoatividade registro, bool exclusao)
        {
            string retorno = "";
            ESTRamoatividade pesquisa = null;
            try
            {
                pesquisa = ESTRamoatividade.Listar("CODIGO = " + registro.Codigo.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region RCA
        public List<ESTRca> ListRca(string semaforo)
        {
            return ESTRca.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateRca(ESTRca registro)
        {
            return InsertUpdateDeleteRca(registro, false);
        }

        public string DeleteRca(ESTRca registro)
        {
            return InsertUpdateDeleteRca(registro, true);
        }

        public string UpdateStatusRca(ESTRca registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteRca(registro, false);
        }

        private string InsertUpdateDeleteRca(ESTRca registro, bool exclusao)
        {
            string retorno = "";
            ESTRca pesquisa = null;
            try
            {
                pesquisa = ESTRca.Listar("CODIGO = " + registro.Codigo.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Secoes
        public List<ESTSecao> ListSecao(string semaforo)
        {
            return ESTSecao.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateSecao(ESTSecao registro)
        {
            return InsertUpdateDeleteSecao(registro, false);
        }

        public string DeleteSecao(ESTSecao registro)
        {
            return InsertUpdateDeleteSecao(registro, true);
        }

        public string UpdateStatusSecao(ESTSecao registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteSecao(registro, false);
        }

        private string InsertUpdateDeleteSecao(ESTSecao registro, bool exclusao)
        {
            string retorno = "";
            ESTSecao pesquisa = null;
            try
            {
                pesquisa = ESTSecao.Listar(string.Format("CODIGO = {0}", registro.Codigo.ToString())).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

        #region Supervisor
        public List<ESTSupervisor> ListSupervisor(string semaforo)
        {
            return ESTSupervisor.Listar(string.Format("SEMAFORO = '{0}' AND ROWNUM < 100", semaforo));
        }
        public string InsertUpdateSupervisor(ESTSupervisor registro)
        {
            return InsertUpdateDeleteSupervisor(registro, false);
        }

        public string DeleteSupervisor(ESTSupervisor registro)
        {
            return InsertUpdateDeleteSupervisor(registro, true);
        }

        public string UpdateStatusSupervisor(ESTSupervisor registro, string semaforo)
        {
            registro.Semaforo = semaforo;
            registro.Dtalteracao = DateTime.Now;

            return InsertUpdateDeleteSupervisor(registro, false);
        }

        private string InsertUpdateDeleteSupervisor(ESTSupervisor registro, bool exclusao)
        {
            string retorno = "";
            ESTSupervisor pesquisa = null;
            try
            {
                pesquisa = ESTSupervisor.Listar("CODIGO = " + registro.Codigo.ToString()).Single();
                registro.OID = pesquisa.OID;
                if (exclusao)
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Excluir);
                }
                else
                {
                    retorno = InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Alterar);
                }
            }
            catch (Exception ex)
            {
                retorno = ex.ToString().Contains("Sequence contains no elements") ? "" : ex.ToString();
                if (pesquisa == null)
                {
                    retorno = retorno + InsertUpdateDelete(registro, Tips.ReplicacaoAcao.Incluir);
                }
            }
            return retorno;
        }
        #endregion

    }
}

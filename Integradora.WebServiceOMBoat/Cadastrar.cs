using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Integradora.ECommerce.Ajuri.Comum;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.Biblioteca.Tools;
using Integradora.Biblioteca.Dictionaries;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.Database.Oracle;
using System.Data.OracleClient;
using System.Data;
using Integradora.ERP.Winthor.View;
using Integradora.ECommerce.Ajuri.Retornos;

namespace Integradora.WebServiceOMBoat
{
    public class Cadastrar
    {
        #region Funções Auxiliares

        public static string servicoWMSOMBoat_TransferirPrograma()
        {
            return "ESG_WMS_OMBOAT.TRANSFERIRPROGRAMA";
        }
        public static string servicoWMSOMBoat_AjustarSaldo()
        {
            return "ESG_WMS_OMBOAT.AJUSTARSALDO";
        }
        public static string servicoWMSOMBoat_BloquearEstoquePorLote()
        {
            return "ESG_WMS_OMBOAT.BLOQUEARESTOQUE";
        }
        public static string servicoWMSOMBoat_DesbloquearEstoquePorLote()
        {
            return "ESG_WMS_OMBOAT.DESBLOQUEARESTOQUE";
        }
        public static string servicoWMSOMBoat_CancelarPedidoVenda()
        {
            return "ESG_WMS_OMBOAT.CANCELARPEDIDOVENDA";
        }
        public static string servicoWMSOMBoat_CancelarNotaEntrada()
        {
            return "ESG_WMS_OMBOAT.CANCELARNOTAENTRADA";
        }
        public static string servicoWMSOMBoat_SaldoProduto()
        {
            return "ESG_WMS_OMBOAT.SALDOPRODUTO";
        }
        public static string servicoWMSOMBoat_TrocarDadosLote()
        {
            return "ESG_WMS_OMBOAT.TROCARDADOSLOTE";
        }
        public static decimal ExecutarEstoqueLivre()
        {
            return 0;
        }
        public static string ExecutarCancelamentoDocumento(bool NotaEntrada
                                                          , decimal numDocumento
                                                          , string motivo)
        {
            try
            {
                string resultado = "";
                Oracle oracle = new Oracle(PCPedc.GetStringConnection());

                OracleConnection objConn = oracle.GetConnection();
                OracleCommand objCmd = objConn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                if (NotaEntrada)
                {
                    objCmd.CommandText = servicoWMSOMBoat_CancelarNotaEntrada();
                    objCmd.Parameters.Add("pnNUMNOTA", OracleType.Double).Value = numDocumento;
                    objCmd.Parameters.Add("psMOTIVO", OracleType.VarChar, 200).Value = motivo;
                }
                else
                {
                    objCmd.CommandText = servicoWMSOMBoat_CancelarPedidoVenda();
                    objCmd.Parameters.Add("pnNUMPED", OracleType.Double).Value = numDocumento;
                    objCmd.Parameters.Add("psMOTIVO", OracleType.VarChar, 200).Value = motivo;
                }

                objCmd.Parameters.Add("psRETORNO", OracleType.VarChar, 200).Direction = ParameterDirection.Output;
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    resultado = objCmd.Parameters["psRETORNO"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = "ERRO - Ao executar procedimento no banco de dados: " + ex.ToString();
                }
                objConn.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                return "ERRO - Ao montar script: " + ex.ToString();
            }
        }

        public static string ExecutarBloqueioDesbloqueio(bool bloqueio
                                                        , decimal codigoProduto
                                                        , string numeroLote
                                                        , decimal quantidade
                                                        , string motivo
                                                        , string numAjuri)
        {
            try
            {
                string resultado = "";
                Oracle oracle = new Oracle(PCPedc.GetStringConnection());

                OracleConnection objConn = oracle.GetConnection();
                OracleCommand objCmd = objConn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                if (bloqueio)
                {
                    objCmd.CommandText = servicoWMSOMBoat_BloquearEstoquePorLote();
                    objCmd.Parameters.Add("pnCODPROD", OracleType.Double).Value = codigoProduto;
                    objCmd.Parameters.Add("psNUMLOTE", OracleType.VarChar, 30).Value = numeroLote;
                    objCmd.Parameters.Add("pnQUANTIDADE", OracleType.Double).Value = quantidade;
                    objCmd.Parameters.Add("psMOTIVO", OracleType.VarChar, 200).Value = motivo;
                    objCmd.Parameters.Add("psNUMAJURI", OracleType.VarChar, 30).Value = numAjuri;
                }
                else
                {
                    objCmd.CommandText = servicoWMSOMBoat_DesbloquearEstoquePorLote();
                    objCmd.Parameters.Add("pnCODPROD", OracleType.Double).Value = codigoProduto;
                    objCmd.Parameters.Add("psNUMLOTE", OracleType.VarChar, 30).Value = numeroLote;
                    objCmd.Parameters.Add("pnQUANTIDADE", OracleType.Double).Value = quantidade;
                }

                objCmd.Parameters.Add("psRETORNO", OracleType.VarChar, 200).Direction = ParameterDirection.Output;
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    resultado = objCmd.Parameters["psRETORNO"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = "ERRO - Ao executar procedimento no banco de dados: " + ex.ToString();
                }
                objConn.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                return "ERRO - Ao montar script: " + ex.ToString();
            }
        }

        public static string ExecutarTransferencia(string codigoFabricaOrigem
                                                  , decimal programaOrigem
                                                  , string codigoFabricaDestino
                                                  , decimal programaDestino
                                                  , string numeroLote
                                                  , decimal quantidade)
        {
            try
            {
                string resultado = "";
                Oracle oracle = new Oracle(PCPedc.GetStringConnection());

                OracleConnection objConn = oracle.GetConnection();
                OracleCommand objCmd = objConn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = servicoWMSOMBoat_TransferirPrograma();
                //Parâmetros
                objCmd.Parameters.Add("psCODFAB_ORIGEM", OracleType.VarChar, 30).Value = codigoFabricaOrigem;
                objCmd.Parameters.Add("pnCODPROGRAMA_ORIGEM", OracleType.Double).Value = programaOrigem;
                objCmd.Parameters.Add("psCODFAB_DESTINO", OracleType.VarChar, 30).Value = codigoFabricaDestino;
                objCmd.Parameters.Add("pnCODPROGRAMA_DESTINO", OracleType.Double).Value = programaDestino;
                objCmd.Parameters.Add("psNUMLOTE", OracleType.VarChar, 30).Value = numeroLote;
                objCmd.Parameters.Add("pnQUANTIDADE", OracleType.Double).Value = quantidade;

                objCmd.Parameters.Add("psRETORNO", OracleType.VarChar, 200).Direction = ParameterDirection.Output;
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    resultado = objCmd.Parameters["psRETORNO"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = "ERRO - Ao executar procedimento no banco de dados: " + ex.ToString();
                }
                objConn.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                return "ERRO - Ao montar script: " + ex.ToString();
            }
        }

        public static string ExecutarAjusteSaldo( string codigoFabrica
                                                , decimal programa
                                                , string numeroLote
                                                , decimal quantidade)
        {
            try
            {
                string resultado = "";
                Oracle oracle = new Oracle(PCPedc.GetStringConnection());

                OracleConnection objConn = oracle.GetConnection();
                OracleCommand objCmd = objConn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = servicoWMSOMBoat_AjustarSaldo();
                //Parâmetros
                objCmd.Parameters.Add("psCODFAB", OracleType.VarChar, 30).Value = codigoFabrica;
                objCmd.Parameters.Add("pnCODPROGRAMA", OracleType.Double).Value = programa;
                objCmd.Parameters.Add("psNUMLOTE", OracleType.VarChar, 30).Value = numeroLote;
                objCmd.Parameters.Add("pnQUANTIDADE", OracleType.Double).Value = quantidade;

                objCmd.Parameters.Add("psRETORNO", OracleType.VarChar, 200).Direction = ParameterDirection.Output;
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    resultado = objCmd.Parameters["psRETORNO"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = "ERRO - Ao executar procedimento no banco de dados: " + ex.ToString();
                }
                objConn.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                return "ERRO - Ao montar script: " + ex.ToString();
            }
        }

        internal Respostas ExecutarTemSaldo( string Partnumber
                                           , string Serial
                                           , string Lote
                                           , decimal Quantidade
                                           , bool Bloquear
                                           )
        {
            Respostas resultado = new Respostas();
            var Codproduto = ObterProduto(Partnumber, Serial);

            if (Codproduto <= 0)
            {
                resultado.mensagem = string.Format("ERRO: Produto {0} - Programa {1} não cadastrado no ERP", Partnumber, Serial);
                resultado.processado = false;                
            }
            try
            {
                Oracle oracle = new Oracle(PCPedc.GetStringConnection());

                OracleConnection objConn = oracle.GetConnection();
                OracleCommand objCmd = objConn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = servicoWMSOMBoat_SaldoProduto();

                objCmd.Parameters.Add("pnCODPROD", OracleType.Double).Value = Codproduto;
                objCmd.Parameters.Add("psNUMLOTE", OracleType.VarChar, 30).Value = Lote; 
                objCmd.Parameters.Add("psNUMAJURI", OracleType.VarChar, 30).Value = Partnumber;
                objCmd.Parameters.Add("psPARABLOQUEAR", OracleType.VarChar, 1).Value = Bloquear ? "S" : "N";
                objCmd.Parameters.Add("pnQUANTIDADE", OracleType.Double).Value = Convert.ToDecimal(Quantidade); 

                objCmd.Parameters.Add("psRETORNO", OracleType.VarChar, 200).Direction = ParameterDirection.Output;
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    resultado.mensagem = objCmd.Parameters["psRETORNO"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado.mensagem = "ERRO - Ao executar procedimento no banco de dados: " + ex.ToString();
                }
                objConn.Close();
                resultado.processado = true;
                return resultado;
            }
            catch (Exception ex)
            {
                resultado.processado = false;
                resultado.mensagem = "ERRO - Ao montar script: " + ex.ToString();
                return resultado;
            }
        }

        private string ObterIDAjuri(List<Livre> list, string chave)
        {
            Livre registro = list.Where(c => c.Nome == chave).FirstOrDefault();
            if (registro != null)
            {
                return registro.Valor;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Retornar o filtro do tipo da pessoa
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private string ScriptFiltroPessoa(Entidade item)
        {
            string cnpj = string.IsNullOrEmpty(item.Documentofederal) ? "11223344RR" : item.Documentofederal;
            string idAjuri = ObterIDAjuri(item.Livres.Livre, "ID_AJURI");
            idAjuri = string.IsNullOrEmpty(idAjuri) ? "XYD" : idAjuri;

            return string.Format(@"((REGEXP_REPLACE(CNPJ_CPF, '[^0-9]','') = REGEXP_REPLACE('{0}', '[^0-9]','')) OR (NUMAJURI = '{1}'))"
                                , cnpj
                                , idAjuri);
        }

        /// <summary>
        /// Montando o endereço completo
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private string MontarEndereco(Entidade item)
        {
            string retorno = "";
            if (string.IsNullOrEmpty(item.Endereco.Logradourotipo))
            {
                retorno = item.Endereco.Logradouro;
            }
            else
            {
                retorno = item.Endereco.Logradourotipo + " " + item.Endereco.Logradouro;
            }
            if (!string.IsNullOrEmpty(retorno))
            {
                retorno = retorno.Replace("'", "´");
            }
            return retorno;
        }
        #endregion

        #region Outros Cadastros
        /// <summary>
        /// Obter o cadsatro de seção ou cadastra-lo
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        private decimal ObterSecao(Produto registro)
        {
            decimal valor = 0;
            if (!string.IsNullOrEmpty(registro.Grupo.Descricao))
            {
                ESTSecao cadastro = null;
                try
                {
                    cadastro = ESTSecao.Listar(string.Format("UPPER(DESCRICAO) = '{0}'"
                                           , registro.Grupo.Descricao.ToUpper())).FirstOrDefault();
                    valor = cadastro.Codigo;
                }
                catch
                {
                    cadastro = new ESTSecao();
                    if (!string.IsNullOrEmpty(registro.Grupo.Descricao))
                    {
                        cadastro.Descricao = registro.Grupo.Descricao.Replace("'", "`"); ;
                    }
                    cadastro.Coddepartamento = ObterDepartamento(registro);
                    cadastro.Codigo = cadastro.Proximo("ESS_ESTSECAO");
                    cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
                    cadastro.Dtalteracao = cadastro.DataHoraServidor();
                    cadastro.Dtinclusao = cadastro.Dtalteracao;

                    if (cadastro.Gravar())
                    {
                        valor = cadastro.Codigo;
                    }
                }
            }
            return valor;
        }

        /// <summary>
        /// Obter o cadastro de departamento ou cadastra-lo
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        private decimal ObterDepartamento(Produto registro)
        {
            decimal valor = 0;
            if (!string.IsNullOrEmpty(registro.Tipo.Descricao))
            {
                ESTDepartamento cadastro = null;
                try
                {
                    cadastro = ESTDepartamento.Listar(string.Format("UPPER(DESCRICAO) = '{0}'"
                                           , registro.Tipo.Descricao.ToUpper())).FirstOrDefault();
                    valor = cadastro.Codigo;
                }
                catch
                {
                    cadastro = new ESTDepartamento();
                    if (!string.IsNullOrEmpty(registro.Grupo.Descricao))
                    {
                        cadastro.Descricao = registro.Grupo.Descricao.Replace("'", "`"); ;
                    }
                    cadastro.Codigo = cadastro.Proximo("ESS_ESTDEPARTAMENTO");
                    cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
                    cadastro.Dtalteracao = cadastro.DataHoraServidor();
                    cadastro.Dtinclusao = cadastro.Dtalteracao;

                    if (cadastro.Gravar())
                    {
                        valor = cadastro.Codigo;
                    }
                }
            }
            return valor;
        }

        /// <summary>
        /// Obter o cadastro de produto ou cadastra-lo
        /// </summary>
        /// <param name="produto"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        private decimal ObterProduto(string Partnumber, string Serial)
        {
            if (string.IsNullOrEmpty(Partnumber))
            {
                Logs.GerarLog("Integradora.WebServiceOMBoat"
                         , "ObterProduto"
                         , "Número ajuri não informado!");
                return 0;
            }
            if (string.IsNullOrEmpty(Serial))
            {
                Logs.GerarLog("Integradora.WebServiceOMBoat"
                             , "ObterProduto"
                             , "Número serial/programa não informado!");
                return 0;
            }

            decimal resultado = 0;
            ESTProduto cadastro = null;
            try
            {//Tenta localizar o produto pelo código de fábrica montado
                cadastro = ESTProduto.Listar(string.Format("NUMAJURI = '{0}' AND SERIAL = '{1}'"
                                            , Partnumber, Serial)).FirstOrDefault();

                if (cadastro != null)
                {
                    resultado = cadastro.Codigo;
                }
            }
            catch (Exception ex)
            {
                if (!ex.ToString().Contains("A sequência contém mais de um elemento"))
                {
                    Logs.GerarLog("Integradora.WebServiceOMBoat"
                                 , "ObterProduto"
                                 , string.Format("Produto não encontrado para a NumAjuri: {0}, Programa: {1} - Erro: {2}", Partnumber, Serial, ex.ToString()));
                }
                resultado = 0;
            }

            if (resultado == 0)
            {
                try
                {//Tenta localizar pelo menos um código de fábrica padrão
                    cadastro = ESTProduto.Listar(string.Format("NUMAJURI = '{0}' ORDER BY NVL(LPAD(SERIAL,3,'0'),'000')"
                                                , Partnumber)).FirstOrDefault();
                    if (cadastro != null)
                    {
                        cadastro.OID = "";
                        cadastro.Serial = Serial;
                        cadastro.Codprodprincipal = cadastro.Codigo;
                        cadastro.Codigo = cadastro.Proximo("ESS_ESTPRODUTO");
                        cadastro.Dtinclusao = cadastro.DataHoraServidor();
                        cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;

                        if (cadastro.Gravar())
                        {
                            resultado = cadastro.Codigo;
                        }
                    }
                }
                catch (Exception ex1)
                {
                    if (!ex1.ToString().Contains("A sequência contém mais de um elemento"))
                    {
                        Logs.GerarLog("Integradora.WebServiceOMBoat"
                                     , "ObterProduto"
                                     , string.Format("Não foi possível copiar um produto para gerar outro para o NumAjuri: {0}, Programa: {1} - Erro: {2}", Partnumber, Serial, ex1.ToString()));
                    }
                    resultado = 0;
                }
            }
            return resultado;
        }

        #endregion

        #region Métodos de importação
        /// <summary>
        /// Importação de cliente e destinatários
        /// </summary>
        /// <param name="DadosAjuri"></param>
        /// <returns></returns>
        internal decimal ImportarCliente(Entidade DadosAjuri)
        {
            decimal resultado = 0;
            ESTCliente cadastro = null;
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    try
                    {
                        cadastro = ESTCliente.Listar(ScriptFiltroPessoa(DadosAjuri)).FirstOrDefault();
                    }
                    catch
                    {
                        cadastro = NovoCliente(cadastro);
                    }

                    if (cadastro == null)
                    {
                        cadastro = NovoCliente(cadastro);
                    }
                    cadastro.Dtalteracao = cadastro.DataHoraServidor();
                    cadastro.Bairro = DadosAjuri.Endereco.Bairro;
                    cadastro.Cep = DadosAjuri.Endereco.Cep;
                    cadastro.Cidade = DadosAjuri.Endereco.Cidade;
                    cadastro.Cnpj_Cpf = DadosAjuri.Documentofederal;
                    cadastro.Codibge = 0;
                    cadastro.Endereco = MontarEndereco(DadosAjuri);
                    cadastro.Estado = DadosAjuri.Endereco.Uf;
                    cadastro.Ie = DadosAjuri.Documentoestadual;
                    cadastro.Nome = DadosAjuri.Razao;
                    cadastro.Numajuri = ObterIDAjuri(DadosAjuri.Livres.Livre, "ID_AJURI");
                    cadastro.Numero = DadosAjuri.Endereco.Numero;
                    cadastro.Codpraca = Biblioteca.Dictionaries.Settings.CodPraca();
                    if (DadosAjuri.Isdestinatario == "SIM")
                    {
                        cadastro.Tipopessoa = "U";
                    }
                    else
                    {
                        cadastro.Tipopessoa = DadosAjuri.Tipo == "JURIDICA" ? "J" : "F";
                    }

                    foreach (var registro in DadosAjuri.Livres.Livre)
                    {
                        if (registro.Nome == "SIGLA_DESTINO_AJURI")
                        {
                            if (!string.IsNullOrEmpty(registro.Valor))
                            {
                                cadastro.Nomefantasia = registro.Valor;
                            }
                        }
                    }

                    if (cadastro.Gravar())
                    {
                        resultado = cadastro.Codigo;
                    }

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarCliente" //metodo
                                             , "Cliente cadastrado com sucesso!" //mensagem
                                             , "ESTCLIENTE" //tabela
                                             , resultado //codigoEssenti
                                             , cadastro.Numajuri //codigoEcommerce
                                             , false //Winthor enviou?
                                             , true //sucesso
                                             );


                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    decimal codigoEssenti = 0;
                    if (cadastro != null)
                    {
                        codigoEssenti = cadastro.Codigo;
                    }

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarCliente" //metodo
                                             , "Erro ao cadastrar cliente/destinatário: " + ex.ToString() //mensagem
                                             , "ESTCLIENTE" //tabela
                                             , codigoEssenti //codigoEssenti
                                             , ObterIDAjuri(DadosAjuri.Livres.Livre, "ID_AJURI") //codigoEcommerce
                                             , false //Winthor enviou?
                                             , false //sucesso
                                             );
                    resultado = 0;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Preparando para gerar um novo cliente
        /// </summary>
        /// <param name="cadastro"></param>
        /// <returns></returns>
        private static ESTCliente NovoCliente(ESTCliente cadastro)
        {
            cadastro = new ESTCliente();
            cadastro.Celular = "";
            cadastro.Telefone = "";
            cadastro.Fax = "";
            cadastro.Codigo = cadastro.Proximo("ESS_ESTCLIENTE");
            cadastro.Dtinclusao = cadastro.DataHoraServidor();
            cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
            return cadastro;
        }

        /// <summary>
        /// Importação de fornecedor
        /// </summary>
        /// <param name="DadosAjuri"></param>
        /// <returns></returns>
        internal decimal ImportarFornecedor(Entidade DadosAjuri)
        {
            decimal resultado = 0;
            ESTFornecedor cadastro = null;
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    try
                    {
                        cadastro = ESTFornecedor.Listar(ScriptFiltroPessoa(DadosAjuri)).FirstOrDefault();
                    }
                    catch
                    {
                        cadastro = NovoFornecedor(cadastro);
                    }
                    if (cadastro == null)
                    {
                        cadastro = NovoFornecedor(cadastro);
                    }
                    cadastro.Dtalteracao = cadastro.DataHoraServidor();
                    cadastro.Bairro = DadosAjuri.Endereco.Bairro;
                    cadastro.Cep = DadosAjuri.Endereco.Cep;
                    cadastro.Cidade = DadosAjuri.Endereco.Cidade;
                    cadastro.Cnpj_Cpf = DadosAjuri.Documentofederal;
                    cadastro.Codibge = 0;
                    cadastro.Endereco = MontarEndereco(DadosAjuri);
                    cadastro.Estado = DadosAjuri.Endereco.Uf;
                    cadastro.Ie = DadosAjuri.Documentoestadual;
                    cadastro.Nome = DadosAjuri.Razao;
                    cadastro.Numajuri = ObterIDAjuri(DadosAjuri.Livres.Livre, "ID_AJURI");
                    cadastro.Numero = DadosAjuri.Endereco.Numero;
                    cadastro.Tipopessoa = DadosAjuri.Tipo == "JURIDICA" ? "J" : "F";

                    if (cadastro.Gravar())
                    {
                        resultado = cadastro.Codigo;
                    }

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarFornecedor" //metodo
                                             , "Fornecedor cadastrado com sucesso!" //mensagem
                                             , "ESTFORNECEDOR" //tabela
                                             , resultado //codigoEssenti
                                             , cadastro.Numajuri //codigoEcommerce
                                             , false //Winthor enviou?
                                             , true //sucesso
                                             );

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    decimal codigoEssenti = 0;
                    if (cadastro != null)
                    {
                        codigoEssenti = cadastro.Codigo;
                    }

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarFornecedor" //metodo
                                             , "Erro ao cadastrar fornecedor: " + ex.ToString() //mensagem
                                             , "ESTFORNECEDOR" //tabela
                                             , codigoEssenti //codigoEssenti
                                             , ObterIDAjuri(DadosAjuri.Livres.Livre, "ID_AJURI") //codigoEcommerce
                                             , false //Winthor enviou?
                                             , false //sucesso
                                             );
                    resultado = 0;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Preparando para gerar um novo fornecedor
        /// </summary>
        /// <param name="cadastro"></param>
        /// <returns></returns>
        private static ESTFornecedor NovoFornecedor(ESTFornecedor cadastro)
        {
            cadastro = new ESTFornecedor();
            cadastro.Celular = "";
            cadastro.Telefone = "";
            cadastro.Fax = "";
            cadastro.Codigo = cadastro.Proximo("ESS_ESTFORNECEDOR");
            cadastro.Dtinclusao = cadastro.DataHoraServidor();
            cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
            return cadastro;
        }

        /// <summary>
        /// Importação de fabricante
        /// </summary>
        /// <param name="DadosAjuri"></param>
        /// <returns></returns>
        internal decimal ImportarFabricante(Entidade DadosAjuri)
        {
            decimal resultado = 0;
            ESTFabricante cadastro = null;
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    try
                    {
                        cadastro = ESTFabricante.Listar(ScriptFiltroPessoa(DadosAjuri)).FirstOrDefault();
                    }
                    catch
                    {
                        cadastro = NovoFabricante(cadastro);
                    }

                    if (cadastro == null)
                    {
                        cadastro = NovoFabricante(cadastro);
                    }
                    cadastro.Dtalteracao = cadastro.DataHoraServidor();
                    cadastro.Bairro = DadosAjuri.Endereco.Bairro;
                    cadastro.Cep = DadosAjuri.Endereco.Cep;
                    cadastro.Cidade = DadosAjuri.Endereco.Cidade;
                    cadastro.Cnpj_Cpf = DadosAjuri.Documentofederal;
                    cadastro.Codibge = 0;
                    cadastro.Endereco = MontarEndereco(DadosAjuri);
                    cadastro.Estado = DadosAjuri.Endereco.Uf;
                    cadastro.Ie = DadosAjuri.Documentoestadual;
                    cadastro.Nome = DadosAjuri.Razao;
                    cadastro.Numajuri = ObterIDAjuri(DadosAjuri.Livres.Livre, "ID_AJURI");
                    cadastro.Numero = DadosAjuri.Endereco.Numero;
                    cadastro.Tipopessoa = DadosAjuri.Tipo == "JURIDICA" ? "J" : "F";

                    if (cadastro.Gravar())
                    {
                        resultado = cadastro.Codigo;
                    }

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarFabricante" //metodo
                                             , "Fabricante cadastrado com sucesso!" //mensagem
                                             , "ESTFABRICANTE" //tabela
                                             , cadastro.Codigo //codigoEssenti
                                             , ObterIDAjuri(DadosAjuri.Livres.Livre, "ID_AJURI") //codigoEcommerce
                                             , false //Winthor enviou?
                                             , true //sucesso
                                             );

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    decimal codigoEssenti = 0;
                    if (cadastro != null)
                    {
                        codigoEssenti = cadastro.Codigo;
                    }

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarFabricante" //metodo
                                             , "Erro ao cadastrar fabricante: " + ex.ToString() //mensagem
                                             , "ESTFABRICANTE" //tabela
                                             , codigoEssenti //codigoEssenti
                                             , ObterIDAjuri(DadosAjuri.Livres.Livre, "ID_AJURI") //codigoEcommerce
                                             , false //Winthor enviou?
                                             , false //sucesso
                                             );
                    resultado = 0;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Preparando para gerar um novo fabricante
        /// </summary>
        /// <param name="cadastro"></param>
        /// <returns></returns>
        private static ESTFabricante NovoFabricante(ESTFabricante cadastro)
        {
            cadastro = new ESTFabricante();
            cadastro.Celular = "";
            cadastro.Telefone = "";
            cadastro.Fax = "";
            cadastro.Dtinclusao = cadastro.DataHoraServidor();
            cadastro.Codigo = cadastro.Proximo("ESS_ESTFABRICANTE");
            cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
            return cadastro;
        }

        /// <summary>
        /// Importação de produto
        /// </summary>
        /// <param name="DadosAjuri"></param>
        /// <returns></returns>
        internal decimal ImportarProduto(Produto DadosAjuri, string serial)
        {
            decimal resultado = 0;
            ESTProduto cadastro = null;

            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    try
                    {
                        cadastro = ESTProduto.Listar(string.Format("NUMAJURI = '{0}'", DadosAjuri.Partnumber)).FirstOrDefault();
                    }
                    catch
                    {
                        cadastro = NovoProduto(cadastro);
                    }

                    if (cadastro == null)
                    {
                        cadastro = NovoProduto(cadastro);
                    }
                    cadastro.Dtalteracao = cadastro.DataHoraServidor();
                    cadastro.Unidade = DadosAjuri.Unidade;
                    cadastro.Embalagem = DadosAjuri.Unidade;
                    if (!string.IsNullOrEmpty(DadosAjuri.Descricao))
                    {
                        cadastro.Descricao = DadosAjuri.Descricao.Replace("'", "`");
                    }
                    cadastro.Descricaocompleta = cadastro.Descricao;
                    cadastro.Numajuri = DadosAjuri.Partnumber;
                    cadastro.Codfabrica = DadosAjuri.Partnumber;
                    cadastro.Serial = string.IsNullOrEmpty(serial) ? "37" : serial;
                    cadastro.Codbarra = Convert.ToDecimal("8" + cadastro.Codfabrica.PadLeft(7, '0') + cadastro.Serial.PadLeft(5, '0'));
                    cadastro.Codmarca = Convert.ToDecimal(cadastro.Serial);
                    foreach (var registro in DadosAjuri.Configuracoes.Configuracao)
                    {
                        cadastro.Altura = Convert.ToDecimal(registro.Embalagem.Alturametros);
                        cadastro.Comprimento = Convert.ToDecimal(registro.Embalagem.Comprimentometros);
                        cadastro.Largura = Convert.ToDecimal(registro.Embalagem.Largurametros);

                        cadastro.Pesobruto = Convert.ToDecimal(registro.Pesobrutovolumekilos);
                        cadastro.Pesoliquido = Convert.ToDecimal(registro.Pesoliquidovolumekilos);
                        cadastro.Volume = Convert.ToDecimal(registro.Volumesporpalete);

                        cadastro.Qtembalagem = Convert.ToDecimal(registro.Itensporvolume);
                        cadastro.Qtunitaria = Convert.ToDecimal(registro.Unidadesporitem);
                    }

                    foreach (var registro in DadosAjuri.Livres.Livre)
                    {
                        if (registro.Nome == "DESCRICAO_AJURI")
                        {
                            if (!string.IsNullOrEmpty(registro.Valor))
                            {
                                if (!string.IsNullOrEmpty(registro.Valor))
                                {
                                    cadastro.Descricaocompleta = registro.Valor.Replace("'", "`");
                                }
                            }
                        }
                    }
                    //Senão existe seção/departamento, o cadastro e realizado.
                    cadastro.Codsecao = ObterSecao(DadosAjuri);

                    if (cadastro.Gravar())
                    {
                        resultado = cadastro.Codigo;
                    }

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarProduto" //metodo
                                             , "Produto cadastrado com sucesso!" //mensagem
                                             , "ESTPRODUTO" //tabela
                                             , cadastro.Codigo //codigoEssenti
                                             , DadosAjuri.Partnumber //codigoEcommerce
                                             , false //Winthor enviou?
                                             , true //sucesso
                                             );

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    decimal codigoEssenti = 0;
                    if (cadastro != null)
                    {
                        codigoEssenti = cadastro.Codigo;
                    }

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarProduto" //metodo
                                             , "Erro ao cadastrar produto: " + ex.ToString() //mensagem
                                             , "ESTPRODUTO" //tabela
                                             , codigoEssenti //codigoEssenti
                                             , DadosAjuri.Partnumber //codigoEcommerce
                                             , false //Winthor enviou?
                                             , false //sucesso
                                             );

                    resultado = 0;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Preparando para gerar um novo produto
        /// </summary>
        /// <param name="cadastro"></param>
        /// <returns></returns>
        private static ESTProduto NovoProduto(ESTProduto cadastro)
        {
            cadastro = new ESTProduto();
            cadastro.Codigo = cadastro.Proximo("ESS_ESTPRODUTO");
            cadastro.Dtinclusao = cadastro.DataHoraServidor();
            cadastro.Codprodprincipal = cadastro.Codigo;
            cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
            cadastro.Codfornec = 1;
            return cadastro;
        }

        /// <summary>
        /// Importação de entrada
        /// </summary>
        /// <param name="DadosAjuri"></param>
        /// <returns></returns>
        internal Respostas ImportarDocumentoEntrada(Documento DadosAjuri)
        {
            Respostas resultado = new Respostas();
            ESTNotaentrada cadastro = null;

            string IDAjuri = ObterIDAjuri(DadosAjuri.Livres.Livre, "TRANSACAO_ID_AJURI");

            if (string.IsNullOrEmpty(IDAjuri))
            {
                resultado.processado = false;
                resultado.mensagem = "Transação ID do Ajuri não informado!";
                return resultado;
            }
            if (ESTNotaentrada.Existe(string.Format("NUMAJURI = '{0}' AND DTCANCELADO IS NULL", IDAjuri)))
            {
                resultado.processado = false;
                resultado.mensagem = "Já existe uma nota de entrada válida para o número ajuri: " + IDAjuri;
                return resultado;
            }
            else
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        cadastro = new ESTNotaentrada();
                        cadastro.Numtransacao = cadastro.Proximo("PCCONSUM", "PROXNUMTRANSENT");
                        cadastro.Chavenfe = "";
                        cadastro.TipoDocumento = "E";
                        cadastro.Codtransportadora = 0;
                        cadastro.Numconferencia = 0;
                        cadastro.Numpedido = 0;
                        cadastro.Obsintegracao = "";
                        cadastro.Tipofrete = "C";
                        cadastro.Tiponota = "E";
                        cadastro.Vltotal = 0;
                        cadastro.Numajuri = IDAjuri;
                        cadastro.Cnpj_Filial = DadosAjuri.Filial.Documentofederal;
                        cadastro.Cnpj_Emitente = DadosAjuri.Cabecalho.Entidade.Documentofederal;
                        cadastro.Cnpj_Cpf = cadastro.Cnpj_Emitente;
                        cadastro.Codfilial = Biblioteca.Dictionaries.Settings.CodFilialVenda();
                        cadastro.Codfornecedor = ImportarFornecedor(DadosAjuri.Cabecalho.Entidade);
                        cadastro.Cfop = DadosAjuri.Cabecalho.Cfop.Codigo;
                        cadastro.Dtalteracao = cadastro.DataHoraServidor();
                        cadastro.Dtemissao = Convert.ToDateTime(DadosAjuri.Cabecalhochave.Data).Date;
                        cadastro.Dtfaturamento = Convert.ToDateTime(cadastro.Dtalteracao).Date;
                        cadastro.Dtinclusao = cadastro.Dtalteracao;
                        cadastro.Numnota = Convert.ToDecimal(DadosAjuri.Cabecalhochave.Numero);
                        cadastro.Qtitens = DadosAjuri.Itens.Item.Count();
                        cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
                        cadastro.Serie = DadosAjuri.Cabecalhochave.Serie;

                        if (cadastro.Codfornecedor == 0)
                        {
                            resultado.processado = false;
                            resultado.mensagem = string.Format("Fornecedor não cadastrado - CNPJ/CPF: {0} - Nota de entrada: {1}", DadosAjuri.Cabecalho.Entidade.Documentofederal, cadastro.Numnota.ToString());
                            return resultado;
                        }

                        foreach (var item in DadosAjuri.Livres.Livre)
                        {
                            if (item.Nome == "NUMERO_DOCUMENTO")
                            {
                                cadastro.Documento = item.Valor;
                            }
                        }

                        int numseq = 0;
                        decimal ValorTotal = 0;
                        foreach (var item in DadosAjuri.Itens.Item)
                        {
                            numseq++;
                            ESTNotaentradaitens cadastroItem = new ESTNotaentradaitens();
                            cadastroItem.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
                            cadastroItem.Codproduto = ObterProduto(item.Produto.Partnumber, item.Serial);
                            if (cadastroItem.Codproduto > 0)
                            {
                                cadastroItem.Dtalteracao = cadastro.Dtalteracao;
                                cadastroItem.Dtinclusao = cadastro.Dtinclusao;
                                cadastroItem.Numajuri = item.Produto.Partnumber;
                                cadastroItem.Serial = item.Serial;
                                cadastroItem.Numseq = numseq;
                                if (!string.IsNullOrEmpty(item.Produto.Descricao))
                                {
                                    cadastroItem.Descricao = item.Produto.Descricao.Replace("'", "`");
                                }
                                cadastroItem.Numtransacao = cadastro.Numtransacao;
                                cadastroItem.Modelo = item.Modelo;
                                cadastroItem.Obsintegracao = "";
                                cadastroItem.Qtarmazenada = 0;
                                cadastroItem.Qtavaria = 0;
                                cadastroItem.Quantidade = Convert.ToDecimal(item.quantidadeunidades);
                                cadastroItem.Vlunitario = Convert.ToDecimal(item.Valorunitario.Replace(".", ","));
                                cadastroItem.Vltotal = cadastroItem.Quantidade * cadastroItem.Vlunitario;

                                ValorTotal += cadastroItem.Vltotal;

                                cadastroItem.Gravar();
                            }
                            else
                            {
                                //Cancela a transação
                                transaction.Rollback();

                                resultado.processado = false;
                                resultado.mensagem = "Produto não cadastrado! NumAjuri " + item.Produto.Partnumber;
                                return resultado;
                            }
                        }

                        if (numseq != DadosAjuri.Itens.Item.Count())
                        {
                            cadastro.Obsintegracao = "Existe divergência no total de itens importados!";
                            cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DigitacaoDadosAjuri;
                        }
                        cadastro.Vltotal = ValorTotal;
                        resultado.processado = cadastro.Gravar();


                        if (resultado.processado)
                        {
                            transaction.Commit();
                            ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                                     , "ImportarEntrada" //metodo
                                                     , "Pedido gravado com sucessso!" //mensagem
                                                     , "ESTNOTAENTRADA" //tabela
                                                     , cadastro.Numpedido //codigoEssenti
                                                     , IDAjuri //codigoEcommerce
                                                     , false //Winthor enviou?
                                                     , true //sucesso
                                                     );

                        }
                        else
                        {
                            transaction.Rollback();
                            ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                                     , "ImportarEntrada" //metodo
                                                     , resultado.mensagem //mensagem
                                                     , "ESTNOTAENTRADA" //tabela
                                                     , cadastro.Numpedido //codigoEssenti
                                                     , IDAjuri //codigoEcommerce
                                                     , false //Winthor enviou?
                                                     , false //sucesso
                                                     );
                        }
                    }
                    catch (Exception ex)
                    {
                        string erro = "Erro ao cadastrar nota de entrada: " + ex.ToString();
                        transaction.Rollback();
                        ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                                 , "ImportarEntrada" //metodo
                                                 , erro //mensagem
                                                 , "ESTNOTAENTRADA" //tabela
                                                 , cadastro.Numpedido //codigoEssenti
                                                 , IDAjuri //codigoEcommerce
                                                 , false //Winthor enviou?
                                                 , false //sucesso
                                                 );

                        resultado.processado = false;
                        resultado.mensagem = erro;
                    }
                }
            }
            return resultado;
        }

        /// <summary>
        /// Importação de saída
        /// </summary>
        /// <param name="DadosAjuri"></param>
        /// <returns></returns>
        internal Respostas ImportarDocumentoSaida(Documento DadosAjuri)
        {
            Respostas resultado = new Respostas();
            ESTPedidosaida cadastro = null;
            string IDAjuri = ObterIDAjuri(DadosAjuri.Livres.Livre, "TRANSACAO_ID_AJURI");

            if (string.IsNullOrEmpty(IDAjuri))
            {
                resultado.processado = false;
                resultado.mensagem = "ERRO: Transação ID do Ajuri não informado!";
                return resultado;
            }
            if (ESTPedidosaida.Existe(string.Format("NUMAJURI = '{0}' AND DTCANCELADO IS NULL", IDAjuri)))
            {
                resultado.processado = false;
                resultado.mensagem = "ERRO: Já existe uma pedido válido para o número ajuri: " + IDAjuri;
                return resultado;
            }
            else
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        try
                        {
                            cadastro = ESTPedidosaida.Listar(string.Format("DTCANCELADO IS NULL AND NUMAJURI = '{0}'", IDAjuri)).FirstOrDefault();
                            //Apaga todos os registros para ser processado de novo
                            cadastro.ExecutarComando("DELETE ESTPEDIDOSAIDAITENS WHERE NUMTRANSACAO = " + cadastro.Numpedido.ToString());
                        }
                        catch
                        {
                            cadastro = new ESTPedidosaida();
                            cadastro.Numpedido = cadastro.Proximo("ESS_ESTPEDIDOSAIDA");
                            cadastro.Numajuri = IDAjuri;
                        }
                        cadastro.TipoDocumento = "S";
                        cadastro.Cnpj_Filial = DadosAjuri.Filial.Documentofederal;
                        cadastro.Cnpj_Emitente = DadosAjuri.Cabecalho.Entidade.Documentofederal;
                        cadastro.Cnpj_Cpf = cadastro.Cnpj_Emitente;
                        cadastro.Codfilial = Biblioteca.Dictionaries.Settings.CodFilialVenda();
                        cadastro.Codcliente = ImportarCliente(DadosAjuri.Cabecalho.Entidade);
                        cadastro.Codtransportadora = 0;
                        string prioridade = Biblioteca.Tools.Numbers.OnlyNumbers(DadosAjuri.Prioridadeprocessamento);
                        if (string.IsNullOrEmpty(prioridade))
                            prioridade = "9";
                        cadastro.Prioridade = Convert.ToDecimal( prioridade );
                        cadastro.Dtalteracao = cadastro.DataHoraServidor();
                        cadastro.Dtemissao = Convert.ToDateTime(DadosAjuri.Cabecalhochave.Data).Date;
                        cadastro.Dtinclusao = Convert.ToDateTime(cadastro.Dtalteracao).Date;
                        cadastro.Numnota = Convert.ToDecimal(DadosAjuri.Cabecalhochave.Numero);
                        cadastro.Obsintegracao = "";
                        cadastro.Qtitens = DadosAjuri.Itens.Item.Count();
                        cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
                        cadastro.Tipofrete = "C";
                        cadastro.Vltotal = 0;
                        if (cadastro.Codcliente == 0)
                        {
                            resultado.processado = false;
                            resultado.mensagem = string.Format("Cliente não cadastrado - CNPJ/CPF: {0} - Pedido: {1}", DadosAjuri.Cabecalho.Entidade.Documentofederal, cadastro.Numnota.ToString());
                            return resultado;
                        }

                        foreach (var item in DadosAjuri.Livres.Livre)
                        {
                            if (item.Nome == "NUMERO_DOCUMENTO")
                            {
                                cadastro.Documento = item.Valor;
                            }
                        }

                        int numseq = 0;
                        decimal ValorTotal = 0;
                        foreach (var item in DadosAjuri.Itens.Item)
                        {
                            numseq++;
                            ESTPedidosaidaitens cadastroItem = new ESTPedidosaidaitens();
                            cadastroItem.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
                            cadastroItem.Codproduto = ObterProduto(item.Produto.Partnumber, item.Serial);
                            if (cadastroItem.Codproduto > 0)
                            {
                                cadastroItem.Dtalteracao = cadastro.Dtalteracao;
                                cadastroItem.Dtinclusao = cadastro.Dtinclusao;
                                cadastroItem.Numajuri = item.Produto.Partnumber;
                                cadastroItem.Serial = item.Serial;
                                if (!string.IsNullOrEmpty(item.Produto.Descricao))
                                {
                                    cadastroItem.Descricao = item.Produto.Descricao.Replace("'", "`");
                                }
                                cadastroItem.Numseq = numseq;
                                cadastroItem.Numpedido = cadastro.Numpedido;
                                cadastroItem.Modelo = item.Modelo;
                                cadastroItem.Obsintegracao = "";
                                cadastroItem.Quantidade = Convert.ToDecimal(item.quantidadeunidades);
                                cadastroItem.Vlunitario = Convert.ToDecimal(item.Valorunitario.Replace(".", ","));
                                cadastroItem.Vltotal = cadastroItem.Quantidade * cadastroItem.Vlunitario;
                                cadastroItem.Numlote = item.Lote;
                                cadastroItem.Tipoestoque = item.Tipoestoque;
                                if (string.IsNullOrEmpty(cadastroItem.Numlote))
                                {
                                    cadastroItem.Usaestoquebloqueado = "N";
                                }
                                else
                                {
                                    cadastroItem.Usaestoquebloqueado = "S";
//                                    cadastroItem.Usaestoquebloqueado = item.Lote == "S/L" ? "N" : "S";

                                    //Movimentando estoque por motivos
                                    ESTMovestoque movEstoqueMotivo = new ESTMovestoque();
                                    movEstoqueMotivo.Codproduto = cadastroItem.Codproduto;
                                    movEstoqueMotivo.Serial = item.Serial;
                                    movEstoqueMotivo.Numajuri = item.Produto.Partnumber;
                                    movEstoqueMotivo.Quantidade = cadastroItem.Quantidade;
                                    movEstoqueMotivo.Modelo = item.Modelo;
                                    movEstoqueMotivo.Numlote = cadastroItem.Numlote;
                                    movEstoqueMotivo.Codmovimento = item.Tipoestoque;
                                    movEstoqueMotivo.Dtfabricacao = Convert.ToDateTime(item.Datafabricacao).Date;
                                    movEstoqueMotivo.Dtvencimento = Convert.ToDateTime(item.Datavencimento).Date;
                                    movEstoqueMotivo.Tipo = "DESBLOQUEAR";

                                    MovimentarEstoquePorMotivo(resultado, movEstoqueMotivo);
                                }

                                if (!string.IsNullOrEmpty(item.Datavencimento))
                                    cadastroItem.Dtvalidade = Convert.ToDateTime(item.Datavencimento).Date;
                                if (!string.IsNullOrEmpty(item.Datafabricacao))
                                    cadastroItem.Dtfabricacao = Convert.ToDateTime(item.Datafabricacao).Date;

                                ValorTotal += cadastroItem.Vltotal;

                                cadastroItem.Gravar();

                            }
                            else
                            {
                                //Cancela a transação
                                transaction.Rollback();

                                resultado.processado = false;
                                resultado.mensagem = "Produto não cadastrado! NumAjuri " + item.Produto.Partnumber;
                                return resultado;
                            }
                        }

                        if (numseq != DadosAjuri.Itens.Item.Count())
                        {
                            cadastro.Obsintegracao = "Existe divergência no total de itens importados!";
                            cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
                        }
                        cadastro.Vltotal = ValorTotal;
                        resultado.processado = cadastro.Gravar();


                        if (resultado.processado)
                        {
                            transaction.Commit();

                            ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                                     , "ImportarDocumentoSaida" //metodo
                                                     , "Pedido gravado com sucessso!" //mensagem
                                                     , "ESTPEDIDOSAIDA" //tabela
                                                     , cadastro.Numpedido //codigoEssenti
                                                     , IDAjuri //codigoEcommerce
                                                     , false //Winthor enviou?
                                                     , true //sucesso
                                                     );

                        }
                        else
                        {
                            transaction.Rollback();

                            ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                                     , "ImportarDocumentoSaida" //metodo
                                                     , resultado.mensagem //mensagem
                                                     , "ESTPEDIDOSAIDA" //tabela
                                                     , cadastro.Numpedido //codigoEssenti
                                                     , IDAjuri //codigoEcommerce
                                                     , false //Winthor enviou?
                                                     , false //sucesso
                                                     );

                        }
                    }
                    catch (Exception ex)
                    {
                        string erro = "Erro ao cadastrar pedido de saida: " + ex.ToString();
                        transaction.Rollback();

                        ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                                 , "ImportarDocumentoSaida" //metodo
                                                 , erro //mensagem
                                                 , "ESTPEDIDOSAIDA" //tabela
                                                 , cadastro.Numpedido //codigoEssenti
                                                 , IDAjuri //codigoEcommerce
                                                 , false //Winthor enviou?
                                                 , false //sucesso
                                                 );

                        resultado.processado = false;
                        resultado.mensagem = erro;
                    }
                }
            }
            return resultado;
        }

        /// <summary>
        /// Cancelar nota de entrada
        /// </summary>
        /// <param name="DadosAjuri"></param>
        /// <returns></returns>
        internal Respostas ImportarCancelarDocumento(Cancelamento DadosAjuri)
        {
            Respostas resultado = new Respostas();

            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    ESTCancelamento cadastro = new ESTCancelamento();
                    cadastro.Codigo = cadastro.Proximo("ESS_ESTCANCELAMENTO");
                    cadastro.Dtalteracao = cadastro.DataHoraServidor();
                    cadastro.Dtinclusao = cadastro.Dtalteracao;
                    cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
                    cadastro.Tipo = DadosAjuri.Tipo;
                    cadastro.Serie = DadosAjuri.Cabecalho.Serie;
                    cadastro.Cfop = DadosAjuri.Cabecalho.Cfop.Codigo;
                    cadastro.Data = Convert.ToDateTime(DadosAjuri.Cabecalho.Data);
                    cadastro.Horario = DadosAjuri.Cabecalho.Hora;
                    cadastro.Numero = Convert.ToDecimal(DadosAjuri.Cabecalho.Numero);
                    cadastro.Obsintegracao = DadosAjuri.Motivo.Codigo;

                    foreach (var item in DadosAjuri.Livres.Livre)
                    {
                        if (item.Nome == "TRANSACAO_ID_AJURI")
                        {
                            cadastro.Numajuri = item.Valor;
                        }
                        if (item.Nome == "TRANSACAO_ID_CLIENTE")
                        {
                            cadastro.Transacaocliente = item.Valor;
                        }
                    }

                    resultado.processado = cadastro.Gravar();



                    if (resultado.processado)
                    {
                        //Executando procedure
                        resultado.mensagem = ExecutarCancelamentoDocumento(DadosAjuri.Tipo == "ENTRADA"
                                                                          , cadastro.Numero
                                                                          , DadosAjuri.Motivo.Codigo
                                                                          );

                        resultado.processado = !resultado.mensagem.Contains("ERRO");

                        transaction.Commit();
                    }
                    else
                    {
                        transaction.Rollback();
                    }

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarCancelarEntrada" //metodo
                                             , "Importar do sucesso o cancelamento" //mensagem
                                             , "ESTCANCELAMENTO" //tabela
                                             , 0 //codigoEssenti
                                             , DadosAjuri.Cabecalho.Numero //codigoEcommerce
                                             , false //Winthor enviou?
                                             , true //sucesso
                                             );

                }
                catch (Exception ex)
                {
                    string erro = "Erro ao cadastrar cancelamento de entrada: " + ex.ToString();
                    transaction.Rollback();

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarCancelarEntrada" //metodo
                                             , erro //mensagem
                                             , "ESTCANCELAMENTO" //tabela
                                             , 0 //codigoEssenti
                                             , DadosAjuri.Cabecalho.Numero //codigoEcommerce
                                             , false //Winthor enviou?
                                             , false //sucesso
                                             );

                    resultado.processado = false;
                    resultado.mensagem = erro;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Importar bloqueio de estoque
        /// </summary>
        /// <param name="DadosAjuri"></param>
        /// <returns></returns>
        internal Respostas ImportarEstoqueBloqueioDesbloqueio(Atuacao DadosAjuri)
        {
            Respostas resultado = new Respostas();

            if (string.IsNullOrEmpty(DadosAjuri.Lote))
            {
                resultado.processado = false;
                resultado.mensagem = "Lote não informado! NumAjuri " + DadosAjuri.Produto.Partnumber;
                return resultado;
            }

            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    ESTMovestoque cadastro = new ESTMovestoque();
                    cadastro.Codigo = cadastro.Proximo("ESS_ESTMOVESTOQUE");
                    cadastro.Codmovimento = DadosAjuri.Motivo.Codigo;
                    cadastro.Codproduto = ObterProduto(DadosAjuri.Produto.Partnumber, DadosAjuri.Serial);
                    if (cadastro.Codproduto == 0)
                    {
                        resultado.processado = false;
                        resultado.mensagem = "Produto não cadastrado! NumAjuri " + DadosAjuri.Produto.Partnumber;
                        return resultado;
                    }
                    cadastro.Dtalteracao = cadastro.DataHoraServidor();
                    cadastro.Dtinclusao = cadastro.Dtalteracao;
                    cadastro.Dtvencimento = Convert.ToDateTime(DadosAjuri.Datavencimento);
                    cadastro.Dtfabricacao = Convert.ToDateTime(DadosAjuri.Datafabricacao);
                    cadastro.Modelo = DadosAjuri.Modelo;
                    cadastro.Numajuri = DadosAjuri.Produto.Partnumber;
                    cadastro.Numlote = DadosAjuri.Lote;
                    cadastro.Obsintegracao = DadosAjuri.Motivo.Codigo;
                    cadastro.Quantidade = Convert.ToDecimal(DadosAjuri.Quantidade);
                    cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
                    cadastro.Serial = DadosAjuri.Serial;
                    cadastro.Tipo = DadosAjuri.Tipo;
                    Livre prazoreserva = DadosAjuri.Livres.Livre.Where(c => c.Nome == "PRAZO_RESERVA").FirstOrDefault();
                    if (prazoreserva != null)
                    {
                        cadastro.Dtvalidadebloqueio = Convert.ToDateTime(prazoreserva.Valor);
                    }

                    resultado.processado = cadastro.Gravar();

                    if (resultado.processado)
                    {
                        //Executando procedure
                        resultado.mensagem = ExecutarBloqueioDesbloqueio(!cadastro.Tipo.Contains("DESBLOQUEAR")
                                                                         , cadastro.Codproduto
                                                                         , cadastro.Numlote
                                                                         , cadastro.Quantidade
                                                                         , DadosAjuri.Motivo.Codigo
                                                                         , ObterIDAjuri(DadosAjuri.Livres.Livre, "TRANSACAO_ID_AJURI")
                                                                         );

                        resultado.processado = !resultado.mensagem.Contains("ERRO");

                        if (resultado.processado)
                        {
                            resultado = MovimentarEstoquePorMotivo(resultado, cadastro);
                        }

                        transaction.Commit();

                        ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                                 , "ImportarEstoqueBloqueioDesbloqueio" //metodo
                                                 , "Bloqueio/desbloqueio de estoque gravado com sucessso!" //mensagem
                                                 , "ESTMOVESTOQUE" //tabela
                                                 , 0 //codigoEssenti
                                                 , DadosAjuri.Produto.Partnumber //codigoEcommerce
                                                 , false //Winthor enviou?
                                                 , true //sucesso
                                                 );
                    }
                    else
                    {
                        transaction.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    string erro = "Erro ao cadastrar bloqueio/desbloqueio de estoque: " + ex.ToString();
                    transaction.Rollback();

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarEstoqueBloqueioDesbloqueio" //metodo
                                             , erro //mensagem
                                             , "ESTMOVESTOQUE" //tabela
                                             , 0 //codigoEssenti
                                             , DadosAjuri.Produto.Partnumber //codigoEcommerce
                                             , false //Winthor enviou?
                                             , false //sucesso
                                             );

                    resultado.processado = false;
                    resultado.mensagem = erro;
                }
            }
            return resultado;
        }

        private static Respostas MovimentarEstoquePorMotivo(Respostas resultado, ESTMovestoque cadastro)
        {
            ESTEstoquemotivo estoque = null;
            try
            {
                estoque = ESTEstoquemotivo.Listar(string.Format("MOTIVO = '{0}' AND CODPROD = {1} AND NUMAJURI = '{2}' AND NUMLOTE = '{3}'"
                                                 , cadastro.Codmovimento
                                                 , cadastro.Codproduto
                                                 , cadastro.Numajuri
                                                 , cadastro.Numlote)).Single();
            }
            catch
            {
                estoque = new ESTEstoquemotivo();
                estoque.Qtentrada = 0;
                estoque.Qtsaida = 0;
                estoque.Codprod = cadastro.Codproduto;
                estoque.Motivo = cadastro.Codmovimento;
                estoque.Numajuri = cadastro.Numajuri;
                estoque.Numlote = cadastro.Numlote;
                estoque.Modelo = cadastro.Modelo;
                estoque.Serial = cadastro.Serial;
                estoque.Dtvalidade = cadastro.Dtvencimento;
                estoque.Dtfabricacao = cadastro.Dtfabricacao;
            }

            estoque.Dtalteracao = estoque.DataHoraServidor();
            estoque.Qtentrada = estoque.Qtentrada + cadastro.Tipo == "DESBLOQUEAR" ? 0 : cadastro.Quantidade;
            estoque.Qtsaida = estoque.Qtsaida + cadastro.Tipo == "DESBLOQUEAR" ? cadastro.Quantidade : 0;
            estoque.Qtsaldo = estoque.Qtentrada - estoque.Qtsaida;

            resultado.processado = estoque.Gravar();
            return resultado;
        }

        /// <summary>
        /// Importar transferência ou acerto de estoque
        /// </summary>
        /// <param name="DadosAjuri"></param>
        /// <returns></returns>
        internal Respostas ImportarEstoqueTransferenciaAcerto(Correcao DadosAjuri)
        {
            Respostas resultado = new Respostas();

            if (string.IsNullOrEmpty(DadosAjuri.Origem.Lote))
            {
                resultado.processado = false;
                resultado.mensagem = "Lote de origem não informado! NumAjuri " + DadosAjuri.Origem.Produto.Partnumber;
                return resultado;
            }

            if (string.IsNullOrEmpty(DadosAjuri.Destino.Lote))
            {
                resultado.processado = false;
                resultado.mensagem = "Lote de destino não informado! NumAjuri " + DadosAjuri.Destino.Produto.Partnumber;
                return resultado;
            }

            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    ESTAcertotransferencia cadastro = new ESTAcertotransferencia();
                    cadastro.Codigo = cadastro.Proximo("ESS_ESTACERTOTRANSFERENCIA");
                    cadastro.Codprodutodestino = ObterProduto(DadosAjuri.Destino.Produto.Partnumber, DadosAjuri.Destino.Serial);
                    cadastro.Codprodutoorigem = ObterProduto(DadosAjuri.Origem.Produto.Partnumber, DadosAjuri.Origem.Serial);
                    try
                    { cadastro.Codmovimento = DadosAjuri.Livres.Livre.Where(c => c.Nome == "TRANSACAO_ID_AJURI").FirstOrDefault().Valor; }
                    catch
                    { }
                    try
                    { cadastro.Documentocema = DadosAjuri.Livres.Livre.Where(c => c.Nome == "DOCUMENTO_CEMA").FirstOrDefault().Valor; }
                    catch
                    { }
                    cadastro.Dtalteracao = cadastro.DataHoraServidor();
                    cadastro.Dtinclusao = cadastro.Dtalteracao;
                    cadastro.Dtfabricaodestino = Convert.ToDateTime(DadosAjuri.Destino.Fabricacao);
                    cadastro.Dtfabricaoorigem = Convert.ToDateTime(DadosAjuri.Origem.Fabricacao);
                    cadastro.Dtvencimentodestino = Convert.ToDateTime(DadosAjuri.Destino.Vencimento);
                    cadastro.Dtvencimentoorigem = Convert.ToDateTime(DadosAjuri.Origem.Vencimento);
                    cadastro.Modelodestino = DadosAjuri.Destino.Modelo;
                    cadastro.Modeloorigem = DadosAjuri.Origem.Modelo;
                    cadastro.Numajuridestino = DadosAjuri.Destino.Produto.Partnumber;
                    cadastro.Numajuriorigem = DadosAjuri.Origem.Produto.Partnumber;
                    cadastro.Numlotedestino = DadosAjuri.Destino.Lote;
                    cadastro.Numloteorigem = DadosAjuri.Origem.Lote;
                    cadastro.Quantidadedestino = Convert.ToDecimal(DadosAjuri.Destino.Quantidadeunidades);
                    cadastro.Quantidadeorigem = Convert.ToDecimal(DadosAjuri.Origem.Quantidadeunidades);
                    cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;
                    cadastro.Serialdestino = DadosAjuri.Destino.Serial;
                    cadastro.Serialorigem = DadosAjuri.Origem.Serial;
                    cadastro.Tipo = DadosAjuri.Tipo;

                    resultado.processado = cadastro.Gravar();

                    if (resultado.processado)
                    {
                        if (DadosAjuri.Tipo == "TRANSFERENCIA")
                        {
                            resultado.mensagem = ExecutarTransferencia(DadosAjuri.Origem.Produto.Partnumber
                                                                      , Convert.ToDecimal(DadosAjuri.Origem.Serial)
                                                                      , DadosAjuri.Destino.Produto.Partnumber
                                                                      , Convert.ToDecimal(DadosAjuri.Destino.Serial)
                                                                      , DadosAjuri.Destino.Lote
                                                                      , Convert.ToDecimal(DadosAjuri.Destino.Quantidadeunidades)
                                                                      );
                        }
                        if (DadosAjuri.Tipo == "ACERTO")
                        {
                            if (DadosAjuri.Destino.Lote != DadosAjuri.Origem.Lote)
                            {
                                resultado.mensagem = ExecutarAjusteSaldo( DadosAjuri.Destino.Produto.Partnumber
                                                                        , Convert.ToDecimal(DadosAjuri.Destino.Serial)
                                                                        , DadosAjuri.Destino.Lote
                                                                        , Convert.ToDecimal(DadosAjuri.Destino.Quantidadeunidades)
                                                                        );
                            }
                            else
                            {
                                resultado.mensagem = ExecutarTrocaDadosLote( DadosAjuri.Destino.Produto.Partnumber
                                                                           , Convert.ToDecimal(DadosAjuri.Destino.Serial)
                                                                           , DadosAjuri.Destino.Lote
                                                                           , Convert.ToDateTime(DadosAjuri.Destino.Fabricacao)
                                                                           , Convert.ToDateTime(DadosAjuri.Destino.Vencimento)
                                                                           , DadosAjuri.Destino.Modelo
                                                                           );
                            }

                        }
                        resultado.processado = !resultado.mensagem.Contains("ERRO");
                    }

                    transaction.Commit();

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarEstoqueTransferenciaAcerto" //metodo
                                             , "Transferência/acerto de estoque gravado com sucessso!" //mensagem
                                             , "ESTMOVESTOQUE" //tabela
                                             , 0 //codigoEssenti
                                             , DadosAjuri.Origem.Produto.Partnumber //codigoEcommerce
                                             , false //Winthor enviou?
                                             , true //sucesso
                                             );
                }
                catch (Exception ex)
                {
                    string erro = "Erro ao cadastrar transferência/acerto de estoque: " + ex.ToString();
                    transaction.Rollback();

                    ESTLogintegracao.GerarLog("Integradora.WebServiceOMBoat" //classe
                                             , "ImportarEstoqueTransferenciaAcerto" //metodo
                                             , erro //mensagem
                                             , "ESTMOVESTOQUE" //tabela
                                             , 0 //codigoEssenti
                                             , DadosAjuri.Origem.Produto.Partnumber //codigoEcommerce
                                             , false //Winthor enviou?
                                             , false //sucesso
                                             );

                    resultado.processado = false;
                    resultado.mensagem = erro;
                }
            }
            return resultado;
        }

        private string ExecutarTrocaDadosLote(string codigoFabrica, decimal programa, string numeroLote, DateTime dataFabricacao, DateTime dataVencimento, string modelo)
        {
            try
            {
                string resultado = "";
                Oracle oracle = new Oracle(PCPedc.GetStringConnection());

                OracleConnection objConn = oracle.GetConnection();
                OracleCommand objCmd = objConn.CreateCommand();
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = servicoWMSOMBoat_TrocarDadosLote();
                //Parâmetros
                objCmd.Parameters.Add("psCODFAB", OracleType.VarChar, 30).Value      = codigoFabrica;
                objCmd.Parameters.Add("pnCODPROGRAMA", OracleType.Double).Value      = programa;
                objCmd.Parameters.Add("psNUMLOTE", OracleType.VarChar, 30).Value     = numeroLote;
                objCmd.Parameters.Add("pdDATAVALIDADE", OracleType.DateTime).Value    = dataVencimento; 
                objCmd.Parameters.Add("pdDATAFABRICACAO", OracleType.DateTime).Value = dataFabricacao;
                objCmd.Parameters.Add("psFABRICANTE", OracleType.VarChar, 30).Value = modelo;

                objCmd.Parameters.Add("psRETORNO", OracleType.VarChar, 200).Direction = ParameterDirection.Output;
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();

                    resultado = objCmd.Parameters["psRETORNO"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = "ERRO - Ao executar procedimento no banco de dados: " + ex.ToString();
                }
                objConn.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                return "ERRO - Ao montar script: " + ex.ToString();
            }
        }

        /// <summary>
        /// Importar abertura de inventário
        /// </summary>
        /// <param name="inventario"></param>
        /// <returns></returns>
        internal bool ImportarInventarioAbertura(ECommerce.Ajuri.Metodos.Inventario inventario)
        {
            bool resultado = false;

            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    //Obter a transação do inventário
                    var ID = inventario.Livres.Livre.Where(c => c.Nome == "TRANSACAO_ID_CLIENTE").FirstOrDefault();
                    decimal IDInventarioAjuri = Convert.ToDecimal(ID);

                    //Montando os registros do inventário
                    foreach (var item in inventario.Material.Item)
                    {
                        try
                        {  //Lista todos os produtos como mesmo código de fábrica
                            List<ESTProduto> ListaProduto = ESTProduto.Listar(string.Format("CODFABRICA = '{0}''", item.Produto.Partnumber));

                            foreach (var itemProduto in ListaProduto)
                            {//Lista todos os endereçamento
                                List<PCEndereco> Enderecamento = PCEndereco.Listar(string.Format("CODPROD = {0}", itemProduto.Codigo));
                                foreach (var itemEndereco in Enderecamento)
                                {
                                    ESTInventario cadastro = new ESTInventario();
                                    cadastro.Codigo = Convert.ToDecimal(inventario.Inventario_id);
                                    cadastro.Dtcriado = Convert.ToDateTime(inventario.Data_origem);
                                    cadastro.Codproduto = itemEndereco.Codprod;
                                    cadastro.Codendereco = itemEndereco.Codendereco;
                                    cadastro.Numajuri = itemProduto.Numajuri;
                                    cadastro.Serial = itemProduto.Serial;
                                    cadastro.Dtalteracao = cadastro.DataHoraServidor();
                                    cadastro.Dtinclusao = cadastro.Dtinclusao;
                                    cadastro.IDinventarioajuri = IDInventarioAjuri;
                                    cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;

                                    cadastro.Gravar();
                                }
                            }
                        }
                        catch
                        {
                            Logs.GerarLog("Integradora.WebServiceOMBoat"
                                         , "ImportarAberturaInventario"
                                         , "Produto não encontrado: " + item.Produto.Partnumber);
                            resultado = false;
                            break;
                        }
                    }

                    if (resultado)
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
                    Logs.GerarLog("Integradora.WebServiceOMBoat"
                                 , "ImportarAberturaInventario"
                                 , "Erro ao cadastrar abertura de inventário: " + ex.ToString());
                    resultado = false;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Importar fechamento de inventário
        /// </summary>
        /// <param name="inventario"></param>
        /// <returns></returns>
        internal bool ImportarInventarioFechamento(ECommerce.Ajuri.Metodos.RetornaInventario inventario)
        {
            bool resultado = false;

            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    foreach (var item in inventario.Itens.Item)
                    {
                        ESTInventario cadastro = null;
                        try
                        {
                            cadastro = ESTInventario.Listar(string.Format("CODIGO = {0} AND NUMAJURI = '{1}' AND SERIAL = '{2}'"
                                                           , inventario.Inventario_id
                                                           , item.Produto.Partnumber
                                                           , item.Serial)).FirstOrDefault();
                        }
                        catch
                        {
                            cadastro = new ESTInventario();
                            cadastro.Codigo = Convert.ToDecimal(inventario.Inventario_id);
                            cadastro.Dtcriado = Convert.ToDateTime(inventario.Data_origem);
                            cadastro.Codproduto = ObterProduto(item.Produto.Partnumber, "");
                            cadastro.Numajuri = item.Produto.Partnumber;
                            cadastro.Dtinclusao = cadastro.DataHoraServidor();
                            cadastro.Quantidade = Convert.ToDecimal(item.Quantidade);
                            cadastro.Serial = item.Serial;
                        }
                        cadastro.Dtalteracao = cadastro.DataHoraServidor();
                        cadastro.Qtprocessada = Convert.ToDecimal(item.Quantidadeprocessada);
                        cadastro.Vlunitario = Convert.ToDecimal(item.Valorunitario);
                        cadastro.Modelo = item.Modelo;
                        cadastro.Localizacao = item.Localizacao;
                        cadastro.Dtfabricacao = Convert.ToDateTime(item.Datafabricacao);
                        cadastro.Dtvencimento = Convert.ToDateTime(item.Datavencimento);

                        cadastro.Semaforo = (decimal)Tips.SemaforoPosicaoOMBoat.DisponivelParaWinthor;

                        resultado = cadastro.Gravar();
                    }

                    if (resultado)
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
                    Logs.GerarLog("Integradora.WebServiceOMBoat"
                                 , "ImportarInventarioFechamento"
                                 , "Erro ao cadastrar fechamento de inventário: " + ex.ToString());
                    resultado = false;
                }
            }
            return resultado;
        }
        #endregion

        internal List<SituacaoDocumento> ObterStatusEntradas(string numeroDocumento)
        {
            List<SituacaoDocumento> retorno = new List<SituacaoDocumento>();

            string filtros = "1=1";
            if (!string.IsNullOrEmpty(numeroDocumento))
            {
                filtros = string.Format("NUMDOCUMENTO = '{0}'", numeroDocumento);
            }
            List<ESVStatusDocumento_Entrada> documentos = ESVStatusDocumento_Entrada.Listar(filtros);

            foreach (var item in documentos)
            {
                SituacaoDocumento documento = new SituacaoDocumento();
                documento.NumAjuri = item.Numajuri;
                documento.NumERP = item.Numdocumento;
                documento.Status = item.Status;
                documento.Situacao = ObterSituacaoEntrada(item.Status);

                retorno.Add(documento);
            }

            return retorno;
        }

        internal List<SituacaoDocumento> ObterStatusSaidas(string numeroDocumento)
        {
            List<SituacaoDocumento> retorno = new List<SituacaoDocumento>();

            string filtros = "1=1";
            if (!string.IsNullOrEmpty(numeroDocumento))
            {
                filtros = string.Format("NUMDOCUMENTO = '{0}'", numeroDocumento);
            }
            List<ESVStatusDocumento_Saida> documentos = ESVStatusDocumento_Saida.Listar(filtros);

            foreach (var item in documentos)
            {
                SituacaoDocumento documento = new SituacaoDocumento();
                documento.NumAjuri = item.Numajuri;
                documento.NumERP = item.Numdocumento;
                documento.Status = item.Status;
                documento.Situacao = ObterSituacaoSaida(item.Status);

                retorno.Add(documento);
            }

            return retorno;
        }

        private string ObterSituacaoSaida(string p)
        {
            string resposta = "";
            switch (p)
            {
                case "PENDENTE": resposta = "Aguardando Separação";
                    break;
                case "ABERTO": resposta = "Aguardando Separação";
                    break;
                case "SEPARACAO": resposta = "Pedido em Separação";
                    break;
                case "CONFERENCIA": resposta = "Pedido em Conferência";
                    break;
                case "EMBALAGEM": resposta = "Pedido em Embalagem";
                    break;
                case "FINALIZADO": resposta = "Concluído, aguardando efetivação";
                    break;
                case "INDEFINIDO": resposta = "Indefinido";
                    break;
                case "FINALIZADO_NAO_EFETIVADO": resposta = "Concluído, falha na efetivação";
                    break;
                default: resposta = "Indefinido";
                    break;
            }
            return resposta;
        }

        private string ObterSituacaoEntrada(string p)
        {
            string resposta = "";
            switch (p)
            {
                case "1": resposta = "Aguardando Conferência";
                    break;
                case "2": resposta = "Em processo de conferência";
                    break;
                case "3": resposta = "Conferida, Aguardando efetivação";
                    break;
                default: resposta = "";
                    break;
            }
            return resposta;
        }
    }
}
using Canducci.Zip;
using Integradora.Biblioteca.Dictionaries;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Corpem.Entity;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Service;
using Integradora.ERP.Winthor.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ERP.Winthor.Domain
{
    public class PedidoWeb
    {
        public PedidoWeb()
        {

        }

        #region Fields
        private IntegracaoParametros parametros;
        private PCClient cliente;
        private PCClientendent endereco;
        private PCCob cobranca;
        private PCPedctemp cabecalho;
        private List<PCPeditemp> itens;
        private List<PCPresttemp> parcelas;
        private PCAutorc creditoCliente;
        #endregion

        #region Propriedades
        public PCCob Cobranca
        {
            get
            {
                return cobranca;
            }
            set
            {
                cobranca = value;
            }
        }
        public PCClient Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }
        public PCAutorc CreditoCliente
        {
            get
            {
                return creditoCliente;
            }
            set
            {
                creditoCliente = value;
            }
        }
        public PCClientendent Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }
        public IntegracaoParametros Parametros
        {
            get
            {
                if (parametros == null)
                { parametros = new IntegracaoParametros(); }
                return parametros;
            }
            set
            {
                parametros = value;
            }
        }
        public PCPedctemp Cabecalho
        {
            get
            {
                if (cabecalho == null)
                { cabecalho = new PCPedctemp(); }
                return cabecalho;
            }
            set
            {
                cabecalho = value;
            }
        }
        public List<PCPeditemp> Itens
        {
            get
            {
                if (itens == null)
                { itens = new List<PCPeditemp>(); }
                return itens;
            }
            set
            {
                itens = value;
            }
        }
        public List<PCPresttemp> Parcelas
        {
            get
            {
                if (parcelas == null)
                { parcelas = new List<PCPresttemp>(); }
                return parcelas;
            }
            set
            {
                parcelas = value;
            }
        }
        public bool ClienteJaExiste { get; set; }
        public bool EnderecoJaExiste { get; set; }
        #endregion

        #region Métodos para o pedido
        public static bool PedidoExiste(string NumeroPedido)
        {
            PCPedctemp temporario = null;
            bool value = false;
            try
            {
                string filtro = string.Format("UPPER(NUMPEDCLI) = '{0}' AND ROWNUM = 1", NumeroPedido.ToUpper());

                if (PCPedctemp.Existe(filtro))
                {
                    value = true;
                    temporario = PCPedctemp.Listar(filtro).Single();
                    if (temporario.Importado == "N")
                    {
                        PedidoWeb pedidoImportado = new PedidoWeb();
                        if (pedidoImportado.PedidoConsultar(temporario.Numpedrca))
                        {
                            using (var transaction = new System.Transactions.CommittableTransaction())
                            {
                                try
                                {
                                    if (Biblioteca.Dictionaries.Settings.ModeloIntegracao() == Tips.Modelo.Winthor_VTex)
                                    {
                                        Logs.GerarLog("Integradora.ERP.Winthor", "PedidoExiste", "Pedido cliente: " + temporario.Numpedcli + " não havia sido importado: " + temporario.Observacao_Pc + " - Será excluído para ser importado novamente");
                                        pedidoImportado.PedidoApagar();
                                        value = false;
                                    }
                                    else
                                    {
                                        value = true;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "PedidoExiste", ex);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                value = false;
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "PedidoExiste", erro);
            }
            return value;
        }
        public void PedidoInicializar()
        {
            try
            {
                //Inicializando os dados do cabeçalho, conforme parâmetros 
                Cabecalho.Numpedrca = 0;
                Cabecalho.Dtaberturapedpalm = Cabecalho.DataHoraServidor();
                Cabecalho.Dtinclusao = Cabecalho.DataHoraServidor();
                Cabecalho.Dtimportacao = Cabecalho.Dtinclusao;
                if (string.IsNullOrEmpty(Cabecalho.Codfilial))
                {
                    Cabecalho.Codfilial = Parametros.Codfilial;
                }
                if (string.IsNullOrEmpty(Cabecalho.Codfilialnf))
                {
                    Cabecalho.Codfilialnf = Parametros.Codfilial;
                }
                Cabecalho.Codcob = Parametros.Codcob;
                Cabecalho.Codplpag = Parametros.Codplpag;
                Cabecalho.Codusur = Parametros.Codusur;
                Cabecalho.Codsupervisor = Parametros.Codsupervisor;
                Cabecalho.Codemitente = Parametros.Matricula;
                Cabecalho.ESC_AjustarFinanceiro = "N";
                Cabecalho.Tipointegracao = "W";
                Cabecalho.Validarnivelvenda = "N";
                Cabecalho.Vlfrete = 0;
                Cabecalho.Vldescontocupom = 0;
                Cabecalho.Vldescontofinanceiro = 0;
                Cabecalho.Vlentrada = 0;
                Cabecalho.Vlfretenf = 0;
                Cabecalho.Vloutrasdesp = 0;
                Cabecalho.Vltroco = 0;
                Cabecalho.Condvenda = 1;
                Cabecalho.Origemped = "W";
                Cabecalho.Integradora = 10; //Ikeda - Rotina 2556
                Cabecalho.Importado = "N";
                Cabecalho.Codautorizacaotef = 0;
                Cabecalho.Esc_obternsu = "N";
                cabecalho.ESC_Vloutrasdespweb = 0;

                //Dados do cliente
                Cabecalho.Codcli = Cliente.Codcli;
                Cabecalho.Codclinf = Cliente.Codcli;
                Cabecalho.Codpraca = Cliente.Codpraca;
                if (Cabecalho.Codusur == 0)
                {
                    Cabecalho.Codusur = Cliente.Codusur1;
                }
                if (Cabecalho.Codplpag == 0)
                {
                    Cabecalho.Codusur = Cliente.Codplpag;
                }
                if (Cabecalho.Codcob == "")
                {
                    Cabecalho.Codcob = Cliente.Codcob;
                }

                //Limpando registros
                Itens.Clear();
                Parcelas.Clear();
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "PedidoInicializar", erro);
            }
        }
        public bool PedidoGravar()
        {
            bool Gravou = true;
            try
            {
                //Tratamento antes da gravação do pedido
                Gravou = PedidoAntesGravar();

                if (Gravou)
                {
                    Persistencia ba = new Persistencia(PCConsum.GetStringConnection());

                    //Valida Plano pagamento x Cliente
                    if (PCPlpagcli.Existe(string.Format("CODCLI = {0}", Cabecalho.Codcli.ToString())))
                    {
                        if (!PCPlpagcli.Existe(string.Format("CODCLI = {0} AND CODPLPAG = {1}", Cabecalho.Codcli.ToString(), Cabecalho.Codplpag.ToString())))
                        {
                            PCPlpagcli registro = new PCPlpagcli();
                            registro.Codcli = Cabecalho.Codcli;
                            registro.Codplpag = Cabecalho.Codplpag;

                            Gravou = ba.Inserir(registro);
                        }
                    }

                    if (Gravou)
                    {
                        Gravou = ba.Inserir(Cabecalho);
                        if (Gravou)
                        {
                            foreach (var item in Itens)
                            {
                                Gravou = ba.Inserir(item);
                                if (!Gravou)
                                    break;
                            }
                        }
                        if (Gravou)
                        {
                            foreach (var parcela in Parcelas)
                            {
                                Gravou = ba.Inserir(parcela);
                                if (!Gravou)
                                    break;
                            }
                        }
                    }
                    if (Gravou)
                    {
                        Gravou = PedidoAposGravar();
                    }
                }
            }
            catch (Exception erro)
            {
                Gravou = false;
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "PedidoGravar", erro);
            }
            return Gravou;
        }
        public bool PedidoApagar()
        {
            bool Apagou = true;
            if (!Biblioteca.Dictionaries.Settings.Debugando())
            {
                try
                {
                    if (Cabecalho != null)
                    {
                        Persistencia ba = new Persistencia(PCConsum.GetStringConnection());

                        try
                        {
                            //Excluir crédito gerado
                            if (CreditoCliente != null)
                            {
                                ba.Excluir(CreditoCliente);
                                CreditoCliente = null;
                            }
                        }
                        catch (Exception ex)
                        {
                            Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "PedidoApagar", "Crédito de cliente não encontrado para ser excluído: " + ex.ToString());
                        }

                        try
                        {
                            //Excluir itens
                            if (Itens != null)
                            {
                                foreach (var registro in Itens)
                                {
                                    if (registro != null)
                                    {
                                        ba.Excluir(registro);
                                    }
                                }
                                Itens.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "PedidoApagar", "Crédito de cliente não encontrado para ser excluído: " + ex.ToString());
                        }

                        try
                        {
                            //Excluir parcelas
                            if (Parcelas != null)
                            {
                                foreach (var registro in Parcelas)
                                {
                                    if (registro != null)
                                    {
                                        ba.Excluir(registro);
                                    }
                                }
                                Parcelas.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "PedidoApagar", "Parcelas não encontrado para ser excluído: " + ex.ToString());
                        }

                        //Tenta retornar o numero do pedido - contador
                        DecrementarContadorNumPedWEB(Cabecalho.Numpedrca);

                        try
                        {
                            if (Cabecalho != null)
                            {
                                ba.Excluir(Cabecalho);
                                Cabecalho = null;
                            }
                        }
                        catch (Exception ex)
                        {
                            Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "PedidoApagar", "Cabeçalho do pedido não encontrado para ser excluído: " + ex.ToString());
                        }
                    }
                }
                catch (Exception erro)
                {
                    Apagou = false;
                    Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "PedidoApagar", erro);
                }
            }
            else
            {
                Apagou = false;
            }
            return Apagou;
        }

        public bool PedidoConsultar(decimal NumeroPedido)
        {
            bool resultado = false;
            try
            { //Carregando o cabeçalho do pedido
                Cabecalho = PCPedctemp.Listar("NUMPEDWEB = '" + NumeroPedido.ToString() + "'").Single();
            }
            catch (Exception)
            {
                Cabecalho = null;
            }

            resultado = Cabecalho != null;
            if (resultado)
            {
                resultado = Cabecalho.Numpedweb > 0;
            }

            if (resultado)
            {
                try
                { //Carregando os itens do pedido
                    Itens = PCPeditemp.Listar("NUMPEDWEB = '" + NumeroPedido.ToString() + "'");
                }
                catch (Exception)
                {
                    Itens = null;
                }
                try
                {//Carregando as parcelas do pedido
                    Parcelas = PCPresttemp.Listar("NUMPEDWEB = '" + NumeroPedido.ToString() + "'");
                }
                catch (Exception)
                {
                    Parcelas = null;
                }
                if (CreditoCliente != null)
                {
                    decimal codigo = CreditoCliente.Numpedido;
                    CreditoCliente = null;
                    try
                    {
                        CreditoCliente = PCAutorc.Listar("NUMPEDIDO = " + codigo.ToString()).Single();
                    }
                    catch (Exception)
                    {
                        CreditoCliente = null;
                    }
                }
            }

            return resultado;
        }

        private void DecrementarContadorNumPedWEB(decimal numpedido)
        {
            try
            {

                numpedido += 1;
                string script = string.Format(@"UPDATE PCUSUARI 
                                               SET PCUSUARI.PROXNUMPEDWEB = PCUSUARI.PROXNUMPEDWEB -1                    
                                             WHERE PCUSUARI.PROXNUMPEDWEB = {0}", numpedido.ToString());

                Persistencia ba = new Persistencia(PCConsum.GetStringConnection());
                ba.Executar(script);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "DecrementarContadorNumPedWEB", "Erro ao retorno o número do pedido web: " + ex.ToString());
            }
        }
        private bool PedidoAntesGravar()
        {
            bool retorno = true;
            try
            {
                if ((Biblioteca.Dictionaries.Settings.ModeloIntegracao() == Tips.Modelo.Winthor_VTex)
                 || (Biblioteca.Dictionaries.Settings.ModeloIntegracao() == Tips.Modelo.Winthor_VTiger)
                 || (Biblioteca.Dictionaries.Settings.ModeloIntegracao() == Tips.Modelo.Winthor_FBits)
                    )
                {
                    GerarAutorizacaoLimite();
                }

                Cabecalho.Dtfechamentopedpalm = Cabecalho.DataHoraServidor();
                if (Cabecalho.Numpedrca <= 0)
                {//VTEX irá usar o mesmo deles...
                    Cabecalho.Numpedrca = Cabecalho.Proximo("PCUSUARI", "PROXNUMPEDWEB", "CODUSUR = " + Cabecalho.Codusur.ToString());
                }

                Cabecalho.Numpedweb = Cabecalho.Numpedrca;
                if (Cabecalho.Dtentrega == null)
                {
                    Cabecalho.Dtentrega = Cabecalho.Data.AddDays(4);
                }
                Cabecalho.Transacao = Cabecalho.Proximo("DFSEQ_PCPEDCTEMP_NUMTRANS");
                Cabecalho.Hora = Cabecalho.Dtinclusao.Hour;
                Cabecalho.Minuto = Cabecalho.Dtinclusao.Minute;
                Cabecalho.Obs1 = "Pedido web: " + Cabecalho.Numpedcli;
                Cabecalho.Numitens = Itens.Count();
                Cabecalho.Baixaestloja = "S";
                Cabecalho.Baixaestcli = "N";

                foreach (var item in Itens)
                { //Tratamento dos itens
                    item.Numpedrca = Cabecalho.Numpedrca;
                    item.Codcli = Cabecalho.Codcli;
                    item.Codplpag = Cabecalho.Codplpag;
                    item.Codusur = Cabecalho.Codusur;
                    item.Data = Cabecalho.Data;
                    item.Dtinclusao = Cabecalho.Dtinclusao;
                    item.Integradora = Cabecalho.Integradora;
                    item.Numpedcli = Cabecalho.Numpedcli;
                    item.Numpedweb = Cabecalho.Numpedweb;
                    item.Tipointegracao = "W";
                    item.Transacao = Cabecalho.Transacao;
                    if (string.IsNullOrEmpty(item.Codfilialretira))
                    {
                        item.Codfilialretira = Parametros.Codfilialretira;
                    }
                }

                foreach (var parcela in Parcelas)
                { //Tratamento das parcelas
                    if (Cabecalho.Codclirecebedor > 0)
                    {
                        parcela.Codcli = Numbers.ToInt32(Cabecalho.Codclirecebedor.ToString());
                    }
                    else
                    {
                        parcela.Codcli = Cabecalho.Codcli;
                    }

                    parcela.Codusur = Cabecalho.Codusur;
                    parcela.Idtitulo = Cabecalho.Proximo("DFSEQ_PCPRESTTEMP_IDTITULO");
                    parcela.Dtinclusao = Cabecalho.Dtinclusao;
                    parcela.Integradora = Cabecalho.Integradora;
                    parcela.Tipointegracao = Cabecalho.Tipointegracao;
                    parcela.Dtemissao = cabecalho.Data;
                    parcela.Vltxboleto = 0;
                    parcela.Numpedweb = cabecalho.Numpedweb;
                    parcela.Nossonumbco = "";
                    if (parcela.Codcob == "")
                    {
                        parcela.Codcob = Cabecalho.Codcob;
                    }
                }
                Cabecalho.Codclirecebedor = 0;

                retorno = true;
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "PedidoAntesGravar", erro);
                retorno = false;
            }

            return retorno;
        }
        private bool PedidoAposGravar()
        {
            bool retorno = true;
            foreach (var item in itens)
            {
                if ((Biblioteca.Dictionaries.Settings.ModeloIntegracao() == Tips.Modelo.Winthor_VTex)
                 || (Biblioteca.Dictionaries.Settings.ModeloIntegracao() == Tips.Modelo.Winthor_VTiger))
                {
                    retorno = GerarAutorizacaoLimiteProdutoPCTABPR(item);
                }
                else
                {
                    if (Biblioteca.Dictionaries.Settings.ModeloIntegracao() == Tips.Modelo.Winthor_FBits)
                    {
                        retorno = GerarAutorizacaoLimiteProdutoPCEMBALAGEM(item);
                    }
                }
            }
            return retorno;
        }

        public PCPeditemp NovoItemPedido()
        {
            PCPeditemp novo = new PCPeditemp();
            if (string.IsNullOrEmpty(novo.Codfilialretira))
            {
                novo.Codfilialretira = Parametros.Codfilialretira;
            }

            return novo;
        }
        public PCPresttemp NovaParcela()
        {
            PCPresttemp novo = new PCPresttemp();

            return novo;
        }

        private bool CobrancaPorBoleto()
        {
            bool retorno = false;
            try
            {
                Cobranca = PCCob.Listar(string.Format("CODCOB = '{0}'", Cabecalho.Codcob.ToUpper())).Single();
            }
            catch
            {
                Cobranca = null;
            }

            if (Cobranca != null)
            {
                if (!string.IsNullOrEmpty(Cobranca.Boleto))
                {
                    retorno = Cobranca.Boleto.ToUpper() == "S";
                }
            }
            return retorno;
        }

        public bool IntegrarPedido_Modelo_01(decimal numeroPedidoWEB, decimal codigoRCA)
        {
            bool resultado = false;
            try
            {
                Persistencia ba = new Persistencia(PCConsum.GetStringConnection());

                ba.ExecutarProcedure(FuncoesBanco.integradoraWeb_Modelo_01()
                                    , "p_numpedweb;p_codusur"
                                    , numeroPedidoWEB.ToString() + ";" + codigoRCA.ToString());
                resultado = true;
            }
            catch (Exception erro)
            {
                Biblioteca.Tools.Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "IntegrarPedido_Modelo_01", erro);
                resultado = false;
            }

            return resultado;
        }

        public bool IntegrarPedido_Modelo_02(decimal numeroPedidoWEB, decimal integradora, decimal codigoRCA)
        {
            bool resultado = false;
            try
            {
                Persistencia ba = new Persistencia(PCConsum.GetStringConnection());

                ba.ExecutarProcedure(FuncoesBanco.integradoraWeb_Modelo_02()
                                    , "PNUMPEDWEB;PINTEGRADORA;PCODUSUR"
                                    , numeroPedidoWEB.ToString() + ";"+integradora.ToString()+";" + codigoRCA.ToString());
                resultado = true;
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "IntegrarPedido", erro);
                resultado = false;
            }

            return resultado;
        }
        #endregion
        #region Métodos para o cliente
        public void ClienteInicializar()
        {
            try
            {
                Cliente = new PCClient();
                Cliente.Codusur1 = Parametros.Codusur;
                Cliente.Codplpag = Parametros.Codplpag;
                Cliente.Codcob = Parametros.Codcob;
                Cliente.Dtcadastro = Parametros.DataServidor();
                Cliente.Codcontab = Parametros.ContaContabilCliente;
                Cliente.Aceitavendafracao = "N";
                Cliente.Meiocomunicacao = "N";
                Cliente.Bloqueio = "N";
                Cliente.Bloqueiosefaz = "N";
                Cliente.Bloqueiosefazped = "N";
                Cliente.Bloqvendapf = "N";
                Cliente.Condvenda1 = "S";
                Cliente.Contribuinte = "N";
                Cliente.Codfunccad = Parametros.Matricula;
                Cliente.Codfunccadastro = Parametros.Matricula;
                Cliente.Dtimportintegracao = Parametros.DataHoraServidor();
                Cliente.Horacadastro = Cliente.Dtimportintegracao;
                Cliente.Dtinclusao = Cliente.Dtimportintegracao;
                Cliente.Dtcadastro = Cliente.Dtimportintegracao;
                Cliente.Dtprimcompra = Cliente.Dtcadastro;
                Cliente.Dtultvisita = Cliente.Dtcadastro;
                Cliente.Codatv1 = Parametros.Codativ;
                Cliente.Aceitatrocanegativa = "N";
                Cliente.Consumidorfinal = "S";
                Cliente.Aplicadescnf = "S";
                Cliente.Simplesnacional = "N";
                Cliente.Sexo = "M";
                Cliente.Isencaosuframa = "T";
                Cliente.Clicrm = "N";
                Cliente.Tv10usacustoproduto = "N";
                Cliente.Inscestadual = "ISENTO";
                Cliente.Codpais = 1058; //Brasil 
                Cliente.Observacao = "Importado do E-Commerce";
                Cliente.Esc_Aposentado = "N";
                Cliente.Esc_diavecto = 1;
                Cliente.Esc_Tipocliente = "A";
                Cliente.Meiocomunicacao = "N";
                Cliente.Aceitachterceiros = "S";
                Cliente.Agregarvalorstdescfin = "N";
                Cliente.Anvisa = "N";
                Cliente.Aplicredbaseicmstransp = "N";
                Cliente.Atendedomingo = "N";
                Cliente.Atendequarta = "N";
                Cliente.Atendequinta = "N";
                Cliente.Atendesabado = "N";
                Cliente.Atendesegunda = "N";
                Cliente.Atendesexta = "N";
                Cliente.Atendeterca = "N";
                Cliente.Atualizasaldoccdescfin = "N";
                Cliente.Bloqremcob = "N";
                Cliente.Clientedan = "N";
                Cliente.Clientefontest = "N";
                Cliente.Clientemonitorado = "N";
                Cliente.Clientprotesto = "S";

            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "ClienteInicializar", erro);
            }
        }
        public bool ClienteExiste(string filtro)
        {
            ClienteJaExiste = true;
            try
            {
                //Obtem a lista de clientes
                List<PCClient> ListaCliente = PCClient.Listar(filtro);
                Cliente = new PCClient();
                switch (ListaCliente.Count)
                {
                    case 0:
                        { //Nenhum cliente encontrado
                            ClienteJaExiste = false;
                            Cliente = null;
                        }
                        break;
                    case 1:
                        { //Acho o cliente
                            ClienteJaExiste = true;
                            Cliente = ListaCliente[0];
                        }
                        break;
                    default:
                        { //Mas de um cliente para o CNPJ/CPF
                            ClienteJaExiste = true;
                            Cliente = null;
                        }
                        break;
                }
            }
            catch (Exception)
            {
                Cliente = null;
                ClienteJaExiste = false;
            }

            return ClienteJaExiste;
        }

        public void GravarClienteECommerce(decimal numPedidoRCA, decimal ValorPedido, decimal ValorParcela)
        {
            if (!ESTCliente_ECommerce.Existe(string.Format("CODCLI = {0} AND NUMPEDRCA = {1}", Cliente.Codcli, numPedidoRCA)))
            {
                ESTCliente_ECommerce ClienteECommerce = new ESTCliente_ECommerce();

                ClienteECommerce.Numpedrca = numPedidoRCA;
                ClienteECommerce.Bairro = Cliente.Bairroent;
                ClienteECommerce.Celular = Cliente.Telcelent;
                ClienteECommerce.Cep = Cliente.Cepent;
                ClienteECommerce.Cidade = Cliente.Municent;
                ClienteECommerce.Cnpj_Cpf = Cliente.Cgcent;
                ClienteECommerce.Codcli = Cliente.Codcli;
                ClienteECommerce.Codramoatividade = Cliente.Codatv1;
                ClienteECommerce.Email = Cliente.Email;
                ClienteECommerce.Endereco = Cliente.Enderent;
                ClienteECommerce.Estado = Cliente.Estent;
                ClienteECommerce.Fax = Cliente.Faxcli;
                ClienteECommerce.Ie = string.IsNullOrEmpty(Cliente.Iest) ? "ISENTO" : Cliente.Iest;
                ClienteECommerce.Nome = Cliente.Cliente;
                ClienteECommerce.Numero = Cliente.Numeroent;
                ClienteECommerce.Telefone = Cliente.Telent;
                ClienteECommerce.Tipopessoa = Biblioteca.Tools.Numbers.OnlyNumbers(Cliente.Cgcent).Length >= 14 ? "J" : "F";
                ClienteECommerce.Tipopessoa = string.IsNullOrEmpty(ClienteECommerce.Tipopessoa) ? "F" : ClienteECommerce.Tipopessoa;
                //string.IsNullOrEmpty(Cliente.Tipofj) ? "J" : Cliente.Tipofj;
                ClienteECommerce.Vlparcelas = ValorParcela;
                ClienteECommerce.Vlpedido = ValorPedido;
                ClienteECommerce.Gravar();
            }
        }

        public bool ClienteGravar()
        {
            bool resultado = false;
            try
            {
                ClienteAntesGravar();

                Persistencia ba = new Persistencia(PCConsum.GetStringConnection());

                if (ClienteJaExiste)
                {
                    ba.Alterar(Cliente);
                }
                else
                {
                    Cliente.Dtinclusao = Cliente.DataHoraServidor();
                    Cliente.Dtcadastro = Cliente.DataHoraServidor();
                    ba.Inserir(Cliente);
                }

                ClienteAposGravar();

                resultado = true;
            }
            catch (Exception erro)
            {
                resultado = false;
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "ClienteGravar", erro);
            }

            return resultado;
        }

        private void ClienteAntesGravar()
        {
            try
            {
                if (Cliente.Codcli <= 0)
                {
                    Cliente.Codcli = Cliente.Proximo("PCCONSUM", "PROXNUMCLI");
                }

                if (!string.IsNullOrEmpty(Cliente.Cepent)) //((!ClienteJaExiste) && 
                {//Obtendo o dados do CEP do cliente
                    ZipCodeInfo CEP = Integradora.CEP.Consultar.ObterEndereco(Cliente.Cepent);
                    PCCidade cidade = null;
                    if (CEP != null)
                    {
                        try
                        {
                            cidade = PCCidade.Listar("CODIBGE = " + CEP.Ibge.ToString() + " AND ROWNUM = 1").Single();
                        }
                        catch
                        {
                            cidade = null;
                        }

                        if (cidade != null)
                        {
                            Cliente.Codcidade = cidade.Codcidade;
                            Cliente.Municent = cidade.Nomecidade;
                            if (Cliente.Estent != cidade.Uf)
                            {
                                Cliente.Estent = cidade.Uf;
                                Cliente.Codpraca = 0; //Para força a busca da praça correta
                            }
                        }
                        else
                        {
                            //Incluida esta condição para quando não localizar a cidade pelo codigo IBGE fazer a pesquisa por nome e uf da cidade do cliente
                            //11/07/2017 - Eduardo Estevão
                            try
                            {
                                cidade = PCCidade.Listar(string.Format("NOMECIDADE = '{0}' AND UF = '{1}' AND ROWNUM = 1", Cliente.Municent.ToUpper(), Cliente.Estent.ToUpper())).Single();
                            }
                            catch
                            {
                                cidade = null;
                            }

                            if (cidade == null)
                            {
                                try 
                                { 
                                    cidade = PCCidade.Listar(string.Format("NOMECIDADE = '{0}' AND UF = '{1}' AND ROWNUM = 1", CEP.City.ToUpper(), CEP.Uf.ToUpper())).Single();
                                }
                                catch (Exception erro)
                                { 
                                    cidade = null;
                                }
                                
                            }

                            if (cidade != null)
                            {
                                Cliente.Codcidade = cidade.Codcidade;
                                Cliente.Municent  = cidade.Nomecidade;
                            }
                            else
                            {
                                Cliente.Municent = CEP.City;
                            }
                            
                            //fim - 11/07/2017 - Eduardo Estevão

                            if (Cliente.Estent != CEP.Uf)
                            {
                                Cliente.Estent = CEP.Uf;
                                Cliente.Codpraca = 0; //Para força a busca da praça correta
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            cidade = PCCidade.Listar(string.Format("NOMECIDADE = '{0}' AND UF = '{1}' AND ROWNUM = 1", Cliente.Municent.ToUpper(), Cliente.Estent.ToUpper())).Single();
                            Cliente.Codcidade = cidade.Codcidade;
                            Cliente.Municent = cidade.Nomecidade;
                            if (Cliente.Estent != cidade.Uf)
                            {
                                Cliente.Estent = cidade.Uf;
                                Cliente.Codpraca = 0; //Para força a busca da praça correta
                            }
                        }
                        catch
                        {
                            cidade = null;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(Cliente.Enderent))
                {
                    Cliente.Enderent = Cliente.Enderent.Replace("'", "´");
                }

                if (!string.IsNullOrEmpty(Cliente.Bairroent))
                {
                    Cliente.Bairroent = Cliente.Bairroent.Replace("'", "´");
                }
                if (!string.IsNullOrEmpty(Cliente.Complementoent))
                {
                    Cliente.Complementoent = Cliente.Complementoent.Replace("'", "´");
                }
                if (string.IsNullOrEmpty(Cliente.Endercob))
                {
                    Cliente.Endercob = Cliente.Enderent;
                    Cliente.Cepcob = Cliente.Cepent;
                    Cliente.Numerocob = Cliente.Numeroent;
                    Cliente.Municcob = Cliente.Municent;
                    Cliente.Complementocob = Cliente.Complementoent;
                    Cliente.Estcob = Cliente.Estent;
                    Cliente.Bairrocob = Cliente.Bairroent;
                }
                if (string.IsNullOrEmpty(Cliente.Endercom))
                {
                    Cliente.Endercom = Cliente.Enderent;
                    Cliente.Cepcom = Cliente.Cepent;
                    Cliente.Numerocom = Cliente.Numeroent;
                    Cliente.Municcom = Cliente.Municent;
                    Cliente.Complementocom = Cliente.Complementoent;
                    Cliente.Estcom = Cliente.Estent;
                    Cliente.Bairrocom = Cliente.Bairroent;
                    Cliente.Codcidadecom = Cliente.Codcidade;
                }
                if (!string.IsNullOrEmpty(Cliente.Cliente))
                {
                    cliente.Cliente = cliente.Cliente.Replace("'", "´");
                }
                if (string.IsNullOrEmpty(Cliente.Fantasia))
                {//Nome fantasia
                    Cliente.Fantasia = Cliente.Cliente;
                }
                else
                {
                    cliente.Fantasia = cliente.Fantasia.Replace("'", "´");
                }
                if (string.IsNullOrEmpty(Cliente.Emailnfe))
                {//Email
                    Cliente.Emailnfe = string.IsNullOrEmpty(Cliente.Email) ? "" : cliente.Email.ToLower();
                }
                //Tipo de pessoa, conforme o docuemnto 
                if (!string.IsNullOrEmpty(Cliente.Cgcent))
                {
                    Cliente.Tipofj = Biblioteca.Tools.Numbers.OnlyNumbers(Cliente.Cgcent).Length >= 14 ? "J" : "F";
                    Cliente.Tipofj = string.IsNullOrEmpty(Cliente.Tipofj) ? "F" : Cliente.Tipofj;
                }
                else
                {
                    Cliente.Tipofj = "F";
                }

                if (Cliente.Codpraca == 0)
                { //Obter a praça e região
                    PCPraca Praca = null;
                    try
                    {
                        ESVEstado_praca EstadoPraca = ESVEstado_praca.Listar(string.Format("UF = '{0}'", cliente.Estent.ToUpper())).Single();
                        Cliente.Codpraca = EstadoPraca.Codpraca;
                        Cliente.Numregiaocli = EstadoPraca.Numregiao;

                    }
                    catch
                    {
                        try
                        {
                            Praca = PCPraca.Listar(string.Format(@"  NVL(SITUACAO,'A') = 'A' 
                                                             AND PRACA IN (SELECT ESTADO
                                                                             FROM PCESTADO
                                                                            WHERE UF = '{0}') 
                                                             AND ROWNUM = 1", cliente.Estent)).Single();

                            Cliente.Codpraca = Praca.Codpraca;
                            Cliente.Numregiaocli = Praca.Numregiao;
                        }
                        catch
                        {
                            Cliente.Codpraca = Parametros.Codpraca;
                            Cliente.Numregiaocli = Parametros.Numregiao;
                        }
                    }
                }

                if (string.IsNullOrEmpty(Cliente.Empresa))
                {
                    Cliente.Empresa = Cliente.Cliente;
                }
                Cliente.Cgcent = Integradora.Biblioteca.Tools.Numbers.OnlyNumbers(Cliente.Cgcent);
                if (string.IsNullOrEmpty(Cliente.Cgcentrega))
                {
                    Cliente.Cgcentrega = Cliente.Cgcent;
                }
                if (Cliente.Codcliprinc <= 0)
                {
                    Cliente.Codcliprinc = Cliente.Codcli;
                }
                if (string.IsNullOrEmpty(Cliente.Ieent))
                {
                    Cliente.Ieent = "ISENTO";
                }
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "ClienteAntesGravar", erro);
            }
        }

        private void ClienteAposGravar()
        {

        }
        #endregion

        #region Endereço de cliente
        public bool EnderecoExiste(string filtro)
        {
            EnderecoJaExiste = true;
            try
            {
                Endereco = PCClientendent.Listar(filtro).Single();
            }
            catch (Exception)
            {
                Endereco = null;
            }

            EnderecoJaExiste = Endereco != null;

            return EnderecoJaExiste;
        }
        public void EnderecoInicializar()
        {
            try
            {
                Endereco = new PCClientendent();
                Endereco.Codfunccad = Parametros.Matricula;
                Endereco.Dtcad = Parametros.DataServidor();
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "EnderecoInicializar", erro);
            }
        }

        public bool EnderecoGravar()
        {
            bool resultado = false;
            try
            {
                EnderecoAntesGravar();

                Persistencia ba = new Persistencia(PCConsum.GetStringConnection());

                if (EnderecoJaExiste)
                {
                    ba.Alterar(Endereco);
                }
                else
                {
                    ba.Inserir(Endereco);
                }

                EnderecoAposGravar();

                resultado = true;
            }
            catch (Exception erro)
            {
                resultado = false;
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "EnderecoGravar", erro);
            }

            return resultado;
        }

        private void EnderecoAposGravar()
        {
        }

        private void EnderecoAntesGravar()
        {
            Endereco.Codfuncultalter = Parametros.Matricula;
            Endereco.Dtultalter = Parametros.DataServidor();

            if ((!EnderecoJaExiste) && (Endereco.Cepent != ""))
            {//Obtendo o dados do CEP do cliente
                ZipCodeInfo CEP = Integradora.CEP.Consultar.ObterEndereco(Endereco.Cepent);
                if (CEP != null)
                {
                    PCCidade cidade = null;
                    try
                    {
                        cidade = PCCidade.Listar("CODIBGE = " + CEP.Ibge.ToString()).Single();
                    }
                    catch
                    {
                        cidade = null;
                    }

                    if (cidade != null)
                    {
                        Endereco.Codcidade = cidade.Codcidade;
                        Endereco.Municent = cidade.Nomecidade;
                        Endereco.Estent = cidade.Uf;
                    }
                    else
                    {
                        Endereco.Municent = CEP.City;
                        Endereco.Estent = CEP.Uf;
                    }
                }
            }
        }
        #endregion

        #region Métodos para o produto
        public bool ProdutoExiste(string CodigoProduto)
        {
            bool value = false;
            try
            {
                value = PCProdut.Existe("CODPROD = " + CodigoProduto);
            }
            catch (Exception erro)
            {
                value = false;
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "ProdutoExiste", erro);
            }
            return value;
        }


        public PCProdut ObterTabelaProduto(string CodigoEmbalagem, string CodFilial)
        {
            try
            {
                return PCProdut.Listar(string.Format("CODPROD IN (SELECT CODPROD FROM PCEMBALAGEM WHERE CODAUXILIAR = {0} AND CODFILIAL = '{1}')"
                                                     , CodigoEmbalagem
                                                     , CodFilial)).FirstOrDefault();
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "EmbalagemExiste", erro);
                return null;
            }
        }

        #endregion


        public bool GerarAutorizacaoLimiteProdutoPCTABPR(PCPeditemp item)
        {
            bool retorno = true;
            string filtro = String.Format("CODPROD = {0} AND NUMREGIAO in (SELECT NUMREGIAOPADRAO FROM PCFILIAL WHERE CODIGO = '{1}')"
                                                 , item.Codprod.ToString()
                                                 , cabecalho.Codfilial);
            try
            {
                PCTabpr tabelaPreco = PCTabpr.Listar(filtro).Single();

                if (item.Perdesc > 0)
                {
                    PCAutori autorizacao = new PCAutori();
                    autorizacao.Codcli = Cabecalho.Codcli;
                    autorizacao.Codfilial = Cabecalho.Codfilial;
                    autorizacao.Codfunccadastro = Parametros.Matricula;
                    autorizacao.Codplpag = Cabecalho.Codplpag;
                    autorizacao.Codprod = item.Codprod;
                    autorizacao.Codusur = cabecalho.Codusur;
                    autorizacao.Dataautorizacao = Cabecalho.Dtinclusao.Date;
                    autorizacao.Numregiao = tabelaPreco.Numregiao;
                    autorizacao.Percdescautor = item.Perdesc; //percentualDesconto;
                    autorizacao.Pvendaatual = item.Ptabela; // tabelaPreco.Pvenda1;
                    autorizacao.Pvendido = item.Pvenda;
                    autorizacao.Codauxiliar = item.Codauxiliar;
                    autorizacao.Statusutiliz = "N";
                    autorizacao.Geradebrca = "S";
                    autorizacao.Afetaperdesc = "N";
                    autorizacao.Apenasplpagmax = "S";
                    autorizacao.Excedecota = "N";
                    autorizacao.Nrautorizacao = autorizacao.Proximo("PCAUTORI_SEQ");

                    Persistencia ba = new Persistencia(PCAutori.GetStringConnection());
                    retorno = ba.Inserir(autorizacao);
                }
            }
            catch (Exception ex)
            {
                retorno = false;
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb"
                             , "GerarAutorizacaoLimiteProdutoPCTABPR"
                             , string.Format("Não foi localizado tabela de preço: {0} - Filtro: {1}", ex.ToString(), filtro)
                             );
            }
            return retorno;
        }

        public bool GerarAutorizacaoLimiteProdutoPCEMBALAGEM(PCPeditemp item)
        {
            bool retorno = true;
            string filtro = String.Format("CODPROD = {0} AND CODFILIAL = '{1}' AND CODAUXILIAR = {2}"
                                                , item.Codprod.ToString()
                                                , cabecalho.Codfilial
                                                , item.Codauxiliar.ToString());
            try
            {

                PCEmbalagem embalagem = PCEmbalagem.Listar(filtro).Single();

                decimal precoTabela = 0;
                if (embalagem.Pvendaweb > 0)
                {
                    precoTabela = embalagem.Pvendaweb.Value;
                }
                if (precoTabela == 0)
                {
                    precoTabela = embalagem.Pvenda.Value;
                }

                precoTabela = precoTabela / embalagem.Qtunit.Value;
                decimal percentualDesconto = (1 - ((item.Pvenda / embalagem.Qtunit.Value) / (precoTabela))) * 100;

                if (percentualDesconto > 0)
                {
                    PCAutori autorizacao = new PCAutori();
                    autorizacao.Codcli = Cabecalho.Codcli;
                    autorizacao.Codfilial = Cabecalho.Codfilial;
                    autorizacao.Codfunccadastro = Parametros.Matricula;
                    autorizacao.Codplpag = Cabecalho.Codplpag;
                    autorizacao.Codprod = item.Codprod;
                    autorizacao.Codusur = cabecalho.Codusur;
                    autorizacao.Dataautorizacao = Cabecalho.Dtinclusao.Date;
                    //autorizacao.Numregiao = tabelaPreco.Numregiao;
                    autorizacao.Percdescautor = percentualDesconto;
                    autorizacao.Pvendaatual = precoTabela;
                    autorizacao.Pvendido = item.Ptabela / embalagem.Qtunit.Value;
                    autorizacao.Codauxiliar = item.Codauxiliar;
                    autorizacao.Statusutiliz = "N";
                    autorizacao.Geradebrca = "S";
                    autorizacao.Afetaperdesc = "N";
                    autorizacao.Apenasplpagmax = "S";
                    autorizacao.Excedecota = "N";
                    autorizacao.Nrautorizacao = autorizacao.Proximo("PCAUTORI_SEQ");

                    Persistencia ba = new Persistencia(PCAutori.GetStringConnection());
                    retorno = ba.Inserir(autorizacao);
                }
            }
            catch (Exception ex)
            {
                retorno = false;
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb"
                             , "GerarAutorizacaoLimiteProdutoPCEMBALAGEM"
                             , string.Format("Não foi localizado tabela de preço: {0} - Filtro: {1}", ex.ToString(), filtro));
            }
            return retorno;
        }

        public bool GerarAutorizacaoLimite()
        {
            bool resultado = false;

            decimal valorSaldo = 0;
            decimal valorLancamento = TotaldoPedido();


            if (valorLancamento > 0)
            {
                //Lançar crédito
                if ((CreditoCliente == null) && (Cabecalho.Codcli > 0))
                {
                    valorSaldo = AnalisarSaldoPedidosAberto(Cabecalho.Codcli);

                    //Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "GerarCreditoCliente", "Valor lancamento: " + valorLancamento.ToString() + " Valor Saldo: " + valorSaldo.ToString());
                    valorLancamento += valorSaldo;
                    try
                    {
                        CreditoCliente = new PCAutorc();
                        CreditoCliente.Numpedido = CreditoCliente.Proximo("DFSEQ_PCAUTORC");
                        CreditoCliente.Codcli = Cabecalho.Codcli;
                        CreditoCliente.Codusur = Cabecalho.Codusur;
                        CreditoCliente.Codfunc = Cabecalho.Codemitente;
                        CreditoCliente.Condvenda = Cabecalho.Condvenda;
                        CreditoCliente.Codplpag = Cabecalho.Codplpag;
                        CreditoCliente.Data = CreditoCliente.DataServidor();
                        CreditoCliente.Liberalimcred = "S";
                        CreditoCliente.Origemped = "W";
                        CreditoCliente.Vlliberado = valorLancamento;
                        CreditoCliente.Limcred = 0;
                        CreditoCliente.Codfuncutilizacao = null;
                        CreditoCliente.Obs = "Pedido gerador: " + Cabecalho.Numpedcli;

                        Persistencia ba = new Persistencia(PCConsum.GetStringConnection());
                        ba.Inserir(CreditoCliente);

                        resultado = true;
                    }
                    catch (Exception erro)
                    {
                        resultado = false;
                        Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "GerarCreditoCliente", erro);
                    }
                }
            }
            else
            {
                Logs.GerarLog("Integradora.ERP.Winthor.Domain.PedidoWeb", "GerarCreditoCliente", "Total do pedido zerado!");
            }
            return resultado;
        }

        private decimal AnalisarSaldoPedidosAberto(decimal CodigoCliente)
        {
            decimal valor = 0;
            if (CodigoCliente > 0)
            {
                try
                {
                    Persistencia ba = new Persistencia(PCConsum.GetStringConnection());
                    valor += ba.GetValorCampoDecimal(@" SELECT NVL((SELECT SUM(NVL(PCPREST.VALOR, 0)) VALOR
                                                      FROM PCPREST
                                                     WHERE PCPREST.DTPAG IS NULL
                                                       AND PCPREST.CODCOB NOT IN ('BNF','BNFT','BNTR','BNFR','BNRP')   
                                                       AND PCPREST.CODCLI = " + CodigoCliente.ToString() + "),0) + " +
                                                     @"NVL((SELECT SUM(NVL(VLATEND, 0)) VALOR
                                                      FROM PCPEDC
                                                     WHERE DTCANCEL IS NULL
                                                       AND POSICAO  IN ('L', 'M')
                                                       AND CODCOB NOT IN ('BNF','BNFT','BNTR','BNFR','BNRP')
                                                       AND CODCLI   = " + CodigoCliente.ToString() + "),0) AS VALOR FROM DUAL");
                }
                catch
                {
                    valor = 0;
                }
            }

            return valor;
        }

        public void MovimentacaoFinanceiraBoleto(decimal Numped)
        {

            if (CobrancaPorBoleto())
            {
                decimal valorLancamento = TotaldoPedido();
                decimal CodigoBanco = cobranca.Codbanco;
                if (CodigoBanco <= 0)
                {
                    CodigoBanco = Integradora.Biblioteca.Dictionaries.Settings.CodBanco();
                }

                //Lançar movimentação de COBs
                MovimentarCaixa caixa = new MovimentarCaixa();
                int codContaGerencial = Convert.ToInt32(PCConsum.Listar().Single().Codcontcli);

                caixa.LancarCreditoCliente(Cabecalho.Codcli, Cabecalho.Codfilial, valorLancamento, Numped);

                caixa.LancarMovimento(Tips.OperacaoFinanceira.Debito,
                                     valorLancamento,
                                     codContaGerencial,
                                     CodigoBanco,
                                     "Compra via web, pedido web " + Cabecalho.Numpedcli,
                                     "",
                                     Numped.ToString());
            }
        }

        private decimal TotaldoPedido()
        {
            decimal valorLancamento = 0;

            foreach (var item in Itens)
            {
                valorLancamento += item.Pvenda * item.Qt;
            }
            valorLancamento += cabecalho.Vlfrete;

            return valorLancamento;
        }
    }
}


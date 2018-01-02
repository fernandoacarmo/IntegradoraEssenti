using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Integradora.Biblioteca.Dictionaries
{
    public sealed class Settings
    {
        #region Coletores

        private static void SalvarParametro(string parametro, string valor)
        {
            // Get the current configuration file.
            System.Configuration.Configuration config =
                    ConfigurationManager.OpenExeConfiguration(
                    ConfigurationUserLevel.None);

            config.AppSettings.Settings[parametro].Value = valor;
            config.Save(ConfigurationSaveMode.Full);
        }

        private static string ObterParametro(string parametro)
        {
            string strParametro = "";

            var resultado = System.Configuration.ConfigurationManager.AppSettings[parametro];
            if (resultado != null)
            {
                strParametro = resultado.ToString();
            }

            return strParametro;
        }
        private static int ObterParametro(string parametro, int valorDefault)
        {
            int intParametro = 0;
            string strParametro = ObterParametro(parametro);

            intParametro = Tools.Numbers.ToInt32(strParametro);

            return intParametro == 0 ? valorDefault : intParametro;
        }
        private static string ObterConnectionString(string parametro)
        {
            string resultado = ObterParametro(parametro);
            if (resultado.Contains("Data Source"))
            {
                //  SalvarParametro(parametro, Tools.MD5.Criptografar(resultado));
            }
            else
            {
                resultado = Tools.MD5.Descriptografar(resultado);
            }
            return resultado;
        }
        private static string ObterParametroFBits(string parametro)
        {
            string url = ObterParametro(parametro).ToLower();
            url = string.Format(url, FBits_Empresa());
            return url.ToLower();
        }
        private static string ObterParametroVTex(string parametro)
        {
            string url = ObterParametro(parametro).ToLower();
            url = string.Format(url, VTex_Empresa());
            return url.ToLower();
        }
        #endregion

        #region Parâmetros geração de pedidos

        public static bool Debugando()
        {
            bool retorno = (ObterParametro("Debugando") == "S");
            return retorno;
        }
        public static int NumeroTentativaImportarPedido()
        {
            return ObterParametro("NumeroTentativaImportarPedido", 5);
        }
        public static int ModeloIntegracaoCodigo()
        {
            return ObterParametro("ModeloIntegracao", 4);
        }
        public static Tips.Modelo ModeloIntegracao()
        {
            return (Tips.Modelo)ModeloIntegracaoCodigo();
        }
        public static int QuantidadeRegistroEnviar()
        {
            return ObterParametro("QuantidadeRegistroEnviar", 50);
        }
        public static int IntervaloSegundos()
        {
            return ObterParametro("IntervaloSegundos", 60000);
        }
        public static string CodFilialVenda()
        {
            return ObterParametro("CodFilialVenda");
        }
        public static string CodFilialRetira()
        {
            return ObterParametro("CodFilialRetira");
        }
        public static string NumRegiaoOferta()
        {
            return ObterParametro("NumRegiaoOferta");
        }

        public static decimal? ContaGerencialEntrada()
        {
            return ObterParametro("ContaGerencialEntrada", 101001);
        }
        public static int CodPlanoPagamento()
        {
            return ObterParametro("CodPlanoPagamento", 4);
        }
        public static int CodPraca()
        {
            return ObterParametro("CodPraca", 1);
        }
        public static int CodRCA()
        {
            return ObterParametro("CodRCA", 1);
        }
        public static int CodFornecedor()
        {
            return ObterParametro("CodFornecedor", 1);
        }
        public static int CodDepartamento()
        {
            return ObterParametro("CodDepartamento", 1);
        }
        public static int CodSecao()
        {
            return ObterParametro("CodSecao", 1);
        }
        public static int CodBanco()
        {
            return ObterParametro("CodBanco", 1);
        }
        public static string CodCobranca()
        {
            return ObterParametro("CodCobranca");
        }
        public static string CodCobrancaMovimentoCaixa()
        {
            return ObterParametro("CodCobrancaMovimentoCaixa");
        }
        public static int CodSupervisor()
        {
            return ObterParametro("CodSupervisor", 1);
        }
        public static int Matricula()
        {
            return ObterParametro("Matricula", 1);
        }
        public static int ContaGerencialReceitaDeCredito()
        {
            return ObterParametro("ContaGerencialReceitaDeCredito", 1);
        }
        public static int Rotina()
        {
            return 9898;
        }
        public static int CodRamoAtividade()
        {
            return ObterParametro("CodRamoAtividade", 1);
        }
        public static string EmailEnvio()
        {
            return ObterParametro("EmailEnvio");
        }
        public static string EmailErro()
        {
            return ObterParametro("EmailErro");
        }
        public static string EmailErroFinanceiro()
        {
            return ObterParametro("EmailErroFinanceiro");
        }
        public static string EmailSenha()
        {
            return ObterParametro("EmailSenha");
        }
        public static string EmailSMTP()
        {
            return ObterParametro("EmailSMTP");
        }
        public static string Winthor_Conexao()
        {
            return ObterConnectionString("Winthor_Conexao");
        }
        public static string Winthor_Usuario()
        {
            return ObterParametro("Winthor_Usuario");
        }
        public static string Winthor_Servidor()
        {
            return ObterParametro("Winthor_Servidor");
        }
        public static string Winthor_ArquivoINI()
        {
            return ObterParametro("Winthor_ArquivoINI");
        }
        public static decimal CodMotivoBloqueioAguardaPagto()
        {
            return ObterParametro("CodMotivoBloqueioAguardaPagto", 0);
        }
        public static decimal CodMotivoBloqueioPagtoAprovado()
        {
            return ObterParametro("CodMotivoBloqueioPagtoAprovado", 0);
        }

        public static string ContaContabilCliente()
        {
            return ObterParametro("ContaContabilCliente");
        }
        #endregion

        #region Parâmetros UseAll
        public static string UseAll_Webservice()
        {
            return ObterParametro("UseAll_Webservice");
        }
        public static string UseAll_Conexao()
        {
            string resultado = ObterConnectionString("UseAll_Conexao");

            return resultado;
        }
        #endregion

        #region Parâmetros VTiger
        public static string VTiger_Login()
        {
            return ObterParametro("VTiger_Login");
        }
        public static string VTiger_Token()
        {
            return ObterParametro("VTiger_Token");
        }
        public static string VTiger_URL()
        {
            return ObterParametro("VTiger_URL");
        }
        #endregion

        #region Parâmetros VTex
        public static string VTex_Empresa()
        {
            return ObterParametro("VTex_Empresa");
        }
        public static int VTex_NumeroPedidos()
        {
            return ObterParametro("VTex_NumeroPedidos", 15);
        }

        public static string VTex_UrlAPI()
        {
            return ObterParametroVTex("VTex_UrlAPI");
        }
        public static string VTex_Username()
        {
            return ObterParametro("VTex_Username");
        }
        public static string VTex_Password()
        {
            return ObterParametro("VTex_Password");
        }
        public static string VTex_AppKey()
        {
            return ObterParametro("VTex_AppKey");
        }
        public static string VTex_AppToken()
        {
            return ObterParametro("VTex_AppToken");
        }
        #endregion

        #region Parâmetros FBits
        public static string FBits_Empresa()
        {
            return ObterParametro("FBits_Empresa").ToLower();
        }
        public static string FBits_Token()
        {
            return ObterParametro("FBits_Token");
        }
        public static string FBits_SyncPedidoVenda()
        {
            return ObterParametroFBits("FBits_SyncPedidoVenda");
        }
        public static string FBits_SyncCategoria()
        {
            return ObterParametroFBits("FBits_SyncCategoria");
        }
        public static string FBits_SyncEstoque()
        {
            return ObterParametroFBits("FBits_SyncEstoque");
        }
        public static string FBits_SyncContaCorrente()
        {
            return ObterParametroFBits("FBits_SyncContaCorrente");
        }
        public static string FBits_SyncPedidoStatus()
        {
            return ObterParametroFBits("FBits_SyncPedidoStatus");
        }
        public static string FBits_SyncProduto()
        {
            return ObterParametroFBits("FBits_SyncProduto");
        }
        public static string FBits_SyncProdutoCategoria()
        {
            return ObterParametroFBits("FBits_SyncProdutoCategoria");
        }
        public static string FBits_SyncProdutoCombo()
        {
            return ObterParametroFBits("FBits_SyncProdutoCombo");
        }
        public static string FBits_SyncProdutoEstoque()
        {
            return ObterParametroFBits("FBits_SyncProdutoEstoque");
        }
        public static string FBits_SyncProdutoFornecedor()
        {
            return ObterParametroFBits("FBits_SyncProdutoFornecedor");
        }
        public static string FBits_SyncProdutoImagem()
        {
            return ObterParametroFBits("FBits_SyncProdutoImagem");
        }
        public static string FBits_SyncProdutoPreco()
        {
            return ObterParametroFBits("FBits_SyncProdutoPreco");
        }
        public static string FBits_SyncUsuario()
        {
            return ObterParametroFBits("FBits_SyncUsuario");
        }
        public static string FBits_SyncUsuarioEndereco()
        {
            return ObterParametroFBits("FBits_SyncUsuarioEndereco");
        }
        #endregion

        #region MagentoComum

        public static string MagentoGrupoAtributo()
        {
            return ObterParametro("MagentoGrupoAtributo");
        }
        public static string MagentoStatusPagamentoAguardando()
        {
            return ObterParametro("MagentoStatusPagamentoAguardando");
        }
        public static string MagentoStatusPagamentoRejeitado()
        {
            return ObterParametro("MagentoStatusPagamentoRejeitado");
        }
        public static string MagentoStatusPagamentoAprovado()
        {
            return ObterParametro("MagentoStatusPagamentoAprovado");
        }

        public static string MagentoStatusPedido_pesquisa()
        {
            return ObterParametro("MagentoStatusPedido_pesquisa");
        }
        public static string MagentoStatusPedido_pendentepagamento()
        {
            return ObterParametro("MagentoStatusPedido_pendentepagamento");
        }
        public static string MagentoStatusPedido_importado()
        {
            return ObterParametro("MagentoStatusPedido_importado");
        }
        #endregion

        #region Parâmetros Magento001
        public static string Magento001_Url()
        {
            return ObterParametro("Magento001_Url");
        }
        public static string Magento001_Username()
        {
            return ObterParametro("Magento001_Username");
        }
        public static string Magento001_Password()
        {
            return ObterParametro("Magento001_Password");
        }
        #endregion

        #region Parâmetros Magento002
        public static string Magento002_Url()
        {
            return ObterParametro("Magento002_Url");
        }
        public static string Magento002_Username()
        {
            return ObterParametro("Magento002_Username");
        }
        public static string Magento002_Password()
        {
            return ObterParametro("Magento002_Password");
        }
        #endregion

        #region Parâmetros Corpem
        public static string Corpem_Conexao()
        {
            string resultado = ObterConnectionString("Corpem_Conexao");

            return resultado;
        }
        public static string Corpem_URL()
        {
            return ObterParametro("Corpem_URL");
        }
        #endregion

        #region Parâmetros Virtuemart
        public static string Virtuemart_URL()
        {
            return ObterParametro("Virtuemart_URL");
        }
        public static string Virtuemart_Username()
        {
            return ObterParametro("Virtuemart_Username");
        }
        public static string Virtuemart_Password()
        {
            return ObterParametro("Virtuemart_Password");
        }
        #endregion

        #region Parâmetros ZoOmBox
        public static string ZoOmBox_URLVendas()
        {
            return ObterParametro("ZoOmBox_URLVendas");
        }
        public static string ZoOmBox_URLFilial()
        {
            return ObterParametro("ZoOmBox_URLFilial");
        }
        public static string ZoOmBox_URLGerenciaVenda()
        {
            return ObterParametro("ZoOmBox_URLGerenciaVenda");
        }
        #endregion

        #region Parâmetros DataHub
        public static string DataHub_UrlAPI()
        {
            return ObterParametro("DataHub_UrlAPI");
        }
        public static string DataHub_Username()
        {
            return ObterParametro("DataHub_Username");
        }
        public static string DataHub_Password()
        {
            return ObterParametro("DataHub_Password");
        }
        public static string DataHub_Alimentos()
        {
            return ObterParametro("DataHub_Alimentos");
        }
        public static string DataHub_Supermercados()
        {
            return ObterParametro("DataHub_Supermercados");
        }
        #endregion

        #region Parâmetros FTP
        public static string FTPEndereco()
        {
            return ObterParametro("FTPEndereco");
        }
        public static string FTPUsuario()
        {
            return ObterParametro("FTPUsuario");
        }
        public static string FTPSenha()
        {
            return ObterParametro("FTPSenha");
        }
        public static string FTPPassivo()
        {
            return ObterParametro("FTPPassivo");
        }
        public static string FTPDadosBinario()
        {
            return ObterParametro("FTPDadosBinario");
        }
        #endregion

        #region Parâmetros Sigep
        public static string Sigep_UrlTeste()
        {
            return ObterParametro("Sigep_UrlTeste");
        }
        public static string Sigep_UrlProducao()
        {
            return ObterParametro("Sigep_UrlProducao");
        }
        public static string Sigep_Usuario()
        {
            return ObterParametro("Sigep_Usuario");
        }
        public static string Sigep_Senha()
        {
            return ObterParametro("Sigep_Senha");
        }
        public static string Sigep_Codigoadministrativo()
        {
            return ObterParametro("Sigep_Codigoadministrativo");
        }
        public static string Sigep_Contrato()
        {
            return ObterParametro("Sigep_Contrato");
        }
        public static int Sigep_CodigoServico()
        {
            return ObterParametro("Sigep_CodigoServico", 0);
        }
        public static string Sigep_Cartao()
        {
            return ObterParametro("Sigep_Cartao");
        }
        #endregion

        #region Protheus
        public static string Protheus_Filial()
        {
            return ObterParametro("Protheus_Filial");
        }

        #endregion

        #region Ajuri
        public static string AjuriURL_Pedidos()
        {
            return ObterParametro("AjuriURL_Pedidos");
        }

        public static string AjuriURL_Entradas()
        {
            return ObterParametro("AjuriURL_Entradas");
        }

        public static string AjuriURL_Transferencia()
        {
            return ObterParametro("AjuriURL_Transferencia");
        }
        #endregion

        #region Tray
        public static string Tray_ConsumerKey()
        {
            return ObterParametro("Tray_ConsumerKey");
        }
        public static string Tray_ConsumerSecret()
        {
            return ObterParametro("Tray_ConsumerSecret");
        }
        public static string Tray_Code()
        {
            return ObterParametro("Tray_Code");
        }
        public static string Tray_URL()
        {
            return ObterParametro("Tray_URL");
        }
        #endregion

        public static string MagentoStatusPagamentoRecusado()
        {
            return ObterParametro("MagentoStatusPagamentoRecusado");
        }

        public static string ManutencaoBancoDados()
        {
            return ObterParametro("ManutencaoBancoDados");
        }

        public static string ValidarClienteJuridico()
        {
            return ObterParametro("ValidarClienteJuridico");
        }

        public static string Administrador()
        {
            return ObterParametro("Administrador");
        }

        public static string OnLineUrl()
        {
            return ObterParametro("OnLineUrl");
        }

        #region Shoppub
        public static string ShoppubURL()
        {
            return ObterParametro("Shoppub_URL");
        }
        public static string ShoppubToken()
        {
            return ObterParametro("Shoppub_Token");
        }
        #endregion

        #region IShopping
        public static string IShoppingURL()
        {
            return ObterParametro("IShopping_URL");
        }
        public static string IShoppingCliente()
        {
            return ObterParametro("IShopping_Cliente");
        }
        public static string IShoppingChaveAcesso()
        {
            return ObterParametro("IShopping_ChaveAcesso");
        }
        #endregion

        #region Adena
        public static string AdenaURL()
        {
            return ObterParametro("Adena_URL");
        }
        public static string AdenaToken()
        {
            return ObterParametro("Adena_Token");
        }

        public static string AdenaUsuario()
        {
            return ObterParametro("Adena_Usuario");
        }

        public static string AdenaSenha()
        {
            return ObterParametro("Adena_Senha");
        }
        
        #endregion
    }
}

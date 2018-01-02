using Integradora.Biblioteca.Dictionaries;
using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Licenca;
using Integradora.Servico.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Integradora.Servico
{
    /// <summary>
    /// Classe executor do serviço de integração
    /// </summary>
    public partial class Executor : ServiceBase
    {
        Timer relogio;
        List<IIntegration> ListaIntegradora;
        Tips.ClientePC codigoclientepc;
        /// <summary>
        /// Executa a integração conforme parâmetros, com loop infinito
        /// </summary>
        public Executor()
        {
            Logs.Notify("Executando!");
            InitializeComponent();
            //Validar se existe licença de uso da integradora
            if (ValidarLicencaDeUso())
            {
                //Obtendo a lista de integradora
                Logs.Notify("Obtendo a lista de serviço a ser executado!");
                ObterListaIntegradora(Integradora.Biblioteca.Dictionaries.Settings.ModeloIntegracao());
                //Caso tenha integradora a processar, inicia o relógio
                if (ListaIntegradora.Count > 0)
                {
                    Logs.Notify("Iniciando o contador de execução!");

                    relogio = new System.Threading.Timer(new TimerCallback(relogio_Tick)
                                                           , null
                                                           , Timeout.Infinite
                                                           , Intervalo());
                }
                else
                {
                    Logs.Notify("Integradora não informada!");
                }
            }
        }

        /// <summary>
        /// Executa a integração conforme parâmetro, com loop finitio
        /// </summary>
        /// <param name="quantidadeExecucao"></param>
        /// <param name="modelo"></param>
        public Executor(int quantidadeExecucao, Tips.Modelo modelo)
        {
            Logs.Notify("Executando!");
            if (modelo == 0)
            {//Obtendo o modelo da integradora, que foi configurando no arquivo de configuração
                modelo = Integradora.Biblioteca.Dictionaries.Settings.ModeloIntegracao();
            }
            //Obtendo lista de integradoras
            ObterListaIntegradora(modelo);
            //Executando integradoras
            ExecutarIntegradora();
        }

        /// <summary>
        /// Executando todas as integradoras listas
        /// </summary>
        /// <returns></returns>
        private void ExecutarIntegradora()
        {//Verificando se a lista foi criado
            if (ListaIntegradora != null)
            {//Verificando se tem registros
                if (ListaIntegradora.Count > 0)
                {//Procesasando uma por uma
                    foreach (var item in ListaIntegradora)
                    {//Executando
                        item.Execute();
                    }
                }
            }
        }

        /// <summary>
        /// Validar permissão de uso da integradora
        /// </summary>
        /// <returns></returns>
        private bool ValidarLicencaDeUso()
        {
            RespostaLicenciamento permiteUtilizarIntegradora = new RespostaLicenciamento();
            //Verificando o modelo de integração se existe licença de uso para o cliente parametrizado na PCCONSUM
            switch (Integradora.Biblioteca.Dictionaries.Settings.ModeloIntegracao())
            {
                case Tips.Modelo.Winthor_IShopping:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_Magento001:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_Magento002:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_UseAll:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_Virtuemart:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_VTex:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_FBits:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_Corpem:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_DataHub:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_GsGroup:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_VTiger:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_Protheus:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_OnLineShop:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_Ajuri:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_OnLineShopVTex:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_Tray:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                case Tips.Modelo.Winthor_Adena:
                    permiteUtilizarIntegradora = Integradora.Licenca.Licenciamento.ValidarClienteWinthor();
                    break;
                default:
                    permiteUtilizarIntegradora.permitido = true;
                    permiteUtilizarIntegradora.codigoClientePC = Tips.ClientePC.MinhaMaquina;
                    break;
            }

            if (!permiteUtilizarIntegradora.permitido)
            {//Sem permissão para utilizar a integradora
                Logs.Notify("Sem permissão para utilizar a integradora!");
                OnStop();
            }
            else
            {//Tem permissao para utilizar
                Logs.Notify("Validado a permissão de uso da integradora!");
                codigoclientepc = permiteUtilizarIntegradora.codigoClientePC;
            }

            return permiteUtilizarIntegradora.permitido;
        }

        /// <summary>
        /// Obtendo a integradora escolhidade
        /// </summary>
        /// <param name="modelo"></param>
        /// <returns></returns>
        private void ObterListaIntegradora(Tips.Modelo modelo)
        {
            //Verifica se a lista já foi criada
            if (ListaIntegradora == null)
            {//Criando a lista
                ListaIntegradora = new List<IIntegration>();
            }
            else
            {//Limpando a lista
                ListaIntegradora.Clear();
            }

            switch (modelo)
            {//Obtendo a integradora confomre o modelo de integração
                case Tips.Modelo.Winthor_IShopping:
                    Logs.Notify("Modelo: IShopping");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.IShopping.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_Magento001:
                    Logs.Notify("Modelo: Magento 001");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.Magento001.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_Magento002:
                    Logs.Notify("Modelo: Magento 002");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.Magento002.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_UseAll:
                    Logs.Notify("Modelo: UseAll");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.UseAll.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_Virtuemart:
                    Logs.Notify("Modelo: Virtuemart");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.Virtuemart.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_VTex:
                    Logs.Notify("Modelo: VTex");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.VTex.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_FBits:
                    Logs.Notify("Modelo: FBits");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.FBits.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_Corpem:
                    Logs.Notify("Modelo: Corpem");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.Corpem.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_VTiger:
                    Logs.Notify("Modelo: VTiger");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.VTiger.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_DataHub:
                    Logs.Notify("Modelo: DataHub");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.DataHub.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_GsGroup:
                    Logs.Notify("Modelo: GsGroup");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.GsGroup.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_Protheus:
                    Logs.Notify("Modelo: Protheus");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.Protheus.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_OnLineShop:
                    Logs.Notify("Modelo: OnLineShop");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.OnLine.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_Ajuri:
                    Logs.Notify("Modelo: Ajuri");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.Ajuri.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_OnLineShopVTex:
                    Logs.Notify("Modelo: OnLine");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.OnLine.Processo(codigoclientepc));
                    Logs.Notify("Modelo: VTex");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.VTex.Processo(codigoclientepc));
                    Logs.Notify("Modelo: Shoppub");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.Shoppub.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_Tray:
                    Logs.Notify("Modelo: Tray");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.Tray.Processo(codigoclientepc));
                    break;
                case Tips.Modelo.Winthor_Adena:
                    Logs.Notify("Modelo: Adena");
                    ListaIntegradora.Add(new Integradora.Norma.Winthor.Adena.Processo(codigoclientepc));
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Cálculando o intervalo da próxima execução
        /// </summary>
        /// <returns></returns>
        public long Intervalo()
        {
            long value;
            value = Integradora.Biblioteca.Dictionaries.Settings.IntervaloSegundos();

            if (value > 0)
            {  //Pegar a quantidade de mintuos e transforma e micro segundos
                value = value * 1000;
            }
            else
            {  //valor default
                value = 60000; 
            }

            return value;
        }

        /// <summary>
        /// Startando o serviço
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            StartService("inicializando serviço...");
            base.OnStart(args);
        }

        /// <summary>
        /// Iniciando o serviço
        /// </summary>
        /// <param name="msg"></param>
        private void StartService(string msg)
        {
            Logs.Notify(msg);
            relogio.Change(15000, Intervalo());
        }

        /// <summary>
        /// Parando o serviço
        /// </summary>
        protected override void OnStop()
        {
            StopService("serviço parado...");
            base.OnStop();
        }

        /// <summary>
        /// Parando o serviço
        /// </summary>
        /// <param name="msg"></param>
        private void StopService(string msg)
        {
            Logs.Notify(msg);
            relogio.Change(Timeout.Infinite, Intervalo());
        }

        /// <summary>
        /// Pausando serviço
        /// </summary>        
        protected override void OnPause()
        {
            StopService("serviço pausado...");
            base.OnPause();
        }

        /// <summary>
        /// Contiuando o serviço
        /// </summary>
        protected override void OnContinue()
        {
            StartService("continuando o serviço...");
            base.OnContinue();
        }

        /// <summary>
        /// Evento do relógio
        /// </summary>
        /// <param name="sender"></param>
        private void relogio_Tick(object sender)
        {
            OnPause();
            try
            {
                Logs.Notify("Processando pacote...");
                ExecutarIntegradora();
            }
            finally
            {
                OnContinue();
            }
        }
    }
}

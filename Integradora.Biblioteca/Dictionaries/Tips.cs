using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Dictionaries
{
    public class Tips
    {
        public enum ECommerce
        {
            FBits,
            IShopping,
            Magento,
            UseAll,
            Virtuemart,
            VTex,
            Corpem,
            DataHub,
            GsGroup,
            VTiger,
            OnLineShop,
            ExecutorProcedure,
            Ajuri,
            Tray,
            Shoppub,
            Adena
        }
        public enum ERP
        {
            Winthor,
            Protheus,
            Corpem
        }
        public enum Sistema
        {
            ECommerce,
            ForcaVenda,
            ERP
        }
        public enum Modelo
        {
            Winthor_Nenhum = 00,
            Winthor_Magento001 = 01,
            Winthor_UseAll = 02,
            Winthor_Virtuemart = 03,
            Winthor_VTex = 04,
            Winthor_FBits = 05,
            Winthor_Corpem = 06,
            Winthor_GsGroup = 07,
            Winthor_DataHub = 08,
            Winthor_VTiger = 09,
            Winthor_OnLineShop = 10,
            Winthor_Protheus = 11,
            Winthor_IShopping = 12,
            Winthor_Magento002 = 13,
            Winthor_Ajuri = 14,
            Winthor_OnLineShopVTex = 15,
            Winthor_Tray = 16,
            Winthor_Shoppub = 17,
            Winthor_Adena = 18
        }
        public enum SGBD
        {
            SQLServer,
            SQLite,
            MySQL,
            Oracle,
            Postgres,
            Firebird,
            Interbase,
            MSAccess,
            DBase
        }
        public enum Aplicativo
        { // TODO:  criar a utilização da versão demo
            Demonstrativo,
            Producao
        }
        public enum ReplicacaoAcao
        {
            Incluir = 0,
            Alterar = 1,
            Excluir = 2
        }

        public enum OperacaoFinanceira
        {
            Debito = 0,
            Credito = 1
        }

        public enum SimNao
        {
            Nao = 0,
            Sim = 1
        }
        public enum ClientePC
        {
            //Clientes - Codigo - Produto
            PCSistemas = 999998,
            MinhaMaquina = -2,
            //Cliente da Essenti
            FrioPecas = 1783, //VTex, Corpem e VTiger
            FrioPecas2 = 1785, //VTex, Corpem e VTiger
            Cergrand = 4979, //UseAll
            DecisaoAtacadista = 981, //FBits
            AgroShop = 4970, //Magento
            JorgeBatista = 1006, //Datahub
            LojasLivia = 1022, //GsGroup
            ClimaRio = 3851, //OnLine
            Pacaluz = 4040, //Protheus
            Inga = 3515, //Magento Modelo 1
            OMBoat = 6673, //Ajuri
            TekDistribuidora = 7156, //Tray ECommerce
            Lippaus = 7659, //Adena ECommerce
            //Cliente pessoal
            Naturalist = 2635, //Virtuamart
            Inovar = 4056, //Executar Procedure
            Machado = 2550, //Magento Modelo 2
            FlashRio = 4899 // Magento Modelo 2
        }

        public enum SemaforoPosicaoCorpem
        {
            //Winthor -> WMS
            EmProcessamentoWinthor = 00, //Enquanto o Winthor estiver trabalhando o registro
            DisponivelParaWMS = 01, //Liberando para o WMS utilizar
            AtualizadoNoWMS = 02, //Gravar ao fim da importação no WMS - Com Sucesso
            ErroAtualizacaoNoWMS = 03, //Gravar ao fim da importação no WMS - Com Erro

            //Corpem -> WMS
            EmProcessamentoWMS = 20, //Enquanto o WMS estiver trabalhando o registro
            DisponivelParaWinthor = 21, //Liberado para o Winthor utilizar
            AtualizadoNoWinthor = 22, //Gravar ao fim da importação no Winthor - Com Sucesso
            ErroAtualizacaoWinthor = 23  //Gravar ao fim da importação no Winthor - Com Erro
        }

        public enum SemaforoPosicaoOMBoat
        {
            //Ajuri --> Winthor
            RecebimentoDoAjuri = 00, //Arquivo recebido nas tabelas temporárias
            DigitacaoDadosAjuri = 01, //Em digitação, tratamento nas tabelas temporário
            DisponivelParaWinthor = 02, //Aguardando para envio das tabelas temporária para o Winthor
            ErroAtualizacaoWinthor = 03, //Erro ao enviar para o Winthor

            //Winthor --> Ajuri
            RecebimentoNoWinthor = 20, //Arquivo recebido no Winthor
            DigitacaoDadosWinthor = 21, //Em digitação no Winthor
            DisponivelParaAjuri = 22, //Aguardando para envio do Winthor para Ajuri
            ErroAtualizacaoAjuri = 23  //Erro ao enviar para o Ajuri
        }

        public enum MovimentoEstoqueOMBoat
        {
            CancelamentoNotaEntrada = 1,  //CANCELANOTAENTRADA
            CancelamentoPedidoSaida = 2,  //CENCELAPEDIDOSAIDA
            TransferenciaPrograma = 3,  //TRANSFERIRPROGRAMA
            AjustarEstoque = 4,  //AJUSTARESTOQUE
            Inventário = 5   //INVENTARIO
        }

        public enum PosicaoPedido
        {
            Todos = 0,
            Digitacao = 1,
            EmAnalise = 2,
            Aprovado = 3,
            Reprovado = 4,
            LiberadoProducao = 5,
            ProgamadaProducao = 6,
            ProduzidoTotal = 7,
            ProduzidoParcial = 8,
            Cancelado = 9,
            Finalizado = 10,
            Requisicao = 11
        }

        public static string ObterPosicaoPedido(PosicaoPedido posicao)
        {
            switch (posicao)
            {
                case PosicaoPedido.Todos: return "T";
                case PosicaoPedido.Digitacao: return "D";
                case PosicaoPedido.EmAnalise: return "E";
                case PosicaoPedido.Aprovado: return "A";
                case PosicaoPedido.Reprovado: return "R";
                case PosicaoPedido.LiberadoProducao: return "P";
                case PosicaoPedido.ProgamadaProducao: return "G";
                case PosicaoPedido.ProduzidoTotal: return "Z";
                case PosicaoPedido.ProduzidoParcial: return "L";
                case PosicaoPedido.Cancelado: return "C";
                case PosicaoPedido.Finalizado: return "F";
                case PosicaoPedido.Requisicao: return "Q";
                default: return "T";
            }
        }
    }
}

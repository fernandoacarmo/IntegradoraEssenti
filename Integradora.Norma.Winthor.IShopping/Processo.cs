using Integradora.Biblioteca.Dictionaries;
using Integradora.Biblioteca.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.IShopping
{
    public sealed class Processo : Integradora.Norma.Winthor.Processo
    {
        public Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda { get; set; }
        public Integradora.ECommerce.IShopping.Integracao LojaEcommerce { get; set; }
        public Processo(Tips.ClientePC codigoclientepc)
        {
            this.ClientePC = codigoclientepc;
        }
        protected override void Send()
        {
            try
            {
                Enviar Enviando = new Enviar();

                Enviando.Process(ClientePC);
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.IShopping.Processo", "Send", erro);
            }
        }

        protected override void Receive()
        {
            try
            {
                Receber Recebimento = new Receber();

                Recebimento.Process(ClientePC);
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.IShopping.Processo", "Receive", erro);
            }
        }

        protected override void Initialize()
        {
            PedidoForcaVenda = new Integradora.ERP.Winthor.Domain.PedidoWeb();
            LojaEcommerce = new Integradora.ECommerce.IShopping.Integracao();
            LojaEcommerce.Initialize();
        }
    }
}

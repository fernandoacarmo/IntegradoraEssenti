using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ECommerce.UseAll;
using Integradora.ECommerce.UseAll.EntityWebService;
using Integradora.Biblioteca.Tools;
using System.Threading;
using Integradora.Biblioteca.Dictionaries;

namespace Integradora.Norma.Winthor.UseAll
{
    public sealed class Processo : Integradora.Norma.Winthor.Processo
    {
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
                Logs.GerarLog("Integradora.Norma.Winthor.UseAll.Processo", "Send", erro);
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
                Logs.GerarLog("Integradora.Norma.Winthor.UseAll.Processo", "Receive", erro);
            }
        }

        protected override void Initialize()
        {
            //Send();
            //Receive();
        }
    }
}

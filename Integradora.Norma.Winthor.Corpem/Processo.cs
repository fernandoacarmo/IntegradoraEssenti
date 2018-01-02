using Integradora.Biblioteca.Dictionaries;
using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.EntityEssenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Corpem
{
    public sealed class Processo : Integradora.Norma.Winthor.Processo
    {
        public Processo(Tips.ClientePC codigoclientepc)
        {
            this.ClientePC = codigoclientepc;
        }

        protected override void Send()
        {
            ESTIntegradora.Notificar("Corpem");
            try
            {
                Enviar Enviando = new Enviar();

                Enviando.Process(ClientePC);
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Corpem.Processo", "Send", erro);
            }
        }

        protected override void Receive()
        {
            ESTIntegradora.Notificar("Corpem");
            try
            {
                Receber Recebimento = new Receber();

                Recebimento.Process(ClientePC);
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Corpem.Processo", "Receive", erro);
            }
        }

        protected override void Initialize()
        {
        }
    }
}

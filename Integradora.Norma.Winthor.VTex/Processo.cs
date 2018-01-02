using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integradora.ERP;
using Integradora.ECommerce;
using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ECommerce.VTex;

namespace Integradora.Norma.Winthor.VTex
{
    public sealed class Processo : Integradora.Norma.Winthor.Processo
    {
        public Processo(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            this.ClientePC = codigoclientepc;
        }

        protected override void Send()
        {
            ESTIntegradora.Notificar("VTex");
            try
            {                
                Enviar Enviando = new Enviar();

                Enviando.Process(ClientePC);
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.VTex.Processo", "Send", erro);
            }
        }

        protected override void Receive()
        {
            ESTIntegradora.Notificar("VTex");
            try
            {
                Receber Recebimento = new Receber();

                Recebimento.Process(ClientePC);
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.VTex.Processo", "Receive", erro);
            }
        }

        protected override void Initialize()
        {
        }
    }
}

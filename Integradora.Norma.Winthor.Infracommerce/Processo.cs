using Integradora.Biblioteca.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Infracommerce
{
    public class Processo : Integradora.Norma.Winthor.Processo
    {
        public Processo(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
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
                Logs.GerarLog("Integradora.Norma.Winthor.Infracommerce.Processo", "Send", erro);
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
                Logs.GerarLog("Integradora.Norma.Winthor.Infracommerce.Processo", "Receive", erro);
            }
        }

        protected override void Initialize()
        {
        }
    }
}

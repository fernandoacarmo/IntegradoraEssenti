using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integradora.ERP.Winthor.EntityWinthor;
using System.Threading;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.FBits;
using Integradora.ECommerce.FBits.SyncCategoria;
using Integradora.ECommerce.FBits.SyncUsuario;
using Integradora.ECommerce.FBits.SyncUsuarioEndereco;
using Integradora.ECommerce.FBits.SyncPedidoVenda;
using Integradora.Biblioteca.Dictionaries;


namespace Integradora.Norma.Winthor.FBits
{
    public class Processo : Integradora.Norma.Winthor.Processo
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
                Logs.GerarLog("Integradora.Norma.Winthor.FBits.Processo", "Send", erro);
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
                Logs.GerarLog("Integradora.Norma.Winthor.FBits.Processo", "Receive", erro);
            }
        }

        protected override void Initialize()
        {
        }
    }
}

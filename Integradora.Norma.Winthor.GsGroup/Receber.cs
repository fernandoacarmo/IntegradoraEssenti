using Integradora.Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.GsGroup
{
    class Receber : IProcessIntegration
    {
        public Integradora.ECommerce.GsGroup.Integracao LojaECommerce { get; set; }
        public Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda { get; set; }

        public Receber()
        {
            LojaECommerce = new ECommerce.GsGroup.Integracao();
            PedidoForcaVenda = new ERP.Winthor.Domain.PedidoWeb();
        }
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            //ReceiveCliente();
            //ReceiveClienteEndereco();
            //ReceivePedidos();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ERP.Winthor.EntityPedidoDireto
{
    public class RetornoPedido
    {
        public RetornoPedido()
        {
            itens = new List<RetornoPedidoItem>();
        }
        decimal numeroPedido;
        bool importado;
        string mensagem;
        List<RetornoPedidoItem> itens;
    }

    public class RetornoPedidoItem
    {
        decimal codigoProduto;
        decimal quantidade;

    }
}

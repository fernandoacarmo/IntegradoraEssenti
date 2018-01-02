using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.OnLine.Orders
{
    public class Cabecalho
    {
        public Cabecalho()
        {
            itens = new List<Itens>();
            cliente = new Clientes();
        }
        public string id { get; set; }
        public string codigoAutorizacao { get; set; }
        public string status { get; set; }
        public string numero { get; set; }
        public string parcelas { get; set; }
        public string filial { get; set; }
        public Clientes cliente { get; set; }
        public double valorFrete { get; set; }
        public string planoPagamento { get; set; }
        public string cobranca { get; set; }
        public string pagamento { get; set; }
        public string link { get; set; }
        public long criado { get; set; }
        public long atualizado { get; set; }
        public List<Itens> itens { get; set; }
        public string criacao { get; set; }
        public string mensagem { get; set; }
        public string code { get; set; }
    }
}

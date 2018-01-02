using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lista de pedidos da VTex
/// </summary>
namespace Integradora.ECommerce.VTex.OrderList
{
    public class Item
    {
        /// <summary>
        /// id do vendedor, loja principal = 1
        /// </summary>
        public string seller { get; set; }
        /// <summary>
        /// quantidade vendida,
        /// </summary>
        public int quantity { get; set; }
        /// <summary>
        /// descricao do SKU,
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// codigo de barras, se tiver
        /// </summary>
        public string ean { get; set; }
        /// <summary>
        /// codigo de referencia
        /// </summary>
        public string refId { get; set; }
    }

    public class List
    {
        /// <summary>
        /// identificador do pedido,
        /// </summary>
        public string orderId { get; set; }
        /// <summary>
        /// data de criacao do pedido,
        /// </summary>
        public string creationDate { get; set; }
        /// <summary>
        /// nome do comprador,
        /// </summary>
        public string clientName { get; set; }
        /// <summary>
        /// items do pedido, SKUs,
        /// </summary>
        public List<Item> items { get; set; }
        /// <summary>
        /// valor total do pedido, incluindo todos os valore
        /// </summary>
        public double totalValue { get; set; }
        /// <summary>
        /// nome dos pagamentos,
        /// </summary>
        public string paymentNames { get; set; }
        /// <summary>
        ///status do pedido no momento da consulta,
        /// </summary>
        public string status { get; set; }
        /// <summary>
        ///nome amigavel do status do pedido no momento da consulta,
        /// </summary>
        public string statusDescription { get; set; }
        /// <summary>
        ///id do pedido no canal de vendas, caso pedido de canais externos,
        /// </summary>
        public string marketPlaceOrderId { get; set; }
        /// <summary>
        ///sequencial do pedido, usado na conciliacao de pagamento,
        /// </summary>
        public string sequence { get; set; }
        /// <summary>
        ///identificado do canal de vendas criado no admin,
        /// </summary>
        public string salesChannel { get; set; }
        /// <summary>
        /// identificado do afiliado de vendas criado no OMS admin,
        /// </summary>
        public string affiliateId { get; set; }
        /// <summary>
        /// local, ou canal externo. [local=Marketplace] [esterno=Fulfillment],
        /// </summary>
        public string origin { get; set; }
        /// <summary>
        ///se tem erro de fluxo,
        /// </summary>
        public bool workflowInErrorState { get; set; }
        /// <summary>
        ///se tem erro de fluxo, ta retenando fluxo,
        /// </summary>
        public bool workflowInRetry { get; set; }
        /// <summary>
        ///ultima mensagem recebida,
        /// </summary>
        public string lastMessageUnread { get; set; }
        /// <summary>
        ///data estimada de despacho,
        /// </summary>
        public string ShippingEstimatedDate { get; set; }
        /// <summary>
        ///pedido fechou sem erros,
        /// </summary>
        public bool orderIsComplete { get; set; }
        /// <summary>
        /// id da lista, caso pedido de lista,
        /// </summary>
        public string listId { get; set; }
        /// <summary>
        ///tipo da lista, caso pedido de lista
        /// </summary>
        public string listType { get; set; }
    }

    public class Item2
    {
        /// <summary>
        ///
        /// </summary>
        public string name { get; set; }
        /// <summary>
        ///quantidade vendida,
        /// </summary>
        public int quantity { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string url { get; set; }
    }

    public class Facet
    {
        /// <summary>
        ///
        /// </summary>
        public string name { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string type { get; set; }
        /// <summary>
        ///
        /// </summary>
        public List<Item2> items { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string rangeUrlTemplate { get; set; }
    }

    public class Paging
    {
        /// <summary>
        ///
        /// </summary>
        public int total { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int pages { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int currentPage { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int perPage { get; set; }
    }

    public class TotalItems
    {
        /// <summary>
        ///
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double Max { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double Mean { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double Min { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int Missing { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double StdDev { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double Sum { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double SumOfSquares { get; set; }
    }

    public class TotalValue
    {
        /// <summary>
        ///
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double Max { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double Mean { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double Min { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int Missing { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double StdDev { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double Sum { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double SumOfSquares { get; set; }
    }

    public class Stats2
    {
        /// <summary>
        ///
        /// </summary>
        public TotalItems totalItems { get; set; }
        /// <summary>
        ///
        /// </summary>
        public TotalValue totalValue { get; set; }
    }

    public class Stats
    {
        /// <summary>
        ///
        /// </summary>
        public Stats2 stats { get; set; }
    }

    public class RootObject
    {   
        /// <summary>
        ///
        /// </summary>
        public List<List> list { get; set; }
        /// <summary>
        ///
        /// </summary>
        public List<Facet> facets { get; set; }
        /// <summary>
        ///
        /// </summary>
        public Paging paging { get; set; }
        /// <summary>
        ///
        /// </summary>
        public Stats stats { get; set; }
    }
}

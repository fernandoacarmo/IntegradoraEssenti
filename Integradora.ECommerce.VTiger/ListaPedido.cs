using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.VTiger
{
    /* 
     Licensed under the Apache License, Version 2.0
    
     http://www.apache.org/licenses/LICENSE-2.0
     */

    [XmlRoot(ElementName = "Cliente")]
    public class VTigerCliente
    {
        [XmlElement(ElementName = "Razaosocial")]
        public string Razaosocial { get; set; }
        [XmlElement(ElementName = "Nomefantasia")]
        public string Nomefantasia { get; set; }
        [XmlElement(ElementName = "CNPJCPF")]
        public string CNPJCPF { get; set; }
        [XmlElement(ElementName = "Inscricaoestadual")]
        public string Inscricaoestadual { get; set; }
        [XmlElement(ElementName = "Codcliente")]
        public string Codcliente { get; set; }
        [XmlElement(ElementName = "Email")]
        public string Email { get; set; }
        [XmlElement(ElementName = "Telefone")]
        public string Telefone { get; set; }
        [XmlElement(ElementName = "Celular")]
        public string Celular { get; set; }
        [XmlElement(ElementName = "FAX")]
        public string FAX { get; set; }
        [XmlElement(ElementName = "Endereco")]
        public string Endereco { get; set; }
        [XmlElement(ElementName = "Numero")]
        public string Numero { get; set; }
        [XmlElement(ElementName = "Bairro")]
        public string Bairro { get; set; }
        [XmlElement(ElementName = "Cidade")]
        public string Cidade { get; set; }
        [XmlElement(ElementName = "Estado")]
        public string Estado { get; set; }
        [XmlElement(ElementName = "CEP")]
        public string CEP { get; set; }
        [XmlElement(ElementName = "Complemento")]
        public string Complemento { get; set; }
    }

    [XmlRoot(ElementName = "ItemPedido")]
    public class ItemPedido
    {
        [XmlElement(ElementName = "Numitem")]
        public string Numitem { get; set; }
        [XmlElement(ElementName = "Codproduto")]
        public string Codproduto { get; set; }
        [XmlElement(ElementName = "Quantidade")]
        public string Quantidade { get; set; }
        [XmlElement(ElementName = "Precotabela")]
        public string Precotabela { get; set; }
        [XmlElement(ElementName = "Precovenda")]
        public string Precovenda { get; set; }
        [XmlElement(ElementName = "Percentualdesconto")]
        public string Percentualdesconto { get; set; }
    }

    [XmlRoot(ElementName = "Itens")]
    public class Itens
    {
        [XmlElement(ElementName = "ItemPedido")]
        public List<ItemPedido> ItemPedido { get; set; }
    }

    [XmlRoot(ElementName = "ParcelaPedido")]
    public class ParcelaPedido
    {
        [XmlElement(ElementName = "CodAutorizacao")]
        public string CodAutorizacao { get; set; }
        [XmlElement(ElementName = "NSU")]
        public string NSU { get; set; }
        [XmlElement(ElementName = "Cobranca")]
        public string Cobranca { get; set; }
        [XmlElement(ElementName = "CodCobranca")]
        public string CodCobranca { get; set; }
        [XmlElement(ElementName = "Numparcelas")]
        public string Numparcelas { get; set; }
        [XmlElement(ElementName = "Valor")]
        public string Valor { get; set; }
    }

    [XmlRoot(ElementName = "Parcelas")]
    public class Parcelas
    {
        [XmlElement(ElementName = "ParcelaPedido")]
        public List<ParcelaPedido> ParcelaPedido { get; set; }
    }

    [XmlRoot(ElementName = "Pedido")]
    public class Pedido
    {
        [XmlElement(ElementName = "Dtinclusao")]
        public string Dtinclusao { get; set; }
        [XmlElement(ElementName = "Numpedido")]
        public string Numpedido { get; set; }
        [XmlElement(ElementName = "CodVendedor")]
        public string CodVendedor { get; set; }
        [XmlElement(ElementName = "CodProfissional")]
        public string CodProfissional { get; set; }
        [XmlElement(ElementName = "Observacao")]
        public string Observacao { get; set; }
        [XmlElement(ElementName = "Valortotal")]
        public string Valortotal { get; set; }
        [XmlElement(ElementName = "Valorfrete")]
        public string Valorfrete { get; set; }
        [XmlElement(ElementName = "Valordesconto")]
        public string Valordesconto { get; set; }
        [XmlElement(ElementName = "Dtemissao")]
        public string Dtemissao { get; set; }
        [XmlElement(ElementName = "Dtentrega")]
        public string Dtentrega { get; set; }
        [XmlElement(ElementName = "Cliente")]
        public VTigerCliente Cliente { get; set; }
        [XmlElement(ElementName = "Itens")]
        public Itens Itens { get; set; }
        [XmlElement(ElementName = "Parcelas")]
        public Parcelas Parcelas { get; set; }
    }

    [XmlRoot(ElementName = "xml")]
    public class ListaPedido
    {
        [XmlElement(ElementName = "Pedido")]
        public List<Pedido> Pedido { get; set; }
    }


}

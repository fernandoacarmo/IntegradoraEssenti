using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Shoppub
{
    public class ResultProduto
    {
        public int id { get; set; }
        public string sku { get; set; }
        public string nome { get; set; }
        public string slug { get; set; }
        public int atributo_grupo { get; set; }
        public bool ativo { get; set; }
        public bool destaque { get; set; }
        public bool lancamento { get; set; }
        public bool home { get; set; }
        public bool promocao { get; set; }
        public int fabricante { get; set; }
        public bool is_wrapper { get; set; }
        public int? genero { get; set; }
        public bool envio_especial { get; set; }
        public string preco_de { get; set; }
        public string preco_por { get; set; }
        public string preco_atacado { get; set; }
        public string preco_custo { get; set; }
        public string seo_tag_title { get; set; }
        public string seo_meta_tag_description { get; set; }
        public string seo_meta_tag_keyword { get; set; }
        public int peso { get; set; }
        public double altura { get; set; }
        public double largura { get; set; }
        public double comprimento { get; set; }
        public string ncm { get; set; }
        public int estoque { get; set; }
        public int estoque_minimo { get; set; }
        public int estoque_reserva { get; set; }
        public string codigo { get; set; }
        public string gtin { get; set; }
        public string mpn { get; set; }
        public int? parent { get; set; }
        public bool principal { get; set; }
        public List<int> categorias { get; set; }
        public List<object> cores { get; set; }
        public List<object> produtos_recomendados_relacionados { get; set; }
        public List<int> atributos_valores { get; set; }
        public object loja_vendedora { get; set; }
        public List<object> grupos { get; set; }
    }

    public class ListaProdutos
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<ResultProduto> results { get; set; }
    }
}

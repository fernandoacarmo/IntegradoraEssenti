using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Adena
{
    public class Opcao
    {
        public string nome { get; set; }
        public string valor { get; set; }
    }

    public class DescontoPorQuantidade
    {
        public string quantidade_de { get; set; }
        public string desconto { get; set; }
        public string tipo { get; set; }
    }

    public class SkuProduto
    {
        public string sku { get; set; }
        public string estoque { get; set; }
        public string custo { get; set; }
        public string preco { get; set; }
        public string preco_de { get; set; }
        public string sku_padrao { get; set; }
        public string status { get; set; }
        public string peso { get; set; }
        public string altura { get; set; }
        public string largura { get; set; }
        public string profundidade { get; set; }
        public string estoque_minimo { get; set; }
        public IList<object> codigo_barras { get; set; }
        public IList<Opcao> opcoes { get; set; }
        public IList<DescontoPorQuantidade> desconto_por_quantidade { get; set; }
    }

    public class Propriedade
    {
        public string nome { get; set; }
        public object valor { get; set; }
    }

    public class Especificacao
    {
        public string nome { get; set; }
        public IList<Propriedade> propriedades { get; set; }
    }

    public class Imagen
    {
        public string nome { get; set; }
        public bool destaque { get; set; }
        public string descricao { get; set; }
        public string endereco { get; set; }
        public IList<string> skus { get; set; }
    }

    public class Produto
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public string resumo { get; set; }
        public string descricao { get; set; }
        public string id_categoria { get; set; }
        public string categoria { get; set; }
        public string destaque_home { get; set; }
        public string destaque_categoria { get; set; }
        public string tipo { get; set; }
        public SkuProduto sku_produto { get; set; }
        public IList<Especificacao> especificacao { get; set; }
        public IList<Imagen> imagens { get; set; }
    }

}

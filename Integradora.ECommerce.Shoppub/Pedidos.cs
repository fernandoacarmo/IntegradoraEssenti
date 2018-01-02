using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Shoppub
{
    public class PedidoitemSet
    {
        public string produto_id { get; set; }
        public string produto_codigo { get; set; }
        public string produto_sku { get; set; }
        public string produto_nome { get; set; }
        public string valor_unitario_custo { get; set; }
        public string valor_unitario_sem_descontos { get; set; }
        public string valor_unitario_com_descontos { get; set; }
        public string valor_unitario_com_todos_descontos { get; set; }
        public int quantidade { get; set; }
        public string total { get; set; }
        public string valor_total_sem_descontos { get; set; }
        public string valor_total_com_todos_descontos { get; set; }
        public string valor_total_custo { get; set; }
        public string valor_total_lucro { get; set; }
        public int loja_vendedora_id_perpetuo { get; set; }
    }

    public class PedidodescontoscampanhasSet
    {
        public int campanha_id { get; set; }
        public string campanha_nome { get; set; }
        public string desconto_total { get; set; }
    }

    public class ExtraDados
    {
        public string paymentMethod { get; set; }
        public string cardSummary { get; set; }
        public string acquirerAccountCode { get; set; }
        public string cvcResult { get; set; }
        public string authCode { get; set; }
        public string cvcResultRaw { get; set; }
        public string isCardCommercial { get; set; }
        public string avsResult { get; set; }
        public string acquirerCode { get; set; }
        public string paymentMethodVariant { get; set; }
        public string refusalReasonRaw { get; set; }
        public string acquirerReference { get; set; }
        public string authorisationMid { get; set; }
        public string avsResultRaw { get; set; }
    }

    public class TransacaocartaocreditoSet
    {
        public string cartao_credito_bandeira { get; set; }
        public string cartao_credito_nome_titular { get; set; }
        public string cartao_credito_cardbin { get; set; }
        public string cartao_credito_numero_fim { get; set; }
        public string cartao_credito_numero_mascara { get; set; }
        public string cartao_credito_validade { get; set; }
        public string cartao_credito_codigo_seguranca { get; set; }
        public string tid { get; set; }
        public string code { get; set; }
        public int parcelas { get; set; }
        public string data_captura { get; set; }
        public string valor_estornado { get; set; }
        public string status { get; set; }
        public ExtraDados extra_dados { get; set; }
    }

    public class ShoppubPedido
    {
        public int id { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
        public int status { get; set; }
        public int status_resumido { get; set; }
        public List<PedidoitemSet> pedidoitem_set { get; set; }
        public int? metodo_pagamento { get; set; }
        public int metodo_pagamento_forma { get; set; }
        public string metodo_pagamento_conector { get; set; }
        public string banco_nome { get; set; }
        public string agencia { get; set; }
        public string conta { get; set; }
        public string tipo_servico { get; set; }
        public bool is_correios { get; set; }
        public int prazo { get; set; }
        public bool frete_is_entrega_agendada { get; set; }
        public string frete_entrega_agendada_data { get; set; }
        public string frete_entrega_agendada_periodo { get; set; }
        public string frete_entrega_agendada_tipo_envio { get; set; }
        public int cliente_id { get; set; }
        public string cliente_nome { get; set; }
        public string tipo_cliente { get; set; }
        public string documento1 { get; set; }
        public string documento2 { get; set; }
        public bool ie_isento { get; set; }
        public string email { get; set; }
        public string telefone1 { get; set; }
        public string ramal1 { get; set; }
        public string telefone2 { get; set; }
        public string ramal2 { get; set; }
        public string celular { get; set; }
        public string cobranca_cep { get; set; }
        public string cobranca_tipo_logradouro { get; set; }
        public string cobranca_logradouro { get; set; }
        public string cobranca_numero { get; set; }
        public string cobranca_complemento { get; set; }
        public string cobranca_referencia { get; set; }
        public string cobranca_bairro { get; set; }
        public string cobranca_cidade { get; set; }
        public string cobranca_estado { get; set; }
        public string cobranca_ibge_municipio { get; set; }
        public string cobranca_ibge_municipio_verificador { get; set; }
        public string entrega_destinatario { get; set; }
        public string entrega_cep { get; set; }
        public string entrega_tipo_logradouro { get; set; }
        public string entrega_logradouro { get; set; }
        public string entrega_numero { get; set; }
        public string entrega_complemento { get; set; }
        public string entrega_referencia { get; set; }
        public string entrega_cidade { get; set; }
        public string entrega_bairro { get; set; }
        public string entrega_estado { get; set; }
        public string entrega_restricao { get; set; }
        public string entrega_ibge_municipio { get; set; }
        public string entrega_ibge_municipio_verificador { get; set; }
        public int qtde_itens { get; set; }
        public string total_custo_presente { get; set; }
        public string valor_total_itens_sem_desconto { get; set; }
        public string valor_total_itens_com_desconto { get; set; }
        public string valor_desconto_metodo_pagamento { get; set; }
        public string valor_desconto_total_pedido { get; set; }
        public string porcentagem_desconto_final { get; set; }
        public string valor_total { get; set; }
        public string custo_envio { get; set; }
        public int peso_total_produtos { get; set; }
        public int peso_total_pedido { get; set; }
        public string sugestao_caixa { get; set; }
        public string prazo_boleto { get; set; }
        public string boleto_codigo_de_barra { get; set; }
        public string boleto_referencia { get; set; }
        public string boleto_dados { get; set; }
        public string boleto_nosso_numero { get; set; }
        public string boleto_data_emissao { get; set; }
        public string boleto_data_validade { get; set; }
        public string lojas_vendedoras_ids_perpetuo { get; set; }
        public bool erp_exportado { get; set; }
        public string erp_id { get; set; }
        public int site_id { get; set; }
        public string site_codigo { get; set; }
        public List<PedidodescontoscampanhasSet> pedidodescontoscampanhas_set { get; set; }
        public List<TransacaocartaocreditoSet> transacaocartaocredito_set { get; set; }
    }

    public class ShoppubListaPedidos
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<ShoppubPedido> results { get; set; }
    }
}

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Shoppub
{
    public class RetornoSucesso
    {
        public int id { get; set; }
        public bool success { get; set; }
    }

    public class RetornoFalha
    {
        public string detail { get; set; }
    }

    public class Erro
    {
        public string nome { get; set; }
        public string slug { get; set; }
    }

    public class RetornoProduto
    {
        public string sku { get; set; }
        public string id { get; set; }
        public string nome { get; set; }
        public string slug { get; set; }
        public bool success { get; set; }
        public int index { get; set; }
        public int action { get; set; }
        public List<Erro> erros { get; set; }
    }

    public class RetornoCategoria
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string slug { get; set; }
        public bool is_departamento { get; set; }
        public object parent { get; set; }
        public bool ativo { get; set; }
    }

    public class RetornoFabricante
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string slug { get; set; }
        [JsonProperty("success")]
        public bool Sucesso { get; set; }
    }

    public class RetornoCliente
    {
        public int id { get; set; }
        public string tipo_pessoa { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string data_cadastro { get; set; }
        public string hora_cadastro { get; set; }
        public bool cadastro_pendente_aprovacao { get; set; }
        public bool bloqueado { get; set; }
        public object motivo_bloqueio { get; set; }
        public string como_conheceu { get; set; }
        public string endereco_cep { get; set; }
        public string endereco_tipo_logradouro { get; set; }
        public string endereco_logradouro { get; set; }
        public string endereco_numero { get; set; }
        public string endereco_complemento { get; set; }
        public string endereco_referencia { get; set; }
        public string endereco_bairro { get; set; }
        public string endereco_cidade { get; set; }
        public string endereco_estado { get; set; }
        public string endereco_ibge_uf { get; set; }
        public string endereco_ibge_municipio { get; set; }
        public string endereco_ibge_municipio_verificador { get; set; }
        public string telefone1 { get; set; }
        public object ramal1 { get; set; }
        public object telefone2 { get; set; }
        public object ramal2 { get; set; }
        public string celular { get; set; }
        public object restricao { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string data_nascimento { get; set; }
        public string sexo { get; set; }
        public object cnpj { get; set; }
        public object inscricao_estadual { get; set; }
        public bool inscricao_estadual_isento { get; set; }
        public object contato_pj { get; set; }
        public object cpf_contato_pj { get; set; }
        public string total_gasto { get; set; }
        public int quantidade_pedidos { get; set; }
        public int quantidade_pedidos_pagos { get; set; }
        public string ticket_medio { get; set; }
        public int id_ultimo_pedido { get; set; }
        public string data_ultimo_pedido { get; set; }
        public bool rdstation_exportado { get; set; }
        public int loja_vendedora { get; set; }
    }
}

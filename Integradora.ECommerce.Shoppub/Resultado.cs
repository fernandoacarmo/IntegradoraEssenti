using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integradora.ECommerce.Shoppub
{
    public class Resultado
    {
        private Dictionary<string, string[]> _Erros;
        public string SKU { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Slug { get; set; }
        [JsonProperty("success")]
        public bool Sucesso { get; set; }
        [JsonProperty("index")]
        public int Indice { get; set; }
        [JsonProperty("action")]
        public TipoAcao Acao { get; set; }
        [JsonProperty("errors")]
        public Dictionary<string, string[]> Erros
        {
            get
            {
                if (this._Erros == null)
                {
                    this._Erros = new Dictionary<string, string[]>();
                }
                return this._Erros;
            }
            set
            {
                if (this._Erros != value)
                {
                    this._Erros = value;
                }
            }
        }

        public class Erro
        {
            public string Nome { get; set; }
            public string[] Erros { get; set; }
        }

        public enum TipoAcao
        {
            Cadastrar = 1,
            Atualizar = 2,
        }
    }
}

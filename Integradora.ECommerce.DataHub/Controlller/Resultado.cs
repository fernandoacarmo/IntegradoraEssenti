using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.ReturnWebService
{
    public class Objeto
    {
    }

    public class CamposObrigatorio
    {
        public CamposObrigatorio()
        {
            obrigatorio = new List<object>();
            falta = new List<object>();
        }
        public List<object> obrigatorio { get; set; }
        public List<object> falta { get; set; }
    }

    public class TiposIncompativei
    {
        public string campo { get; set; }
        public string encontrado { get; set; }
        public string esperado { get; set; }
    }

    public class TamanhosMaximoExcedido
    {
        public string campo { get; set; }
        public string valorEnviado { get; set; }
        public string tamanhoEnviado { get; set; }
        public string tamanhoMaximo { get; set; }
    }

    public class TamanhosMinimoExcedido
    {
        public string campo { get; set; }
        public string valorEnviado { get; set; }
        public string tamanhoEnviado { get; set; }
        public string tamanhoMinimo { get; set; }
    }

    public class ValoresMaximoExcedido
    {
        public string campo { get; set; }
        public string valorMaximo { get; set; }
        public string valorEnviado { get; set; }
    }

    public class ValoresMinimoExcedido
    {
        public string campo { get; set; }
        public string valorMinimo { get; set; }
        public string valorEnviado { get; set; }
    }

    public class ValoresNaoEsperado
    {
        public ValoresNaoEsperado()
        {
            permitido = new List<object>();
        }
        public string campo { get; set; }
        public string valor { get; set; }
        public List<object> permitido { get; set; }
    }

    public class Resultado
    {
        public Resultado()
        {
            camposObrigatorios = new List<CamposObrigatorio>();
            tiposIncompativeis = new List<TiposIncompativei>();
            tamanhosMaximoExcedidos = new List<TamanhosMaximoExcedido>();
            tamanhosMinimoExcedidos = new List<TamanhosMinimoExcedido>();
            valoresMaximoExcedidos = new List<ValoresMaximoExcedido>();
            valoresMinimoExcedidos = new List<ValoresMinimoExcedido>();
            valoresNaoEsperados = new List<ValoresNaoEsperado>();

        }
        public Objeto objeto { get; set; }
        public List<CamposObrigatorio> camposObrigatorios { get; set; }
        public List<TiposIncompativei> tiposIncompativeis { get; set; }
        public List<TamanhosMaximoExcedido> tamanhosMaximoExcedidos { get; set; }
        public List<TamanhosMinimoExcedido> tamanhosMinimoExcedidos { get; set; }
        public List<ValoresMaximoExcedido> valoresMaximoExcedidos { get; set; }
        public List<ValoresMinimoExcedido> valoresMinimoExcedidos { get; set; }
        public List<ValoresNaoEsperado> valoresNaoEsperados { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.Ajuri.Retornos
{
    public class ResponsePosicaoEstoquePorMotivo
    {
        public ResponsePosicaoEstoquePorMotivo()
        { 
        }

        [XmlElement(ElementName = "estoques")]
        public Estoques Estoques { get; set; }

        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
    }

    public class Estoques
    {
        public Estoques()
        {
            Estoque = new List<Estoque>();
        }
        [XmlElement(ElementName = "estoque")]
        public List<Estoque> Estoque { get; set; }

    }

    public class Estoque
    {
        public Estoque()
        {

        }
        [XmlElement(ElementName = "motivo")]
        public string Motivo { get; set; }
        [XmlElement(ElementName = "partnumber")]
        public string Partnumber { get; set; }
        [XmlElement(ElementName = "lote")]
        public string Lote { get; set; }
        [XmlElement(ElementName = "quantidade")]
        public decimal Quantidade { get; set; }
        [XmlElement(ElementName = "serial")]
        public string Serial { get; set; }
        [XmlElement(ElementName = "modelo")]
        public string Modelo { get; set; }
        [XmlElement(ElementName = "fabricacao")]
        public string Fabricacao { get; set; }
        [XmlElement(ElementName = "vencimento")]
        public string Vencimento { get; set; }
    }
}

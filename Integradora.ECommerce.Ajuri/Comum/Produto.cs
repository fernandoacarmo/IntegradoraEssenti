using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;


namespace Integradora.ECommerce.Ajuri.Comum
{
    [DataContract(Name = "produto", Namespace = "vx")]
    [XmlRoot(ElementName = "produto", Namespace = "vx")]
    public class Produto
    {
        public Produto()
        {
            Livres = new Livres();
            Filial = new Filial();
            Cliente = new Cliente();
            Grupo = new Grupo();
            Tipo = new Tipo();
            Configuracoes = new Configuracoes();
        }

        [DataMember(Name = "filial")]
        [XmlElement(ElementName = "filial", Namespace = "vx")]
        public Filial Filial { get; set; }
        [DataMember(Name = "cliente")]
        [XmlElement(ElementName = "cliente", Namespace = "vx")]
        public Cliente Cliente { get; set; }
        [DataMember(Name = "partnumber")]
        [XmlElement(ElementName = "partnumber", Namespace = "vx")]
        public string Partnumber { get; set; }
        [DataMember(Name = "descricao")]
        [XmlElement(ElementName = "descricao", Namespace = "vx")]
        public string Descricao { get; set; }
        [DataMember(Name = "unidade")]
        [XmlElement(ElementName = "unidade", Namespace = "vx")]
        public string Unidade { get; set; }
        [DataMember(Name = "dias-validade")]
        [XmlElement(ElementName = "dias-validade", Namespace = "vx")]
        public string Diasvalidade { get; set; }
        [DataMember(Name = "dias-bloqueio")]
        [XmlElement(ElementName = "dias-bloqueio", Namespace = "vx")]
        public string Diasbloqueio { get; set; }
        [DataMember(Name = "mistura-produto-posicao")]
        [XmlElement(ElementName = "mistura-produto-posicao", Namespace = "vx")]
        public string Misturaprodutoposicao { get; set; }
        [DataMember(Name = "mistura-lote-posicao")]
        [XmlElement(ElementName = "mistura-lote-posicao", Namespace = "vx")]
        public string Misturaloteposicao { get; set; }
        [DataMember(Name = "endereca-bloqueado")]
        [XmlElement(ElementName = "endereca-bloqueado", Namespace = "vx")]
        public string Enderecabloqueado { get; set; }
        [DataMember(Name = "bloqueia-qualidade")]
        [XmlElement(ElementName = "bloqueia-qualidade", Namespace = "vx")]
        public string Bloqueiaqualidade { get; set; }
        [DataMember(Name = "grupo")]
        [XmlElement(ElementName = "grupo", Namespace = "vx")]
        public Grupo Grupo { get; set; }
        [DataMember(Name = "tipo")]
        [XmlElement(ElementName = "tipo", Namespace = "vx")]
        public Tipo Tipo { get; set; }
        [DataMember(Name = "configura-embalagens")]
        [XmlElement(ElementName = "configura-embalagens", Namespace = "vx")]
        public Configuracoes Configuracoes { get; set; }
        [DataMember(Name = "livres")]
        [XmlElement(ElementName = "livres", Namespace = "vx")]
        public Livres Livres { get; set; }
    }
}

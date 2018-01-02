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
    [DataContract(Name = "configuracao", Namespace = "vx")]
    [XmlRoot(ElementName = "configuracao", Namespace = "vx")]
    public class Configuracao
    {
        public Configuracao()
        {
            Embalagem = new Embalagem();
        }
        [DataMember(Name = "embalagem")]
        [XmlElement(ElementName = "embalagem", Namespace = "vx")]
        public Embalagem Embalagem { get; set; }
        [DataMember(Name = "itens-por-volume")]
        [XmlElement(ElementName = "itens-por-volume", Namespace = "vx")]
        public string Itensporvolume { get; set; }
        [DataMember(Name = "unidades-por-item")]
        [XmlElement(ElementName = "unidades-por-item", Namespace = "vx")]
        public string Unidadesporitem { get; set; }
        [DataMember(Name = "volumes-por-palete")]
        [XmlElement(ElementName = "volumes-por-palete", Namespace = "vx")]
        public string Volumesporpalete { get; set; }
        [DataMember(Name = "peso-bruto-volume-kilos")]
        [XmlElement(ElementName = "peso-bruto-volume-kilos", Namespace = "vx")]
        public string Pesobrutovolumekilos { get; set; }
        [DataMember(Name = "peso-liquido-volume-kilos")]
        [XmlElement(ElementName = "peso-liquido-volume-kilos", Namespace = "vx")]
        public string Pesoliquidovolumekilos { get; set; }
    }

}

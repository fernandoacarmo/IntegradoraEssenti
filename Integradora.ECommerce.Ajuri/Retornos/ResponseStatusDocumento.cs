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
using System.Web.Services.Protocols;


namespace Integradora.ECommerce.Ajuri.Retornos
{
    public class ResponseStatusDocumento
    {
        public ResponseStatusDocumento()
        {
            Documentos = new SituacaoDocumentos();
        }
        [XmlAttribute(AttributeName = "tipo")]
        public string Tipo { get; set; }

        [XmlAttribute(AttributeName = "numero")]
        public string Numero { get; set; }

        [XmlElement(ElementName = "documentos")]
        public SituacaoDocumentos Documentos { get; set; }

        [XmlAttribute(AttributeName = "status")]
        public string Status{ get; set; }
    }

    public class SituacaoDocumentos
    {
        public SituacaoDocumentos()
        {
            Documento = new List<SituacaoDocumento>();
        }
        [XmlElement(ElementName = "documento")]
        public List<SituacaoDocumento> Documento { get; set; }

    }

    public class SituacaoDocumento
    {
        public SituacaoDocumento()
        {
            
        }
        [XmlElement(ElementName = "numajuri")]
        public string NumAjuri { get; set; }
        [XmlElement(ElementName = "numerp")]
        public string NumERP { get; set; }
        [XmlElement(ElementName = "status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "situacao")]
        public string Situacao { get; set; }

    }
}

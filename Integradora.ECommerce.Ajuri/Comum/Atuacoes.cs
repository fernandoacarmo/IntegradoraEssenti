﻿using System;
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
    [DataContract(Name = "atuacoes", Namespace = "vx")]
    [XmlRoot(ElementName = "Atuacao", Namespace = "vx")]
    public class Atuacoes
    {
        public Atuacoes()
        {
            Atuacao = new List<Atuacao>();
        }
        [DataMember(Name = "atuacao")]
        [XmlElement(ElementName = "atuacao", Namespace = "vx")]
        public List<Atuacao> Atuacao { get; set; }
    }
}


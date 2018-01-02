using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.UseAll.Entity
{
    public class Entity
    {
        public void Serializer()
        {

            string caminho = this.GetType().Name;
            caminho = caminho + ".xml";

            FileStream stream = new FileStream(caminho, FileMode.Create);
            System.Xml.Serialization.XmlSerializer serializador = new System.Xml.Serialization.XmlSerializer(this.GetType());
            serializador.Serialize(stream, this);

        }

    }
}

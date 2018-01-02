using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.UseAll.EntityWebService
{
    public class Entity
    {
        public void Serializer(string nomeArquivo)
        {
            Biblioteca.Tools.XML.Export(this, nomeArquivo);
        }

    }
}
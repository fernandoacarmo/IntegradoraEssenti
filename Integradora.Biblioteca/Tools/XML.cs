using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Integradora.Biblioteca.Tools
{
    public class XML
    {
        public static void Export(object Objeto, string nomeArquivo)
        {
            string pathArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "xml");
            Export(Objeto, nomeArquivo, pathArquivo);

        }

        public static void Export(object Objeto, string nomeArquivo, string diretorio)
        {
            string pathArquivo = diretorio;
            if (!Directory.Exists(pathArquivo))
            {
                Directory.CreateDirectory(pathArquivo);
            }

            if (string.IsNullOrEmpty(nomeArquivo))
            {
                nomeArquivo = Objeto.GetType().Name;
            }

            nomeArquivo = nomeArquivo + ".xml";
            pathArquivo = Path.Combine(pathArquivo, nomeArquivo);

            FileStream fs = new FileStream(pathArquivo, FileMode.Create);
            XmlTextWriter stream = new XmlTextWriter(fs, Encoding.Unicode);
            //FileStream stream = new FileStream(pathArquivo, FileMode.Create);
            try
            {
                System.Xml.Serialization.XmlSerializer serializador = new System.Xml.Serialization.XmlSerializer(Objeto.GetType());
                serializador.Serialize(stream, Objeto);
            }
            finally
            {
                stream.Close();
            }
        }

        public static string XMLtoString(object Objeto, string NameSpaces, string nomeArquivo)
        {
            string resultado = "";

            string pathArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "xml");

            nomeArquivo = nomeArquivo + ".xml";
            pathArquivo = Path.Combine(pathArquivo, nomeArquivo);

            if (System.IO.File.Exists(pathArquivo))
            {
                System.IO.File.Delete(pathArquivo);
            }

            StreamWriter stream = new StreamWriter(pathArquivo, true);
//            FileStream stream = new FileStream(pathArquivo, FileMode.Create);
            try
            {
                XmlSerializerNamespaces myNamespaces = new XmlSerializerNamespaces();

                System.Xml.Serialization.XmlSerializer serializador = new System.Xml.Serialization.XmlSerializer(Objeto.GetType());
                if (!string.IsNullOrEmpty(NameSpaces))
                {
                    myNamespaces.Add(NameSpaces, NameSpaces);
                    serializador.Serialize(stream, Objeto, myNamespaces);
                }
                else
                {
                    serializador.Serialize(stream, Objeto);
                }
            }
            finally
            {
                stream.Close();
            }

            resultado = System.IO.File.ReadAllText(pathArquivo);
            return resultado;
        }
    }
}

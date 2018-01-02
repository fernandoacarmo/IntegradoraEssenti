using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Tools
{
    public class JSON
    {
        public static string Export(object Objeto, string nomeArquivo)
        {
            var json = JsonConvert.SerializeObject(Objeto);

            string pathArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "json");
            if (!Directory.Exists(pathArquivo))
            {
                Directory.CreateDirectory(pathArquivo);
            }

            if (string.IsNullOrEmpty(nomeArquivo))
            {
                nomeArquivo = Objeto.GetType().Name;
            }

            nomeArquivo = nomeArquivo + ".json";
            pathArquivo = Path.Combine(pathArquivo, nomeArquivo);

            StreamWriter vWriter = new StreamWriter(pathArquivo, false);
            vWriter.WriteLine(json);
            vWriter.Flush();
            vWriter.Close();

            return pathArquivo;
        }
        public static string Serialize<T>(T value) where T : class
        {

            Type type = value.GetType();
            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();

            //ignorando propriedades nulas
            json.NullValueHandling = NullValueHandling.Ignore;

            // ignorar referencias ciclicas em objetos
            json.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            // formato da data, utilizar o iso
            json.DateFormatHandling = DateFormatHandling.IsoDateFormat;

            if (type == typeof(DataTable))
                json.Converters.Add(new DataTableConverter());
            else if (type == typeof(DataSet))
                json.Converters.Add(new DataSetConverter());

            StringWriter sw = new StringWriter();
            Newtonsoft.Json.JsonTextWriter writer = new JsonTextWriter(sw);

            writer.Formatting = Formatting.None;

            writer.QuoteChar = '"';
            json.Serialize(writer, value);

            string output = sw.ToString();
            writer.Close();
            sw.Close();

            return output;

        }
        public static T DeSerialize<T>(string value) where T : class
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            // se alguma propriedade nao existir no objeto, ignorar
            settings.MissingMemberHandling = MissingMemberHandling.Ignore;

            return JsonConvert.DeserializeObject<T>(value);

        }
    }
}

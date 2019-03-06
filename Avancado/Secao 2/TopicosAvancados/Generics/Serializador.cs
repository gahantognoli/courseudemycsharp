using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace Generics
{
    public class Serializador
    {
        public static void Serializar(object objeto)
        {
            StreamWriter stream = new StreamWriter(@"C:\Users\gabri\OneDrive\Documentos\Gabriel\Plataformas de ensino\UDEMY\Curso C# Udemy\Avancado\Secao 2\Arquivos\" + objeto.GetType().Name + ".txt");
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string json = serializador.Serialize(objeto);
            stream.WriteLine(json);
            stream.Close();
        }

        public static T Deserializar<T>()
        {
            StreamReader stream = new StreamReader(@"C:\Users\gabri\OneDrive\Documentos\Gabriel\Plataformas de ensino\UDEMY\Curso C# Udemy\Avancado\Secao 2\Arquivos\" + typeof(T).Name + ".txt");
            string conteudo = stream.ReadToEnd();

            JavaScriptSerializer deserializador = new JavaScriptSerializer();
            return deserializador.Deserialize<T>(conteudo);
        }

    }
}

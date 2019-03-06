using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using Biblioteca;

namespace SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Gabriel Antognoli",
                CPF = "416.367.418-78",
                Email = "gabriel.antognoli@hotmail.com"
            };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string stringJSON = serializador.Serialize(usuario);

            StreamWriter stream = new StreamWriter(@"C:\Users\gabri\OneDrive\Documentos\Gabriel\Plataformas de ensino\UDEMY\Curso C# Udemy\Avancado\Secao 1\Arquivos\Serializar_UsuarionJSON.json");
            stream.WriteLine(stringJSON);
            stream.Close();
        }
    }
}

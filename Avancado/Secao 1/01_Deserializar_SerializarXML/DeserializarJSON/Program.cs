using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using Biblioteca;

namespace DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\gabri\OneDrive\Documentos\Gabriel\Plataformas de ensino\UDEMY\Curso C# Udemy\Avancado\Secao 1\Arquivos\Serializar_UsuarionJSON.json");
            string usuarioSerializado = stream.ReadToEnd();

            JavaScriptSerializer deserializador = new JavaScriptSerializer();
            Usuario usuario = (Usuario)deserializador.Deserialize(usuarioSerializado, typeof(Usuario));

            Console.WriteLine("Nome: " + usuario.Nome);
            Console.WriteLine("CPF: " + usuario.CPF);
            Console.WriteLine("E-mail: " + usuario.Email);

            Console.ReadKey();

        }
    }
}

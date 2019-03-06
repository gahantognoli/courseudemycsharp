using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Biblioteca;

namespace DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\gabri\OneDrive\Documentos\Gabriel\Plataformas de ensino\UDEMY\Curso C# Udemy\Avancado\Secao 1\Arquivos\Serializar_Usuario.xml");
            XmlSerializer deserializador = new XmlSerializer(typeof(Usuario));

            Usuario usuario = (Usuario)deserializador.Deserialize(stream);

            Console.WriteLine("Nome: " + usuario.Nome);
            Console.WriteLine("CPF: " + usuario.CPF);
            Console.WriteLine("Email: " + usuario.Email);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Biblioteca;
using System.Xml.Serialization; //classe para serialização de XML.

namespace SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario =
                 new Usuario() { Nome = "Gabriel", CPF = "416.367.418-78", Email = "gabriel_antognoli@hotmail.com" };
            //objeto que serializa o usuário.
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            StreamWriter stream = 
                new StreamWriter(@"C:\Users\gabri\OneDrive\Documentos\Gabriel\Plataformas de ensino\UDEMY\Curso C# Udemy\Avancado\Secao 1\Arquivos\Serializar_Usuario.xml");

            serializador.Serialize(stream, usuario);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_GravandoArquiv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando o arquivo no diretório informado no construtor.
            // A "\" pode ser usada para fazer o "scaping", que é para indicar que se deve exibir o texto que está informando.
            StreamWriter arquivo = new StreamWriter(@"C:\temp\teste.txt");

            //Inserindo texto no arquivo.
            arquivo.WriteLine("Olá Mundo.");
            arquivo.WriteLine("Testando a gravação ...");

            arquivo.Close();//Fechando o arquivo.

            Console.WriteLine("Arquivo gravado com sucesso.");
            Console.ReadKey();
        }
    }
}

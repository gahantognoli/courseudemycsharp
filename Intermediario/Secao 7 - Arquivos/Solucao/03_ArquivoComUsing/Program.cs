using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ArquivoComUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando o arquivo no diretório informado no construtor.
            // A "\" pode ser usada para fazer o "scaping", que é para indicar que se deve exibir o texto que está informando.
            using (StreamWriter arquivo = new StreamWriter(@"C:\temp\teste1.txt"))
            {
                //Inserindo texto no arquivo.
                arquivo.WriteLine("Olá Mundo.");
                arquivo.WriteLine("Testando a gravação ...");
            }

            Console.WriteLine("Arquivo gravado com sucesso.");
            Console.ReadKey();
        }
    }
}

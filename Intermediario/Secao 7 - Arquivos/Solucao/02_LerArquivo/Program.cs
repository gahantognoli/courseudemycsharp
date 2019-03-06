using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LerArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pegando conteudo do arquivo selecionado.
            string texto = File.ReadAllText(@"C:\temp\teste.txt");
            Console.WriteLine(texto);

            string[] linhas = File.ReadAllLines(@"C:\temp\teste.txt");

            Console.WriteLine("Quantidade de Linhas: " + linhas.Length);

            foreach (string linha in linhas)
            {
                Console.WriteLine("Linha: " + linha);
            }

            Console.ReadKey();
        }
    }
}

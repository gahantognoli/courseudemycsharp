using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LocalizarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá amigos estou muito feliz de esta aqui com voces.Deseja a todos um feliz ano novo.";

            Console.WriteLine("Tamanho do texto: " + texto.Length);
            Console.WriteLine("Localizador: " + texto.IndexOf("."));// primeira ocorrencia do parametro.
            Console.WriteLine("Localizar ultimo: " + texto.LastIndexOf(".")); // ultima ocorrencia do parametro.

            Console.ReadKey();
            
        }
    }
}

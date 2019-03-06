using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatarString
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gabriel Antognoli";
            string texto = "Bem vindo " + nome + " ! Feliz Natal.";

            string textoFormatado = string.Format("Bem vindo {0} ! Feliz Natal.{0} {1}", nome, "Feliz");

            Console.WriteLine(texto);
            Console.WriteLine(textoFormatado);

            Console.ReadKey();
        }
    }
}

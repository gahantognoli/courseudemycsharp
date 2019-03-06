using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ConversaoTextoParaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroTexto = "30";
            int numeroConvertido = int.Parse(numeroTexto);
            int numero = 30;

            Console.WriteLine(numeroConvertido + numero);
            Console.WriteLine("O Resultado da soma é: " + numeroConvertido + numero);
            Console.WriteLine("O Resultado da soma é: " + (numeroConvertido + numero));
            Console.ReadKey();  
        }
    }
}

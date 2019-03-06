using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.SetNome("Gabriel Antognoli");

            Console.WriteLine("Nome: " + pessoa.GetNome());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario;
            int anoNascimento;

            Console.WriteLine("Informe seu Nome: ");
            nomeUsuario = Console.ReadLine();

            Console.WriteLine("Digite sua Idade: ");
            anoNascimento = anoNascimentoUsuario(Convert.ToByte(Console.ReadLine()));
            Console.WriteLine("O seu ano de nascimento é: " + anoNascimento);
            Console.ReadKey();
        }

        public static int anoNascimentoUsuario(int idadeUsuario)
        {
            return DateTime.Now.Year - idadeUsuario;
        }
    }
}

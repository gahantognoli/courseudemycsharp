using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ParamOut
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 25;

            Console.WriteLine("Main > var valor: " + valor);

            AlterarValor(out valor);
            int idade;
            //Além de retornar o nome, o out retorna o nome passado como parametro com um novo valor.
            //Isso é utilizado quando desejamos retornar algo e além disso atribuir um valor para a variavel passada.
            string nome = RetornarNomeIdadePessoa(new DateTime(10, 10, 2000), out idade);

            int.TryParse("1", out int valor2);// Exemplo de utilização no próprio c#.

            Console.WriteLine("Main > var valor: " + valor);

            Console.ReadKey();
        }

        static void AlterarValor(out double valor)
        {
            valor = 10;
        }

        static string RetornarNomeIdadePessoa(DateTime dataNascimento, out int idade)
        {
            idade = 10;
            return "Nome";
        }
    }
}

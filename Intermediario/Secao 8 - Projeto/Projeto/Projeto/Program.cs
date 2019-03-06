using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Views;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            //Menu
            do
            {
                Console.WriteLine("------------ OPERAÇÕES ------------");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Funcionário");
                Console.WriteLine("4 - Listar Funcionários");
                Console.WriteLine("5 - Fechar");
                opcao = Convert.ToInt32(Console.ReadLine());

                ManterCliente manterCliente = new ManterCliente();
                ManterFuncionario manterFuncionario = new ManterFuncionario();

                switch (opcao)
                {
                    case 1:
                        manterCliente.CadastrarCliente();
                        break;

                    case 2:
                        manterCliente.CadastrarCliente();
                        break;

                    case 3:
                        manterFuncionario.CadastrarFuncionario();
                        break;

                    case 4:
                        manterFuncionario.ListarFuncionarios();
                        break;

                    case 5:
                        opcao = 5;
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }

            } while (opcao != 5);



            Console.ReadKey();

        }
    }
}

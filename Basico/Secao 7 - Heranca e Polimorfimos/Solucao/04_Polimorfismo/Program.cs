using _04_Polimorfismo.Biblioteca;
using _04_Polimorfismo.Biblioteca.Derivadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            MoverVeiculo(carro);

            Moto moto = new Moto();
            MoverVeiculo(moto);

            Console.ReadKey();
        }
        //Como uma moto ou um carro é um veiculo, então pode-se passar eles como parametro para veiculo, pois tbm são veiculos.
        //E com o polimorfismo o método que será chamado é o metodo referente ao objeto que foi passado.
        //Exemplo: se um objeto carro foi passado para o veiculo, como há uma sobrescrita do método mover no veiculo, o método que
        //será executado é o mover do carro, que sobrescreveu o método do veiculo.
        public static void MoverVeiculo(Veiculo veiculo)
        {
            veiculo.Mover();
        }

    }
}

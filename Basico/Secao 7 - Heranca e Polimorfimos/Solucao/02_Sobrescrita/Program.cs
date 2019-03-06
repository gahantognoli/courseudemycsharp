using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sobrescrita
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Moto moto = new Moto();

            Veiculo veiculo = new Veiculo();

            carro.Marca = "Fiat";
            moto.Marca = "Triumph";
            veiculo.Marca = "Airbus";

            veiculo.Mover();
            moto.Mover();
            carro.Mover();

            Console.ReadKey();
        }
    }
}

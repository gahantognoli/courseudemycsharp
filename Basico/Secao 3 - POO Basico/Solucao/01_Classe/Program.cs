using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Classe.Veiculo;

namespace _01_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo.Carro carro = new Carro();
            _01_Classe.Veiculo.Carro carro2 = new Carro();
            Carro carro3 = new Carro();

            Console.WriteLine("Marca: " + carro.Marca);
            carro.Marca = "FORD";
            Console.WriteLine("Marca: " + carro.Marca);

            Console.WriteLine("Estado das Luzes: " + carro.LuzesInternas);
            carro.AbrirPorta();
            Console.WriteLine("Estado das Luzes: " + carro.LuzesInternas);

            string statusFarol = carro.AcenderFarolAutomaticamente();
            Console.WriteLine("Status Farol: " + statusFarol);

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConstrutorRapid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construtor rapido.
            Carro carro = new Carro() { Marca = "FIAT", Modelo = "Palio", Rodas = 4, DataFabricacao = new DateTime(2010, 02, 02)};
        }
    }
}

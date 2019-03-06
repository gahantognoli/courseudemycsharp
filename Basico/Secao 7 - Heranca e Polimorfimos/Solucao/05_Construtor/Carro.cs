using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Construtor
{
    class Carro
    {
        public string Marca;
        public string Modelo;

        //Construtor que já inicializa as propriedades.
        public Carro()
        {
            Marca = "Fiat";
            Modelo = "Palio";
        }

        //Construtor feito por sobrecarga, no qual é possível a passagem de parametros.
        public Carro(string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }

    }
}

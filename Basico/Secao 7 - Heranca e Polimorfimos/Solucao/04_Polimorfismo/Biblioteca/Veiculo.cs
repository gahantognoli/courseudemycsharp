using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Polimorfismo.Biblioteca
{
    class Veiculo
    {
        public string Modelo;
        public string Marca;
        public string Ano;

        public virtual void Mover()
        {
            Console.WriteLine("Veiculo se movendo ...");
        }

    }
}

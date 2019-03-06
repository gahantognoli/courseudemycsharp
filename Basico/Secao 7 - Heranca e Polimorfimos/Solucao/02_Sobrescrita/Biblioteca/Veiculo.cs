using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sobrescrita
{
    class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int QuantidadeMaxPassageiros;
        public int Ano;

        //Virtual - deixa o método ser sobrescrido, com uma leitura mais intuitiva.
        public virtual void Mover()
        {
            Console.WriteLine("Mover chamando dentro de Veiculo.Mover");
        }

    }
}

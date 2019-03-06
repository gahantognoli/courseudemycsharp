using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ModificadorAcessP1.Lib
{
    public class Veiculo
    {
        public string Marca;
        protected string Modelo;
        private DateTime AnoFabricacao;
        internal DateTime AnoModelo;

        void InfoVeiculo()
        {
            Marca = "FIAT";
            Console.WriteLine("Marca: " + Marca);

            Modelo = "Palio";

            AnoModelo = new DateTime(0, 0, 0);
        }
    }
}

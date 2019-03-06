using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classe.Veiculo
{
    class Carro
    {
        public string Marca = "FIAT";
        public string Modelo;
        public string Cor;
        public bool LuzesInternas = false;

        public void AbrirPorta()
        {
            LuzesInternas = true;
        }

        public void FecharPorta()
        {
            LuzesInternas = false;
        }

        public string AcenderFarolAutomaticamente()
        {
            return "Médio";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TratandoExcpt
{
    class Pessoa
    {
        private string Nome;
        private string CEP;
        private string CPF;

        public void SetCEP(string cep)
        {
            int.Parse(cep);
            int resultado;
            if(int.TryParse(cep, out resultado))
            {
                CEP = cep;
            }
            else
            {
                throw new Exception("CEP Inválido.");
            }
        }
    }
}

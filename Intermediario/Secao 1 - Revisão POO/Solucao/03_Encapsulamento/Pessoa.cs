using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Encapsulamento
{
    class Pessoa
    {
        private string Nome;
        private string CEP;
        private string Endereco;
        private string CPF;

        //Encapsulamento.
        public void SetNome(string nome)
        {
            Nome = nome.Trim();
        }

        public string GetNome()
        {
            return Nome.ToUpper();
        }
    }
}

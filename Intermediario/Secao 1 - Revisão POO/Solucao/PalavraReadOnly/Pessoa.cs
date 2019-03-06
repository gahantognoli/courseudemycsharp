using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalavraReadOnly
{
    class Pessoa
    {
        public readonly string Nome = "Gabriel Antognoli";

        public string Idade { get; private set; }

        public void SetIdade(string idade)
        {
            Idade = idade;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementParte2
{
    class Pessoa
    {
        //Customizanação encapsulamento.
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value.Trim();
            }
        }
    }
}

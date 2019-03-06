using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassesParciais
{
    //Mesma classe, porém em arquivos diferentes.
    //Muito usado quando´´e necessário uma implementação mais robusta, com varios métodos e atributos.
    partial class Pessoa
    {
        public void PessoaX()
        {
            //Acessando a propriedade criada na classe parcial "Pessoa.Part2".
            nome = "Gabriel";
        }
    }
}

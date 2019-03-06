using System;

namespace _03_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construtor da classe, obrigando a passagem dos parâmetros.
            Pessoa pessoa = new Pessoa("Gabriel Antognoli", "M", DateTime.Now, 20.5, 10.5);
        }
    }
}

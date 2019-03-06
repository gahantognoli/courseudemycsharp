using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacao;

namespace ValidacaoPersonalizada
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Gabriel",
                Email = "gazim123",
                Senha = "123"
            };

            ValidationContext contexto = new ValidationContext(usuario);
            List<ValidationResult> resultados = new List<ValidationResult>();

            if (Validator.TryValidateObject(usuario, contexto, resultados, true) == false)
            {
                //Mensagens
                foreach (var erro in resultados)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

            Console.ReadKey();
        }
    }
}

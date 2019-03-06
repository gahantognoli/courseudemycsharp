using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ValidacaoPersonalizada;

namespace Validacao
{
    class Usuario
    {
        [Required(ErrorMessage = "O Campo Nome é de preenchimento obrigatório")]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MyValidation(ErrorMessage = "O campo senha deve possuir 10 caracteres.")]
        public string Senha { get; set; }
    }
}

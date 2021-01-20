using System;
using System.ComponentModel.DataAnnotations;

namespace site.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo 'E-mail' é obrigatória")]
        [EmailAddress(ErrorMessage = "O campo 'E-mail' é inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatória")]
        public string Senha { get; set; }
    }
}

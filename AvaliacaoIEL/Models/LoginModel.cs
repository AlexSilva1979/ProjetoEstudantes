﻿using System.ComponentModel.DataAnnotations;

namespace AvaliacaoIEL.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o e-mail.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite a senha.")]
        public string Senha { get; set; }
    }
}

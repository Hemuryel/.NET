﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMvcBusinessObject01.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome deve ser informado")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O nome deve ter no mínimo 5 caracteres")]
        [Display(Name = "Informe o nome do cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sexo deve ser informado")]
        [Display(Name = "Informe o sexo do cliente")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O e-mail deve ser informado")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A data de nascimento deve ser informada")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Nascimento { get; set; }

        public string Foto { get; set; }
        public string Texto { get; set; }
    }
}

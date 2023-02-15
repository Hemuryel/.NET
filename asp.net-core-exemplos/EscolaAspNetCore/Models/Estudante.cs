using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaAspNetCore.Models
{
    public class Estudante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do Estudante")]
        public string Nome { get; set; }

        public DateTime DataMatricula { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}

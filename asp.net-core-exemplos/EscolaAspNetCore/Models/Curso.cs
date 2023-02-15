using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaAspNetCore.Models
{
    public class Curso
    {
        public int CursoId { get; set; }

        [Required(ErrorMessage ="Informe o nome do Curso")]
        public string Titulo { get; set; }
        
        public int Creditos { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}

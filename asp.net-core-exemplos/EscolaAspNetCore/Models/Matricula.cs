using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaAspNetCore.Models
{
    public enum Nota
    {
        A,B,C,D,F
    }

    public class Matricula
    {
        public int MatriculaId { get; set; }
        public int CursoId { get; set; }
        public int EstudanteId { get; set; }
        public Nota? Nota { get; set; }

        public Curso Curso { get; set; }
        public Estudante Estudante { get; set; }
    }
}

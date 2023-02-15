using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore03.Models
{
    [Table("AlunosEF")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [StringLength(50)]
        public string Sexo { get; set; }
        [Required]
        [StringLength(150)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }

        [Required]
        [StringLength(150)]
        public string Foto { get; set; }

        [Required]
        [StringLength(150)]
        public string Texto { get; set; }

        // TipoSocio ou TipoSocioId = EF Core identifica automaticamente como FK
        public TipoSocio TipoSocio { get; set; }
    }
}

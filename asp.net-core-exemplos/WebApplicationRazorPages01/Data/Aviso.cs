using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationRazorPages01.Data
{
    [Table("Avisos")]
    public class Aviso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime? Hora { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [StringLength(250)]
        public string Mensagem { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationEFCore04.Models
{
    [Table("ClientesEF04")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Nome { get; set; }
        [Required]
        [StringLength(150)]
        public string Email { get; set; }
    }
}
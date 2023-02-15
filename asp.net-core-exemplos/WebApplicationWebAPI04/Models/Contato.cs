using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationWebAPI04.Models
{
    [Table("Contatos")]
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome do contato")]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o e-mail do contato")]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o telefone do contato")]
        [StringLength(50)]
        public string Telefone { get; set; }
    }
}

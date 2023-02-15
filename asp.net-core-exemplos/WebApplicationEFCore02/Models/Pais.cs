using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationEFCore02.Models
{
    [Table("Paises")]
    public class Pais
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome do país")]
        public string Nome { get; set; }
        public string Codigo { get; set; }
    }
}

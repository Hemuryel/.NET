using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore03.Models
{
    [Table("TipoSociosEF")]
    public class TipoSocio
    {
        // Id ou TipoSocioId = EF Core identifica automaticamente como PK, ou usar [Key] da DataAnnotations
        [Key]
        public int Id { get; set; }

        [Required]
        public int DuracaoEmMeses { get; set; }

        /* mensal   = sem desconto
         * 3 meses  = 10%
         * 6 meses  = 20%
         * 12 meses = 30%
         */
        [Required]
        public int TaxaDesconto { get; set; }
    }
}

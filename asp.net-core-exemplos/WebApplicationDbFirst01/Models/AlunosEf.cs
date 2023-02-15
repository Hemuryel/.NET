using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationDbFirst01.Models
{
    public partial class AlunosEf
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public string Foto { get; set; }
        public string Texto { get; set; }
        public int? TipoSocioId { get; set; }

        public virtual TipoSociosEf TipoSocio { get; set; }
    }
}

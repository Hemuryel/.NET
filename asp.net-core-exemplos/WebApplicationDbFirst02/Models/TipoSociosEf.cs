using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationDbFirst02.Models
{
    public partial class TipoSociosEf
    {
        public TipoSociosEf()
        {
            AlunosEfs = new HashSet<AlunosEf>();
        }

        public int Id { get; set; }
        public int DuracaoEmMeses { get; set; }
        public int TaxaDesconto { get; set; }

        public virtual ICollection<AlunosEf> AlunosEfs { get; set; }
    }
}

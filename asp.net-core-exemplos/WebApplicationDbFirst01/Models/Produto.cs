using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationDbFirst01.Models
{
    public partial class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}

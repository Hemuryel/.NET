using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore01.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Decimal Preco { get; set; }
    }
}

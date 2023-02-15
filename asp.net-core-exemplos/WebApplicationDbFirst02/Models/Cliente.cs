using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationDbFirst02.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}

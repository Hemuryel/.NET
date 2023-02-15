using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationDbFirst02.Models
{
    public partial class Cliente1
    {
        public Cliente1()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}

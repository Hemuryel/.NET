using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationDbFirst01.Models
{
    public partial class Pedido
    {
        public int PedidoId { get; set; }
        public string Item { get; set; }
        public int Quantidade { get; set; }
        public int Preco { get; set; }
        public int? ClienteId { get; set; }

        public virtual Cliente1 Cliente { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMvc03.Models;

// útil para passar dados complexos de 2 ou + Models na View
namespace WebApplicationMvc03.ViewModel
{
    public class ClientePedidoViewModel
    {
        public Cliente Cliente { get; set; }
        public List<Pedido> Pedidos{ get; set;}
    }
}

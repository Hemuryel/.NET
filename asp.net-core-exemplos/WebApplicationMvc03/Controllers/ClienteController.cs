using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMvc03.Models;
using WebApplicationMvc03.ViewModel;

namespace WebApplicationMvc02.Controllers
{
    [Route("[controller]/[action]")]
    public class ClienteController : Controller
    {
        public IActionResult Detalhe()
        {
            // fortemente tipado = usar Model
            Cliente cliente = new Cliente
            {
                ClienteId = 100,
                Nome = "Fulano",
                Email = "fulano@hotmail.com"
            };

            var pedidos = new List<Pedido>
            {
                new Pedido { Nome = "Pedido1" },
                new Pedido { Nome = "Pedido2" }
            };

            var viewModel = new ClientePedidoViewModel
            {
                Cliente = cliente,
                Pedidos = pedidos
            };

            // return View(cliente); // assim era por Model, mas permitia apenas 1
            return View(viewModel);
        }
    }
}

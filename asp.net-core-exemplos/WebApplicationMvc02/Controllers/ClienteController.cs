using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMvc02.Models;

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

            return View(cliente);
        }
    }
}

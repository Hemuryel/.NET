using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDbFirst02.Models;

namespace WebApplicationDbFirst02.Controllers
{
    public class ClienteController : Controller
    {
        private asp_net_core_exemplosContext _context;

        public ClienteController(asp_net_core_exemplosContext context)
        {
            _context = context;
        }

        public IActionResult Index(){
            var clientes = _context.Clientes.ToList();
            return View(clientes);
        }
    }
}
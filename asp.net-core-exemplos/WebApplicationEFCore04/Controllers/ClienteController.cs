
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplicationEFCore04.Models;

namespace WebApplicationEFCore04.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteContext _context;
        public ClienteController(ClienteContext context)
        {
             this._context = context;
        }

        public IActionResult Index(){
            var clientes = _context.Clientes.ToList();
            return View(clientes);
        }
    }
}
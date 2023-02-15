using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplicationIdentity03.Data;

namespace WebApplicationIdentity03.Controllers
{
    [Authorize]
    public class ContatoController : Controller
    {
        private ApplicationDbContext _context;
        public ContatoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            // requer esse IF se não usar atributo [Authorize]
            //if (User.Identity.IsAuthenticated)
            //{
                var contatos = _context.Contatos.ToList();
                return View(contatos);
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Account");
            //}
        }
 
        public IActionResult AcessoAutorizado()
        {
            return Content("Acesso autorizado!");
        }

        [AllowAnonymous]
        public IActionResult AcessoAnonimo()
        {
            return Content("Acesso anônimo!");
        }
    }
}

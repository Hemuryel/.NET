using Identity_AutenticaAutoriza.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Identity_AutenticaAutoriza.Controllers
{
    [Authorize]
    public class ContatoController : Controller
    {
        private ApplicationDbContext _context;

        public ContatoController(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        
        public IActionResult Index()
        {
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
            return Content("ACESSO AUTORIZADO..........");
        }

        [AllowAnonymous]
        public IActionResult AcessoAnonimo()
        {
            return Content("ACESSO ANÔNIMO..........");
        }


    }
}
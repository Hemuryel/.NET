using AspCoreMvc_Filtros.Filtros;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AspCoreMvc_Filtros.Controllers
{
    public class HomeController : Controller
    {
        [SaudacaoFilter]
        public IActionResult Index()
        {
            ViewData["Message"] = "Pagina Index.";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Pagina About.";
            throw new Exception("Ocorreu um erro no método Action About !!!");
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Pagina Contact.";
            throw new Exception("Ocorreu um erro no método Action Contact !!!");
            return View();
        }
    }
}

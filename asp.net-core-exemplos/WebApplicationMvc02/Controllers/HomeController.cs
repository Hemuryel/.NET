using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationMvc02.Models;

namespace WebApplicationMvc02.Controllers
{
    // attribute routing
    [Route("api/[controller]/[action]")] // só funciona para actions sem route, exemplo lista
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Lista()
        {
            return "Action Lista";
        }

        [Route("/listax/{valor:int}")]
        public string Lista2(string valor)
        {
            return "Action Lista2" + valor;
        }

        [Route("/listay/{valor:range(1,12)}")]
        public string Lista3(string valor)
        {
            return "Action Lista3" + valor;
        }

        [Route("/")]
        [Route("/home")]
        [Route("/home/index123")]
        [Route("/api/home/index")]
        public IActionResult Index()
        {
            return View(); // procura na convenção Views/Home/Index.cshtml, se não existir, procura em Views/Shared
        }

        public IActionResult Index2()
        {
            return View("Views/Home/Index.cshtml");
        }

        [Route("home/privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

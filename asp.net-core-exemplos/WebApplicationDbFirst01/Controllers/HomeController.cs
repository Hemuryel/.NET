using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationDbFirst01.Models;

namespace WebApplicationDbFirst01.Controllers
{
    public class HomeController : Controller
    {
        private asp_net_core_exemplosContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, asp_net_core_exemplosContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var alunos = _context.AlunosEfs.ToList();
            return View(alunos);
        }

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

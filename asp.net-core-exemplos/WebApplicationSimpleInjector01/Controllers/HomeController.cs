using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebApplicationAcessandoAppSettings1.Services;
using WebApplicationSimpleInjector01.Models;

namespace WebApplicationSimpleInjector01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMensagemService _mensagemService;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IMensagemService mensagemService, IConfiguration configuration)
        {
            _logger = logger;
            _mensagemService = mensagemService;
            _config = configuration;
        }

        public IActionResult Index()
        {
            ViewData["msg123"] = _mensagemService.GetMensagem() + " - " + _config["mensagem"];

            return View();
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

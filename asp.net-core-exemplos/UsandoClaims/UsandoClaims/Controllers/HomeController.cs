using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsandoClaims.Models;
using Microsoft.AspNetCore.Authorization;

namespace UsandoClaims.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Claims = User.Claims;
            return View();
        }

        [Authorize(Policy ="CEO")]
        public IActionResult Diretor()
        {
            return View();
        }

        [Authorize(Policy = "ADMIN")]
        public IActionResult Funcionario()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [AllowAnonymous]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

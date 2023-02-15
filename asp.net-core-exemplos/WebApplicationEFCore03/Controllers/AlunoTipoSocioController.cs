using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationEFCore03.Models;

namespace WebApplicationEFCore03.Controllers
{
    public class AlunoTipoSocioController : Controller
    {
        private AlunoContext _context;
        public AlunoTipoSocioController(AlunoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //Eager loading, incluir FK
            var infoAluno = _context.AlunosEF.Include(tp => tp.TipoSocio).ToList();

            return View(infoAluno);
        }
    }
}

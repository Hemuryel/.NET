using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationEFCore03.Models;

namespace WebApplicationEFCore03.Controllers
{
    public class TesteController : Controller
    {
        private AlunoContext _context;

        public TesteController(AlunoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // LINQ = execução adiada, ToList força execução imediata, traz todos registros
            List<Aluno> alunos = _context.AlunosEF.ToList();

            // outros exemplos
            // var alunos2 = from a in _context.AlunosEF select a;
            // var alunos3 = _context.AlunosEF.OrderBy(a => a.Nome);
            // var alunos4 = _context.AlunosEF.Where(a => a.Id == 1);
            // var alunos5 = _context.AlunosEF.First();
            // var alunos6 = _context.AlunosEF.Single();

            return View(alunos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // evita ataque Cross Site
        //[Bind] restringir campos aceitos, restante é descartado
        public IActionResult Create([Bind("Id,Nome,Sexo,Email,Nascimento")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluno);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

          
            var aluno = _context.AlunosEF.SingleOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Nome,Sexo,Email,Nascimento")] Aluno aluno)
        {
            if (id != aluno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aluno);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlunoExists(id))
                    {
                        return NotFound();
                    }
                    else 
                    {
                        throw;   
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }

        private bool AlunoExists(int id)
        {
            return _context.AlunosEF.Any(e => e.Id == id);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) 
                NotFound();

            var aluno = _context.AlunosEF.SingleOrDefault(a => a.Id == id);

            if (aluno == null)
                NotFound();

            return View(aluno);
        }

        [HttpPost, ActionName("Delete")] // responde para action "Delete" Post
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmar(int? id)
        {
            var aluno = _context.AlunosEF.SingleOrDefault(a => a.Id == id);
            
            //_context.AlunosEF.Remove(aluno);

            //outra forma
            _context.Entry(aluno).State = EntityState.Deleted;

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet, ActionName("Details")]
        public IActionResult Detalhe(int? id)
        {

            if (id == null)
                return NotFound();

            var aluno = _context.AlunosEF.SingleOrDefault(a => a.Id == id);

            if (aluno == null)
                return NotFound();

            return View("Detalhe", aluno); //padrão Details.cshtml por causa da ActionName
        }

    }
}

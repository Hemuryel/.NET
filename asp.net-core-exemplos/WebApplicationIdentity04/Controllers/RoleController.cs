using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplicationIdentity04.Data;

namespace WebApplicationIdentity04.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        
        public RoleController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            this._context = context;
            this._roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var Roles = _context.Roles.ToList();
            return View(Roles);
        }

        public IActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole Role)
        {
            IdentityResult roleResult = await _roleManager.CreateAsync(new IdentityRole(Role.Name));
            return RedirectToAction("Index");
        }
    }
}

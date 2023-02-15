using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplicationWebAPI01.Models;
using WebApplicationWebAPI01.ViewModels;

namespace WebApplicationWebAPI01.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<MeuUserIdentity> userManager;
        private readonly SignInManager<MeuUserIdentity> loginManager;
        private readonly RoleManager<MeuRoleIdentity> roleManager;

        public AccountController(UserManager<MeuUserIdentity> userManager,
           SignInManager<MeuUserIdentity> loginManager,
           RoleManager<MeuRoleIdentity> roleManager)
        {
            this.userManager = userManager;
            this.loginManager = loginManager;
            this.roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel obj)
        {
            if (ModelState.IsValid)
            {
                MeuUserIdentity user = new MeuUserIdentity();
                user.UserName = obj.UserName;
                user.Email = obj.Email;

                IdentityResult result = userManager.CreateAsync(user, obj.Password).Result;

                if (result.Succeeded)
                {
                    if (!roleManager.RoleExistsAsync("Admin").Result)
                    {
                        MeuRoleIdentity role = new MeuRoleIdentity();
                        role.Name = "Admin";
                        role.Descricao = "Realiza operações básicas.";
                        IdentityResult roleResult = roleManager.
                        CreateAsync(role).Result;
                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "Error ao criar o perfil!");
                            return View(obj);
                        }
                    }

                    userManager.AddToRoleAsync(user, "Admin").Wait();
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(obj);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel obj)
        {
            if (ModelState.IsValid)
            {
                MeuUserIdentity user = new MeuUserIdentity();
                user.UserName = obj.UserName;

                // não funcionando, versão antiga era string, versão atual mudou para UserIdentity o 1º parâmetro
                // ver projeto GalaxiaAPI
                var result = loginManager.PasswordSignInAsync(user, obj.Password, false, false).Result;

                if (result.Succeeded)
                {
                    return Content("Usuário Autorizado");
                }

                ModelState.AddModelError("", "Login Invalido!");
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            loginManager.SignOutAsync().Wait();
            return RedirectToAction("Login", "Account");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using WebAPI_Jwt.ViewModels;

namespace WebAPI_Jwt.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.Email == "macoratti@gmail.com" && model.Password == "numsey")
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            return Redirect("/Account/Login");
        }


    }
}
using Microsoft.AspNetCore.Mvc;
using MVCUserLogin.BAL;
using MVCUserLogin.Models;

namespace MVCUserLogin.Controllers
{
    public class UserController : Controller
    {
        private readonly ILoginService loginService;

        public UserController(ILoginService _loginService)
        {
            this.loginService = _loginService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(LoginViewModel loginVM)
        {
            if (ModelState.IsValid == true)
            {
                var userVM = loginService.GetUser(loginVM);

                if (userVM.Name != null)
                {
                    HttpContext.Session.SetString("Name", userVM.Name);
                    return RedirectToAction("Index", "Dashboard");
                }
                TempData["WrongCredential"] = "Email id or password is wrong";
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "User");
        }
    }
}

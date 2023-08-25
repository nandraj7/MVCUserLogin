using Microsoft.AspNetCore.Mvc;
using MVCUserLogin.BAL;
using MVCUserLogin.Models;

namespace MVCUserLogin.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService _accountService)
        {
            this.accountService = _accountService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddViewModel addVM = new AddViewModel();
            return View(addVM);
        }

        [HttpPost]

        public IActionResult Add(AddViewModel addVM)
        {
            if (ModelState.IsValid == true)
            {
                accountService.AddUser(addVM);
                return RedirectToAction("Index", "Dashboard");
            }
            return View(addVM);
        }
    }
}

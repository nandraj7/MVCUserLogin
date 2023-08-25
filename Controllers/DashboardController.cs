using Microsoft.AspNetCore.Mvc;

namespace MVCUserLogin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

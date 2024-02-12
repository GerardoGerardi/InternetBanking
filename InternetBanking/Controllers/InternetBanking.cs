using Microsoft.AspNetCore.Mvc;

namespace InternetBanking.Controllers
{
    public class InternetBanking : Controller
    {
        public IActionResult BankCardsList()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registation()
        {
            return View("About");
        }

        public IActionResult About()
        {
            return View();
        }
    }
}

using InternetBanking.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InternetBanking.Controllers
{
    public class InternetBanking : Controller
    {
        private readonly ILogger<InternetBanking> _logger;

        public InternetBanking(ILogger<InternetBanking> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

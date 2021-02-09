using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Needy.Models;
using System.Diagnostics;

namespace Needy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
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
        
        [HttpPost]
        public IActionResult Emergency(string nome, string cpf, string rg)
        {
            ViewBag.Nome = nome;

            return View();
        }

        [HttpPost]
        public IActionResult Crimes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Waiting()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Fire()
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

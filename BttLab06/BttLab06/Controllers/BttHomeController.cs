using System.Diagnostics;
using BttLab06.Models;
using Microsoft.AspNetCore.Mvc;

namespace BttLab06.Controllers
{
    public class BttHomeController : Controller
    {
        private readonly ILogger<BttHomeController> _logger;

        public BttHomeController(ILogger<BttHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult BttIndex()
        {
            return View();
        }

        public IActionResult BttAbout()
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

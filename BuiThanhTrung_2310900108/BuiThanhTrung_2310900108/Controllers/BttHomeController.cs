using System.Diagnostics;
using BuiThanhTrung_2310900108.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuiThanhTrung_2310900108.Controllers
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

        public IActionResult BttPrivacy()
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

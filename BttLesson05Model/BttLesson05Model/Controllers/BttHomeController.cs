using System.Diagnostics;
using BttLesson05Model.Models;
using BttLesson05Model.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace BttLesson05Model.Controllers
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
            BttMember bttMember = new BttMember();
            bttMember.BttMemberId = Guid.NewGuid().ToString();
            bttMember.BttUserName = "ThanhTrung";
            bttMember.BttPassword = "123456@";
            bttMember.BttFullName = "Bùi Thành Trung";
            bttMember.BttEmail = "buitrung4212@gmail.com";
            return View(bttMember);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

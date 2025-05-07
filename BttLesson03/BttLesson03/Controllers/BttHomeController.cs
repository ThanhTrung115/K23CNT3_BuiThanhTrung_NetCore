using Microsoft.AspNetCore.Mvc;

namespace BttLesson03.Controllers
{
    public class BttHomeController : Controller
    {
        public IActionResult BttHome()
        {
            return View();
        }

        public IActionResult BttAbout()
        {
            return View();
        }
    }
}

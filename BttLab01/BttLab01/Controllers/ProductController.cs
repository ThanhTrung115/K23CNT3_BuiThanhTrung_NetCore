using Microsoft.AspNetCore.Mvc;

namespace BttLab01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

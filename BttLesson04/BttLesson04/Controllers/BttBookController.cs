using System.Diagnostics;
using BttLesson04.Models;
using Microsoft.AspNetCore.Mvc;

namespace BttLesson04.Controllers
{
    public class BttBookController : Controller
    {
        protected BttBook bttBook = new BttBook();
        //GET: /BttBook/BttIndex => Lấy tất cả các cuốn sách
        public IActionResult BttIndex()
        {
            var bttBooks = bttBook.GetBttBookList();
            return View(bttBooks);
        }

        //GET: /BttBook/BttCreate
        public IActionResult BttCreate()
        {
            BttBook bttBook = new BttBook();
            return View(bttBook);
        }

        //POST: /BttBook/BttCreateSubmit
        [HttpPost]
        public IActionResult BttCreateSubmit(BttBook bttBook)
        {
            return RedirectToAction("BttIndex");
        }

        //GET: /BttBook/BttEdit
        public IActionResult BttEdit(string id)
        {
            BttBook model = bttBook.GetBttBookById(id);
            return View(model);
        }

        //POST: /BttBook/BttEditSubmit
        public IActionResult BttEditSubmit()
        {
            // ...
            return RedirectToAction("BttIndex");
        }
    }
}

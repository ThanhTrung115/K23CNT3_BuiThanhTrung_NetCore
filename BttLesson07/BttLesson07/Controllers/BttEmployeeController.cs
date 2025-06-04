using BttLesson07.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BttLesson07.Controllers
{
    public class BttEmployeeController : Controller
    {
        // Mock Data:
        private static List<BttEmployee> bttListEmployeee = new List<BttEmployee>()
        {
            new BttEmployee { BttId = 1, BttName = "Bùi Thành Trung", BttBirthDay = new DateTime(2005, 5, 11), BttEmail = "buitrung4212@gmail.com", BttPhone = "0969021769", BttSalary = 12000000m, BttStatus = true },
            new BttEmployee { BttId = 2, BttName = "Tran Thi B", BttBirthDay = new DateTime(1988, 3, 25), BttEmail = "b.tran@example.com", BttPhone = "0912345678", BttSalary = 15000000m, BttStatus = true },
            new BttEmployee { BttId = 3, BttName = "Le Van C", BttBirthDay = new DateTime(1995, 11, 3), BttEmail = "c.le@example.com", BttPhone = "0934567890", BttSalary = 10000000m, BttStatus = false },
            new BttEmployee { BttId = 4, BttName = "Pham Thi D", BttBirthDay = new DateTime(1992, 7, 19), BttEmail = "d.pham@example.com", BttPhone = "0945678901", BttSalary = 13000000m, BttStatus = true },
            new BttEmployee { BttId = 5, BttName = "Do Van E", BttBirthDay = new DateTime(1985, 1, 30), BttEmail = "e.do@example.com", BttPhone = "0956789012", BttSalary = 11000000m, BttStatus = false }
        };
        // GET: BttEmployeeController
        public ActionResult BttIndex()
        {
            return View(bttListEmployeee);
        }

        // GET: BttEmployeeController/Details/5
        public ActionResult BttDetails(int id)
        {
            var bttEmployee = bttListEmployeee.FirstOrDefault(x => x.BttId == id);
            return View(bttEmployee);
        }

        // GET: BttEmployeeController/Create
        public ActionResult BttCreate()
        {
            var bttEmployee = new BttEmployee();
            return View(bttEmployee);
        }

        // POST: BttEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BttCreate(BttEmployee bttModel)
        {
            try
            {
                //Thêm mới nhân viên vào list
                bttModel.BttId = bttListEmployeee.Max(x => x.BttId) + 1;
                bttListEmployeee.Add(bttModel);
                return RedirectToAction(nameof(BttIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: BttEmployeeController/Edit/5
        public ActionResult BttEdit(int id)
        {
            var bttEmployee = bttListEmployeee.FirstOrDefault(x => x.BttId == id);
            return View(bttEmployee);
        }

        // POST: BttEmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BttEdit(int id, BttEmployee bttModel)
        {
            try
            {
                for (int i = 0; i < bttListEmployeee.Count(); i++)
                {
                    if (bttListEmployeee[i].BttId == id)
                    {
                        bttListEmployeee[i] = bttModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(BttIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: BttEmployeeController/Delete/5
        public ActionResult BttDelete(int id)
        {
            var bttEmployee = bttListEmployeee.FirstOrDefault(x => x.BttId == id);
            return View(bttListEmployeee);
        }

        // POST: BttEmployeeController/Delete/5
        [HttpPost, ActionName("BttDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult BttDelete(int id, BttEmployee bttModel)
        {
            try
            {
                var employeeToDelete = bttListEmployeee.FirstOrDefault(x => x.BttId == id);
                if (employeeToDelete != null)
                {
                    bttListEmployeee.Remove(employeeToDelete); // Perform the actual deletion
                }
                return RedirectToAction(nameof(BttIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}

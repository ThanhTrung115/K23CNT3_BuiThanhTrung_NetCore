using BttLab06.Models;
using Microsoft.AspNetCore.Mvc;

namespace BttLab06.Controllers
{
    public class BttEmployeeController : Controller
    {
        private static List<BttEmployee> bttListEmployeee = new List<BttEmployee>()
        {
            new BttEmployee { BttId = 1, BttName = "Bùi Thành Trung", BttBirthDay = new DateTime(2005, 5, 11), BttEmail = "buitrung4212@gmail.com", BttPhone = "0969021769", BttSalary = 12000000m, BttStatus = true },
            new BttEmployee { BttId = 2, BttName = "Tran Thi B", BttBirthDay = new DateTime(1988, 3, 25), BttEmail = "b.tran@example.com", BttPhone = "0912345678", BttSalary = 15000000m, BttStatus = true },
            new BttEmployee { BttId = 3, BttName = "Le Van C", BttBirthDay = new DateTime(1995, 11, 3), BttEmail = "c.le@example.com", BttPhone = "0934567890", BttSalary = 10000000m, BttStatus = false },
            new BttEmployee { BttId = 4, BttName = "Pham Thi D", BttBirthDay = new DateTime(1992, 7, 19), BttEmail = "d.pham@example.com", BttPhone = "0945678901", BttSalary = 13000000m, BttStatus = true },
            new BttEmployee { BttId = 5, BttName = "Do Van E", BttBirthDay = new DateTime(1985, 1, 30), BttEmail = "e.do@example.com", BttPhone = "0956789012", BttSalary = 11000000m, BttStatus = false }
        };
        public IActionResult BttIndex()
        {
            return View(bttListEmployeee);
        }
        public IActionResult BttCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BttCreateSubmit(BttEmployee model)
        {
            if (ModelState.IsValid)
            {
                int newId = bttListEmployeee.Any() ? bttListEmployeee.Max(e => e.BttId) + 1 : 1;
                model.BttId = newId;
                bttListEmployeee.Add(model);
                return RedirectToAction("BttIndex");
            }
            return View(model);
        }
        public IActionResult BttEdit(int id)
        {
            var employee = bttListEmployeee.FirstOrDefault(e => e.BttId == id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        [HttpPost]
        public IActionResult BttEditSubmit(BttEmployee model)
        {
            if (ModelState.IsValid)
            {
                var existingEmployee = bttListEmployeee.FirstOrDefault(e => e.BttId == model.BttId);

                if (existingEmployee != null)
                {
                    existingEmployee.BttName = model.BttName;
                    existingEmployee.BttBirthDay = model.BttBirthDay;
                    existingEmployee.BttEmail = model.BttEmail;
                    existingEmployee.BttPhone = model.BttPhone;
                    existingEmployee.BttSalary = model.BttSalary;
                    existingEmployee.BttStatus = model.BttStatus;

                    return RedirectToAction("BttIndex");
                }
                else
                {
                    ModelState.AddModelError("", "Không tìm thấy nhân viên cần cập nhật.");
                }
            }
            return View("BttEdit", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BttDelete(int id)
        {
            var employeeToDelete = bttListEmployeee.FirstOrDefault(e => e.BttId == id);
            if (employeeToDelete != null)
            {
                bttListEmployeee.Remove(employeeToDelete);
                return RedirectToAction("BttIndex");
            }
            return NotFound();
        }
    }
}

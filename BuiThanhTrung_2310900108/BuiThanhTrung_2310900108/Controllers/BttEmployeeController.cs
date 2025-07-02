using BuiThanhTrung_2310900108.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuiThanhTrung_2310900108.Controllers
{
    public class BttEmployeeController : Controller
    {
        private static List<BttEmployee> bttListEmployee = new List<BttEmployee>()
        {
            new BttEmployee { bttEmpId = 1, bttEmpName = "Bui Thanh Trung", bttEmpLevel = 3, bttEmpStartDate = new DateTime(2005, 5, 11), bttEmpStatus = true },
            new BttEmployee { bttEmpId = 2, bttEmpName = "Nguyen Van A", bttEmpLevel = 2, bttEmpStartDate = new DateTime(2022, 5, 10), bttEmpStatus = false },
            new BttEmployee { bttEmpId = 3, bttEmpName = "Le Thi B", bttEmpLevel = 1, bttEmpStartDate = new DateTime(2024, 1, 15), bttEmpStatus = true }
        };
        // GET: BttEmployeeController1
        public ActionResult BttIndex()
        {
            return View(bttListEmployee);
        }

        // GET: BttEmployeeController1/Details/5
        public ActionResult BttDetails(int id)
        {
            var bttEmployee = bttListEmployee.FirstOrDefault(x => x.bttEmpId == id);
            return View(bttEmployee);
        }

        // GET: BttEmployeeController1/Create
        public ActionResult BttCreate()
        {
            var bttEmployee = new BttEmployee();
            return View(bttEmployee);
        }

        // POST: BttEmployeeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BttCreate(BttEmployee bttModel)
        {
            try
            {
                bttModel.bttEmpId = bttListEmployee.Max(x => x.bttEmpId) + 1;
                bttListEmployee.Add(bttModel);
                return RedirectToAction(nameof(BttIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: BttEmployeeController1/Edit/5
        public ActionResult BttEdit(int id)
        {
            var bttEmployee = bttListEmployee.FirstOrDefault(x => x.bttEmpId == id);
            return View(bttEmployee);
        }

        // POST: BttEmployeeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BttEdit(int id, BttEmployee bttModel)
        {
            try
            {
                for (int i = 0; i < bttListEmployee.Count(); i++)
                {
                    if (bttListEmployee[i].bttEmpId == id)
                    {
                        bttListEmployee[i] = bttModel;
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

        // GET: BttEmployeeController1/Delete/5
        public ActionResult BttDelete(int id)
        {
            var bttEmployee = bttListEmployee.FirstOrDefault(x => x.bttEmpId == id);
            return View(bttEmployee);
        }


        // POST: BttEmployeeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BttDelete(int id, BttEmployee bttModel)
        {
            try
            {
                for (int i = 0; i < bttListEmployee.Count; i++)
                {
                    if (bttListEmployee[i].bttEmpId == id)
                    {
                        bttListEmployee.RemoveAt(i);
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
    }
}

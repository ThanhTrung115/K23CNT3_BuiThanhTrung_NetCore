using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuiThanhTrung_2310900108.Models;

namespace BuiThanhTrung_2310900108.Controllers
{
    public class BttEmployeesController : Controller
    {
        private readonly BttDbContext _context;

        public BttEmployeesController(BttDbContext context)
        {
            _context = context;
        }

        // GET: BttEmployees
        public async Task<IActionResult> BttIndex()
        {
            return View(await _context.BttEmployees.ToListAsync());
        }

        // GET: BttEmployees/Details/5
        public async Task<IActionResult> BttDetails(int? BttEmpId)
        {
            if (BttEmpId == null)
            {
                return NotFound();
            }

            var bttEmployee = await _context.BttEmployees
                .FirstOrDefaultAsync(m => m.BttEmpId == BttEmpId);
            if (bttEmployee == null)
            {
                return NotFound();
            }

            return View(bttEmployee);
        }

        // GET: BttEmployees/Create
        public IActionResult BttCreate()
        {
            return View();
        }

        // POST: BttEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BttCreate([Bind("BttEmpId,BttEmpName,BttEmpLevel,BttEmpStartDate,BttEmpStatus")] BttEmployee bttEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bttEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bttEmployee);
        }

        // GET: BttEmployees/Edit/5
        public async Task<IActionResult> BttEdit(int? BttEmpId)
        {
            if (BttEmpId == null)
            {
                return NotFound();
            }

            var bttEmployee = await _context.BttEmployees.FindAsync(BttEmpId);
            if (bttEmployee == null)
            {
                return NotFound();
            }
            return View(bttEmployee);
        }

        // POST: BttEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BttEdit(int BttEmpId, [Bind("BttEmpId,BttEmpName,BttEmpLevel,BttEmpStartDate,BttEmpStatus")] BttEmployee bttEmployee)
        {
            if (BttEmpId != bttEmployee.BttEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bttEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BttEmployeeExists(bttEmployee.BttEmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bttEmployee);
        }

        // GET: BttEmployees/Delete/5
        public async Task<IActionResult> BttDelete(int? BttEmpId)
        {
            if (BttEmpId == null)
            {
                return NotFound();
            }

            var bttEmployee = await _context.BttEmployees
                .FirstOrDefaultAsync(m => m.BttEmpId == BttEmpId);
            if (bttEmployee == null)
            {
                return NotFound();
            }

            return View(bttEmployee);
        }

        // POST: BttEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BttDeleteConfirmed(int BttEmpId)
        {
            var bttEmployee = await _context.BttEmployees.FindAsync(BttEmpId);
            if (bttEmployee != null)
            {
                _context.BttEmployees.Remove(bttEmployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BttEmployeeExists(int BttEmpId)
        {
            return _context.BttEmployees.Any(e => e.BttEmpId == BttEmpId);
        }
    }
}

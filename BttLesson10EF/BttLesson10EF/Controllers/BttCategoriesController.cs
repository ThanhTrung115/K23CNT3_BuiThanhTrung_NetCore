using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BttLesson10EF.Models;

namespace BttLesson10EF.Controllers
{
    public class BttCategoriesController : Controller
    {
        private readonly BttK23cnt3lesson10DbContext _context;

        public BttCategoriesController(BttK23cnt3lesson10DbContext context)
        {
            _context = context;
        }

        // GET: BttCategories
        public async Task<IActionResult> BttIndex()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: BttCategories/Details/5
        public async Task<IActionResult> BttDetails(int? bttId)
        {
            if (bttId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CateId == bttId);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: BttCategories/Create
        public IActionResult BttCreate()
        {
            return View();
        }

        // POST: BttCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BttCreate([Bind("CateId,CateName,CateStaus")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(BttIndex));
            }
            return View(category);
        }

        // GET: BttCategories/Edit/5
        public async Task<IActionResult> BttEdit(int? bttId)
        {
            if (bttId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(bttId);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: BttCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BttEdit(int bttId, [Bind("CateId,CateName,CateStaus")] Category category)
        {
            if (bttId != category.CateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CateId))
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
            return View(category);
        }

        // GET: BttCategories/Delete/5
        public async Task<IActionResult> BttDelete(int? bttId)
        {
            if (bttId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CateId == bttId);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: BttCategories/Delete/5
        [HttpPost, ActionName("BttDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int bttId)
        {
            var category = await _context.Categories.FindAsync(bttId);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BttIndex));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CateId == id);
        }
    }
}

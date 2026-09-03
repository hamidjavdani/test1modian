using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SM2.Models;

namespace SMService.Controllers
{
    public class ViewPardakhtMnsController : Controller
    {
        private readonly MunicipalityDbContext _context;

        public ViewPardakhtMnsController(MunicipalityDbContext context)
        {
            _context = context;
        }

        // GET: ViewPardakhtMns
        public async Task<IActionResult> Index()
        {
            return View(await _context.ViewPardakhtMns.ToListAsync());
        }

        // GET: ViewPardakhtMns/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewPardakhtMn = await _context.ViewPardakhtMns
                .FirstOrDefaultAsync(m => m.Idrow == id);
            if (viewPardakhtMn == null)
            {
                return NotFound();
            }

            return View(viewPardakhtMn);
        }

        // GET: ViewPardakhtMns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ViewPardakhtMns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idrow,Malek,Codemeli,Codeitem,Onvanitem,Pardakhti,Datepardakht,Shenasehghabz,Shomarepeygiri,State")] ViewPardakhtMn viewPardakhtMn)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viewPardakhtMn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewPardakhtMn);
        }

        // GET: ViewPardakhtMns/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewPardakhtMn = await _context.ViewPardakhtMns.FindAsync(id);
            if (viewPardakhtMn == null)
            {
                return NotFound();
            }
            return View(viewPardakhtMn);
        }

        // POST: ViewPardakhtMns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("Idrow,Malek,Codemeli,Codeitem,Onvanitem,Pardakhti,Datepardakht,Shenasehghabz,Shomarepeygiri,State")] ViewPardakhtMn viewPardakhtMn)
        {
            if (id != viewPardakhtMn.Idrow)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(viewPardakhtMn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ViewPardakhtMnExists(viewPardakhtMn.Idrow))
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
            return View(viewPardakhtMn);
        }

        // GET: ViewPardakhtMns/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewPardakhtMn = await _context.ViewPardakhtMns
                .FirstOrDefaultAsync(m => m.Idrow == id);
            if (viewPardakhtMn == null)
            {
                return NotFound();
            }

            return View(viewPardakhtMn);
        }

        // POST: ViewPardakhtMns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var viewPardakhtMn = await _context.ViewPardakhtMns.FindAsync(id);
            if (viewPardakhtMn != null)
            {
                _context.ViewPardakhtMns.Remove(viewPardakhtMn);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ViewPardakhtMnExists(decimal id)
        {
            return _context.ViewPardakhtMns.Any(e => e.Idrow == id);
        }
    }
}

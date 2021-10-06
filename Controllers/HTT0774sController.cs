using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HoangTrungThong774.Models;
using HoangTrungThong774.Data;

namespace HoangTrungThong774.Controllers
{
    public class HTT0774sController : Controller
    {
        private readonly ApplictionContext _context;

        public HTT0774sController(ApplictionContext context)
        {
            _context = context;
        }

        // GET: HTT0774s
        public async Task<IActionResult> Index()
        {
            return View(await _context.HTT0774.ToListAsync());
        }

        // GET: HTT0774s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hTT0774 = await _context.HTT0774
                .FirstOrDefaultAsync(m => m.HTTId == id);
            if (hTT0774 == null)
            {
                return NotFound();
            }

            return View(hTT0774);
        }

        // GET: HTT0774s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HTT0774s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HTTId,HTTName,HTTGender")] HTT0774 hTT0774)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hTT0774);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hTT0774);
        }

        // GET: HTT0774s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hTT0774 = await _context.HTT0774.FindAsync(id);
            if (hTT0774 == null)
            {
                return NotFound();
            }
            return View(hTT0774);
        }

        // POST: HTT0774s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HTTId,HTTName,HTTGender")] HTT0774 hTT0774)
        {
            if (id != hTT0774.HTTId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hTT0774);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HTT0774Exists(hTT0774.HTTId))
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
            return View(hTT0774);
        }

        // GET: HTT0774s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hTT0774 = await _context.HTT0774
                .FirstOrDefaultAsync(m => m.HTTId == id);
            if (hTT0774 == null)
            {
                return NotFound();
            }

            return View(hTT0774);
        }

        // POST: HTT0774s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hTT0774 = await _context.HTT0774.FindAsync(id);
            _context.HTT0774.Remove(hTT0774);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HTT0774Exists(string id)
        {
            return _context.HTT0774.Any(e => e.HTTId == id);
        }
    }
}

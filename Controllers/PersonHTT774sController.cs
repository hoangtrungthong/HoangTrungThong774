using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HoangTrungThong774.Models;

namespace HoangTrungThong774.Controllers
{
    public class PersonHTT774sController : Controller
    {
        private readonly ApplictionContext _context;

        public PersonHTT774sController(ApplictionContext context)
        {
            _context = context;
        }

        // GET: PersonHTT774s
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonHTT774.ToListAsync());
        }

        // GET: PersonHTT774s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personHTT774 = await _context.PersonHTT774
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personHTT774 == null)
            {
                return NotFound();
            }

            return View(personHTT774);
        }

        // GET: PersonHTT774s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonHTT774s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonHTT774 personHTT774)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personHTT774);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personHTT774);
        }

        // GET: PersonHTT774s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personHTT774 = await _context.PersonHTT774.FindAsync(id);
            if (personHTT774 == null)
            {
                return NotFound();
            }
            return View(personHTT774);
        }

        // POST: PersonHTT774s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonHTT774 personHTT774)
        {
            if (id != personHTT774.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personHTT774);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonHTT774Exists(personHTT774.PersonId))
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
            return View(personHTT774);
        }

        // GET: PersonHTT774s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personHTT774 = await _context.PersonHTT774
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personHTT774 == null)
            {
                return NotFound();
            }

            return View(personHTT774);
        }

        // POST: PersonHTT774s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personHTT774 = await _context.PersonHTT774.FindAsync(id);
            _context.PersonHTT774.Remove(personHTT774);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonHTT774Exists(string id)
        {
            return _context.PersonHTT774.Any(e => e.PersonId == id);
        }
    }
}

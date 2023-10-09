using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EX0072.Context;
using EX0072.Models;

namespace EX0072.Controllers
{
    public class CookieGameController : Controller
    {
        private readonly AppDbContext _context;

        public CookieGameController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CookieGame
        public async Task<IActionResult> Index()
        {
              return _context.Cookies != null ? 
                          View(await _context.Cookies.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Cookies'  is null.");
        }

        // GET: CookieGame/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cookies == null)
            {
                return NotFound();
            }

            var cookie = await _context.Cookies
                .FirstOrDefaultAsync(m => m.JogoId == id);
            if (cookie == null)
            {
                return NotFound();
            }

            return View(cookie);
        }

        // GET: CookieGame/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CookieGame/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JogoId,Nome,Descricao,imagem,Ativo")] Cookie cookie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cookie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cookie);
        }

        // GET: CookieGame/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cookies == null)
            {
                return NotFound();
            }

            var cookie = await _context.Cookies.FindAsync(id);
            if (cookie == null)
            {
                return NotFound();
            }
            return View(cookie);
        }

        // POST: CookieGame/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JogoId,Nome,Descricao,imagem,Ativo")] Cookie cookie)
        {
            if (id != cookie.JogoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cookie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CookieExists(cookie.JogoId))
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
            return View(cookie);
        }

        // GET: CookieGame/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cookies == null)
            {
                return NotFound();
            }

            var cookie = await _context.Cookies
                .FirstOrDefaultAsync(m => m.JogoId == id);
            if (cookie == null)
            {
                return NotFound();
            }

            return View(cookie);
        }

        // POST: CookieGame/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cookies == null)
            {
                return Problem("Entity set 'AppDbContext.Cookies'  is null.");
            }
            var cookie = await _context.Cookies.FindAsync(id);
            if (cookie != null)
            {
                _context.Cookies.Remove(cookie);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CookieExists(int id)
        {
          return (_context.Cookies?.Any(e => e.JogoId == id)).GetValueOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Kiddo.Models
{
    public class RequisitadoresController : Controller
    {
        private readonly KiddoContext _context;

        public RequisitadoresController(KiddoContext context)
        {
            _context = context;
        }

        // GET: Requisitadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Requisitador.ToListAsync());
        }

        // GET: Requisitadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisitador = await _context.Requisitador
                .FirstOrDefaultAsync(m => m.ID == id);
            if (requisitador == null)
            {
                return NotFound();
            }

            return View(requisitador);
        }

        // GET: Requisitadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Requisitadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Email,Password,Nome,Foto,Localizacao,Contacto,Pagamento")] Requisitador requisitador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requisitador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requisitador);
        }

        // GET: Requisitadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisitador = await _context.Requisitador.FindAsync(id);
            if (requisitador == null)
            {
                return NotFound();
            }
            return View(requisitador);
        }

        // POST: Requisitadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Email,Password,Nome,Foto,Localizacao,Contacto,Pagamento")] Requisitador requisitador)
        {
            if (id != requisitador.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requisitador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequisitadorExists(requisitador.ID))
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
            return View(requisitador);
        }

        // GET: Requisitadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var requisitador = await _context.Requisitador
                .FirstOrDefaultAsync(m => m.ID == id);
            if (requisitador == null)
            {
                return NotFound();
            }

            return View(requisitador);
        }

        // POST: Requisitadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var requisitador = await _context.Requisitador.FindAsync(id);
            _context.Requisitador.Remove(requisitador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequisitadorExists(int id)
        {
            return _context.Requisitador.Any(e => e.ID == id);
        }
    }
}

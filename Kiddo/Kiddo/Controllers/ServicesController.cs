using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kiddo.Models;

namespace Kiddo.Controllers
{
    public class ServicesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Services
        public ActionResult Index()
        {
            var services = db.Services.Include(s => s.Babysitter).Include(s => s.Requisitador);
            return View(services.ToList());
        }

        // GET: Services/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = db.Services.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        // GET: Services/Create
        public ActionResult Create()
        {
            ViewBag.BabysitterId = new SelectList(db.Babysitters, "Id", "Email");
            ViewBag.RequisitadorId = new SelectList(db.Requisitadors, "Id", "Email");
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RequisitadorId,BabysitterId,date,duration,location,numberChildren,extra")] Service service)
        {
            if (ModelState.IsValid)
            {
                db.Services.Add(service);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BabysitterId = new SelectList(db.Babysitters, "Id", "Email", service.BabysitterId);
            ViewBag.RequisitadorId = new SelectList(db.Requisitadors, "Id", "Email", service.RequisitadorId);
            return View(service);
        }

        // GET: Services/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = db.Services.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            ViewBag.BabysitterId = new SelectList(db.Babysitters, "Id", "Email", service.BabysitterId);
            ViewBag.RequisitadorId = new SelectList(db.Requisitadors, "Id", "Email", service.RequisitadorId);
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RequisitadorId,BabysitterId,date,duration,location,numberChildren,extra")] Service service)
        {
            if (ModelState.IsValid)
            {
                db.Entry(service).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BabysitterId = new SelectList(db.Babysitters, "Id", "Email", service.BabysitterId);
            ViewBag.RequisitadorId = new SelectList(db.Requisitadors, "Id", "Email", service.RequisitadorId);
            return View(service);
        }

        // GET: Services/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service service = db.Services.Find(id);
            if (service == null)
            {
                return HttpNotFound();
            }
            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Service service = db.Services.Find(id);
            db.Services.Remove(service);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

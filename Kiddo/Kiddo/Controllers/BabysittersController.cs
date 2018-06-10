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
    public class BabysittersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Babysitters
        public ActionResult Index()
        {
            return View(db.Babysitters.ToList());
        }

        // GET: Babysitters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Babysitter babysitter = db.Babysitters.Find(id);
            if (babysitter == null)
            {
                return HttpNotFound();
            }
            return View(babysitter);
        }

        // GET: Babysitters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Babysitters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Email,Name,Age,Photo,City,PricePerHour")] Babysitter babysitter)
        {
            if (ModelState.IsValid)
            {
                db.Babysitters.Add(babysitter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(babysitter);
        }

        // GET: Babysitters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Babysitter babysitter = db.Babysitters.Find(id);
            if (babysitter == null)
            {
                return HttpNotFound();
            }
            return View(babysitter);
        }

        // POST: Babysitters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,Name,Age,Photo,City,PricePerHour")] Babysitter babysitter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(babysitter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(babysitter);
        }

        // GET: Babysitters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Babysitter babysitter = db.Babysitters.Find(id);
            if (babysitter == null)
            {
                return HttpNotFound();
            }
            return View(babysitter);
        }

        // POST: Babysitters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Babysitter babysitter = db.Babysitters.Find(id);
            db.Babysitters.Remove(babysitter);
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

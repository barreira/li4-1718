using Kiddo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kiddo.Controllers
{
    public class BabysitterController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Babysitter
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A nossa missão";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Estamos sempre disponíveis para o ajudar!";

            return View();
        }

        public ActionResult MyServices()
        {
            return View(db.Services.ToList());
        }
    }
}
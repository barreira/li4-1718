using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kiddo.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
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
    }
}
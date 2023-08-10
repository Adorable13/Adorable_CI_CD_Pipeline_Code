using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Favourites()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LatestNews()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
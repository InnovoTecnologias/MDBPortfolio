using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDBPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.RenderCarousel = false;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.RenderCarousel = false;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.RenderCarousel = false;
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.RenderCarousel = true;
            return View();
        }

        public ActionResult Variations()
        {
            ViewBag.RenderCarousel = false;
            return View();
        }
    }
}
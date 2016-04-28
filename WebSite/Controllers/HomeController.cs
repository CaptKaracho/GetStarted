using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Information = "Das ist der erste Text der MVC-Applikation!";
            return View();
        }

        public ActionResult About()
        {
            
            return View();
        }
    }
}
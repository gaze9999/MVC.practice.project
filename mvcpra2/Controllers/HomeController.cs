using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcpra2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }
        public ActionResult Works()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
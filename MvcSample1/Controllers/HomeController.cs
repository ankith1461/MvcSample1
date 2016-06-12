using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSample1.Models;

namespace MvcSample1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Msg = "sample data ";
            ViewData["hru"] = "hey hi";
            return View();
        }

        // GET: /Home/

        public ActionResult First()
        {
            ViewBag.Msg = "First data ";
            return View();
        }

        // GET: /Home/

        public ActionResult Second()
        {
            ViewBag.Msg = "Second data ";
            return View();
        }

        // GET: /Home/

        public ActionResult Third()
        {
            ViewBag.Msg = "Third data ";
            return View();
        }
        [HttpPost]
        public ActionResult Ankith(RegisterModel model)
        {
            return View();
        }


    }
}

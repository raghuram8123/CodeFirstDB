using CodeFirstDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            AppDBContext appDBContext = new AppDBContext();
            List<AntarcticPopulations> lst = new List<AntarcticPopulations>();
            lst = appDBContext.AntarcticPopulations.ToList();
            return View();
        }
    }
}

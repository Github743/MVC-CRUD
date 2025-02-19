using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCRUD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(!string.IsNullOrWhiteSpace(ConfigurationManager.ConnectionStrings["EmpConnection"].ConnectionString.ToString()))
            {
                ViewBag.Message = "Welcome to CRUD";
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
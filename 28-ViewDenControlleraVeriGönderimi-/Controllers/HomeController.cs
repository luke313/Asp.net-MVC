using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _28_ViewDenControlleraVeriGönderimi_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            string getWithparameter = name;
            string getRequestForm = Request.Form["name"];

            
            return View();
        }
    }
}
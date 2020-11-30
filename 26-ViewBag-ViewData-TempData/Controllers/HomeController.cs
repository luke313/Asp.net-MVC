using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _26_ViewBag_ViewData_TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["text1"] = "ViewData ile gönderilen içerik";
            ViewBag.text2 = "ViewBag ile gönderilen içerik";

            TempData["text3"] = "Tempdata kullanımı";
            return View();
        }

        public ActionResult TempDataForSecond()
        {
            return View();
        }
    }
}
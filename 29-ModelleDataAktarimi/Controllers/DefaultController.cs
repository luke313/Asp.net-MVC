using _29_ModelleDataAktarimi.Models;
using _29_ModelleDataAktarimi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _29_ModelleDataAktarimi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Kisi kisi)
        {
            return View(kisi);
        }

        public ActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Home(HomeViewModel model)
        {
            return View(model);
        }
    }
}
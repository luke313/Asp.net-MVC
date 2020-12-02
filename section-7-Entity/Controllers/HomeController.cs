using section_7_Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace section_7_Entity.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Burada database çağrıldığı anda DBContext constructor, SetInitiliazer ile Seed metodunu çağıracak
            DatabaseContext db = new DatabaseContext();
            db.UsersEntity.ToList(); // EF'de select atma işlemi
            return View();
        }
    }
}
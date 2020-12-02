using section_7_Entity.Context;
using section_7_Entity.ViewModels;
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
            
            /*DatabaseContext db = new DatabaseContext();
            db.UsersEntity.ToList(); // EF'de select atma işlemi*/
            return View();
        }

        public ActionResult HomePage()
        {
            DatabaseContext db = new DatabaseContext();
            HomePageViewModel hpvm = new HomePageViewModel()
            {
                Users = db.UsersEntity.ToList(),
                Addresses=db.AddressEntity.ToList()

            };
            return View(hpvm);
        }
    }
}
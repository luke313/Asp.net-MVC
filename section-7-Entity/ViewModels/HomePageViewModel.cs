using section_7_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace section_7_Entity.ViewModels
{
    public class HomePageViewModel
    {
        public List<Users> Users { get; set; }
        public List<Addresses> Addresses { get; set; }

         
    }
}
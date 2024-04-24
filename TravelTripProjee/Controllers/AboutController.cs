using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjee.Models.Sınıflar;

namespace TravelTripProjee.Controllers
{
    public class AboutController : Controller
    {
        Context cnt = new Context();

        //Hakkımızda Listeleme
        public ActionResult Index()
        {
            var deger = cnt.Hakkimizdas.ToList();
            return View(deger);
        }

        
      


    }
}
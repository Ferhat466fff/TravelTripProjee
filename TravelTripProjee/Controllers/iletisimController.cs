using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjee.Models.Sınıflar;

namespace TravelTripProjee.Controllers
{
    public class iletisimController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(iletisim iletisim)
        {
            db.iletisims.Add(iletisim);
            db.SaveChanges();
            return View();
        }
    }
}
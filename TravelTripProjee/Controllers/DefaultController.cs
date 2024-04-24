using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjee.Models.Sınıflar;

namespace TravelTripProjee.Controllers
{
    public class DefaultController : Controller
    {

        //Tıklandığında Home Gidecek
        Context db = new Context();
        public ActionResult Index()
        {
            var value = db.Blogs.Take(6).ToList();//İlk 6 Bloğu Getir.
            return View(value);
        }
        //Tıklandığında About(hakkımda) Gidecek
        public ActionResult About()
        {
            return View();
        }


        //Son 3 Gezdiğimiz Yerin Resimleri Listeleme  Css Bozulduğundan Dolayı Ayrı Ayrı Partial Oluşturup 3 Resmi bir araya aldık.
        public PartialViewResult Partial1()
        {
            var value = db.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();//Take(2)-->Son 2 atnesini alıyor 3 adet denedik ama css bozuldu
            return PartialView(value);
        }
        public PartialViewResult Partial2()
        {
            var value = db.Blogs.Where(x => x.ID==2).ToList();
            return PartialView(value);
        }


        //Son 10 Blog'u Listeleme
        public PartialViewResult Partial3()
        {
            var value = db.Blogs.Take(10).ToList();
            return PartialView(value);
        }

        //En beğendiğim Yerler Listeleme(Ayrı Ayrı Aldık Partial4-Partial5'i)
        public PartialViewResult Partial4()
        {
            var value = db.Blogs.Take(3).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial5()
        {
            var value = db.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(value);
        }









    }
}
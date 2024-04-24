using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjee.Models.Sınıflar;

namespace TravelTripProjee.Controllers
{
    public class BlogController : Controller
    {


        Context db = new Context();//Sınıfları Context Topladık Veriyi buradan alacagız.
        BlogYorum by = new BlogYorum();//Bir Viewde 2 Sınıfı Birden kullanmak için Oluşturduk.Değer1-->Blog Değer2-->Yorumlar değer3-->Son Yorumlar.
        //Blog Listesi
        public ActionResult Index()
        {
            by.Deger1 = db.Blogs.ToList();//Blogları Listelesin
            by.Deger3 = db.Blogs.OrderByDescending(x => x.Tarih).Take(3);//Take-->Al Son 3 Yorumu Al.
            by.Deger4 = db.Yorumlars.OrderByDescending(x => x.ID).Take(3);
            return View(by);
        }
        
      

        //Blog Başlığına Tıklanınca Blog Detay Sayfasına Gidip O Bloga Ait Yorumlar Gözükecek.

        public ActionResult BlogDetay(int id)
        {
            by.Deger1 = db.Blogs.Where(x => x.ID == id).ToList();//Blog Sınıfındaki Id ile tiklanlan Id Eşitse Listeleme Yapsın.
            by.Deger2 = db.Yorumlars.Where(x => x.BlogId == id).ToList();//Blog Sınıfındaki Id ile tiklanlan Id Eşitse yorumYapsın.
            return View(by);
        }

        //Yorum Yapma(Ekleme)

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.dgr = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            db.Yorumlars.Add(y);
            db.SaveChanges();
            return PartialView();
        }




    }
}
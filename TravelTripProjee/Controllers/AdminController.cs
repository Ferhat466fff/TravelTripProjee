using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProjee.Models.Sınıflar;
using System.Net;
using PagedList;
using PagedList.Mvc;

namespace TravelTripProjee.Controllers
{
    public class AdminController : Controller
    {
        Context db = new Context();

        //Blogları Listeleme Sayfalama Ve Arama
        [Authorize]
        public ActionResult Index(string parametre,int sayfa=1)
        {
            var degerler = from d in db.Blogs select d;
            if (!String.IsNullOrEmpty(parametre))//parametre boş değilse
            {
                degerler = degerler.Where(x => x.Baslik.Contains(parametre));
            }
            var value = degerler.ToList().ToPagedList(sayfa,4);//Sayfa 1den başlasın ve 4 erli bölünsün.
            return View(value);
        }

        //Blog Silme
        public ActionResult BlogSil(int id)
        {
            var value = db.Blogs.Find(id);
            db.Blogs.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Blog Ekleme
        [HttpGet]
        public ActionResult EkleBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EkleBlog(Blog b)
        {
            db.Blogs.Add(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Blog Güncelleme Ve Verileri Getirme
        [HttpGet]
        public ActionResult GuncelleBlog(int id)
        {//verileri taşıma
            var value = db.Blogs.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult GuncelleBlog(Blog Blog)
        {
            var value = db.Blogs.Find(Blog.ID);
            value.ID = Blog.ID;
            value.Baslik= Blog.Baslik;
            value.Tarih = Blog.Tarih;
            value.Aciklama = Blog.Aciklama;
            value.BlogImage = Blog.BlogImage;
            db.SaveChanges();
            return RedirectToAction("Index");
        }






        //Yorum listeleme
        public ActionResult YorumListeleme(int sayfa=1)
        {
            var value = db.Yorumlars.ToList().ToPagedList(sayfa, 4);
            return View(value);
        }
        //Yorum Silme
        public ActionResult YorumSil(int id)
        {
            var deger = db.Yorumlars.Find(id);
            db.Yorumlars.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("YorumListeleme");
            
        }
        //Yorum Güncelleme Ve Verileri Getirme
        [HttpGet]
        public ActionResult GuncelleYorum(int id)
        {//verileri taşıma
            var value = db.Yorumlars.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult GuncelleYorum(Yorumlar y)
        {
            var value = db.Yorumlars.Find(y.ID);
            value.ID = y.ID;
            value.KullaniciAdi = y.KullaniciAdi;
            value.Mail = y.Mail;
            value.Yorum = y.Yorum;
            db.SaveChanges();
            return RedirectToAction("YorumListeleme");
        }


        //İletişim Bilgilerini Listeleme
        public ActionResult iletisimListeleme()
        {
            var value = db.iletisims.ToList();
            return View(value);
        }
        public ActionResult Hakkımda()
        {
            return View();
        }
       






    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;//tanımla
using TravelTripProjee.Models.Sınıflar;

namespace TravelTripProjee.Controllers
{
    public class GirisYapController : Controller
    {
        Context db = new Context();
        //Admin Giriş Paneli

        //Kullanıcı Adı Ve Şifre Sorgulama
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin k)
        {
            var value = db.Admins.FirstOrDefault(x => x.Kullanici == k.Kullanici && x.Sifre == k.Sifre);
            //Parametredeki Bilgilerle Veri Tabanındaki Eşleşirse İzin ver.
           if(value !=null)
            {
                FormsAuthentication.SetAuthCookie(value.Kullanici,false);//Başarılı bir giriş olursa,Kullanıcı Bigileriyle bir çerez oluşturur.
                Session["Kullanici"] = value.Kullanici.ToString(); //Kullanıcının adını Session değişkeninde saklar.
                return RedirectToAction("Index", "Admin");//1.Parametre-->View 2.Parametre-->Controller
                //Logindede Bir İşlem Var Orayıda Yapınca Cookie Tamamlanmış Oluyor.
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış.");//1.Parametre-->neden hata oldu(""yapınca genel oluyor)2.Parametre-->Hata Mesajı
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }





    }
}
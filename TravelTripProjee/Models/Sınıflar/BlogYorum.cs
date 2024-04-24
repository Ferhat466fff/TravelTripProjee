using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TravelTripProjee.Models.Sınıflar
{
    public class BlogYorum
    {   //Bloglara Yorum İçin IEnumerable-->Koleksiyon Oluşturduk.
        public IEnumerable<Blog>Deger1{ get; set; }// IEnumerable-->Sayesinde Bir ViewdeBirden Fazla Değeri Kullanabileceğiz. //Bloglar
        public IEnumerable<Yorumlar> Deger2 { get; set; }//Yorumlar
        public IEnumerable<Blog> Deger3 { get; set; }//Yorumlar
        public IEnumerable<Yorumlar> Deger4 { get; set; }//Yorumlar

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TravelTripProjee.Models.Sınıflar
{
    public class Blog
    {   [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }

        //Icollection listeleme yapıyor blog kısmına yorumları listelmke istiyorduk
        public ICollection<Yorumlar> Yorumlars { get; set; }//Bir Blogun Birden Fazla Yorumu Olabilir(Bire-Cok) İlişki


    }
}
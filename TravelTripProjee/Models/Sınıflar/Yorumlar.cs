using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProjee.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]//Birincil Anahtar
        public int ID { get; set; }
        public String KullaniciAdi { get; set; }
        public String Mail { get; set; }
        public String Yorum { get; set; }

        //yorumlar blogla ilişkili
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }//Bir Yorum Bir Blog İçin Geçerli Olabilr.
    }
}
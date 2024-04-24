using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProjee.Models.Sınıflar
{
    public class AnaSayfa
    {
        [Key]//Birincil Anahtar
        public int ID { get; set; }
        public String Başlik { get; set; }
        public String Aciklama { get; set; }

    }
}
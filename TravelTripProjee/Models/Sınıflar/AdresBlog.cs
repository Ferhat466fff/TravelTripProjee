﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProjee.Models.Sınıflar
{
    public class AdresBlog
    {
        [Key]//Birincil Anahtar
        public int ID { get; set; }
        public String Baslik { get; set; }
        public String Aciklama { get; set; }
        public String AdresAcik { get; set; }
        public String Mail { get; set; }
        public String Telefon { get; set; }
        public String Konum { get; set; }
    }
}
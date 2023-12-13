using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class Iletisim
    {
        [Key]
        public int ID { get; set; }

        [Display(Name ="Ad Soyad")]
        public string AdSoyad { get; set; }
        [Display(Name = "Mail Adresiniz")]

        public string Mail { get; set; }
        [Display(Name = "Konu")]

        public string Konu { get; set; }
        [Display(Name = "Mesaj")]

        public string Mesaj { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string Gorsel { get; set; }
        public string Icerik { get; set; }
    }
}
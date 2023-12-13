using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class BlogGuncelleViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Lütfen başlık alanını doldurunuz.")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "Lütfen açıklama alanını doldurunuz.")]
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Lütfen tarih alanını doldurunuz.")]
        public DateTime Tarih { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }

        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı adı boş bırakılamaz.")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Mail boş bırakılamaz.")]

        public string Mail { get; set; }
        [Display(Name = "Yorum")]
        [Required(ErrorMessage = "Yorum boş bırakılamaz.")]

        public string Yorum { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blog{ get; set; }
    }
}
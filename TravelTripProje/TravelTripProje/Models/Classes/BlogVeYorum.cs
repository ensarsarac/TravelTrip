using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Models
{
    public class BlogVeYorum
    {
        public Blog blog { get; set; }
        public List<Yorumlar> yorumlar { get; set; }
        public List<Blog> bloglar{ get; set; }
        public List<Blog> son4blog{ get; set; }
        public List<Yorumlar> sonyorumlar{ get; set; }
    }
}
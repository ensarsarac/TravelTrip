using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Iletisim i)
        {
            Context c = new Context();
            c.Iletisims.Add(i);
            c.SaveChanges();
            return RedirectToAction("Index", "Default");
        }

        public PartialViewResult IletisimDiger()
        {
            Context c = new Context();
            return PartialView(c.AdresBlogs.FirstOrDefault());
        }





    }
}
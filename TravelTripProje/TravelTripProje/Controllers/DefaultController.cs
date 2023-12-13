using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            return View(c.Blogs.ToList());
        }

        public ActionResult About()
        {
            var values = c.Hakkimizdas.FirstOrDefault();
            return View(values);
        }

        public PartialViewResult Son3Blog()
        {
            var yorumlar = c.Blogs.OrderByDescending(x => x.Tarih).Take(3).ToList();
            return PartialView(yorumlar);
        }

        public PartialViewResult IndexPartial()
        {

            return PartialView(c.AnaSayfas.FirstOrDefault());
        }

        public PartialViewResult Son10BlogAnasayfa()
        {

            return PartialView(c.Blogs.OrderByDescending(x=>x.Tarih).Take(10).ToList());
        }

        public PartialViewResult BegendigimYerler()
        {
            var values = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult BegendigimYerler2()
        {
            var values = c.Blogs.Take(3).ToList();
            return PartialView(values);
        }

    }
}
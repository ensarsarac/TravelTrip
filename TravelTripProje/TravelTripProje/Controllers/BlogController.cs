using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models;
using TravelTripProje.Models.Classes;


namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogVeYorum b = new BlogVeYorum();
        public ActionResult Index()
        {
            b.son4blog = c.Blogs.OrderByDescending(x => x.Tarih).Take(4).ToList();
            b.bloglar = c.Blogs.ToList();
           
            return View(b);
        }

        public ActionResult BlogDetay(int id)
        {
            var value = c.Blogs.Find(id);

            ViewBag.yorumlar = c.Yorumlars.Where(x => x.BlogID == id);
            TempData["blogId"] = id;
            BlogVeYorum b = new BlogVeYorum()
            {
                blog = c.Blogs.Find(id),
                yorumlar = c.Yorumlars.Where(x => x.BlogID == id).ToList(),
                son4blog = c.Blogs.OrderByDescending(x => x.Tarih).Take(4).ToList(),

        };
            return View(b);
        }

        [HttpPost]
        public ActionResult YorumYap(string KullaniciAdi,string Mail,string Yorum)
        {
            Yorumlar y = new Yorumlar()
            {
                KullaniciAdi = KullaniciAdi,
                Mail = Mail,
                Yorum = Yorum,
                BlogID = (int)TempData["blogId"],
            };

            c.Yorumlars.Add(y);
            c.SaveChanges();

            return RedirectToAction("BlogDetay","Blog", new {id = TempData["blogId"] });
        }

        public PartialViewResult SonYorumlar()
        {
            b.sonyorumlar = c.Yorumlars.OrderByDescending(x => x.ID).Take(4).ToList();
            return PartialView(b);
        }




    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        public ActionResult Index(string sehir)
        {
            if (!String.IsNullOrEmpty(sehir))
            {
                var values = c.Blogs.Where(x => x.Baslik.Contains(sehir)).ToList();
                return View(values);
            }
            else
            {
                return View(c.Blogs.ToList());

            }
        }

        [HttpGet]
        public ActionResult BlogEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BlogEkle(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

        public ActionResult Sil(int id)
        {

            c.Blogs.Remove(c.Blogs.Find(id));
            c.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var value = c.Blogs.Find(id);
            BlogGuncelleViewModel bg = new BlogGuncelleViewModel()
            {
                ID = value.ID,
                Baslik = value.Baslik,
                Aciklama = value.Aciklama,
                Tarih = value.Tarih,
            };
            return View(bg);
        }

        [HttpPost]
        public ActionResult Guncelle(BlogGuncelleViewModel b)
        {
            if (ModelState.IsValid)
            {
                var values = c.Blogs.Find(b.ID);
                values.Baslik = b.Baslik;
                values.Aciklama = b.Aciklama;
                values.Tarih = b.Tarih;
                c.SaveChanges();
                return RedirectToAction("Index", "Admin");

            }
            else
            {
                return View(b);
            }

        }




    }
}
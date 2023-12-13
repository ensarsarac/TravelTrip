using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class YorumController : Controller
    {
        // GET: Yorum
        Context c = new Context();
        public ActionResult Index(string yorum)
        {
            if (!String.IsNullOrEmpty(yorum))
            {
                var values = c.Yorumlars.Where(x => x.Yorum.Contains(yorum)).ToList();
                return View(values);

            }
            else
            {
                var values = c.Yorumlars.ToList();
                return View(values);

            }
        }

        public ActionResult Sil(int id)
        {

            c.Yorumlars.Remove(c.Yorumlars.Find(id));
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {

            return View(c.Yorumlars.Find(id));
        }
        [HttpPost]
        public ActionResult Guncelle(Yorumlar y)
        {
            if (ModelState.IsValid)
            {
                var values = c.Yorumlars.Find(y.ID);
                values.KullaniciAdi = y.KullaniciAdi;
                values.Mail = y.Mail;
                values.Yorum = y.Yorum;
                c.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(y);
            }
            
        }



    }
}
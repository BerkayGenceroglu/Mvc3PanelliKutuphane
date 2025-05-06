using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
namespace MvcKutuphane.Controllers
{
    public class YazarController : Controller
    {
        // GET: Yaza
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var values = db.TBLYAZAR.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YazarEkle(TBLYAZAR yazar)
        {
            if (!ModelState.IsValid)
            {
                return View("YazarEkle");
            }
            db.TBLYAZAR.Add(yazar);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YazarSil(int id)
        {
           var value = db.TBLYAZAR.Find(id);
            db.TBLYAZAR.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YazarGetir(int id)
        {
            var value = db.TBLYAZAR.Find(id);
            return View("YazarGetir", value);
        }

        public ActionResult YazarGuncelle(TBLYAZAR yazar)
        {
            var yzr = db.TBLYAZAR.Find(yazar.ID);
            yzr.AD = yazar.AD;
            yzr.SOYAD = yazar.SOYAD;
            yzr.DETAY = yazar.DETAY;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YazarKitaplar(int id)
        {
            var value = db.TBLKITAP.Where(x => x.YAZAR == id).ToList();
            var yazaradi = db.TBLYAZAR.Where(x=>x.ID == id).Select(y=> y.AD+ " " + y.SOYAD).FirstOrDefault();
            ViewBag.yazaradi = yazaradi;
            return View(value);
        }
    }
}
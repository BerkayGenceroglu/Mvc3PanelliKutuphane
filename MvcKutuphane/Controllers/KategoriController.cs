using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var value = db.TBLKATEGORI.Where(x=> x.DURUM ==true).ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(TBLKATEGORI kategorı)
        {
            if (!ModelState.IsValid)
            {
                return View("KategoriEkle");
            }
            db.TBLKATEGORI.Add(kategorı);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriSil(int id)
        {
            var value = db.TBLKATEGORI.Find(id);
            value.DURUM = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult KategoriGuncelle(int id)
        {
            var value = db.TBLKATEGORI.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult KategoriGuncelle(TBLKATEGORI kategorı)
        {
            var value = db.TBLKATEGORI.Find(kategorı.ID);
            value.AD = kategorı.AD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
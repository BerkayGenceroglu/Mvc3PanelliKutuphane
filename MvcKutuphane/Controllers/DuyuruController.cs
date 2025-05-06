using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class DuyuruController : Controller
    {
        // GET: Duyuru
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var duyurular = db.TBLDUYURULAR.ToList();
            return View(duyurular);
        }

        [HttpGet]
        public ActionResult DuyuruEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DuyuruEkle(TBLDUYURULAR duyuru)
        {
            db.TBLDUYURULAR.Add(duyuru);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DuyuruGetir(int id)
        {
            var duyuru = db.TBLDUYURULAR.Find(id);
            return View(duyuru);
        }
        [HttpPost]
        public ActionResult DuyuruGetir(TBLDUYURULAR duyuru)
        {
            var newDuyuru = db.TBLDUYURULAR.Find(duyuru.ID);
            newDuyuru.KATEGORI = duyuru.KATEGORI;
            newDuyuru.ICERIK = duyuru.ICERIK;
            newDuyuru.TARIH = duyuru.TARIH;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
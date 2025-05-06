using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
using PagedList;
using PagedList.Mvc;



namespace MvcKutuphane.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index(int sayfa = 1)
        {
            var degerler = db.TBLUYELER.ToList().ToPagedList(sayfa, 4);
            return View(degerler);
        }
        //sayfa: Kaçıncı sayfa olduğunu belirtir.
        //4: Her sayfada kaç öğe gösterileceğini belirtir.Burada her sayfada 4 üye gösterilecek.
        //sayfa=1: Varsayılan olarak ilk sayfayı gösterir.
        [HttpGet]
        public ActionResult UyeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeEkle(TBLUYELER üye)
        {
            if (!ModelState.IsValid)
            {
                return View("UyeEkle");
            }
            db.TBLUYELER.Add(üye);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UyeSil(int id)
        {
            var uye = db.TBLUYELER.Find(id);
            db.TBLUYELER.Remove(uye);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UyeGetir(int id)
        {
            var uye = db.TBLUYELER.Find(id);
            return View("UyeGetir", uye);
        }
        public ActionResult UyeGuncelle(TBLUYELER uye)
        {
            var normal = db.TBLUYELER.Find(uye.ID);
            normal.AD = uye.AD;
            normal.SOYAD = uye.SOYAD;
            normal.MAIL = uye.MAIL;
            normal.KULLANICIADI = uye.KULLANICIADI;
            normal.SIFRE = uye.SIFRE;
            normal.FOTOGRAF = uye.FOTOGRAF;
            normal.TELEFON = uye.TELEFON;
            normal.OKUL = uye.OKUL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KitapGecmis(int id)
        {
            var uye = db.TBLHAREKET.Where(x => x.UYE == id).ToList();
            var uyead = db.TBLUYELER.Where(x => x.ID == id).Select(y => y.AD + " " + y.SOYAD).FirstOrDefault();
            ViewBag.uyead = uyead;
            return View(uye);
        }
    }
}
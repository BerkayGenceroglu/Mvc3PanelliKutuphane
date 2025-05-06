using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKutuphane.Controllers
{
    public class AyarlarController : Controller
    {
        // GET: Ayarlar
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities(); 
        public ActionResult Index()
        {
            var adminler = db.TBLADMİN.ToList();
            return View(adminler);
        }
        [HttpPost]
        public ActionResult YeniAdminEkle(TBLADMİN admin)
        {
            db.TBLADMİN.Add(admin); // Yeni admini ekle
            db.SaveChanges(); // Değişiklikleri kaydet
            return RedirectToAction("Index"); // İşlem tamamlandıktan sonra adminler sayfasına yönlendir
        }
        public ActionResult AdminSil(int id)
        {
            var admin = db.TBLADMİN.Find(id);
            db.TBLADMİN.Remove(admin); // Admini sil
            db.SaveChanges(); // Değişiklikleri kaydet
            return RedirectToAction("Index"); // İşlem tamamlandıktan sonra adminler sayfasına yönlendir
        }
        [HttpGet]
        public ActionResult AdminDuzenle(int id)
        {
            var admin = db.TBLADMİN.Find(id);
            return View("adminDuzenle", admin); // Admin düzenleme sayfasını göster
        }
        [HttpPost]
        public ActionResult AdminDuzenle(TBLADMİN admin)
        {
            var adminUpdate = db.TBLADMİN.Find(admin.ID);
            adminUpdate.Kullanici = admin.Kullanici;
            adminUpdate.Sifre = admin.Sifre;
            adminUpdate.Yetki = admin.Yetki;
            db.SaveChanges(); // Değişiklikleri kaydet
            return RedirectToAction("Index"); // İşlem tamamlandıktan sonra adminler sayfasına yönlendir
        }
    }
}
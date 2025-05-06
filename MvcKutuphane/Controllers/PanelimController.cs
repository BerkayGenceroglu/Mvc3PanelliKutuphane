using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace MvcKutuphane.Controllers
{
    public class PanelimController : Controller
    {
        // GET: Panelim
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();

        [HttpGet]
        public ActionResult Index()
        {
            var gelenDeger = (string)Session["Mail"];
            var degerler = db.TBLUYELER.FirstOrDefault(x => x.MAIL == gelenDeger);
            ViewBag.ad = degerler.AD;
            ViewBag.soyad = degerler.SOYAD;
            ViewBag.kullaniciadi = degerler.KULLANICIADI;
            ViewBag.telefon = degerler.TELEFON;
            ViewBag.okul = degerler.OKUL;
            ViewBag.fotograf = degerler.FOTOGRAF;
            ViewBag.mail = degerler.MAIL;
            var uye = degerler.ID;
            ViewBag.OkunanKitap = db.TBLHAREKET.Where(x =>x.UYE == uye).Count();
            ViewBag.gelenKutusu = db.TBLMESAJLAR.Where(x => x.ALICI == gelenDeger ).Count();
            ViewBag.duyuruSayisi = db.TBLDUYURULAR.Count(); 
            return View(degerler);
        }
        [HttpPost]
        public ActionResult Güncelle(TBLUYELER uye)
        {
            var deger = (string)Session["Mail"];
            var guncel = db.TBLUYELER.FirstOrDefault(x => x.MAIL == deger);
            //e - mail adresinin o anki oturum açmış kullanıcıyı(üyeyi) benzersiz bir şekilde tanımlayan bir kimlik bilgisi olmasıdır.
            guncel.AD = uye.AD;
            guncel.SOYAD = uye.SOYAD;
            guncel.KULLANICIADI = uye.KULLANICIADI;
            guncel.TELEFON = uye.TELEFON;
            guncel.OKUL = uye.OKUL;
            guncel.FOTOGRAF = uye.FOTOGRAF;
            guncel.SIFRE = uye.SIFRE;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Kitaplarim()
        {
            var satır = (string)Session["Mail"];
            var uyemiz = db.TBLUYELER.FirstOrDefault(x=> x.MAIL==satır);
            var deger = db.TBLHAREKET.Where(x => x.UYE == uyemiz.ID).ToList();
            return View(deger);
        }
        public ActionResult Duyurular()
        {
            var duyurular =db.TBLDUYURULAR.ToList();
            return View(duyurular);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("GirisYap", "Login");
        }
    }
}
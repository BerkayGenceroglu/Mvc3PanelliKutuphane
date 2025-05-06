using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;


namespace MvcKutuphane.Controllers
{
    public class istatistikController : Controller
    {
        // GET: istatistik

        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var uyesayısı = db.TBLUYELER.Count();
            ViewBag.uye = uyesayısı;

            var kitapSayısı = db.TBLKITAP.Count();
            ViewBag.kitap = kitapSayısı;

            var emanetkitaplar = db.TBLKITAP.Where(x => x.DURUM == false).Count();
            ViewBag.emanet = emanetkitaplar;

            var kasa = db.TBLCEZALAR.Sum(x => x.PARA);
            ViewBag.kasa = kasa +" "+ "TL";    
            return View();
        }
        public ActionResult HavaDurum()
        {
            return View();
        }
        public ActionResult HavaKart()
        {
            return View();
        }
        public ActionResult Fotograflar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ResimYükle(HttpPostedFileBase Dosya)
        {
            if (Dosya.ContentLength>0)
            {
                string DosyaYolu = Path.Combine(Server.MapPath("~/web2/Resimler/"), Path.GetFileName(Dosya.FileName));
                Dosya.SaveAs(DosyaYolu);
            }
            return RedirectToAction("Fotograflar");
        }
        //🔹 HttpPostedFileBase Nedir?
        //HttpPostedFileBase, ASP.NET MVC'de kullanıcının formdan yüklediği dosyayı sunucu tarafında temsil eden bir sınıftır.
        //Kısaca:
        //🧾 Tarayıcıdan gelen dosyanın tüm bilgilerini(isim, içerik, boyut, uzantı vs.) bu sınıfla elde edersin.

        public ActionResult LinqKart()
        {
            var uyesayısı = db.TBLUYELER.Count();
            ViewBag.uye = uyesayısı;

            var kitapSayısı = db.TBLKITAP.Count();
            ViewBag.kitap = kitapSayısı;

            var emanetkitaplar = db.TBLKITAP.Where(x => x.DURUM == false).Count();
            ViewBag.emanet = emanetkitaplar;

            var kasa = db.TBLCEZALAR.Sum(x => x.PARA);
            ViewBag.kasa = kasa + " " + "TL";

            var kategoriSayısı = db.TBLKATEGORI.Count();
            ViewBag.kategorisayısı = kategoriSayısı;

            var mesaj = db.TBLILETISIM.Count();
            ViewBag.toplammesaj = mesaj;

            var enFazlaKitapYazar = db.EnFazlaKitapYazar().FirstOrDefault();
            ViewBag.enFazlaKitapYazar = enFazlaKitapYazar;

            var enfazlaKitapYayınevi=db.TBLKITAP.GroupBy(x => x.YAYINEVI).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault();
            ViewBag.enfazlayayınevi = enfazlaKitapYayınevi;

            var enAktifÜye = db.TBLHAREKET.GroupBy(x => x.TBLUYELER.AD + " " + x.TBLUYELER.SOYAD).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault();
            ViewBag.enAktifÜye = enAktifÜye;

            var enBaşarılıPersonel = db.TBLHAREKET.GroupBy(x => x.TBLPERSONEL.PERSONAL).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault();
            ViewBag.enBaşarılıPersonel = enBaşarılıPersonel;
             
            var enÇokOkunanKitap = db.TBLHAREKET.GroupBy(x => x.TBLKITAP.AD).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault();
            ViewBag.enÇokOkunanKitap = enÇokOkunanKitap;

            var oduncVerilenKitapBugün = db.TBLHAREKET.Where(x => x.ALISTARIH == DateTime.Today).Count();
            ViewBag.oduncVerilenKitapBugün = oduncVerilenKitapBugün;

            return View();
        }
    }    
}
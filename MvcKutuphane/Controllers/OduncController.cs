using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
namespace MvcKutuphane.Controllers
{
    public class OduncController : Controller
    {
        // GET: Odunc

        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        [Authorize(Roles = "A")]
        public ActionResult Index()
        {
            var degerler = db.TBLHAREKET.Where(x => x.ISLEMDURUM == false).ToList();
            return View(degerler);
        }
        //Ödünç İade Ver Sayfası
        [HttpGet]
        public ActionResult OduncVer()
        {
            List<SelectListItem> üyeler = (from x in db.TBLUYELER.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.AD + " " + x.SOYAD,
                                               Value = x.ID.ToString()
                                           }).ToList();

            List<SelectListItem> personeller = (from x in db.TBLPERSONEL.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = x.PERSONAL,
                                                    Value = x.ID.ToString()
                                                }).ToList();
            List<SelectListItem> kitaplar = (from x in db.TBLKITAP.Where(x=>x.DURUM ==true).ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.AD,
                                               Value = x.ID.ToString()
                                           }).ToList();

            ViewBag.uyeler = üyeler;
            ViewBag.personeller = personeller;
            ViewBag.kitaplar = kitaplar;
            return View();
        }
        [HttpPost]
        public ActionResult OduncVer(TBLHAREKET hareket)
        {
            var uye = db.TBLUYELER.Where(x => x.ID == hareket.TBLUYELER.ID).FirstOrDefault();
            var kitap = db.TBLKITAP.Where(x => x.ID == hareket.TBLKITAP.ID).FirstOrDefault();
            var personel = db.TBLPERSONEL.Where(x => x.ID == hareket.TBLPERSONEL.ID).FirstOrDefault();
            hareket.TBLPERSONEL = personel;
            hareket.TBLKITAP = kitap;
            hareket.TBLUYELER = uye;
            db.TBLHAREKET.Add(hareket);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Ödünç İade Al Sayfası
        public ActionResult OduncIade(int id)
        {
            //ASP.NET MVC diyor ki:
            //“Sen benden TBLHAREKET tipinde bir nesne istiyorsun.Ama ben sadece URL'den ID bilgisi alabiliyorum.
            //O zaman bu ID'yi alır, senin istediğin nesneye sadece ID'yi doldururum. Diğer alanlar boş kalır.
            var value = db.TBLHAREKET.Find(id);
            DateTime d1 = DateTime.Parse(value.IADETARIH.ToString());
            DateTime d2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            TimeSpan fark = d2 - d1;
            if (fark.TotalDays < 0)
            {
                ViewBag.dgr = "Gecikme Bulunamamaktadır";
            }
            else
            {
                ViewBag.dgr = fark.TotalDays + " " + "Gün Gecikmiştir !";
            }

            return View("OduncIade", value);
        }
        public ActionResult OduncGuncelle(TBLHAREKET hareket)
        {
            var value = db.TBLHAREKET.Find(hareket.ID);
            value.UYEGETIRTARIH = hareket.UYEGETIRTARIH;
            value.ISLEMDURUM = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

//TimeSpan, iki tarih veya iki saat arasındaki zaman farkını saklamak için kullanılır.
//İçinde şu bilgiler vardır:

//Gün(Days)

//Saat(Hours)

//Dakika(Minutes)

//Saniye(Seconds)

//Milisaniye(Millisecond
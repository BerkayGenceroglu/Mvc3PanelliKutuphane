using Microsoft.SqlServer.Server;
using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MvcKutuphane.Controllers
{
    public class KitapController : Controller
    {
        // GET: Kitap
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index(string p)
        {
            var kitaplar = db.TBLKITAP.ToList();
            if (!string.IsNullOrEmpty(p))
            {
                kitaplar = kitaplar.Where(k => k.AD.Contains(p)).ToList();
            }
            return View(kitaplar);
        }
        [HttpGet]
        public ActionResult KitapEkle()
        {
            List<SelectListItem> kategoriler= (from x in db.TBLKATEGORI.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.AD,
                                                   Value = x.ID.ToString()
                                               }).ToList();
            List<SelectListItem> yazarlar = (from x in db.TBLYAZAR.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.AD + " " + x.SOYAD,
                                                 Value = x.ID.ToString()
                                             }).ToList();
            ViewBag.Category = kategoriler; 
            ViewBag.YAZAR = yazarlar;    
            return View();
        }
        [HttpPost]
        public ActionResult KitapEkle(TBLKITAP p)
        {
            var ktg = db.TBLKATEGORI.Where(k =>k.ID == p.TBLKATEGORI.ID).FirstOrDefault();
            var yzr = db.TBLYAZAR.Where(k=> k.ID == p.TBLYAZAR.ID).FirstOrDefault();
            p.TBLKATEGORI = ktg;
            p.TBLYAZAR = yzr;
            //Formda kullanıcı yalnızca bir ID seçiyor(kategori ve yazar için).
            //Ancak, bu ID'ler veritabanında bulunan tüm verileri (kategori adı, yazar adı, vs.) doğru şekilde temsil etmelidir. Bu yüzden, p.TBLKATEGORI ve p.TBLYAZAR gibi alanlar, ilgili tablolarla ilişkili tüm veriyi taşır, sadece ID değil.
            //p.TBLKATEGORI ve p.TBLYAZAR, formda seçilen kategori ve yazarın sadece ID'sini değil, tüm bilgilerini de doğru şekilde ekler ve veritabanına kaydeder.
            db.TBLKITAP.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KitapSil(int id)
        {
            var kitap = db.TBLKITAP.Find(id);
            db.TBLKITAP.Remove(kitap);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KitapGetir(int id)
        {
            var value = db.TBLKITAP.Find(id);
            List<SelectListItem> kategoriler = (from x in db.TBLKATEGORI.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = x.AD,
                                                    Value = x.ID.ToString()
                                                }).ToList();
            List<SelectListItem> yazarlar = (from x in db.TBLYAZAR.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.AD + " " + x.SOYAD,
                                                 Value = x.ID.ToString()
                                             }).ToList();
            ViewBag.Category = kategoriler;
            ViewBag.YAZAR = yazarlar;
            return View("KitapGetir",value);
        }
        public ActionResult KitapGuncelle(TBLKITAP kitap)
        {
            var newkitap = db.TBLKITAP.Find(kitap.ID);
            newkitap.AD = kitap.AD;
            newkitap.BASIMYIL = kitap.BASIMYIL;
            newkitap.YAYINEVI = kitap.YAYINEVI;
            newkitap.SAYFA = kitap.SAYFA;
            newkitap.DURUM = true;
            var ktg = db.TBLKATEGORI.Where(k => k.ID == kitap.TBLKATEGORI.ID).FirstOrDefault();
            var yzr = db.TBLYAZAR.Where(k => k.ID == kitap.TBLYAZAR.ID).FirstOrDefault();
            newkitap.KATEGORI = ktg.ID;
            newkitap.YAZAR = yzr.ID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
//Güncellemede sadece ID değiştiriyorsun çünkü zaten var olan bir kaydı güncelliyorsun.

//Eklemede ise, yeni bir kitap oluştururken doğrudan kategori ve yazar nesnelerini bağlaman gerekiyor, yoksa EF ilişkiyi anlamaz.

//Bu mantığı anladığında Entity Framework ile ilişkisel veri modellemesi daha mantıklı gelecektir. Biraz daha devam et tamamen oturacaktır
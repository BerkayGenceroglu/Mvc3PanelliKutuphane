using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity; // Assuming you have a namespace for your entity models
namespace MvcKutuphane.Controllers
{
    public class MesajlarController : Controller
    {
        // GET: Mesajlar
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult GelenMesaj()
        {
            var uyeler = Session["Mail"].ToString();  
            var gelenMesajlar = db.TBLMESAJLAR.Where(x =>x.ALICI == uyeler).ToList();
            return View(gelenMesajlar);
        }
        public ActionResult GonderilenMesaj()
        {
            var uyeler = Session["Mail"].ToString();
            var gonderilenMesajlar = db.TBLMESAJLAR.Where(x => x.GONDEREN == uyeler).ToList();
            return View(gonderilenMesajlar);
        }

        [HttpGet]
        public ActionResult YeniMesaj()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMesaj(TBLMESAJLAR mesaj)
        {
            var deger = Session["Mail"].ToString();
            var gonderen = db.TBLUYELER.FirstOrDefault(x => x.MAIL == deger);
            mesaj.GONDEREN = gonderen.MAIL;
            mesaj.TARIH = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBLMESAJLAR.Add(mesaj);
            db.SaveChanges();
            return RedirectToAction("GonderilenMesaj");
        }

        public PartialViewResult MessagePartial()
        {
            var deger = Session["Mail"].ToString();
            var gonderen =db.TBLMESAJLAR.Where(x => x.GONDEREN == deger).Count();
            ViewBag.gonderen = gonderen;
            var alici = db.TBLMESAJLAR.Where(x => x.ALICI == deger).Count();
            ViewBag.alici = alici;
            return PartialView();
        }
    }
}
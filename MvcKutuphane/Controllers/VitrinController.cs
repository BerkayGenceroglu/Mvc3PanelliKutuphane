using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity;
using MvcKutuphane.Models.Sınıflarım;

namespace MvcKutuphane.Controllers
{
    [AllowAnonymous]
    public class VitrinController : Controller
    {
        // GET: Vitrin

        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        [HttpGet]
        public ActionResult Index()
        {
            Sınıflarım sınıflar = new Sınıflarım();
            sınıflar.Kitaplar = db.TBLKITAP.ToList();
            sınıflar.Hakkımda = db.TBLHAKKIMDA.ToList();
            return View(sınıflar);
        }

        [HttpPost]
        public ActionResult Index(TBLILETISIM p)
        {
            db.TBLILETISIM.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
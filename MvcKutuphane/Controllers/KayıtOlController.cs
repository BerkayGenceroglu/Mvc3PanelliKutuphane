using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MvcKutuphane.Controllers
{
    [AllowAnonymous]
    public class KayıtOlController : Controller
    {
        // GET: KayıtOl
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        [HttpGet]
        public ActionResult Kayıt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kayıt(TBLUYELER uye)
        {
            if (!ModelState.IsValid)
            {
                return View("Kayıt");
            }
            db.TBLUYELER.Add(uye);
            ViewBag.BasariliKayit = true;
            db.SaveChanges();
            return RedirectToAction("Kayıt");
        }
    }
}
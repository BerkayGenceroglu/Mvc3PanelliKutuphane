using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models.Entity; // Assuming you have a Models namespace
namespace MvcKutuphane.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            var personelList = db.TBLPERSONEL.ToList(); 
            return View(personelList);
        }
        [HttpGet]
        public ActionResult PersonelEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PersonelEkle(TBLPERSONEL p)
        {
            if (!ModelState.IsValid)
            {
                return View("PersonelEkle");
            }
            db.TBLPERSONEL.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PersonelSil(int id)
        {
            var personel = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(personel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult PersonelGetir(int id)
        {
            var value = db.TBLPERSONEL.Find(id);
            return View("PersonelGetir", value);
        }

        public ActionResult PersonelGuncelle(TBLPERSONEL pers)
        {
            var personel = db.TBLPERSONEL.Find(pers.ID);
            personel.PERSONAL = pers.PERSONAL;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
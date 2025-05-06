using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKutuphane.Models;
using MvcKutuphane.Models.Entity;
namespace MvcKutuphane.Controllers
{
    public class GrafikController : Controller
    {
        // GET: Grafik
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VisualizeKitapResult()
        {
            return Json(liste());
        }
        public List<YayıneviGrafik> liste()
        {
            List<YayıneviGrafik> cs = new List<YayıneviGrafik>();

            var query = from k in db.TBLKITAP
                        group k by k.YAYINEVI into g
                        select new
                        {
                            Sayı = g.Count(),
                            Ad = g.Key
                        };

            foreach (var item in query)
            {
                cs.Add(new YayıneviGrafik()
                {
                    Sayı = item.Sayı,
                    Ad = item.Ad
                });
            }
            return cs;
        }
        public ActionResult Anasayfa()
        {
            return View();
        }
    }
}

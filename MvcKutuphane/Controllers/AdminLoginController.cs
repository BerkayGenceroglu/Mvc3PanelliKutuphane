using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcKutuphane.Controllers
{
    [AllowAnonymous]
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(TBLADMİN admin)
        {
            var deger = db.TBLADMİN.Where(x => x.Kullanici== admin.Kullanici && x.Sifre ==admin.Sifre).FirstOrDefault();
            if (deger != null)
            {
                FormsAuthentication.SetAuthCookie(deger.Kullanici, false);
                // Bu yöntem, kimlik doğrulama bilgilerini çerez olarak kullanıcının tarayıcısına yerleştirir. Bu çerez, daha sonraki isteklerde kullanıcıyı tanımak için kullanılır.
                Session["Kullanici"] = deger.Kullanici.ToString();
                /*oturum verilerini kullanarak, kullanıcı adı gibi bilgileri uygulama boyunca saklar. Bu sayede, kullanıcı bir sayfadan diğerine geçtiğinde, kimlik doğrulama işlemini yeniden yapmaya gerek kalmaz ve kullanıcı adı gibi bilgilere kolayca erişilebilir.*/
                return RedirectToAction("Index", "Kategori");
            }
            else
            {
                ViewBag.HataMesaji = "Şifre veya kullanıcı hatalı, lütfen tekrar deneyiniz.";
                return View();
            }
        }
    }
}

//Cookie, kullanıcıyı kimlik doğrulama işlemi için hatırlamak amacıyla kullanılır.

//Session, uygulama içinde kullanıcıya özel verileri (örneğin, kullanıcı adı) tutmak amacıyla kullanılır.
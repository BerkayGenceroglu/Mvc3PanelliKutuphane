using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcKutuphane
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			GlobalFilters.Filters.Add(new AuthorizeAttribute());//Böylece, uygulamadaki tüm controller ve action'lara erişim için kullanıcı giriş yapmış (yetkili) olmalıdır. Giriş yapılmamışsa, kullanıcı login sayfasına yönlendirilir.
            AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}

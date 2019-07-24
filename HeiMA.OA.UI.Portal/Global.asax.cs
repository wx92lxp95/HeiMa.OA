using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Spring.Web.Mvc;          //1.添加引用

namespace HeiMA.OA.UI.Portal
{
    //public class MvcApplication : System.Web.HttpApplication
    public class MvcApplication : SpringMvcApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

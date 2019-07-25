using Castle.Windsor;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication.App_Start;

namespace WebApplication
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private IWindsorContainer container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            container = new WindsorContainer();
            BootstrapConfig.Register(this.container);
        }

        protected void Application_Stop()
        {
            if (this.container != null)
            {
                this.container.Dispose();
            }
        }
    }
}

using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using ApplicationLayer.Services;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DomainLayer;

namespace WebApplication.App_Start
{
    public class BootstrapConfig
    {
        public static void Register(IWindsorContainer container)
        {
            GlobalConfiguration.Configuration.Services.Replace(
                typeof(IHttpControllerActivator),
                new WindsorCompositionRoot(container));

            container.Register(Classes.FromThisAssembly()
                .BasedOn<IHttpController>()
                .Configure(c => c.LifestyleTransient()));

            container.Register(Component.For<IInquiryService>().ImplementedBy<InquiryService>().LifeStyle.Transient);

            container.Register(Component.For<ICustomerRepository>().ImplementedBy<CustomerRepository>().LifeStyle.Singleton);
        }
    }
}
using Academico.Infra.CrossCutting.IoC;
using Academico.Services.WebApi.App_Start;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using WebActivatorEx;

[assembly: PostApplicationStartMethod(typeof(SimpleInjectorInitializer), "Initialize")]

namespace Academico.Services.WebApi.App_Start
{
    public static class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            InitializeContainer(container);
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {
            SimpleInjectorConfig.RegisterServices(container);
            SimpleInjectorConfig.IniciarServiceLocator(container);
        }
    }
}
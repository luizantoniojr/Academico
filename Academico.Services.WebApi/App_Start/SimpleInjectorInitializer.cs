using Academico.Infra.CrossCutting.IoC;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using System.Web.Mvc;

namespace Academico.Services.WebApi.App_Start
{
    public static class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            InitializeContainer(container);
            #region Configurações Owin
            // Necessário para registrar o ambiente do Owin que é dependência do Identity
            // Feito fora da camada de IoC para não levar o System.Web para fora
            //container.RegisterPerWebRequest(() =>
            //{
            //    if (HttpContext.Current != null && HttpContext.Current.Items["owin.Environment"] == null &&
            //        container.IsVerifying())
            //    {
            //        return new OwinContext().Authentication;
            //    }
            //    return HttpContext.Current.GetOwinContext().Authentication;
            //});
            //container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            #endregion
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorWebApiDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {
            SimpleInjectorConfig.RegisterServices(container);
        }
    }
}
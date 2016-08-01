using Academico.Application.FastMapper;
using System.Web.Http;

namespace Academico.Services.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FastMapperConfig.Initialize();
        }
    }
}
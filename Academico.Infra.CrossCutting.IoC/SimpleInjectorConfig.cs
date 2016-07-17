using Academico.Application.Interfaces;
using Academico.Application.Services;
using Academico.Domain.Interfaces.Repository;
using Academico.Domain.Interfaces.Services;
using Academico.Domain.Services;
using Academico.Infra.Data.Repositories;
using SimpleInjector;

namespace Academico.Infra.CrossCutting.IoC
{
    public class SimpleInjectorConfig
    {
        public static void RegisterServices(Container container)
        {
            #region Registro dos AppServices
            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            container.Register<IAvaliacaoAppService, AvaliacaoAppService>();
            container.Register<ICursoAppService, CursoAppService>();
            container.Register<IDiscenteAppService, DiscenteAppService>();
            container.Register<IDisciplinaMatriculadaAppService, DisciplinaMatriculadaAppService>();
            container.Register<IDisciplinaAppService, DisciplinaAppService>();
            container.Register<IDocenteAppService, DocenteAppService>();
            container.Register<IFaltaAppService, FaltaAppService>();
            container.Register<ITurmaAppService, TurmaAppService>();
            container.Register<IUsuarioAppService, UsuarioAppService>();
            #endregion

            #region Registro dos Services
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<IAvaliacaoService, AvaliacaoService>();
            container.Register<ICursoService, CursoService>();
            container.Register<IDiscenteService, DiscenteService>();
            container.Register<IDisciplinaMatriculadaService, DisciplinaMatriculadaService>();
            container.Register<IDisciplinaService, DisciplinaService>();
            container.Register<IDocenteService, DocenteService>();
            container.Register<IFaltaService, FaltaService>();
            container.Register<ITurmaService, TurmaService>();
            container.Register<IUsuarioService, UsuarioService>();
            #endregion

            #region Registro dos Repositories
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<,>));
            container.Register<IAvaliacaoRepository, AvaliacaoRepository>();
            container.Register<ICursoRepository, CursoRepository>();
            container.Register<IDiscenteRepository, DiscenteRepository>();
            container.Register<IDisciplinaMatriculadaRepository, DisciplinaMatriculadaRepository>();
            container.Register<IDisciplinaRepository, DisciplinaRepository>();
            container.Register<IDocenteRepository, DocenteRepository>();
            container.Register<IFaltaRepository, FaltaRepository>();
            container.Register<ITurmaRepository, TurmaRepository>();
            container.Register<IUsuarioRepository, UsuarioRepository>();
            #endregion
        }
    }
}

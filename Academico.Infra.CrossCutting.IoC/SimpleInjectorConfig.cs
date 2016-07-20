using Academico.Application.Interfaces;
using Academico.Application.Services;
using Academico.Domain.Interfaces.Repository;
using Academico.Domain.Interfaces.Services;
using Academico.Domain.Services;
using Academico.Infra.Data.Context;
using Academico.Infra.Data.Interfaces;
using Academico.Infra.Data.Repositories;
using Academico.Infra.Data.UoW;
using CommonServiceLocator.SimpleInjectorAdapter;
using Microsoft.Practices.ServiceLocation;
using SimpleInjector;

namespace Academico.Infra.CrossCutting.IoC
{
    public class SimpleInjectorConfig
    {
        public static void RegisterServices(Container container)
        {
            #region Registro dos AppServices
            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            container.Register<IAvaliacaoAppService, AvaliacaoAppService>(Lifestyle.Scoped);
            container.Register<ICursoAppService, CursoAppService>(Lifestyle.Scoped);
            container.Register<IDiscenteAppService, DiscenteAppService>(Lifestyle.Scoped);
            container.Register<IDisciplinaMatriculadaAppService, DisciplinaMatriculadaAppService>(Lifestyle.Scoped);
            container.Register<IDisciplinaAppService, DisciplinaAppService>(Lifestyle.Scoped);
            container.Register<IDocenteAppService, DocenteAppService>(Lifestyle.Scoped);
            container.Register<IFaltaAppService, FaltaAppService>(Lifestyle.Scoped);
            container.Register<ITurmaAppService, TurmaAppService>(Lifestyle.Scoped);
            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);
            #endregion

            #region Registro dos Services
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<IAvaliacaoService, AvaliacaoService>(Lifestyle.Scoped);
            container.Register<ICursoService, CursoService>(Lifestyle.Scoped);
            container.Register<IDiscenteService, DiscenteService>(Lifestyle.Scoped);
            container.Register<IDisciplinaMatriculadaService, DisciplinaMatriculadaService>(Lifestyle.Scoped);
            container.Register<IDisciplinaService, DisciplinaService>(Lifestyle.Scoped);
            container.Register<IDocenteService, DocenteService>(Lifestyle.Scoped);
            container.Register<IFaltaService, FaltaService>(Lifestyle.Scoped);
            container.Register<ITurmaService, TurmaService>(Lifestyle.Scoped);
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);
            #endregion

            #region Registro dos Repositories
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.Register<IAvaliacaoRepository, AvaliacaoRepository>(Lifestyle.Scoped);
            container.Register<ICursoRepository, CursoRepository>(Lifestyle.Scoped);
            container.Register<IDiscenteRepository, DiscenteRepository>(Lifestyle.Scoped);
            container.Register<IDisciplinaMatriculadaRepository, DisciplinaMatriculadaRepository>(Lifestyle.Scoped);
            container.Register<IDisciplinaRepository, DisciplinaRepository>(Lifestyle.Scoped);
            container.Register<IDocenteRepository, DocenteRepository>(Lifestyle.Scoped);
            container.Register<IFaltaRepository, FaltaRepository>(Lifestyle.Scoped);
            container.Register<ITurmaRepository, TurmaRepository>(Lifestyle.Scoped);
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
            #endregion

            #region Data Config
            container.Register(typeof(IContextManager<>), typeof(ContextManager<>));
            container.Register<IDbContext, AcademicoContext>(Lifestyle.Scoped);
            container.Register(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            #endregion
        }

        public static void IniciarServiceLocator(Container container) {
            var adapter = new SimpleInjectorServiceLocatorAdapter(container);
            ServiceLocator.SetLocatorProvider(() => adapter);
        }
    }
}

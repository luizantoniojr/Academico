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
            #region Registro dos Services
            container.Register<IAvaliacaoService, AvaliacaoService>();
            container.Register<ICursoService, CursoService>();
            container.Register<IDiscenteService, DiscenteService>();
            container.Register<IDisciplinaMatriculadaService, DisciplinaMatriculadaService>();
            container.Register<IDisciplinaService, DisciplinaService>();
            container.Register<IDocenteService, DocenteService>();
            container.Register<IFaltaService, FaltaService>();
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<ITurmaService, TurmaService>();
            container.Register<IUsuarioService, UsuarioService>();
            #endregion

            #region Registro dos Repositories
            container.Register<IAvaliacaoRepository, AvaliacaoRepository>();
            container.Register<ICursoRepository, CursoRepository>();
            container.Register<IDiscenteRepository, DiscenteRepository>();
            container.Register<IDisciplinaMatriculadaRepository, DisciplinaMatriculadaRepository>();
            container.Register<IDisciplinaRepository, DisciplinaRepository>();
            container.Register<IDocenteRepository, DocenteRepository>();
            container.Register<IFaltaRepository, FaltaRepository>();
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<,>));
            container.Register<ITurmaRepository, TurmaRepository>();
            container.Register<IUsuarioRepository, UsuarioRepository>();
            #endregion
        }
    }
}

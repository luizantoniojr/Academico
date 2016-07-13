using Academico.Infra.Data.Interfaces;

namespace Academico.Application.Interfaces
{
    public interface IAppServiceBase<TContext> where TContext : IDbContext
    {
        void BeginTransaction();
        void Commit();
    }
}

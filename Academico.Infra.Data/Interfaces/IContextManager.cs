namespace Academico.Infra.Data.Interfaces
{
    interface IContextManager<TContext> where TContext : IDbContext, new()
    {
        IDbContext GetContext();
    }
}
using Academico.Domain.Entities;
using Academico.Domain.Interfaces.Repository;
using Academico.Infra.Data.Context;

namespace Academico.Infra.Data.Repositories
{
    public class DisciplinaRepository : RepositoryBase<Disciplina, AcademicoContext>, IDisciplinaRepository
    {
    }
}

using Academico.Domain.Entities;
using Academico.Domain.Interfaces.Repository;
using Academico.Domain.Interfaces.Services;

namespace Academico.Domain.Services
{
    public class TurmaService : ServiceBase<Turma>, ITurmaService
    {
        private readonly ITurmaRepository _turmaRepository;

        public TurmaService(ITurmaRepository turmaRepository)
            : base(turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }
    }
}

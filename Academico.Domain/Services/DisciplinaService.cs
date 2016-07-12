using Academico.Domain.Entities;
using Academico.Domain.Interfaces.Repository;
using Academico.Domain.Interfaces.Services;

namespace Academico.Domain.Services
{
    public class DisciplinaService : ServiceBase<Disciplina>, IDisciplinaService
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository)
            : base(disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }
    }
}

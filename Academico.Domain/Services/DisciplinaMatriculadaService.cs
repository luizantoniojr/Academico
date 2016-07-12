using Academico.Domain.Entities;
using Academico.Domain.Interfaces.Repository;
using Academico.Domain.Interfaces.Services;

namespace Academico.Domain.Services
{
    public class DisciplinaMatriculadaService : ServiceBase<DisciplinaMatriculada>, IDisciplinaMatriculadaService
    {
        private readonly IDisciplinaMatriculadaRepository _disciplinaMatriculadaRepository;

        public DisciplinaMatriculadaService(IDisciplinaMatriculadaRepository disciplinaMatriculadaRepository)
            : base(disciplinaMatriculadaRepository)
        {
            _disciplinaMatriculadaRepository = disciplinaMatriculadaRepository;
        }
    }
}

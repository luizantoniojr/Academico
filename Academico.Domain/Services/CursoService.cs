using Academico.Domain.Entities;
using Academico.Domain.Interfaces.Repository;
using Academico.Domain.Interfaces.Services;

namespace Academico.Domain.Services
{
    public class CursoService : ServiceBase<Curso>, ICursoService
    {
        private readonly ICursoRepository _cursoRepository;

        public CursoService(ICursoRepository cursoRepository)
            : base(cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
    }
}
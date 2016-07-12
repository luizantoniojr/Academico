using Academico.Domain.Entities;
using Academico.Domain.Interfaces.Repository;
using Academico.Domain.Interfaces.Services;

namespace Academico.Domain.Services
{
    public class DocenteService : ServiceBase<Docente>, IDocenteService
    {
        private readonly IDocenteRepository _docenteRepository;

        public DocenteService(IDocenteRepository docenteRepository)
            : base(docenteRepository)
        {
            _docenteRepository = docenteRepository;
        }
    }
}

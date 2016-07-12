using Academico.Domain.Entities;
using Academico.Domain.Interfaces.Repository;
using Academico.Domain.Interfaces.Services;

namespace Academico.Domain.Services
{
    public class DiscenteService : ServiceBase<Discente>, IDiscenteService
    {
        private readonly IDiscenteRepository _discenteRepository;

        public DiscenteService(IDiscenteRepository discenteRepository)
            : base(discenteRepository)
        {
            _discenteRepository = discenteRepository;
        }
    }
}
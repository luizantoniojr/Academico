using Academico.Domain.Entities;
using Academico.Domain.Interfaces.Repository;
using Academico.Domain.Interfaces.Services;

namespace Academico.Domain.Services
{
    public class FaltaService : ServiceBase<Falta>, IFaltaService
    {
        private readonly IFaltaRepository _faltaRepository;

        public FaltaService(IFaltaRepository faltaRepository)
            : base(faltaRepository)
        {
            _faltaRepository = faltaRepository;
        }
    }
}

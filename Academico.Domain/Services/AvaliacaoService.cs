using Academico.Domain.Entities;
using Academico.Domain.Interfaces.Repository;
using Academico.Domain.Interfaces.Services;

namespace Academico.Domain.Services
{
    public class AvaliacaoService : ServiceBase<Avaliacao>, IAvaliacaoService
    {
        private readonly IAvaliacaoRepository _avaliacaoRepository;

        public AvaliacaoService(IAvaliacaoRepository avaliacaoRepository)
            : base(avaliacaoRepository)
        {
            _avaliacaoRepository = avaliacaoRepository;
        }
    }
}
using Academico.Application.Interfaces;
using Academico.Domain.Interfaces.Services;
using Academico.Infra.Data.Context;

namespace Academico.Application.Services
{
    public class AvaliacaoAppService : AppServiceBase<AcademicoContext>, IAvaliacaoAppService
    {
        private readonly IAvaliacaoService _avaliacaoService;

        public AvaliacaoAppService(IAvaliacaoService avaliacaoService)
        {
            _avaliacaoService = avaliacaoService;
        }

        public void Dispose()
        {
            _avaliacaoService.Dispose();
        }
    }
}

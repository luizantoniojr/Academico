using Academico.Application.Interfaces;
using Academico.Domain.Interfaces.Services;
using Academico.Infra.Data.Context;

namespace Academico.Application.Services
{
    public class DiscenteAppService : AppServiceBase<AcademicoContext>, IDiscenteAppService
    {
        private readonly IDiscenteService _discenteService;

        public DiscenteAppService(IDiscenteService discenteService)
        {
            _discenteService = discenteService;
        }

        public void Dispose()
        {
            _discenteService.Dispose();
        }
    }
}

using Academico.Application.Interfaces;
using Academico.Domain.Interfaces.Services;
using Academico.Infra.Data.Context;

namespace Academico.Application.Services
{
    public class FaltaAppService : AppServiceBase<AcademicoContext>, IFaltaAppService
    {
        private readonly IFaltaService _faltaService;

        public FaltaAppService(IFaltaService faltaService)
        {
            _faltaService = faltaService;
        }

        public void Dispose()
        {
            _faltaService.Dispose();
        }
    }
}

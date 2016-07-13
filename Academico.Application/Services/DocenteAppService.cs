using Academico.Application.Interfaces;
using Academico.Domain.Interfaces.Services;
using Academico.Infra.Data.Context;

namespace Academico.Application.Services
{
    public class DocenteAppService : AppServiceBase<AcademicoContext>, IDocenteAppService
    {
        private readonly IDocenteService _docenteService;

        public DocenteAppService(IDocenteService docenteService)
        {
            _docenteService = docenteService;
        }

        public void Dispose()
        {
            _docenteService.Dispose();
        }
    }
}

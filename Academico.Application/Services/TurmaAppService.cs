using Academico.Application.Interfaces;
using Academico.Domain.Interfaces.Services;
using Academico.Infra.Data.Context;

namespace Academico.Application.Services
{
    public class TurmaAppService : AppServiceBase<AcademicoContext>, ITurmaAppService
    {
        private readonly ITurmaService _turmaService;

        public TurmaAppService(ITurmaService turmaService)
        {
            _turmaService = turmaService;
        }

        public void Dispose()
        {
            _turmaService.Dispose();
        }
    }
}

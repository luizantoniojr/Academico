using Academico.Application.Interfaces;
using Academico.Domain.Interfaces.Services;
using Academico.Infra.Data.Context;

namespace Academico.Application.Services
{
    public class DisciplinaAppService : AppServiceBase<AcademicoContext>, IDisciplinaAppService
    {
        private readonly IDisciplinaService _disciplinaService;

        public DisciplinaAppService(IDisciplinaService disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }

        public void Dispose()
        {
            _disciplinaService.Dispose();
        }
    }
}

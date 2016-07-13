using Academico.Application.Interfaces;
using Academico.Domain.Interfaces.Services;
using Academico.Infra.Data.Context;

namespace Academico.Application.Services
{
    public class DisciplinaMatriculadaAppService : AppServiceBase<AcademicoContext>, IDisciplinaMatriculadaAppService
    {
        private readonly IDisciplinaMatriculadaService _disciplinaMatriculadaService;

        public DisciplinaMatriculadaAppService(IDisciplinaMatriculadaService disciplinaMatriculadaService)
        {
            _disciplinaMatriculadaService = disciplinaMatriculadaService;
        }

        public void Dispose()
        {
            _disciplinaMatriculadaService.Dispose();
        }
    }
}

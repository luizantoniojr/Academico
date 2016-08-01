using Academico.Application.Interfaces;
using Academico.Application.ViewModels;
using Academico.Domain.Entities;
using Academico.Domain.Interfaces.Services;
using Academico.Infra.Data.Context;
using FastMapper;
using System;

namespace Academico.Application.Services
{
    public class CursoAppService : AppServiceBase<AcademicoContext>, ICursoAppService
    {
        private readonly ICursoService _cursoService;

        public CursoAppService(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        public void Inserir(CursoViewModel cursoViewModel)
        {
            var curso = TypeAdapter.Adapt<CursoViewModel, Curso>(cursoViewModel);
            BeginTransaction();
            _cursoService.Add(curso);
            Commit();
        }

        public CursoViewModel Buscar(Guid cursoId)
        {
            var curso = TypeAdapter.Adapt<Curso, CursoViewModel>(_cursoService.GetById(cursoId));
            return curso;
        }

        public void Dispose()
        {
            _cursoService.Dispose();
        }
    }
}

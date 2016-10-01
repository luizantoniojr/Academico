using Academico.Application.Interfaces;
using Academico.Application.ViewModels;
using Academico.Domain.Entities;
using Academico.Domain.Interfaces.Services;
using Academico.Infra.Data.Context;
using FastMapper;
using System;
using System.Collections.Generic;

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
            return TypeAdapter.Adapt<Curso, CursoViewModel>(_cursoService.GetById(cursoId));
        }

        public IEnumerable<CursoViewModel> Buscar()
        {
            return TypeAdapter.Adapt<IEnumerable<Curso>, IEnumerable<CursoViewModel>>(_cursoService.GetAll());
        }

        public void Editar(CursoViewModel curso)
        {
            BeginTransaction();
            _cursoService.Update(TypeAdapter.Adapt<CursoViewModel, Curso>(curso));
            Commit();
        }

        public void Deletar(CursoViewModel curso)
        {
            BeginTransaction();
            _cursoService.Remove(TypeAdapter.Adapt<CursoViewModel, Curso>(curso));
            Commit();
        }

        public void Dispose()
        {
            _cursoService.Dispose();
        }
    }
}

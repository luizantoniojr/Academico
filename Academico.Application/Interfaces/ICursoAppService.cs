using Academico.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Academico.Application.Interfaces
{
    public interface ICursoAppService : IDisposable
    {
        void Inserir(CursoViewModel cursoViewModel);
        CursoViewModel Buscar(Guid cursoId);
        IEnumerable<CursoViewModel> Buscar();
        void Editar(CursoViewModel curso);
        void Deletar(CursoViewModel curso);
    }
}
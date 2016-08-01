using Academico.Application.ViewModels;
using System;

namespace Academico.Application.Interfaces
{
    public interface ICursoAppService : IDisposable
    {
        void Inserir(CursoViewModel cursoViewModel);
        CursoViewModel Buscar(Guid cursoId);
    }
}
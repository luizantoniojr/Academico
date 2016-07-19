using System;
using System.Collections.Generic;

namespace Academico.Application.ViewModels
{
    public class DisciplinaViewModel
    {
        public DisciplinaViewModel()
        {
            Id = Guid.NewGuid();
            Cursos = Cursos ?? new List<CursoViewModel>();
            DocentesLecionando = DocentesLecionando ?? new List<DocenteViewModel>();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<CursoViewModel> Cursos { get; set; }
        public virtual ICollection<DocenteViewModel> DocentesLecionando { get; set; }
    }
}

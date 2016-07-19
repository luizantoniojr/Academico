using System;
using System.Collections.Generic;

namespace Academico.Application.ViewModels
{
    public class CursoViewModel
    {
        public CursoViewModel()
        {
            Id = Guid.NewGuid();
            GradeDisciplinas = GradeDisciplinas ?? new List<DisciplinaViewModel>();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<DisciplinaViewModel> GradeDisciplinas { get; set; }
        public virtual ICollection<TurmaViewModel> Turmas { get; set; }
    }
}

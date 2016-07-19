using System;
using System.Collections.Generic;

namespace Academico.Application.ViewModels
{
    public class DisciplinaMatriculadaViewModel
    {
        public DisciplinaMatriculadaViewModel()
        {
            Id = Guid.NewGuid();
            Avaliacoes = Avaliacoes ?? new List<AvaliacaoViewModel>();
            Faltas = Faltas ?? new List<FaltaViewModel>();
        }
        public Guid Id { get; set; }
        public Guid DiscenteId { get; set; }
        public Guid DisciplinaId { get; set; }
        public virtual DiscenteViewModel Discente { get; set; }
        public virtual DisciplinaViewModel Disciplina { get; set; }
        public virtual ICollection<AvaliacaoViewModel> Avaliacoes { get; set; }
        public virtual ICollection<FaltaViewModel> Faltas { get; set; }
    }
}

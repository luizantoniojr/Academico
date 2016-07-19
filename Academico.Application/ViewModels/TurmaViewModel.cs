using System;
using System.Collections.Generic;

namespace Academico.Application.ViewModels
{
    public class TurmaViewModel
    {
        public TurmaViewModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid CursoId { get; set; }
        public string Nome { get; set; }
        public virtual CursoViewModel Curso { get; set; }
        public virtual ICollection<DiscenteViewModel> Discentes { get; set; }
        public virtual ICollection<DocenteViewModel> Docentes { get; set; }
    }
}
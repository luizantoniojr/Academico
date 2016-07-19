using System;
using System.Collections.Generic;

namespace Academico.Application.ViewModels
{
    public class DiscenteViewModel : UsuarioViewModel
    {
        public DiscenteViewModel()
        {
            DisciplinasMatriculadas = DisciplinasMatriculadas ?? new List<DisciplinaMatriculadaViewModel>();
        }
        public Guid TurmaId{ get; set; }
        public string Matricula { get; set; }
        public DateTime DataMatricula { get; set; }
        public virtual TurmaViewModel Turma { get; set; }
        public virtual ICollection<DisciplinaMatriculadaViewModel> DisciplinasMatriculadas { get; set; }
    }
}

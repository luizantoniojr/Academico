using Academico.Domain.Entities;
using System.Collections.Generic;

namespace Academico.Application.ViewModels
{
    public class DocenteViewModel : UsuarioViewModel
    {
        public DocenteViewModel()
        {
            DisciplinasLecionadas = DisciplinasLecionadas ?? new List<DisciplinaViewModel>();
            TurmasLeciona = TurmasLeciona ?? new List<TurmaViewModel>();
        }
        public Formacao Formacao { get; set; }
        public virtual ICollection<DisciplinaViewModel> DisciplinasLecionadas { get; set; }
        public virtual ICollection<TurmaViewModel> TurmasLeciona { get; set; }
    }
}

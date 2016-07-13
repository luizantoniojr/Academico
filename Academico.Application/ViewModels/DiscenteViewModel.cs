using System;
using System.Collections.Generic;

namespace Academico.Domain.Entities
{
    public class DiscenteViewModel : UsuarioViewModel
    {
        public DiscenteViewModel()
        {
            DisciplinasMatriculadas = DisciplinasMatriculadas ?? new List<DisciplinaMatriculada>();
        }
        public Guid TurmaId{ get; set; }
        public string Matricula { get; set; }
        public DateTime DataMatricula { get; set; }
        public virtual Turma Turma { get; set; }
        public virtual ICollection<DisciplinaMatriculada> DisciplinasMatriculadas { get; set; }
    }
}

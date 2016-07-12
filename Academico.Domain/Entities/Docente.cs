using System.Collections.Generic;

namespace Academico.Domain.Entities
{
    public class Docente : Usuario
    {
        public Docente()
        {
            DisciplinasLecionadas = DisciplinasLecionadas ?? new List<Disciplina>();
            TurmasLeciona = TurmasLeciona ?? new List<Turma>();
        }
        public Formacao Formacao { get; set; }
        public virtual ICollection<Disciplina> DisciplinasLecionadas { get; set; }
        public virtual ICollection<Turma> TurmasLeciona { get; set; }
    }
}

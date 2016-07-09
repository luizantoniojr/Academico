using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico.Domain.Entities
{
    public class Discente : Usuario
    {
        public Discente()
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

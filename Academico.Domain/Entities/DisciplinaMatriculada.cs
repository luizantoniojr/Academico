using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico.Domain.Entities
{
    public class DisciplinaMatriculada
    {
        public DisciplinaMatriculada()
        {
            Avaliacoes = Avaliacoes ?? new List<Avaliacao>();
            Faltas = Faltas ?? new List<Falta>();
        }
        public Guid DiscenteId { get; set; }
        public Guid DisciplinaId { get; set; }
        public virtual Discente Discente { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }
        public virtual ICollection<Falta> Faltas { get; set; }
    }
}

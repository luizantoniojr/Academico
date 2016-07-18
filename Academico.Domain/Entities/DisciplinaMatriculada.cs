using System;
using System.Collections.Generic;

namespace Academico.Domain.Entities
{
    public class DisciplinaMatriculada
    {
        public DisciplinaMatriculada()
        {
            Id = Guid.NewGuid();
            Avaliacoes = Avaliacoes ?? new List<Avaliacao>();
            Faltas = Faltas ?? new List<Falta>();
        }
        public Guid Id { get; set; }
        public Guid DiscenteId { get; set; }
        public Guid DisciplinaId { get; set; }
        public virtual Discente Discente { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual IEnumerable<Avaliacao> Avaliacoes { get; set; }
        public virtual IEnumerable<Falta> Faltas { get; set; }
    }
}

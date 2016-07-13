using System;
using System.Collections.Generic;

namespace Academico.Domain.Entities
{
    public class DisciplinaMatriculadaViewModel
    {
        public DisciplinaMatriculadaViewModel()
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
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }
        public virtual ICollection<Falta> Faltas { get; set; }
    }
}

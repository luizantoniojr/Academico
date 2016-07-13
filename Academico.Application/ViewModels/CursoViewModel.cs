using System;
using System.Collections.Generic;

namespace Academico.Domain.Entities
{
    public class CursoViewModel
    {
        public CursoViewModel()
        {
            Id = Guid.NewGuid();
            GradeDisciplinas = GradeDisciplinas ?? new List<Disciplina>();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Disciplina> GradeDisciplinas { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}

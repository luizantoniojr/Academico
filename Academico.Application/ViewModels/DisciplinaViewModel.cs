using System;
using System.Collections.Generic;

namespace Academico.Domain.Entities
{
    public class DisciplinaViewModel
    {
        public DisciplinaViewModel()
        {
            Id = Guid.NewGuid();
            Cursos = Cursos ?? new List<Curso>();
            DocentesLecionando = DocentesLecionando ?? new List<Docente>();
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<Docente> DocentesLecionando { get; set; }
    }
}

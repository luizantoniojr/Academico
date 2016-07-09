using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico.Domain.Entities
{
    public class Turma
    {
        public Turma()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid CursoId { get; set; }
        public string Nome { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
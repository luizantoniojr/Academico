using System;

namespace Academico.Domain.Entities
{
    public class Falta
    {
        public Falta()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid DisciplinaFaltadaId { get; set; }
        public DateTime Data { get; set; }
        public virtual DisciplinaMatriculada DisciplinaFaltada { get; set; }
    }
}

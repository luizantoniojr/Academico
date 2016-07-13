using System;

namespace Academico.Domain.Entities
{
    public class AvaliacaoViewModel
    {
        public AvaliacaoViewModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid DisciplinaAvaliadaId { get; set; }
        public string Nome { get; set; }
        public double Nota { get; set; }
        public int Peso { get; set; }
        public virtual DisciplinaMatriculada DisciplinaAvaliada{ get; set; }
    }
}

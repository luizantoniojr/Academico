using System;

namespace Academico.Application.ViewModels
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
        public virtual DisciplinaMatriculadaViewModel DisciplinaAvaliada{ get; set; }
    }
}

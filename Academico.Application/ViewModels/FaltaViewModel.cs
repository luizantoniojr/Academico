using System;

namespace Academico.Application.ViewModels
{
    public class FaltaViewModel
    {
        public FaltaViewModel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid DisciplinaFaltadaId { get; set; }
        public DateTime Data { get; set; }
        public virtual DisciplinaMatriculadaViewModel DisciplinaFaltada { get; set; }
    }
}

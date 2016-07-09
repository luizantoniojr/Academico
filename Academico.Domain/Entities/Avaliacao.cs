﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico.Domain.Entities
{
    public class Avaliacao
    {
        public Avaliacao()
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

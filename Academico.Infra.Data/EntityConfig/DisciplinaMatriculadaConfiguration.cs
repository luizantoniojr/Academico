using Academico.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Academico.Infra.Data.EntityConfig
{
    public class DisciplinaMatriculadaConfiguration : EntityTypeConfiguration<DisciplinaMatriculada>
    {
        public DisciplinaMatriculadaConfiguration()
        {
            HasKey(d => d.Id);

            HasRequired(d => d.Discente)
               .WithMany()
               .HasForeignKey(d => d.DiscenteId);

            HasRequired(d => d.Disciplina)
            .WithMany()
            .HasForeignKey(d => d.DisciplinaId);
        }
    }
}
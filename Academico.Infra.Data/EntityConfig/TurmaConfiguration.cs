using Academico.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Academico.Infra.Data.EntityConfig
{
    public class TurmaConfiguration : EntityTypeConfiguration<Turma>
    {
        public TurmaConfiguration()
        {
            HasKey(t => t.Id);

            Property(t => t.Nome)
              .IsRequired()
              .HasMaxLength(50);

            HasRequired(t => t.Curso)
            .WithMany()
            .HasForeignKey(t => t.CursoId);
        }
    }
}

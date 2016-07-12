using Academico.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Academico.Infra.Data.EntityConfig
{
    public class DiscenteConfiguration : EntityTypeConfiguration<Discente>
    {
        public DiscenteConfiguration()
        {
            Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(d => d.DataMatricula)
                .IsRequired();

            HasRequired(d => d.Turma)
                .WithMany()
                .HasForeignKey(d => d.TurmaId);
        }
    }
}

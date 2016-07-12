using Academico.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Academico.Infra.Data.EntityConfig
{
    public class FaltaConfiguration : EntityTypeConfiguration<Falta>
    {
        public FaltaConfiguration()
        {
            HasKey(f => f.Id);

            Property(f => f.Data)
                .IsRequired();

            HasRequired(f => f.DisciplinaFaltada)
               .WithMany()
               .HasForeignKey(f => f.DisciplinaFaltadaId);
        }
    }
}

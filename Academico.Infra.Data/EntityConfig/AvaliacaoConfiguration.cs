using Academico.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Academico.Infra.Data.EntityConfig
{
    public class AvaliacaoConfiguration : EntityTypeConfiguration<Avaliacao>
    {
        public AvaliacaoConfiguration()
        {
            HasKey(a => a.Id);

            Property(a => a.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(a => a.Peso)
               .IsRequired();

            HasRequired(a => a.DisciplinaAvaliada)
                .WithMany()
                .HasForeignKey(a => a.DisciplinaAvaliadaId);
        }
    }
}

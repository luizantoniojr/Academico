using Academico.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Academico.Infra.Data.EntityConfig
{
    public class DisciplinaConfiguration : EntityTypeConfiguration<Disciplina>
    {
        public DisciplinaConfiguration()
        {
            HasKey(d => d.Id);

            Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(100);

            HasMany(d => d.DocentesLecionando)
            .WithMany(doc => doc.DisciplinasLecionadas)
            .Map(me =>
            {
                me.MapLeftKey("DocenteId");
                me.MapRightKey("DisciplinaId");
                me.ToTable("DocenteDisciplina");
            });
        }
    }
}

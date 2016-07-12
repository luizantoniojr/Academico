using Academico.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Academico.Infra.Data.EntityConfig
{
    public class DocenteConfiguration : EntityTypeConfiguration<Docente>
    {
        public DocenteConfiguration()
        {
            Property(d => d.Formacao)
              .IsRequired();

            HasMany(d => d.TurmasLeciona)
            .WithMany(t => t.Docentes)
            .Map(me =>
            {
                me.MapLeftKey("TurmaId");
                me.MapRightKey("DocenteId");
                me.ToTable("TurmaDocente");
            });
        }
    }
}

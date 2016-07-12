using Academico.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Academico.Infra.Data.EntityConfig
{
    public class CursoConfiguration : EntityTypeConfiguration<Curso>
    {
        public CursoConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            HasMany(c => c.GradeDisciplinas)
             .WithMany(d => d.Cursos)
             .Map(me =>
             {
                 me.MapLeftKey("CursoId");
                 me.MapRightKey("DisciplinaId");
                 me.ToTable("CursoDisciplina");
             });
        }
    }
}

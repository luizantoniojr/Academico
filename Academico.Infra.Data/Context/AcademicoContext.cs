using Academico.Domain.Entities;
using Academico.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Academico.Infra.Data.Context
{
    public class AcademicoContext : BaseDbContext
    {
        public AcademicoContext() : base("Academico"){ }

        public IDbSet<Avaliacao> Avaliacoes { get; set; }
        public IDbSet<Curso> Cursos { get; set; }
        public IDbSet<Discente> Discentes { get; set; }
        public IDbSet<Disciplina> Disciplinas { get; set; }
        public IDbSet<DisciplinaMatriculada> DisciplinasMatriculadas { get; set; }
        public IDbSet<Docente> Docentes { get; set; }
        public IDbSet<Falta> Faltas { get; set; }
        public IDbSet<Turma> Turma { get; set; }
        public IDbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Conventions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // General Custom Context Properties
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            // ModelConfiguration
            modelBuilder.Configurations.Add(new AvaliacaoConfiguration());
            modelBuilder.Configurations.Add(new CursoConfiguration());
            modelBuilder.Configurations.Add(new DiscenteConfiguration());
            modelBuilder.Configurations.Add(new DisciplinaConfiguration());
            modelBuilder.Configurations.Add(new DisciplinaMatriculadaConfiguration());
            modelBuilder.Configurations.Add(new DocenteConfiguration());
            modelBuilder.Configurations.Add(new FaltaConfiguration());
            modelBuilder.Configurations.Add(new TurmaConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}

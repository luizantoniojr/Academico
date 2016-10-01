namespace Academico.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avaliacao",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DisciplinaAvaliadaId = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Nota = c.Double(nullable: false),
                        Peso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DisciplinaMatriculada", t => t.DisciplinaAvaliadaId)
                .Index(t => t.DisciplinaAvaliadaId);
            
            CreateTable(
                "dbo.DisciplinaMatriculada",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DiscenteId = c.Guid(nullable: false),
                        DisciplinaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.DiscenteId)
                .ForeignKey("dbo.Disciplina", t => t.DisciplinaId)
                .Index(t => t.DiscenteId)
                .Index(t => t.DisciplinaId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Login = c.String(maxLength: 100, unicode: false),
                        Senha = c.String(maxLength: 100, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        DataAtualizacao = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        Administrador = c.Boolean(nullable: false),
                        TurmaId = c.Guid(),
                        Matricula = c.String(maxLength: 100, unicode: false),
                        DataMatricula = c.DateTime(),
                        Formacao = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Turma", t => t.TurmaId)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.Turma",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CursoId = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Curso", t => t.CursoId)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Disciplina",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Falta",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DisciplinaFaltadaId = c.Guid(nullable: false),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DisciplinaMatriculada", t => t.DisciplinaFaltadaId)
                .Index(t => t.DisciplinaFaltadaId);
            
            CreateTable(
                "dbo.TurmaDocente",
                c => new
                    {
                        TurmaId = c.Guid(nullable: false),
                        DocenteId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.TurmaId, t.DocenteId })
                .ForeignKey("dbo.Usuario", t => t.TurmaId)
                .ForeignKey("dbo.Turma", t => t.DocenteId)
                .Index(t => t.TurmaId)
                .Index(t => t.DocenteId);
            
            CreateTable(
                "dbo.DocenteDisciplina",
                c => new
                    {
                        DocenteId = c.Guid(nullable: false),
                        DisciplinaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.DocenteId, t.DisciplinaId })
                .ForeignKey("dbo.Disciplina", t => t.DocenteId)
                .ForeignKey("dbo.Usuario", t => t.DisciplinaId)
                .Index(t => t.DocenteId)
                .Index(t => t.DisciplinaId);
            
            CreateTable(
                "dbo.CursoDisciplina",
                c => new
                    {
                        CursoId = c.Guid(nullable: false),
                        DisciplinaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.CursoId, t.DisciplinaId })
                .ForeignKey("dbo.Curso", t => t.CursoId)
                .ForeignKey("dbo.Disciplina", t => t.DisciplinaId)
                .Index(t => t.CursoId)
                .Index(t => t.DisciplinaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Falta", "DisciplinaFaltadaId", "dbo.DisciplinaMatriculada");
            DropForeignKey("dbo.Avaliacao", "DisciplinaAvaliadaId", "dbo.DisciplinaMatriculada");
            DropForeignKey("dbo.DisciplinaMatriculada", "DisciplinaId", "dbo.Disciplina");
            DropForeignKey("dbo.DisciplinaMatriculada", "DiscenteId", "dbo.Usuario");
            DropForeignKey("dbo.Usuario", "TurmaId", "dbo.Turma");
            DropForeignKey("dbo.Turma", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.CursoDisciplina", "DisciplinaId", "dbo.Disciplina");
            DropForeignKey("dbo.CursoDisciplina", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.DocenteDisciplina", "DisciplinaId", "dbo.Usuario");
            DropForeignKey("dbo.DocenteDisciplina", "DocenteId", "dbo.Disciplina");
            DropForeignKey("dbo.TurmaDocente", "DocenteId", "dbo.Turma");
            DropForeignKey("dbo.TurmaDocente", "TurmaId", "dbo.Usuario");
            DropIndex("dbo.CursoDisciplina", new[] { "DisciplinaId" });
            DropIndex("dbo.CursoDisciplina", new[] { "CursoId" });
            DropIndex("dbo.DocenteDisciplina", new[] { "DisciplinaId" });
            DropIndex("dbo.DocenteDisciplina", new[] { "DocenteId" });
            DropIndex("dbo.TurmaDocente", new[] { "DocenteId" });
            DropIndex("dbo.TurmaDocente", new[] { "TurmaId" });
            DropIndex("dbo.Falta", new[] { "DisciplinaFaltadaId" });
            DropIndex("dbo.Turma", new[] { "CursoId" });
            DropIndex("dbo.Usuario", new[] { "TurmaId" });
            DropIndex("dbo.DisciplinaMatriculada", new[] { "DisciplinaId" });
            DropIndex("dbo.DisciplinaMatriculada", new[] { "DiscenteId" });
            DropIndex("dbo.Avaliacao", new[] { "DisciplinaAvaliadaId" });
            DropTable("dbo.CursoDisciplina");
            DropTable("dbo.DocenteDisciplina");
            DropTable("dbo.TurmaDocente");
            DropTable("dbo.Falta");
            DropTable("dbo.Disciplina");
            DropTable("dbo.Curso");
            DropTable("dbo.Turma");
            DropTable("dbo.Usuario");
            DropTable("dbo.DisciplinaMatriculada");
            DropTable("dbo.Avaliacao");
        }
    }
}

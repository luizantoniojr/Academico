namespace Academico.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AcademicoInfraDataContextAcademicoContext : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Avaliacao", "DisciplinaMatriculada_Id", "dbo.DisciplinaMatriculada");
            DropForeignKey("dbo.DisciplinaMatriculada", "Discente_Id", "dbo.Usuario");
            DropForeignKey("dbo.Usuario", "Turma_Id", "dbo.Turma");
            DropForeignKey("dbo.Falta", "DisciplinaMatriculada_Id", "dbo.DisciplinaMatriculada");
            DropIndex("dbo.Avaliacao", new[] { "DisciplinaMatriculada_Id" });
            DropIndex("dbo.DisciplinaMatriculada", new[] { "Discente_Id" });
            DropIndex("dbo.Usuario", new[] { "Turma_Id" });
            DropIndex("dbo.Falta", new[] { "DisciplinaMatriculada_Id" });
            DropColumn("dbo.Avaliacao", "DisciplinaMatriculada_Id");
            DropColumn("dbo.DisciplinaMatriculada", "Discente_Id");
            DropColumn("dbo.Usuario", "Turma_Id");
            DropColumn("dbo.Falta", "DisciplinaMatriculada_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Falta", "DisciplinaMatriculada_Id", c => c.Guid());
            AddColumn("dbo.Usuario", "Turma_Id", c => c.Guid());
            AddColumn("dbo.DisciplinaMatriculada", "Discente_Id", c => c.Guid());
            AddColumn("dbo.Avaliacao", "DisciplinaMatriculada_Id", c => c.Guid());
            CreateIndex("dbo.Falta", "DisciplinaMatriculada_Id");
            CreateIndex("dbo.Usuario", "Turma_Id");
            CreateIndex("dbo.DisciplinaMatriculada", "Discente_Id");
            CreateIndex("dbo.Avaliacao", "DisciplinaMatriculada_Id");
            AddForeignKey("dbo.Falta", "DisciplinaMatriculada_Id", "dbo.DisciplinaMatriculada", "Id");
            AddForeignKey("dbo.Usuario", "Turma_Id", "dbo.Turma", "Id");
            AddForeignKey("dbo.DisciplinaMatriculada", "Discente_Id", "dbo.Usuario", "Id");
            AddForeignKey("dbo.Avaliacao", "DisciplinaMatriculada_Id", "dbo.DisciplinaMatriculada", "Id");
        }
    }
}

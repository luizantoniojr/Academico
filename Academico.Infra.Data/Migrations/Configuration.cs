using System.Data.Entity.Migrations;

namespace Academico.Infra.Data.Migrations
{
    public class Configuration : DbMigrationsConfiguration<Context.AcademicoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}

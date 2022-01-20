namespace PrototypeMIP_mk1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PrototypeMIP_mk1.Model.EF_DBContext.UserDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PrototypeMIP_mk1.Model.UserDbContext";
        }

        protected override void Seed(PrototypeMIP_mk1.Model.EF_DBContext.UserDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

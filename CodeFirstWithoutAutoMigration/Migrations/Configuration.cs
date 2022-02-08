namespace CodeFirstWithoutAutoMigration.Migrations
{
    using CodeFirstWithoutAutoMigration.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstWithoutAutoMigration.Entity.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CodeFirstWithoutAutoMigration.Entity.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //context.Categories.AddOrUpdate(
            //new Category()
            //{
            //    CategoryName = "Deneme1",
            //    Description = "Deneme1 ürünü"
            //},
            //new Category()
            //{
            //    CategoryName = "Deneme2",
            //    Description = "Deneme2 ürünü"
            //},
            //new Category()
            //{
            //    CategoryName = "Deneme3",
            //    Description = "Deneme3 ürünü"
            //}
            //);
        }
    }
}

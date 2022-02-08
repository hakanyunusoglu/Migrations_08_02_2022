namespace CodeFirstWithoutAutoMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShipBetweenProductandCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category_CategoryID", c => c.Int());
            CreateIndex("dbo.Products", "Category_CategoryID");
            AddForeignKey("dbo.Products", "Category_CategoryID", "dbo.Categories", "CategoryID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_CategoryID" });
            DropColumn("dbo.Products", "Category_CategoryID");
        }
    }
}

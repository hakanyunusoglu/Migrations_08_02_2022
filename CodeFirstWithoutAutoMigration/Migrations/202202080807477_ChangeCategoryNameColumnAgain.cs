namespace CodeFirstWithoutAutoMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCategoryNameColumnAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Name", c => c.String());
            //Silmeden önce içerisindeki verileri kurtarabilirim
            Sql("Update dbo.Categories set Name=CategoryName");
            DropColumn("dbo.Categories", "CategoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryName", c => c.String());
            Sql("Update dbo.Categories set CategoryName=Name");
            DropColumn("dbo.Categories", "Name");
        }
    }
}

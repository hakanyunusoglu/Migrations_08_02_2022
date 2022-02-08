namespace CodeFirstWithoutAutoMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EkleProductTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        UnitPrice = c.Int(nullable: false),
                        QuantityPerUnit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}

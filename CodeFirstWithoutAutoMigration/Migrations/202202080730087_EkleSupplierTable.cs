namespace CodeFirstWithoutAutoMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EkleSupplierTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        ContactName = c.String(),
                    })
                .PrimaryKey(t => t.SupplierID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suppliers");
        }
    }
}

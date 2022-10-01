namespace CS_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        // This will be called when the database update (Update-Database) Command is called 
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryUniqueId = c.Int(nullable: false, identity: true),
                        CategoryId = c.String(),
                        CategoryName = c.String(),
                        BasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CategoryUniqueId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductUniqueId = c.Int(nullable: false, identity: true),
                        ProductId = c.String(),
                        ProductName = c.String(),
                        Manufacturer = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoryUniqueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductUniqueId)
                .ForeignKey("dbo.Category", t => t.CategoryUniqueId, cascadeDelete: true)
                .Index(t => t.CategoryUniqueId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "CategoryUniqueId", "dbo.Category");
            DropIndex("dbo.Product", new[] { "CategoryUniqueId" });
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}

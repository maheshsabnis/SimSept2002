namespace CS_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Category", "CategoryId", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Category", "CategoryName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Product", "ProductId", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Product", "ProductName", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Product", "Manufacturer", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Product", "Description", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "Description", c => c.String());
            AlterColumn("dbo.Product", "Manufacturer", c => c.String());
            AlterColumn("dbo.Product", "ProductName", c => c.String());
            AlterColumn("dbo.Product", "ProductId", c => c.String());
            AlterColumn("dbo.Category", "CategoryName", c => c.String());
            AlterColumn("dbo.Category", "CategoryId", c => c.String());
        }
    }
}

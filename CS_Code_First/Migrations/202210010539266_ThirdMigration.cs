namespace CS_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Vat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "TotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "TotalPrice");
            DropColumn("dbo.Product", "Vat");
        }
    }
}

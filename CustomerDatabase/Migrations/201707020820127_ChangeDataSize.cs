namespace CustomerDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataSize : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "Street", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Addresses", "BuildingNumber", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Addresses", "PostalCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Addresses", "Town", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Customers", "Surname", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "Town", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "PostalCode", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "BuildingNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "Street", c => c.String(nullable: false));
        }
    }
}

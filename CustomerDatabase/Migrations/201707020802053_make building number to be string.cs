namespace CustomerDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makebuildingnumbertobestring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "BuildingNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "BuildingNumber", c => c.Int(nullable: false));
        }
    }
}

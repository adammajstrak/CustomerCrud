namespace CustomerDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeFlatNumberNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "FlatNumber", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "FlatNumber", c => c.Int(nullable: false));
        }
    }
}

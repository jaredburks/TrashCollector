namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestDayOfWeek : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PickUpDay", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "PickUpDay");
        }
    }
}

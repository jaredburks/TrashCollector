namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VacationDateRange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "NoPickUpStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "NoPickUpEndDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "NoPickUpEndDate");
            DropColumn("dbo.Customers", "NoPickUpStartDate");
        }
    }
}

namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecifyZipCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Street", c => c.String());
            AddColumn("dbo.Customers", "City", c => c.String());
            AddColumn("dbo.Customers", "Zip", c => c.String());
            AddColumn("dbo.Workers", "Area", c => c.String());
            DropColumn("dbo.Customers", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Address", c => c.String());
            DropColumn("dbo.Workers", "Area");
            DropColumn("dbo.Customers", "Zip");
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "Street");
        }
    }
}

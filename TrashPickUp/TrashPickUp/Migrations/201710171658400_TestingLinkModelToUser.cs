namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestingLinkModelToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workers", "UserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Workers", "UserID");
            AddForeignKey("dbo.Workers", "UserID", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "UserID", "dbo.AspNetUsers");
            DropIndex("dbo.Workers", new[] { "UserID" });
            DropColumn("dbo.Workers", "UserID");
        }
    }
}

namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Workers", "UserID", "dbo.AspNetUsers");
            DropIndex("dbo.Workers", new[] { "UserID" });
            AddColumn("dbo.Workers", "loggedUser_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Workers", "UserID", c => c.String());
            CreateIndex("dbo.Workers", "loggedUser_Id");
            AddForeignKey("dbo.Workers", "loggedUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "loggedUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Workers", new[] { "loggedUser_Id" });
            AlterColumn("dbo.Workers", "UserID", c => c.String(maxLength: 128));
            DropColumn("dbo.Workers", "loggedUser_Id");
            CreateIndex("dbo.Workers", "UserID");
            AddForeignKey("dbo.Workers", "UserID", "dbo.AspNetUsers", "Id");
        }
    }
}

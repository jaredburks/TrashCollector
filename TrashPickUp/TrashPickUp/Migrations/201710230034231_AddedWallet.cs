namespace TrashPickUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWallet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Wallet", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Wallet");
        }
    }
}

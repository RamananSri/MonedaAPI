namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class goodmigrationhehe : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CashFlows", "Account_UserId", "dbo.Accounts");
            DropIndex("dbo.Accounts", new[] { "UserId" });
            DropIndex("dbo.CashFlows", new[] { "Account_UserId" });
            RenameColumn(table: "dbo.CashFlows", name: "Account_UserId", newName: "Account_Id");
            DropPrimaryKey("dbo.Accounts");
            AddColumn("dbo.Accounts", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Accounts", "Name", c => c.String());
            AlterColumn("dbo.Accounts", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.CashFlows", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.CashFlows", "Account_Id", c => c.Int());
            AddPrimaryKey("dbo.Accounts", "Id");
            CreateIndex("dbo.Accounts", "UserId");
            CreateIndex("dbo.CashFlows", "Account_Id");
            AddForeignKey("dbo.CashFlows", "Account_Id", "dbo.Accounts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CashFlows", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.CashFlows", new[] { "Account_Id" });
            DropIndex("dbo.Accounts", new[] { "UserId" });
            DropPrimaryKey("dbo.Accounts");
            AlterColumn("dbo.CashFlows", "Account_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.CashFlows", "Amount", c => c.Double(nullable: false));
            AlterColumn("dbo.Accounts", "UserId", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Accounts", "Name");
            DropColumn("dbo.Accounts", "Id");
            AddPrimaryKey("dbo.Accounts", "UserId");
            RenameColumn(table: "dbo.CashFlows", name: "Account_Id", newName: "Account_UserId");
            CreateIndex("dbo.CashFlows", "Account_UserId");
            CreateIndex("dbo.Accounts", "UserId");
            AddForeignKey("dbo.CashFlows", "Account_UserId", "dbo.Accounts", "UserId");
        }
    }
}

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedkeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CashFlows", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "Id", "dbo.Users");
            DropForeignKey("dbo.CashFlows", "User_Id", "dbo.Users");
            DropIndex("dbo.Accounts", new[] { "Id" });
            DropIndex("dbo.CashFlows", new[] { "Account_Id" });
            DropIndex("dbo.CashFlows", new[] { "User_Id" });
            RenameColumn(table: "dbo.Accounts", name: "Id", newName: "UserId");
            RenameColumn(table: "dbo.CashFlows", name: "Account_Id", newName: "Account_UserId");
            RenameColumn(table: "dbo.CashFlows", name: "User_Id", newName: "User_Username");
            DropPrimaryKey("dbo.Accounts");
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Accounts", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.CashFlows", "Account_UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.CashFlows", "User_Username", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Accounts", "UserId");
            AddPrimaryKey("dbo.Users", "Username");
            CreateIndex("dbo.Accounts", "UserId");
            CreateIndex("dbo.CashFlows", "Account_UserId");
            CreateIndex("dbo.CashFlows", "User_Username");
            AddForeignKey("dbo.CashFlows", "Account_UserId", "dbo.Accounts", "UserId");
            AddForeignKey("dbo.Accounts", "UserId", "dbo.Users", "Username");
            AddForeignKey("dbo.CashFlows", "User_Username", "dbo.Users", "Username");
            DropColumn("dbo.Users", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.CashFlows", "User_Username", "dbo.Users");
            DropForeignKey("dbo.Accounts", "UserId", "dbo.Users");
            DropForeignKey("dbo.CashFlows", "Account_UserId", "dbo.Accounts");
            DropIndex("dbo.CashFlows", new[] { "User_Username" });
            DropIndex("dbo.CashFlows", new[] { "Account_UserId" });
            DropIndex("dbo.Accounts", new[] { "UserId" });
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Accounts");
            AlterColumn("dbo.CashFlows", "User_Username", c => c.Int());
            AlterColumn("dbo.CashFlows", "Account_UserId", c => c.Int());
            AlterColumn("dbo.Users", "Username", c => c.String());
            AlterColumn("dbo.Accounts", "UserId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Users", "Id");
            AddPrimaryKey("dbo.Accounts", "Id");
            RenameColumn(table: "dbo.CashFlows", name: "User_Username", newName: "User_Id");
            RenameColumn(table: "dbo.CashFlows", name: "Account_UserId", newName: "Account_Id");
            RenameColumn(table: "dbo.Accounts", name: "UserId", newName: "Id");
            CreateIndex("dbo.CashFlows", "User_Id");
            CreateIndex("dbo.CashFlows", "Account_Id");
            CreateIndex("dbo.Accounts", "Id");
            AddForeignKey("dbo.CashFlows", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Accounts", "Id", "dbo.Users", "Id");
            AddForeignKey("dbo.CashFlows", "Account_Id", "dbo.Accounts", "Id");
        }
    }
}

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CashFlows", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "UserId", "dbo.Users");
            DropForeignKey("dbo.CashFlows", "Frequency_Id", "dbo.Frequencies");
            DropIndex("dbo.Accounts", new[] { "UserId" });
            DropIndex("dbo.CashFlows", new[] { "Account_Id" });
            DropIndex("dbo.CashFlows", new[] { "Frequency_Id" });
            RenameColumn(table: "dbo.CashFlows", name: "Account_Id", newName: "AccountId");
            RenameColumn(table: "dbo.CashFlows", name: "Frequency_Id", newName: "FrequencyId");
            AddColumn("dbo.Accounts", "User_Username", c => c.String(maxLength: 128));
            AddColumn("dbo.CashFlows", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Accounts", "UserId", c => c.String());
            AlterColumn("dbo.CashFlows", "AccountId", c => c.Int(nullable: false));
            AlterColumn("dbo.CashFlows", "FrequencyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Accounts", "User_Username");
            CreateIndex("dbo.CashFlows", "FrequencyId");
            CreateIndex("dbo.CashFlows", "AccountId");
            AddForeignKey("dbo.CashFlows", "AccountId", "dbo.Accounts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Accounts", "User_Username", "dbo.Users", "Username");
            AddForeignKey("dbo.CashFlows", "FrequencyId", "dbo.Frequencies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CashFlows", "FrequencyId", "dbo.Frequencies");
            DropForeignKey("dbo.Accounts", "User_Username", "dbo.Users");
            DropForeignKey("dbo.CashFlows", "AccountId", "dbo.Accounts");
            DropIndex("dbo.CashFlows", new[] { "AccountId" });
            DropIndex("dbo.CashFlows", new[] { "FrequencyId" });
            DropIndex("dbo.Accounts", new[] { "User_Username" });
            AlterColumn("dbo.CashFlows", "FrequencyId", c => c.Int());
            AlterColumn("dbo.CashFlows", "AccountId", c => c.Int());
            AlterColumn("dbo.Accounts", "UserId", c => c.String(maxLength: 128));
            DropColumn("dbo.CashFlows", "UserId");
            DropColumn("dbo.Accounts", "User_Username");
            RenameColumn(table: "dbo.CashFlows", name: "FrequencyId", newName: "Frequency_Id");
            RenameColumn(table: "dbo.CashFlows", name: "AccountId", newName: "Account_Id");
            CreateIndex("dbo.CashFlows", "Frequency_Id");
            CreateIndex("dbo.CashFlows", "Account_Id");
            CreateIndex("dbo.Accounts", "UserId");
            AddForeignKey("dbo.CashFlows", "Frequency_Id", "dbo.Frequencies", "Id");
            AddForeignKey("dbo.Accounts", "UserId", "dbo.Users", "Username");
            AddForeignKey("dbo.CashFlows", "Account_Id", "dbo.Accounts", "Id");
        }
    }
}

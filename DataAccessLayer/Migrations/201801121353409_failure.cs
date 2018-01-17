namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class failure : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CashFlows", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.CashFlows", "FrequencyId", "dbo.Frequencies");
            DropIndex("dbo.CashFlows", new[] { "FrequencyId" });
            DropIndex("dbo.CashFlows", new[] { "AccountId" });
            RenameColumn(table: "dbo.CashFlows", name: "AccountId", newName: "Account_Id");
            RenameColumn(table: "dbo.CashFlows", name: "FrequencyId", newName: "Frequency_Id");
            AlterColumn("dbo.CashFlows", "Frequency_Id", c => c.Int());
            AlterColumn("dbo.CashFlows", "Account_Id", c => c.Int());
            CreateIndex("dbo.CashFlows", "Account_Id");
            CreateIndex("dbo.CashFlows", "Frequency_Id");
            AddForeignKey("dbo.CashFlows", "Account_Id", "dbo.Accounts", "Id");
            AddForeignKey("dbo.CashFlows", "Frequency_Id", "dbo.Frequencies", "Id");
            DropColumn("dbo.CashFlows", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CashFlows", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.CashFlows", "Frequency_Id", "dbo.Frequencies");
            DropForeignKey("dbo.CashFlows", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.CashFlows", new[] { "Frequency_Id" });
            DropIndex("dbo.CashFlows", new[] { "Account_Id" });
            AlterColumn("dbo.CashFlows", "Account_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.CashFlows", "Frequency_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.CashFlows", name: "Frequency_Id", newName: "FrequencyId");
            RenameColumn(table: "dbo.CashFlows", name: "Account_Id", newName: "AccountId");
            CreateIndex("dbo.CashFlows", "AccountId");
            CreateIndex("dbo.CashFlows", "FrequencyId");
            AddForeignKey("dbo.CashFlows", "FrequencyId", "dbo.Frequencies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CashFlows", "AccountId", "dbo.Accounts", "Id", cascadeDelete: true);
        }
    }
}

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class worksnow : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CashFlows", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.CashFlows", "Frequency_Id", "dbo.Frequencies");
            DropIndex("dbo.CashFlows", new[] { "Account_Id" });
            DropIndex("dbo.CashFlows", new[] { "Frequency_Id" });
            RenameColumn(table: "dbo.CashFlows", name: "Account_Id", newName: "AccountId");
            RenameColumn(table: "dbo.CashFlows", name: "Frequency_Id", newName: "FrequencyId");
            AddColumn("dbo.Accounts", "UserId", c => c.String());
            AddColumn("dbo.CashFlows", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.CashFlows", "AccountId", c => c.Int(nullable: false));
            AlterColumn("dbo.CashFlows", "FrequencyId", c => c.Int(nullable: false));
            CreateIndex("dbo.CashFlows", "FrequencyId");
            CreateIndex("dbo.CashFlows", "AccountId");
            AddForeignKey("dbo.CashFlows", "AccountId", "dbo.Accounts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CashFlows", "FrequencyId", "dbo.Frequencies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CashFlows", "FrequencyId", "dbo.Frequencies");
            DropForeignKey("dbo.CashFlows", "AccountId", "dbo.Accounts");
            DropIndex("dbo.CashFlows", new[] { "AccountId" });
            DropIndex("dbo.CashFlows", new[] { "FrequencyId" });
            AlterColumn("dbo.CashFlows", "FrequencyId", c => c.Int());
            AlterColumn("dbo.CashFlows", "AccountId", c => c.Int());
            DropColumn("dbo.CashFlows", "UserId");
            DropColumn("dbo.Accounts", "UserId");
            RenameColumn(table: "dbo.CashFlows", name: "FrequencyId", newName: "Frequency_Id");
            RenameColumn(table: "dbo.CashFlows", name: "AccountId", newName: "Account_Id");
            CreateIndex("dbo.CashFlows", "Frequency_Id");
            CreateIndex("dbo.CashFlows", "Account_Id");
            AddForeignKey("dbo.CashFlows", "Frequency_Id", "dbo.Frequencies", "Id");
            AddForeignKey("dbo.CashFlows", "Account_Id", "dbo.Accounts", "Id");
        }
    }
}

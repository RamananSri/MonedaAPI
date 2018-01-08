namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CashFlows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Description = c.String(),
                        Account_Id = c.Int(),
                        Frequency_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .ForeignKey("dbo.Frequencies", t => t.Frequency_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Account_Id)
                .Index(t => t.Frequency_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Frequencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CashFlows", "User_Id", "dbo.Users");
            DropForeignKey("dbo.CashFlows", "Frequency_Id", "dbo.Frequencies");
            DropForeignKey("dbo.CashFlows", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "Id", "dbo.Users");
            DropIndex("dbo.CashFlows", new[] { "User_Id" });
            DropIndex("dbo.CashFlows", new[] { "Frequency_Id" });
            DropIndex("dbo.CashFlows", new[] { "Account_Id" });
            DropIndex("dbo.Accounts", new[] { "Id" });
            DropTable("dbo.Frequencies");
            DropTable("dbo.CashFlows");
            DropTable("dbo.Users");
            DropTable("dbo.Accounts");
        }
    }
}

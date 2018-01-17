namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ok : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Accounts", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "UserId", c => c.String());
        }
    }
}

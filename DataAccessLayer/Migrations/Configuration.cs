namespace DataAccessLayer.Migrations
{
    using ModelLayer;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<DomainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        
        protected override void Seed(DomainContext context)
        {

            //TODO: dupes!
            context.Database.ExecuteSqlCommand("delete from Accounts");
            context.Database.ExecuteSqlCommand("delete from Cashflows");
            context.Database.ExecuteSqlCommand("delete from Users");
            context.Database.ExecuteSqlCommand("delete from Frequencies");

            context.frequencies.AddOrUpdate(new Frequency { Description = "Årlig" });
            context.frequencies.AddOrUpdate(new Frequency { Description = "Månedlig" });
            context.frequencies.AddOrUpdate(new Frequency { Description = "Engang" });
            context.frequencies.AddOrUpdate(new Frequency { Description = "Kvartal" });
            context.frequencies.AddOrUpdate(new Frequency { Description = "Ugentlig" });

            context.users.AddOrUpdate(new User { Username = "brian", Password = "brian" });
            context.users.AddOrUpdate(new User { Username = "admin", Password = "admin" });
        }
    }
}

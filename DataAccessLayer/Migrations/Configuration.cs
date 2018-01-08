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

            context.frequencies.AddOrUpdate(new Frequency { description = "Yearly" });
            context.frequencies.AddOrUpdate(new Frequency { description = "Monthly" });
            context.frequencies.AddOrUpdate(new Frequency { description = "Single" });
            context.frequencies.AddOrUpdate(new Frequency { description = "Quarter" });
            context.frequencies.AddOrUpdate(new Frequency { description = "Weekly" });

            context.users.AddOrUpdate(new User { Username = "brian", Password = "brian" });
            context.users.AddOrUpdate(new User { Username = "admin", Password = "admin" });
        }
    }
}

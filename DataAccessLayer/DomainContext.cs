using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DomainContext : DbContext
    {

        public DomainContext() : base("MSDbContext")
        {
            //Database.SetInitializer<DomainContext>(new CreateDatabaseIfNotExists<DomainContext>());
        }

        //TODO: Refactor with IoC - constructor injection 

        //public DomainContext() : base("OracleDbContext")
        //{
        //}

        public DbSet<User> users { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<CashFlow> cashFlows { get; set; }
        public DbSet<Frequency> frequencies { get; set; }


    }
}

using System.Collections.Generic;
using CustomerDatabase.Model;

namespace CustomerDatabase.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<CustomerDatabase.EntityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CustomerDatabase.EntityDbContext context)
        {
            context.Address.AddOrUpdate(x => x.Id,
                new Address() { Id = 1, Street = "Katowicka", BuildingNumber = "9", FlatNumber = 8, PostalCode = "43-100", Town="Tychy", CustomerId = 1 },
                new Address() { Id = 2, Street = "Tyska", BuildingNumber = "8A", FlatNumber = 7, PostalCode = "42-200", Town="Katowice", CustomerId = 2 },
                new Address() { Id = 3, Street = "Wejchertów", BuildingNumber = "81C", FlatNumber = 72, PostalCode = "22-200", Town="Warszawa", CustomerId = 3 }
              );

            context.Customer.AddOrUpdate(x => x.Id,
                new Customer() { Id = 1, Name = "Adam", Surname = "Majstrak", TelephoneNumber = 0048722000000 },
                new Customer() { Id = 2, Name = "Adrianna", Surname = "Majstrak", TelephoneNumber = 0048999000000 },
                new Customer() { Id = 3, Name = "Ewa", Surname = "Janosz", TelephoneNumber = 0048888000000 }
              );
        }
    }
}

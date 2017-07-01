//-----------------------------------------------------------------------
// <copyright file="EntityDbContext.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace CustomerDatabase
{
    using System.Data.Entity;
    using CustomerDatabase.Model;

    /// <summary>
    /// Context of entity framework code first
    /// </summary>
    public class EntityDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDbContext"/> class.
        /// </summary>
        public EntityDbContext() : base(@"CustomerDB")
        {
        }

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public DbSet<Customer> Customer { get; set; }

        /// <summary>
        /// Gets or sets the addresses of this customer
        /// </summary>
        public DbSet<Address> Address { get; set; }
    }
}

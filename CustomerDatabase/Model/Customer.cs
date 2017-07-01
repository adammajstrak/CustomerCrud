//-----------------------------------------------------------------------
// <copyright file="Customer.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace CustomerDatabase.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Initializes a new instance of the <see cref="Customer"/> class.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets customer id
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets customer name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets customer surname
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets customer telephone
        /// </summary>
        [Required]
        public long TelephoneNumber { get; set; }

        /// <summary>
        /// Gets or sets customer addresses.
        /// For this moment person have only one address, but in the future
        /// it's possible to add extra address to the same customer without impact to db
        /// </summary>
        public virtual ICollection<Address> Addresses { get; set; }
    }
}

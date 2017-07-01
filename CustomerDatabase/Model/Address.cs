//-----------------------------------------------------------------------
// <copyright file="Address.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace CustomerDatabase.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Initializes a new instance of the <see cref="Address"/> class.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets address id
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the street
        /// </summary>
        [Required]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the building number
        /// </summary>
        [Required]
        public int BuildingNumber { get; set; }

        /// <summary>
        /// Gets or sets the flat number
        /// </summary>
        public int FlatNumber { get; set; }

        /// <summary>
        /// Gets or sets the postal code
        /// </summary>
        [Required]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the town
        /// </summary>
        [Required]
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets foreign key to customer
        /// </summary>
        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets navigation property to customer
        /// </summary>
        public virtual Customer Customer { get; set; }
    }
}

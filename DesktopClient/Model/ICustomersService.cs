//-----------------------------------------------------------------------
// <copyright file="ICustomersService.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Customer service interface allows to manage customer data
    /// </summary>
    public interface ICustomersService
    {
        /// <summary>
        /// Allow to create customer
        /// </summary>
        /// <param name="customer">Customer object to save</param>
        void CreateCustomer(Customer customer);

        /// <summary>
        /// Gets all customers
        /// </summary>
        /// <returns>Customers list</returns>
        IEnumerable<Customer> GetAllCustomers();

        /// <summary>
        /// Gets customer by id
        /// </summary>
        /// <param name="id">Id of customer</param>
        /// <returns>Customer object</returns>
        Customer GetCustomerById(int id);

        /// <summary>
        /// Update customer
        /// </summary>
        /// <param name="customer">New customer date</param>
        void UpdateCustomer(Customer customer);

        /// <summary>
        /// Delete customer
        /// </summary>
        /// <param name="customerId">Id of customer</param>
        void DeleteCustomer(int customerId);
    }
}
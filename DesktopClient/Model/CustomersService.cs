//-----------------------------------------------------------------------
// <copyright file="CustomersService.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.Model
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Implementation of customer service interface allows to manage customer data
    /// </summary>
    public class CustomersService : ICustomersService
    {
        /// <summary>
        /// OData service client
        /// </summary>
        private CustomerRestClient.Model.Default.Container serviceClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersService"/> class.
        /// </summary>
        /// <param name="serviceClient">Instance of customer OData service</param>
        public CustomersService(CustomerRestClient.Model.Default.Container serviceClient)
        {
            this.serviceClient = serviceClient;
        }

        /// <summary>
        /// Allow to create customer
        /// </summary>
        /// <param name="customer">Customer object to save</param>
        public void CreateCustomer(Customer customer)
        {
            this.TryToMakeIt(() =>
            {
                var newCustomer = new CustomerRestClient.Model.CustomerDatabase.Model.Customer()
                {
                    Name = customer.Name,
                    Surname = customer.Surname,
                    TelephoneNumber = customer.TelephoneNumber
                };

                serviceClient.AddToCustomers(newCustomer);
                serviceClient.SaveChanges();

                var customerAddress = new CustomerRestClient.Model.CustomerDatabase.Model.Address()
                {
                    BuildingNumber = customer.Addresses.First().BuildingNumber,
                    FlatNumber = customer.Addresses.First().FlatNumber,
                    PostalCode = customer.Addresses.First().PostalCode,
                    Street = customer.Addresses.First().Street,
                    Town = customer.Addresses.First().Town,
                    CustomerId = newCustomer.Id
                };

                newCustomer.Addresses.Add(customerAddress);

                serviceClient.AddToAddresses(customerAddress);
                serviceClient.SaveChanges();
            });
        }

        /// <summary>
        /// Gets all customers
        /// </summary>
        /// <returns>Customers list</returns>
        public IEnumerable<Customer> GetAllCustomers()
        {
            return this.TryToMakeIt(() =>
            {
                var result = serviceClient.Customers.Expand(p => p.Addresses).ToList()
                    .Select(x => new Customer()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Surname = x.Surname,
                        TelephoneNumber = x.TelephoneNumber,
                        Addresses = new ObservableCollection<Address>()
                        {
                            x.Addresses.Select(a => new Address()
                            {
                                Id = a.Id,
                                BuildingNumber = a.BuildingNumber,
                                FlatNumber = a.FlatNumber,
                                PostalCode = a.PostalCode,
                                Street = a.Street,
                                Town = a.Town
                            }).First()
                        }
                    })
                    .ToList();

                return result;
            });
        }
        
        /// <summary>
        /// Gets customer by id
        /// </summary>
        /// <param name="id">Id of customer</param>
        /// <returns>Customer object</returns>
        public Customer GetCustomerById(int id)
        {
            return this.TryToMakeIt(() =>
            {
                //// First and FirstOrDefault is not supported by OData client so, I cannot put prdicate inside it
                var result = serviceClient.Customers.Expand(p => p.Addresses).Where(x => x.Id == id).ToList()
               .Select(x => new Customer()
               {
                   Id = x.Id,
                   Name = x.Name,
                   Surname = x.Surname,
                   TelephoneNumber = x.TelephoneNumber,
                   Addresses = new ObservableCollection<Address>()
                        {
                            x.Addresses.Select(a => new Address()
                            {
                                Id = a.Id,
                                BuildingNumber = a.BuildingNumber,
                                FlatNumber = a.FlatNumber,
                                PostalCode = a.PostalCode,
                                Street = a.Street,
                                Town = a.Town
                            }).First()
                        }
               })
                .FirstOrDefault();
                return result;
            });
        }

        /// <summary>
        /// Update customer
        /// </summary>
        /// <param name="customer">New customer date</param>
        public void UpdateCustomer(Customer customer)
        {
            this.TryToMakeIt(() =>
            {
                var customerEntity = serviceClient.Customers.Where(x => x.Id == customer.Id).First();
                customerEntity.Name = customer.Name;
                customerEntity.Surname = customer.Surname;
                customerEntity.TelephoneNumber = customer.TelephoneNumber;
                var addressEntity = customerEntity.Addresses.First();
                var addressVm = customer.Addresses.First();
                addressEntity.BuildingNumber = addressVm.BuildingNumber;
                addressEntity.FlatNumber = addressVm.FlatNumber;
                addressEntity.PostalCode = addressVm.PostalCode;
                addressEntity.Street = addressVm.Street;
                addressEntity.Town = addressVm.Town;

                serviceClient.UpdateObject(customerEntity);
                serviceClient.UpdateObject(addressEntity);
                serviceClient.SaveChanges();
            });
        }

        /// <summary>
        /// Delete customer
        /// </summary>
        /// <param name="customerId">Id of customer</param>
        public void DeleteCustomer(int customerId)
        {
            this.TryToMakeIt(() =>
            {
                serviceClient.DeleteObject(serviceClient.Customers.Where(x => x.Id == customerId).First());
                serviceClient.SaveChanges();
            });
        }

        /// <summary>
        /// Helper allows to try to execute function in try/catch statement
        /// </summary>
        /// <typeparam name="T">Function return type</typeparam>
        /// <param name="request">Function to do</param>
        /// <returns>Result of function</returns>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1116:SplitParametersMustStartOnLineAfterDeclaration", Justification = "Reviewed.")]
        private T TryToMakeIt<T>(Func<T> request)
        {
            try
            {
                return request();
            }
            catch (Microsoft.OData.Client.DataServiceTransportException ex)
            {
                //// SA116: We shouldn't to add string, but I did it to make it more clear.
                //// I would to use verbatim string, but in this case I couldn't to use tab to format code... So I will stay with that...

                throw new ConnectionToServiceException("Cannot connect to customer service. Check if the service is running.\r\n" +
                                                       "If not - please start CustomerOdataServiceSelfHost.exe process.\r\n" +
                                                       "Check also if your database exist.\r\n" +
                                                       "If not - please execute 'update-database' in your package manager console\r\n\r\n", 
                                                       ex);
            }
            catch (Microsoft.OData.Client.DataServiceRequestException ex)
            {
                throw new ConnectionToServiceException(
                   "Cannot connect to customer service. Check if the service is running", ex);
            }
        }

        /// <summary>
        /// Helper allows to try to execute action in try/catch statement
        /// </summary>
        /// <param name="request">Action to do</param>
        private void TryToMakeIt(Action request)
        {
            try
            {
                request();
            }
            catch (Microsoft.OData.Client.DataServiceTransportException ex)
            {
                throw new ConnectionToServiceException("Cannot connect to customer service. Check if the service is running", ex);
            }
            catch (Microsoft.OData.Client.DataServiceRequestException ex)
            {
                throw new ConnectionToServiceException(
                   "Cannot connect to customer service. Check if the service is running", ex);
            }
        }
    }
}

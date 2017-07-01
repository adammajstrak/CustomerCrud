//-----------------------------------------------------------------------
// <copyright file="CreateCustomerViewModel.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.ViewModel
{
    using System;
    using System.Collections.ObjectModel;
    using DesktopClient.Model;
    using DesktopClient.ViewModel.Abstract;
    using GalaSoft.MvvmLight.Command;
    using GalaSoft.MvvmLight.Messaging;

    /// <summary>
    ///  View model for create customer window   
    /// </summary>
    public class CreateCustomerViewModel : AbstractCustomerEditorViewModel
    {
        /// <summary>
        /// Instance of customer service provider
        /// </summary>
        private readonly ICustomersService customerService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerViewModel"/> class.
        /// </summary>
        /// <param name="customerService">instance of customer service</param>
        public CreateCustomerViewModel(ICustomersService customerService)
        {
            this.customerService = customerService;
        }

        /// <summary>
        /// Gets the command, which saves customer.
        /// </summary>
        public RelayCommand SaveCustomer
        {
            get
            {
                return new RelayCommand(() =>
                {
                    try
                    {
                        if (!ValidateAll())
                        {
                            return;
                        }

                        Customer.Addresses = new ObservableCollection<Address>() { this.CustomerAddress };
                        customerService.CreateCustomer(Customer);
                        ClearTemplate();
                        CloseWindow();
                    }
                    catch (ConnectionToServiceException ex)
                    {
                        Messenger.Default.Send(ex.Message, "FatalError");
                    }
                });
            }
        }

        /// <summary>
        /// Provides Customer object for base class
        /// </summary>
        /// <param name="id">customer id</param>
        /// <returns>Object of customers witch requested id</returns>
        protected override Customer GetCustomerById(int id)
        {
            return this.customerService.GetCustomerById(id);
        }
    }
}

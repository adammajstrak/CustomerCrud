//-----------------------------------------------------------------------
// <copyright file="MainViewModel.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.ViewModel
{
    using System;
    using System.Collections.ObjectModel;
    using System.Reflection;
    using DesktopClient.Helpers;
    using DesktopClient.Model;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using GalaSoft.MvvmLight.Messaging;

    /// <summary>
    /// View model for main window
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Instance of customer service provider
        /// </summary>
        private readonly ICustomersService customerService;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        /// <param name="customerService">instance of customer service</param>
        public MainViewModel(ICustomersService customerService)
        {
            this.customerService = customerService;
        }

        /// <summary>
        /// Gets the title of main window
        /// </summary>
        public string Title => $"Customer CRUD v.{Assembly.GetExecutingAssembly().GetName().Version}";

        /// <summary>
        /// Gets all customers
        /// </summary>
        public ObservableCollection<Customer> Customers
        {
            get
            {
                return this.TryToMakeIt(() => new ObservableCollection<Customer>(this.customerService.GetAllCustomers()));
            }
        }

        /// <summary>
        /// Gets the command, which shows edit customer window.
        /// </summary>
        public RelayCommand<int> EditCustomer
        {
            get
            {
                return new RelayCommand<int>((id) =>
                {
                    Messenger.Default.Send(new OpenWindowMessage() { Argument = id }, "EditCustomer");
                    RaisePropertyChanged("Customers");
                });
            }
        }

        /// <summary>
        /// Gets the command, which shows delete customer window.
        /// </summary>
        public RelayCommand<int> DeleteCustomer
        {
            get
            {
                return new RelayCommand<int>((id) =>
                {
                    Messenger.Default.Send(
                        new Action(() => { TryToMakeIt(() => customerService.DeleteCustomer(id)); }), 
                        "ConfirmModal");
                    RaisePropertyChanged("Customers");
                });
            }
        }

        /// <summary>
        /// Gets the command, which shows create new customer window.
        /// </summary>
        public RelayCommand<int> CreateCustomer
        {
            get
            {
                return new RelayCommand<int>((id) =>
                {
                    Messenger.Default.Send(new OpenWindowMessage(), "CreateCustomer");
                    RaisePropertyChanged("Customers");
                });
            }
        }

        /// <summary>
        /// Allows to execute some function in try/catch statement
        /// </summary>
        /// <typeparam name="T">Type which function returns</typeparam>
        /// <param name="functionToDo">What should to be done</param>
        /// <returns>Result of function</returns>
        private T TryToMakeIt<T>(Func<T> functionToDo)
        {
            try
            {
                return functionToDo();
            }
            catch (ConnectionToServiceException ex)
            {
                Messenger.Default.Send(ex.Message, "FatalError");
                return default(T);
            }
        }

        /// <summary>
        /// Allows to execute some action in try/catch statement
        /// </summary>
        /// <param name="actionToDo">What should to be done</param>
        private void TryToMakeIt(Action actionToDo)
        {
            try
            {
                actionToDo();
            }
            catch (ConnectionToServiceException ex)
            {
                Messenger.Default.Send(ex.Message, "FatalError");
            }
        }
    }
}
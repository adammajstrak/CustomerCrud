//-----------------------------------------------------------------------
// <copyright file="ViewModelLocator.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.ViewModel
{
    using System;
    using DesktopClient.Model;
    using GalaSoft.MvvmLight.Ioc;
    using Microsoft.Practices.ServiceLocation;

    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Gets the instance of OData client
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "Using Win32 naming for consistency.")]
        private readonly Func<CustomerRestClient.Model.Default.Container> oDataService = () =>
        {
            var serviceClient =
                new CustomerRestClient.Model.Default.Container(
                    new Uri(Properties.Settings.Default.ODataUri));

            return serviceClient;
        };

        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Unregister<CustomerRestClient.Model.Default.Container>(); //// SIC!
            SimpleIoc.Default.Register<CustomerRestClient.Model.Default.Container>(this.oDataService);
            SimpleIoc.Default.Register<ICustomersService, CustomersService>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<EditCustomerViewModel>();
            SimpleIoc.Default.Register<DialogWindowOkCancelViewModel>();
            SimpleIoc.Default.Register<CreateCustomerViewModel>();
        }

        /// <summary>
        /// Gets the view model for main window
        /// </summary>
        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        /// <summary>
        /// Gets the view model for edit customer  window
        /// </summary>
        public EditCustomerViewModel EditCustomer => ServiceLocator.Current.GetInstance<EditCustomerViewModel>();

        /// <summary>
        /// Gets the view model for dialog  window
        /// </summary>
        public DialogWindowOkCancelViewModel DialogWindowOkCancel => ServiceLocator.Current.GetInstance<DialogWindowOkCancelViewModel>();

        /// <summary>
        /// Gets the view model for create customer  window
        /// </summary>
        public CreateCustomerViewModel CreateCustomer => ServiceLocator.Current.GetInstance<CreateCustomerViewModel>();

        /// <summary>
        /// Unregistering components
        /// </summary>
        public static void Cleanup()
        {
            SimpleIoc.Default.Unregister<CustomerRestClient.Model.Default.Container>();
            SimpleIoc.Default.Unregister<ICustomersService>();
            SimpleIoc.Default.Unregister<MainViewModel>();
            SimpleIoc.Default.Unregister<EditCustomerViewModel>();
            SimpleIoc.Default.Unregister<DialogWindowOkCancelViewModel>();
            SimpleIoc.Default.Unregister<CreateCustomerViewModel>();
        }
    }
}
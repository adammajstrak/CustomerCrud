//-----------------------------------------------------------------------
// <copyright file="AbstractCustomerEditorViewModel.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.ViewModel.Abstract
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using DesktopClient.Helpers;
    using DesktopClient.Model;

    /// <summary>
    /// Superclass of ViewModel which is base for all ViewModels which needs to modify the customer properties 
    /// It's obvious I could use some nice library to validation, but this project would be too boring ;)
    /// </summary>
    public abstract class AbstractCustomerEditorViewModel : ValidatedViewModeBasel
    {
        /// <summary>
        /// Instance of the customer
        /// </summary>
        private Customer customer = new Customer();

        /// <summary>
        /// Instance of the customer address
        /// For now customer have only one address, but in the future we can add more the one - db is ready
        /// </summary>
        private Address customerAddress = new Address();

        /// <summary>
        /// customer telephone number
        /// this field is required, because telephone number can be in format with + on the beginning or - between numbers sets
        /// </summary>
        private string telephoneNumber;

        /// <summary>
        /// customer flat number
        /// I keep it in string, to do not invoke default parse validation, but handle it bu myself
        /// </summary>
        private string flatNumber;

        /// <summary>
        /// customer id
        /// </summary>
        private int customerId;

        /// <summary>
        /// Request for close the window
        /// </summary>
        public event EventHandler Close;
        
        /// <summary>
        /// Gets or sets the id of customer
        /// When it sets, that means I edit the next customer, so I need to clear previous state
        /// </summary>
        public int CustomerId
        {
            get
            {
                return this.customerId;
            }

            set
            {
                this.customerId = value;
                this.customer = this.GetCustomerById(this.customerId);
                this.customerAddress = this.customer.Addresses.FirstOrDefault();
                this.telephoneNumber = this.customer.TelephoneNumber.TelNbrFormat();
                this.flatNumber = this.customer.Addresses.FirstOrDefault().FlatNumber.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the name of customer
        /// </summary>
        public string Name
        {
            get
            {
                return Customer.Name;
            }

            set
            {
                Customer.Name = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the surname of customer
        /// </summary>
        public string Surname
        {
            get
            {
                return Customer.Surname;
            }

            set
            {
                Customer.Surname = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the telephone number of Gets or sets 
        /// </summary>
        public string TelephoneNumber
        {
            get
            {
                return this.telephoneNumber;
            }

            set
            {
                this.telephoneNumber = value;

                long val;
                if (long.TryParse(value.TelNbrUnformat(), out val))
                {
                    Customer.TelephoneNumber = val;
                }

                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the building number of customer
        /// </summary>
        public string BuildingNumber
        {
            get
            {
                return this.customerAddress.BuildingNumber;
            }

            set
            {
                this.customerAddress.BuildingNumber = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the street of customer
        /// </summary>
        public string Street
        {
            get
            {
                return this.customerAddress.Street;
            }

            set
            {
                this.customerAddress.Street = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the flat number of customer
        /// </summary>
        public string FlatNumber
        {
            get
            {
                return this.flatNumber;
            }

            set
            {
                this.flatNumber = value;

                if (string.IsNullOrWhiteSpace(this.flatNumber))
                {
                    this.customerAddress.FlatNumber = null;
                }

                int val;
                if (int.TryParse(value, out val))
                {
                    this.customerAddress.FlatNumber = val;
                }

                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the postal code of customer
        /// </summary>
        public string PostalCode
        {
            get
            {
                return this.customerAddress.PostalCode;
            }

            set
            {
                this.customerAddress.PostalCode = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the town of customer
        /// </summary>
        public string Town
        {
            get
            {
                return this.customerAddress.Town;
            }

            set
            {
                this.customerAddress.Town = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        protected Customer Customer => this.customer;

        /// <summary>
        /// Gets or sets the customer address
        /// </summary>
        protected Address CustomerAddress => this.customerAddress;

        /// <summary>
        /// Requires inherit class to implement method which create customer object using his id
        /// </summary>
        /// <param name="id">Id of customer</param>
        /// <returns>Customer object</returns>
        protected abstract Customer GetCustomerById(int id);

        /// <summary>
        /// Ask for close window
        /// </summary>
        protected void CloseWindow()
        {
            this.Close?.Invoke(this, null);
        }

        /// <summary>
        /// Clears the state of this class
        /// </summary>
        protected virtual void ClearTemplate()
        {
            this.customer = new Customer();
            this.customerAddress = new Address();
            this.customer.Addresses = new ObservableCollection<Address>() { this.customerAddress };
            this.telephoneNumber = string.Empty;
            this.flatNumber = string.Empty;
            this.ClearValidation();
        }

        /// <summary>
        /// Validates all customer object
        /// </summary>
        /// <returns>True if all properties are valid</returns>
        protected virtual bool ValidateAll()
        {
            return this.IsValid("Name", "Surname", "TelephoneNumber", "Street", "BuildingNumber", "FlatNumber", "PostalCode", "Town");
        }

        /// <summary>
        /// Provides validation rules for customer form.
        /// It's obvious I could use some nice library to validation, but this project would be too boring ;)
        /// </summary>
        /// <param name="propertyName">Name o validated property</param>
        /// <returns>validation rule</returns>
        protected override Func<string> GetValiationRuleForProperty(string propertyName)
        {
            long o;

            switch (propertyName)
            {
                case "Name":
                    return () => string.IsNullOrEmpty(this.Name) ? "Name is required!" : string.Empty;
                case "Surname":
                    return () => string.IsNullOrEmpty(this.Surname) ? "Surname is required!" : string.Empty;
                case "TelephoneNumber":
                    return () =>
                    {
                        if (string.IsNullOrEmpty(this.TelephoneNumber))
                        {
                            return "Telephone number is required!";
                        }

                        if (!long.TryParse(this.TelephoneNumber.TelNbrUnformat(), out o))
                        {
                            return "Wrong format";
                        }

                        return string.Empty;
                    };
                case "Street":
                    return () => string.IsNullOrEmpty(this.Street) ? "Street is required!" : string.Empty;
                case "BuildingNumber":
                    return () => string.IsNullOrEmpty(this.BuildingNumber) ? "Building number is required!" : string.Empty;
                case "FlatNumber":
                    return () =>
                    {
                        if (!string.IsNullOrWhiteSpace(this.FlatNumber) && !long.TryParse(this.FlatNumber, out o))
                        {
                            return "Wrong format";
                        }

                        return string.Empty;
                    };
                case "PostalCode":
                    return () => string.IsNullOrEmpty(this.PostalCode) ? "PostalCode is required!" : string.Empty;
                case "Town":
                    return () => string.IsNullOrEmpty(this.Town) ? "Town is required!" : string.Empty;
            }

            return () => string.Empty;
        }
    }
}

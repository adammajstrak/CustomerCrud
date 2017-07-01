//-----------------------------------------------------------------------
// <copyright file="Customer.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.Model
{
    using System.Collections.ObjectModel;
    using GalaSoft.MvvmLight;

    /// <summary>
    /// The model of customer
    /// INotifyPropertyChanged implementation is not necessary in current case, but I will add it for the future cases
    /// </summary>
    public class Customer : ObservableObject
    {
        /// <summary>
        /// customer id
        /// </summary>
        private int id;

        /// <summary>
        /// customer name
        /// </summary>
        private string name;

        /// <summary>
        /// customer surname
        /// </summary>
        private string surname;

        /// <summary>
        /// customer telephone number
        /// </summary>
        private long telephoneNumber;

        /// <summary>
        /// Gets or sets customer id
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets customer name
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets customer surname
        /// </summary>
        public string Surname
        {
            get
            {
                return this.surname;
            }

            set
            {
                this.surname = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets customer telephone number
        /// </summary>
        public long TelephoneNumber
        {
            get
            {
                return this.telephoneNumber;
            }

            set
            {
                this.telephoneNumber = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets customer address
        /// For this moment person have only one address, but in the future
        /// it's possible to add extra addresses to the same customer without impact to db
        /// </summary>
        public ObservableCollection<Address> Addresses { get; set; }
    }
}

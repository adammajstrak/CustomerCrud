//-----------------------------------------------------------------------
// <copyright file="Address.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.Model
{
    using GalaSoft.MvvmLight;

    /// <summary>
    /// The model of customer address
    /// INotifyPropertyChanged implementation is not necessary in current case, but I will add it for the future cases
    /// </summary>
    public class Address : ObservableObject
    {
        /// <summary>
        /// customer id
        /// </summary>
        private int id;

        /// <summary>
        /// customer street
        /// </summary>
        private string street;

        /// <summary>
        /// customer building number
        /// </summary>
        private int buildingNumber;

        /// <summary>
        /// customer  flat number
        /// </summary>
        private int? flatNumber;

        /// <summary>
        /// customer  postal code
        /// </summary>
        private string postalCode;

        /// <summary>
        /// customer  town
        /// </summary>
        private string town;
        
        /// <summary>
        /// Gets or sets customer address id
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
        /// Gets or sets street
        /// </summary>
        public string Street
        {
            get
            {
                return this.street;
            }

            set
            {
                this.street = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets building number
        /// </summary>
        public int BuildingNumber
        {
            get
            {
                return this.buildingNumber;
            }

            set
            {
                this.buildingNumber = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets flat number
        /// </summary>
        public int? FlatNumber
        {
            get
            {
                return this.flatNumber;
            }

            set
            {
                this.flatNumber = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets postal code
        /// </summary>
        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }

            set
            {
                this.postalCode = value;
                this.RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets town
        /// </summary>
        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                this.town = value;
                this.RaisePropertyChanged();
            }
        }
    }
}

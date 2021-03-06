﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 02.07.2017 10:03:57
namespace CustomerRestClient.Model.CustomerDatabase.Model
{
    /// <summary>
    /// There are no comments for AddressSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AddressSingle")]
    public partial class AddressSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Address>
    {
        /// <summary>
        /// Initialize a new AddressSingle object.
        /// </summary>
        public AddressSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AddressSingle object.
        /// </summary>
        public AddressSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AddressSingle object.
        /// </summary>
        public AddressSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Address> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Customer")]
        public global::CustomerRestClient.Model.CustomerDatabase.Model.CustomerSingle Customer
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Customer == null))
                {
                    this._Customer = new global::CustomerRestClient.Model.CustomerDatabase.Model.CustomerSingle(this.Context, GetPath("Customer"));
                }
                return this._Customer;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::CustomerRestClient.Model.CustomerDatabase.Model.CustomerSingle _Customer;
    }
    /// <summary>
    /// There are no comments for Address in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Address")]
    public partial class Address : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Address object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="street">Initial value of Street.</param>
        /// <param name="buildingNumber">Initial value of BuildingNumber.</param>
        /// <param name="postalCode">Initial value of PostalCode.</param>
        /// <param name="town">Initial value of Town.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Address CreateAddress(int ID, string street, string buildingNumber, string postalCode, string town)
        {
            Address address = new Address();
            address.Id = ID;
            address.Street = street;
            address.BuildingNumber = buildingNumber;
            address.PostalCode = postalCode;
            address.Town = town;
            return address;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Street in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Street")]
        public string Street
        {
            get
            {
                return this._Street;
            }
            set
            {
                this.OnStreetChanging(value);
                this._Street = value;
                this.OnStreetChanged();
                this.OnPropertyChanged("Street");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Street;
        partial void OnStreetChanging(string value);
        partial void OnStreetChanged();
        /// <summary>
        /// There are no comments for Property BuildingNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BuildingNumber")]
        public string BuildingNumber
        {
            get
            {
                return this._BuildingNumber;
            }
            set
            {
                this.OnBuildingNumberChanging(value);
                this._BuildingNumber = value;
                this.OnBuildingNumberChanged();
                this.OnPropertyChanged("BuildingNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _BuildingNumber;
        partial void OnBuildingNumberChanging(string value);
        partial void OnBuildingNumberChanged();
        /// <summary>
        /// There are no comments for Property FlatNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FlatNumber")]
        public global::System.Nullable<int> FlatNumber
        {
            get
            {
                return this._FlatNumber;
            }
            set
            {
                this.OnFlatNumberChanging(value);
                this._FlatNumber = value;
                this.OnFlatNumberChanged();
                this.OnPropertyChanged("FlatNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<int> _FlatNumber;
        partial void OnFlatNumberChanging(global::System.Nullable<int> value);
        partial void OnFlatNumberChanged();
        /// <summary>
        /// There are no comments for Property PostalCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PostalCode")]
        public string PostalCode
        {
            get
            {
                return this._PostalCode;
            }
            set
            {
                this.OnPostalCodeChanging(value);
                this._PostalCode = value;
                this.OnPostalCodeChanged();
                this.OnPropertyChanged("PostalCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PostalCode;
        partial void OnPostalCodeChanging(string value);
        partial void OnPostalCodeChanged();
        /// <summary>
        /// There are no comments for Property Town in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Town")]
        public string Town
        {
            get
            {
                return this._Town;
            }
            set
            {
                this.OnTownChanging(value);
                this._Town = value;
                this.OnTownChanged();
                this.OnPropertyChanged("Town");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Town;
        partial void OnTownChanging(string value);
        partial void OnTownChanged();
        /// <summary>
        /// There are no comments for Property CustomerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerId")]
        public global::System.Nullable<int> CustomerId
        {
            get
            {
                return this._CustomerId;
            }
            set
            {
                this.OnCustomerIdChanging(value);
                this._CustomerId = value;
                this.OnCustomerIdChanged();
                this.OnPropertyChanged("CustomerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Nullable<int> _CustomerId;
        partial void OnCustomerIdChanging(global::System.Nullable<int> value);
        partial void OnCustomerIdChanged();
        /// <summary>
        /// There are no comments for Property Customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Customer")]
        public global::CustomerRestClient.Model.CustomerDatabase.Model.Customer Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
                this.OnCustomerChanging(value);
                this._Customer = value;
                this.OnCustomerChanged();
                this.OnPropertyChanged("Customer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::CustomerRestClient.Model.CustomerDatabase.Model.Customer _Customer;
        partial void OnCustomerChanging(global::CustomerRestClient.Model.CustomerDatabase.Model.Customer value);
        partial void OnCustomerChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for CustomerSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerSingle")]
    public partial class CustomerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Customer>
    {
        /// <summary>
        /// Initialize a new CustomerSingle object.
        /// </summary>
        public CustomerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerSingle object.
        /// </summary>
        public CustomerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerSingle object.
        /// </summary>
        public CustomerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Customer> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Addresses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Addresses")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Address> Addresses
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Addresses == null))
                {
                    this._Addresses = Context.CreateQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Address>(GetPath("Addresses"));
                }
                return this._Addresses;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Address> _Addresses;
    }
    /// <summary>
    /// There are no comments for Customer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Customer")]
    public partial class Customer : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="surname">Initial value of Surname.</param>
        /// <param name="telephoneNumber">Initial value of TelephoneNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Customer CreateCustomer(int ID, string name, string surname, long telephoneNumber)
        {
            Customer customer = new Customer();
            customer.Id = ID;
            customer.Name = name;
            customer.Surname = surname;
            customer.TelephoneNumber = telephoneNumber;
            return customer;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Surname in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Surname")]
        public string Surname
        {
            get
            {
                return this._Surname;
            }
            set
            {
                this.OnSurnameChanging(value);
                this._Surname = value;
                this.OnSurnameChanged();
                this.OnPropertyChanged("Surname");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Surname;
        partial void OnSurnameChanging(string value);
        partial void OnSurnameChanged();
        /// <summary>
        /// There are no comments for Property TelephoneNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TelephoneNumber")]
        public long TelephoneNumber
        {
            get
            {
                return this._TelephoneNumber;
            }
            set
            {
                this.OnTelephoneNumberChanging(value);
                this._TelephoneNumber = value;
                this.OnTelephoneNumberChanged();
                this.OnPropertyChanged("TelephoneNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private long _TelephoneNumber;
        partial void OnTelephoneNumberChanging(long value);
        partial void OnTelephoneNumberChanged();
        /// <summary>
        /// There are no comments for Property Addresses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Addresses")]
        public global::Microsoft.OData.Client.DataServiceCollection<global::CustomerRestClient.Model.CustomerDatabase.Model.Address> Addresses
        {
            get
            {
                return this._Addresses;
            }
            set
            {
                this.OnAddressesChanging(value);
                this._Addresses = value;
                this.OnAddressesChanged();
                this.OnPropertyChanged("Addresses");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::CustomerRestClient.Model.CustomerDatabase.Model.Address> _Addresses = new global::Microsoft.OData.Client.DataServiceCollection<global::CustomerRestClient.Model.CustomerDatabase.Model.Address>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAddressesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::CustomerRestClient.Model.CustomerDatabase.Model.Address> value);
        partial void OnAddressesChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::CustomerRestClient.Model.CustomerDatabase.Model.Address as global::CustomerRestClient.Model.CustomerDatabase.Model.AddressSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::CustomerRestClient.Model.CustomerDatabase.Model.AddressSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Address> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::CustomerRestClient.Model.CustomerDatabase.Model.AddressSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::CustomerRestClient.Model.CustomerDatabase.Model.Address as global::CustomerRestClient.Model.CustomerDatabase.Model.AddressSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::CustomerRestClient.Model.CustomerDatabase.Model.AddressSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Address> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::CustomerRestClient.Model.CustomerDatabase.Model.AddressSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::CustomerRestClient.Model.CustomerDatabase.Model.Customer as global::CustomerRestClient.Model.CustomerDatabase.Model.CustomerSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::CustomerRestClient.Model.CustomerDatabase.Model.CustomerSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Customer> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::CustomerRestClient.Model.CustomerDatabase.Model.CustomerSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::CustomerRestClient.Model.CustomerDatabase.Model.Customer as global::CustomerRestClient.Model.CustomerDatabase.Model.CustomerSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::CustomerRestClient.Model.CustomerDatabase.Model.CustomerSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Customer> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::CustomerRestClient.Model.CustomerDatabase.Model.CustomerSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}
namespace CustomerRestClient.Model.Default
{
    /// <summary>
    /// There are no comments for Container in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("Container")]
    public partial class Container : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public Container(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "CustomerDatabase.Model", "CustomerRestClient.Model.CustomerDatabase.Model");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            resolvedType = this.DefaultResolveType(typeName, "Default", "CustomerRestClient.Model.Default");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            global::Microsoft.OData.Client.OriginalNameAttribute originalNameAttribute = (global::Microsoft.OData.Client.OriginalNameAttribute)global::System.Linq.Enumerable.SingleOrDefault(global::Microsoft.OData.Client.Utility.GetCustomAttributes(clientType, typeof(global::Microsoft.OData.Client.OriginalNameAttribute), true));
            if (clientType.Namespace.Equals("CustomerRestClient.Model.CustomerDatabase.Model", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("CustomerDatabase.Model.", originalNameAttribute.OriginalName);
                }
                return string.Concat("CustomerDatabase.Model.", clientType.Name);
            }
            if (clientType.Namespace.Equals("CustomerRestClient.Model.Default", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("Default.", originalNameAttribute.OriginalName);
                }
                return string.Concat("Default.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Addresses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Addresses")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Address> Addresses
        {
            get
            {
                if ((this._Addresses == null))
                {
                    this._Addresses = base.CreateQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Address>("Addresses");
                }
                return this._Addresses;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Address> _Addresses;
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Customers")]
        public global::Microsoft.OData.Client.DataServiceQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Customer> Customers
        {
            get
            {
                if ((this._Customers == null))
                {
                    this._Customers = base.CreateQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Customer>("Customers");
                }
                return this._Customers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::CustomerRestClient.Model.CustomerDatabase.Model.Customer> _Customers;
        /// <summary>
        /// There are no comments for Addresses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public void AddToAddresses(global::CustomerRestClient.Model.CustomerDatabase.Model.Address address)
        {
            base.AddObject("Addresses", address);
        }
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public void AddToCustomers(global::CustomerRestClient.Model.CustomerDatabase.Model.Customer customer)
        {
            base.AddObject("Customers", customer);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""CustomerDatabase.Model"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""Address"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Street"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""BuildingNumber"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""FlatNumber"" Type=""Edm.Int32"" />
        <Property Name=""PostalCode"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""Town"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""CustomerId"" Type=""Edm.Int32"" />
        <NavigationProperty Name=""Customer"" Type=""CustomerDatabase.Model.Customer"">
          <ReferentialConstraint Property=""CustomerId"" ReferencedProperty=""Id"" />
        </NavigationProperty>
      </EntityType>
      <EntityType Name=""Customer"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Name"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""Surname"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""TelephoneNumber"" Type=""Edm.Int64"" Nullable=""false"" />
        <NavigationProperty Name=""Addresses"" Type=""Collection(CustomerDatabase.Model.Address)"" />
      </EntityType>
    </Schema>
    <Schema Namespace=""Default"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityContainer Name=""Container"">
        <EntitySet Name=""Addresses"" EntityType=""CustomerDatabase.Model.Address"">
          <NavigationPropertyBinding Path=""Customer"" Target=""Customers"" />
        </EntitySet>
        <EntitySet Name=""Customers"" EntityType=""CustomerDatabase.Model.Customer"">
          <NavigationPropertyBinding Path=""Addresses"" Target=""Addresses"" />
        </EntitySet>
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    return global::Microsoft.OData.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
}

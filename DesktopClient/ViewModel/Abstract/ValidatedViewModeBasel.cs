//-----------------------------------------------------------------------
// <copyright file="ValidatedViewModeBasel.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.ViewModel.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using GalaSoft.MvvmLight;

    /// <summary>
    /// Base view model class which allows for validation properties implement IdDirty mechanism and INotifyPropertyChanged interface
    /// </summary>
    public abstract class ValidatedViewModeBasel : ViewModelBase, IDataErrorInfo
    {
        /// <summary>
        /// List of modified properties
        /// </summary>
        private readonly HashSet<string> dirtyFlags = new HashSet<string>();

        /// <summary>
        /// List of not valid properties
        /// </summary>
        private readonly HashSet<string> notValifFields = new HashSet<string>();
        
        /// <summary>
        /// Gets the error. I mean, It would to get it, if it was implemented :D 
        /// Not implemented
        /// </summary>
        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Indexer allows to validate properties, required by IDataErrorInfo
        /// </summary>
        /// <param name="propertyName">Name of property to check</param>
        /// <returns>Error message (if any)</returns>
        public string this[string propertyName]
        {
            get
            {
                string result = this.Validate(propertyName, this.GetValiationRuleForProperty(propertyName));
                return result;
            }
        }

        /// <summary>
        /// Modified implementation of INotifyPropertyChanged, which allows to set flag, that some filed is dirty.
        /// </summary>
        /// <param name="propertyName">Name of property which notifies</param>
        public override void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.SetDirty(propertyName);
            base.RaisePropertyChanged(propertyName);
        }

        /// <summary>
        /// Clear validation results
        /// </summary>
        protected void ClearValidation()
        {
            this.dirtyFlags.Clear();
            this.notValifFields.Clear();
        }

        /// <summary>
        /// Validates some properties according to rule
        /// </summary>
        /// <param name="fieldName">Property to validate</param>
        /// <param name="checkingFunction">Validation rule</param>
        /// <returns>Validation error message</returns>
        protected string Validate(string fieldName, Func<string> checkingFunction)
        {
            //// I validate only the properties which was modified before
            bool shouldBeChecked = this.dirtyFlags.Contains(fieldName);
            
            string errorMessage = checkingFunction();

            bool error = shouldBeChecked && (errorMessage != string.Empty);

            if (error)
            {
                this.notValifFields.Add(fieldName);
            }
            else
            {
                this.notValifFields.Remove(fieldName);
                errorMessage = string.Empty;
            }

            return errorMessage;
        }

        /// <summary>
        /// Validates all properties given in parameters
        /// </summary>
        /// <param name="props">Properties names to be valid</param>
        /// <returns>True if all are valid</returns>
        protected bool IsValid(params string[] props)
        {
            //// I invokes RaisePropertyChanged to make all properties 'dirty'
            //// It's because only dirty properties are validated
            foreach (var prop in props)
            {
                this.RaisePropertyChanged(prop);
            }

            return this.notValifFields.Count == 0;
        }

        /// <summary>
        /// Ask inherited classes to describe validation rules for all properties
        /// </summary>
        /// <param name="propertyName">Name of property to be validated</param>
        /// <returns>Validation function for this property</returns>
        protected abstract Func<string> GetValiationRuleForProperty(string propertyName);

        /// <summary>
        /// Allows to set some property as 'dirty'
        /// </summary>
        /// <param name="propertyName">Name of property to set</param>
        private void SetDirty([CallerMemberName] string propertyName = null)
        {
            if (propertyName != null)
            {
                this.dirtyFlags.Add(propertyName);
            }
        }
    }
}

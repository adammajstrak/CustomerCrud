//-----------------------------------------------------------------------
// <copyright file="DialogWindowOkCancelViewModel.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.ViewModel
{
    using System;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;

    /// <summary>
    ///  View model for modal confirmation dialog 
    /// </summary>
    public class DialogWindowOkCancelViewModel : ViewModelBase
    {
        /// <summary>
        /// Request for close this dialog
        /// </summary>
        public event EventHandler Close;

        /// <summary>
        /// Gets or sets the action which should to be invoked in case of confirmation
        /// </summary>
        public Action ActionToDo { get; set; }
        
        /// <summary>
        /// Gets the command which will be raised if somebody will confirm action
        /// </summary>
        public RelayCommand ConfirmAction
        {
            get
            {
                return new RelayCommand(() =>
                {
                    ActionToDo?.Invoke();
                    Close?.Invoke(this, null);
                });
            }
        }
    }
}

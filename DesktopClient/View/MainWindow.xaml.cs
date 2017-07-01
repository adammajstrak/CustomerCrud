//-----------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.View
{
    using System;
    using System.Windows;
    using DesktopClient.Helpers;
    using DesktopClient.ViewModel;
    using GalaSoft.MvvmLight.Ioc;
    using GalaSoft.MvvmLight.Messaging;

    /// <summary>
    ///     Interaction logic for MainWindow view
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Instance of modal window
        /// </summary>
        private Window modalWindow;

        /// <summary>
        ///     Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

            Messenger.Default.Register<OpenWindowMessage>(
                this,
                "EditCustomer",
                msg =>
                {
                    var vm = SimpleIoc.Default.GetInstance<EditCustomerViewModel>();
                    vm.CustomerId = (int)msg.Argument;
                    vm.Close += CloseModal;

                    modalWindow = new EditCustomer
                    {
                        DataContext = SimpleIoc.Default.GetInstance<EditCustomerViewModel>()
                    };

                    modalWindow.ShowDialog();

                    vm.Close -= CloseModal;
                });

            Messenger.Default.Register<OpenWindowMessage>(
                this,
                "CreateCustomer",
                msg =>
                {
                    var vm = SimpleIoc.Default.GetInstance<CreateCustomerViewModel>();

                    vm.Close += CloseModal;

                    modalWindow = new CreateCustomer
                    {
                        DataContext = SimpleIoc.Default.GetInstance<CreateCustomerViewModel>()
                    };

                    modalWindow.ShowDialog();

                    vm.Close -= CloseModal;
                });

            Messenger.Default.Register<Action>(
                this,
                "ConfirmModal",
                actionToDo =>
                {
                    var vm = SimpleIoc.Default.GetInstance<DialogWindowOkCancelViewModel>();
                    vm.ActionToDo = actionToDo;

                    vm.Close += CloseModal;

                    modalWindow = new DialogWindowOkCancel
                    {
                        DataContext = SimpleIoc.Default.GetInstance<DialogWindowOkCancelViewModel>()
                    };

                    modalWindow.ShowDialog();

                    vm.Close -= CloseModal;
                });
        }

        /// <summary>
        /// Request to close current modal window
        /// </summary>
        /// <param name="sender">Requester instance => not used</param>
        /// <param name="e">Event parameters => not used</param>
        public void CloseModal(object sender, EventArgs e)
        {
           this.modalWindow.Close();
        }
    }
}
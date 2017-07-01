//-----------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient
{
    using System;
    using System.Windows;
    using DesktopClient.View;
    using GalaSoft.MvvmLight.Messaging;

    /// <summary>
    /// Interaction logic for Application
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Application entry point
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">Startup parameters</param>
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Messenger.Default.Register<string>(
                this, 
                "FatalError", 
                errorMessage =>
                {
                    if (MessageBox.Show(
                        $"{errorMessage} Close application?", "Error occurred", MessageBoxButton.YesNo, MessageBoxImage.Error) ==
                        MessageBoxResult.Yes)
                    {
                        Environment.Exit(200);
                    }
                });

            MainWindow mainWndow = new View.MainWindow();
            mainWndow.Show();
        }
    }
}

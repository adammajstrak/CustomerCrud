//-----------------------------------------------------------------------
// <copyright file="DialogWindowOkCancel.xaml.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.View
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for DialogWindowOkCancel
    /// </summary>
    public partial class DialogWindowOkCancel : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogWindowOkCancel"/> class.
        /// </summary>
        public DialogWindowOkCancel()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Close window
        /// </summary>
        /// <param name="sender">Requester instance => not used</param>
        /// <param name="e">Event parameters => not used</param>
        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

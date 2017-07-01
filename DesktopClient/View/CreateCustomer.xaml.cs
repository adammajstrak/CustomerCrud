//-----------------------------------------------------------------------
// <copyright file="CreateCustomer.xaml.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.View
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for EditCustomer
    /// </summary>
    public partial class CreateCustomer : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomer"/> class.
        /// </summary>
        public CreateCustomer()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Close window
        /// </summary>
        /// <param name="sender">Requester instance => not used</param>
        /// <param name="e">Event parameters => not used</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

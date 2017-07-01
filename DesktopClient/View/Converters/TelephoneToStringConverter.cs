//-----------------------------------------------------------------------
// <copyright file="TelephoneToStringConverter.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.View.Converters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    /// <summary>
    /// Converter long to telephone format
    /// </summary>
    public class TelephoneToStringConverter : IValueConverter
    {
        /// <summary>
        /// Converts long to telephone format
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <param name="targetType">target type</param>
        /// <param name="parameter">extra parameter</param>
        /// <param name="culture">culture info</param>
        /// <returns>Converted object</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is long))
            {
                return null;
            }
            
            var telephoneNumberFormat = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            telephoneNumberFormat.NumberGroupSeparator = " ";
            string tel = ((long)value).ToString("#,0", telephoneNumberFormat); 

            return $"+{tel}";
        }

        /// <summary>
        /// Not used
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <param name="targetType">target type</param>
        /// <param name="parameter">extra parameter</param>
        /// <param name="culture">culture info</param>
        /// <returns>Converted object</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

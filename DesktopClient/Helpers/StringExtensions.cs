//-----------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.Helpers
{
    using System.Text;

    /// <summary>
    /// Extension for string allows to format telephone number
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Allows to change formatted telephone number to normal string with digits only
        /// </summary>
        /// <param name="value">Value to format</param>
        /// <returns>string with digits only</returns>
        public static string TelNbrUnformat(this string value)
        {
            return value.Replace("-", string.Empty).Replace("+", "00").Replace(" ", string.Empty).Trim();
        }

        /// <summary>
        /// Allows to format long number to telephone number string
        /// </summary>
        /// <param name="value">Value to format</param>
        /// <returns>Formatted value</returns>
        public static string TelNbrFormat(this long value)
        {
            if (value == 0)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder(value.ToString());
            sb.Insert(0, "+", 1);

            if (sb.Length > 3)
            {
                sb.Insert(3, " ", 1);
            }

            for (int i = 7; i < sb.Length; i += 4)
            {
                sb.Insert(i, "-", 1);
            }

            var res = sb.ToString();
            return res;
        }
    }
}

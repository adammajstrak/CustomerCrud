//-----------------------------------------------------------------------
// <copyright file="ConnectionToServiceException.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace DesktopClient.Model
{
    using System;

    /// <summary>
    /// Exception which can be thrown during connection to service
    /// </summary>
    public class ConnectionToServiceException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionToServiceException"/> class.
        /// </summary>
        public ConnectionToServiceException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionToServiceException"/> class.
        /// </summary>
        /// <param name="message">Exception message</param>
        public ConnectionToServiceException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionToServiceException"/> class.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">Inner exception</param>
        public ConnectionToServiceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

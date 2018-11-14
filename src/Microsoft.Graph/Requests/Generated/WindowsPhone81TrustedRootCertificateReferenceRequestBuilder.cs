// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WindowsPhone81TrustedRootCertificateReferenceRequestBuilder.
    /// </summary>
    public partial class WindowsPhone81TrustedRootCertificateReferenceRequestBuilder : BaseRequestBuilder, IWindowsPhone81TrustedRootCertificateReferenceRequestBuilder
    {
        /// <summary>
        /// Constructs a new WindowsPhone81TrustedRootCertificateReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsPhone81TrustedRootCertificateReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsPhone81TrustedRootCertificateReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsPhone81TrustedRootCertificateReferenceRequest Request(IEnumerable<Option> options)
        {
            return new WindowsPhone81TrustedRootCertificateReferenceRequest(this.RequestUrl, this.Client, options);
        }
    }
}

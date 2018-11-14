// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequestBuilder.
    /// </summary>
    public partial class WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequestBuilder : BaseRequestBuilder, IWindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequest Request(IEnumerable<Option> options)
        {
            return new WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequest(this.RequestUrl, this.Client, options);
        }
    }
}

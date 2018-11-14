// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type Windows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class Windows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IWindows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new Windows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public Windows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new Windows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedDeviceCertificateStateWithReferenceRequestBuilder"/> for the specified Windows10ImportedPFXCertificateProfileManagedDeviceCertificateState.
        /// </summary>
        /// <param name="id">The ID for the Windows10ImportedPFXCertificateProfileManagedDeviceCertificateState.</param>
        /// <returns>The <see cref="IManagedDeviceCertificateStateWithReferenceRequestBuilder"/>.</returns>
        public IManagedDeviceCertificateStateWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new ManagedDeviceCertificateStateWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IWindows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IWindows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequestBuilder"/>.</returns>
        public IWindows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequestBuilder References
        {
            get
            {
                return new Windows10ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}

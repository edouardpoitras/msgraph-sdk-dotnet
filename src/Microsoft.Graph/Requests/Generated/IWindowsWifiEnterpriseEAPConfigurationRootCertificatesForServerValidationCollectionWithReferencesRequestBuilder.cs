// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IWindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IWindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionWithReferencesRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IWindows81TrustedRootCertificateWithReferenceRequestBuilder"/> for the specified Windows81TrustedRootCertificate.
        /// </summary>
        /// <param name="id">The ID for the Windows81TrustedRootCertificate.</param>
        /// <returns>The <see cref="IWindows81TrustedRootCertificateWithReferenceRequestBuilder"/>.</returns>
        IWindows81TrustedRootCertificateWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IWindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IWindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionReferencesRequestBuilder"/>.</returns>
        IWindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionReferencesRequestBuilder References { get; }

    }
}

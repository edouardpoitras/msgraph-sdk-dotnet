// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IWindowsUniversalAppXCommittedContainedAppsCollectionRequestBuilder.
    /// </summary>
    public partial interface IWindowsUniversalAppXCommittedContainedAppsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWindowsUniversalAppXCommittedContainedAppsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWindowsUniversalAppXCommittedContainedAppsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IMobileContainedAppRequestBuilder"/> for the specified MobileContainedApp.
        /// </summary>
        /// <param name="id">The ID for the MobileContainedApp.</param>
        /// <returns>The <see cref="IMobileContainedAppRequestBuilder"/>.</returns>
        IMobileContainedAppRequestBuilder this[string id] { get; }

        
    }
}
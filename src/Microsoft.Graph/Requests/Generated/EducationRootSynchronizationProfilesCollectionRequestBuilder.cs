// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EducationRootSynchronizationProfilesCollectionRequestBuilder.
    /// </summary>
    public partial class EducationRootSynchronizationProfilesCollectionRequestBuilder : BaseRequestBuilder, IEducationRootSynchronizationProfilesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EducationRootSynchronizationProfilesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationRootSynchronizationProfilesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEducationRootSynchronizationProfilesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEducationRootSynchronizationProfilesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new EducationRootSynchronizationProfilesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEducationSynchronizationProfileRequestBuilder"/> for the specified EducationRootEducationSynchronizationProfile.
        /// </summary>
        /// <param name="id">The ID for the EducationRootEducationSynchronizationProfile.</param>
        /// <returns>The <see cref="IEducationSynchronizationProfileRequestBuilder"/>.</returns>
        public IEducationSynchronizationProfileRequestBuilder this[string id]
        {
            get
            {
                return new EducationSynchronizationProfileRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

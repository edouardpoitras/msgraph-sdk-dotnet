// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EdiscoveryCustodianUserSourcesCollectionRequestBuilder.
    /// </summary>
    public partial class EdiscoveryCustodianUserSourcesCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IEdiscoveryCustodianUserSourcesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EdiscoveryCustodianUserSourcesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public EdiscoveryCustodianUserSourcesCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEdiscoveryCustodianUserSourcesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEdiscoveryCustodianUserSourcesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new EdiscoveryCustodianUserSourcesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserSourceRequestBuilder"/> for the specified EdiscoveryCustodianUserSource.
        /// </summary>
        /// <param name="id">The ID for the EdiscoveryCustodianUserSource.</param>
        /// <returns>The <see cref="IUserSourceRequestBuilder"/>.</returns>
        public IUserSourceRequestBuilder this[string id]
        {
            get
            {
                return new UserSourceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type StoreSetsCollectionRequestBuilder.
    /// </summary>
    public partial class StoreSetsCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IStoreSetsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new StoreSetsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public StoreSetsCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IStoreSetsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IStoreSetsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new StoreSetsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISetRequestBuilder"/> for the specified StoreSet.
        /// </summary>
        /// <param name="id">The ID for the StoreSet.</param>
        /// <returns>The <see cref="ISetRequestBuilder"/>.</returns>
        public ISetRequestBuilder this[string id]
        {
            get
            {
                return new SetRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

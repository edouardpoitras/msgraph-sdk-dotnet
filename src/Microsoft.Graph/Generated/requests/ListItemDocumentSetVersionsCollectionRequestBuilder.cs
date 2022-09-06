// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ListItemDocumentSetVersionsCollectionRequestBuilder.
    /// </summary>
    public partial class ListItemDocumentSetVersionsCollectionRequestBuilder : BaseRequestBuilder, IListItemDocumentSetVersionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ListItemDocumentSetVersionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ListItemDocumentSetVersionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IListItemDocumentSetVersionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IListItemDocumentSetVersionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ListItemDocumentSetVersionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDocumentSetVersionRequestBuilder"/> for the specified ListItemDocumentSetVersion.
        /// </summary>
        /// <param name="id">The ID for the ListItemDocumentSetVersion.</param>
        /// <returns>The <see cref="IDocumentSetVersionRequestBuilder"/>.</returns>
        public IDocumentSetVersionRequestBuilder this[string id]
        {
            get
            {
                return new DocumentSetVersionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
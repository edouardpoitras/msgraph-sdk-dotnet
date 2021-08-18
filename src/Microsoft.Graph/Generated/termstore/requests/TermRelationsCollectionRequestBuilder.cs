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
    /// The type TermRelationsCollectionRequestBuilder.
    /// </summary>
    public partial class TermRelationsCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, ITermRelationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TermRelationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public TermRelationsCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITermRelationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITermRelationsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new TermRelationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IRelationRequestBuilder"/> for the specified TermRelation.
        /// </summary>
        /// <param name="id">The ID for the TermRelation.</param>
        /// <returns>The <see cref="IRelationRequestBuilder"/>.</returns>
        public IRelationRequestBuilder this[string id]
        {
            get
            {
                return new RelationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

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
    /// The type EdiscoveryCaseReviewSetsCollectionRequestBuilder.
    /// </summary>
    public partial class EdiscoveryCaseReviewSetsCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IEdiscoveryCaseReviewSetsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EdiscoveryCaseReviewSetsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public EdiscoveryCaseReviewSetsCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEdiscoveryCaseReviewSetsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEdiscoveryCaseReviewSetsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new EdiscoveryCaseReviewSetsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEdiscoveryReviewSetRequestBuilder"/> for the specified EdiscoveryCaseEdiscoveryReviewSet.
        /// </summary>
        /// <param name="id">The ID for the EdiscoveryCaseEdiscoveryReviewSet.</param>
        /// <returns>The <see cref="IEdiscoveryReviewSetRequestBuilder"/>.</returns>
        public IEdiscoveryReviewSetRequestBuilder this[string id]
        {
            get
            {
                return new EdiscoveryReviewSetRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
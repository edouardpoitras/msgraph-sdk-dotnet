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
    /// The type GraphServiceFilterOperatorsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceFilterOperatorsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceFilterOperatorsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceFilterOperatorsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceFilterOperatorsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceFilterOperatorsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceFilterOperatorsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceFilterOperatorsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IFilterOperatorSchemaRequestBuilder"/> for the specified GraphServiceFilterOperatorSchema.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceFilterOperatorSchema.</param>
        /// <returns>The <see cref="IFilterOperatorSchemaRequestBuilder"/>.</returns>
        public IFilterOperatorSchemaRequestBuilder this[string id]
        {
            get
            {
                return new FilterOperatorSchemaRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

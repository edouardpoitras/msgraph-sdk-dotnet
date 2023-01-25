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
    /// The type AccessReviewStageDecisionsCollectionRequestBuilder.
    /// </summary>
    public partial class AccessReviewStageDecisionsCollectionRequestBuilder : BaseRequestBuilder, IAccessReviewStageDecisionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AccessReviewStageDecisionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessReviewStageDecisionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAccessReviewStageDecisionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAccessReviewStageDecisionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AccessReviewStageDecisionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAccessReviewInstanceDecisionItemRequestBuilder"/> for the specified AccessReviewStageAccessReviewInstanceDecisionItem.
        /// </summary>
        /// <param name="id">The ID for the AccessReviewStageAccessReviewInstanceDecisionItem.</param>
        /// <returns>The <see cref="IAccessReviewInstanceDecisionItemRequestBuilder"/>.</returns>
        public IAccessReviewInstanceDecisionItemRequestBuilder this[string id]
        {
            get
            {
                return new AccessReviewInstanceDecisionItemRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessReviewInstanceDecisionItemFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstanceDecisionItemFilterByCurrentUserRequestBuilder"/>.</returns>
        public IAccessReviewInstanceDecisionItemFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            AccessReviewInstanceDecisionItemFilterByCurrentUserOptions on)
        {
            return new AccessReviewInstanceDecisionItemFilterByCurrentUserRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.filterByCurrentUser"),
                this.Client,
                on);
        }
    }
}
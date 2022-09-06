// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: StreamRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System.Collections.Generic;

    /// <summary>
    /// The type AttachmentSessionContentRequestBuilder.
    /// </summary>
    public partial class AttachmentSessionContentRequestBuilder : BaseRequestBuilder, IAttachmentSessionContentRequestBuilder
    {
        /// <summary>
        /// Constructs a new AttachmentSessionContentRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AttachmentSessionContentRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAttachmentSessionContentRequest Request(IEnumerable<Option> options = null)
        {
            return new AttachmentSessionContentRequest(this.RequestUrl, this.Client, options);
        }
    }
}
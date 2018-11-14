// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type PrivilegedRoleAssignmentRequestWithReferenceRequestBuilder.
    /// </summary>
    public partial class PrivilegedRoleAssignmentRequestWithReferenceRequestBuilder : BaseRequestBuilder, IPrivilegedRoleAssignmentRequestWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new PrivilegedRoleAssignmentRequestWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrivilegedRoleAssignmentRequestWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPrivilegedRoleAssignmentRequestWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPrivilegedRoleAssignmentRequestWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new PrivilegedRoleAssignmentRequestWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the privilegedRoleAssignmentRequest.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentRequestReferenceRequestBuilder"/>.</returns>
        public IPrivilegedRoleAssignmentRequestReferenceRequestBuilder Reference
        {
            get
            {
                return new PrivilegedRoleAssignmentRequestReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}

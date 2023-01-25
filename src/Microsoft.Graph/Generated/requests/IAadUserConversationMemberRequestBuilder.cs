// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IAadUserConversationMemberRequestBuilder.
    /// </summary>
    public partial interface IAadUserConversationMemberRequestBuilder : IConversationMemberRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IAadUserConversationMemberRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IAadUserConversationMemberRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for User.
        /// </summary>
        /// <returns>The <see cref="IUserWithReferenceRequestBuilder"/>.</returns>
        IUserWithReferenceRequestBuilder User { get; }
    
    }
}
// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ITodoTaskAttachmentSessionsCollectionRequestBuilder.
    /// </summary>
    public partial interface ITodoTaskAttachmentSessionsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ITodoTaskAttachmentSessionsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ITodoTaskAttachmentSessionsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IAttachmentSessionRequestBuilder"/> for the specified AttachmentSession.
        /// </summary>
        /// <param name="id">The ID for the AttachmentSession.</param>
        /// <returns>The <see cref="IAttachmentSessionRequestBuilder"/>.</returns>
        IAttachmentSessionRequestBuilder this[string id] { get; }

        
    }
}

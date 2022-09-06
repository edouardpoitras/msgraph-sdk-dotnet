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
    /// The type ServiceUpdateMessageAttachmentsCollectionRequestBuilder.
    /// </summary>
    public partial class ServiceUpdateMessageAttachmentsCollectionRequestBuilder : BaseRequestBuilder, IServiceUpdateMessageAttachmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ServiceUpdateMessageAttachmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ServiceUpdateMessageAttachmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IServiceUpdateMessageAttachmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IServiceUpdateMessageAttachmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ServiceUpdateMessageAttachmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IServiceAnnouncementAttachmentRequestBuilder"/> for the specified ServiceUpdateMessageServiceAnnouncementAttachment.
        /// </summary>
        /// <param name="id">The ID for the ServiceUpdateMessageServiceAnnouncementAttachment.</param>
        /// <returns>The <see cref="IServiceAnnouncementAttachmentRequestBuilder"/>.</returns>
        public IServiceAnnouncementAttachmentRequestBuilder this[string id]
        {
            get
            {
                return new ServiceAnnouncementAttachmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
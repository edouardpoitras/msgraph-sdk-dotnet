// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type MessagePinnedEventMessageDetail.
    /// </summary>
    public partial class MessagePinnedEventMessageDetail : EventMessageDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagePinnedEventMessageDetail"/> class.
        /// </summary>
        public MessagePinnedEventMessageDetail()
        {
            this.ODataType = "microsoft.graph.messagePinnedEventMessageDetail";
        }

        /// <summary>
        /// Gets or sets eventDateTime.
        /// Date and time when the event occurred.
        /// </summary>
        [JsonPropertyName("eventDateTime")]
        public DateTimeOffset? EventDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets initiator.
        /// Initiator of the event.
        /// </summary>
        [JsonPropertyName("initiator")]
        public IdentitySet Initiator { get; set; }
    
    }
}
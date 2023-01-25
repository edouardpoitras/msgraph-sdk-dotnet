// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ChatMarkChatUnreadForUserRequestBody.
    /// </summary>
    public partial class ChatMarkChatUnreadForUserRequestBody
    {
    
        /// <summary>
        /// Gets or sets User.
        /// </summary>
        [JsonPropertyName("user")]
        public TeamworkUserIdentity User { get; set; }
    
        /// <summary>
        /// Gets or sets LastMessageReadDateTime.
        /// </summary>
        [JsonPropertyName("lastMessageReadDateTime")]
        public DateTimeOffset? LastMessageReadDateTime { get; set; }
    
    }
}
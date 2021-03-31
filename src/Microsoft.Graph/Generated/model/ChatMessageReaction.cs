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
    /// The type ChatMessageReaction.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ChatMessageReaction>))]
    public partial class ChatMessageReaction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageReaction"/> class.
        /// </summary>
        public ChatMessageReaction()
        {
            this.ODataType = "microsoft.graph.chatMessageReaction";
        }

        /// <summary>
        /// Gets or sets createdDateTime.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets reactionType.
        /// Supported values are like, angry, sad, laugh, heart, surprised.
        /// </summary>
        [JsonPropertyName("reactionType")]
        public string ReactionType { get; set; }
    
        /// <summary>
        /// Gets or sets user.
        /// The user who reacted to the message.
        /// </summary>
        [JsonPropertyName("user")]
        public IdentitySet User { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}

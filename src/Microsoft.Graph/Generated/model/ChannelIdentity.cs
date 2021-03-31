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
    /// The type ChannelIdentity.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ChannelIdentity>))]
    public partial class ChannelIdentity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelIdentity"/> class.
        /// </summary>
        public ChannelIdentity()
        {
            this.ODataType = "microsoft.graph.channelIdentity";
        }

        /// <summary>
        /// Gets or sets channelId.
        /// The identity of the channel in which the message was posted.
        /// </summary>
        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }
    
        /// <summary>
        /// Gets or sets teamId.
        /// The identity of the team in which the message was posted.
        /// </summary>
        [JsonPropertyName("teamId")]
        public string TeamId { get; set; }
    
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

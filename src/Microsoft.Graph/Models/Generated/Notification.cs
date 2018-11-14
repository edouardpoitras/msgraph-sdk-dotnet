// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Notification.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Notification : Entity
    {
    
        /// <summary>
        /// Gets or sets target host name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetHostName", Required = Newtonsoft.Json.Required.Default)]
        public string TargetHostName { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets payload.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payload", Required = Newtonsoft.Json.Required.Default)]
        public PayloadTypes Payload { get; set; }
    
        /// <summary>
        /// Gets or sets display time to live.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayTimeToLive", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DisplayTimeToLive { get; set; }
    
        /// <summary>
        /// Gets or sets priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "priority", Required = Newtonsoft.Json.Required.Default)]
        public Priority? Priority { get; set; }
    
        /// <summary>
        /// Gets or sets group name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupName", Required = Newtonsoft.Json.Required.Default)]
        public string GroupName { get; set; }
    
        /// <summary>
        /// Gets or sets target policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetPolicy", Required = Newtonsoft.Json.Required.Default)]
        public TargetPolicyEndpoints TargetPolicy { get; set; }
    
    }
}

